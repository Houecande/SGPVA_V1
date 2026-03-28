<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmControle
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnDeconnexion = New System.Windows.Forms.Button()
        Me.lblAgent = New System.Windows.Forms.Label()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.pnlForm = New System.Windows.Forms.Panel()
        Me.btnValider = New System.Windows.Forms.Button()
        Me.txtObservation = New System.Windows.Forms.TextBox()
        Me.lbl5 = New System.Windows.Forms.Label()
        Me.txtKm = New System.Windows.Forms.TextBox()
        Me.lbl4 = New System.Windows.Forms.Label()
        Me.cboChauffeur = New System.Windows.Forms.ComboBox()
        Me.lbl3 = New System.Windows.Forms.Label()
        Me.cboVehicule = New System.Windows.Forms.ComboBox()
        Me.lbl2 = New System.Windows.Forms.Label()
        Me.txtNumMission = New System.Windows.Forms.TextBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pnlOnglets = New System.Windows.Forms.Panel()
        Me.btnOngletRetour = New System.Windows.Forms.Button()
        Me.btnOngletSortie = New System.Windows.Forms.Button()
        Me.lblFormTitre = New System.Windows.Forms.Label()
        Me.pnlVerif = New System.Windows.Forms.Panel()
        Me.pnlResultat = New System.Windows.Forms.Panel()
        Me.lblResultat = New System.Windows.Forms.Label()
        Me.lblMissionOk = New System.Windows.Forms.Label()
        Me.lblVerifMission = New System.Windows.Forms.Label()
        Me.lblStatutChauf = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAssurance = New System.Windows.Forms.Label()
        Me.lblStatutVeh = New System.Windows.Forms.Label()
        Me.lblVisite = New System.Windows.Forms.Label()
        Me.lblPermis = New System.Windows.Forms.Label()
        Me.lblVerifVehicule = New System.Windows.Forms.Label()
        Me.lblVerifTitre = New System.Windows.Forms.Label()
        Me.pnlJournal = New System.Windows.Forms.Panel()
        Me.dgvJournal = New System.Windows.Forms.DataGridView()
        Me.lblTitreJournal = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.pnlForm.SuspendLayout()
        Me.pnlOnglets.SuspendLayout()
        Me.pnlVerif.SuspendLayout()
        Me.pnlResultat.SuspendLayout()
        Me.pnlJournal.SuspendLayout()
        CType(Me.dgvJournal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(10, Byte), Integer), CType(CType(14, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnDeconnexion)
        Me.Panel1.Controls.Add(Me.lblAgent)
        Me.Panel1.Controls.Add(Me.lblTitre)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1329, 60)
        Me.Panel1.TabIndex = 0
        '
        'btnDeconnexion
        '
        Me.btnDeconnexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(180, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.btnDeconnexion.FlatAppearance.BorderSize = 0
        Me.btnDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDeconnexion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeconnexion.ForeColor = System.Drawing.Color.White
        Me.btnDeconnexion.Location = New System.Drawing.Point(1206, 15)
        Me.btnDeconnexion.Name = "btnDeconnexion"
        Me.btnDeconnexion.Size = New System.Drawing.Size(110, 32)
        Me.btnDeconnexion.TabIndex = 2
        Me.btnDeconnexion.Text = "↩ Déconnexion"
        Me.btnDeconnexion.UseVisualStyleBackColor = False
        '
        'lblAgent
        '
        Me.lblAgent.AutoSize = True
        Me.lblAgent.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAgent.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblAgent.Location = New System.Drawing.Point(1056, 22)
        Me.lblAgent.Name = "lblAgent"
        Me.lblAgent.Size = New System.Drawing.Size(45, 15)
        Me.lblAgent.TabIndex = 1
        Me.lblAgent.Text = "Agent :"
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.White
        Me.lblTitre.Location = New System.Drawing.Point(20, 18)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(230, 23)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "🔐 Contrôle Entrée / Sortie"
        '
        'pnlForm
        '
        Me.pnlForm.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlForm.Controls.Add(Me.btnValider)
        Me.pnlForm.Controls.Add(Me.txtObservation)
        Me.pnlForm.Controls.Add(Me.lbl5)
        Me.pnlForm.Controls.Add(Me.txtKm)
        Me.pnlForm.Controls.Add(Me.lbl4)
        Me.pnlForm.Controls.Add(Me.cboChauffeur)
        Me.pnlForm.Controls.Add(Me.lbl3)
        Me.pnlForm.Controls.Add(Me.cboVehicule)
        Me.pnlForm.Controls.Add(Me.lbl2)
        Me.pnlForm.Controls.Add(Me.txtNumMission)
        Me.pnlForm.Controls.Add(Me.lbl1)
        Me.pnlForm.Controls.Add(Me.pnlOnglets)
        Me.pnlForm.Controls.Add(Me.lblFormTitre)
        Me.pnlForm.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlForm.Location = New System.Drawing.Point(0, 60)
        Me.pnlForm.Name = "pnlForm"
        Me.pnlForm.Size = New System.Drawing.Size(380, 567)
        Me.pnlForm.TabIndex = 1
        '
        'btnValider
        '
        Me.btnValider.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(86, Byte), Integer), CType(CType(219, Byte), Integer))
        Me.btnValider.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnValider.FlatAppearance.BorderSize = 0
        Me.btnValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnValider.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValider.ForeColor = System.Drawing.Color.White
        Me.btnValider.Location = New System.Drawing.Point(20, 445)
        Me.btnValider.Name = "btnValider"
        Me.btnValider.Size = New System.Drawing.Size(330, 45)
        Me.btnValider.TabIndex = 12
        Me.btnValider.Text = "✅ Valider"
        Me.btnValider.UseVisualStyleBackColor = False
        '
        'txtObservation
        '
        Me.txtObservation.Location = New System.Drawing.Point(20, 390)
        Me.txtObservation.Name = "txtObservation"
        Me.txtObservation.Size = New System.Drawing.Size(330, 20)
        Me.txtObservation.TabIndex = 11
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl5.Location = New System.Drawing.Point(20, 370)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(71, 15)
        Me.lbl5.TabIndex = 10
        Me.lbl5.Text = "Observation"
        '
        'txtKm
        '
        Me.txtKm.Location = New System.Drawing.Point(20, 325)
        Me.txtKm.Name = "txtKm"
        Me.txtKm.Size = New System.Drawing.Size(330, 20)
        Me.txtKm.TabIndex = 9
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl4.Location = New System.Drawing.Point(20, 305)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(62, 15)
        Me.lbl4.TabIndex = 8
        Me.lbl4.Text = "Km Relevé"
        '
        'cboChauffeur
        '
        Me.cboChauffeur.FormattingEnabled = True
        Me.cboChauffeur.Location = New System.Drawing.Point(20, 260)
        Me.cboChauffeur.Name = "cboChauffeur"
        Me.cboChauffeur.Size = New System.Drawing.Size(330, 21)
        Me.cboChauffeur.TabIndex = 7
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl3.Location = New System.Drawing.Point(20, 240)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(60, 15)
        Me.lbl3.TabIndex = 6
        Me.lbl3.Text = "Chauffeur"
        '
        'cboVehicule
        '
        Me.cboVehicule.FormattingEnabled = True
        Me.cboVehicule.Location = New System.Drawing.Point(20, 195)
        Me.cboVehicule.Name = "cboVehicule"
        Me.cboVehicule.Size = New System.Drawing.Size(330, 21)
        Me.cboVehicule.TabIndex = 5
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl2.Location = New System.Drawing.Point(20, 175)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(139, 15)
        Me.lbl2.TabIndex = 4
        Me.lbl2.Text = "Immatriculation Véhicule"
        '
        'txtNumMission
        '
        Me.txtNumMission.Location = New System.Drawing.Point(20, 130)
        Me.txtNumMission.Name = "txtNumMission"
        Me.txtNumMission.Size = New System.Drawing.Size(330, 20)
        Me.txtNumMission.TabIndex = 3
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lbl1.Location = New System.Drawing.Point(20, 110)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(114, 15)
        Me.lbl1.TabIndex = 2
        Me.lbl1.Text = "N° Ordre de Mission"
        '
        'pnlOnglets
        '
        Me.pnlOnglets.Controls.Add(Me.btnOngletRetour)
        Me.pnlOnglets.Controls.Add(Me.btnOngletSortie)
        Me.pnlOnglets.Location = New System.Drawing.Point(20, 55)
        Me.pnlOnglets.Name = "pnlOnglets"
        Me.pnlOnglets.Size = New System.Drawing.Size(330, 40)
        Me.pnlOnglets.TabIndex = 1
        '
        'btnOngletRetour
        '
        Me.btnOngletRetour.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.btnOngletRetour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOngletRetour.FlatAppearance.BorderSize = 0
        Me.btnOngletRetour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOngletRetour.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOngletRetour.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.btnOngletRetour.Location = New System.Drawing.Point(165, 0)
        Me.btnOngletRetour.Name = "btnOngletRetour"
        Me.btnOngletRetour.Size = New System.Drawing.Size(165, 40)
        Me.btnOngletRetour.TabIndex = 13
        Me.btnOngletRetour.Text = "🟢 Retour Véhicule"
        Me.btnOngletRetour.UseVisualStyleBackColor = False
        '
        'btnOngletSortie
        '
        Me.btnOngletSortie.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(68, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnOngletSortie.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnOngletSortie.FlatAppearance.BorderSize = 0
        Me.btnOngletSortie.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOngletSortie.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOngletSortie.ForeColor = System.Drawing.Color.White
        Me.btnOngletSortie.Location = New System.Drawing.Point(0, 0)
        Me.btnOngletSortie.Name = "btnOngletSortie"
        Me.btnOngletSortie.Size = New System.Drawing.Size(165, 40)
        Me.btnOngletSortie.TabIndex = 0
        Me.btnOngletSortie.Text = "🔴 Sortie Véhicule"
        Me.btnOngletSortie.UseVisualStyleBackColor = False
        '
        'lblFormTitre
        '
        Me.lblFormTitre.AutoSize = True
        Me.lblFormTitre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFormTitre.ForeColor = System.Drawing.Color.White
        Me.lblFormTitre.Location = New System.Drawing.Point(20, 20)
        Me.lblFormTitre.Name = "lblFormTitre"
        Me.lblFormTitre.Size = New System.Drawing.Size(143, 20)
        Me.lblFormTitre.TabIndex = 0
        Me.lblFormTitre.Text = "📋 Enregistrement"
        '
        'pnlVerif
        '
        Me.pnlVerif.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.pnlVerif.Controls.Add(Me.pnlResultat)
        Me.pnlVerif.Controls.Add(Me.lblMissionOk)
        Me.pnlVerif.Controls.Add(Me.lblVerifMission)
        Me.pnlVerif.Controls.Add(Me.lblStatutChauf)
        Me.pnlVerif.Controls.Add(Me.Label1)
        Me.pnlVerif.Controls.Add(Me.lblAssurance)
        Me.pnlVerif.Controls.Add(Me.lblStatutVeh)
        Me.pnlVerif.Controls.Add(Me.lblVisite)
        Me.pnlVerif.Controls.Add(Me.lblPermis)
        Me.pnlVerif.Controls.Add(Me.lblVerifVehicule)
        Me.pnlVerif.Controls.Add(Me.lblVerifTitre)
        Me.pnlVerif.Dock = System.Windows.Forms.DockStyle.Left
        Me.pnlVerif.Location = New System.Drawing.Point(380, 60)
        Me.pnlVerif.Name = "pnlVerif"
        Me.pnlVerif.Size = New System.Drawing.Size(320, 567)
        Me.pnlVerif.TabIndex = 2
        '
        'pnlResultat
        '
        Me.pnlResultat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlResultat.Controls.Add(Me.lblResultat)
        Me.pnlResultat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(75, Byte), Integer))
        Me.pnlResultat.Location = New System.Drawing.Point(15, 340)
        Me.pnlResultat.Name = "pnlResultat"
        Me.pnlResultat.Size = New System.Drawing.Size(285, 60)
        Me.pnlResultat.TabIndex = 14
        '
        'lblResultat
        '
        Me.lblResultat.AutoSize = True
        Me.lblResultat.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultat.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblResultat.Location = New System.Drawing.Point(11, 19)
        Me.lblResultat.Name = "lblResultat"
        Me.lblResultat.Size = New System.Drawing.Size(83, 17)
        Me.lblResultat.TabIndex = 12
        Me.lblResultat.Text = "En attente..."
        Me.lblResultat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblMissionOk
        '
        Me.lblMissionOk.AutoSize = True
        Me.lblMissionOk.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMissionOk.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblMissionOk.Location = New System.Drawing.Point(15, 295)
        Me.lblMissionOk.Name = "lblMissionOk"
        Me.lblMissionOk.Size = New System.Drawing.Size(105, 15)
        Me.lblMissionOk.TabIndex = 10
        Me.lblMissionOk.Text = "⬜ Mission validée"
        '
        'lblVerifMission
        '
        Me.lblVerifMission.AutoSize = True
        Me.lblVerifMission.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.lblVerifMission.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerifMission.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblVerifMission.Location = New System.Drawing.Point(15, 270)
        Me.lblVerifMission.Name = "lblVerifMission"
        Me.lblVerifMission.Size = New System.Drawing.Size(63, 15)
        Me.lblVerifMission.TabIndex = 8
        Me.lblVerifMission.Text = "Mission —"
        '
        'lblStatutChauf
        '
        Me.lblStatutChauf.AutoSize = True
        Me.lblStatutChauf.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatutChauf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblStatutChauf.Location = New System.Drawing.Point(15, 230)
        Me.lblStatutChauf.Name = "lblStatutChauf"
        Me.lblStatutChauf.Size = New System.Drawing.Size(115, 15)
        Me.lblStatutChauf.TabIndex = 7
        Me.lblStatutChauf.Text = "⬜ Statut Chauffeur"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(15, 175)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Chauffeur —"
        '
        'lblAssurance
        '
        Me.lblAssurance.AutoSize = True
        Me.lblAssurance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAssurance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblAssurance.Location = New System.Drawing.Point(15, 75)
        Me.lblAssurance.Name = "lblAssurance"
        Me.lblAssurance.Size = New System.Drawing.Size(77, 15)
        Me.lblAssurance.TabIndex = 5
        Me.lblAssurance.Text = "⬜ Assurance"
        '
        'lblStatutVeh
        '
        Me.lblStatutVeh.AutoSize = True
        Me.lblStatutVeh.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatutVeh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblStatutVeh.Location = New System.Drawing.Point(15, 135)
        Me.lblStatutVeh.Name = "lblStatutVeh"
        Me.lblStatutVeh.Size = New System.Drawing.Size(106, 15)
        Me.lblStatutVeh.TabIndex = 4
        Me.lblStatutVeh.Text = "⬜ Statut Véhicule"
        '
        'lblVisite
        '
        Me.lblVisite.AutoSize = True
        Me.lblVisite.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVisite.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblVisite.Location = New System.Drawing.Point(15, 105)
        Me.lblVisite.Name = "lblVisite"
        Me.lblVisite.Size = New System.Drawing.Size(112, 15)
        Me.lblVisite.TabIndex = 3
        Me.lblVisite.Text = "⬜ Visite Technique"
        '
        'lblPermis
        '
        Me.lblPermis.AutoSize = True
        Me.lblPermis.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermis.ForeColor = System.Drawing.Color.FromArgb(CType(CType(130, Byte), Integer), CType(CType(155, Byte), Integer), CType(CType(210, Byte), Integer))
        Me.lblPermis.Location = New System.Drawing.Point(15, 200)
        Me.lblPermis.Name = "lblPermis"
        Me.lblPermis.Size = New System.Drawing.Size(95, 15)
        Me.lblPermis.TabIndex = 2
        Me.lblPermis.Text = "⬜ Permis valide"
        '
        'lblVerifVehicule
        '
        Me.lblVerifVehicule.AutoSize = True
        Me.lblVerifVehicule.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerifVehicule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(150, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblVerifVehicule.Location = New System.Drawing.Point(15, 50)
        Me.lblVerifVehicule.Name = "lblVerifVehicule"
        Me.lblVerifVehicule.Size = New System.Drawing.Size(66, 15)
        Me.lblVerifVehicule.TabIndex = 1
        Me.lblVerifVehicule.Text = "Véhicule —"
        '
        'lblVerifTitre
        '
        Me.lblVerifTitre.AutoSize = True
        Me.lblVerifTitre.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVerifTitre.ForeColor = System.Drawing.Color.White
        Me.lblVerifTitre.Location = New System.Drawing.Point(15, 15)
        Me.lblVerifTitre.Name = "lblVerifTitre"
        Me.lblVerifTitre.Size = New System.Drawing.Size(122, 20)
        Me.lblVerifTitre.TabIndex = 0
        Me.lblVerifTitre.Text = "🔍 Vérifications"
        '
        'pnlJournal
        '
        Me.pnlJournal.Controls.Add(Me.dgvJournal)
        Me.pnlJournal.Controls.Add(Me.lblTitreJournal)
        Me.pnlJournal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlJournal.Location = New System.Drawing.Point(700, 60)
        Me.pnlJournal.Name = "pnlJournal"
        Me.pnlJournal.Padding = New System.Windows.Forms.Padding(20)
        Me.pnlJournal.Size = New System.Drawing.Size(629, 567)
        Me.pnlJournal.TabIndex = 3
        '
        'dgvJournal
        '
        Me.dgvJournal.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.dgvJournal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvJournal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvJournal.Location = New System.Drawing.Point(20, 55)
        Me.dgvJournal.Name = "dgvJournal"
        Me.dgvJournal.ReadOnly = True
        Me.dgvJournal.RowHeadersVisible = False
        Me.dgvJournal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvJournal.Size = New System.Drawing.Size(600, 500)
        Me.dgvJournal.TabIndex = 1
        '
        'lblTitreJournal
        '
        Me.lblTitreJournal.AutoSize = True
        Me.lblTitreJournal.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitreJournal.ForeColor = System.Drawing.Color.White
        Me.lblTitreJournal.Location = New System.Drawing.Point(20, 20)
        Me.lblTitreJournal.Name = "lblTitreJournal"
        Me.lblTitreJournal.Size = New System.Drawing.Size(144, 20)
        Me.lblTitreJournal.TabIndex = 0
        Me.lblTitreJournal.Text = "📋 Journal du Jour"
        '
        'FrmControle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1329, 627)
        Me.Controls.Add(Me.pnlJournal)
        Me.Controls.Add(Me.pnlVerif)
        Me.Controls.Add(Me.pnlForm)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmControle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Contrôle Entrée / Sortie"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.pnlForm.ResumeLayout(False)
        Me.pnlForm.PerformLayout()
        Me.pnlOnglets.ResumeLayout(False)
        Me.pnlVerif.ResumeLayout(False)
        Me.pnlVerif.PerformLayout()
        Me.pnlResultat.ResumeLayout(False)
        Me.pnlResultat.PerformLayout()
        Me.pnlJournal.ResumeLayout(False)
        Me.pnlJournal.PerformLayout()
        CType(Me.dgvJournal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblAgent As Label
    Friend WithEvents lblTitre As Label
    Friend WithEvents btnDeconnexion As Button
    Friend WithEvents pnlForm As Panel
    Friend WithEvents lblFormTitre As Label
    Friend WithEvents pnlOnglets As Panel
    Friend WithEvents btnOngletSortie As Button
    Friend WithEvents lbl2 As Label
    Friend WithEvents txtNumMission As TextBox
    Friend WithEvents lbl1 As Label
    Friend WithEvents lbl4 As Label
    Friend WithEvents cboChauffeur As ComboBox
    Friend WithEvents lbl3 As Label
    Friend WithEvents cboVehicule As ComboBox
    Friend WithEvents txtObservation As TextBox
    Friend WithEvents lbl5 As Label
    Friend WithEvents txtKm As TextBox
    Friend WithEvents btnValider As Button
    Friend WithEvents pnlVerif As Panel
    Friend WithEvents lblAssurance As Label
    Friend WithEvents lblStatutVeh As Label
    Friend WithEvents lblVisite As Label
    Friend WithEvents lblPermis As Label
    Friend WithEvents lblVerifVehicule As Label
    Friend WithEvents lblVerifTitre As Label
    Friend WithEvents lblResultat As Label
    Friend WithEvents lblMissionOk As Label
    Friend WithEvents lblVerifMission As Label
    Friend WithEvents lblStatutChauf As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents pnlResultat As Panel
    Friend WithEvents pnlJournal As Panel
    Friend WithEvents dgvJournal As DataGridView
    Friend WithEvents lblTitreJournal As Label
    Friend WithEvents btnOngletRetour As Button
End Class
