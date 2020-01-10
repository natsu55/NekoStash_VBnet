Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ComboBox_Acc.Text = "Select Item(s)"
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TextBox_PIC.Clear()
        TextBox_SN.Clear()
        TextBox_Case.Clear()
        TextBox_Memo.Clear()
        TextBox_Signature.Clear()
        TextBox_Acc_list.Clear()
        ComboBox_Acc.Text = "Select Item(s)"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim unused = ComboBox_Acc.Text
        TextBox_Acc_list.AppendText(ComboBox_Acc.Text + vbNewLine)

    End Sub
End Class
