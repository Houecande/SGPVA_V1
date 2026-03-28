Imports System.Data.OleDb

Public Class FrmChauffeurs

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

    Private Sub FrmChauffeurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppliquerDesign()
        ChargerCategories()
        ChargerServices()
        ChargerChauffeurs("Tous")
    End Sub

    Private Sub AppliquerDesign()
        StylerGrille(dgvChauffeurs)
        dtpExpPermis.Format = DateTimePickerFormat.Short
        dtpExpPermis.Value = DateTime.Today.AddYears(3)
    End Sub

    Private Sub ChargerCategories()
        cboCatPermis.Items.Clear()
        cboCatPermis.Items.Add("B")
        cboCatPermis.Items.Add("B, C")
        cboCatPermis.Items.Add("B, D")
        cboCatPermis.Items.Add("B, C, D")
        cboCatPermis.Items.Add("C")
        cboCatPermis.Items.Add("D")
        cboCatPermis.SelectedIndex = 0
    End Sub

    Private Sub ChargerServices()
        cboService.Items.Clear()
        cboService.Items.Add("Direction des Finances")
        cboService.Items.Add("Cabinet du Ministre")
        cboService.Items.Add("Service Logistique")
        cboService.Items.Add("Direction des Ressources Humaines")
        cboService.Items.Add("Service Courrier")
        cboService.Items.Add("Direction Générale")
        cboService.SelectedIndex = 0
    End Sub

    Private Sub ChargerChauffeurs(filtre As String)
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim sql As String =
                    "SELECT id_chauffeur AS [ID], " &
                    "matricule AS [Matricule], " &
                    "nom_complet AS [Nom & Prénom], " &
                    "telephone AS [Téléphone], " &
                    "numero_permis AS [N° Permis], " &
                    "categorie_permis AS [Catégorie], " &
                    "Format(date_expiration_permis,'dd/mm/yyyy') AS [Exp Permis], " &
                    "service AS [Service], " &
                    "statut AS [Statut] " &
                    "FROM T_Chauffeurs"

                If filtre = "Actif" Then
                    sql &= " WHERE statut = 'Actif'"
                ElseIf filtre = "Conge" Then
                    sql &= " WHERE statut = 'Conge'"
                End If
                sql &= " ORDER BY nom_complet"

                Dim da As New OleDbDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvChauffeurs.DataSource = dt
                StylerGrille(dgvChauffeurs)

                If dgvChauffeurs.Columns.Contains("ID") Then
                    dgvChauffeurs.Columns("ID").Visible = False
                End If

                ColorierStatuts()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur chauffeurs : " & ex.Message)
        End Try
    End Sub

    Private Sub ColorierStatuts()
        For Each row As DataGridViewRow In dgvChauffeurs.Rows
            If Not row.IsNewRow Then
                Select Case row.Cells("Statut").Value.ToString()
                    Case "Actif"
                        row.Cells("Statut").Style.ForeColor = Color.FromArgb(16, 185, 129)
                    Case "Conge"
                        row.Cells("Statut").Style.ForeColor = Color.FromArgb(245, 158, 11)
                    Case "Suspendu"
                        row.Cells("Statut").Style.ForeColor = Color.FromArgb(239, 68, 68)
                End Select

                ' Alerte permis expiré
                Try
                    If Not IsDBNull(row.Cells("Exp Permis").Value) Then
                        Dim dPerm As DateTime = CDate(row.Cells("Exp Permis").Value)
                        If dPerm < DateTime.Today Then
                            row.Cells("Exp. Permis").Style.ForeColor = Color.FromArgb(239, 68, 68)
                            row.Cells("Exp. Permis").Style.BackColor = Color.FromArgb(40, 15, 15)
                        ElseIf dPerm <= DateTime.Today.AddDays(30) Then
                            row.Cells("Exp. Permis").Style.ForeColor = Color.FromArgb(245, 158, 11)
                        End If
                    End If
                Catch
                End Try
            End If
        Next
    End Sub

    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        If txtMatricule.Text.Trim() = "" OrElse txtNom.Text.Trim() = "" OrElse
       txtPermis.Text.Trim() = "" Then
            MessageBox.Show("Matricule, Nom et N° Permis sont obligatoires.",
                        "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' ── Mode Modification
        If btnAjouter.Tag IsNot Nothing AndAlso btnAjouter.Tag.ToString() = "modifier" Then
            Try
                Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                    Dim sql As String =
                    "UPDATE T_Chauffeurs SET " &
                    "matricule=?, nom_complet=?, telephone=?, numero_permis=?, " &
                    "categorie_permis=?, date_expiration_permis=?, service=? " &
                    "WHERE id_chauffeur=?"
                    Dim cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", txtMatricule.Text.Trim())
                    cmd.Parameters.AddWithValue("?", txtNom.Text.Trim())
                    cmd.Parameters.AddWithValue("?", txtTelephone.Text.Trim())
                    cmd.Parameters.AddWithValue("?", txtPermis.Text.Trim())
                    cmd.Parameters.AddWithValue("?", cboCatPermis.Text)
                    cmd.Parameters.AddWithValue("?", dtpExpPermis.Value.Date)
                    cmd.Parameters.AddWithValue("?", cboService.Text)
                    cmd.Parameters.AddWithValue("?", _idChauffeurSelectionne)
                    cmd.ExecuteNonQuery()
                End Using
                MessageBox.Show("✅ Chauffeur modifié avec succès !",
                            "Modifié", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ' Réinitialiser mode
                btnAjouter.Text = "✅ Ajouter le Chauffeur"
                btnAjouter.Tag = Nothing
                lblFormTitre.Text = "➕ Ajouter un Chauffeur"
                _idChauffeurSelectionne = -1
                ViderFormulaire()
                ChargerChauffeurs(_filtreActuel)
            Catch ex As Exception
                MessageBox.Show("Erreur modification : " & ex.Message)
            End Try
            Exit Sub
        End If

        ' ── Mode Ajout (code existant)
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim sql As String =
                "INSERT INTO T_Chauffeurs " &
                "(matricule, nom_complet, telephone, numero_permis, " &
                "categorie_permis, date_expiration_permis, service, statut) " &
                "VALUES (?, ?, ?, ?, ?, ?, ?, ?)"
                Dim cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("?", txtMatricule.Text.Trim())
                cmd.Parameters.AddWithValue("?", txtNom.Text.Trim())
                cmd.Parameters.AddWithValue("?", txtTelephone.Text.Trim())
                cmd.Parameters.AddWithValue("?", txtPermis.Text.Trim())
                cmd.Parameters.AddWithValue("?", cboCatPermis.Text)
                cmd.Parameters.AddWithValue("?", dtpExpPermis.Value.Date)
                cmd.Parameters.AddWithValue("?", cboService.Text)
                cmd.Parameters.AddWithValue("?", "Actif")
                cmd.ExecuteNonQuery()
                MessageBox.Show("✅ Chauffeur " & txtNom.Text & " ajouté !",
                    "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ViderFormulaire()
                ChargerChauffeurs(_filtreActuel)
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        End Try
    End Sub

    Private Sub ViderFormulaire()
        txtMatricule.Clear() : txtNom.Clear()
        txtTelephone.Clear() : txtPermis.Clear()
        cboCatPermis.SelectedIndex = 0
        cboService.SelectedIndex = 0
        dtpExpPermis.Value = DateTime.Today.AddYears(3)
    End Sub

    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        ViderFormulaire()
    End Sub

    Private Sub btnFiltreAll_Click(sender As Object, e As EventArgs) Handles btnFiltreAll.Click
        _filtreActuel = "Tous"
        ResetFiltres() : btnFiltreAll.BackColor = Color.FromArgb(26, 86, 219)
        ChargerChauffeurs("Tous")
    End Sub

    Private Sub btnFiltreActif_Click(sender As Object, e As EventArgs) Handles btnFiltreActif.Click
        _filtreActuel = "Actif"
        ResetFiltres() : btnFiltreActif.BackColor = Color.FromArgb(16, 185, 129)
        ChargerChauffeurs("Actif")
    End Sub

    Private Sub btnFiltreConge_Click(sender As Object, e As EventArgs) Handles btnFiltreConge.Click
        _filtreActuel = "Conge"
        ResetFiltres() : btnFiltreConge.BackColor = Color.FromArgb(245, 158, 11)
        ChargerChauffeurs("Conge")
    End Sub

    Private Sub btnFiltreSuspendu_Click(sender As Object, e As EventArgs) Handles btnFiltreSuspendu.Click
        _filtreActuel = "Suspendu"
        ResetFiltres() : btnFiltreSuspendu.BackColor = Color.FromArgb(239, 68, 68)
        ChargerChauffeurs("Suspendu")
    End Sub

    Private Sub ResetFiltres()
        For Each btn As Button In {btnFiltreAll, btnFiltreActif, btnFiltreConge}
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

    '─────────────────────────────────────────
    ' Clic droit — menu contextuel
    '─────────────────────────────────────────
    Private _idChauffeurSelectionne As Integer = -1

    Private Sub dgvChauffeurs_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvChauffeurs.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim info = dgvChauffeurs.HitTest(e.X, e.Y)
            If info.RowIndex >= 0 Then
                dgvChauffeurs.Rows(info.RowIndex).Selected = True
                _idChauffeurSelectionne = CInt(dgvChauffeurs.Rows(info.RowIndex).Cells("ID").Value)
            End If
        End If
    End Sub

    '─────────────────────────────────────────
    ' Modifier
    '─────────────────────────────────────────
    Private Sub mnuModifier_Click(sender As Object, e As EventArgs) Handles mnuModifier.Click
        If _idChauffeurSelectionne = -1 Then Exit Sub

        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim cmd As New OleDbCommand(
                    "SELECT * FROM T_Chauffeurs WHERE id_chauffeur=?", conn)
                cmd.Parameters.AddWithValue("?", _idChauffeurSelectionne)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()

                If dr.Read() Then
                    ' Remplir le formulaire avec les données existantes
                    txtMatricule.Text = dr("matricule").ToString()
                    txtNom.Text = dr("nom_complet").ToString()
                    txtTelephone.Text = dr("telephone").ToString()
                    txtPermis.Text = dr("numero_permis").ToString()
                    cboCatPermis.Text = dr("categorie_permis").ToString()
                    dtpExpPermis.Value = CDate(dr("date_expiration_permis"))
                    cboService.Text = dr("service").ToString()
                End If
                dr.Close()
            End Using

            ' Changer le bouton en mode Modification
            btnAjouter.Text = "💾 Enregistrer les Modifications"
            btnAjouter.Tag = "modifier"
            lblFormTitre.Text = "✏️ Modifier le Chauffeur"

        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        End Try
    End Sub

    '─────────────────────────────────────────
    ' Changer statut
    '─────────────────────────────────────────
    Private Sub mnuConge_Click(sender As Object, e As EventArgs) Handles mnuConge.Click
        ChangerStatutChauffeur("Conge", "mis en Congé")
    End Sub

    Private Sub mnuActif_Click(sender As Object, e As EventArgs) Handles mnuActif.Click
        ChangerStatutChauffeur("Actif", "remis Actif")
    End Sub

    Private Sub mnuSuspendre_Click(sender As Object, e As EventArgs) Handles mnuSuspendre.Click
        ChangerStatutChauffeur("Suspendu", "Suspendu")
    End Sub

    Private Sub ChangerStatutChauffeur(nouveauStatut As String, libelle As String)
        If _idChauffeurSelectionne = -1 Then Exit Sub
        Dim rep = MessageBox.Show("Confirmer : chauffeur " & libelle & " ?",
                                  "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = DialogResult.Yes Then
            Try
                Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                    Dim cmd As New OleDbCommand(
                        "UPDATE T_Chauffeurs SET statut=? WHERE id_chauffeur=?", conn)
                    cmd.Parameters.AddWithValue("?", nouveauStatut)
                    cmd.Parameters.AddWithValue("?", _idChauffeurSelectionne)
                    cmd.ExecuteNonQuery()
                End Using
                ChargerChauffeurs(_filtreActuel)
            Catch ex As Exception
                MessageBox.Show("Erreur : " & ex.Message)
            End Try
        End If
    End Sub

    '─────────────────────────────────────────
    ' Supprimer
    '─────────────────────────────────────────
    Private Sub mnuSupprimer_Click(sender As Object, e As EventArgs) Handles mnuSupprimer.Click
        If _idChauffeurSelectionne = -1 Then Exit Sub
        Dim rep = MessageBox.Show("⚠️ Supprimer définitivement ce chauffeur ?",
                                  "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If rep = DialogResult.Yes Then
            Try
                Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                    Dim cmd As New OleDbCommand(
                        "DELETE FROM T_Chauffeurs WHERE id_chauffeur=?", conn)
                    cmd.Parameters.AddWithValue("?", _idChauffeurSelectionne)
                    cmd.ExecuteNonQuery()
                End Using
                _idChauffeurSelectionne = -1
                ChargerChauffeurs(_filtreActuel)
                MessageBox.Show("✅ Chauffeur supprimé.", "Supprimé",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Erreur suppression : " & ex.Message)
            End Try
        End If
    End Sub

End Class