Imports System.Diagnostics.Contracts

Public Class Form1
    Dim usuario, password As String

    Private Sub Calculadro_Click(sender As Object, e As EventArgs) Handles Calculadro.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        usuario = TextBox1.Text
        password = TextBox2.Text
        If usuario = "wcm" And password = "123" Then
            Form2.Show()
            Hide()
        Else
            MsgBox("Usuario y/o contraseña incorrecta")
        End If
    End Sub
End Class
