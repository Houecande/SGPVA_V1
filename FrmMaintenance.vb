Imports System.Data.OleDb

Public Class FrmMaintenance

    Private _idUser As Integer
    Private _nom As String
    Private _role As String
    Private _filtreActuel As String = "Toutes"
    Private _idMaintSelectionne As Integer = -1

    Public Sub New(idUser As Integer, nom As String, role As String)
        InitializeComponent()
        _idUser = idUser
        _nom = nom
        _role = role
    End Sub

    Private Sub FrmMaintenance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppliquerDesign()
        ChargerVehicules()
        ChargerTypes()
        ChargerPrestataires()
        MettreAJourTransitionsAuto() ' ← transitions automatiques au chargement
        ChargerMaintenance("Toutes")
    End Sub

    '─────────────────────────────────────────
    ' TRANSITIONS AUTOMATIQUES
    '─────────────────────────────────────────
    Private Sub MettreAJourTransitionsAuto()
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                ' Planifiée → En_Cours (30 min avant date_entree)
                Dim cmdEnCours As New OleDbCommand(
                    "UPDATE T_Maintenance SET statut='En_Cours' " &
                    "WHERE statut='Planifiee' " &
                    "AND date_entree <= Now() + (30/1440)", conn)
                cmdEnCours.ExecuteNonQuery()

                ' En_Cours → Terminée (après date_sortie_prevue)
                Dim cmdTerminee As New OleDbCommand(
                    "UPDATE T_Maintenance SET statut='Terminee', " &
                    "date_sortie_reelle=Now() " &
                    "WHERE statut='En_Cours' " &
                    "AND date_sortie_prevue < Now()", conn)
                cmdTerminee.ExecuteNonQuery()

                ' Remettre véhicules disponibles si maintenance terminée
                Dim cmdVeh As New OleDbCommand(
                    "UPDATE T_Vehicules SET statut='Disponible' " &
                    "WHERE id_vehicule IN (" &
                    "SELECT id_vehicule FROM T_Maintenance " &
                    "WHERE statut='Terminee' " &
                    "AND date_sortie_reelle >= Date())" &
                    "AND statut='Maintenance'", conn)
                cmdVeh.ExecuteNonQuery()

            End Using
        Catch ex As Exception
            ' Silencieux — transitions auto ne doivent pas bloquer
        End Try
    End Sub

    '─────────────────────────────────────────
    ' Design
    '─────────────────────────────────────────
    Private Sub AppliquerDesign()
        StylerGrille(dgvMaintenance)
        dtpEntree.Format = DateTimePickerFormat.Short
        dtpSortie.Format = DateTimePickerFormat.Short
        dtpEntree.Value = DateTime.Today
        dtpSortie.Value = DateTime.Today.AddDays(3)
    End Sub

    '─────────────────────────────────────────
    ' Charger données
    '─────────────────────────────────────────
    Private Sub ChargerVehicules()
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim da As New OleDbDataAdapter(
                    "SELECT id_vehicule, immatriculation & ' — ' & marque & ' ' & modele AS info " &
                    "FROM T_Vehicules ORDER BY immatriculation", conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                cboVehicule.DisplayMember = "info"
                cboVehicule.ValueMember = "id_vehicule"
                cboVehicule.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur véhicules : " & ex.Message)
        End Try
    End Sub

    Private Sub ChargerTypes()
        cboType.Items.Clear()
        cboType.Items.Add("Preventive")
        cboType.Items.Add("Corrective")
        cboType.Items.Add("Reglementaire")
        cboType.SelectedIndex = 0
    End Sub

    Private Sub ChargerPrestataires()
        cboPrestataire.Items.Clear()
        cboPrestataire.Items.Add("Atelier Interne")
        cboPrestataire.Items.Add("Garage Central")
        cboPrestataire.Items.Add("Centre Agréé")
        cboPrestataire.Items.Add("Concessionnaire")
        cboPrestataire.SelectedIndex = 0
    End Sub

    '─────────────────────────────────────────
    ' Charger liste maintenance
    '─────────────────────────────────────────
    Private Sub ChargerMaintenance(filtre As String)
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim sql As String =
                    "SELECT MT.id_maintenance AS [ID], " &
                    "V.immatriculation AS [Véhicule], " &
                    "MT.nature_intervention AS [Nature], " &
                    "MT.type_intervention AS [Type], " &
                    "MT.prestataire AS [Prestataire], " &
                    "Format(MT.date_entree,'dd/mm/yyyy') AS [Entrée], " &
                    "Format(MT.date_sortie_prevue,'dd/mm/yyyy') AS [Sortie Prévue], " &
                    "MT.cout_fcfa AS [Coût FCFA], " &
                    "MT.statut AS [Statut] " &
                    "FROM T_Maintenance AS MT " &
                    "INNER JOIN T_Vehicules AS V ON MT.id_vehicule = V.id_vehicule"

                If filtre <> "Toutes" Then
                    sql &= " WHERE MT.statut = '" & filtre & "'"
                End If
                sql &= " ORDER BY MT.date_entree DESC"

                Dim da As New OleDbDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvMaintenance.DataSource = dt
                StylerGrille(dgvMaintenance)

                If dgvMaintenance.Columns.Contains("ID") Then
                    dgvMaintenance.Columns("ID").Visible = False
                End If
                ColorierStatuts()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur maintenance : " & ex.Message)
        End Try
    End Sub

    Private Sub ColorierStatuts()
        For Each row As DataGridViewRow In dgvMaintenance.Rows
            If Not row.IsNewRow Then
                Select Case row.Cells("Statut").Value.ToString()
                    Case "En_Cours"
                        row.Cells("Statut").Style.ForeColor = Color.FromArgb(16, 185, 129)
                        row.Cells("Statut").Style.BackColor = Color.FromArgb(15, 40, 30)
                    Case "Planifiee"
                        row.Cells("Statut").Style.ForeColor = Color.FromArgb(245, 158, 11)
                        row.Cells("Statut").Style.BackColor = Color.FromArgb(40, 30, 10)
                    Case "Terminee"
                        row.Cells("Statut").Style.ForeColor = Color.FromArgb(130, 155, 210)
                End Select
                Select Case row.Cells("Type").Value.ToString()
                    Case "Preventive"
                        row.Cells("Type").Style.ForeColor = Color.FromArgb(16, 185, 129)
                    Case "Corrective"
                        row.Cells("Type").Style.ForeColor = Color.FromArgb(245, 158, 11)
                    Case "Reglementaire"
                        row.Cells("Type").Style.ForeColor = Color.FromArgb(150, 180, 255)
                End Select
            End If
        Next
    End Sub

    '─────────────────────────────────────────
    ' CRUD — Enregistrer (Ajout + Modification)
    '─────────────────────────────────────────
    Private Sub btnEnregistrer_Click(sender As Object, e As EventArgs) Handles btnEnregistrer.Click
        If cboVehicule.SelectedValue Is Nothing OrElse txtNature.Text.Trim() = "" Then
            MessageBox.Show("Véhicule et Nature sont obligatoires.",
                            "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpSortie.Value < dtpEntree.Value Then
            MessageBox.Show("La date de sortie doit être après la date d'entrée.",
                            "Dates invalides", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim cout As Integer = 0
        Integer.TryParse(txtCout.Text.Replace(" ", ""), cout)

        '── MODE MODIFICATION
        If btnEnregistrer.Tag IsNot Nothing AndAlso
           btnEnregistrer.Tag.ToString() = "modifier" Then
            Try
                Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                    Dim sql As String =
                        "UPDATE T_Maintenance SET " &
                        "id_vehicule=?, nature_intervention=?, type_intervention=?, " &
                        "prestataire=?, date_entree=?, date_sortie_prevue=?, cout_fcfa=? " &
                        "WHERE id_maintenance=?"
                    Dim cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", CInt(cboVehicule.SelectedValue))
                    cmd.Parameters.AddWithValue("?", txtNature.Text.Trim())
                    cmd.Parameters.AddWithValue("?", cboType.Text)
                    cmd.Parameters.AddWithValue("?", cboPrestataire.Text)
                    cmd.Parameters.AddWithValue("?", dtpEntree.Value.Date)
                    cmd.Parameters.AddWithValue("?", dtpSortie.Value.Date)
                    cmd.Parameters.AddWithValue("?", cout)
                    cmd.Parameters.AddWithValue("?", _idMaintSelectionne)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("✅ Intervention modifiée !",
                                "Modifié", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ResetModeFormulaire()
                ChargerMaintenance(_filtreActuel)
            Catch ex As Exception
                MessageBox.Show("Erreur modification : " & ex.Message)
            End Try
            Exit Sub
        End If

        '── MODE AJOUT
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim sql As String =
                    "INSERT INTO T_Maintenance " &
                    "(id_vehicule, nature_intervention, type_intervention, " &
                    "prestataire, date_entree, date_sortie_prevue, cout_fcfa, statut) " &
                    "VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
                Dim cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("?", CInt(cboVehicule.SelectedValue))
                cmd.Parameters.AddWithValue("?", txtNature.Text.Trim())
                cmd.Parameters.AddWithValue("?", cboType.Text)
                cmd.Parameters.AddWithValue("?", cboPrestataire.Text)
                cmd.Parameters.AddWithValue("?", dtpEntree.Value.Date)
                cmd.Parameters.AddWithValue("?", dtpSortie.Value.Date)
                cmd.Parameters.AddWithValue("?", cout)
                cmd.Parameters.AddWithValue("?", "Planifiee")
                cmd.ExecuteNonQuery()

                ' Mettre véhicule en maintenance
                Dim cmdVeh As New OleDbCommand(
                    "UPDATE T_Vehicules SET statut='Maintenance' WHERE id_vehicule=?", conn)
                cmdVeh.Parameters.AddWithValue("?", CInt(cboVehicule.SelectedValue))
                cmdVeh.ExecuteNonQuery()

                MessageBox.Show("✅ Intervention enregistrée !",
                                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ViderFormulaire()
                ChargerMaintenance(_filtreActuel)
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message,
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    '─────────────────────────────────────────
    ' CRUD — Menu contextuel (clic droit)
    '─────────────────────────────────────────
    Private Sub dgvMaintenance_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvMaintenance.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim info = dgvMaintenance.HitTest(e.X, e.Y)
            If info.RowIndex >= 0 Then
                dgvMaintenance.Rows(info.RowIndex).Selected = True
                _idMaintSelectionne = CInt(dgvMaintenance.Rows(info.RowIndex).Cells("ID").Value)
            End If
        End If
    End Sub

    Private Sub mnuModifier_Click(sender As Object, e As EventArgs) Handles mnuModifier.Click
        If _idMaintSelectionne = -1 Then Exit Sub
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim cmd As New OleDbCommand(
                    "SELECT * FROM T_Maintenance WHERE id_maintenance=?", conn)
                cmd.Parameters.AddWithValue("?", _idMaintSelectionne)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    ' Sélectionner le bon véhicule
                    For i As Integer = 0 To cboVehicule.Items.Count - 1
                        Dim row As DataRowView = CType(cboVehicule.Items(i), DataRowView)
                        If CInt(row("id_vehicule")) = CInt(dr("id_vehicule")) Then
                            cboVehicule.SelectedIndex = i
                            Exit For
                        End If
                    Next
                    txtNature.Text = dr("nature_intervention").ToString()
                    cboType.Text = dr("type_intervention").ToString()
                    cboPrestataire.Text = dr("prestataire").ToString()
                    dtpEntree.Value = CDate(dr("date_entree"))
                    dtpSortie.Value = CDate(dr("date_sortie_prevue"))
                    If Not IsDBNull(dr("cout_fcfa")) Then
                        txtCout.Text = dr("cout_fcfa").ToString()
                    End If
                End If
                dr.Close()
            End Using
            btnEnregistrer.Text = "💾 Enregistrer Modifications"
            btnEnregistrer.Tag = "modifier"
            lblFormTitre.Text = "✏️ Modifier l'Intervention"
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        End Try
    End Sub

    Private Sub mnuCloturerManuellement_Click(sender As Object, e As EventArgs) Handles mnuCloturerManuellement.Click
        If _idMaintSelectionne = -1 Then Exit Sub
        Dim rep = MessageBox.Show("Clôturer manuellement cette intervention ?",
                                  "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = DialogResult.Yes Then
            Try
                Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                    Dim cmd As New OleDbCommand(
                        "UPDATE T_Maintenance SET statut='Terminee', " &
                        "date_sortie_reelle=Now() WHERE id_maintenance=?", conn)
                    cmd.Parameters.AddWithValue("?", _idMaintSelectionne)
                    cmd.ExecuteNonQuery()

                    ' Récupérer id_vehicule
                    Dim cmdIdVeh As New OleDbCommand(
                        "SELECT id_vehicule FROM T_Maintenance WHERE id_maintenance=?", conn)
                    cmdIdVeh.Parameters.AddWithValue("?", _idMaintSelectionne)
                    Dim idVeh As Integer = CInt(cmdIdVeh.ExecuteScalar())

                    ' Remettre disponible
                    Dim cmdVeh As New OleDbCommand(
                        "UPDATE T_Vehicules SET statut='Disponible' WHERE id_vehicule=?", conn)
                    cmdVeh.Parameters.AddWithValue("?", idVeh)
                    cmdVeh.ExecuteNonQuery()
                End Using
                MessageBox.Show("✅ Intervention clôturée — véhicule remis Disponible !",
                                "Clôturé", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ChargerMaintenance(_filtreActuel)
            Catch ex As Exception
                MessageBox.Show("Erreur : " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub mnuSupprimer_Click(sender As Object, e As EventArgs) Handles mnuSupprimer.Click
        If _idMaintSelectionne = -1 Then Exit Sub
        Dim rep = MessageBox.Show("⚠️ Supprimer définitivement cette intervention ?",
                                  "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If rep = DialogResult.Yes Then
            Try
                Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                    Dim cmd As New OleDbCommand(
                        "DELETE FROM T_Maintenance WHERE id_maintenance=?", conn)
                    cmd.Parameters.AddWithValue("?", _idMaintSelectionne)
                    cmd.ExecuteNonQuery()
                End Using
                _idMaintSelectionne = -1
                ChargerMaintenance(_filtreActuel)
                MessageBox.Show("✅ Intervention supprimée.",
                                "Supprimé", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Erreur suppression : " & ex.Message)
            End Try
        End If
    End Sub

    '─────────────────────────────────────────
    ' Helpers
    '─────────────────────────────────────────
    Private Sub ResetModeFormulaire()
        btnEnregistrer.Text = "✅ Enregistrer"
        btnEnregistrer.Tag = Nothing
        lblFormTitre.Text = "➕ Nouvelle Intervention"
        _idMaintSelectionne = -1
        ViderFormulaire()
    End Sub

    Private Sub ViderFormulaire()
        txtNature.Clear()
        txtCout.Clear()
        cboType.SelectedIndex = 0
        cboPrestataire.SelectedIndex = 0
        dtpEntree.Value = DateTime.Today
        dtpSortie.Value = DateTime.Today.AddDays(3)
    End Sub

    '─────────────────────────────────────────
    ' Filtres
    '─────────────────────────────────────────
    Private Sub btnFiltreAll_Click(sender As Object, e As EventArgs) Handles btnFiltreAll.Click
        _filtreActuel = "Toutes"
        ResetFiltres()
        btnFiltreAll.BackColor = Color.FromArgb(26, 86, 219)
        ChargerMaintenance("Toutes")
    End Sub

    Private Sub btnFiltrePlanifiee_Click(sender As Object, e As EventArgs) Handles btnFiltrePlanifiee.Click
        _filtreActuel = "Planifiee"
        ResetFiltres()
        btnFiltrePlanifiee.BackColor = Color.FromArgb(245, 158, 11)
        ChargerMaintenance("Planifiee")
    End Sub

    Private Sub btnFiltreEnCours_Click(sender As Object, e As EventArgs) Handles btnFiltreEnCours.Click
        _filtreActuel = "En_Cours"
        ResetFiltres()
        btnFiltreEnCours.BackColor = Color.FromArgb(16, 185, 129)
        ChargerMaintenance("En_Cours")
    End Sub

    Private Sub btnFiltreTerminee_Click(sender As Object, e As EventArgs) Handles btnFiltreTerminee.Click
        _filtreActuel = "Terminee"
        ResetFiltres()
        btnFiltreTerminee.BackColor = Color.FromArgb(130, 155, 210)
        ChargerMaintenance("Terminee")
    End Sub

    Private Sub ResetFiltres()
        btnFiltreAll.BackColor = Color.FromArgb(25, 35, 75)
        btnFiltrePlanifiee.BackColor = Color.FromArgb(25, 35, 75)
        btnFiltreEnCours.BackColor = Color.FromArgb(25, 35, 75)
        btnFiltreTerminee.BackColor = Color.FromArgb(25, 35, 75)
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        ResetModeFormulaire()
    End Sub

    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Me.Close()
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

End Class