﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblSearchNote = New System.Windows.Forms.Label()
        Me.datagridSearch = New System.Windows.Forms.DataGridView()
        Me.txtboxSearch = New System.Windows.Forms.TextBox()
        Me.Label_SearchValue = New System.Windows.Forms.Label()
        Me.cboxSearch = New System.Windows.Forms.ComboBox()
        Me.Label_Search = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label_RegistrationType = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnEOL = New System.Windows.Forms.Button()
        Me.txtboxMemo = New System.Windows.Forms.TextBox()
        Me.txtboxAcc_list = New System.Windows.Forms.TextBox()
        Me.txtboxCase = New System.Windows.Forms.TextBox()
        Me.txtboxSignature = New System.Windows.Forms.TextBox()
        Me.txtboxSN = New System.Windows.Forms.TextBox()
        Me.txtboxPIC = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddAccessory = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.cboxAcc = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnOther = New System.Windows.Forms.Button()
        Me.btnRepair = New System.Windows.Forms.Button()
        Me.btnStorage = New System.Windows.Forms.Button()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.btnTermination = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.rbtnOut = New System.Windows.Forms.RadioButton()
        Me.rbtnIn = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.NekoAssetsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NekoAssetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NekostashDataSet = New NekoStash_VBnet.NekostashDataSet()
        Me.NekoAssetsTableAdapter = New NekoStash_VBnet.NekostashDataSetTableAdapters.NekoAssetsTableAdapter()
        Me.TableAdapterManager = New NekoStash_VBnet.NekostashDataSetTableAdapters.TableAdapterManager()
        Me.NekostashDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datagridSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.NekoAssetsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NekoAssetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NekostashDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NekostashDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(23, 17)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1720, 677)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(1712, 644)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "IN/OUT"
        '
        'GroupBox2
        '
        Me.GroupBox2.AutoSize = True
        Me.GroupBox2.Controls.Add(Me.lblSearchNote)
        Me.GroupBox2.Controls.Add(Me.datagridSearch)
        Me.GroupBox2.Controls.Add(Me.txtboxSearch)
        Me.GroupBox2.Controls.Add(Me.Label_SearchValue)
        Me.GroupBox2.Controls.Add(Me.cboxSearch)
        Me.GroupBox2.Controls.Add(Me.Label_Search)
        Me.GroupBox2.Location = New System.Drawing.Point(603, 22)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox2.Size = New System.Drawing.Size(1116, 634)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asset Search"
        '
        'lblSearchNote
        '
        Me.lblSearchNote.AutoSize = True
        Me.lblSearchNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblSearchNote.Location = New System.Drawing.Point(558, 29)
        Me.lblSearchNote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSearchNote.Name = "lblSearchNote"
        Me.lblSearchNote.Size = New System.Drawing.Size(305, 22)
        Me.lblSearchNote.TabIndex = 23
        Me.lblSearchNote.Text = "Change in Value => Auto Update"
        '
        'datagridSearch
        '
        Me.datagridSearch.AllowUserToAddRows = False
        Me.datagridSearch.AllowUserToDeleteRows = False
        Me.datagridSearch.AllowUserToOrderColumns = True
        Me.datagridSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.datagridSearch.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.datagridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridSearch.DefaultCellStyle = DataGridViewCellStyle1
        Me.datagridSearch.Location = New System.Drawing.Point(14, 69)
        Me.datagridSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.datagridSearch.Name = "datagridSearch"
        Me.datagridSearch.ReadOnly = True
        Me.datagridSearch.RowHeadersWidth = 62
        Me.datagridSearch.Size = New System.Drawing.Size(1094, 485)
        Me.datagridSearch.TabIndex = 22
        '
        'txtboxSearch
        '
        Me.txtboxSearch.Location = New System.Drawing.Point(356, 26)
        Me.txtboxSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(192, 26)
        Me.txtboxSearch.TabIndex = 4
        '
        'Label_SearchValue
        '
        Me.Label_SearchValue.AutoSize = True
        Me.Label_SearchValue.Location = New System.Drawing.Point(258, 31)
        Me.Label_SearchValue.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_SearchValue.Name = "Label_SearchValue"
        Me.Label_SearchValue.Size = New System.Drawing.Size(95, 20)
        Me.Label_SearchValue.TabIndex = 3
        Me.Label_SearchValue.Text = "Input Value:"
        '
        'cboxSearch
        '
        Me.cboxSearch.AutoCompleteCustomSource.AddRange(New String() {"Serial", "PIC", "Signature", "Memo"})
        Me.cboxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxSearch.FormattingEnabled = True
        Me.cboxSearch.Items.AddRange(New Object() {"Serial", "PIC", "Signature", "Memo"})
        Me.cboxSearch.Location = New System.Drawing.Point(104, 26)
        Me.cboxSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboxSearch.Name = "cboxSearch"
        Me.cboxSearch.Size = New System.Drawing.Size(116, 28)
        Me.cboxSearch.TabIndex = 2
        '
        'Label_Search
        '
        Me.Label_Search.AutoSize = True
        Me.Label_Search.Location = New System.Drawing.Point(10, 31)
        Me.Label_Search.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_Search.Name = "Label_Search"
        Me.Label_Search.Size = New System.Drawing.Size(87, 20)
        Me.Label_Search.TabIndex = 0
        Me.Label_Search.Text = "Search for:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label_RegistrationType)
        Me.Panel1.Location = New System.Drawing.Point(400, 5)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(160, 86)
        Me.Panel1.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 0)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Registration For:"
        '
        'Label_RegistrationType
        '
        Me.Label_RegistrationType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_RegistrationType.Location = New System.Drawing.Point(4, 22)
        Me.Label_RegistrationType.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label_RegistrationType.Name = "Label_RegistrationType"
        Me.Label_RegistrationType.Size = New System.Drawing.Size(142, 60)
        Me.Label_RegistrationType.TabIndex = 28
        Me.Label_RegistrationType.Text = "-"
        Me.Label_RegistrationType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(315, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(331, 69)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NekoStash"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnEOL)
        Me.GroupBox1.Controls.Add(Me.txtboxMemo)
        Me.GroupBox1.Controls.Add(Me.txtboxAcc_list)
        Me.GroupBox1.Controls.Add(Me.txtboxCase)
        Me.GroupBox1.Controls.Add(Me.txtboxSignature)
        Me.GroupBox1.Controls.Add(Me.txtboxSN)
        Me.GroupBox1.Controls.Add(Me.txtboxPIC)
        Me.GroupBox1.Controls.Add(Me.btnClear)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnAddAccessory)
        Me.GroupBox1.Controls.Add(Me.btnSubmit)
        Me.GroupBox1.Controls.Add(Me.cboxAcc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnOther)
        Me.GroupBox1.Controls.Add(Me.btnRepair)
        Me.GroupBox1.Controls.Add(Me.btnStorage)
        Me.GroupBox1.Controls.Add(Me.btnLoan)
        Me.GroupBox1.Controls.Add(Me.btnTermination)
        Me.GroupBox1.Controls.Add(Me.btnRefresh)
        Me.GroupBox1.Controls.Add(Me.rbtnOut)
        Me.GroupBox1.Controls.Add(Me.rbtnIn)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 92)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.GroupBox1.Size = New System.Drawing.Size(550, 514)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asset Registration"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(205, 373)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 34)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnEOL
        '
        Me.btnEOL.Location = New System.Drawing.Point(172, 18)
        Me.btnEOL.Name = "btnEOL"
        Me.btnEOL.Size = New System.Drawing.Size(111, 40)
        Me.btnEOL.TabIndex = 33
        Me.btnEOL.Text = "Return EOL"
        Me.btnEOL.UseVisualStyleBackColor = True
        '
        'txtboxMemo
        '
        Me.txtboxMemo.Location = New System.Drawing.Point(392, 66)
        Me.txtboxMemo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxMemo.Multiline = True
        Me.txtboxMemo.Name = "txtboxMemo"
        Me.txtboxMemo.Size = New System.Drawing.Size(148, 132)
        Me.txtboxMemo.TabIndex = 32
        '
        'txtboxAcc_list
        '
        Me.txtboxAcc_list.Location = New System.Drawing.Point(291, 306)
        Me.txtboxAcc_list.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxAcc_list.Multiline = True
        Me.txtboxAcc_list.Name = "txtboxAcc_list"
        Me.txtboxAcc_list.Size = New System.Drawing.Size(180, 133)
        Me.txtboxAcc_list.TabIndex = 31
        '
        'txtboxCase
        '
        Me.txtboxCase.Location = New System.Drawing.Point(291, 225)
        Me.txtboxCase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxCase.Name = "txtboxCase"
        Me.txtboxCase.Size = New System.Drawing.Size(148, 26)
        Me.txtboxCase.TabIndex = 30
        '
        'txtboxSignature
        '
        Me.txtboxSignature.Location = New System.Drawing.Point(96, 462)
        Me.txtboxSignature.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxSignature.Name = "txtboxSignature"
        Me.txtboxSignature.Size = New System.Drawing.Size(148, 26)
        Me.txtboxSignature.TabIndex = 29
        '
        'txtboxSN
        '
        Me.txtboxSN.Location = New System.Drawing.Point(50, 266)
        Me.txtboxSN.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxSN.Multiline = True
        Me.txtboxSN.Name = "txtboxSN"
        Me.txtboxSN.Size = New System.Drawing.Size(148, 179)
        Me.txtboxSN.TabIndex = 28
        '
        'txtboxPIC
        '
        Me.txtboxPIC.Location = New System.Drawing.Point(50, 225)
        Me.txtboxPIC.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtboxPIC.Name = "txtboxPIC"
        Me.txtboxPIC.Size = New System.Drawing.Size(148, 26)
        Me.txtboxPIC.TabIndex = 27
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnClear.Location = New System.Drawing.Point(440, 457)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(88, 34)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(201, 274)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Accessory"
        '
        'btnAddAccessory
        '
        Me.btnAddAccessory.Location = New System.Drawing.Point(482, 266)
        Me.btnAddAccessory.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAddAccessory.Name = "btnAddAccessory"
        Me.btnAddAccessory.Size = New System.Drawing.Size(66, 35)
        Me.btnAddAccessory.TabIndex = 24
        Me.btnAddAccessory.Text = "Add"
        Me.btnAddAccessory.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnSubmit.Location = New System.Drawing.Point(340, 457)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(90, 34)
        Me.btnSubmit.TabIndex = 22
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'cboxAcc
        '
        Me.cboxAcc.AutoCompleteCustomSource.AddRange(New String() {"AC Adapter", "LAN Adapter", "HDMI to VGA", "Other"})
        Me.cboxAcc.FormattingEnabled = True
        Me.cboxAcc.Items.AddRange(New Object() {"Apple - AC Adapter", "Lenovo - AC Adapter", "LAN Adapter (USB A)", "LAN Adapter (USB C)", "OTHER -"})
        Me.cboxAcc.Location = New System.Drawing.Point(291, 269)
        Me.cboxAcc.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboxAcc.Name = "cboxAcc"
        Me.cboxAcc.Size = New System.Drawing.Size(180, 28)
        Me.cboxAcc.TabIndex = 23
        Me.cboxAcc.Text = "Select item(s)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(436, 42)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 20)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Memo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(220, 229)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Case #"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 465)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Signature"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 269)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "S/N"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 229)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "PIC"
        '
        'btnOther
        '
        Me.btnOther.Location = New System.Drawing.Point(262, 137)
        Me.btnOther.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOther.Name = "btnOther"
        Me.btnOther.Size = New System.Drawing.Size(112, 63)
        Me.btnOther.TabIndex = 11
        Me.btnOther.Text = "Other"
        Me.btnOther.UseVisualStyleBackColor = True
        '
        'btnRepair
        '
        Me.btnRepair.Location = New System.Drawing.Point(141, 137)
        Me.btnRepair.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRepair.Name = "btnRepair"
        Me.btnRepair.Size = New System.Drawing.Size(112, 63)
        Me.btnRepair.TabIndex = 10
        Me.btnRepair.Text = "Repair"
        Me.btnRepair.UseVisualStyleBackColor = True
        '
        'btnStorage
        '
        Me.btnStorage.Location = New System.Drawing.Point(12, 137)
        Me.btnStorage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnStorage.Name = "btnStorage"
        Me.btnStorage.Size = New System.Drawing.Size(120, 63)
        Me.btnStorage.TabIndex = 9
        Me.btnStorage.Text = "Storage"
        Me.btnStorage.UseVisualStyleBackColor = True
        '
        'btnLoan
        '
        Me.btnLoan.Location = New System.Drawing.Point(262, 66)
        Me.btnLoan.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(112, 63)
        Me.btnLoan.TabIndex = 8
        Me.btnLoan.Text = "Loan PC"
        Me.btnLoan.UseVisualStyleBackColor = True
        '
        'btnTermination
        '
        Me.btnTermination.Location = New System.Drawing.Point(141, 66)
        Me.btnTermination.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnTermination.Name = "btnTermination"
        Me.btnTermination.Size = New System.Drawing.Size(112, 63)
        Me.btnTermination.TabIndex = 7
        Me.btnTermination.Text = "Termination"
        Me.btnTermination.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(12, 66)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(120, 63)
        Me.btnRefresh.TabIndex = 6
        Me.btnRefresh.Text = "Refresh PC"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'rbtnOut
        '
        Me.rbtnOut.AutoSize = True
        Me.rbtnOut.Location = New System.Drawing.Point(84, 29)
        Me.rbtnOut.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtnOut.Name = "rbtnOut"
        Me.rbtnOut.Size = New System.Drawing.Size(75, 24)
        Me.rbtnOut.TabIndex = 5
        Me.rbtnOut.Text = "[OUT]"
        Me.rbtnOut.UseVisualStyleBackColor = True
        '
        'rbtnIn
        '
        Me.rbtnIn.AutoSize = True
        Me.rbtnIn.Location = New System.Drawing.Point(12, 29)
        Me.rbtnIn.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rbtnIn.Name = "rbtnIn"
        Me.rbtnIn.Size = New System.Drawing.Size(58, 24)
        Me.rbtnIn.TabIndex = 4
        Me.rbtnIn.Text = "[IN]"
        Me.rbtnIn.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.TextBox1)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.ComboBox1)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.NekoAssetsDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(1712, 644)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DB Admin"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label9.Location = New System.Drawing.Point(555, 12)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(305, 22)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Change in Value => Auto Update"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(336, 9)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(205, 26)
        Me.TextBox1.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(238, 14)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(95, 20)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Input Value:"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"Serial", "PIC", "Signature", "Memo"})
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Serial", "PIC", "Signature", "Memo"})
        Me.ComboBox1.Location = New System.Drawing.Point(105, 9)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(116, 28)
        Me.ComboBox1.TabIndex = 25
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 14)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 20)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "Search for:"
        '
        'NekoAssetsDataGridView
        '
        Me.NekoAssetsDataGridView.AutoGenerateColumns = False
        Me.NekoAssetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NekoAssetsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.NekoAssetsDataGridView.DataSource = Me.NekoAssetsBindingSource
        Me.NekoAssetsDataGridView.Location = New System.Drawing.Point(9, 51)
        Me.NekoAssetsDataGridView.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.NekoAssetsDataGridView.Name = "NekoAssetsDataGridView"
        Me.NekoAssetsDataGridView.RowHeadersWidth = 62
        Me.NekoAssetsDataGridView.Size = New System.Drawing.Size(1416, 577)
        Me.NekoAssetsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Serial"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Serial"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PIC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PIC"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Case"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Case"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Memo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Memo"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Registration_Type"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Registration_Type"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Signature"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Signature"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Accessory"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Accessory"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'NekoAssetsBindingSource
        '
        Me.NekoAssetsBindingSource.DataMember = "NekoAssets"
        Me.NekoAssetsBindingSource.DataSource = Me.NekostashDataSet
        '
        'NekostashDataSet
        '
        Me.NekostashDataSet.DataSetName = "NekostashDataSet"
        Me.NekostashDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NekoAssetsTableAdapter
        '
        Me.NekoAssetsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.NekoAssetsTableAdapter = Me.NekoAssetsTableAdapter
        Me.TableAdapterManager.UpdateOrder = NekoStash_VBnet.NekostashDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NekostashDataSetBindingSource
        '
        Me.NekostashDataSetBindingSource.DataSource = Me.NekostashDataSet
        Me.NekostashDataSetBindingSource.Position = 0
        '
        'Panel2
        '
        Me.Panel2.AutoSize = True
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Location = New System.Drawing.Point(12, 145)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1732, 665)
        Me.Panel2.TabIndex = 31
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1756, 855)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "NekoStash Inventory Manager"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datagridSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.NekoAssetsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NekoAssetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NekostashDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NekostashDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnOther As Button
    Friend WithEvents btnRepair As Button
    Friend WithEvents btnStorage As Button
    Friend WithEvents btnLoan As Button
    Friend WithEvents btnTermination As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents rbtnOut As RadioButton
    Friend WithEvents rbtnIn As RadioButton
    Friend WithEvents cboxAcc As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents btnAddAccessory As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label_RegistrationType As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents cboxSearch As ComboBox
    Friend WithEvents Label_Search As Label
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents Label_SearchValue As Label
    Friend WithEvents NekostashDataSet As NekostashDataSet
    Friend WithEvents NekoAssetsBindingSource As BindingSource
    Friend WithEvents NekoAssetsTableAdapter As NekostashDataSetTableAdapters.NekoAssetsTableAdapter
    Friend WithEvents TableAdapterManager As NekostashDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents txtboxMemo As TextBox
    Friend WithEvents txtboxAcc_list As TextBox
    Friend WithEvents txtboxCase As TextBox
    Friend WithEvents txtboxSignature As TextBox
    Friend WithEvents txtboxSN As TextBox
    Friend WithEvents txtboxPIC As TextBox
    Friend WithEvents datagridSearch As DataGridView
    Friend WithEvents NekostashDataSetBindingSource As BindingSource
    Friend WithEvents lblSearchNote As Label
    Friend WithEvents NekoAssetsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnEOL As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
End Class
