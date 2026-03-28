Imports System.Data.OleDb

Public Class FrmTableauBord
    Private _idUser As Integer
    Private _nom As String
    Private _role As String

    ' Constructeur
    Public Sub New(idUser As Integer, nom As String, role As String)
        InitializeComponent()
        _idUser = idUser
        _nom = nom
        _role = role
    End Sub

    ' Chargement
    Private Sub FrmTableauBord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Tableau de Bord — SGPVA"
        lblNomUser.Text = "Connecté : " & _nom & "  |  " & _role
        ChargerStatistiques()
        ChargerMissionsDuJour()
        AfficherAlertesList()
    End Sub

    ' Statistiques véhicules
    Private Sub ChargerStatistiques()
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()

                ' Total véhicules
                Dim cmdTotal As New OleDbCommand(
                    "SELECT COUNT(*) FROM T_Vehicules", conn)
                lblTotalVeh.Text = cmdTotal.ExecuteScalar().ToString()

                ' Disponibles
                Dim cmdDispo As New OleDbCommand(
                    "SELECT COUNT(*) FROM T_Vehicules WHERE statut='Disponible'", conn)
                lblDispoVeh.Text = cmdDispo.ExecuteScalar().ToString()

                ' En mission
                Dim cmdMission As New OleDbCommand(
                    "SELECT COUNT(*) FROM T_Vehicules WHERE statut='En_Mission'", conn)
                lblMissionVeh.Text = cmdMission.ExecuteScalar().ToString()

                ' En maintenance
                Dim cmdMaint As New OleDbCommand(
                    "SELECT COUNT(*) FROM T_Vehicules WHERE statut='Maintenance'", conn)
                lblMaintenVeh.Text = cmdMaint.ExecuteScalar().ToString()

            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur statistiques : " & ex.Message,
                            "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Missions du jour
    Private Sub ChargerMissionsDuJour()
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()

                Dim sql As String =
                "SELECT M.numero_mission AS [N° Mission], " &
                "M.service_demandeur AS [Service], " &
                "V.immatriculation AS [Véhicule], " &
                "C.nom_complet AS [Chauffeur], " &
                "M.destination AS [Destination], " &
                "M.statut AS [Statut] " &
                "FROM (T_Missions AS M " &
                "INNER JOIN T_Vehicules AS V ON M.id_vehicule = V.id_vehicule) " &
                "INNER JOIN T_Chauffeurs AS C ON M.id_chauffeur = C.id_chauffeur " &
                "WHERE M.date_depart_prevue >= ? AND M.date_depart_prevue < ?" &
                " ORDER BY M.date_depart_prevue"

                Dim cmd As New OleDbCommand(sql, conn)

                ' On définit le début et la fin de la journée d'aujourd'hui
                Dim debutAujourdhui As DateTime = DateTime.Today
                Dim finAujourdhui As DateTime = DateTime.Today.AddDays(1)

                ' On ajoute les paramètres (l'ordre est important pour OleDb)
                cmd.Parameters.Add("@debut", OleDbType.Date).Value = debutAujourdhui
                cmd.Parameters.Add("@fin", OleDbType.Date).Value = finAujourdhui

                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                dgvMissions.DataSource = dt
                StylerGrille(dgvMissions)
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur missions : " & ex.Message,
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Alertes documents
    Private Sub AfficherAlertesList()
        ' Vider le panel alertes
        dgvAlertes.Visible = False

        ' Créer un panel liste
        Dim pnlListe As New Panel()
        pnlListe.BackColor = Color.FromArgb(18, 25, 55)
        pnlListe.Location = dgvAlertes.Location
        pnlListe.Size = dgvAlertes.Size
        pnlListe.AutoScroll = True
        pnlContenu.Controls.Add(pnlListe)

        ' Données alertes
        Dim alertes As New List(Of Tuple(Of String, String, String, Color))

        Using conn As OleDbConnection = ConnexionDB.GetConnexion()
            ' Assurances expirées
            Dim da1 As New OleDbDataAdapter(
            "SELECT immatriculation, date_assurance FROM T_Vehicules " &
            "WHERE date_assurance IS NOT NULL", conn)
            Dim dt1 As New DataTable()
            da1.Fill(dt1)
            For Each r As DataRow In dt1.Rows
                Dim d As DateTime = CDate(r("date_assurance"))
                Dim couleur As Color = If(d < DateTime.Today,
                Color.FromArgb(239, 68, 68),
                Color.FromArgb(245, 158, 11))
                Dim msg As String = If(d < DateTime.Today,
                "Assurance expirée — " & r("immatriculation").ToString(),
                "Assurance bientôt — " & r("immatriculation").ToString())
                Dim sub_msg As String = If(d < DateTime.Today,
                "Expirée le " & d.ToString("dd/MM/yyyy"),
                "Expire le " & d.ToString("dd/MM/yyyy"))
                alertes.Add(New Tuple(Of String, String, String, Color)(
                msg, sub_msg, "", couleur))
            Next

            ' Permis chauffeurs
            Dim da3 As New OleDbDataAdapter(
            "SELECT nom_complet, date_expiration_permis FROM T_Chauffeurs " &
            "WHERE date_expiration_permis IS NOT NULL " &
            "AND date_expiration_permis <= Date()+30", conn)
            Dim dt3 As New DataTable()
            da3.Fill(dt3)
            For Each r As DataRow In dt3.Rows
                Dim d As DateTime = CDate(r("date_expiration_permis"))
                alertes.Add(New Tuple(Of String, String, String, Color)(
                "Permis chauffeur — " & r("nom_complet").ToString(),
                "Expire le " & d.ToString("dd/MM/yyyy"),
                "", Color.FromArgb(245, 158, 11)))
            Next
        End Using

        ' Afficher chaque alerte
        Dim yPos As Integer = 10
        For Each alerte In alertes
            ' Ligne alerte
            Dim pnlAlerte As New Panel()
            pnlAlerte.BackColor = Color.FromArgb(22, 30, 65)
            pnlAlerte.Size = New Size(pnlListe.Width - 20, 60)
            pnlAlerte.Location = New Point(10, yPos)
            pnlAlerte.BorderStyle = BorderStyle.None

            ' Point coloré
            Dim dot As New Panel()
            dot.BackColor = alerte.Item4
            dot.Size = New Size(8, 8)
            dot.Location = New Point(15, 26)
            pnlAlerte.Controls.Add(dot)

            ' Bordure gauche colorée
            Dim bord As New Panel()
            bord.BackColor = alerte.Item4
            bord.Size = New Size(3, 60)
            bord.Location = New Point(0, 0)
            pnlAlerte.Controls.Add(bord)

            ' Titre alerte
            Dim lblTitre As New Label()
            lblTitre.Text = alerte.Item1
            lblTitre.ForeColor = Color.White
            lblTitre.Font = New Font("Segoe UI", 9, FontStyle.Bold)
            lblTitre.Location = New Point(35, 10)
            lblTitre.AutoSize = True
            pnlAlerte.Controls.Add(lblTitre)

            ' Sous-titre
            Dim lblSub As New Label()
            lblSub.Text = alerte.Item2
            lblSub.ForeColor = Color.FromArgb(130, 155, 210)
            lblSub.Font = New Font("Segoe UI", 8)
            lblSub.Location = New Point(35, 32)
            lblSub.AutoSize = True
            pnlAlerte.Controls.Add(lblSub)

            pnlListe.Controls.Add(pnlAlerte)
            yPos += 70
        Next
    End Sub

    ' Style des grilles
    Private Sub StylerGrille(dgv As DataGridView)
        ' Désactive le style Windows par défaut pour permettre la personnalisation
        dgvMissions.EnableHeadersVisualStyles = False
        dgvMissions.BorderStyle = BorderStyle.None


        ' Configuration des En-têtes (Headers) 
        dgvMissions.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgvMissions.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(26, 47, 108) ' Ton bleu de menu
        dgvMissions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgvMissions.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgvMissions.ColumnHeadersHeight = 40

        ' Configuration des Lignes 
        dgvMissions.RowHeadersVisible = False ' Cache la marge à gauche
        dgvMissions.RowTemplate.Height = 35
        dgvMissions.SelectionMode = DataGridViewSelectionMode.FullRowSelect ' Sélectionne toute la ligne

        ' Style par défaut (Lignes paires)
        dgvMissions.DefaultCellStyle.BackColor = Color.FromArgb(28, 33, 59)
        dgvMissions.DefaultCellStyle.ForeColor = Color.White
        dgvMissions.DefaultCellStyle.Font = New Font("Segoe UI", 9)
        dgvMissions.DefaultCellStyle.SelectionBackColor = Color.FromArgb(40, 50, 90)
        dgvMissions.DefaultCellStyle.SelectionForeColor = Color.White

        ' Style Alterné (Lignes impaires) - On reste dans le sombre !
        dgvMissions.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(24, 28, 50)

        ' Alignement et Bordures
        dgvMissions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        dgvMissions.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgvMissions.GridColor = Color.FromArgb(45, 50, 80) ' Lignes de séparation discrètes
    End Sub

    ' Navigation menu
    Private Sub btnMenuMissions_Click(sender As Object, e As EventArgs) Handles btnMenuMissions.Click
        Dim frm As New FrmMissions(_idUser, _nom, _role)
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenuVehicules_Click(sender As Object, e As EventArgs) Handles btnMenuVehicules.Click
        Dim frm As New FrmVehicules(_idUser, _nom, _role)
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenuChauffeurs_Click(sender As Object, e As EventArgs) Handles btnMenuChauffeurs.Click
        Dim frm As New FrmChauffeurs(_idUser, _nom, _role)
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnMenuMaintenance_Click(sender As Object, e As EventArgs) Handles btnMenuMaintenance.Click
        Dim frm As New FrmMaintenance(_idUser, _nom, _role)
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Module Maintenance — bientôt disponible !",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Déconnexion
    Private Sub btnDeconnexion_Click(sender As Object, e As EventArgs) Handles btnDeconnexion.Click
        Dim rep As DialogResult = MessageBox.Show(
            "Voulez-vous vous déconnecter ?",
            "Déconnexion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If rep = DialogResult.Yes Then
            Dim login As New FrmLogin()
            login.Show()
            Me.Close()
        End If
    End Sub

End Class