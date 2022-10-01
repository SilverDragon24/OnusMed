<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockReport
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radioGD = New System.Windows.Forms.RadioButton()
        Me.radioSTO = New System.Windows.Forms.RadioButton()
        Me.radioBoth = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radioItem = New System.Windows.Forms.RadioButton()
        Me.radioBatch = New System.Windows.Forms.RadioButton()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radioGD)
        Me.GroupBox1.Controls.Add(Me.radioSTO)
        Me.GroupBox1.Controls.Add(Me.radioBoth)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(242, 34)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'radioGD
        '
        Me.radioGD.AutoSize = True
        Me.radioGD.Location = New System.Drawing.Point(12, 12)
        Me.radioGD.Name = "radioGD"
        Me.radioGD.Size = New System.Drawing.Size(67, 17)
        Me.radioGD.TabIndex = 0
        Me.radioGD.TabStop = True
        Me.radioGD.Text = "From GD"
        Me.radioGD.UseVisualStyleBackColor = True
        '
        'radioSTO
        '
        Me.radioSTO.AutoSize = True
        Me.radioSTO.Location = New System.Drawing.Point(85, 12)
        Me.radioSTO.Name = "radioSTO"
        Me.radioSTO.Size = New System.Drawing.Size(73, 17)
        Me.radioSTO.TabIndex = 1
        Me.radioSTO.TabStop = True
        Me.radioSTO.Text = "From STO"
        Me.radioSTO.UseVisualStyleBackColor = True
        '
        'radioBoth
        '
        Me.radioBoth.AutoSize = True
        Me.radioBoth.Location = New System.Drawing.Point(164, 12)
        Me.radioBoth.Name = "radioBoth"
        Me.radioBoth.Size = New System.Drawing.Size(73, 17)
        Me.radioBoth.TabIndex = 2
        Me.radioBoth.TabStop = True
        Me.radioBoth.Text = "From Both"
        Me.radioBoth.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radioItem)
        Me.GroupBox2.Controls.Add(Me.radioBatch)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(242, 42)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'radioItem
        '
        Me.radioItem.AutoSize = True
        Me.radioItem.Location = New System.Drawing.Point(12, 16)
        Me.radioItem.Name = "radioItem"
        Me.radioItem.Size = New System.Drawing.Size(60, 17)
        Me.radioItem.TabIndex = 0
        Me.radioItem.TabStop = True
        Me.radioItem.Text = "By Item"
        Me.radioItem.UseVisualStyleBackColor = True
        '
        'radioBatch
        '
        Me.radioBatch.AutoSize = True
        Me.radioBatch.Location = New System.Drawing.Point(78, 16)
        Me.radioBatch.Name = "radioBatch"
        Me.radioBatch.Size = New System.Drawing.Size(68, 17)
        Me.radioBatch.TabIndex = 1
        Me.radioBatch.TabStop = True
        Me.radioBatch.Text = "By Batch"
        Me.radioBatch.UseVisualStyleBackColor = True
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(69, 82)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 23)
        Me.btnReport.TabIndex = 2
        Me.btnReport.Text = "Get Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'StockReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(242, 110)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StockReport"
        Me.Text = "StockReport"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radioGD As RadioButton
    Friend WithEvents radioSTO As RadioButton
    Friend WithEvents radioBoth As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radioItem As RadioButton
    Friend WithEvents radioBatch As RadioButton
    Friend WithEvents btnReport As Button
End Class
