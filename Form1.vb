Public Class Form1
    Dim RegistrationType As String
    Dim StorageStatus As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'NekostashDataSet.NekoAssets' table. You can move, or remove it, as needed.
        'Me.NekoAssetsTableAdapter.Fill(Me.NekostashDataSet.NekoAssets)
        'NekoAssetsBindingSource.AddNew()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'txtboxPIC.Clear()
        'txtboxCase.Clear()
        'txtboxSN.Clear()
        'txtboxMemo.Clear()
        'txtboxSignature.Clear()
        'txtboxAcc_list.Clear()
        cboxAcc.Text = "Select Item(s)"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnAddAccessory.Click
        Dim unused = cboxAcc.Text
        'txtboxAcc_list.AppendText(cboxAcc.Text + vbNewLine)

    End Sub

    Private Sub rbtnIn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnIn.CheckedChanged
        If rbtnIn.Checked Then
            StorageStatus = "in"
            btnEOL.Text = "Refresh PC (EOL) Return"
            btnLoan.Text = "Loan PC Return"
            btnStorage.Text = "Storage"
            btnTermination.Text = "Termination"
        Else
            StorageStatus = "out"
            btnEOL.Text = "Refresh PC (EOL)"
            btnLoan.Text = "Loan PC"
            btnStorage.Text = "Storage (Warehouse)"
            btnTermination.Text = "New Hire"
        End If
    End Sub

    Private Sub btnEOL_Click(sender As Object, e As EventArgs) Handles btnEOL.Click
        Select Case True
            Case Me.rbtnIn.Checked
                Label_RegistrationType.Text = "[IN] " + btnEOL.Text
            Case Me.rbtnOut.Checked
                Label_RegistrationType.Text = "[OUT] " + btnEOL.Text
        End Select
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Try
            Me.Validate()
            Me.NekoAssetsBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.NekostashDataSet)
            NekoAssetsBindingSource.AddNew()
            MessageBox.Show("DB Updated")
        Catch ex As Exception
            MessageBox.Show("Error occured. Please check and try again.")
        End Try
    End Sub

    Private Sub NekoAssetsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles NekoAssetsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.NekoAssetsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NekostashDataSet)
    End Sub
End Class
