

Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ClassLibrary1.Class1.Msg("Hello Git !")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text <> "" Then
            MsgBox(TextBox1.Text)
        Else
            MsgBox("Empty !")
        End If


    End Sub
End Class
