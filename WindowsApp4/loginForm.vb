Imports MySql.Data.MySqlClient
Public Class loginForm

    Private Sub loginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDBConnection()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Using conn = getDBConnection()
            Try
                conn.Open()

                Dim sqlquery As String = "SELECT * FROM tbuser WHERE username = @un AND password_hash = @pw"
                Dim cmd As New MySqlCommand(sqlquery, conn)
                cmd.Parameters.AddWithValue("@un", txtname.Text)
                cmd.Parameters.AddWithValue("@pw", txtpw.Text)
                Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                If result > 0 Then
                    Me.Hide()
                    Dim dashboard As New dashboard()
                    dashboard.Show()
                Else
                    MessageBox.Show("Login Failed: Invalid username or password")
                End If

            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)

            End Try
        End Using
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
