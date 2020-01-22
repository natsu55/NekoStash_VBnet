<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim SerialLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim PICLabel As System.Windows.Forms.Label
        Dim CaseLabel As System.Windows.Forms.Label
        Dim MemoLabel As System.Windows.Forms.Label
        Dim Registration_TypeLabel As System.Windows.Forms.Label
        Dim SignatureLabel As System.Windows.Forms.Label
        Dim AccessoryLabel As System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnSearch = New System.Windows.Forms.Button()
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
        Me.btnEOL = New System.Windows.Forms.Button()
        Me.rbtnOut = New System.Windows.Forms.RadioButton()
        Me.rbtnIn = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.NekostashDataSet = New NekoStash_VBnet.NekostashDataSet()
        Me.NekoAssetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NekoAssetsTableAdapter = New NekoStash_VBnet.NekostashDataSetTableAdapters.NekoAssetsTableAdapter()
        Me.TableAdapterManager = New NekoStash_VBnet.NekostashDataSetTableAdapters.TableAdapterManager()
        Me.NekoAssetsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.NekoAssetsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.NekoAssetsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SerialTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.PICTextBox = New System.Windows.Forms.TextBox()
        Me.CaseTextBox = New System.Windows.Forms.TextBox()
        Me.MemoTextBox = New System.Windows.Forms.TextBox()
        Me.Registration_TypeTextBox = New System.Windows.Forms.TextBox()
        Me.SignatureTextBox = New System.Windows.Forms.TextBox()
        Me.AccessoryTextBox = New System.Windows.Forms.TextBox()
        SerialLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        PICLabel = New System.Windows.Forms.Label()
        CaseLabel = New System.Windows.Forms.Label()
        MemoLabel = New System.Windows.Forms.Label()
        Registration_TypeLabel = New System.Windows.Forms.Label()
        SignatureLabel = New System.Windows.Forms.Label()
        AccessoryLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NekostashDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NekoAssetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NekoAssetsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NekoAssetsBindingNavigator.SuspendLayout()
        CType(Me.NekoAssetsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1026, 440)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1018, 414)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "IN/OUT"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(AccessoryLabel)
        Me.GroupBox2.Controls.Add(Me.AccessoryTextBox)
        Me.GroupBox2.Controls.Add(SignatureLabel)
        Me.GroupBox2.Controls.Add(Me.SignatureTextBox)
        Me.GroupBox2.Controls.Add(Registration_TypeLabel)
        Me.GroupBox2.Controls.Add(Me.Registration_TypeTextBox)
        Me.GroupBox2.Controls.Add(MemoLabel)
        Me.GroupBox2.Controls.Add(Me.MemoTextBox)
        Me.GroupBox2.Controls.Add(CaseLabel)
        Me.GroupBox2.Controls.Add(Me.CaseTextBox)
        Me.GroupBox2.Controls.Add(PICLabel)
        Me.GroupBox2.Controls.Add(Me.PICTextBox)
        Me.GroupBox2.Controls.Add(StatusLabel)
        Me.GroupBox2.Controls.Add(Me.StatusTextBox)
        Me.GroupBox2.Controls.Add(SerialLabel)
        Me.GroupBox2.Controls.Add(Me.SerialTextBox)
        Me.GroupBox2.Controls.Add(Me.NekoAssetsDataGridView)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Controls.Add(Me.txtboxSearch)
        Me.GroupBox2.Controls.Add(Me.Label_SearchValue)
        Me.GroupBox2.Controls.Add(Me.cboxSearch)
        Me.GroupBox2.Controls.Add(Me.Label_Search)
        Me.GroupBox2.Location = New System.Drawing.Point(390, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(639, 399)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asset Search"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.btnSearch.Location = New System.Drawing.Point(413, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtboxSearch
        '
        Me.txtboxSearch.Location = New System.Drawing.Point(231, 17)
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(173, 20)
        Me.txtboxSearch.TabIndex = 4
        '
        'Label_SearchValue
        '
        Me.Label_SearchValue.AutoSize = True
        Me.Label_SearchValue.Location = New System.Drawing.Point(166, 20)
        Me.Label_SearchValue.Name = "Label_SearchValue"
        Me.Label_SearchValue.Size = New System.Drawing.Size(64, 13)
        Me.Label_SearchValue.TabIndex = 3
        Me.Label_SearchValue.Text = "Input Value:"
        '
        'cboxSearch
        '
        Me.cboxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxSearch.FormattingEnabled = True
        Me.cboxSearch.Items.AddRange(New Object() {"s/n", "pic", "signature", "memo", "accessory", "case"})
        Me.cboxSearch.Location = New System.Drawing.Point(69, 17)
        Me.cboxSearch.Name = "cboxSearch"
        Me.cboxSearch.Size = New System.Drawing.Size(79, 21)
        Me.cboxSearch.TabIndex = 2
        '
        'Label_Search
        '
        Me.Label_Search.AutoSize = True
        Me.Label_Search.Location = New System.Drawing.Point(7, 20)
        Me.Label_Search.Name = "Label_Search"
        Me.Label_Search.Size = New System.Drawing.Size(59, 13)
        Me.Label_Search.TabIndex = 0
        Me.Label_Search.Text = "Search for:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label_RegistrationType)
        Me.Panel1.Location = New System.Drawing.Point(267, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(108, 57)
        Me.Panel1.TabIndex = 29
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Registration For:"
        '
        'Label_RegistrationType
        '
        Me.Label_RegistrationType.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label_RegistrationType.Location = New System.Drawing.Point(3, 14)
        Me.Label_RegistrationType.Name = "Label_RegistrationType"
        Me.Label_RegistrationType.Size = New System.Drawing.Size(95, 39)
        Me.Label_RegistrationType.TabIndex = 28
        Me.Label_RegistrationType.Text = "-"
        Me.Label_RegistrationType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(210, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(51, 57)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Maiandra GD", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NekoStash"
        '
        'GroupBox1
        '
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
        Me.GroupBox1.Controls.Add(Me.btnEOL)
        Me.GroupBox1.Controls.Add(Me.rbtnOut)
        Me.GroupBox1.Controls.Add(Me.rbtnIn)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 334)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asset Registration"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnClear.Location = New System.Drawing.Point(293, 297)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(59, 22)
        Me.btnClear.TabIndex = 26
        Me.btnClear.Text = "Clear All"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(134, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Accessory"
        '
        'btnAddAccessory
        '
        Me.btnAddAccessory.Location = New System.Drawing.Point(321, 173)
        Me.btnAddAccessory.Name = "btnAddAccessory"
        Me.btnAddAccessory.Size = New System.Drawing.Size(44, 23)
        Me.btnAddAccessory.TabIndex = 24
        Me.btnAddAccessory.Text = "Add"
        Me.btnAddAccessory.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.btnSubmit.Location = New System.Drawing.Point(227, 297)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(60, 22)
        Me.btnSubmit.TabIndex = 22
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'cboxAcc
        '
        Me.cboxAcc.AutoCompleteCustomSource.AddRange(New String() {"AC Adapter", "LAN Adapter", "HDMI to VGA", "Other"})
        Me.cboxAcc.FormattingEnabled = True
        Me.cboxAcc.Items.AddRange(New Object() {"Apple - AC Adapter", "Lenovo - AC Adapter", "LAN Adapter (USB A)", "LAN Adapter (USB C)", "OTHER -"})
        Me.cboxAcc.Location = New System.Drawing.Point(194, 175)
        Me.cboxAcc.Name = "cboxAcc"
        Me.cboxAcc.Size = New System.Drawing.Size(121, 21)
        Me.cboxAcc.TabIndex = 23
        Me.cboxAcc.Text = "Select item"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(291, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Memo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(147, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Case #"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Signature"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 175)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "S/N"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "PIC"
        '
        'btnOther
        '
        Me.btnOther.Location = New System.Drawing.Point(175, 89)
        Me.btnOther.Name = "btnOther"
        Me.btnOther.Size = New System.Drawing.Size(75, 41)
        Me.btnOther.TabIndex = 11
        Me.btnOther.Text = "Other"
        Me.btnOther.UseVisualStyleBackColor = True
        '
        'btnRepair
        '
        Me.btnRepair.Location = New System.Drawing.Point(94, 89)
        Me.btnRepair.Name = "btnRepair"
        Me.btnRepair.Size = New System.Drawing.Size(75, 41)
        Me.btnRepair.TabIndex = 10
        Me.btnRepair.Text = "Repair"
        Me.btnRepair.UseVisualStyleBackColor = True
        '
        'btnStorage
        '
        Me.btnStorage.Location = New System.Drawing.Point(8, 89)
        Me.btnStorage.Name = "btnStorage"
        Me.btnStorage.Size = New System.Drawing.Size(80, 41)
        Me.btnStorage.TabIndex = 9
        Me.btnStorage.Text = "Storage"
        Me.btnStorage.UseVisualStyleBackColor = True
        '
        'btnLoan
        '
        Me.btnLoan.Location = New System.Drawing.Point(175, 43)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(75, 41)
        Me.btnLoan.TabIndex = 8
        Me.btnLoan.Text = "Loan PC"
        Me.btnLoan.UseVisualStyleBackColor = True
        '
        'btnTermination
        '
        Me.btnTermination.Location = New System.Drawing.Point(94, 43)
        Me.btnTermination.Name = "btnTermination"
        Me.btnTermination.Size = New System.Drawing.Size(75, 41)
        Me.btnTermination.TabIndex = 7
        Me.btnTermination.Text = "Termination"
        Me.btnTermination.UseVisualStyleBackColor = True
        '
        'btnEOL
        '
        Me.btnEOL.Location = New System.Drawing.Point(8, 43)
        Me.btnEOL.Name = "btnEOL"
        Me.btnEOL.Size = New System.Drawing.Size(80, 41)
        Me.btnEOL.TabIndex = 6
        Me.btnEOL.Text = "Refresh PC (EOL)"
        Me.btnEOL.UseVisualStyleBackColor = True
        '
        'rbtnOut
        '
        Me.rbtnOut.AutoSize = True
        Me.rbtnOut.Location = New System.Drawing.Point(56, 19)
        Me.rbtnOut.Name = "rbtnOut"
        Me.rbtnOut.Size = New System.Drawing.Size(54, 17)
        Me.rbtnOut.TabIndex = 5
        Me.rbtnOut.Text = "[OUT]"
        Me.rbtnOut.UseVisualStyleBackColor = True
        '
        'rbtnIn
        '
        Me.rbtnIn.AutoSize = True
        Me.rbtnIn.Location = New System.Drawing.Point(8, 19)
        Me.rbtnIn.Name = "rbtnIn"
        Me.rbtnIn.Size = New System.Drawing.Size(42, 17)
        Me.rbtnIn.TabIndex = 4
        Me.rbtnIn.Text = "[IN]"
        Me.rbtnIn.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1018, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DB Admin"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1018, 400)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "AUDIT"
        '
        'NekostashDataSet
        '
        Me.NekostashDataSet.DataSetName = "NekostashDataSet"
        Me.NekostashDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NekoAssetsBindingSource
        '
        Me.NekoAssetsBindingSource.DataMember = "NekoAssets"
        Me.NekoAssetsBindingSource.DataSource = Me.NekostashDataSet
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
        'NekoAssetsBindingNavigator
        '
        Me.NekoAssetsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NekoAssetsBindingNavigator.BindingSource = Me.NekoAssetsBindingSource
        Me.NekoAssetsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NekoAssetsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NekoAssetsBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.NekoAssetsBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.NekoAssetsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NekoAssetsBindingNavigatorSaveItem})
        Me.NekoAssetsBindingNavigator.Location = New System.Drawing.Point(679, 6)
        Me.NekoAssetsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NekoAssetsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NekoAssetsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NekoAssetsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NekoAssetsBindingNavigator.Name = "NekoAssetsBindingNavigator"
        Me.NekoAssetsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NekoAssetsBindingNavigator.Size = New System.Drawing.Size(300, 25)
        Me.NekoAssetsBindingNavigator.TabIndex = 2
        Me.NekoAssetsBindingNavigator.Text = "BindingNavigator1"
        Me.NekoAssetsBindingNavigator.Visible = False
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'NekoAssetsBindingNavigatorSaveItem
        '
        Me.NekoAssetsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NekoAssetsBindingNavigatorSaveItem.Image = CType(resources.GetObject("NekoAssetsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NekoAssetsBindingNavigatorSaveItem.Name = "NekoAssetsBindingNavigatorSaveItem"
        Me.NekoAssetsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.NekoAssetsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'NekoAssetsDataGridView
        '
        Me.NekoAssetsDataGridView.AllowUserToAddRows = False
        Me.NekoAssetsDataGridView.AllowUserToDeleteRows = False
        Me.NekoAssetsDataGridView.AutoGenerateColumns = False
        Me.NekoAssetsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NekoAssetsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.NekoAssetsDataGridView.DataSource = Me.NekoAssetsBindingSource
        Me.NekoAssetsDataGridView.Location = New System.Drawing.Point(231, 51)
        Me.NekoAssetsDataGridView.Name = "NekoAssetsDataGridView"
        Me.NekoAssetsDataGridView.ReadOnly = True
        Me.NekoAssetsDataGridView.Size = New System.Drawing.Size(388, 328)
        Me.NekoAssetsDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Date_Time"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date_Time"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Serial"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Serial"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PIC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PIC"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Case"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Case"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Memo"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Memo"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Registration_Type"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Registration_Type"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Signature"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Signature"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Accessory"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Accessory"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'SerialLabel
        '
        SerialLabel.AutoSize = True
        SerialLabel.Location = New System.Drawing.Point(20, 110)
        SerialLabel.Name = "SerialLabel"
        SerialLabel.Size = New System.Drawing.Size(36, 13)
        SerialLabel.TabIndex = 6
        SerialLabel.Text = "Serial:"
        '
        'SerialTextBox
        '
        Me.SerialTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NekoAssetsBindingSource, "Serial", True))
        Me.SerialTextBox.Location = New System.Drawing.Point(62, 107)
        Me.SerialTextBox.Name = "SerialTextBox"
        Me.SerialTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SerialTextBox.TabIndex = 7
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(21, 150)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 8
        StatusLabel.Text = "Status:"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NekoAssetsBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(67, 147)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(100, 20)
        Me.StatusTextBox.TabIndex = 9
        '
        'PICLabel
        '
        PICLabel.AutoSize = True
        PICLabel.Location = New System.Drawing.Point(18, 186)
        PICLabel.Name = "PICLabel"
        PICLabel.Size = New System.Drawing.Size(27, 13)
        PICLabel.TabIndex = 10
        PICLabel.Text = "PIC:"
        '
        'PICTextBox
        '
        Me.PICTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NekoAssetsBindingSource, "PIC", True))
        Me.PICTextBox.Location = New System.Drawing.Point(51, 183)
        Me.PICTextBox.Name = "PICTextBox"
        Me.PICTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PICTextBox.TabIndex = 11
        '
        'CaseLabel
        '
        CaseLabel.AutoSize = True
        CaseLabel.Location = New System.Drawing.Point(17, 222)
        CaseLabel.Name = "CaseLabel"
        CaseLabel.Size = New System.Drawing.Size(34, 13)
        CaseLabel.TabIndex = 12
        CaseLabel.Text = "Case:"
        '
        'CaseTextBox
        '
        Me.CaseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NekoAssetsBindingSource, "Case", True))
        Me.CaseTextBox.Location = New System.Drawing.Point(57, 219)
        Me.CaseTextBox.Name = "CaseTextBox"
        Me.CaseTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CaseTextBox.TabIndex = 13
        '
        'MemoLabel
        '
        MemoLabel.AutoSize = True
        MemoLabel.Location = New System.Drawing.Point(18, 253)
        MemoLabel.Name = "MemoLabel"
        MemoLabel.Size = New System.Drawing.Size(39, 13)
        MemoLabel.TabIndex = 14
        MemoLabel.Text = "Memo:"
        '
        'MemoTextBox
        '
        Me.MemoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NekoAssetsBindingSource, "Memo", True))
        Me.MemoTextBox.Location = New System.Drawing.Point(63, 250)
        Me.MemoTextBox.Name = "MemoTextBox"
        Me.MemoTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MemoTextBox.TabIndex = 15
        '
        'Registration_TypeLabel
        '
        Registration_TypeLabel.AutoSize = True
        Registration_TypeLabel.Location = New System.Drawing.Point(16, 291)
        Registration_TypeLabel.Name = "Registration_TypeLabel"
        Registration_TypeLabel.Size = New System.Drawing.Size(93, 13)
        Registration_TypeLabel.TabIndex = 16
        Registration_TypeLabel.Text = "Registration Type:"
        '
        'Registration_TypeTextBox
        '
        Me.Registration_TypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NekoAssetsBindingSource, "Registration_Type", True))
        Me.Registration_TypeTextBox.Location = New System.Drawing.Point(115, 288)
        Me.Registration_TypeTextBox.Name = "Registration_TypeTextBox"
        Me.Registration_TypeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Registration_TypeTextBox.TabIndex = 17
        '
        'SignatureLabel
        '
        SignatureLabel.AutoSize = True
        SignatureLabel.Location = New System.Drawing.Point(16, 325)
        SignatureLabel.Name = "SignatureLabel"
        SignatureLabel.Size = New System.Drawing.Size(55, 13)
        SignatureLabel.TabIndex = 18
        SignatureLabel.Text = "Signature:"
        '
        'SignatureTextBox
        '
        Me.SignatureTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NekoAssetsBindingSource, "Signature", True))
        Me.SignatureTextBox.Location = New System.Drawing.Point(77, 322)
        Me.SignatureTextBox.Name = "SignatureTextBox"
        Me.SignatureTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SignatureTextBox.TabIndex = 19
        '
        'AccessoryLabel
        '
        AccessoryLabel.AutoSize = True
        AccessoryLabel.Location = New System.Drawing.Point(15, 351)
        AccessoryLabel.Name = "AccessoryLabel"
        AccessoryLabel.Size = New System.Drawing.Size(59, 13)
        AccessoryLabel.TabIndex = 20
        AccessoryLabel.Text = "Accessory:"
        '
        'AccessoryTextBox
        '
        Me.AccessoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NekoAssetsBindingSource, "Accessory", True))
        Me.AccessoryTextBox.Location = New System.Drawing.Point(80, 348)
        Me.AccessoryTextBox.Name = "AccessoryTextBox"
        Me.AccessoryTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AccessoryTextBox.TabIndex = 21
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 460)
        Me.Controls.Add(Me.NekoAssetsBindingNavigator)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "NekoStash Inventory Manager"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NekostashDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NekoAssetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NekoAssetsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NekoAssetsBindingNavigator.ResumeLayout(False)
        Me.NekoAssetsBindingNavigator.PerformLayout()
        CType(Me.NekoAssetsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
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
    Friend WithEvents btnEOL As Button
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
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtboxSearch As TextBox
    Friend WithEvents Label_SearchValue As Label
    Friend WithEvents NekostashDataSet As NekostashDataSet
    Friend WithEvents NekoAssetsBindingSource As BindingSource
    Friend WithEvents NekoAssetsTableAdapter As NekostashDataSetTableAdapters.NekoAssetsTableAdapter
    Friend WithEvents TableAdapterManager As NekostashDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NekoAssetsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents NekoAssetsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AccessoryTextBox As TextBox
    Friend WithEvents SignatureTextBox As TextBox
    Friend WithEvents Registration_TypeTextBox As TextBox
    Friend WithEvents MemoTextBox As TextBox
    Friend WithEvents CaseTextBox As TextBox
    Friend WithEvents PICTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents SerialTextBox As TextBox
    Friend WithEvents NekoAssetsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
End Class
