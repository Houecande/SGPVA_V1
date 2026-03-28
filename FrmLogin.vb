Imports System.Data.OleDb

Public Class FrmLogin

    ' Chargement du formulaire
    Private Sub FrmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtLogin.Select()
    End Sub

    ' Bouton Se connecter
    Private Sub btnConnecter_Click(sender As Object, e As EventArgs) Handles btnConnecter.Click
        ' Vérification champs vides
        If txtLogin.Text.Trim() = "" Or txtMotDePasse.Text.Trim() = "" Then
            MessageBox.Show("Veuillez remplir tous les champs.",
                            "Champs requis",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Vérification dans la base
        Dim utilisateur As DataRow = VerifierLogin(txtLogin.Text.Trim(),
                                                    txtMotDePasse.Text.Trim())

        If utilisateur IsNot Nothing Then
            ' Connexion réussie → ouvrir le bon formulaire selon le rôle
            Dim role As String = utilisateur("role").ToString()
            Dim nom As String = utilisateur("nom_complet").ToString()
            Dim idUser As Integer = CInt(utilisateur("id_utilisateur"))

            MessageBox.Show("Bienvenue " & nom & " !",
                            "Connexion réussie",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

            ' Ouvrir le tableau de bord selon le rôle
            If role = "Gestionnaire" Then
                Dim frmTableau As New FrmTableauBord(idUser, nom, role)
                frmTableau.Show()
            ElseIf role = "Agent_Controle" Then
                Dim frmControle As New FrmControle(idUser, nom, role)
                frmControle.Show()
            End If

            ' Cacher le login
            Me.Hide()

        Else
            ' Identifiants incorrects
            MessageBox.Show("Identifiant ou mot de passe incorrect.",
                            "Accès refusé",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            txtMotDePasse.Clear()
            txtMotDePasse.Focus()
        End If
    End Sub

    ' Vérification login dans la base
    Private Function VerifierLogin(login As String, motDePasse As String) As DataRow
        Try
            Using conn As OleDbConnection = ConnexionDB.GetConnexion()
                Dim sql As String =
                    "SELECT id_utilisateur, nom_complet, role " &
                    "FROM T_Utilisateurs " &
                    "WHERE login = ? AND mot_de_passe = ? AND actif = True"

                Dim cmd As New OleDbCommand(sql, conn)
                cmd.Parameters.AddWithValue("?", login)
                cmd.Parameters.AddWithValue("?", motDePasse)

                Dim da As New OleDbDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    Return dt.Rows(0)
                Else
                    Return Nothing
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message,
                            "Erreur base de données",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return Nothing
        End Try
    End Function

    ' Touche Entrée = Se connecter
    Private Sub txtMotDePasse_KeyDown(sender As Object, e As KeyEventArgs) Handles txtMotDePasse.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConnecter_Click(sender, e)
        End If
    End Sub

    ' Bouton Quitter
    Private Sub btnQuitter_Click(sender As Object, e As EventArgs) Handles btnQuitter.Click
        Application.Exit()
    End Sub

End Class