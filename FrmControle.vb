Imports System.Data.OleDb

Public Class FrmControle

    Private _idUser As Integer
    Private _nom As String
    Private _role As String
    Private _typeMouvement As String = "SortieMission"

    Public Sub New(idUser As Integer, nom As String, role As String)
        InitializeComponent()
        _idUser = idUser
        _nom = nom
        _role = role
    End Sub

    Private Sub FrmControle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblAgent.Text = "Agent : " & _nom
        AppliquerDesign()
        ChargerVehicules()
        ChargerChauffeurs()
        ChargerJournal()
    End Sub

    Private Sub AppliquerDesign()
        StylerGrille(dgvJournal)
        ResetVerifications()
        ActiverMode("SortieMission")
    End Sub

    ' Modes de mouvement
    Private Sub ActiverMode(mode As String)
        _typeMouvement = mode
        ResetBoutonsModes()

        Select Case mode
            Case "SortieMission"
                btnSortieMission.BackColor = Color.FromArgb(239, 68, 68)
                btnSortieMission.ForeColor = Color.White
                lblFormTitre.Text = "📋 Enregistrement — Sortie Mission"
                txtNumMission.Enabled = True
                ChargerVehicules()

            Case "SortieMaintenance"
                btnSortieMaint.BackColor = Color.FromArgb(245, 158, 11)
                btnSortieMaint.ForeColor = Color.White
                lblFormTitre.Text = "🔧 Enregistrement — Sortie Maintenance"
                txtNumMission.Enabled = False
                txtNumMission.Text = "— Maintenance —"
                ChargerVehicules()

            Case "RetourMission"
                btnRetourMission.BackColor = Color.FromArgb(16, 185, 129)
                btnRetourMission.ForeColor = Color.White
                lblFormTitre.Text = "🟢 Enregistrement — Retour Mission"
                txtNumMission.Enabled = True
                ChargerVehicules()

            Case "RetourMaintenance"
                btnRetourMaint.BackColor = Color.FromArgb(26, 86, 219)
                btnRetourMaint.ForeColor = Color.White
                lblFormTitre.Text = "🔵 Enregistrement — Retour Maintenance"
                txtNumMission.Enabled = False
                txtNumMission.Text = "— Maintenance —"
                ChargerVehicules()
        End Select

        ResetVerifications()
    End Sub

    Private Sub ResetBoutonsModes()
        btnSortieMission.BackColor = Color.FromArgb(25, 35, 75)
        btnSortieMaint.BackColor = Color.FromArgb(25, 35, 75)
        btnRetourMission.BackColor = Color.FromArgb(25, 35, 75)
        btnRetourMaint.BackColor = Color.FromArgb(25, 35, 75)
        For Each btn As Button In {btnSortieMission, btnSortieMaint,
                                    btnRetourMission, btnRetourMaint}
            btn.ForeColor = Color.FromArgb(130, 155, 210)
        Next
    End Sub

    Private Sub btnSortieMission_Click(sender As Object, e As EventArgs) Handles btnSortieMission.Click
        ActiverMode("SortieMission")
    End Sub

    Private Sub btnSortieMaint_Click(sender As Object, e As EventArgs) Handles btnSortieMaint.Click
        ActiverMode("SortieMaintenance")
    End Sub

    Private Sub btnRetourMission_Click(sender As Object, e As EventArgs) Handles btnRetourMission.Click
        ActiverMode("RetourMission")
    End Sub

    Private Sub btnRetourMaint_Click(sender As Object, e As EventArgs) Handles btnRetourMaint.Click
        ActiverMode("RetourMaintenance")
    End Sub

    ' Charger véhicules selon mode
    Private Sub ChargerVehicules()
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim sql As String
                Select Case _typeMouvement
                    Case "SortieMission", "SortieMaintenance"
                        sql = "SELECT id_vehicule, immatriculation FROM T_Vehicules " &
                              "WHERE statut='Disponible'"
                    Case "RetourMission"
                        sql = "SELECT id_vehicule, immatriculation FROM T_Vehicules " &
                              "WHERE statut='En_Mission'"
                    Case "RetourMaintenance"
                        sql = "SELECT id_vehicule, immatriculation FROM T_Vehicules " &
                              "WHERE statut='Maintenance'"
                    Case Else
                        sql = "SELECT id_vehicule, immatriculation FROM T_Vehicules"
                End Select

                Dim da As New OleDbDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                cboVehicule.DisplayMember = "immatriculation"
                cboVehicule.ValueMember = "id_vehicule"
                cboVehicule.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        End Try
    End Sub

    Private Sub ChargerChauffeurs()
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim da As New OleDbDataAdapter(
                    "SELECT id_chauffeur, nom_complet FROM T_Chauffeurs " &
                    "WHERE statut='Actif'", conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                cboChauffeur.DisplayMember = "nom_complet"
                cboChauffeur.ValueMember = "id_chauffeur"
                cboChauffeur.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        End Try
    End Sub

    ' Vérifications automatiques
    Private Sub cboVehicule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVehicule.SelectedIndexChanged
        If cboVehicule.SelectedValue IsNot Nothing Then
            VerifierVehicule(CInt(cboVehicule.SelectedValue))
        End If
    End Sub

    Private Sub cboChauffeur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboChauffeur.SelectedIndexChanged
        If cboChauffeur.SelectedValue IsNot Nothing Then
            VerifierChauffeur(CInt(cboChauffeur.SelectedValue))
        End If
    End Sub

    Private Sub txtNumMission_Leave(sender As Object, e As EventArgs) Handles txtNumMission.Leave
        If txtNumMission.Enabled AndAlso txtNumMission.Text.Trim() <> "" Then
            VerifierMission(txtNumMission.Text.Trim())
        End If
    End Sub

    Private Sub VerifierVehicule(idVeh As Integer)
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim cmd As New OleDbCommand(
                    "SELECT statut, date_assurance, date_visite_technique " &
                    "FROM T_Vehicules WHERE id_vehicule=?", conn)
                cmd.Parameters.AddWithValue("?", idVeh)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    If Not IsDBNull(dr("date_assurance")) Then
                        Dim d As DateTime = CDate(dr("date_assurance"))
                        SetCheck(lblAssurance, d >= DateTime.Today,
                                 If(d >= DateTime.Today,
                                    "✅ Assurance valide — exp. " & d.ToString("dd/MM/yyyy"),
                                    "❌ Assurance EXPIRÉE le " & d.ToString("dd/MM/yyyy")))
                    End If
                    If Not IsDBNull(dr("date_visite_technique")) Then
                        Dim d As DateTime = CDate(dr("date_visite_technique"))
                        SetCheck(lblVisite, d >= DateTime.Today,
                                 If(d >= DateTime.Today,
                                    "✅ Visite technique valide — exp. " & d.ToString("dd/MM/yyyy"),
                                    "❌ Visite technique EXPIRÉE"))
                    End If
                    Dim statut As String = dr("statut").ToString()
                    SetCheck(lblStatutVeh, statut = "Disponible",
                             If(statut = "Disponible", "✅ Véhicule Disponible",
                                "❌ Véhicule : " & statut))
                End If
                dr.Close()
            End Using
            MettreAJourResultat()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub VerifierChauffeur(idChauf As Integer)
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim cmd As New OleDbCommand(
                    "SELECT statut, date_expiration_permis FROM T_Chauffeurs " &
                    "WHERE id_chauffeur=?", conn)
                cmd.Parameters.AddWithValue("?", idChauf)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    If Not IsDBNull(dr("date_expiration_permis")) Then
                        Dim d As DateTime = CDate(dr("date_expiration_permis"))
                        SetCheck(lblPermis, d >= DateTime.Today,
                                 If(d >= DateTime.Today,
                                    "✅ Permis valide — exp. " & d.ToString("dd/MM/yyyy"),
                                    "❌ Permis EXPIRÉ le " & d.ToString("dd/MM/yyyy")))
                    End If
                    Dim statut As String = dr("statut").ToString()
                    SetCheck(lblStatutChauf, statut = "Actif",
                             If(statut = "Actif", "✅ Chauffeur Actif",
                                "❌ Chauffeur : " & statut))
                End If
                dr.Close()
            End Using
            MettreAJourResultat()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub VerifierMission(numMission As String)
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim cmd As New OleDbCommand(
                    "SELECT statut, destination FROM T_Missions " &
                    "WHERE numero_mission=?", conn)
                cmd.Parameters.AddWithValue("?", numMission)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()
                If dr.Read() Then
                    Dim statut As String = dr("statut").ToString()
                    Dim dest As String = dr("destination").ToString()
                    SetCheck(lblMissionOk,
                             statut = "Validee" Or statut = "En_Cours" Or statut = "En_Attente",
                             If(statut = "Validee" Or statut = "En_Attente",
                                "✅ Mission validée → " & dest,
                                If(statut = "En_Cours",
                                   "✅ Mission en cours → " & dest,
                                   "❌ Mission non autorisée (" & statut & ")")))
                Else
                    SetCheck(lblMissionOk, False, "❌ Mission introuvable")
                End If
                dr.Close()
            End Using
            MettreAJourResultat()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub SetCheck(lbl As Label, ok As Boolean, texte As String)
        lbl.Text = texte
        lbl.ForeColor = If(ok, Color.FromArgb(16, 185, 129), Color.FromArgb(239, 68, 68))
    End Sub

    Private Sub MettreAJourResultat()
        Dim vert As Color = Color.FromArgb(16, 185, 129)
        Dim toutOk As Boolean =
            lblAssurance.ForeColor = vert AndAlso
            lblVisite.ForeColor = vert AndAlso
            lblStatutVeh.ForeColor = vert AndAlso
            lblPermis.ForeColor = vert AndAlso
            lblStatutChauf.ForeColor = vert

        If toutOk Then
            pnlResultat.BackColor = Color.FromArgb(15, 40, 30)
            lblResultat.ForeColor = vert
            lblResultat.Text = "🟢 AUTORISATION ACCORDÉE"
        Else
            pnlResultat.BackColor = Color.FromArgb(40, 15, 15)
            lblResultat.ForeColor = Color.FromArgb(239, 68, 68)
            lblResultat.Text = "🔴 VÉRIFICATIONS INCOMPLÈTES"
        End If
    End Sub

    Private Sub ResetVerifications()
        Dim gris As Color = Color.FromArgb(130, 155, 210)
        For Each lbl As Label In {lblAssurance, lblVisite, lblStatutVeh,
                                   lblPermis, lblStatutChauf, lblMissionOk}
            lbl.ForeColor = gris
            lbl.Text = lbl.Text.Split("—")(0).Trim() & " —"
        Next
        pnlResultat.BackColor = Color.FromArgb(25, 35, 75)
        lblResultat.ForeColor = gris
        lblResultat.Text = "En attente de vérification..."
    End Sub

    ' Valider le mouvement
    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        If cboVehicule.SelectedValue Is Nothing OrElse txtKm.Text.Trim() = "" Then
            MessageBox.Show("Véhicule et Km sont obligatoires.",
                            "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If txtNumMission.Enabled AndAlso txtNumMission.Text.Trim() = "" Then
            MessageBox.Show("Le N° de mission est obligatoire.",
                            "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim km As Integer
        If Not Integer.TryParse(txtKm.Text.Replace(" ", ""), km) Then
            MessageBox.Show("Km invalide.", "Erreur",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim idVehicule As Integer = CInt(cboVehicule.SelectedValue)

                Select Case _typeMouvement

                    Case "SortieMission"
                        Dim idMission As Object = GetIdMission(txtNumMission.Text.Trim(), conn)
                        If idMission Is Nothing Then
                            MessageBox.Show("Mission introuvable !")
                            Exit Sub
                        End If
                        InsererMouvement(CInt(idMission), "Sortie", km,
                                         txtObservation.Text, conn)
                        UpdateMission(CInt(idMission), "En_Cours", conn)
                        UpdateVehicule(idVehicule, "En_Mission", km, conn)
                        MessageBox.Show("✅ Sortie Mission enregistrée !")

                    Case "SortieMaintenance"
                        ' Trouver la maintenance planifiée pour ce véhicule
                        Dim idMaint As Object = GetIdMaintenance(idVehicule, conn)
                        If idMaint IsNot Nothing Then
                            Dim cmd As New OleDbCommand(
                                "UPDATE T_Maintenance SET statut='En_Cours' " &
                                "WHERE id_maintenance=?", conn)
                            cmd.Parameters.AddWithValue("?", CInt(idMaint))
                            cmd.ExecuteNonQuery()
                        End If
                        ' Créer un mouvement fictif lié à maintenance
                        InsererMouvementLibre("Sortie_Maint", idVehicule, km,
                                              txtObservation.Text, conn)
                        UpdateVehicule(idVehicule, "Maintenance", km, conn)
                        MessageBox.Show("✅ Sortie Maintenance enregistrée !")

                    Case "RetourMission"
                        Dim idMission As Object = GetIdMission(txtNumMission.Text.Trim(), conn)
                        If idMission Is Nothing Then
                            MessageBox.Show("Mission introuvable !")
                            Exit Sub
                        End If
                        InsererMouvement(CInt(idMission), "Retour", km,
                                         txtObservation.Text, conn)
                        UpdateMission(CInt(idMission), "Terminee", conn)
                        UpdateVehicule(idVehicule, "Disponible", km, conn)
                        MessageBox.Show("✅ Retour Mission enregistré !")

                    Case "RetourMaintenance"
                        Dim idMaint As Object = GetIdMaintenance(idVehicule, conn)
                        If idMaint IsNot Nothing Then
                            Dim cmd As New OleDbCommand(
                                "UPDATE T_Maintenance SET statut='Terminee', " &
                                "date_sortie_reelle=Now() WHERE id_maintenance=?", conn)
                            cmd.Parameters.AddWithValue("?", CInt(idMaint))
                            cmd.ExecuteNonQuery()
                        End If
                        InsererMouvementLibre("Retour_Maint", idVehicule, km,
                                              txtObservation.Text, conn)
                        UpdateVehicule(idVehicule, "Disponible", km, conn)
                        MessageBox.Show("✅ Retour Maintenance enregistré !")
                End Select

                ' Réinitialiser
                txtNumMission.Clear()
                txtKm.Clear()
                txtObservation.Text = "RAS"
                ResetVerifications()
                ChargerVehicules()
                ChargerJournal()
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message,
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetIdMission(numMission As String,
                                   conn As OleDbConnection) As Object
        Dim cmd As New OleDbCommand(
            "SELECT id_mission FROM T_Missions WHERE numero_mission=?", conn)
        cmd.Parameters.AddWithValue("?", numMission)
        Dim result As Object = cmd.ExecuteScalar()
        Return If(result Is DBNull.Value, Nothing, result)
    End Function

    Private Function GetIdMaintenance(idVehicule As Integer,
                                       conn As OleDbConnection) As Object
        Dim cmd As New OleDbCommand(
            "SELECT id_maintenance FROM T_Maintenance " &
            "WHERE id_vehicule=? AND statut IN ('Planifiee','En_Cours') " &
            "ORDER BY date_entree DESC", conn)
        cmd.Parameters.AddWithValue("?", idVehicule)
        Dim result As Object = cmd.ExecuteScalar()
        Return If(result Is DBNull.Value, Nothing, result)
    End Function

    Private Sub InsererMouvement(idMission As Integer, typeMvt As String,
                                  km As Integer, obs As String,
                                  conn As OleDbConnection)
        Dim cmd As New OleDbCommand(
            "INSERT INTO T_Mouvements " &
            "(id_mission, type_mouvement, date_heure, km_releve, observation, id_agent) " &
            "VALUES (?, ?, ?, ?, ?, ?)", conn)
        cmd.Parameters.AddWithValue("?", idMission)
        cmd.Parameters.AddWithValue("?", typeMvt)
        cmd.Parameters.AddWithValue("?", DateTime.Now)
        cmd.Parameters.AddWithValue("?", km)
        cmd.Parameters.AddWithValue("?", obs)
        cmd.Parameters.AddWithValue("?", _idUser)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub InsererMouvementLibre(typeMvt As String, idVehicule As Integer,
                                       km As Integer, obs As String,
                                       conn As OleDbConnection)
        Dim cmd As New OleDbCommand(
            "INSERT INTO T_Mouvements " &
            "(id_mission, type_mouvement, date_heure, km_releve, observation, id_agent) " &
            "VALUES (0, ?, ?, ?, ?, ?)", conn)
        cmd.Parameters.AddWithValue("?", typeMvt)
        cmd.Parameters.AddWithValue("?", DateTime.Now)
        cmd.Parameters.AddWithValue("?", km)
        cmd.Parameters.AddWithValue("?", obs)
        cmd.Parameters.AddWithValue("?", _idUser)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub UpdateMission(idMission As Integer, statut As String,
                               conn As OleDbConnection)
        Dim cmd As New OleDbCommand(
            "UPDATE T_Missions SET statut=? WHERE id_mission=?", conn)
        cmd.Parameters.AddWithValue("?", statut)
        cmd.Parameters.AddWithValue("?", idMission)
        cmd.ExecuteNonQuery()
    End Sub

    Private Sub UpdateVehicule(idVehicule As Integer, statut As String,
                                km As Integer, conn As OleDbConnection)
        Dim cmd As New OleDbCommand(
            "UPDATE T_Vehicules SET statut=?, km_actuel=? WHERE id_vehicule=?", conn)
        cmd.Parameters.AddWithValue("?", statut)
        cmd.Parameters.AddWithValue("?", km)
        cmd.Parameters.AddWithValue("?", idVehicule)
        cmd.ExecuteNonQuery()
    End Sub

    ' Journal du jour
    Private Sub ChargerJournal()
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim sql As String =
                    "SELECT Format(MV.date_heure,'hh:nn') AS [Heure], " &
                    "MV.type_mouvement AS [Type], " &
                    "V.immatriculation AS [Véhicule], " &
                    "C.nom_complet AS [Chauffeur], " &
                    "M.numero_mission AS [Mission], " &
                    "MV.km_releve AS [Km], " &
                    "MV.observation AS [Observation] " &
                    "FROM (((T_Mouvements AS MV " &
                    "INNER JOIN T_Missions AS M ON MV.id_mission = M.id_mission) " &
                    "INNER JOIN T_Vehicules AS V ON M.id_vehicule = V.id_vehicule) " &
                    "INNER JOIN T_Chauffeurs AS C ON M.id_chauffeur = C.id_chauffeur) " &
                    "WHERE DateValue(MV.date_heure) = Date() " &
                    "ORDER BY MV.date_heure DESC"

                Dim da As New OleDbDataAdapter(sql, conn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgvJournal.DataSource = dt
                StylerGrille(dgvJournal)

                For Each row As DataGridViewRow In dgvJournal.Rows
                    If Not row.IsNewRow Then
                        Dim t As String = row.Cells("Type").Value.ToString()
                        If t.Contains("Sortie") Then
                            row.Cells("Type").Style.ForeColor = Color.FromArgb(239, 68, 68)
                        Else
                            row.Cells("Type").Style.ForeColor = Color.FromArgb(16, 185, 129)
                        End If
                    End If
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur journal : " & ex.Message)
        End Try
    End Sub

    ' Déconnexion
    Private Sub btnDeconnexion_Click(sender As Object, e As EventArgs) Handles btnDeconnexion.Click
        Dim rep As DialogResult = MessageBox.Show(
            "Voulez-vous vous déconnecter ?",
            "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If rep = DialogResult.Yes Then
            Dim login As New FrmLogin()
            login.Show()
            Me.Close()
        End If
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