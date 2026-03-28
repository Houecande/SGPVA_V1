Imports System.Data.OleDb

Public Class FrmVehicules

    Private _idUser As Integer
    Private _nom As String
    Private _role As String
    Private _filtreActuel As String = "Tous"

    Public Sub New(idUser As Integer, nom As String, role As String)
        InitializeComponent()
        _idUser = idUser
        _nom = nom
        _role = role
    End Sub

    Private Sub FrmVehicules_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppliquerDesign()
        ChargerTypes()
        ChargerVehicules("Tous")
    End Sub

    Private Sub AppliquerDesign()
        StylerGrille(dgvVehicules)
        dtpAssurance.Format = DateTimePickerFormat.Short
        dtpVisite.Format = DateTimePickerFormat.Short
        dtpAssurance.Value = DateTime.Today.AddYears(1)
        dtpVisite.Value = DateTime.Today.AddYears(1)
    End Sub

    Private Sub ChargerTypes()
        cboType.Items.Clear()
        cboType.Items.Add("4x4")
        cboType.Items.Add("Berline")
        cboType.Items.Add("Break")
        cboType.Items.Add("Minibus")
        cboType.Items.Add("Pick-up")
        cboType.Items.Add("Camionnette")
        cboType.SelectedIndex = 0

        cboCarburant.Items.Clear()
        cboCarburant.Items.Add("Diesel")
        cboCarburant.Items.Add("Essence")
        cboCarburant.Items.Add("Electrique")
        cboCarburant.SelectedIndex = 0
    End Sub

    Private Sub ChargerVehicules(filtre As String)
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim sql As String =
                    "SELECT id_vehicule AS [ID], " &
                    "immatriculation AS [Immatriculation], " &
                    "marque AS [Marque], modele AS [Modèle], " &
                    "type_vehicule AS [Type], carburant AS [Carburant], " &
                    "nb_places AS [Places], km_actuel AS [Km Actuel], " &
                    "statut AS [Statut], " &
                    "Format(date_assurance,'dd/mm/yyyy') AS [Assurance], " &
                    "Format(date_visite_technique,'dd/mm/yyyy') AS [Visite Tech] " &
                    "FROM T_Vehicules"

                If filtre <> "Tous" Then
                    sql &= " WHERE statut = '" & filtre & "'"
                End If
                sql &= " ORDER BY immatriculation"

                Dim da As New OleDbDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvVehicules.DataSource = dt
                StylerGrille(dgvVehicules)

                If dgvVehicules.Columns.Contains("ID") Then
                    dgvVehicules.Columns("ID").Visible = False
                End If

                ColorierStatuts()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur véhicules : " & ex.Message)
        End Try
    End Sub

    Private Sub ColorierStatuts()
        For Each row As DataGridViewRow In dgvVehicules.Rows
            If Not row.IsNewRow Then
                Select Case row.Cells("Statut").Value.ToString()
                    Case "Disponible"
                        row.Cells("Statut").Style.ForeColor = Color.FromArgb(16, 185, 129)
                    Case "En_Mission"
                        row.Cells("Statut").Style.ForeColor = Color.FromArgb(150, 180, 255)
                    Case "Maintenance"
                        row.Cells("Statut").Style.ForeColor = Color.FromArgb(245, 158, 11)
                End Select

                ' Alertes dates expirées
                Try
                    If Not IsDBNull(row.Cells("Visite Tech").Value) Then
                        Dim dAss As DateTime = CDate(row.Cells("Assurance").Value)
                        If dAss < DateTime.Today Then
                            row.Cells("Assurance").Style.ForeColor = Color.FromArgb(239, 68, 68)
                        End If
                    End If
                Catch
                End Try
            End If
        Next
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        ' Validation
        If txtImmat.Text.Trim() = "" OrElse txtMarque.Text.Trim() = "" OrElse
       txtModele.Text.Trim() = "" Then
            MessageBox.Show("Immatriculation, Marque et Modèle sont obligatoires.",
                        "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim km As Integer = 0
        Integer.TryParse(txtKm.Text.Replace(" ", ""), km)
        Dim places As Integer = 5
        Integer.TryParse(txtPlaces.Text, places)

        ' MODE MODIFICATION
        If btnAjouter.Tag IsNot Nothing AndAlso btnAjouter.Tag.ToString() = "modifier" Then
            Try
                Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                    Dim sql As String =
                    "UPDATE T_Vehicules SET " &
                    "immatriculation=?, marque=?, modele=?, type_vehicule=?, " &
                    "carburant=?, nb_places=?, km_actuel=?, " &
                    "date_assurance=?, date_visite_technique=? " &
                    "WHERE id_vehicule=?"

                    Dim cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", txtImmat.Text.Trim().ToUpper())
                    cmd.Parameters.AddWithValue("?", txtMarque.Text.Trim())
                    cmd.Parameters.AddWithValue("?", txtModele.Text.Trim())
                    cmd.Parameters.AddWithValue("?", cboType.Text)
                    cmd.Parameters.AddWithValue("?", cboCarburant.Text)
                    cmd.Parameters.AddWithValue("?", places)
                    cmd.Parameters.AddWithValue("?", km)
                    cmd.Parameters.AddWithValue("?", dtpAssurance.Value.Date)
                    cmd.Parameters.AddWithValue("?", dtpVisite.Value.Date)
                    cmd.Parameters.AddWithValue("?", _idVehiculeSelectionne)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("✅ Véhicule modifié avec succès !",
                            "Modifié", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Réinitialiser mode
                btnAjouter.Text = "✅ Ajouter le Véhicule"
                btnAjouter.Tag = Nothing
                lblFormTitre.Text = "➕ Ajouter un Véhicule"
                _idVehiculeSelectionne = -1
                ViderFormulaire()
                ChargerVehicules(_filtreActuel)

            Catch ex As Exception
                MessageBox.Show("Erreur modification : " & ex.Message,
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Exit Sub
        End If

        ' MODE AJOUT
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim sql As String =
                "INSERT INTO T_Vehicules " &
                "(immatriculation, marque, modele, type_vehicule, carburant, " &
                "nb_places, km_actuel, statut, date_assurance, date_visite_technique) " &
                "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)"

                Dim cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("?", txtImmat.Text.Trim().ToUpper())
                cmd.Parameters.AddWithValue("?", txtMarque.Text.Trim())
                cmd.Parameters.AddWithValue("?", txtModele.Text.Trim())
                cmd.Parameters.AddWithValue("?", cboType.Text)
                cmd.Parameters.AddWithValue("?", cboCarburant.Text)
                cmd.Parameters.AddWithValue("?", places)
                cmd.Parameters.AddWithValue("?", km)
                cmd.Parameters.AddWithValue("?", "Disponible")
                cmd.Parameters.AddWithValue("?", dtpAssurance.Value.Date)
                cmd.Parameters.AddWithValue("?", dtpVisite.Value.Date)
                cmd.ExecuteNonQuery()

                MessageBox.Show("✅ Véhicule " & txtImmat.Text.ToUpper() & " ajouté !",
                            "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ViderFormulaire()
                ChargerVehicules(_filtreActuel)
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ViderFormulaire()
        txtImmat.Clear() : txtMarque.Clear()
        txtModele.Clear() : txtKm.Clear() : txtPlaces.Clear()
        cboType.SelectedIndex = 0
        cboCarburant.SelectedIndex = 0
        dtpAssurance.Value = DateTime.Today.AddYears(1)
        dtpVisite.Value = DateTime.Today.AddYears(1)
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        ViderFormulaire()
    End Sub

    Private Sub btnFiltreAll_Click(sender As Object, e As EventArgs) Handles btnFiltreAll.Click
        _filtreActuel = "Tous"
        ResetFiltres() : btnFiltreAll.BackColor = Color.FromArgb(26, 86, 219)
        ChargerVehicules("Tous")
    End Sub

    Private Sub btnFiltreDispo_Click(sender As Object, e As EventArgs) Handles btnFiltreDispo.Click
        _filtreActuel = "Disponible"
        ResetFiltres() : btnFiltreDispo.BackColor = Color.FromArgb(16, 185, 129)
        ChargerVehicules("Disponible")
    End Sub

    Private Sub btnFiltreMission_Click(sender As Object, e As EventArgs) Handles btnFiltreMission.Click
        _filtreActuel = "En_Mission"
        ResetFiltres() : btnFiltreMission.BackColor = Color.FromArgb(150, 180, 255)
        ChargerVehicules("En_Mission")
    End Sub

    Private Sub btnFiltreMaint_Click(sender As Object, e As EventArgs) Handles btnFiltreMaint.Click
        _filtreActuel = "Maintenance"
        ResetFiltres() : btnFiltreMaint.BackColor = Color.FromArgb(245, 158, 11)
        ChargerVehicules("Maintenance")
    End Sub

    Private Sub ResetFiltres()
        For Each btn As Button In {btnFiltreAll, btnFiltreDispo, btnFiltreMission, btnFiltreMaint}
            btn.BackColor = Color.FromArgb(25, 35, 75)
        Next
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Dim frm As New FrmTableauBord(_idUser, _nom, _role)
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub StylerGrille(dgv As DataGridView)
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 86, 219)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        dgv.ColumnHeadersHeight = 38
        dgv.RowTemplate.Height = 34
        dgv.DefaultCellStyle.BackColor = Color.FromArgb(18, 25, 55)
        dgv.DefaultCellStyle.ForeColor = Color.FromArgb(210, 220, 240)
        dgv.DefaultCellStyle.Font = New Font("Segoe UI", 9)
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(26, 86, 219)
        dgv.DefaultCellStyle.SelectionForeColor = Color.White
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(22, 30, 65)
        dgv.BackgroundColor = Color.FromArgb(18, 25, 55)
        dgv.BorderStyle = BorderStyle.None
        dgv.GridColor = Color.FromArgb(30, 40, 80)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
    End Sub

    Private _idVehiculeSelectionne As Integer = -1

    Private Sub dgvVehicules_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvVehicules.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim info = dgvVehicules.HitTest(e.X, e.Y)
            If info.RowIndex >= 0 Then
                dgvVehicules.Rows(info.RowIndex).Selected = True
                _idVehiculeSelectionne = CInt(dgvVehicules.Rows(info.RowIndex).Cells("ID").Value)
            End If
        End If
    End Sub

    Private Sub mnuDisponible_Click(sender As Object, e As EventArgs)
        ChangerStatutVehicule("Disponible")
    End Sub

    Private Sub mnuEnMission_Click(sender As Object, e As EventArgs)
        ChangerStatutVehicule("En_Mission")
    End Sub

    Private Sub mnuEnMaintenance_Click(sender As Object, e As EventArgs)
        ChangerStatutVehicule("Maintenance")
    End Sub

    Private Sub ChangerStatutVehicule(nouveauStatut As String)
        If _idVehiculeSelectionne = -1 Then Exit Sub
        Dim rep = MessageBox.Show("Changer le statut en : " & nouveauStatut & " ?",
                                  "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = DialogResult.Yes Then
            Try
                Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                    Dim cmd As New OleDbCommand(
                        "UPDATE T_Vehicules SET statut=? WHERE id_vehicule=?", conn)
                    cmd.Parameters.AddWithValue("?", nouveauStatut)
                    cmd.Parameters.AddWithValue("?", _idVehiculeSelectionne)
                    cmd.ExecuteNonQuery()
                End Using
                ChargerVehicules(_filtreActuel)
            Catch ex As Exception
                MessageBox.Show("Erreur : " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub mnuModifierVeh_Click(sender As Object, e As EventArgs) Handles mnuModifierVeh.Click
        If _idVehiculeSelectionne = -1 Then Exit Sub
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim cmd As New OleDbCommand(
                    "SELECT * FROM T_Vehicules WHERE id_vehicule=?", conn)
                cmd.Parameters.AddWithValue("?", _idVehiculeSelectionne)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    txtImmat.Text = dr("immatriculation").ToString()
                    txtMarque.Text = dr("marque").ToString()
                    txtModele.Text = dr("modele").ToString()
                    cboType.Text = dr("type_vehicule").ToString()
                    cboCarburant.Text = dr("carburant").ToString()
                    txtPlaces.Text = dr("nb_places").ToString()
                    txtKm.Text = dr("km_actuel").ToString()
                    If Not IsDBNull(dr("date_assurance")) Then
                        dtpAssurance.Value = CDate(dr("date_assurance"))
                    End If
                    If Not IsDBNull(dr("date_visite_technique")) Then
                        dtpVisite.Value = CDate(dr("date_visite_technique"))
                    End If
                End If
                dr.Close()
            End Using
            btnAjouter.Text = "💾 Enregistrer Modifications"
            btnAjouter.Tag = "modifier"
            lblFormTitre.Text = "✏️ Modifier le Véhicule"
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        End Try
    End Sub

    Private Sub mnuSupprimerVeh_Click(sender As Object, e As EventArgs) Handles mnuSupprimerVeh.Click
        If _idVehiculeSelectionne = -1 Then Exit Sub
        Dim rep = MessageBox.Show("⚠️ Supprimer définitivement ce véhicule ?",
                                  "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If rep = DialogResult.Yes Then
            Try
                Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                    Dim cmd As New OleDbCommand(
                        "DELETE FROM T_Vehicules WHERE id_vehicule=?", conn)
                    cmd.Parameters.AddWithValue("?", _idVehiculeSelectionne)
                    cmd.ExecuteNonQuery()
                End Using
                _idVehiculeSelectionne = -1
                ChargerVehicules(_filtreActuel)
                MessageBox.Show("✅ Véhicule supprimé.", "Supprimé",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Erreur suppression : " & ex.Message)
            End Try
        End If
    End Sub
End Class