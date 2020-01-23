Imports System.Data.OleDb
Public Class Form1
    Dim RegistrationType As String
    Dim StorageStatus As String
    '-----DB Variables
    Dim dbConnection As OleDbConnection
    Dim dbCommand As OleDbCommand
    Dim dbDataAdapter As OleDbDataAdapter
    Dim ConnectString As String = "Provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source = Nekostash.mdb" 'This only work went DB file is inside /bin/debug folder
    Dim dtNekostash As DataTable
    '-----DB Variables
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'NekostashDataSet.NekoAssets' table. You can move, or remove it, as needed.
        Me.NekoAssetsTableAdapter.Fill(Me.NekostashDataSet.NekoAssets)
        'NekoAssetsBindingSource.AddNew()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtboxPIC.Clear()
        txtboxCase.Clear()
        txtboxSN.Clear()
        txtboxMemo.Clear()
        txtboxSignature.Clear()
        txtboxAcc_list.Clear()
        cboxAcc.Text = "Select Item(s)"
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnAddAccessory.Click
        Dim unused = cboxAcc.Text
        txtboxAcc_list.AppendText(cboxAcc.Text + vbNewLine)

    End Sub

    Private Sub rbtnIn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnIn.CheckedChanged
        If rbtnIn.Checked Then
            StorageStatus = "in"
            btnEOL.Text = "Refresh PC (EOL) Return"
            btnLoan.Text = "Loan PC Return"
            btnStorage.Text = "Storage"
            btnTermination.Text = "Termination"
            Label_RegistrationType.Text = ""
        Else
            StorageStatus = "out"
            btnEOL.Text = "Refresh PC (EOL)"
            btnLoan.Text = "Loan PC"
            btnStorage.Text = "Storage (Warehouse)"
            btnTermination.Text = "New Hire"
            Label_RegistrationType.Text = ""
        End If
    End Sub

    '=============Update Registration type label 
    Private Sub btnEOL_Click(sender As Object, e As EventArgs) Handles btnEOL.Click
        Select Case True
            Case Me.rbtnIn.Checked
                Label_RegistrationType.Text = "[IN] " + btnEOL.Text
            Case Me.rbtnOut.Checked
                Label_RegistrationType.Text = "[OUT] " + btnEOL.Text
        End Select
    End Sub

    Private Sub btnTermination_Click(sender As Object, e As EventArgs) Handles btnTermination.Click
        Select Case True
            Case Me.rbtnIn.Checked
                Label_RegistrationType.Text = "[IN] " + btnTermination.Text
            Case Me.rbtnOut.Checked
                Label_RegistrationType.Text = "[OUT] " + btnTermination.Text
        End Select
    End Sub

    Private Sub btnLoan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click
        Select Case True
            Case Me.rbtnIn.Checked
                Label_RegistrationType.Text = "[IN] " + btnLoan.Text
            Case Me.rbtnOut.Checked
                Label_RegistrationType.Text = "[OUT] " + btnLoan.Text
        End Select
    End Sub

    Private Sub btnStorage_Click(sender As Object, e As EventArgs) Handles btnStorage.Click
        Select Case True
            Case Me.rbtnIn.Checked
                Label_RegistrationType.Text = "[IN] " + btnStorage.Text
            Case Me.rbtnOut.Checked
                Label_RegistrationType.Text = "[OUT] " + btnStorage.Text
        End Select
    End Sub

    Private Sub btnRepair_Click(sender As Object, e As EventArgs) Handles btnRepair.Click
        Select Case True
            Case Me.rbtnIn.Checked
                Label_RegistrationType.Text = "[IN] " + btnRepair.Text
            Case Me.rbtnOut.Checked
                Label_RegistrationType.Text = "[OUT] " + btnRepair.Text
        End Select
    End Sub

    Private Sub btnOther_Click(sender As Object, e As EventArgs) Handles btnOther.Click
        Form_Others.Show()
    End Sub
    '=============Update Registration type label 
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        Me.NekoAssetsTableAdapter.Insert(Me.txtboxSN.Text, Me.StorageStatus, Me.txtboxPIC.Text, Me.txtboxCase.Text, Me.txtboxMemo.Text, Me.btnEOL.Text, Me.txtboxSignature.Text, Me.txtboxAcc_list.Text)
        Me.NekoAssetsTableAdapter.Fill(Me.NekostashDataSet.NekoAssets)

        '====Code to to push changes to DB
        Me.Validate()
        Me.NekoAssetsBindingSource.EndEdit()
        Me.NekoAssetsBindingSource1.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.NekostashDataSet)
        Me.NekoAssetsTableAdapter.Update(Me.NekostashDataSet.NekoAssets)
        Me.NekoAssetsTableAdapter.Update(Me.NekostashDataSet1.NekoAssets)
        '====Code to to push changes to DB

        MsgBox("DB Updated Successfully")

        'Clears entered data
        txtboxPIC.Clear()
        txtboxCase.Clear()
        txtboxSN.Clear()
        txtboxMemo.Clear()
        txtboxSignature.Clear()
        txtboxAcc_list.Clear()
        cboxAcc.Text = "Select Item(s)"

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        'Filter Search
        Me.NekoAssetsBindingSource.Filter = cboxSearch.Text & " = '" & Me.txtboxSearch.Text & " ' "
    End Sub


End Class
