<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Others
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtboxOthers = New System.Windows.Forms.TextBox()
        Me.btnOthersDes = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please specify description for 'other' "
        '
        'txtboxOthers
        '
        Me.txtboxOthers.Location = New System.Drawing.Point(15, 25)
        Me.txtboxOthers.Name = "txtboxOthers"
        Me.txtboxOthers.Size = New System.Drawing.Size(180, 20)
        Me.txtboxOthers.TabIndex = 1
        '
        'btnOthersDes
        '
        Me.btnOthersDes.Location = New System.Drawing.Point(202, 21)
        Me.btnOthersDes.Name = "btnOthersDes"
        Me.btnOthersDes.Size = New System.Drawing.Size(75, 23)
        Me.btnOthersDes.TabIndex = 2
        Me.btnOthersDes.Text = "Submit"
        Me.btnOthersDes.UseVisualStyleBackColor = True
        '
        'Form_Others
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 75)
        Me.Controls.Add(Me.btnOthersDes)
        Me.Controls.Add(Me.txtboxOthers)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form_Others"
        Me.Text = "Input Description"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtboxOthers As TextBox
    Friend WithEvents btnOthersDes As Button
End Class
