Imports System.Data.OleDb
Public Class Form1
    Dim RegistrationType As String
    Dim StorageStatus As String
    Dim x As Integer = 0 'counter for list index
    Dim accesoryList As New List(Of String)
    '-----DB Connection
    Dim con As New OleDbConnection
    Dim dbConnection As OleDbConnection
    Dim dbCommand As OleDbCommand
    Dim dbDataAdapter As OleDbDataAdapter
    Dim ConnectString As String = "Provider = Microsoft.Jet.OLEDB.4.0;" & "Data Source = Nekostash.mdb" 'This only work went DB file is inside /bin/debug folder
    Dim dtNekostash As DataTable
    '-----DB Connection

    '-----DB Variables
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        'TODO: This line of code loads data into the 'NekostashDataSet.NekoAssets' table. You can move, or remove it, as needed.
        con.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source= ..\Debug\Nekostash.mdb"
        'Me.NekoAssetsTableAdapter.Fill(Me.NekostashDataSet.NekoAssets)
        'TabControl1.
        'TabPage1.AutoSize = True
    End Sub

    Private Sub rbtnIn_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnIn.CheckedChanged
        'Updates Registration Type Label
        If rbtnIn.Checked Then
            StorageStatus = "in"
            btnRefresh.Text = "PC Refresh"
            btnLoan.Text = "Loan PC Return"
            btnStorage.Text = "Storage"
            btnTermination.Text = "Termination"
            Label_RegistrationType.Text = ""
            btnEOL.Visible = False
        Else
            StorageStatus = "out"
            btnRefresh.Text = "PC Refresh"
            btnLoan.Text = "Loan PC"
            btnStorage.Text = "Storage (Warehouse)"
            btnTermination.Text = "New Hire"
            Label_RegistrationType.Text = ""
            btnEOL.Visible = True
        End If
    End Sub

    '==========Updates Registration Type label for everytime a registration button selected


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
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Select Case True
            Case Me.rbtnIn.Checked
                Label_RegistrationType.Text = "[IN] " + btnRefresh.Text
            Case Me.rbtnOut.Checked
                Label_RegistrationType.Text = "[OUT] " + btnRefresh.Text
        End Select
    End Sub

    Private Sub btnReturnEOL_Click(sender As Object, e As EventArgs) Handles btnEOL.Click
        Select Case True
            Case Me.rbtnIn.Checked
                btnEOL.Visible = False
            Case Me.rbtnOut.Checked
                Label_RegistrationType.Text = "[OUT] " + btnEOL.Text
        End Select
    End Sub

    Private Sub btnOther_Click(sender As Object, e As EventArgs) Handles btnOther.Click
        Form_Others.Show()
    End Sub
    '==========Updates Registration Type label for everytime a registration button selected 

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btnAddAccessory.Click
        'Add accessory list
        Dim unused = cboxAcc.Text
        accesoryList.Insert(x, cboxAcc.Text)
        x += 1
        txtboxAcc_list.AppendText(cboxAcc.Text & "," + vbNewLine)
    End Sub
    '=====================TEST
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim emptyTextBoxes =
            From txtbox In Me.Controls.OfType(Of TextBox)()
            Where txtbox.Text.Length = 0
            Select txtbox.Name
        If emptyTextBoxes.Any Then
            MessageBox.Show(String.Format("Please fill following textboxes: {0}",
                    String.Join(",", emptyTextBoxes)))
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'CLEAR ALL Button
        txtboxPIC.Clear()
        txtboxCase.Clear()
        txtboxSN.Clear()
        txtboxMemo.Clear()
        txtboxSignature.Clear()
        txtboxAcc_list.Clear()
        cboxAcc.Text = "Select Item(s)"
        accesoryList.Clear()
    End Sub

    '=====SUBMIT BUTTON
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        'NOT YET IMPLEMENTED - To check empty textboxes
        ' Dim emptyTextBoxes =
        'From txtbox In Me.Controls.OfType(Of TextBox)()
        ' Where txtbox.Text.Length = 0
        ' Select Case txtbox.Name
        ' If emptyTextBoxes.Any Then
        ' MessageBox.Show(String.Format("Please fill following textboxes: {0}",
        ' String.Join(",", emptyTextBoxes)))
        ' End If

        If txtboxSN.Text.Length > 0 And Label_RegistrationType.Text.Length > 2 And txtboxPIC.Text.Length > 0 And txtboxSignature.Text.Length > 0 Then
            'Splits text per line and inserts values to DB
            Dim split = txtboxSN.Text.Split(vbNewLine)
            Dim contents As String = txtboxSN.Text
            If split.Count > 0 Then
                Dim parts As String() = contents.Split(New String() {Environment.NewLine},
                                           StringSplitOptions.None)
                For Each Line As String In txtboxSN.Lines
                    Try
                        'Insert function
                        Me.NekoAssetsTableAdapter.Insert(Line, Me.StorageStatus, Me.txtboxPIC.Text, Me.txtboxCase.Text, Me.txtboxMemo.Text, Me.Label_RegistrationType.Text, Me.txtboxSignature.Text, String.Join(",", accesoryList.ToArray))
                        Me.NekoAssetsTableAdapter.Fill(Me.NekostashDataSet.NekoAssets)

                        'Code to to push changes to DB
                        Me.Validate()
                        Me.NekoAssetsBindingSource.EndEdit()
                        Me.TableAdapterManager.UpdateAll(Me.NekostashDataSet)
                        Me.NekoAssetsTableAdapter.Update(Me.NekostashDataSet.NekoAssets)
                    Catch ex As Exception
                        MsgBox("Error occured. Please try again.")
                    End Try

                Next
                MsgBox("DB Updated Successfully")

                'Clear entered data
                txtboxPIC.Clear()
                txtboxCase.Clear()
                txtboxSN.Clear()
                txtboxMemo.Clear()
                txtboxSignature.Clear()
                txtboxAcc_list.Clear()
                cboxAcc.Text = "Select Item(s)"
                accesoryList.Clear()
            End If
        Else
            MessageBox.Show("Please provide: Registration Type, PIC, S/N and Signature.")
        End If
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs)
        'Filter Search
        'Me.NekoAssetsBindingSource.Filter = cboxSearch.Text & " = '" & Me.txtboxSearch.Text & " ' "
        Dim SQL As String

        SQL = "SELECT NekoAssets.ID, NekoAssets.Serial,NekoAssets.Memo,NekoAssets.Date_Time " _
            & "FROM NekoAssets " _
            & "WHERE Serial LIKE '*" & Me.txtboxSearch.Text & "*' " _
            & " OR Memo LIKE '*" & Me.txtboxSearch.Text & "*' " _
            & "ORDER BY NekoAssets.Date_Time "
        'Me.NekoAssetsTableAdapter.Fill(Me.NekostashDataSet.NekoAssets)
        'Me.NekoAssetsTableAdapter.Fill(SQL)

    End Sub

    Private Sub txtboxSearch_TextChanged(sender As Object, e As EventArgs) Handles txtboxSearch.TextChanged
        If cboxSearch.Text = "" Then
            MsgBox("Please select what to 'search for' then input desired value.")
        Else
            con.Open() 'connect to DB
            Dim dt As New DataTable
            Dim ds As New DataSet
            ds.Tables.Add(dt)
            Dim da As New OleDbDataAdapter

            'Search Filter
            da = New OleDbDataAdapter("Select * from NekoAssets where " & cboxSearch.Text & " like '%" & txtboxSearch.Text & "%'", con)
            'Load Data
            da.Fill(dt)
            'Display search result
            datagridSearch.DataSource = dt.DefaultView
            con.Close() 'end connection 
        End If

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            Me.Hide()
            Login_Form.Show()
        End If
    End Sub
End Class
