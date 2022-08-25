<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesReport
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
        Me.radioItem = New System.Windows.Forms.RadioButton()
        Me.radioBatch = New System.Windows.Forms.RadioButton()
        Me.radioDoctor = New System.Windows.Forms.RadioButton()
        Me.radioPatient = New System.Windows.Forms.RadioButton()
        Me.dateFrom = New System.Windows.Forms.DateTimePicker()
        Me.dateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRequest = New System.Windows.Forms.Button()
        Me.btnToday = New System.Windows.Forms.Button()
        Me.chkSubtract = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'radioItem
        '
        Me.radioItem.AutoSize = True
        Me.radioItem.Location = New System.Drawing.Point(12, 12)
        Me.radioItem.Name = "radioItem"
        Me.radioItem.Size = New System.Drawing.Size(59, 17)
        Me.radioItem.TabIndex = 0
        Me.radioItem.TabStop = True
        Me.radioItem.Text = "by Item"
        Me.radioItem.UseVisualStyleBackColor = True
        '
        'radioBatch
        '
        Me.radioBatch.AutoSize = True
        Me.radioBatch.Location = New System.Drawing.Point(77, 12)
        Me.radioBatch.Name = "radioBatch"
        Me.radioBatch.Size = New System.Drawing.Size(67, 17)
        Me.radioBatch.TabIndex = 1
        Me.radioBatch.TabStop = True
        Me.radioBatch.Text = "by Batch"
        Me.radioBatch.UseVisualStyleBackColor = True
        '
        'radioDoctor
        '
        Me.radioDoctor.AutoSize = True
        Me.radioDoctor.Location = New System.Drawing.Point(150, 12)
        Me.radioDoctor.Name = "radioDoctor"
        Me.radioDoctor.Size = New System.Drawing.Size(71, 17)
        Me.radioDoctor.TabIndex = 2
        Me.radioDoctor.TabStop = True
        Me.radioDoctor.Text = "by Doctor"
        Me.radioDoctor.UseVisualStyleBackColor = True
        '
        'radioPatient
        '
        Me.radioPatient.AutoSize = True
        Me.radioPatient.Location = New System.Drawing.Point(227, 12)
        Me.radioPatient.Name = "radioPatient"
        Me.radioPatient.Size = New System.Drawing.Size(72, 17)
        Me.radioPatient.TabIndex = 3
        Me.radioPatient.TabStop = True
        Me.radioPatient.Text = "by Patient"
        Me.radioPatient.UseVisualStyleBackColor = True
        '
        'dateFrom
        '
        Me.dateFrom.Location = New System.Drawing.Point(45, 58)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(251, 20)
        Me.dateFrom.TabIndex = 4
        '
        'dateTo
        '
        Me.dateTo.Location = New System.Drawing.Point(45, 84)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(251, 20)
        Me.dateTo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "To:"
        '
        'btnRequest
        '
        Me.btnRequest.Location = New System.Drawing.Point(90, 110)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(98, 23)
        Me.btnRequest.TabIndex = 8
        Me.btnRequest.Text = "Request Report"
        Me.btnRequest.UseVisualStyleBackColor = True
        '
        'btnToday
        '
        Me.btnToday.Location = New System.Drawing.Point(194, 110)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(102, 23)
        Me.btnToday.TabIndex = 9
        Me.btnToday.Text = "Today's Report"
        Me.btnToday.UseVisualStyleBackColor = True
        '
        'chkSubtract
        '
        Me.chkSubtract.AutoSize = True
        Me.chkSubtract.Location = New System.Drawing.Point(12, 35)
        Me.chkSubtract.Name = "chkSubtract"
        Me.chkSubtract.Size = New System.Drawing.Size(106, 17)
        Me.chkSubtract.TabIndex = 10
        Me.chkSubtract.Text = "Subtract Returns"
        Me.chkSubtract.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'SalesReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(302, 138)
        Me.Controls.Add(Me.chkSubtract)
        Me.Controls.Add(Me.btnToday)
        Me.Controls.Add(Me.btnRequest)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dateTo)
        Me.Controls.Add(Me.dateFrom)
        Me.Controls.Add(Me.radioPatient)
        Me.Controls.Add(Me.radioDoctor)
        Me.Controls.Add(Me.radioBatch)
        Me.Controls.Add(Me.radioItem)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SalesReport"
        Me.Text = "SalesReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radioItem As RadioButton
    Friend WithEvents radioBatch As RadioButton
    Friend WithEvents radioDoctor As RadioButton
    Friend WithEvents radioPatient As RadioButton
    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRequest As Button
    Friend WithEvents btnToday As Button
    Friend WithEvents chkSubtract As CheckBox
    Friend WithEvents Timer1 As Timer
End Class
