<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.datagridSearch = New System.Windows.Forms.DataGridView()
        Me.NekoAssetsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NekostashDataSet = New NekoStash_VBnet.NekostashDataSet()
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
        Me.btnEOL = New System.Windows.Forms.Button()
        Me.rbtnOut = New System.Windows.Forms.RadioButton()
        Me.rbtnIn = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.NekoAssetsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NekoAssetsTableAdapter = New NekoStash_VBnet.NekostashDataSetTableAdapters.NekoAssetsTableAdapter()
        Me.TableAdapterManager = New NekoStash_VBnet.NekostashDataSetTableAdapters.TableAdapterManager()
        Me.NekostashDataSet1 = New NekoStash_VBnet.NekostashDataSet()
        Me.NekostashDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSearchNote = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datagridSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NekoAssetsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NekostashDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.NekoAssetsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NekostashDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NekostashDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.GroupBox2.Controls.Add(Me.lblSearchNote)
        Me.GroupBox2.Controls.Add(Me.datagridSearch)
        Me.GroupBox2.Controls.Add(Me.txtboxSearch)
        Me.GroupBox2.Controls.Add(Me.Label_SearchValue)
        Me.GroupBox2.Controls.Add(Me.cboxSearch)
        Me.GroupBox2.Controls.Add(Me.Label_Search)
        Me.GroupBox2.Location = New System.Drawing.Point(390, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(610, 385)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Asset Search"
        '
        'datagridSearch
        '
        Me.datagridSearch.AllowUserToAddRows = False
        Me.datagridSearch.AllowUserToDeleteRows = False
        Me.datagridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridSearch.Location = New System.Drawing.Point(8, 56)
        Me.datagridSearch.Name = "datagridSearch"
        Me.datagridSearch.ReadOnly = True
        Me.datagridSearch.Size = New System.Drawing.Size(596, 315)
        Me.datagridSearch.TabIndex = 22
        '
        'NekoAssetsBindingSource1
        '
        Me.NekoAssetsBindingSource1.DataMember = "NekoAssets"
        Me.NekoAssetsBindingSource1.DataSource = Me.NekostashDataSet
        '
        'NekostashDataSet
        '
        Me.NekostashDataSet.DataSetName = "NekostashDataSet"
        Me.NekostashDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtboxSearch
        '
        Me.txtboxSearch.Location = New System.Drawing.Point(223, 17)
        Me.txtboxSearch.Name = "txtboxSearch"
        Me.txtboxSearch.Size = New System.Drawing.Size(138, 20)
        Me.txtboxSearch.TabIndex = 4
        '
        'Label_SearchValue
        '
        Me.Label_SearchValue.AutoSize = True
        Me.Label_SearchValue.Location = New System.Drawing.Point(158, 20)
        Me.Label_SearchValue.Name = "Label_SearchValue"
        Me.Label_SearchValue.Size = New System.Drawing.Size(64, 13)
        Me.Label_SearchValue.TabIndex = 3
        Me.Label_SearchValue.Text = "Input Value:"
        '
        'cboxSearch
        '
        Me.cboxSearch.AutoCompleteCustomSource.AddRange(New String() {"Serial", "PIC", "Signature", "Memo"})
        Me.cboxSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboxSearch.FormattingEnabled = True
        Me.cboxSearch.Items.AddRange(New Object() {"Serial", "PIC", "Signature", "Memo"})
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
        'txtboxMemo
        '
        Me.txtboxMemo.Location = New System.Drawing.Point(261, 43)
        Me.txtboxMemo.Multiline = True
        Me.txtboxMemo.Name = "txtboxMemo"
        Me.txtboxMemo.Size = New System.Drawing.Size(100, 87)
        Me.txtboxMemo.TabIndex = 32
        '
        'txtboxAcc_list
        '
        Me.txtboxAcc_list.Location = New System.Drawing.Point(194, 199)
        Me.txtboxAcc_list.Multiline = True
        Me.txtboxAcc_list.Name = "txtboxAcc_list"
        Me.txtboxAcc_list.Size = New System.Drawing.Size(121, 88)
        Me.txtboxAcc_list.TabIndex = 31
        '
        'txtboxCase
        '
        Me.txtboxCase.Location = New System.Drawing.Point(194, 146)
        Me.txtboxCase.Name = "txtboxCase"
        Me.txtboxCase.Size = New System.Drawing.Size(100, 20)
        Me.txtboxCase.TabIndex = 30
        '
        'txtboxSignature
        '
        Me.txtboxSignature.Location = New System.Drawing.Point(64, 300)
        Me.txtboxSignature.Name = "txtboxSignature"
        Me.txtboxSignature.Size = New System.Drawing.Size(100, 20)
        Me.txtboxSignature.TabIndex = 29
        '
        'txtboxSN
        '
        Me.txtboxSN.Location = New System.Drawing.Point(33, 173)
        Me.txtboxSN.Multiline = True
        Me.txtboxSN.Name = "txtboxSN"
        Me.txtboxSN.Size = New System.Drawing.Size(100, 118)
        Me.txtboxSN.TabIndex = 28
        '
        'txtboxPIC
        '
        Me.txtboxPIC.Location = New System.Drawing.Point(33, 146)
        Me.txtboxPIC.Name = "txtboxPIC"
        Me.txtboxPIC.Size = New System.Drawing.Size(100, 20)
        Me.txtboxPIC.TabIndex = 27
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
        Me.cboxAcc.Text = "Select item(s)"
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
        Me.TabPage2.Size = New System.Drawing.Size(1018, 414)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DB Admin"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1018, 414)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "AUDIT"
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
        'NekostashDataSet1
        '
        Me.NekostashDataSet1.DataSetName = "NekostashDataSet"
        Me.NekostashDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NekostashDataSetBindingSource
        '
        Me.NekostashDataSetBindingSource.DataSource = Me.NekostashDataSet
        Me.NekostashDataSetBindingSource.Position = 0
        '
        'lblSearchNote
        '
        Me.lblSearchNote.AutoSize = True
        Me.lblSearchNote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblSearchNote.Location = New System.Drawing.Point(369, 19)
        Me.lblSearchNote.Name = "lblSearchNote"
        Me.lblSearchNote.Size = New System.Drawing.Size(214, 15)
        Me.lblSearchNote.TabIndex = 23
        Me.lblSearchNote.Text = "Change in Value => Auto Update"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 460)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "NekoStash Inventory Manager"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datagridSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NekoAssetsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NekostashDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.NekoAssetsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NekostashDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NekostashDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
    Friend WithEvents NekostashDataSet1 As NekostashDataSet
    Friend WithEvents NekoAssetsBindingSource1 As BindingSource
    Friend WithEvents NekostashDataSetBindingSource As BindingSource
    Friend WithEvents lblSearchNote As Label
End Class
