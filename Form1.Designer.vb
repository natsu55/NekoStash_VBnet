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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox_Acc_list = New System.Windows.Forms.TextBox()
        Me.TextBox_Signature = New System.Windows.Forms.TextBox()
        Me.ComboBox_Acc = New System.Windows.Forms.ComboBox()
        Me.TextBox_Memo = New System.Windows.Forms.TextBox()
        Me.TextBox_Case = New System.Windows.Forms.TextBox()
        Me.TextBox_SN = New System.Windows.Forms.TextBox()
        Me.TextBox_PIC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.HelpProvider1 = New System.Windows.Forms.HelpProvider()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
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
        Me.TabControl1.Size = New System.Drawing.Size(761, 426)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(753, 400)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "IN/OUT"
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
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 48)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "NekoStash"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button9)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Button8)
        Me.GroupBox1.Controls.Add(Me.Button7)
        Me.GroupBox1.Controls.Add(Me.TextBox_Acc_list)
        Me.GroupBox1.Controls.Add(Me.TextBox_Signature)
        Me.GroupBox1.Controls.Add(Me.ComboBox_Acc)
        Me.GroupBox1.Controls.Add(Me.TextBox_Memo)
        Me.GroupBox1.Controls.Add(Me.TextBox_Case)
        Me.GroupBox1.Controls.Add(Me.TextBox_SN)
        Me.GroupBox1.Controls.Add(Me.TextBox_PIC)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 60)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(367, 334)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Asset Registration"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button9.Location = New System.Drawing.Point(293, 297)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(59, 22)
        Me.Button9.TabIndex = 26
        Me.Button9.Text = "Clear All"
        Me.Button9.UseVisualStyleBackColor = False
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
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(321, 173)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(44, 23)
        Me.Button8.TabIndex = 24
        Me.Button8.Text = "Add"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.Button7.Location = New System.Drawing.Point(227, 297)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(60, 22)
        Me.Button7.TabIndex = 22
        Me.Button7.Text = "Submit"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'TextBox_Acc_list
        '
        Me.TextBox_Acc_list.Location = New System.Drawing.Point(194, 202)
        Me.TextBox_Acc_list.Multiline = True
        Me.TextBox_Acc_list.Name = "TextBox_Acc_list"
        Me.TextBox_Acc_list.Size = New System.Drawing.Size(121, 83)
        Me.TextBox_Acc_list.TabIndex = 5
        '
        'TextBox_Signature
        '
        Me.TextBox_Signature.Location = New System.Drawing.Point(64, 299)
        Me.TextBox_Signature.Name = "TextBox_Signature"
        Me.TextBox_Signature.Size = New System.Drawing.Size(157, 20)
        Me.TextBox_Signature.TabIndex = 21
        '
        'ComboBox_Acc
        '
        Me.ComboBox_Acc.AutoCompleteCustomSource.AddRange(New String() {"AC Adapter", "LAN Adapter", "HDMI to VGA", "Other"})
        Me.ComboBox_Acc.FormattingEnabled = True
        Me.ComboBox_Acc.Items.AddRange(New Object() {"Apple - AC Adapter", "Lenovo - AC Adapter", "LAN Adapter (USB A)", "LAN Adapter (USB C)", "OTHER -"})
        Me.ComboBox_Acc.Location = New System.Drawing.Point(194, 175)
        Me.ComboBox_Acc.Name = "ComboBox_Acc"
        Me.ComboBox_Acc.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox_Acc.TabIndex = 23
        '
        'TextBox_Memo
        '
        Me.TextBox_Memo.Location = New System.Drawing.Point(261, 43)
        Me.TextBox_Memo.Multiline = True
        Me.TextBox_Memo.Name = "TextBox_Memo"
        Me.TextBox_Memo.Size = New System.Drawing.Size(100, 87)
        Me.TextBox_Memo.TabIndex = 20
        '
        'TextBox_Case
        '
        Me.TextBox_Case.Location = New System.Drawing.Point(194, 146)
        Me.TextBox_Case.Name = "TextBox_Case"
        Me.TextBox_Case.Size = New System.Drawing.Size(121, 20)
        Me.TextBox_Case.TabIndex = 19
        '
        'TextBox_SN
        '
        Me.TextBox_SN.Location = New System.Drawing.Point(30, 175)
        Me.TextBox_SN.Multiline = True
        Me.TextBox_SN.Name = "TextBox_SN"
        Me.TextBox_SN.Size = New System.Drawing.Size(100, 110)
        Me.TextBox_SN.TabIndex = 18
        '
        'TextBox_PIC
        '
        Me.TextBox_PIC.Location = New System.Drawing.Point(30, 146)
        Me.TextBox_PIC.Name = "TextBox_PIC"
        Me.TextBox_PIC.Size = New System.Drawing.Size(100, 20)
        Me.TextBox_PIC.TabIndex = 17
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
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(170, 89)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 41)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Other"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(89, 89)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 41)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "Repair Return"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(8, 89)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 41)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "From Warehouse"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(170, 43)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 41)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Loan PC Return"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(89, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 41)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Termination"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 42)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 41)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Refresh PC (EOL)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(56, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "[OUT]"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(8, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(42, 17)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "[IN]"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(753, 400)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "DB Admin"
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.Control
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(753, 400)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "AUDIT"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "NekoStash Inventory Manager"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button7 As Button
    Friend WithEvents TextBox_Signature As TextBox
    Friend WithEvents TextBox_Memo As TextBox
    Friend WithEvents TextBox_Case As TextBox
    Friend WithEvents TextBox_SN As TextBox
    Friend WithEvents TextBox_PIC As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ComboBox_Acc As ComboBox
    Friend WithEvents HelpProvider1 As HelpProvider
    Friend WithEvents Label7 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents TextBox_Acc_list As TextBox
    Friend WithEvents Button9 As Button
End Class
