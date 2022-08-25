<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseReport
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
        Me.radioSupplier = New System.Windows.Forms.RadioButton()
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
        'radioSupplier
        '
        Me.radioSupplier.AutoSize = True
        Me.radioSupplier.Location = New System.Drawing.Point(150, 12)
        Me.radioSupplier.Name = "radioSupplier"
        Me.radioSupplier.Size = New System.Drawing.Size(77, 17)
        Me.radioSupplier.TabIndex = 2
        Me.radioSupplier.TabStop = True
        Me.radioSupplier.Text = "by Supplier"
        Me.radioSupplier.UseVisualStyleBackColor = True
        '
        'dateFrom
        '
        Me.dateFrom.Location = New System.Drawing.Point(58, 62)
        Me.dateFrom.Name = "dateFrom"
        Me.dateFrom.Size = New System.Drawing.Size(169, 20)
        Me.dateFrom.TabIndex = 3
        '
        'dateTo
        '
        Me.dateTo.Location = New System.Drawing.Point(58, 88)
        Me.dateTo.Name = "dateTo"
        Me.dateTo.Size = New System.Drawing.Size(169, 20)
        Me.dateTo.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "From:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "To:"
        '
        'btnRequest
        '
        Me.btnRequest.Location = New System.Drawing.Point(12, 114)
        Me.btnRequest.Name = "btnRequest"
        Me.btnRequest.Size = New System.Drawing.Size(105, 23)
        Me.btnRequest.TabIndex = 7
        Me.btnRequest.Text = "Request Report"
        Me.btnRequest.UseVisualStyleBackColor = True
        '
        'btnToday
        '
        Me.btnToday.Location = New System.Drawing.Point(123, 114)
        Me.btnToday.Name = "btnToday"
        Me.btnToday.Size = New System.Drawing.Size(104, 23)
        Me.btnToday.TabIndex = 8
        Me.btnToday.Text = "Today's Report"
        Me.btnToday.UseVisualStyleBackColor = True
        '
        'chkSubtract
        '
        Me.chkSubtract.AutoSize = True
        Me.chkSubtract.Location = New System.Drawing.Point(12, 35)
        Me.chkSubtract.Name = "chkSubtract"
        Me.chkSubtract.Size = New System.Drawing.Size(106, 17)
        Me.chkSubtract.TabIndex = 9
        Me.chkSubtract.Text = "Subtract Returns"
        Me.chkSubtract.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'PurchaseReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 143)
        Me.Controls.Add(Me.chkSubtract)
        Me.Controls.Add(Me.btnToday)
        Me.Controls.Add(Me.btnRequest)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dateTo)
        Me.Controls.Add(Me.dateFrom)
        Me.Controls.Add(Me.radioSupplier)
        Me.Controls.Add(Me.radioBatch)
        Me.Controls.Add(Me.radioItem)
        Me.Name = "PurchaseReport"
        Me.Text = "PurchaseReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radioItem As RadioButton
    Friend WithEvents radioBatch As RadioButton
    Friend WithEvents radioSupplier As RadioButton
    Friend WithEvents dateFrom As DateTimePicker
    Friend WithEvents dateTo As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRequest As Button
    Friend WithEvents btnToday As Button
    Friend WithEvents chkSubtract As CheckBox
    Friend WithEvents Timer1 As Timer
End Class
