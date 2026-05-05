<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMissions
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
        Me.components = New System.ComponentModel.Container()
        Me.pnlHautMissions = New System.Windows.Forms.Panel()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.lblTitreMissions = New System.Windows.Forms.Label()
        Me.pnlFormMission = New System.Windows.Forms.Panel()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnCreerMission = New System.Windows.Forms.Button()
        Me.dtpRetour = New System.Windows.Forms.DateTimePicker()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.dtpDepart = New System.Windows.Forms.DateTimePicker()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.cboChauffeur = New System.Windows.Forms.ComboBox()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.cboVehicule = New System.Windows.Forms.ComboBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txtDestination = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtMotif = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.cboService = New System.Windows.Forms.ComboBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblFormTitre = New System.Windows.Forms.Label()
        Me.pnlListeMissions = New System.Windows.Forms.Panel()
        Me.dgvMissions = New System.Windows.Forms.DataGridView()
        Me.menuContextMission = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuModifierMission = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMettreEnAttente = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuValiderMission = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAnnulerMission = New System.Windows.Forms.ToolStripMenuItem()
        Me.Séparateur = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSupprimerMission = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlFiltres = New System.Windows.Forms.Panel()
        Me.btnFiltreTerminee = New System.Windows.Forms.Button()
        Me.btnFiltreAttente = New System.Windows.Forms.Button()
        Me.btnFiltreEnCours = New System.Windows.Forms.Button()
        Me.btnFiltreAll = New System.Windows.Forms.Button()
        Me.lblTitreListe = New System.Windows.Forms.Label()
        Me.pnlHautMissions.SuspendLayout()
        Me.pnlFormMission.SuspendLayout()
        Me.pnlListeMissions.SuspendLayout()
        CType(Me.dgvMissions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuContextMission.SuspendLayout()
        Me.pnlFiltres.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHautMissions
        '
        Me.pnlHautMissions.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlHautMissions.Controls.Add(Me.btnRetour)
        Me.pnlHautMissions.Controls.Add(Me.lblTitreMissions)
        Me.pnlHautMissions.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHautMissions.Location = New System.Drawing.Point(0, 0)
        Me.pnlHautMissions.Name = "pnlHautMissions"
        Me.pnlHautMissions.Size = New System.Drawing.Size(1084, 60)
        Me.pnlHautMissions.TabIndex = 0
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnRetour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRetour.FlatAppearance.BorderSize = 0
        Me.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetour.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetour.ForeColor = System.Drawing.Color.White
        Me.btnRetour.Location = New System.Drawing.Point(914, 18)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(100, 32)
        Me.btnRetour.TabIndex = 1
        Me.btnRetour.Text = "← Retour"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'lblTitreMissions
        '
        Me.lblTitreMissions.AutoSize = True
        Me.lblTitreMissions.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreMissions.ForeColor = System.Drawing.Color.White
        Me.lblTitreMissions.Location = New System.Drawing.Point(20, 18)
        Me.lblTitreMissions.Name = "lblTitreMissions"
        Me.lblTitreMissions.Size = New System.Drawing.Size(203, 23)
        Me.lblTitreMissions.TabIndex = 0
        Me.lblTitreMissions.Text = "📋 Gestion des Missions"
        '
        'pnlFormMission
        '
        Me.pnlFormMission.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlFormMission.Controls.Add(Me.btnAnnuler)
        Me.pnlFormMission.Controls.Add(Me.btnCreerMission)
        Me.pnlFormMission.Controls.Add(Me.dtpRetour)
        Me.pnlFormMission.Controls.Add(Me.lbl7)
        Me.pnlFormMission.Controls.Add(Me.dtpDepart)
        Me.pnlFormMission.Controls.Add(Me.lbl6)
        Me.pnlFormMission.Controls.Add(Me.cboChauffeur)
        Me.pnlFormMission.Controls.Add(Me.lbl5)
        Me.pnlFormMission.Controls.Add(Me.cboVehicule)
        Me.pnlFormMission.Controls.Add(Me.lbl4)
        Me.pnlFormMission.Controls.Add(Me.txtDestination)
        Me.pnlFormMission.Controls.Add(Me.lbl3)
        Me.pnlFormMission.Controls.Add(Me.txtMotif)
        Me.pnlFormMission.Controls.Add(Me.lbl2)
        Me.pnlFormMission.Controls.Add(Me.cboService)
        Me.pnlFormMission.Controls.Add(Me.lbl1)
        Me.pnlFormMission.Controls.Add(Me.lblFormTitre)
        Me.pnlFormMission.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFormMission.Location = New System.Drawing.Point(0, 60)
        Me.pnlFormMission.Name = "pnlFormMission"
        Me.pnlFormMission.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlFormMission.Size = New System.Drawing.Size(350, 601)
        Me.pnlFormMission.TabIndex = 1
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnuler.FlatAppearance.BorderSize = 0
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.ForeColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnAnnuler.Location = New System.Drawing.Point(20, 560)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(300, 35)
        Me.btnAnnuler.TabIndex = 16
        Me.btnAnnuler.Text = "✕ Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'btnCreerMission
        '
        Me.btnCreerMission.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnCreerMission.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCreerMission.FlatAppearance.BorderSize = 0
        Me.btnCreerMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreerMission.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreerMission.ForeColor = System.Drawing.Color.White
        Me.btnCreerMission.Location = New System.Drawing.Point(20, 510)
        Me.btnCreerMission.Name = "btnCreerMission"
        Me.btnCreerMission.Size = New System.Drawing.Size(300, 40)
        Me.btnCreerMission.TabIndex = 15
        Me.btnCreerMission.Text = "✅ Créer la Mission"
        Me.btnCreerMission.UseVisualStyleBackColor = False
        '
        'dtpRetour
        '
        Me.dtpRetour.Location = New System.Drawing.Point(20, 460)
        Me.dtpRetour.Name = "dtpRetour"
        Me.dtpRetour.Size = New System.Drawing.Size(300, 20)
        Me.dtpRetour.TabIndex = 14
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl7.Location = New System.Drawing.Point(20, 440)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(140, 15)
        Me.lbl7.TabIndex = 13
        Me.lbl7.Text = "Date & Heure Retour Prévu"
        '
        'dtpDepart
        '
        Me.dtpDepart.CalendarFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDepart.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpDepart.Location = New System.Drawing.Point(20, 396)
        Me.dtpDepart.Name = "dtpDepart"
        Me.dtpDepart.Size = New System.Drawing.Size(300, 20)
        Me.dtpDepart.TabIndex = 12
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl6.Location = New System.Drawing.Point(20, 376)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(107, 15)
        Me.lbl6.TabIndex = 11
        Me.lbl6.Text = "Date & Heure Départ"
        '
        'cboChauffeur
        '
        Me.cboChauffeur.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cboChauffeur.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboChauffeur.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboChauffeur.ForeColor = System.Drawing.Color.White
        Me.cboChauffeur.FormattingEnabled = True
        Me.cboChauffeur.Location = New System.Drawing.Point(20, 332)
        Me.cboChauffeur.Name = "cboChauffeur"
        Me.cboChauffeur.Size = New System.Drawing.Size(300, 23)
        Me.cboChauffeur.TabIndex = 10
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl5.Location = New System.Drawing.Point(20, 312)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(60, 15)
        Me.lbl5.TabIndex = 9
        Me.lbl5.Text = "Chauffeur"
        '
        'cboVehicule
        '
        Me.cboVehicule.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cboVehicule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVehicule.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehicule.ForeColor = System.Drawing.Color.White
        Me.cboVehicule.FormattingEnabled = True
        Me.cboVehicule.Location = New System.Drawing.Point(20, 268)
        Me.cboVehicule.Name = "cboVehicule"
        Me.cboVehicule.Size = New System.Drawing.Size(300, 23)
        Me.cboVehicule.TabIndex = 8
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl4.Location = New System.Drawing.Point(20, 248)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(109, 15)
        Me.lbl4.TabIndex = 7
        Me.lbl4.Text = "Véhicule disponible"
        '
        'txtDestination
        '
        Me.txtDestination.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtDestination.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDestination.ForeColor = System.Drawing.Color.White
        Me.txtDestination.Location = New System.Drawing.Point(20, 205)
        Me.txtDestination.Name = "txtDestination"
        Me.txtDestination.Size = New System.Drawing.Size(300, 23)
        Me.txtDestination.TabIndex = 6
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(20, 185)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(67, 15)
        Me.lbl3.TabIndex = 5
        Me.lbl3.Text = "Destination"
        '
        'txtMotif
        '
        Me.txtMotif.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtMotif.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotif.ForeColor = System.Drawing.Color.White
        Me.txtMotif.Location = New System.Drawing.Point(20, 140)
        Me.txtMotif.Name = "txtMotif"
        Me.txtMotif.Size = New System.Drawing.Size(300, 23)
        Me.txtMotif.TabIndex = 4
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(20, 120)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(76, 15)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "Motif / Objet"
        '
        'cboService
        '
        Me.cboService.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cboService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboService.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboService.ForeColor = System.Drawing.Color.White
        Me.cboService.FormattingEnabled = True
        Me.cboService.Location = New System.Drawing.Point(20, 80)
        Me.cboService.Name = "cboService"
        Me.cboService.Size = New System.Drawing.Size(300, 23)
        Me.cboService.TabIndex = 2
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(20, 60)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(109, 15)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Service Demandeur"
        '
        'lblFormTitre
        '
        Me.lblFormTitre.AutoSize = True
        Me.lblFormTitre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitre.ForeColor = System.Drawing.Color.White
        Me.lblFormTitre.Location = New System.Drawing.Point(20, 20)
        Me.lblFormTitre.Name = "lblFormTitre"
        Me.lblFormTitre.Size = New System.Drawing.Size(155, 20)
        Me.lblFormTitre.TabIndex = 0
        Me.lblFormTitre.Text = "➕ Nouvelle Mission"
        '
        'pnlListeMissions
        '
        Me.pnlListeMissions.Controls.Add(Me.dgvMissions)
        Me.pnlListeMissions.Controls.Add(Me.pnlFiltres)
        Me.pnlListeMissions.Controls.Add(Me.lblTitreListe)
        Me.pnlListeMissions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlListeMissions.Location = New System.Drawing.Point(350, 60)
        Me.pnlListeMissions.Name = "pnlListeMissions"
        Me.pnlListeMissions.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlListeMissions.Size = New System.Drawing.Size(734, 601)
        Me.pnlListeMissions.TabIndex = 2
        '
        'dgvMissions
        '
        Me.dgvMissions.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.dgvMissions.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMissions.ContextMenuStrip = Me.menuContextMission
        Me.dgvMissions.Location = New System.Drawing.Point(20, 95)
        Me.dgvMissions.Name = "dgvMissions"
        Me.dgvMissions.ReadOnly = True
        Me.dgvMissions.RowHeadersVisible = False
        Me.dgvMissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMissions.Size = New System.Drawing.Size(700, 500)
        Me.dgvMissions.TabIndex = 2
        '
        'menuContextMission
        '
        Me.menuContextMission.BackColor = System.Drawing.SystemColors.Control
        Me.menuContextMission.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModifierMission, Me.mnuMettreEnAttente, Me.mnuValiderMission, Me.mnuAnnulerMission, Me.Séparateur, Me.mnuSupprimerMission})
        Me.menuContextMission.Name = "menuContextMission"
        Me.menuContextMission.Size = New System.Drawing.Size(208, 158)
        '
        'mnuModifierMission
        '
        Me.mnuModifierMission.Name = "mnuModifierMission"
        Me.mnuModifierMission.Size = New System.Drawing.Size(207, 22)
        Me.mnuModifierMission.Text = "✏️ Modifier cette mission"
        '
        'mnuMettreEnAttente
        '
        Me.mnuMettreEnAttente.Name = "mnuMettreEnAttente"
        Me.mnuMettreEnAttente.Size = New System.Drawing.Size(207, 22)
        Me.mnuMettreEnAttente.Text = "⏸️ Mettre en Attente"
        '
        'mnuValiderMission
        '
        Me.mnuValiderMission.Name = "mnuValiderMission"
        Me.mnuValiderMission.Size = New System.Drawing.Size(207, 22)
        Me.mnuValiderMission.Text = "✅ Valider la Mission"
        '
        'mnuAnnulerMission
        '
        Me.mnuAnnulerMission.Name = "mnuAnnulerMission"
        Me.mnuAnnulerMission.Size = New System.Drawing.Size(207, 22)
        Me.mnuAnnulerMission.Text = "❌ Annuler la Mission"
        '
        'Séparateur
        '
        Me.Séparateur.Name = "Séparateur"
        Me.Séparateur.Size = New System.Drawing.Size(207, 22)
        Me.Séparateur.Text = "───────────────"
        '
        'mnuSupprimerMission
        '
        Me.mnuSupprimerMission.Name = "mnuSupprimerMission"
        Me.mnuSupprimerMission.Size = New System.Drawing.Size(207, 22)
        Me.mnuSupprimerMission.Text = "🗑️ Supprimer"
        '
        'pnlFiltres
        '
        Me.pnlFiltres.Controls.Add(Me.btnFiltreTerminee)
        Me.pnlFiltres.Controls.Add(Me.btnFiltreAttente)
        Me.pnlFiltres.Controls.Add(Me.btnFiltreEnCours)
        Me.pnlFiltres.Controls.Add(Me.btnFiltreAll)
        Me.pnlFiltres.Location = New System.Drawing.Point(20, 45)
        Me.pnlFiltres.Name = "pnlFiltres"
        Me.pnlFiltres.Size = New System.Drawing.Size(700, 40)
        Me.pnlFiltres.TabIndex = 1
        '
        'btnFiltreTerminee
        '
        Me.btnFiltreTerminee.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnFiltreTerminee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltreTerminee.FlatAppearance.BorderSize = 0
        Me.btnFiltreTerminee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltreTerminee.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltreTerminee.ForeColor = System.Drawing.Color.White
        Me.btnFiltreTerminee.Location = New System.Drawing.Point(300, 5)
        Me.btnFiltreTerminee.Name = "btnFiltreTerminee"
        Me.btnFiltreTerminee.Size = New System.Drawing.Size(90, 30)
        Me.btnFiltreTerminee.TabIndex = 3
        Me.btnFiltreTerminee.Text = "Terminées"
        Me.btnFiltreTerminee.UseVisualStyleBackColor = False
        '
        'btnFiltreAttente
        '
        Me.btnFiltreAttente.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnFiltreAttente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltreAttente.FlatAppearance.BorderSize = 0
        Me.btnFiltreAttente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltreAttente.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltreAttente.ForeColor = System.Drawing.Color.White
        Me.btnFiltreAttente.Location = New System.Drawing.Point(200, 5)
        Me.btnFiltreAttente.Name = "btnFiltreAttente"
        Me.btnFiltreAttente.Size = New System.Drawing.Size(90, 30)
        Me.btnFiltreAttente.TabIndex = 2
        Me.btnFiltreAttente.Text = "En Attente"
        Me.btnFiltreAttente.UseVisualStyleBackColor = False
        '
        'btnFiltreEnCours
        '
        Me.btnFiltreEnCours.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnFiltreEnCours.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltreEnCours.FlatAppearance.BorderSize = 0
        Me.btnFiltreEnCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltreEnCours.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltreEnCours.ForeColor = System.Drawing.Color.White
        Me.btnFiltreEnCours.Location = New System.Drawing.Point(100, 5)
        Me.btnFiltreEnCours.Name = "btnFiltreEnCours"
        Me.btnFiltreEnCours.Size = New System.Drawing.Size(90, 30)
        Me.btnFiltreEnCours.TabIndex = 1
        Me.btnFiltreEnCours.Text = "En Cours"
        Me.btnFiltreEnCours.UseVisualStyleBackColor = False
        '
        'btnFiltreAll
        '
        Me.btnFiltreAll.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnFiltreAll.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltreAll.FlatAppearance.BorderSize = 0
        Me.btnFiltreAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltreAll.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltreAll.ForeColor = System.Drawing.Color.White
        Me.btnFiltreAll.Location = New System.Drawing.Point(0, 5)
        Me.btnFiltreAll.Name = "btnFiltreAll"
        Me.btnFiltreAll.Size = New System.Drawing.Size(90, 30)
        Me.btnFiltreAll.TabIndex = 0
        Me.btnFiltreAll.Text = "Toutes"
        Me.btnFiltreAll.UseVisualStyleBackColor = False
        '
        'lblTitreListe
        '
        Me.lblTitreListe.AutoSize = True
        Me.lblTitreListe.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreListe.ForeColor = System.Drawing.Color.White
        Me.lblTitreListe.Location = New System.Drawing.Point(20, 20)
        Me.lblTitreListe.Name = "lblTitreListe"
        Me.lblTitreListe.Size = New System.Drawing.Size(161, 20)
        Me.lblTitreListe.TabIndex = 0
        Me.lblTitreListe.Text = "📋 Liste des Missions"
        '
        'FrmMissions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.pnlListeMissions)
        Me.Controls.Add(Me.pnlFormMission)
        Me.Controls.Add(Me.pnlHautMissions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmMissions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestion des Missions"
        Me.pnlHautMissions.ResumeLayout(False)
        Me.pnlHautMissions.PerformLayout()
        Me.pnlFormMission.ResumeLayout(False)
        Me.pnlFormMission.PerformLayout()
        Me.pnlListeMissions.ResumeLayout(False)
        Me.pnlListeMissions.PerformLayout()
        CType(Me.dgvMissions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuContextMission.ResumeLayout(False)
        Me.pnlFiltres.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHautMissions As Panel
    Friend WithEvents lblTitreMissions As Label
    Friend WithEvents btnRetour As Button
    Friend WithEvents pnlFormMission As Panel
    Friend WithEvents lblFormTitre As Label
    Friend WithEvents cboService As ComboBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents txtMotif As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents txtDestination As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents cboChauffeur As ComboBox
    Friend WithEvents lbl5 As Label
    Friend WithEvents cboVehicule As ComboBox
    Friend WithEvents dtpDepart As DateTimePicker
    Friend WithEvents lbl6 As Label
    Friend WithEvents btnCreerMission As Button
    Friend WithEvents dtpRetour As DateTimePicker
    Friend WithEvents lbl7 As Label
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents pnlListeMissions As Panel
    Friend WithEvents lblTitreListe As Label
    Friend WithEvents dgvMissions As DataGridView
    Friend WithEvents pnlFiltres As Panel
    Friend WithEvents btnFiltreAll As Button
    Friend WithEvents btnFiltreTerminee As Button
    Friend WithEvents btnFiltreAttente As Button
    Friend WithEvents btnFiltreEnCours As Button
    Friend WithEvents menuContextMission As ContextMenuStrip
    Friend WithEvents mnuModifierMission As ToolStripMenuItem
    Friend WithEvents mnuMettreEnAttente As ToolStripMenuItem
    Friend WithEvents mnuValiderMission As ToolStripMenuItem
    Friend WithEvents mnuAnnulerMission As ToolStripMenuItem
    Friend WithEvents Séparateur As ToolStripMenuItem
    Friend WithEvents mnuSupprimerMission As ToolStripMenuItem
End Class
