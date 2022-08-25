<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SchedPurFilter
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbSched = New System.Windows.Forms.ComboBox()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmbSched
        '
        Me.cmbSched.FormattingEnabled = True
        Me.cmbSched.Location = New System.Drawing.Point(66, 6)
        Me.cmbSched.Name = "cmbSched"
        Me.cmbSched.Size = New System.Drawing.Size(121, 21)
        Me.cmbSched.TabIndex = 7
        '
        'dateFrom
        '
        Me.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateFrom.Location = New System.Drawing.Point(66, 33)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(121, 20)
        Me.dateFrom.TabIndex = 8
        '
        'dateTo
        '
        Me.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dateTo.Location = New System.Drawing.Point(66, 59)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(121, 20)
        Me.dateTo.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Schedule:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "From:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "To:"
        '
        'btnReport
        '
        Me.btnReport.Location = New System.Drawing.Point(66, 85)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(75, 23)
        Me.btnReport.TabIndex = 13
        Me.btnReport.Text = "Get Report"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'SchedPurFilter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(193, 115)
        Me.Controls.Add(Me.btnReport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dateTo)
        Me.Controls.Add(Me.dateFrom)
        Me.Controls.Add(Me.cmbSched)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SchedPurFilter"
        Me.Text = "SchedPurFilter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents cmbSched As ComboBox
    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnReport As Button
End Class
