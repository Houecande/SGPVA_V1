Imports System.Data.OleDb

Public Class FrmControle

    Private _idUser As Integer
    Private _nom As String
    Private _role As String
    Private _modeSortie As Boolean = True

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

    ' Design
    Private Sub AppliquerDesign()
        StylerGrille(dgvJournal)
        ResetVerifications()
    End Sub

    ' Charger véhicules
    Private Sub ChargerVehicules()
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim sql As String = If(_modeSortie,
                    "SELECT id_vehicule, immatriculation FROM T_Vehicules WHERE statut='Disponible'",
                    "SELECT id_vehicule, immatriculation FROM T_Vehicules WHERE statut='En_Mission'")
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

    ' Charger chauffeurs
    Private Sub ChargerChauffeurs()
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim da As New OleDbDataAdapter(
                    "SELECT id_chauffeur, nom_complet FROM T_Chauffeurs WHERE statut='Actif'", conn)
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

    ' Vérification automatique
    Private Sub cboVehicule_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboVehicule.SelectedIndexChanged
        If cboVehicule.SelectedValue Is Nothing Then Exit Sub
        VerifierVehicule(CInt(cboVehicule.SelectedValue))
    End Sub

    Private Sub cboChauffeur_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboChauffeur.SelectedIndexChanged
        If cboChauffeur.SelectedValue Is Nothing Then Exit Sub
        VerifierChauffeur(CInt(cboChauffeur.SelectedValue))
    End Sub

    Private Sub txtNumMission_Leave(sender As Object, e As EventArgs) Handles txtNumMission.Leave
        If txtNumMission.Text.Trim() <> "" Then
            VerifierMission(txtNumMission.Text.Trim())
        End If
    End Sub

    ' Vérifier véhicule
    Private Sub VerifierVehicule(idVeh As Integer)
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim cmd As New OleDbCommand(
                    "SELECT statut, date_assurance, date_visite_technique " &
                    "FROM T_Vehicules WHERE id_vehicule=?", conn)
                cmd.Parameters.AddWithValue("?", idVeh)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()

                If dr.Read() Then
                    ' Assurance
                    If Not IsDBNull(dr("date_assurance")) Then
                        Dim dateAss As DateTime = CDate(dr("date_assurance"))
                        If dateAss >= DateTime.Today Then
                            SetCheck(lblAssurance, True, "✅ Assurance valide — exp. " & dateAss.ToString("dd/MM/yyyy"))
                        Else
                            SetCheck(lblAssurance, False, "❌ Assurance EXPIRÉE le " & dateAss.ToString("dd/MM/yyyy"))
                        End If
                    End If

                    ' Visite technique
                    If Not IsDBNull(dr("date_visite_technique")) Then
                        Dim dateVT As DateTime = CDate(dr("date_visite_technique"))
                        If dateVT >= DateTime.Today Then
                            SetCheck(lblVisite, True, "✅ Visite technique valide — exp. " & dateVT.ToString("dd/MM/yyyy"))
                        Else
                            SetCheck(lblVisite, False, "❌ Visite technique EXPIRÉE")
                        End If
                    End If

                    ' Statut
                    Dim statut As String = dr("statut").ToString()
                    If statut = "Disponible" Then
                        SetCheck(lblStatutVeh, True, "✅ Véhicule Disponible")
                    Else
                        SetCheck(lblStatutVeh, False, "❌ Véhicule : " & statut)
                    End If
                End If
                dr.Close()
            End Using
            MettreAJourResultat()
        Catch ex As Exception
            MessageBox.Show("Erreur vérif. véhicule : " & ex.Message)
        End Try
    End Sub

    ' Vérifier chauffeur
    Private Sub VerifierChauffeur(idChauf As Integer)
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim cmd As New OleDbCommand(
                    "SELECT statut, date_expiration_permis FROM T_Chauffeurs WHERE id_chauffeur=?", conn)
                cmd.Parameters.AddWithValue("?", idChauf)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()

                If dr.Read() Then
                    If Not IsDBNull(dr("date_expiration_permis")) Then
                        Dim datePerm As DateTime = CDate(dr("date_expiration_permis"))
                        If datePerm >= DateTime.Today Then
                            SetCheck(lblPermis, True, "✅ Permis valide — exp. " & datePerm.ToString("dd/MM/yyyy"))
                        Else
                            SetCheck(lblPermis, False, "❌ Permis EXPIRÉ le " & datePerm.ToString("dd/MM/yyyy"))
                        End If
                    End If

                    Dim statut As String = dr("statut").ToString()
                    If statut = "Actif" Then
                        SetCheck(lblStatutChauf, True, "✅ Chauffeur Actif")
                    Else
                        SetCheck(lblStatutChauf, False, "❌ Chauffeur : " & statut)
                    End If
                End If
                dr.Close()
            End Using
            MettreAJourResultat()
        Catch ex As Exception
            MessageBox.Show("Erreur vérif. chauffeur : " & ex.Message)
        End Try
    End Sub

    ' Vérifier mission
    Private Sub VerifierMission(numMission As String)
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim cmd As New OleDbCommand(
                    "SELECT statut, destination FROM T_Missions WHERE numero_mission=?", conn)
                cmd.Parameters.AddWithValue("?", numMission)
                Dim dr As OleDbDataReader = cmd.ExecuteReader()

                If dr.Read() Then
                    Dim statut As String = dr("statut").ToString()
                    Dim dest As String = dr("destination").ToString()
                    If statut = "Validee" Or statut = "En_Cours" Then
                        SetCheck(lblMissionOk, True, "✅ Mission validée → " & dest)
                    Else
                        SetCheck(lblMissionOk, False, "❌ Mission non validée (" & statut & ")")
                    End If
                Else
                    SetCheck(lblMissionOk, False, "❌ Mission introuvable")
                End If
                dr.Close()
            End Using
            MettreAJourResultat()
        Catch ex As Exception
            MessageBox.Show("Erreur vérif. mission : " & ex.Message)
        End Try
    End Sub

    ' Afficher check
    Private Sub SetCheck(lbl As Label, ok As Boolean, texte As String)
        lbl.Text = texte
        lbl.ForeColor = If(ok, Color.FromArgb(16, 185, 129), Color.FromArgb(239, 68, 68))
    End Sub

    ' Mettre à jour résultat global
    Private Sub MettreAJourResultat()
        Dim toutOk As Boolean =
            lblAssurance.ForeColor = Color.FromArgb(16, 185, 129) AndAlso
            lblVisite.ForeColor = Color.FromArgb(16, 185, 129) AndAlso
            lblStatutVeh.ForeColor = Color.FromArgb(16, 185, 129) AndAlso
            lblPermis.ForeColor = Color.FromArgb(16, 185, 129) AndAlso
            lblStatutChauf.ForeColor = Color.FromArgb(16, 185, 129)

        If toutOk Then
            pnlResultat.BackColor = Color.FromArgb(15, 40, 30)
            lblResultat.ForeColor = Color.FromArgb(16, 185, 129)
            lblResultat.Text = "🟢 AUTORISATION ACCORDÉE"
        Else
            pnlResultat.BackColor = Color.FromArgb(40, 15, 15)
            lblResultat.ForeColor = Color.FromArgb(239, 68, 68)
            lblResultat.Text = "🔴 VÉRIFICATIONS INCOMPLÈTES"
        End If
    End Sub

    ' Reset vérifications
    Private Sub ResetVerifications()
        Dim labels = {lblAssurance, lblVisite, lblStatutVeh, lblPermis, lblStatutChauf, lblMissionOk}
        For Each lbl In labels
            lbl.ForeColor = Color.FromArgb(130, 155, 210)
        Next
        pnlResultat.BackColor = Color.FromArgb(25, 35, 75)
        lblResultat.ForeColor = Color.FromArgb(130, 155, 210)
        lblResultat.Text = "En attente de vérification..."
    End Sub

    ' Onglets Sortie / Retour
    Private Sub btnOngletSortie_Click(sender As Object, e As EventArgs) Handles btnOngletSortie.Click
        _modeSortie = True
        btnOngletSortie.BackColor = Color.FromArgb(239, 68, 68)
        btnOngletSortie.ForeColor = Color.White
        btnOngletRetour.BackColor = Color.FromArgb(25, 35, 75)
        btnOngletRetour.ForeColor = Color.FromArgb(130, 155, 210)
        btnValider.Text = "✅ Valider la Sortie"
        btnValider.BackColor = Color.FromArgb(239, 68, 68)
        ResetVerifications()
        ChargerVehicules()
    End Sub

    Private Sub btnOngletRetour_Click(sender As Object, e As EventArgs) Handles btnOngletRetour.Click
        _modeSortie = False
        btnOngletRetour.BackColor = Color.FromArgb(16, 185, 129)
        btnOngletRetour.ForeColor = Color.White
        btnOngletSortie.BackColor = Color.FromArgb(25, 35, 75)
        btnOngletSortie.ForeColor = Color.FromArgb(130, 155, 210)
        btnValider.Text = "✅ Valider le Retour"
        btnValider.BackColor = Color.FromArgb(16, 185, 129)
        ResetVerifications()
        ChargerVehicules()
    End Sub

    ' Valider sortie ou retour
    Private Sub btnValider_Click(sender As Object, e As EventArgs) Handles btnValider.Click
        If txtNumMission.Text.Trim() = "" OrElse
           cboVehicule.SelectedValue Is Nothing OrElse
           txtKm.Text.Trim() = "" Then
            MessageBox.Show("Veuillez remplir : N° Mission, Véhicule et Km.",
                            "Champs requis", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim km As Integer
        If Not Integer.TryParse(txtKm.Text.Replace(" ", ""), km) Then
            MessageBox.Show("Le kilométrage doit être un nombre entier.",
                            "Valeur invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                ' Trouver id_mission
                Dim cmdMission As New OleDbCommand(
                    "SELECT id_mission FROM T_Missions WHERE numero_mission=?", conn)
                cmdMission.Parameters.AddWithValue("?", txtNumMission.Text.Trim())
                Dim idMission As Object = cmdMission.ExecuteScalar()

                If idMission Is Nothing Then
                    MessageBox.Show("Mission introuvable !", "Erreur",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

                Dim typeMvt As String = If(_modeSortie, "Sortie", "Retour")

                ' Enregistrer mouvement
                Dim cmdMvt As New OleDbCommand(
                    "INSERT INTO T_Mouvements " &
                    "(id_mission, type_mouvement, date_heure, km_releve, observation, id_agent) " &
                    "VALUES (?, ?, ?, ?, ?, ?)", conn)
                cmdMvt.Parameters.AddWithValue("?", CInt(idMission))
                cmdMvt.Parameters.AddWithValue("?", typeMvt)
                cmdMvt.Parameters.AddWithValue("?", DateTime.Now)
                cmdMvt.Parameters.AddWithValue("?", km)
                cmdMvt.Parameters.AddWithValue("?", txtObservation.Text)
                cmdMvt.Parameters.AddWithValue("?", _idUser)
                cmdMvt.ExecuteNonQuery()

                ' Mettre à jour statut mission et véhicule
                If _modeSortie Then
                    Dim cmdM As New OleDbCommand(
                        "UPDATE T_Missions SET statut='En_Cours' WHERE id_mission=?", conn)
                    cmdM.Parameters.AddWithValue("?", CInt(idMission))
                    cmdM.ExecuteNonQuery()

                    Dim cmdV As New OleDbCommand(
                        "UPDATE T_Vehicules SET statut='En_Mission', km_actuel=? WHERE id_vehicule=?", conn)
                    cmdV.Parameters.AddWithValue("?", km)
                    cmdV.Parameters.AddWithValue("?", CInt(cboVehicule.SelectedValue))
                    cmdV.ExecuteNonQuery()
                Else
                    Dim cmdM As New OleDbCommand(
                        "UPDATE T_Missions SET statut='Terminee' WHERE id_mission=?", conn)
                    cmdM.Parameters.AddWithValue("?", CInt(idMission))
                    cmdM.ExecuteNonQuery()

                    Dim cmdV As New OleDbCommand(
                        "UPDATE T_Vehicules SET statut='Disponible', km_actuel=? WHERE id_vehicule=?", conn)
                    cmdV.Parameters.AddWithValue("?", km)
                    cmdV.Parameters.AddWithValue("?", CInt(cboVehicule.SelectedValue))
                    cmdV.ExecuteNonQuery()
                End If

                MessageBox.Show("✅ " & typeMvt & " enregistrée avec succès !",
                                "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)

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

                ' Colorier Sortie/Retour
                For Each row As DataGridViewRow In dgvJournal.Rows
                    If Not row.IsNewRow Then
                        If row.Cells("Type").Value.ToString() = "Sortie" Then
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

End Class