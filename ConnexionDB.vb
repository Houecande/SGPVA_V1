Imports System.Data.OleDb

Module ConnexionDB

    Private ReadOnly CHEMIN_DB As String =
        "C:\Users\Armand Blade\Desktop\Système de Gestion du Parc de Véhicules\SGPVA_DB.accdb"

    Private ReadOnly CHAINE_CONNEXION As String =
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & CHEMIN_DB & ";"

    Public Function GetConnexion() As OleDbConnection
        Dim conn As New OleDbConnection(CHAINE_CONNEXION)
        conn.Open()
        Return conn
    End Function

    Public Function TesterConnexion() As Boolean
        Try
            Using conn As OleDbConnection = GetConnexion()
                Return conn.State = ConnectionState.Open
            End Using
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message & vbNewLine &
                            "Chemin : " & CHEMIN_DB,
                            "Connexion échouée",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module