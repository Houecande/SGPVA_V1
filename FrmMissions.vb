Imports System.Data.OleDb

Public Class FrmMissions

    Private _idUser As Integer
    Private _nom As String
    Private _role As String
    Private _filtreActuel As String = "Toutes"

    Public Sub New(idUser As Integer, nom As String, role As String)
        InitializeComponent()
        _idUser = idUser
        _nom = nom
        _role = role
    End Sub

    Private Sub FrmMissions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppliquerDesign()
        ChargerVehiculesDispo()
        ChargerChauffeursDispo()
        ChargerServices()
        ChargerMissions("Toutes")
    End Sub

    ' Design
    Private Sub AppliquerDesign()
        StylerGrille(dgvMissions)
        dtpDepart.Format = DateTimePickerFormat.Custom
        dtpDepart.CustomFormat = "dd/MM/yyyy HH:mm"
        dtpRetour.Format = DateTimePickerFormat.Custom
        dtpRetour.CustomFormat = "dd/MM/yyyy HH:mm"
        dtpDepart.Value = DateTime.Now
        dtpRetour.Value = DateTime.Now.AddHours(4)
    End Sub

    ' Charger véhicules disponibles
    Private Sub ChargerVehiculesDispo()
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim da As New OleDbDataAdapter(
                    "SELECT id_vehicule, immatriculation & ' — ' & marque & ' ' & modele AS info " &
                    "FROM T_Vehicules WHERE statut = 'Disponible'", conn)
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

    ' Charger chauffeurs actifs
    Private Sub ChargerChauffeursDispo()
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim da As New OleDbDataAdapter(
                    "SELECT id_chauffeur, nom_complet & ' (' & matricule & ')' AS info " &
                    "FROM T_Chauffeurs WHERE statut = 'Actif'", conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                cboChauffeur.DisplayMember = "info"
                cboChauffeur.ValueMember = "id_chauffeur"
                cboChauffeur.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur chauffeurs : " & ex.Message)
        End Try
    End Sub

    ' Charger services
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

    ' Charger liste missions
    Private Sub ChargerMissions(filtre As String)
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim sql As String =
                    "SELECT M.numero_mission AS [N° Mission], " &
                    "M.service_demandeur AS [Service], " &
                    "V.immatriculation AS [Véhicule], " &
                    "C.nom_complet AS [Chauffeur], " &
                    "M.destination AS [Destination], " &
                    "Format(M.date_depart_prevue,'dd/mm/yyyy hh:nn') AS [Départ], " &
                    "M.statut AS [Statut] " &
                    "FROM (T_Missions AS M " &
                    "INNER JOIN T_Vehicules AS V ON M.id_vehicule = V.id_vehicule) " &
                    "INNER JOIN T_Chauffeurs AS C ON M.id_chauffeur = C.id_chauffeur"

                If filtre <> "Toutes" Then
                    sql &= " WHERE M.statut = '" & filtre & "'"
                End If
                sql &= " ORDER BY M.date_depart_prevue DESC"

                Dim da As New OleDbDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvMissions.DataSource = dt
                StylerGrille(dgvMissions)
                ColorierStatuts()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur missions : " & ex.Message)
        End Try
    End Sub

    ' Colorier colonne Statut
    Private Sub ColorierStatuts()
        For Each row As DataGridViewRow In dgvMissions.Rows
            If Not row.IsNewRow Then
                Select Case row.Cells("Statut").Value.ToString()
                    Case "En_Cours"
                        row.Cells("Statut").Style.ForeColor = Color.FromArgb(16, 185, 129)
                        row.Cells("Statut").Style.BackColor = Color.FromArgb(15, 40, 30)
                    Case "Validee"
                        row.Cells("Statut").Style.ForeColor = Color.FromArgb(150, 180, 255)
                        row.Cells("Statut").Style.BackColor = Color.FromArgb(20, 30, 60)
                    Case "En_Attente"
                        row.Cells("Statut").Style.ForeColor = Color.FromArgb(245, 158, 11)
                        row.Cells("Statut").Style.BackColor = Color.FromArgb(40, 30, 10)
                    Case "Terminee"
                        row.Cells("Statut").Style.ForeColor = Color.FromArgb(130, 155, 210)
                    Case "Annulee"
                        row.Cells("Statut").Style.ForeColor = Color.FromArgb(239, 68, 68)
                End Select
            End If
        Next
    End Sub

    ' Créer mission
    Private Sub btnCreerMission_Click(sender As Object, e As EventArgs) Handles btnCreerMission.Click
        If cboService.Text.Trim() = "" OrElse txtMotif.Text.Trim() = "" OrElse
       txtDestination.Text.Trim() = "" OrElse cboVehicule.SelectedValue Is Nothing OrElse
       cboChauffeur.SelectedValue Is Nothing Then
            MessageBox.Show("Veuillez remplir tous les champs obligatoires.",
                        "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If dtpRetour.Value <= dtpDepart.Value Then
            MessageBox.Show("La date de retour doit être après la date de départ.",
                        "Dates invalides", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' MODE MODIFICATION
        If btnCreerMission.Tag IsNot Nothing AndAlso
       btnCreerMission.Tag.ToString() = "modifier" Then
            Try
                Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                    Dim sql As String =
                    "UPDATE T_Missions SET " &
                    "service_demandeur=?, motif=?, destination=?, " &
                    "id_vehicule=?, id_chauffeur=?, " &
                    "date_depart_prevue=?, date_retour_prevue=? " &
                    "WHERE numero_mission=?"

                    Dim cmd As New OleDbCommand(sql, conn)
                    cmd.Parameters.AddWithValue("?", cboService.Text)
                    cmd.Parameters.AddWithValue("?", txtMotif.Text)
                    cmd.Parameters.AddWithValue("?", txtDestination.Text)
                    cmd.Parameters.AddWithValue("?", CInt(cboVehicule.SelectedValue))
                    cmd.Parameters.AddWithValue("?", CInt(cboChauffeur.SelectedValue))

                    ' Dates typées correctement
                    Dim pDepart1 As New OleDb.OleDbParameter("?", OleDb.OleDbType.DBTimeStamp)
                    pDepart1.Value = dtpDepart.Value
                    cmd.Parameters.Add(pDepart1)

                    Dim pRetour1 As New OleDb.OleDbParameter("?", OleDb.OleDbType.DBTimeStamp)
                    pRetour1.Value = dtpRetour.Value
                    cmd.Parameters.Add(pRetour1)

                    cmd.Parameters.AddWithValue("?", _numMissionSelectionne)
                    cmd.ExecuteNonQuery()
                End Using

                MessageBox.Show("✅ Mission modifiée avec succès !",
                            "Modifié", MessageBoxButtons.OK, MessageBoxIcon.Information)
                btnCreerMission.Text = "✅ Créer la Mission"
                btnCreerMission.Tag = Nothing
                lblFormTitre.Text = "➕ Nouvelle Mission"
                _numMissionSelectionne = ""
                txtMotif.Clear()
                txtDestination.Clear()
                ChargerMissions(_filtreActuel)

            Catch ex As Exception
                MessageBox.Show("Erreur modification : " & ex.Message,
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Exit Sub
        End If
        '── MODE AJOUT
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim numMission As String = GenererNumeroMission(conn)

                ' ── Test des valeurs avant insertion
                Dim idVeh As Integer = CInt(cboVehicule.SelectedValue)
                Dim idChauf As Integer = CInt(cboChauffeur.SelectedValue)
                Dim dateDepart As DateTime = dtpDepart.Value
                Dim dateRetour As DateTime = dtpRetour.Value

                Dim sql As String =
            "INSERT INTO T_Missions " &
            "(numero_mission, service_demandeur, motif, destination, " &
            "id_vehicule, id_chauffeur, date_depart_prevue, date_retour_prevue, statut) " &
            "VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)"

                Dim cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.Add(New OleDb.OleDbParameter("p1", OleDb.OleDbType.VarWChar) With {.Value = numMission})
                cmd.Parameters.Add(New OleDb.OleDbParameter("p2", OleDb.OleDbType.VarWChar) With {.Value = cboService.Text})
                cmd.Parameters.Add(New OleDb.OleDbParameter("p3", OleDb.OleDbType.VarWChar) With {.Value = txtMotif.Text})
                cmd.Parameters.Add(New OleDb.OleDbParameter("p4", OleDb.OleDbType.VarWChar) With {.Value = txtDestination.Text})
                cmd.Parameters.Add(New OleDb.OleDbParameter("p5", OleDb.OleDbType.Integer) With {.Value = idVeh})
                cmd.Parameters.Add(New OleDb.OleDbParameter("p6", OleDb.OleDbType.Integer) With {.Value = idChauf})
                cmd.Parameters.Add(New OleDb.OleDbParameter("p7", OleDb.OleDbType.DBTimeStamp) With {.Value = dateDepart})
                cmd.Parameters.Add(New OleDb.OleDbParameter("p8", OleDb.OleDbType.DBTimeStamp) With {.Value = dateRetour})
                cmd.Parameters.Add(New OleDb.OleDbParameter("p9", OleDb.OleDbType.VarWChar) With {.Value = "En_Attente"})

                cmd.ExecuteNonQuery()

                MessageBox.Show("✅ Mission " & numMission & " créée !",
                        "Mission créée", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtMotif.Clear()
                txtDestination.Clear()
                ChargerVehiculesDispo()
                ChargerMissions(_filtreActuel)
            End Using

        Catch ex As Exception
            MessageBox.Show("Erreur création : " & ex.Message & vbNewLine &
                    "Détail : " & ex.InnerException?.Message,
                    "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Générer numéro mission auto
    Private Function GenererNumeroMission(conn As OleDbConnection) As String
        Dim cmd As New OleDbCommand(
            "SELECT COUNT(*) FROM T_Missions", conn)
        Dim count As Integer = CInt(cmd.ExecuteScalar()) + 1
        Return "MSN-" & DateTime.Now.ToString("yyMM") & "-" & count.ToString("000")
    End Function

    ' Boutons filtres
    Private Sub btnFiltreAll_Click(sender As Object, e As EventArgs) Handles btnFiltreAll.Click
        _filtreActuel = "Toutes"
        ResetFiltres()
        btnFiltreAll.BackColor = Color.FromArgb(26, 86, 219)
        ChargerMissions("Toutes")
    End Sub

    Private Sub btnFiltreEnCours_Click(sender As Object, e As EventArgs) Handles btnFiltreEnCours.Click
        _filtreActuel = "En_Cours"
        ResetFiltres()
        btnFiltreEnCours.BackColor = Color.FromArgb(16, 185, 129)
        ChargerMissions("En_Cours")
    End Sub

    Private Sub btnFiltreAttente_Click(sender As Object, e As EventArgs) Handles btnFiltreAttente.Click
        _filtreActuel = "En_Attente"
        ResetFiltres()
        btnFiltreAttente.BackColor = Color.FromArgb(245, 158, 11)
        ChargerMissions("En_Attente")
    End Sub

    Private Sub btnFiltreTerminee_Click(sender As Object, e As EventArgs) Handles btnFiltreTerminee.Click
        _filtreActuel = "Terminee"
        ResetFiltres()
        btnFiltreTerminee.BackColor = Color.FromArgb(130, 155, 210)
        ChargerMissions("Terminee")
    End Sub

    Private Sub ResetFiltres()
        btnFiltreAll.BackColor = Color.FromArgb(25, 35, 75)
        btnFiltreEnCours.BackColor = Color.FromArgb(25, 35, 75)
        btnFiltreAttente.BackColor = Color.FromArgb(25, 35, 75)
        btnFiltreTerminee.BackColor = Color.FromArgb(25, 35, 75)
    End Sub

    ' Annuler
    Private Sub btnAnnuler_Click(sender As Object, e As EventArgs) Handles btnAnnuler.Click
        txtMotif.Clear()
        txtDestination.Clear()
        cboService.SelectedIndex = 0
        dtpDepart.Value = DateTime.Now
        dtpRetour.Value = DateTime.Now.AddHours(4)
    End Sub

    ' Retour tableau de bord
    Private Sub btnRetour_Click(sender As Object, e As EventArgs) Handles btnRetour.Click
        Dim frm As New FrmTableauBord(_idUser, _nom, _role)
        frm.Show()
        Me.Hide()
    End Sub

    ' Valider mission (double-clic)
    Private Sub dgvMissions_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMissions.CellDoubleClick
        If e.RowIndex < 0 Then Exit Sub

        Dim numMission As String = dgvMissions.Rows(e.RowIndex).Cells("N° Mission").Value.ToString()
        Dim statut As String = dgvMissions.Rows(e.RowIndex).Cells("Statut").Value.ToString()

        If statut = "En_Attente" Then
            Dim rep As DialogResult = MessageBox.Show(
                "Valider la mission " & numMission & " ?",
                "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If rep = DialogResult.Yes Then
                Try
                    Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                        Dim cmd As New OleDbCommand(
                            "UPDATE T_Missions SET statut='Validee' " &
                            "WHERE numero_mission=?", conn)
                        cmd.Parameters.AddWithValue("?", numMission)
                        cmd.ExecuteNonQuery()
                    End Using
                    ChargerMissions(_filtreActuel)
                Catch ex As Exception
                    MessageBox.Show("Erreur : " & ex.Message)
                End Try
            End If
        End If
    End Sub

    ' Style grille
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
        dgv.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb(210, 220, 240)
        dgv.BackgroundColor = Color.FromArgb(18, 25, 55)
        dgv.BorderStyle = BorderStyle.None
        dgv.GridColor = Color.FromArgb(30, 40, 80)
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
    End Sub

    ' TRANSITIONS AUTOMATIQUES MISSIONS
    Private Sub MettreAJourTransitionsMissions()
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                ' Validée depuis plus de 24h sans mouvement → En_Attente
                Dim cmdAttente As New OleDbCommand(
                    "UPDATE T_Missions SET statut='En_Attente' " &
                    "WHERE statut='Validee' " &
                    "AND date_depart_prevue > Now()", conn)
                cmdAttente.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            ' Silencieux
        End Try
    End Sub

    ' CRUD — Menu contextuel
    Private _idMissionSelectionne As Integer = -1
    Private _numMissionSelectionne As String = ""

    Private Sub dgvMissions_MouseDown(sender As Object, e As MouseEventArgs) Handles dgvMissions.MouseDown
        If e.Button = MouseButtons.Right Then
            Dim info = dgvMissions.HitTest(e.X, e.Y)
            If info.RowIndex >= 0 Then
                dgvMissions.Rows(info.RowIndex).Selected = True
                _numMissionSelectionne = dgvMissions.Rows(info.RowIndex).Cells("N° Mission").Value.ToString()
            End If
        End If
    End Sub

    Private Sub mnuModifierMission_Click(sender As Object, e As EventArgs) Handles mnuModifierMission.Click
        If _numMissionSelectionne = "" Then Exit Sub
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim cmd As New OleDbCommand(
                    "SELECT * FROM T_Missions WHERE numero_mission=?", conn)
                cmd.Parameters.AddWithValue("?", _numMissionSelectionne)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    cboService.Text = dr("service_demandeur").ToString()
                    txtMotif.Text = dr("motif").ToString()
                    txtDestination.Text = dr("destination").ToString()
                    dtpDepart.Value = CDate(dr("date_depart_prevue"))
                    dtpRetour.Value = CDate(dr("date_retour_prevue"))

                    ' Sélectionner véhicule
                    For i As Integer = 0 To cboVehicule.Items.Count - 1
                        Dim row As DataRowView = CType(cboVehicule.Items(i), DataRowView)
                        If CInt(row("id_vehicule")) = CInt(dr("id_vehicule")) Then
                            cboVehicule.SelectedIndex = i
                            Exit For
                        End If
                    Next

                    ' Sélectionner chauffeur
                    For i As Integer = 0 To cboChauffeur.Items.Count - 1
                        Dim row As DataRowView = CType(cboChauffeur.Items(i), DataRowView)
                        If CInt(row("id_chauffeur")) = CInt(dr("id_chauffeur")) Then
                            cboChauffeur.SelectedIndex = i
                            Exit For
                        End If
                    Next
                End If
                dr.Close()
            End Using
            btnCreerMission.Text = "💾 Enregistrer Modifications"
            btnCreerMission.Tag = "modifier"
            lblFormTitre.Text = "✏️ Modifier la Mission"
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        End Try
    End Sub

    Private Sub mnuMettreEnAttente_Click(sender As Object, e As EventArgs) Handles mnuMettreEnAttente.Click
        ChangerStatutMission("En_Attente", "mise En Attente")
    End Sub

    Private Sub mnuValiderMission_Click(sender As Object, e As EventArgs) Handles mnuValiderMission.Click
        ChangerStatutMission("Validee", "Validée")
    End Sub

    Private Sub mnuAnnulerMission_Click(sender As Object, e As EventArgs) Handles mnuAnnulerMission.Click
        ChangerStatutMission("Annulee", "Annulée")
    End Sub

    Private Sub ChangerStatutMission(nouveauStatut As String, libelle As String)
        If _numMissionSelectionne = "" Then Exit Sub
        Dim rep = MessageBox.Show("Mission " & libelle & " — confirmer ?",
                                  "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = DialogResult.Yes Then
            Try
                Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                    Dim cmd As New OleDbCommand(
                        "UPDATE T_Missions SET statut=? WHERE numero_mission=?", conn)
                    cmd.Parameters.AddWithValue("?", nouveauStatut)
                    cmd.Parameters.AddWithValue("?", _numMissionSelectionne)
                    cmd.ExecuteNonQuery()
                End Using
                ChargerMissions(_filtreActuel)
            Catch ex As Exception
                MessageBox.Show("Erreur : " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub mnuSupprimerMission_Click(sender As Object, e As EventArgs) Handles mnuSupprimerMission.Click
        If _numMissionSelectionne = "" Then Exit Sub
        Dim rep = MessageBox.Show("⚠️ Supprimer la mission " & _numMissionSelectionne & " ?",
                                  "Suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If rep = DialogResult.Yes Then
            Try
                Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                    Dim cmd As New OleDbCommand(
                        "DELETE FROM T_Missions WHERE numero_mission=?", conn)
                    cmd.Parameters.AddWithValue("?", _numMissionSelectionne)
                    cmd.ExecuteNonQuery()
                End Using
                _numMissionSelectionne = ""
                ChargerMissions(_filtreActuel)
                MessageBox.Show("✅ Mission supprimée.",
                                "Supprimé", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Erreur suppression : " & ex.Message)
            End Try
        End If
    End Sub
End Class