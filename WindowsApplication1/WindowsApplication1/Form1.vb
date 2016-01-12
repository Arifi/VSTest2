

Public Class Form1


    Protected Property username As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If LoginDlg.ShowDialog() = Windows.Forms.DialogResult.OK Then

            If LoginDlg.Password = "123" Then
                username = LoginDlg.Username
                MsgBox("Welcom", MsgBoxStyle.Information)
            Else
                MsgBox("Wrong password", MsgBoxStyle.Exclamation)
            End If
        End If

        'ClassLibrary1.Class1.Msg("Hello Git !")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text <> "" Then
            MsgBox(TextBox1.Text)
        Else
            MsgBox("Nothing to show !")
        End If


    End Sub
End Class
