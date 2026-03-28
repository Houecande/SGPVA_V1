<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.lblSousTitre = New System.Windows.Forms.Label()
        Me.lblLogin = New System.Windows.Forms.Label()
        Me.lblMotDePasse = New System.Windows.Forms.Label()
        Me.txtMotDePasse = New System.Windows.Forms.TextBox()
        Me.btnConnecter = New System.Windows.Forms.Button()
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Font = New System.Drawing.Font("Segoe UI", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitre.ForeColor = System.Drawing.Color.White
        Me.lblTitre.Location = New System.Drawing.Point(165, 9)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(64, 23)
        Me.lblTitre.TabIndex = 0
        Me.lblTitre.Text = "SGPVA"
        '
        'lblSousTitre
        '
        Me.lblSousTitre.AutoSize = True
        Me.lblSousTitre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSousTitre.ForeColor = System.Drawing.Color.White
        Me.lblSousTitre.Location = New System.Drawing.Point(135, 41)
        Me.lblSousTitre.Name = "lblSousTitre"
        Me.lblSousTitre.Size = New System.Drawing.Size(130, 15)
        Me.lblSousTitre.TabIndex = 1
        Me.lblSousTitre.Text = "Veuillez vous connecter"
        '
        'lblLogin
        '
        Me.lblLogin.AutoSize = True
        Me.lblLogin.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLogin.ForeColor = System.Drawing.Color.White
        Me.lblLogin.Location = New System.Drawing.Point(62, 68)
        Me.lblLogin.Name = "lblLogin"
        Me.lblLogin.Size = New System.Drawing.Size(61, 15)
        Me.lblLogin.TabIndex = 2
        Me.lblLogin.Text = "Identifiant"
        '
        'lblMotDePasse
        '
        Me.lblMotDePasse.AutoSize = True
        Me.lblMotDePasse.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMotDePasse.ForeColor = System.Drawing.Color.White
        Me.lblMotDePasse.Location = New System.Drawing.Point(62, 119)
        Me.lblMotDePasse.Name = "lblMotDePasse"
        Me.lblMotDePasse.Size = New System.Drawing.Size(77, 15)
        Me.lblMotDePasse.TabIndex = 3
        Me.lblMotDePasse.Text = "Mot de passe"
        '
        'txtMotDePasse
        '
        Me.txtMotDePasse.Location = New System.Drawing.Point(65, 137)
        Me.txtMotDePasse.Name = "txtMotDePasse"
        Me.txtMotDePasse.Size = New System.Drawing.Size(280, 20)
        Me.txtMotDePasse.TabIndex = 5
        Me.txtMotDePasse.UseSystemPasswordChar = True
        '
        'btnConnecter
        '
        Me.btnConnecter.BackColor = System.Drawing.Color.MediumBlue
        Me.btnConnecter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConnecter.FlatAppearance.BorderSize = 0
        Me.btnConnecter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConnecter.ForeColor = System.Drawing.Color.White
        Me.btnConnecter.Location = New System.Drawing.Point(65, 179)
        Me.btnConnecter.Name = "btnConnecter"
        Me.btnConnecter.Size = New System.Drawing.Size(280, 38)
        Me.btnConnecter.TabIndex = 6
        Me.btnConnecter.Text = "Connecter"
        Me.btnConnecter.UseVisualStyleBackColor = False
        '
        'btnQuitter
        '
        Me.btnQuitter.BackColor = System.Drawing.Color.WhiteSmoke
        Me.btnQuitter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnQuitter.FlatAppearance.BorderSize = 0
        Me.btnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnQuitter.ForeColor = System.Drawing.Color.Black
        Me.btnQuitter.Location = New System.Drawing.Point(65, 223)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(280, 30)
        Me.btnQuitter.TabIndex = 7
        Me.btnQuitter.Text = "Quitter"
        Me.btnQuitter.UseVisualStyleBackColor = False
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(65, 86)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(280, 20)
        Me.txtLogin.TabIndex = 8
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(20, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(404, 281)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.btnQuitter)
        Me.Controls.Add(Me.btnConnecter)
        Me.Controls.Add(Me.txtMotDePasse)
        Me.Controls.Add(Me.lblMotDePasse)
        Me.Controls.Add(Me.lblLogin)
        Me.Controls.Add(Me.lblSousTitre)
        Me.Controls.Add(Me.lblTitre)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion — SGPVA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitre As Label
    Friend WithEvents lblSousTitre As Label
    Friend WithEvents lblLogin As Label
    Friend WithEvents lblMotDePasse As Label
    Friend WithEvents txtMotDePasse As TextBox
    Friend WithEvents btnConnecter As Button
    Friend WithEvents btnQuitter As Button
    Friend WithEvents txtLogin As TextBox
End Class
