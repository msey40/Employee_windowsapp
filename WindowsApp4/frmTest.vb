Public Class frmTest
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim d1 As New animal
        Dim c1 As New animal


        With d1
            .name = "Rover"
            .age = 5
            .type = "4 legs"
        End With
        With c1
            .name = "Fluffy"
            .age = 3
            .type = "4 legs"
        End With


        MsgBox(d1.name & " is " & d1.age & " years old.", MsgBoxStyle.Exclamation, "Warning")
        d1.eat()
        MsgBox(c1.name & " is " & c1.age & " years old.", MsgBoxStyle.Exclamation, "Warning")
        c1.eat()
    End Sub
End Class
Public Class animal
    Public name As String
    Public age As Integer
    Public type As String



    Public Sub eat()

        MsgBox("want to eat dinosaur", MsgBoxStyle.Exclamation, "Warning")
    End Sub

End Class

