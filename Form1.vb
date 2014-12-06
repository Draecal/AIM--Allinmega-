Imports MySql.Data.MySqlClient
Public Class main
    Friend conexion As MySqlConnection
    Public Property WindowState As FormWindowState
    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion = New MySqlConnection()
            conexion.ConnectionString = "server=31.220.20.81;" & "user id=u926235322_user;" & "password=aimuser;"
            conexion.Open()
        Catch ex As MySqlException
            status.Text = "No Registrado"
            status.ForeColor = Color.DarkRed
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
