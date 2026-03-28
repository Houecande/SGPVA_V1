<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmVehicules
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
        Me.pnlHaut = New System.Windows.Forms.Panel()
        Me.btnRetour = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.btnAnnuler = New System.Windows.Forms.Button()
        Me.btnAjouter = New System.Windows.Forms.Button()
        Me.dtpVisite = New System.Windows.Forms.DateTimePicker()
        Me.lbl9 = New System.Windows.Forms.Label()
        Me.dtpAssurance = New System.Windows.Forms.DateTimePicker()
        Me.lbl8 = New System.Windows.Forms.Label()
        Me.txtKm = New System.Windows.Forms.TextBox()
        Me.lbl7 = New System.Windows.Forms.Label()
        Me.txtPlaces = New System.Windows.Forms.TextBox()
        Me.lbl6 = New System.Windows.Forms.Label()
        Me.cboCarburant = New System.Windows.Forms.ComboBox()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.txtModele = New System.Windows.Forms.TextBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.txtMarque = New System.Windows.Forms.TextBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtImmat = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.lblFormTitre = New System.Windows.Forms.Label()
        Me.pnlListeMissions = New System.Windows.Forms.Panel()
        Me.dgvVehicules = New System.Windows.Forms.DataGridView()
        Me.menuContextVehicule = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnuModifierVeh = New System.Windows.Forms.ToolStripMenuItem()
        Me.Séparateur = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSupprimerVeh = New System.Windows.Forms.ToolStripMenuItem()
        Me.pnlFiltres = New System.Windows.Forms.Panel()
        Me.btnFiltreMaint = New System.Windows.Forms.Button()
        Me.btnFiltreMission = New System.Windows.Forms.Button()
        Me.btnFiltreDispo = New System.Windows.Forms.Button()
        Me.btnFiltreAll = New System.Windows.Forms.Button()
        Me.lblTitreListe = New System.Windows.Forms.Label()
        Me.pnlHaut.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.pnlListeMissions.SuspendLayout()
        CType(Me.dgvVehicules, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuContextVehicule.SuspendLayout()
        Me.pnlFiltres.SuspendLayout()
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
        Me.btnRetour.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.lblTitre.Size = New System.Drawing.Size(209, 23)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "🚗 Gestion des Véhicules"
        '
        'pnlForm
        '
        Me.pnlForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlForm.Controls.Add(Me.btnAnnuler)
        Me.pnlForm.Controls.Add(Me.btnAjouter)
        Me.pnlForm.Controls.Add(Me.dtpVisite)
        Me.pnlForm.Controls.Add(Me.lbl9)
        Me.pnlForm.Controls.Add(Me.dtpAssurance)
        Me.pnlForm.Controls.Add(Me.lbl8)
        Me.pnlForm.Controls.Add(Me.txtKm)
        Me.pnlForm.Controls.Add(Me.lbl7)
        Me.pnlForm.Controls.Add(Me.txtPlaces)
        Me.pnlForm.Controls.Add(Me.lbl6)
        Me.pnlForm.Controls.Add(Me.cboCarburant)
        Me.pnlForm.Controls.Add(Me.lbl5)
        Me.pnlForm.Controls.Add(Me.cboType)
        Me.pnlForm.Controls.Add(Me.lbl4)
        Me.pnlForm.Controls.Add(Me.txtModele)
        Me.pnlForm.Controls.Add(Me.lbl3)
        Me.pnlForm.Controls.Add(Me.txtMarque)
        Me.pnlForm.Controls.Add(Me.lbl2)
        Me.pnlForm.Controls.Add(Me.txtImmat)
        Me.pnlForm.Controls.Add(Me.lbl1)
        Me.pnlForm.Controls.Add(Me.lblFormTitre)
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlForm.Location = New System.Drawing.Point(0, 60)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(350, 657)
        Me.pnlForm.TabIndex = 1
        '
        'btnAnnuler
        '
        Me.btnAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.btnAnnuler.FlatAppearance.BorderSize = 0
        Me.btnAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnuler.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnnuler.ForeColor = System.Drawing.Color.White
        Me.btnAnnuler.Location = New System.Drawing.Point(20, 614)
        Me.btnAnnuler.Name = "btnAnnuler"
        Me.btnAnnuler.Size = New System.Drawing.Size(300, 35)
        Me.btnAnnuler.TabIndex = 20
        Me.btnAnnuler.Text = "✕ Annuler"
        Me.btnAnnuler.UseVisualStyleBackColor = False
        '
        'btnAjouter
        '
        Me.btnAjouter.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnAjouter.FlatAppearance.BorderSize = 0
        Me.btnAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAjouter.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAjouter.ForeColor = System.Drawing.Color.White
        Me.btnAjouter.Location = New System.Drawing.Point(20, 564)
        Me.btnAjouter.Name = "btnAjouter"
        Me.btnAjouter.Size = New System.Drawing.Size(300, 40)
        Me.btnAjouter.TabIndex = 19
        Me.btnAjouter.Text = "✅ Ajouter le Véhicule"
        Me.btnAjouter.UseVisualStyleBackColor = False
        '
        'dtpVisite
        '
        Me.dtpVisite.Location = New System.Drawing.Point(20, 525)
        Me.dtpVisite.Name = "dtpVisite"
        Me.dtpVisite.Size = New System.Drawing.Size(300, 20)
        Me.dtpVisite.TabIndex = 18
        '
        'lbl9
        '
        Me.lbl9.AutoSize = True
        Me.lbl9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl9.Location = New System.Drawing.Point(20, 505)
        Me.lbl9.Name = "lbl9"
        Me.lbl9.Size = New System.Drawing.Size(124, 15)
        Me.lbl9.TabIndex = 17
        Me.lbl9.Text = "Expir. Visite Technique"
        '
        'dtpAssurance
        '
        Me.dtpAssurance.Location = New System.Drawing.Point(20, 460)
        Me.dtpAssurance.Name = "dtpAssurance"
        Me.dtpAssurance.Size = New System.Drawing.Size(300, 20)
        Me.dtpAssurance.TabIndex = 16
        '
        'lbl8
        '
        Me.lbl8.AutoSize = True
        Me.lbl8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl8.Location = New System.Drawing.Point(20, 440)
        Me.lbl8.Name = "lbl8"
        Me.lbl8.Size = New System.Drawing.Size(93, 15)
        Me.lbl8.TabIndex = 15
        Me.lbl8.Text = "Expir. Assurance"
        '
        'txtKm
        '
        Me.txtKm.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtKm.ForeColor = System.Drawing.Color.White
        Me.txtKm.Location = New System.Drawing.Point(20, 395)
        Me.txtKm.Name = "txtKm"
        Me.txtKm.Size = New System.Drawing.Size(300, 20)
        Me.txtKm.TabIndex = 14
        '
        'lbl7
        '
        Me.lbl7.AutoSize = True
        Me.lbl7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl7.Location = New System.Drawing.Point(20, 375)
        Me.lbl7.Name = "lbl7"
        Me.lbl7.Size = New System.Drawing.Size(60, 15)
        Me.lbl7.TabIndex = 13
        Me.lbl7.Text = "Km actuel"
        '
        'txtPlaces
        '
        Me.txtPlaces.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtPlaces.ForeColor = System.Drawing.Color.White
        Me.txtPlaces.Location = New System.Drawing.Point(175, 330)
        Me.txtPlaces.Name = "txtPlaces"
        Me.txtPlaces.Size = New System.Drawing.Size(145, 20)
        Me.txtPlaces.TabIndex = 12
        '
        'lbl6
        '
        Me.lbl6.AutoSize = True
        Me.lbl6.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl6.Location = New System.Drawing.Point(175, 310)
        Me.lbl6.Name = "lbl6"
        Me.lbl6.Size = New System.Drawing.Size(40, 15)
        Me.lbl6.TabIndex = 11
        Me.lbl6.Text = "Places"
        '
        'cboCarburant
        '
        Me.cboCarburant.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cboCarburant.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCarburant.ForeColor = System.Drawing.Color.White
        Me.cboCarburant.FormattingEnabled = True
        Me.cboCarburant.Location = New System.Drawing.Point(20, 330)
        Me.cboCarburant.Name = "cboCarburant"
        Me.cboCarburant.Size = New System.Drawing.Size(140, 21)
        Me.cboCarburant.TabIndex = 10
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl5.Location = New System.Drawing.Point(20, 310)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(60, 15)
        Me.lbl5.TabIndex = 9
        Me.lbl5.Text = "Carburant"
        '
        'cboType
        '
        Me.cboType.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboType.ForeColor = System.Drawing.Color.White
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(20, 265)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(300, 21)
        Me.cboType.TabIndex = 8
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl4.Location = New System.Drawing.Point(20, 245)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(31, 15)
        Me.lbl4.TabIndex = 7
        Me.lbl4.Text = "Type"
        '
        'txtModele
        '
        Me.txtModele.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtModele.ForeColor = System.Drawing.Color.White
        Me.txtModele.Location = New System.Drawing.Point(20, 210)
        Me.txtModele.Name = "txtModele"
        Me.txtModele.Size = New System.Drawing.Size(300, 20)
        Me.txtModele.TabIndex = 6
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(20, 190)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(47, 15)
        Me.lbl3.TabIndex = 5
        Me.lbl3.Text = "Modèle"
        '
        'txtMarque
        '
        Me.txtMarque.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtMarque.ForeColor = System.Drawing.Color.White
        Me.txtMarque.Location = New System.Drawing.Point(20, 145)
        Me.txtMarque.Name = "txtMarque"
        Me.txtMarque.Size = New System.Drawing.Size(300, 20)
        Me.txtMarque.TabIndex = 4
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(20, 125)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(48, 15)
        Me.lbl2.TabIndex = 3
        Me.lbl2.Text = "Marque"
        '
        'txtImmat
        '
        Me.txtImmat.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.txtImmat.ForeColor = System.Drawing.Color.White
        Me.txtImmat.Location = New System.Drawing.Point(20, 80)
        Me.txtImmat.Name = "txtImmat"
        Me.txtImmat.Size = New System.Drawing.Size(300, 20)
        Me.txtImmat.TabIndex = 2
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(20, 60)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(92, 15)
        Me.lbl1.TabIndex = 1
        Me.lbl1.Text = "Immatriculation"
        '
        'lblFormTitre
        '
        Me.lblFormTitre.AutoSize = True
        Me.lblFormTitre.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitre.ForeColor = System.Drawing.Color.White
        Me.lblFormTitre.Location = New System.Drawing.Point(20, 20)
        Me.lblFormTitre.Name = "lblFormTitre"
        Me.lblFormTitre.Size = New System.Drawing.Size(195, 23)
        Me.lblFormTitre.TabIndex = 0
        Me.lblFormTitre.Text = "➕ Ajouter un Véhicule"
        '
        'pnlListeMissions
        '
        Me.pnlListeMissions.Controls.Add(Me.dgvVehicules)
        Me.pnlListeMissions.Controls.Add(Me.pnlFiltres)
        Me.pnlListeMissions.Controls.Add(Me.lblTitreListe)
        Me.pnlListeMissions.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlListeMissions.Location = New System.Drawing.Point(350, 60)
        Me.pnlListeMissions.Name = "pnlListeMissions"
        Me.pnlListeMissions.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlListeMissions.Size = New System.Drawing.Size(734, 657)
        Me.pnlListeMissions.TabIndex = 3
        '
        'dgvVehicules
        '
        Me.dgvVehicules.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.dgvVehicules.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvVehicules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVehicules.ContextMenuStrip = Me.menuContextVehicule
        Me.dgvVehicules.Location = New System.Drawing.Point(20, 95)
        Me.dgvVehicules.Name = "dgvVehicules"
        Me.dgvVehicules.ReadOnly = True
        Me.dgvVehicules.RowHeadersVisible = False
        Me.dgvVehicules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvVehicules.Size = New System.Drawing.Size(700, 554)
        Me.dgvVehicules.TabIndex = 2
        '
        'menuContextVehicule
        '
        Me.menuContextVehicule.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuModifierVeh, Me.Séparateur, Me.mnuSupprimerVeh})
        Me.menuContextVehicule.Name = "menuContextVehicule"
        Me.menuContextVehicule.Size = New System.Drawing.Size(197, 70)
        '
        'mnuModifierVeh
        '
        Me.mnuModifierVeh.Name = "mnuModifierVeh"
        Me.mnuModifierVeh.Size = New System.Drawing.Size(196, 22)
        Me.mnuModifierVeh.Text = "✏️ Modifier ce véhicule"
        '
        'Séparateur
        '
        Me.Séparateur.Name = "Séparateur"
        Me.Séparateur.Size = New System.Drawing.Size(196, 22)
        Me.Séparateur.Text = "───────────────"
        '
        'mnuSupprimerVeh
        '
        Me.mnuSupprimerVeh.Name = "mnuSupprimerVeh"
        Me.mnuSupprimerVeh.Size = New System.Drawing.Size(196, 22)
        Me.mnuSupprimerVeh.Text = "🗑️ Supprimer"
        '
        'pnlFiltres
        '
        Me.pnlFiltres.Controls.Add(Me.btnFiltreMaint)
        Me.pnlFiltres.Controls.Add(Me.btnFiltreMission)
        Me.pnlFiltres.Controls.Add(Me.btnFiltreDispo)
        Me.pnlFiltres.Controls.Add(Me.btnFiltreAll)
        Me.pnlFiltres.Location = New System.Drawing.Point(20, 45)
        Me.pnlFiltres.Name = "pnlFiltres"
        Me.pnlFiltres.Size = New System.Drawing.Size(700, 40)
        Me.pnlFiltres.TabIndex = 1
        '
        'btnFiltreMaint
        '
        Me.btnFiltreMaint.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnFiltreMaint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltreMaint.FlatAppearance.BorderSize = 0
        Me.btnFiltreMaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltreMaint.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltreMaint.ForeColor = System.Drawing.Color.White
        Me.btnFiltreMaint.Location = New System.Drawing.Point(320, 5)
        Me.btnFiltreMaint.Name = "btnFiltreMaint"
        Me.btnFiltreMaint.Size = New System.Drawing.Size(100, 30)
        Me.btnFiltreMaint.TabIndex = 3
        Me.btnFiltreMaint.Text = "Maintenance"
        Me.btnFiltreMaint.UseVisualStyleBackColor = False
        '
        'btnFiltreMission
        '
        Me.btnFiltreMission.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnFiltreMission.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltreMission.FlatAppearance.BorderSize = 0
        Me.btnFiltreMission.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltreMission.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltreMission.ForeColor = System.Drawing.Color.White
        Me.btnFiltreMission.Location = New System.Drawing.Point(210, 5)
        Me.btnFiltreMission.Name = "btnFiltreMission"
        Me.btnFiltreMission.Size = New System.Drawing.Size(100, 30)
        Me.btnFiltreMission.TabIndex = 2
        Me.btnFiltreMission.Text = "En Mission"
        Me.btnFiltreMission.UseVisualStyleBackColor = False
        '
        'btnFiltreDispo
        '
        Me.btnFiltreDispo.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnFiltreDispo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFiltreDispo.FlatAppearance.BorderSize = 0
        Me.btnFiltreDispo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFiltreDispo.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFiltreDispo.ForeColor = System.Drawing.Color.White
        Me.btnFiltreDispo.Location = New System.Drawing.Point(100, 5)
        Me.btnFiltreDispo.Name = "btnFiltreDispo"
        Me.btnFiltreDispo.Size = New System.Drawing.Size(100, 30)
        Me.btnFiltreDispo.TabIndex = 1
        Me.btnFiltreDispo.Text = "Disponibles"
        Me.btnFiltreDispo.UseVisualStyleBackColor = False
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
        Me.lblTitreListe.Size = New System.Drawing.Size(155, 20)
        Me.lblTitreListe.TabIndex = 0
        Me.lblTitreListe.Text = "🚗 Parc de Véhicules"
        '
        'FrmVehicules
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1084, 717)
        Me.Controls.Add(Me.pnlListeMissions)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.pnlHaut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmVehicules"
        Me.Text = "FrmVehicules"
        Me.pnlHaut.ResumeLayout(False)
        Me.pnlHaut.PerformLayout()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.pnlListeMissions.ResumeLayout(False)
        Me.pnlListeMissions.PerformLayout()
        CType(Me.dgvVehicules, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuContextVehicule.ResumeLayout(False)
        Me.pnlFiltres.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlHaut As Panel
    Friend WithEvents lblTitre As Label
    Friend WithEvents btnRetour As Button
    Friend WithEvents pnlForm As Panel
    Friend WithEvents txtImmat As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lblFormTitre As Label
    Friend WithEvents txtModele As TextBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents txtMarque As TextBox
    Friend WithEvents lbl2 As Label
    Friend WithEvents cboCarburant As ComboBox
    Friend WithEvents lbl5 As Label
    Friend WithEvents cboType As ComboBox
    Friend WithEvents lbl4 As Label
    Friend WithEvents txtKm As TextBox
    Friend WithEvents lbl7 As Label
    Friend WithEvents txtPlaces As TextBox
    Friend WithEvents lbl6 As Label
    Friend WithEvents dtpVisite As DateTimePicker
    Friend WithEvents lbl9 As Label
    Friend WithEvents dtpAssurance As DateTimePicker
    Friend WithEvents lbl8 As Label
    Friend WithEvents btnAnnuler As Button
    Friend WithEvents btnAjouter As Button
    Friend WithEvents pnlListeMissions As Panel
    Friend WithEvents dgvVehicules As DataGridView
    Friend WithEvents pnlFiltres As Panel
    Friend WithEvents btnFiltreMaint As Button
    Friend WithEvents btnFiltreMission As Button
    Friend WithEvents btnFiltreDispo As Button
    Friend WithEvents btnFiltreAll As Button
    Friend WithEvents lblTitreListe As Label
    Friend WithEvents menuContextVehicule As ContextMenuStrip
    Friend WithEvents mnuModifierVeh As ToolStripMenuItem
    Friend WithEvents Séparateur As ToolStripMenuItem
    Friend WithEvents mnuSupprimerVeh As ToolStripMenuItem
End Class
