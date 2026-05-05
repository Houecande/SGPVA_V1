<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMaintenance
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
        Me.pnlHaut = New System.Windows.Forms.Panel()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.pnlFormMaint = New System.Windows.Forms.Panel()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnEnregistrer = New System.Windows.Forms.Button()
        Me.txtCout = New System.Windows.Forms.TextBox()
        Me.dtpSortie = New System.Windows.Forms.DateTimePicker()
        Me.dtpEntree = New System.Windows.Forms.DateTimePicker()
        Me.cboPrestataire = New System.Windows.Forms.ComboBox()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.txtNature = New System.Windows.Forms.TextBox()
        Me.cboVehicule = New System.Windows.Forms.ComboBox()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblFormTitre = New System.Windows.Forms.Label()
        Me.lblTitreListe = New System.Windows.Forms.Label()
        Me.pnlListeMaint = New System.Windows.Forms.Panel()
        Me.dgvMaintenance = New System.Windows.Forms.DataGridView()
        Me.pnlFiltres = New System.Windows.Forms.Panel()
        Me.btnFiltreEnCours = New System.Windows.Forms.Button()
        Me.btnFiltreTerminee = New System.Windows.Forms.Button()
        Me.btnFiltrePlanifiee = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnFiltreAll = New System.Windows.Forms.Button()
        Me.menuContextMaint = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuModifier = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCloturerManuellement = New System.Windows.Forms.ToolStripMenuItem()
        Me.Séparateur = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSupprimer = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlHaut.SuspendLayout()
        Me.pnlFormMaint.SuspendLayout()
        Me.pnlListeMaint.SuspendLayout()
        CType(Me.dgvMaintenance, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnlFiltres.SuspendLayout()
        Me.menuContextMaint.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlHaut
        '
        Me.pnlHaut.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.pnlHaut.Controls.Add(Me.btnRetour)
        Me.pnlHaut.Controls.Add(Me.lblTitre)
        Me.pnlHaut.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlHaut.Location = New System.Drawing.Point(0, 0)
        Me.pnlHaut.Name = "pnlHaut"
        Me.pnlHaut.Size = New System.Drawing.Size(1084, 60)
        Me.pnlHaut.TabIndex = 0
        '
        'btnRetour
        '
        Me.btnRetour.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.btnRetour.FlatAppearance.BorderSize = 0
        Me.btnRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRetour.ForeColor = System.Drawing.Color.White
        Me.btnRetour.Location = New System.Drawing.Point(950, 15)
        Me.btnRetour.Name = "btnRetour"
        Me.btnRetour.Size = New System.Drawing.Size(100, 32)
        Me.btnRetour.TabIndex = 1
        Me.btnRetour.Text = "← Retour"
        Me.btnRetour.UseVisualStyleBackColor = False
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.White
        Me.lblTitre.Location = New System.Drawing.Point(20, 18)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(246, 23)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "🔧 Maintenance & Réparations"
        '
        'pnlFormMaint
        '
        Me.pnlFormMaint.Controls.Add(Me.btnAnnuler)
        Me.pnlFormMaint.Controls.Add(Me.btnEnregistrer)
        Me.pnlFormMaint.Controls.Add(Me.txtCout)
        Me.pnlFormMaint.Controls.Add(Me.dtpSortie)
        Me.pnlFormMaint.Controls.Add(Me.dtpEntree)
        Me.pnlFormMaint.Controls.Add(Me.cboPrestataire)
        Me.pnlFormMaint.Controls.Add(Me.cboType)
        Me.pnlFormMaint.Controls.Add(Me.txtNature)
        Me.pnlFormMaint.Controls.Add(Me.cboVehicule)
        Me.pnlFormMaint.Controls.Add(Me.lbl7)
        Me.pnlFormMaint.Controls.Add(Me.lbl6)
        Me.pnlFormMaint.Controls.Add(Me.lbl5)
        Me.pnlFormMaint.Controls.Add(Me.lbl4)
        Me.pnlFormMaint.Controls.Add(Me.lbl3)
        Me.pnlFormMaint.Controls.Add(Me.lbl2)
        Me.pnlFormMaint.Controls.Add(Me.lbl1)
        Me.pnlFormMaint.Controls.Add(Me.lblFormTitre)
        Me.pnlFormMaint.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlFormMaint.Location = New System.Drawing.Point(0, 60)
        Me.pnlFormMaint.Name = "pnlFormMaint"
        Me.pnlFormMaint.Size = New System.Drawing.Size(350, 601)
        Me.pnlFormMaint.TabIndex = 1
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnAnnuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnuler.FlatAppearance.BorderSize = 0
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.ForeColor = System.Drawing.Color.White
        Me.btnAnnuler.Location = New System.Drawing.Point(20, 560)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(300, 35)
        Me.btnAnnuler.TabIndex = 18
        Me.btnAnnuler.Text = "✕ Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'btnEnregistrer
        '
        Me.btnEnregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnEnregistrer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEnregistrer.FlatAppearance.BorderSize = 0
        Me.btnEnregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEnregistrer.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnregistrer.ForeColor = System.Drawing.Color.White
        Me.btnEnregistrer.Location = New System.Drawing.Point(20, 510)
        Me.btnEnregistrer.Name = "btnEnregistrer"
        Me.btnEnregistrer.Size = New System.Drawing.Size(300, 40)
        Me.btnEnregistrer.TabIndex = 17
        Me.btnEnregistrer.Text = "✅ Enregistrer"
        Me.btnEnregistrer.UseVisualStyleBackColor = False
        '
        'txtCout
        '
        Me.txtCout.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtCout.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCout.ForeColor = System.Drawing.Color.White
        Me.txtCout.Location = New System.Drawing.Point(20, 460)
        Me.txtCout.Name = "txtCout"
        Me.txtCout.Size = New System.Drawing.Size(300, 23)
        Me.txtCout.TabIndex = 16
        '
        'dtpSortie
        '
        Me.dtpSortie.Location = New System.Drawing.Point(20, 396)
        Me.dtpSortie.Name = "dtpSortie"
        Me.dtpSortie.Size = New System.Drawing.Size(300, 20)
        Me.dtpSortie.TabIndex = 14
        '
        'dtpEntree
        '
        Me.dtpEntree.Location = New System.Drawing.Point(20, 332)
        Me.dtpEntree.Name = "dtpEntree"
        Me.dtpEntree.Size = New System.Drawing.Size(300, 20)
        Me.dtpEntree.TabIndex = 13
        '
        'cboPrestataire
        '
        Me.cboPrestataire.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cboPrestataire.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPrestataire.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPrestataire.ForeColor = System.Drawing.Color.White
        Me.cboPrestataire.FormattingEnabled = True
        Me.cboPrestataire.Location = New System.Drawing.Point(20, 268)
        Me.cboPrestataire.Name = "cboPrestataire"
        Me.cboPrestataire.Size = New System.Drawing.Size(300, 23)
        Me.cboPrestataire.TabIndex = 12
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboType.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboType.ForeColor = System.Drawing.Color.White
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(20, 205)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(300, 23)
        Me.cboType.TabIndex = 11
        '
        'txtNature
        '
        Me.txtNature.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtNature.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNature.ForeColor = System.Drawing.Color.White
        Me.txtNature.Location = New System.Drawing.Point(20, 140)
        Me.txtNature.Name = "txtNature"
        Me.txtNature.Size = New System.Drawing.Size(300, 23)
        Me.txtNature.TabIndex = 10
        '
        'cboVehicule
        '
        Me.cboVehicule.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cboVehicule.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVehicule.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVehicule.ForeColor = System.Drawing.Color.White
        Me.cboVehicule.FormattingEnabled = True
        Me.cboVehicule.Location = New System.Drawing.Point(20, 80)
        Me.cboVehicule.Name = "cboVehicule"
        Me.cboVehicule.Size = New System.Drawing.Size(300, 23)
        Me.cboVehicule.TabIndex = 9
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl7.Location = New System.Drawing.Point(20, 440)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(109, 15)
        Me.lbl7.TabIndex = 7
        Me.lbl7.Text = "Coût estimé (FCFA)"
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl6.Location = New System.Drawing.Point(20, 376)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(103, 15)
        Me.lbl6.TabIndex = 6
        Me.lbl6.Text = "Date Sortie Prévue"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl5.Location = New System.Drawing.Point(20, 312)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(104, 15)
        Me.lbl5.TabIndex = 5
        Me.lbl5.Text = "Date Entrée Atelier"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl4.Location = New System.Drawing.Point(20, 248)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(62, 15)
        Me.lbl4.TabIndex = 4
        Me.lbl4.Text = "Prestataire"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(20, 185)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(31, 15)
        Me.lbl3.TabIndex = 3
        Me.lbl3.Text = "Type"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(20, 120)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(132, 15)
        Me.lbl2.TabIndex = 2
        Me.lbl2.Text = "Nature de l'Intervention"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(20, 60)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(51, 15)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Véhicule"
        '
        'lblFormTitre
        '
        Me.lblFormTitre.AutoSize = True
        Me.lblFormTitre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitre.ForeColor = System.Drawing.Color.White
        Me.lblFormTitre.Location = New System.Drawing.Point(20, 20)
        Me.lblFormTitre.Name = "lblFormTitre"
        Me.lblFormTitre.Size = New System.Drawing.Size(189, 20)
        Me.lblFormTitre.TabIndex = 0
        Me.lblFormTitre.Text = "➕ Nouvelle Intervention"
        '
        'lblTitreListe
        '
        Me.lblTitreListe.AutoSize = True
        Me.lblTitreListe.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreListe.ForeColor = System.Drawing.Color.White
        Me.lblTitreListe.Location = New System.Drawing.Point(20, 20)
        Me.lblTitreListe.Name = "lblTitreListe"
        Me.lblTitreListe.Size = New System.Drawing.Size(268, 20)
        Me.lblTitreListe.TabIndex = 15
        Me.lblTitreListe.Text = "🔧 Interventions en cours & planifiées"
        '
        'pnlListeMaint
        '
        Me.pnlListeMaint.Controls.Add(Me.dgvMaintenance)
        Me.pnlListeMaint.Controls.Add(Me.pnlFiltres)
        Me.pnlListeMaint.Controls.Add(Me.lblTitreListe)
        Me.pnlListeMaint.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlListeMaint.Location = New System.Drawing.Point(350, 60)
        Me.pnlListeMaint.Name = "pnlListeMaint"
        Me.pnlListeMaint.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlListeMaint.Size = New System.Drawing.Size(734, 601)
        Me.pnlListeMaint.TabIndex = 2
        '
        'dgvMaintenance
        '
        Me.dgvMaintenance.AllowUserToAddRows = False
        Me.dgvMaintenance.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(2, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.dgvMaintenance.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMaintenance.ContextMenuStrip = Me.menuContextMaint
        Me.dgvMaintenance.Location = New System.Drawing.Point(20, 100)
        Me.dgvMaintenance.Name = "dgvMaintenance"
        Me.dgvMaintenance.ReadOnly = True
        Me.dgvMaintenance.RowHeadersVisible = False
        Me.dgvMaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMaintenance.Size = New System.Drawing.Size(700, 500)
        Me.dgvMaintenance.TabIndex = 17
        '
        'pnlFiltres
        '
        Me.pnlFiltres.Controls.Add(Me.btnFiltreEnCours)
        Me.pnlFiltres.Controls.Add(Me.btnFiltreTerminee)
        Me.pnlFiltres.Controls.Add(Me.btnFiltrePlanifiee)
        Me.pnlFiltres.Controls.Add(Me.Button2)
        Me.pnlFiltres.Controls.Add(Me.btnFiltreAll)
        Me.pnlFiltres.Location = New System.Drawing.Point(20, 50)
        Me.pnlFiltres.Name = "pnlFiltres"
        Me.pnlFiltres.Size = New System.Drawing.Size(600, 40)
        Me.pnlFiltres.TabIndex = 16
        '
        'btnFiltreEnCours
        '
        Me.btnFiltreEnCours.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnFiltreEnCours.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltreEnCours.FlatAppearance.BorderSize = 0
        Me.btnFiltreEnCours.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltreEnCours.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltreEnCours.ForeColor = System.Drawing.Color.White
        Me.btnFiltreEnCours.Location = New System.Drawing.Point(220, 5)
        Me.btnFiltreEnCours.Name = "btnFiltreEnCours"
        Me.btnFiltreEnCours.Size = New System.Drawing.Size(100, 30)
        Me.btnFiltreEnCours.TabIndex = 4
        Me.btnFiltreEnCours.Text = "En Cours"
        Me.btnFiltreEnCours.UseVisualStyleBackColor = False
        '
        'btnFiltreTerminee
        '
        Me.btnFiltreTerminee.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnFiltreTerminee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltreTerminee.FlatAppearance.BorderSize = 0
        Me.btnFiltreTerminee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltreTerminee.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltreTerminee.ForeColor = System.Drawing.Color.White
        Me.btnFiltreTerminee.Location = New System.Drawing.Point(330, 5)
        Me.btnFiltreTerminee.Name = "btnFiltreTerminee"
        Me.btnFiltreTerminee.Size = New System.Drawing.Size(100, 30)
        Me.btnFiltreTerminee.TabIndex = 3
        Me.btnFiltreTerminee.Text = "Terminées"
        Me.btnFiltreTerminee.UseVisualStyleBackColor = False
        '
        'btnFiltrePlanifiee
        '
        Me.btnFiltrePlanifiee.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnFiltrePlanifiee.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltrePlanifiee.FlatAppearance.BorderSize = 0
        Me.btnFiltrePlanifiee.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltrePlanifiee.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltrePlanifiee.ForeColor = System.Drawing.Color.White
        Me.btnFiltrePlanifiee.Location = New System.Drawing.Point(110, 5)
        Me.btnFiltrePlanifiee.Name = "btnFiltrePlanifiee"
        Me.btnFiltrePlanifiee.Size = New System.Drawing.Size(100, 30)
        Me.btnFiltrePlanifiee.TabIndex = 2
        Me.btnFiltrePlanifiee.Text = "Planifiées"
        Me.btnFiltrePlanifiee.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(250, 5)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
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
        Me.btnFiltreAll.Size = New System.Drawing.Size(100, 30)
        Me.btnFiltreAll.TabIndex = 0
        Me.btnFiltreAll.Text = "Toutes"
        Me.btnFiltreAll.UseVisualStyleBackColor = False
        '
        'menuContextMaint
        '
        Me.menuContextMaint.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModifier, Me.mnuCloturerManuellement, Me.Séparateur, Me.mnuSupprimer})
        Me.menuContextMaint.Name = "menuContextMaint"
        Me.menuContextMaint.Size = New System.Drawing.Size(213, 114)
        '
        'mnuModifier
        '
        Me.mnuModifier.Name = "mnuModifier"
        Me.mnuModifier.Size = New System.Drawing.Size(212, 22)
        Me.mnuModifier.Text = "✏️ Modifier"
        '
        'mnuCloturerManuellement
        '
        Me.mnuCloturerManuellement.Name = "mnuCloturerManuellement"
        Me.mnuCloturerManuellement.Size = New System.Drawing.Size(212, 22)
        Me.mnuCloturerManuellement.Text = "✅ Clôturer manuellement"
        '
        'Séparateur
        '
        Me.Séparateur.Name = "Séparateur"
        Me.Séparateur.Size = New System.Drawing.Size(212, 22)
        Me.Séparateur.Text = "───────────────"
        '
        'mnuSupprimer
        '
        Me.mnuSupprimer.Name = "mnuSupprimer"
        Me.mnuSupprimer.Size = New System.Drawing.Size(212, 22)
        Me.mnuSupprimer.Text = "🗑️ Supprimer"
        '
        'FrmMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1084, 661)
        Me.Controls.Add(Me.pnlListeMaint)
        Me.Controls.Add(Me.pnlFormMaint)
        Me.Controls.Add(Me.pnlHaut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmMaintenance"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Maintenance & Réparations"
        Me.pnlHaut.ResumeLayout(False)
        Me.pnlHaut.PerformLayout()
        Me.pnlFormMaint.ResumeLayout(False)
        Me.pnlFormMaint.PerformLayout()
        Me.pnlListeMaint.ResumeLayout(False)
        Me.pnlListeMaint.PerformLayout()
        CType(Me.dgvMaintenance, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnlFiltres.ResumeLayout(False)
        Me.menuContextMaint.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHaut As Panel
    Friend WithEvents lblTitre As Label
    Friend WithEvents btnRetour As Button
    Friend WithEvents pnlFormMaint As Panel
    Friend WithEvents lblFormTitre As Label
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl7 As Label
    Friend WithEvents lbl6 As Label
    Friend WithEvents lbl5 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents lbl3 As Label
    Friend WithEvents lbl2 As Label
    Friend WithEvents cboVehicule As ComboBox
    Friend WithEvents txtNature As TextBox
    Friend WithEvents cboType As ComboBox
    Friend WithEvents cboPrestataire As ComboBox
    Friend WithEvents dtpEntree As DateTimePicker
    Friend WithEvents dtpSortie As DateTimePicker
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnEnregistrer As Button
    Friend WithEvents txtCout As TextBox
    Friend WithEvents lblTitreListe As Label
    Friend WithEvents pnlListeMaint As Panel
    Friend WithEvents dgvMaintenance As DataGridView
    Friend WithEvents pnlFiltres As Panel
    Friend WithEvents btnFiltreAll As Button
    Friend WithEvents btnFiltreEnCours As Button
    Friend WithEvents btnFiltreTerminee As Button
    Friend WithEvents btnFiltrePlanifiee As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents menuContextMaint As ContextMenuStrip
    Friend WithEvents mnuModifier As ToolStripMenuItem
    Friend WithEvents mnuCloturerManuellement As ToolStripMenuItem
    Friend WithEvents Séparateur As ToolStripMenuItem
    Friend WithEvents mnuSupprimer As ToolStripMenuItem
End Class
