<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmChauffeurs
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlHautMissions = New System.Windows.Forms.Panel()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.lblTitreMissions = New System.Windows.Forms.Label()
        Me.pnlFormMission = New System.Windows.Forms.Panel()
        Me.cboService = New System.Windows.Forms.ComboBox()
        Me.txtPermis = New System.Windows.Forms.TextBox()
        Me.txtMatricule = New System.Windows.Forms.TextBox()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.dtpExpPermis = New System.Windows.Forms.DateTimePicker()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.cboCatPermis = New System.Windows.Forms.ComboBox()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txtTelephone = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtNom = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblFormTitre = New System.Windows.Forms.Label()
        Me.pnlListe = New System.Windows.Forms.Panel()
        Me.dgvChauffeurs = New System.Windows.Forms.DataGridView()
        Me.menuContextChauffeur = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuModifier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuConge = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuActif = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSuspendre = New System.Windows.Forms.ToolStripMenuItem()
        Me.Séparateur = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSupprimer = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlFiltres = New System.Windows.Forms.Panel()
        Me.btnFiltreConge = New System.Windows.Forms.Button()
        Me.btnFiltreActif = New System.Windows.Forms.Button()
        Me.btnFiltreAll = New System.Windows.Forms.Button()
        Me.lblTitreListe = New System.Windows.Forms.Label()
        Me.btnFiltreSuspendu = New System.Windows.Forms.Button()
        Me.pnlHautMissions.SuspendLayout()
        Me.pnlFormMission.SuspendLayout()
        Me.pnlListe.SuspendLayout()
        CType(Me.dgvChauffeurs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuContextChauffeur.SuspendLayout()
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
        Me.pnlHautMissions.TabIndex = 1
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
        Me.pnlFormMission.Controls.Add(Me.cboService)
        Me.pnlFormMission.Controls.Add(Me.txtPermis)
        Me.pnlFormMission.Controls.Add(Me.txtMatricule)
        Me.pnlFormMission.Controls.Add(Me.btnAnnuler)
        Me.pnlFormMission.Controls.Add(Me.btnAjouter)
        Me.pnlFormMission.Controls.Add(Me.lbl7)
        Me.pnlFormMission.Controls.Add(Me.dtpExpPermis)
        Me.pnlFormMission.Controls.Add(Me.lbl6)
        Me.pnlFormMission.Controls.Add(Me.cboCatPermis)
        Me.pnlFormMission.Controls.Add(Me.lbl5)
        Me.pnlFormMission.Controls.Add(Me.lbl4)
        Me.pnlFormMission.Controls.Add(Me.txtTelephone)
        Me.pnlFormMission.Controls.Add(Me.lbl3)
        Me.pnlFormMission.Controls.Add(Me.txtNom)
        Me.pnlFormMission.Controls.Add(Me.lbl2)
        Me.pnlFormMission.Controls.Add(Me.lbl1)
        Me.pnlFormMission.Controls.Add(Me.lblFormTitre)
        Me.pnlFormMission.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFormMission.Location = New System.Drawing.Point(0, 60)
        Me.pnlFormMission.Name = "pnlFormMission"
        Me.pnlFormMission.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlFormMission.Size = New System.Drawing.Size(350, 601)
        Me.pnlFormMission.TabIndex = 2
        '
        'cboService
        '
        Me.cboService.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cboService.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboService.ForeColor = System.Drawing.Color.White
        Me.cboService.FormattingEnabled = True
        Me.cboService.Location = New System.Drawing.Point(20, 461)
        Me.cboService.Name = "cboService"
        Me.cboService.Size = New System.Drawing.Size(300, 21)
        Me.cboService.TabIndex = 19
        '
        'txtPermis
        '
        Me.txtPermis.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtPermis.ForeColor = System.Drawing.Color.White
        Me.txtPermis.Location = New System.Drawing.Point(20, 265)
        Me.txtPermis.Name = "txtPermis"
        Me.txtPermis.Size = New System.Drawing.Size(300, 20)
        Me.txtPermis.TabIndex = 18
        '
        'txtMatricule
        '
        Me.txtMatricule.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtMatricule.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatricule.ForeColor = System.Drawing.Color.White
        Me.txtMatricule.Location = New System.Drawing.Point(20, 80)
        Me.txtMatricule.Name = "txtMatricule"
        Me.txtMatricule.Size = New System.Drawing.Size(300, 23)
        Me.txtMatricule.TabIndex = 17
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
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAjouter.FlatAppearance.BorderSize = 0
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Location = New System.Drawing.Point(20, 510)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(300, 40)
        Me.btnAjouter.TabIndex = 15
        Me.btnAjouter.Text = "✅ Ajouter le Chauffeur"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl7.Location = New System.Drawing.Point(20, 440)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(44, 15)
        Me.lbl7.TabIndex = 13
        Me.lbl7.Text = "Service"
        '
        'dtpExpPermis
        '
        Me.dtpExpPermis.CalendarFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpExpPermis.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtpExpPermis.Location = New System.Drawing.Point(20, 396)
        Me.dtpExpPermis.Name = "dtpExpPermis"
        Me.dtpExpPermis.Size = New System.Drawing.Size(300, 20)
        Me.dtpExpPermis.TabIndex = 12
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl6.Location = New System.Drawing.Point(20, 376)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(99, 15)
        Me.lbl6.TabIndex = 11
        Me.lbl6.Text = "Expiration Permis"
        '
        'cboCatPermis
        '
        Me.cboCatPermis.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cboCatPermis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCatPermis.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCatPermis.ForeColor = System.Drawing.Color.White
        Me.cboCatPermis.FormattingEnabled = True
        Me.cboCatPermis.Location = New System.Drawing.Point(20, 332)
        Me.cboCatPermis.Name = "cboCatPermis"
        Me.cboCatPermis.Size = New System.Drawing.Size(300, 23)
        Me.cboCatPermis.TabIndex = 10
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl5.Location = New System.Drawing.Point(20, 312)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(97, 15)
        Me.lbl5.TabIndex = 9
        Me.lbl5.Text = "Catégorie Permis"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl4.Location = New System.Drawing.Point(20, 248)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(60, 15)
        Me.lbl4.TabIndex = 7
        Me.lbl4.Text = "N° Permis"
        '
        'txtTelephone
        '
        Me.txtTelephone.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtTelephone.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelephone.ForeColor = System.Drawing.Color.White
        Me.txtTelephone.Location = New System.Drawing.Point(20, 205)
        Me.txtTelephone.Name = "txtTelephone"
        Me.txtTelephone.Size = New System.Drawing.Size(300, 23)
        Me.txtTelephone.TabIndex = 6
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(20, 185)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(61, 15)
        Me.lbl3.TabIndex = 5
        Me.lbl3.Text = "Téléphone"
        '
        'txtNom
        '
        Me.txtNom.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtNom.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNom.ForeColor = System.Drawing.Color.White
        Me.txtNom.Location = New System.Drawing.Point(20, 140)
        Me.txtNom.Name = "txtNom"
        Me.txtNom.Size = New System.Drawing.Size(300, 23)
        Me.txtNom.TabIndex = 4
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(20, 120)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(82, 15)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "Nom & Prénom"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(20, 60)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(57, 15)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Matricule"
        '
        'lblFormTitre
        '
        Me.lblFormTitre.AutoSize = True
        Me.lblFormTitre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitre.ForeColor = System.Drawing.Color.White
        Me.lblFormTitre.Location = New System.Drawing.Point(20, 20)
        Me.lblFormTitre.Name = "lblFormTitre"
        Me.lblFormTitre.Size = New System.Drawing.Size(184, 20)
        Me.lblFormTitre.TabIndex = 0
        Me.lblFormTitre.Text = "➕ Ajouter un Chauffeur"
        '
        'pnlListe
        '
        Me.pnlListe.Controls.Add(Me.dgvChauffeurs)
        Me.pnlListe.Controls.Add(Me.pnlFiltres)
        Me.pnlListe.Controls.Add(Me.lblTitreListe)
        Me.pnlListe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlListe.Location = New System.Drawing.Point(350, 60)
        Me.pnlListe.Name = "pnlListe"
        Me.pnlListe.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlListe.Size = New System.Drawing.Size(734, 601)
        Me.pnlListe.TabIndex = 3
        '
        'dgvChauffeurs
        '
        Me.dgvChauffeurs.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.dgvChauffeurs.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvChauffeurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChauffeurs.ContextMenuStrip = Me.menuContextChauffeur
        Me.dgvChauffeurs.Location = New System.Drawing.Point(20, 95)
        Me.dgvChauffeurs.Name = "dgvChauffeurs"
        Me.dgvChauffeurs.ReadOnly = True
        Me.dgvChauffeurs.RowHeadersVisible = False
        Me.dgvChauffeurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvChauffeurs.Size = New System.Drawing.Size(700, 500)
        Me.dgvChauffeurs.TabIndex = 2
        '
        'menuContextChauffeur
        '
        Me.menuContextChauffeur.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModifier, Me.mnuConge, Me.mnuActif, Me.mnuSuspendre, Me.Séparateur, Me.mnuSupprimer})
        Me.menuContextChauffeur.Name = "menuContextChauffeur"
        Me.menuContextChauffeur.Size = New System.Drawing.Size(204, 136)
        '
        'mnuModifier
        '
        Me.mnuModifier.Name = "mnuModifier"
        Me.mnuModifier.Size = New System.Drawing.Size(203, 22)
        Me.mnuModifier.Text = "✏️ Modifier ce chauffeur"
        '
        'mnuConge
        '
        Me.mnuConge.Name = "mnuConge"
        Me.mnuConge.Size = New System.Drawing.Size(203, 22)
        Me.mnuConge.Text = "🏖️ Mettre en Congé"
        '
        'mnuActif
        '
        Me.mnuActif.Name = "mnuActif"
        Me.mnuActif.Size = New System.Drawing.Size(203, 22)
        Me.mnuActif.Text = "✅ Remettre Actif"
        '
        'mnuSuspendre
        '
        Me.mnuSuspendre.Name = "mnuSuspendre"
        Me.mnuSuspendre.Size = New System.Drawing.Size(203, 22)
        Me.mnuSuspendre.Text = "🚫 Suspendre"
        '
        'Séparateur
        '
        Me.Séparateur.Name = "Séparateur"
        Me.Séparateur.Size = New System.Drawing.Size(203, 22)
        Me.Séparateur.Text = "───────────────"
        '
        'mnuSupprimer
        '
        Me.mnuSupprimer.Name = "mnuSupprimer"
        Me.mnuSupprimer.Size = New System.Drawing.Size(203, 22)
        Me.mnuSupprimer.Text = "🗑️ Supprimer"
        '
        'pnlFiltres
        '
        Me.pnlFiltres.Controls.Add(Me.btnFiltreSuspendu)
        Me.pnlFiltres.Controls.Add(Me.btnFiltreConge)
        Me.pnlFiltres.Controls.Add(Me.btnFiltreActif)
        Me.pnlFiltres.Controls.Add(Me.btnFiltreAll)
        Me.pnlFiltres.Location = New System.Drawing.Point(20, 45)
        Me.pnlFiltres.Name = "pnlFiltres"
        Me.pnlFiltres.Size = New System.Drawing.Size(700, 40)
        Me.pnlFiltres.TabIndex = 1
        '
        'btnFiltreConge
        '
        Me.btnFiltreConge.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnFiltreConge.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltreConge.FlatAppearance.BorderSize = 0
        Me.btnFiltreConge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltreConge.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltreConge.ForeColor = System.Drawing.Color.White
        Me.btnFiltreConge.Location = New System.Drawing.Point(200, 5)
        Me.btnFiltreConge.Name = "btnFiltreConge"
        Me.btnFiltreConge.Size = New System.Drawing.Size(90, 30)
        Me.btnFiltreConge.TabIndex = 2
        Me.btnFiltreConge.Text = "Congé"
        Me.btnFiltreConge.UseVisualStyleBackColor = False
        '
        'btnFiltreActif
        '
        Me.btnFiltreActif.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnFiltreActif.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltreActif.FlatAppearance.BorderSize = 0
        Me.btnFiltreActif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltreActif.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltreActif.ForeColor = System.Drawing.Color.White
        Me.btnFiltreActif.Location = New System.Drawing.Point(100, 5)
        Me.btnFiltreActif.Name = "btnFiltreActif"
        Me.btnFiltreActif.Size = New System.Drawing.Size(90, 30)
        Me.btnFiltreActif.TabIndex = 1
        Me.btnFiltreActif.Text = "Actifs"
        Me.btnFiltreActif.UseVisualStyleBackColor = False
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
        Me.btnFiltreAll.Text = "Tous"
        Me.btnFiltreAll.UseVisualStyleBackColor = False
        '
        'lblTitreListe
        '
        Me.lblTitreListe.AutoSize = True
        Me.lblTitreListe.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreListe.ForeColor = System.Drawing.Color.White
        Me.lblTitreListe.Location = New System.Drawing.Point(20, 20)
        Me.lblTitreListe.Name = "lblTitreListe"
        Me.lblTitreListe.Size = New System.Drawing.Size(177, 20)
        Me.lblTitreListe.TabIndex = 0
        Me.lblTitreListe.Text = "👤 Liste des Chauffeurs"
        '
        'btnFiltreSuspendu
        '
        Me.btnFiltreSuspendu.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnFiltreSuspendu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltreSuspendu.FlatAppearance.BorderSize = 0
        Me.btnFiltreSuspendu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltreSuspendu.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltreSuspendu.ForeColor = System.Drawing.Color.White
        Me.btnFiltreSuspendu.Location = New System.Drawing.Point(305, 5)
        Me.btnFiltreSuspendu.Name = "btnFiltreSuspendu"
        Me.btnFiltreSuspendu.Size = New System.Drawing.Size(90, 30)
        Me.btnFiltreSuspendu.TabIndex = 3
        Me.btnFiltreSuspendu.Text = "Suspendu"
        Me.btnFiltreSuspendu.UseVisualStyleBackColor = False
        '
        'FrmChauffeurs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.pnlListe)
        Me.Controls.Add(Me.pnlFormMission)
        Me.Controls.Add(Me.pnlHautMissions)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmChauffeurs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmChauffeurs"
        Me.pnlHautMissions.ResumeLayout(False)
        Me.pnlHautMissions.PerformLayout()
        Me.pnlFormMission.ResumeLayout(False)
        Me.pnlFormMission.PerformLayout()
        Me.pnlListe.ResumeLayout(False)
        Me.pnlListe.PerformLayout()
        CType(Me.dgvChauffeurs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuContextChauffeur.ResumeLayout(False)
        Me.pnlFiltres.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHautMissions As Panel
    Friend WithEvents btnRetour As Button
    Friend WithEvents lblTitreMissions As Label
    Friend WithEvents pnlFormMission As Panel
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnAjouter As Button
    Friend WithEvents lbl7 As Label
    Friend WithEvents dtpExpPermis As DateTimePicker
    Friend WithEvents lbl6 As Label
    Friend WithEvents cboCatPermis As ComboBox
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents txtTelephone As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents txtNom As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblFormTitre As Label
    Friend WithEvents txtMatricule As TextBox
    Friend WithEvents txtPermis As TextBox
    Friend WithEvents cboService As ComboBox
    Friend WithEvents pnlListe As Panel
    Friend WithEvents dgvChauffeurs As DataGridView
    Friend WithEvents pnlFiltres As Panel
    Friend WithEvents btnFiltreConge As Button
    Friend WithEvents btnFiltreActif As Button
    Friend WithEvents btnFiltreAll As Button
    Friend WithEvents lblTitreListe As Label
    Friend WithEvents menuContextChauffeur As ContextMenuStrip
    Friend WithEvents mnuModifier As ToolStripMenuItem
    Friend WithEvents mnuConge As ToolStripMenuItem
    Friend WithEvents mnuActif As ToolStripMenuItem
    Friend WithEvents mnuSuspendre As ToolStripMenuItem
    Friend WithEvents Séparateur As ToolStripMenuItem
    Friend WithEvents mnuSupprimer As ToolStripMenuItem
    Friend WithEvents btnFiltreSuspendu As Button
End Class
