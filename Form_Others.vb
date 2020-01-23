Public Class Form_Others
    Private Sub btnOthersDes_Click(sender As Object, e As EventArgs) Handles btnOthersDes.Click
        Select Case True
            Case Form1.rbtnIn.Checked
                Form1.Label_RegistrationType.Text = "[IN] " + txtboxOthers.Text
            Case Form1.rbtnOut.Checked
                Form1.Label_RegistrationType.Text = "[OUT] " + txtboxOthers.Text
        End Select
        Me.Close()
    End Sub
End Class