Public Class Login_Form
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        Form1.Show()
        Form1.TabControl1.SelectTab(0)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtboxUsername.Text = "LTSC" And txtboxPassword.Text = "LTSCKiosk25" Then
            Form1.Show()
            Form1.TabControl1.SelectTab(1)
            Me.Hide()
            Form1.NekoAssetsTableAdapter.Fill(Form1.NekostashDataSet.NekoAssets)
        Else
            MsgBox("Password incorrect. You shall not pass!")
        End If
        txtboxUsername.Text = ""
        txtboxPassword.Text = ""
    End Sub
End Class