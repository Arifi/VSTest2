Imports System.Windows.Forms

Public Class LoginDlg

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    ReadOnly Property Username As String
        Get

            Return TB_Username.Text
        End Get
    End Property
    ReadOnly Property Password As String
        Get
            Return TB_password.Text
        End Get
    End Property
End Class
