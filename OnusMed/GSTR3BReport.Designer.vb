<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GSTR3BReport
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radioQ1 = New System.Windows.Forms.RadioButton()
        Me.radioQ2 = New System.Windows.Forms.RadioButton()
        Me.radioQ3 = New System.Windows.Forms.RadioButton()
        Me.radioQ4 = New System.Windows.Forms.RadioButton()
        Me.btnQReport = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.btnCustomReport = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnCustomReport)
        Me.GroupBox1.Controls.Add(Me.dateTo)
        Me.GroupBox1.Controls.Add(Me.dateFrom)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(205, 110)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Custom Report"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnQReport)
        Me.GroupBox2.Controls.Add(Me.radioQ4)
        Me.GroupBox2.Controls.Add(Me.radioQ3)
        Me.GroupBox2.Controls.Add(Me.radioQ2)
        Me.GroupBox2.Controls.Add(Me.radioQ1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Location = New System.Drawing.Point(0, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(205, 74)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Reports by Quarter"
        '
        'radioQ1
        '
        Me.radioQ1.AutoSize = True
        Me.radioQ1.Location = New System.Drawing.Point(18, 19)
        Me.radioQ1.Name = "radioQ1"
        Me.radioQ1.Size = New System.Drawing.Size(39, 17)
        Me.radioQ1.TabIndex = 0
        Me.radioQ1.TabStop = True
        Me.radioQ1.Text = "Q1"
        Me.radioQ1.UseVisualStyleBackColor = True
        '
        'radioQ2
        '
        Me.radioQ2.AutoSize = True
        Me.radioQ2.Location = New System.Drawing.Point(63, 19)
        Me.radioQ2.Name = "radioQ2"
        Me.radioQ2.Size = New System.Drawing.Size(39, 17)
        Me.radioQ2.TabIndex = 1
        Me.radioQ2.TabStop = True
        Me.radioQ2.Text = "Q2"
        Me.radioQ2.UseVisualStyleBackColor = True
        '
        'radioQ3
        '
        Me.radioQ3.AutoSize = True
        Me.radioQ3.Location = New System.Drawing.Point(108, 19)
        Me.radioQ3.Name = "radioQ3"
        Me.radioQ3.Size = New System.Drawing.Size(39, 17)
        Me.radioQ3.TabIndex = 2
        Me.radioQ3.TabStop = True
        Me.radioQ3.Text = "Q3"
        Me.radioQ3.UseVisualStyleBackColor = True
        '
        'radioQ4
        '
        Me.radioQ4.AutoSize = True
        Me.radioQ4.Location = New System.Drawing.Point(153, 19)
        Me.radioQ4.Name = "radioQ4"
        Me.radioQ4.Size = New System.Drawing.Size(39, 17)
        Me.radioQ4.TabIndex = 3
        Me.radioQ4.TabStop = True
        Me.radioQ4.Text = "Q4"
        Me.radioQ4.UseVisualStyleBackColor = True
        '
        'btnQReport
        '
        Me.btnQReport.Location = New System.Drawing.Point(54, 42)
        Me.btnQReport.Name = "btnQReport"
        Me.btnQReport.Size = New System.Drawing.Size(75, 23)
        Me.btnQReport.TabIndex = 4
        Me.btnQReport.Text = "Get Report"
        Me.btnQReport.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'dateFrom
        '
        Me.dateFrom.CustomFormat = "yyyy-MM-dd"
        Me.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateFrom.Location = New System.Drawing.Point(54, 19)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(106, 20)
        Me.dateFrom.TabIndex = 0
        '
        'dateTo
        '
        Me.dateTo.CustomFormat = "yyyy-MM-dd"
        Me.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateTo.Location = New System.Drawing.Point(54, 45)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(106, 20)
        Me.dateTo.TabIndex = 1
        '
        'btnCustomReport
        '
        Me.btnCustomReport.AutoSize = True
        Me.btnCustomReport.Location = New System.Drawing.Point(54, 71)
        Me.btnCustomReport.Name = "btnCustomReport"
        Me.btnCustomReport.Size = New System.Drawing.Size(75, 23)
        Me.btnCustomReport.TabIndex = 4
        Me.btnCustomReport.Text = "Get Report"
        Me.btnCustomReport.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "To:"
        '
        'GSTR3BReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 187)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "GSTR3BReport"
        Me.Text = "GSTR3BReport"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCustomReport As Button
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents btnQReport As Button
    Friend WithEvents radioQ4 As RadioButton
    Friend WithEvents radioQ3 As RadioButton
    Friend WithEvents radioQ2 As RadioButton
    Friend WithEvents radioQ1 As RadioButton
    Friend WithEvents Timer1 As Timer
End Class
