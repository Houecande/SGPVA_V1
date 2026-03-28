<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTableauBord
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlHaut = New System.Windows.Forms.Panel()
        Me.lblNomUser = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlMenu = New System.Windows.Forms.Panel()
        Me.btnMenuVehicules = New System.Windows.Forms.Button()
        Me.btnMenuChauffeurs = New System.Windows.Forms.Button()
        Me.btnMenuMaintenance = New System.Windows.Forms.Button()
        Me.btnDeconnexion = New System.Windows.Forms.Button()
        Me.btnMenuMissions = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.pnlContenu = New System.Windows.Forms.Panel()
        Me.lblTitreAlertes = New System.Windows.Forms.Label()
        Me.lblTitreMissions = New System.Windows.Forms.Label()
        Me.dgvAlertes = New System.Windows.Forms.DataGridView()
        Me.dgvMissions = New System.Windows.Forms.DataGridView()
        Me.pnlCardMission = New System.Windows.Forms.Panel()
        Me.lblMissionTxt = New System.Windows.Forms.Label()
        Me.lblMissionVeh = New System.Windows.Forms.Label()
        Me.pnlCardMaint = New System.Windows.Forms.Panel()
        Me.lblMaintenTxt = New System.Windows.Forms.Label()
        Me.lblMaintenVeh = New System.Windows.Forms.Label()
        Me.pnlCardDispo = New System.Windows.Forms.Panel()
        Me.lblDispoVeh = New System.Windows.Forms.Label()
        Me.lblDispoTxt = New System.Windows.Forms.Label()
        Me.pnlCardTotal = New System.Windows.Forms.Panel()
        Me.lblTotalTxt = New System.Windows.Forms.Label()
        Me.lblTotalVeh = New System.Windows.Forms.Label()
        Me.pnlBordTotal = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pnlHaut.SuspendLayout()
        Me.pnlMenu.SuspendLayout()
        Me.pnlContenu.SuspendLayout()
        CType(Me.dgvAlertes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMissions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlCardMission.SuspendLayout()
        Me.pnlCardMaint.SuspendLayout()
        Me.pnlCardDispo.SuspendLayout()
        Me.pnlCardTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHaut
        '
        Me.pnlHaut.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlHaut.Controls.Add(Me.lblNomUser)
        Me.pnlHaut.Controls.Add(Me.Label1)
        Me.pnlHaut.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHaut.Location = New System.Drawing.Point(0, 0)
        Me.pnlHaut.Margin = New System.Windows.Forms.Padding(6)
        Me.pnlHaut.Name = "pnlHaut"
        Me.pnlHaut.Size = New System.Drawing.Size(1027, 65)
        Me.pnlHaut.TabIndex = 0
        '
        'lblNomUser
        '
        Me.lblNomUser.AutoSize = True
        Me.lblNomUser.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomUser.ForeColor = System.Drawing.Color.White
        Me.lblNomUser.Location = New System.Drawing.Point(800, 22)
        Me.lblNomUser.Name = "lblNomUser"
        Me.lblNomUser.Size = New System.Drawing.Size(67, 15)
        Me.lblNomUser.TabIndex = 1
        Me.lblNomUser.Text = "Connecté : "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(20, 18)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(245, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "🚗 SGPVA — Gestion du Parc"
        '
        'pnlMenu
        '
        Me.pnlMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlMenu.Controls.Add(Me.btnMenuVehicules)
        Me.pnlMenu.Controls.Add(Me.btnMenuChauffeurs)
        Me.pnlMenu.Controls.Add(Me.btnMenuMaintenance)
        Me.pnlMenu.Controls.Add(Me.btnDeconnexion)
        Me.pnlMenu.Controls.Add(Me.btnMenuMissions)
        Me.pnlMenu.Controls.Add(Me.Button1)
        Me.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlMenu.Location = New System.Drawing.Point(0, 65)
        Me.pnlMenu.Name = "pnlMenu"
        Me.pnlMenu.Size = New System.Drawing.Size(210, 562)
        Me.pnlMenu.TabIndex = 1
        '
        'btnMenuVehicules
        '
        Me.btnMenuVehicules.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnMenuVehicules.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuVehicules.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuVehicules.FlatAppearance.BorderSize = 0
        Me.btnMenuVehicules.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuVehicules.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuVehicules.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnMenuVehicules.Location = New System.Drawing.Point(0, 208)
        Me.btnMenuVehicules.Name = "btnMenuVehicules"
        Me.btnMenuVehicules.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnMenuVehicules.Size = New System.Drawing.Size(210, 52)
        Me.btnMenuVehicules.TabIndex = 5
        Me.btnMenuVehicules.Text = "🚗 Véhicules"
        Me.btnMenuVehicules.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuVehicules.UseVisualStyleBackColor = False
        '
        'btnMenuChauffeurs
        '
        Me.btnMenuChauffeurs.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnMenuChauffeurs.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuChauffeurs.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuChauffeurs.FlatAppearance.BorderSize = 0
        Me.btnMenuChauffeurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuChauffeurs.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuChauffeurs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnMenuChauffeurs.Location = New System.Drawing.Point(0, 156)
        Me.btnMenuChauffeurs.Name = "btnMenuChauffeurs"
        Me.btnMenuChauffeurs.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnMenuChauffeurs.Size = New System.Drawing.Size(210, 52)
        Me.btnMenuChauffeurs.TabIndex = 4
        Me.btnMenuChauffeurs.Text = "👤 Chauffeurs"
        Me.btnMenuChauffeurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuChauffeurs.UseVisualStyleBackColor = False
        '
        'btnMenuMaintenance
        '
        Me.btnMenuMaintenance.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnMenuMaintenance.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuMaintenance.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuMaintenance.FlatAppearance.BorderSize = 0
        Me.btnMenuMaintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuMaintenance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuMaintenance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnMenuMaintenance.Location = New System.Drawing.Point(0, 104)
        Me.btnMenuMaintenance.Name = "btnMenuMaintenance"
        Me.btnMenuMaintenance.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnMenuMaintenance.Size = New System.Drawing.Size(210, 52)
        Me.btnMenuMaintenance.TabIndex = 3
        Me.btnMenuMaintenance.Text = "🔧 Maintenance"
        Me.btnMenuMaintenance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuMaintenance.UseVisualStyleBackColor = False
        '
        'btnDeconnexion
        '
        Me.btnDeconnexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnDeconnexion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDeconnexion.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnDeconnexion.FlatAppearance.BorderSize = 0
        Me.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeconnexion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeconnexion.ForeColor = System.Drawing.Color.White
        Me.btnDeconnexion.Location = New System.Drawing.Point(0, 510)
        Me.btnDeconnexion.Name = "btnDeconnexion"
        Me.btnDeconnexion.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnDeconnexion.Size = New System.Drawing.Size(210, 52)
        Me.btnDeconnexion.TabIndex = 2
        Me.btnDeconnexion.Text = "↩ Déconnexion"
        Me.btnDeconnexion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDeconnexion.UseVisualStyleBackColor = False
        '
        'btnMenuMissions
        '
        Me.btnMenuMissions.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(17, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnMenuMissions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenuMissions.Dock = System.Windows.Forms.DockStyle.Top
        Me.btnMenuMissions.FlatAppearance.BorderSize = 0
        Me.btnMenuMissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMenuMissions.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMenuMissions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnMenuMissions.Location = New System.Drawing.Point(0, 52)
        Me.btnMenuMissions.Name = "btnMenuMissions"
        Me.btnMenuMissions.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.btnMenuMissions.Size = New System.Drawing.Size(210, 52)
        Me.btnMenuMissions.TabIndex = 1
        Me.btnMenuMissions.Text = "📋 Missions"
        Me.btnMenuMissions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnMenuMissions.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(179, Byte), Integer))
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.Button1.Size = New System.Drawing.Size(210, 52)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "📊 Tableau de Bord"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.UseVisualStyleBackColor = False
        '
        'pnlContenu
        '
        Me.pnlContenu.Controls.Add(Me.lblTitreAlertes)
        Me.pnlContenu.Controls.Add(Me.lblTitreMissions)
        Me.pnlContenu.Controls.Add(Me.dgvAlertes)
        Me.pnlContenu.Controls.Add(Me.dgvMissions)
        Me.pnlContenu.Controls.Add(Me.pnlCardMission)
        Me.pnlContenu.Controls.Add(Me.pnlCardMaint)
        Me.pnlContenu.Controls.Add(Me.pnlCardDispo)
        Me.pnlContenu.Controls.Add(Me.pnlCardTotal)
        Me.pnlContenu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlContenu.Location = New System.Drawing.Point(210, 65)
        Me.pnlContenu.Name = "pnlContenu"
        Me.pnlContenu.Padding = New System.Windows.Forms.Padding(24)
        Me.pnlContenu.Size = New System.Drawing.Size(817, 562)
        Me.pnlContenu.TabIndex = 2
        '
        'lblTitreAlertes
        '
        Me.lblTitreAlertes.AutoSize = True
        Me.lblTitreAlertes.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreAlertes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.lblTitreAlertes.Location = New System.Drawing.Point(24, 350)
        Me.lblTitreAlertes.Name = "lblTitreAlertes"
        Me.lblTitreAlertes.Size = New System.Drawing.Size(148, 17)
        Me.lblTitreAlertes.TabIndex = 5
        Me.lblTitreAlertes.Text = "⚠️ Alertes Documents"
        '
        'lblTitreMissions
        '
        Me.lblTitreMissions.AutoSize = True
        Me.lblTitreMissions.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreMissions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblTitreMissions.Location = New System.Drawing.Point(24, 121)
        Me.lblTitreMissions.Name = "lblTitreMissions"
        Me.lblTitreMissions.Size = New System.Drawing.Size(136, 17)
        Me.lblTitreMissions.TabIndex = 4
        Me.lblTitreMissions.Text = "📋 Missions du Jour"
        '
        'dgvAlertes
        '
        Me.dgvAlertes.AllowUserToAddRows = False
        Me.dgvAlertes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(27, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.dgvAlertes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvAlertes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlertes.GridColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.dgvAlertes.Location = New System.Drawing.Point(20, 370)
        Me.dgvAlertes.Name = "dgvAlertes"
        Me.dgvAlertes.ReadOnly = True
        Me.dgvAlertes.RowHeadersVisible = False
        Me.dgvAlertes.RowTemplate.Height = 34
        Me.dgvAlertes.Size = New System.Drawing.Size(785, 180)
        Me.dgvAlertes.TabIndex = 3
        '
        'dgvMissions
        '
        Me.dgvMissions.AllowUserToAddRows = False
        Me.dgvMissions.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.dgvMissions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMissions.GridColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.dgvMissions.Location = New System.Drawing.Point(20, 143)
        Me.dgvMissions.Name = "dgvMissions"
        Me.dgvMissions.ReadOnly = True
        Me.dgvMissions.RowHeadersVisible = False
        Me.dgvMissions.RowTemplate.Height = 34
        Me.dgvMissions.Size = New System.Drawing.Size(785, 204)
        Me.dgvMissions.TabIndex = 2
        '
        'pnlCardMission
        '
        Me.pnlCardMission.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pnlCardMission.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardMission.Controls.Add(Me.Panel3)
        Me.pnlCardMission.Controls.Add(Me.lblMissionTxt)
        Me.pnlCardMission.Controls.Add(Me.lblMissionVeh)
        Me.pnlCardMission.Location = New System.Drawing.Point(420, 20)
        Me.pnlCardMission.Name = "pnlCardMission"
        Me.pnlCardMission.Size = New System.Drawing.Size(185, 100)
        Me.pnlCardMission.TabIndex = 1
        '
        'lblMissionTxt
        '
        Me.lblMissionTxt.AutoSize = True
        Me.lblMissionTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMissionTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblMissionTxt.Location = New System.Drawing.Point(15, 8)
        Me.lblMissionTxt.Name = "lblMissionTxt"
        Me.lblMissionTxt.Size = New System.Drawing.Size(64, 15)
        Me.lblMissionTxt.TabIndex = 4
        Me.lblMissionTxt.Text = "En Mission"
        '
        'lblMissionVeh
        '
        Me.lblMissionVeh.AutoSize = True
        Me.lblMissionVeh.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMissionVeh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.lblMissionVeh.Location = New System.Drawing.Point(55, 35)
        Me.lblMissionVeh.Name = "lblMissionVeh"
        Me.lblMissionVeh.Size = New System.Drawing.Size(40, 47)
        Me.lblMissionVeh.TabIndex = 5
        Me.lblMissionVeh.Text = "0"
        '
        'pnlCardMaint
        '
        Me.pnlCardMaint.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(15, Byte), Integer), CType(CType(15, Byte), Integer))
        Me.pnlCardMaint.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardMaint.Controls.Add(Me.Panel4)
        Me.pnlCardMaint.Controls.Add(Me.lblMaintenTxt)
        Me.pnlCardMaint.Controls.Add(Me.lblMaintenVeh)
        Me.pnlCardMaint.Location = New System.Drawing.Point(620, 20)
        Me.pnlCardMaint.Name = "pnlCardMaint"
        Me.pnlCardMaint.Size = New System.Drawing.Size(185, 100)
        Me.pnlCardMaint.TabIndex = 1
        '
        'lblMaintenTxt
        '
        Me.lblMaintenTxt.AutoSize = True
        Me.lblMaintenTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaintenTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblMaintenTxt.Location = New System.Drawing.Point(15, 8)
        Me.lblMaintenTxt.Name = "lblMaintenTxt"
        Me.lblMaintenTxt.Size = New System.Drawing.Size(79, 15)
        Me.lblMaintenTxt.TabIndex = 2
        Me.lblMaintenTxt.Text = "Maintenance"
        '
        'lblMaintenVeh
        '
        Me.lblMaintenVeh.AutoSize = True
        Me.lblMaintenVeh.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaintenVeh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.lblMaintenVeh.Location = New System.Drawing.Point(55, 35)
        Me.lblMaintenVeh.Name = "lblMaintenVeh"
        Me.lblMaintenVeh.Size = New System.Drawing.Size(40, 47)
        Me.lblMaintenVeh.TabIndex = 3
        Me.lblMaintenVeh.Text = "0"
        '
        'pnlCardDispo
        '
        Me.pnlCardDispo.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.pnlCardDispo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardDispo.Controls.Add(Me.Panel2)
        Me.pnlCardDispo.Controls.Add(Me.lblDispoVeh)
        Me.pnlCardDispo.Controls.Add(Me.lblDispoTxt)
        Me.pnlCardDispo.Location = New System.Drawing.Point(220, 20)
        Me.pnlCardDispo.Name = "pnlCardDispo"
        Me.pnlCardDispo.Size = New System.Drawing.Size(185, 100)
        Me.pnlCardDispo.TabIndex = 1
        '
        'lblDispoVeh
        '
        Me.lblDispoVeh.AutoSize = True
        Me.lblDispoVeh.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispoVeh.ForeColor = System.Drawing.Color.Green
        Me.lblDispoVeh.Location = New System.Drawing.Point(55, 35)
        Me.lblDispoVeh.Name = "lblDispoVeh"
        Me.lblDispoVeh.Size = New System.Drawing.Size(40, 47)
        Me.lblDispoVeh.TabIndex = 1
        Me.lblDispoVeh.Text = "0"
        '
        'lblDispoTxt
        '
        Me.lblDispoTxt.AutoSize = True
        Me.lblDispoTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDispoTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblDispoTxt.Location = New System.Drawing.Point(15, 8)
        Me.lblDispoTxt.Name = "lblDispoTxt"
        Me.lblDispoTxt.Size = New System.Drawing.Size(70, 15)
        Me.lblDispoTxt.TabIndex = 0
        Me.lblDispoTxt.Text = "Disponibles"
        '
        'pnlCardTotal
        '
        Me.pnlCardTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(20, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.pnlCardTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCardTotal.Controls.Add(Me.pnlBordTotal)
        Me.pnlCardTotal.Controls.Add(Me.lblTotalTxt)
        Me.pnlCardTotal.Controls.Add(Me.lblTotalVeh)
        Me.pnlCardTotal.Location = New System.Drawing.Point(20, 20)
        Me.pnlCardTotal.Name = "pnlCardTotal"
        Me.pnlCardTotal.Size = New System.Drawing.Size(185, 100)
        Me.pnlCardTotal.TabIndex = 0
        '
        'lblTotalTxt
        '
        Me.lblTotalTxt.AutoSize = True
        Me.lblTotalTxt.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalTxt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblTotalTxt.Location = New System.Drawing.Point(18, 5)
        Me.lblTotalTxt.Name = "lblTotalTxt"
        Me.lblTotalTxt.Size = New System.Drawing.Size(89, 15)
        Me.lblTotalTxt.TabIndex = 1
        Me.lblTotalTxt.Text = "Total Véhicules"
        '
        'lblTotalVeh
        '
        Me.lblTotalVeh.AutoSize = True
        Me.lblTotalVeh.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalVeh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.lblTotalVeh.Location = New System.Drawing.Point(55, 35)
        Me.lblTotalVeh.Name = "lblTotalVeh"
        Me.lblTotalVeh.Size = New System.Drawing.Size(40, 47)
        Me.lblTotalVeh.TabIndex = 0
        Me.lblTotalVeh.Text = "0"
        '
        'pnlBordTotal
        '
        Me.pnlBordTotal.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.pnlBordTotal.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlBordTotal.Location = New System.Drawing.Point(0, 0)
        Me.pnlBordTotal.Name = "pnlBordTotal"
        Me.pnlBordTotal.Size = New System.Drawing.Size(183, 4)
        Me.pnlBordTotal.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(16, Byte), Integer), CType(CType(185, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(183, 4)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(183, 4)
        Me.Panel3.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(183, 4)
        Me.Panel4.TabIndex = 3
        '
        'FrmTableauBord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1027, 627)
        Me.Controls.Add(Me.pnlContenu)
        Me.Controls.Add(Me.pnlMenu)
        Me.Controls.Add(Me.pnlHaut)
        Me.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.MaximizeBox = False
        Me.Name = "FrmTableauBord"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tableau de Bord — SGPVA"
        Me.pnlHaut.ResumeLayout(False)
        Me.pnlHaut.PerformLayout()
        Me.pnlMenu.ResumeLayout(False)
        Me.pnlContenu.ResumeLayout(False)
        Me.pnlContenu.PerformLayout()
        CType(Me.dgvAlertes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMissions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlCardMission.ResumeLayout(False)
        Me.pnlCardMission.PerformLayout()
        Me.pnlCardMaint.ResumeLayout(False)
        Me.pnlCardMaint.PerformLayout()
        Me.pnlCardDispo.ResumeLayout(False)
        Me.pnlCardDispo.PerformLayout()
        Me.pnlCardTotal.ResumeLayout(False)
        Me.pnlCardTotal.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHaut As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents lblNomUser As Label
    Friend WithEvents pnlMenu As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents btnMenuMissions As Button
    Friend WithEvents btnMenuVehicules As Button
    Friend WithEvents btnMenuChauffeurs As Button
    Friend WithEvents btnMenuMaintenance As Button
    Friend WithEvents btnDeconnexion As Button
    Friend WithEvents pnlContenu As Panel
    Friend WithEvents pnlCardTotal As Panel
    Friend WithEvents pnlCardMission As Panel
    Friend WithEvents pnlCardMaint As Panel
    Friend WithEvents pnlCardDispo As Panel
    Friend WithEvents lblTotalVeh As Label
    Friend WithEvents lblTotalTxt As Label
    Friend WithEvents lblDispoVeh As Label
    Friend WithEvents lblDispoTxt As Label
    Friend WithEvents lblMissionTxt As Label
    Friend WithEvents lblMissionVeh As Label
    Friend WithEvents lblMaintenTxt As Label
    Friend WithEvents lblMaintenVeh As Label
    Friend WithEvents dgvAlertes As DataGridView
    Friend WithEvents dgvMissions As DataGridView
    Friend WithEvents lblTitreAlertes As Label
    Friend WithEvents lblTitreMissions As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents pnlBordTotal As Panel
End Class
