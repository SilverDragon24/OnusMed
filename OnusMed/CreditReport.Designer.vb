<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditReport
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
        Me.radioSupplier = New System.Windows.Forms.RadioButton()
        Me.radioPatient = New System.Windows.Forms.RadioButton()
        Me.btnGetReport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'radioSupplier
        '
        Me.radioSupplier.AutoSize = True
        Me.radioSupplier.Location = New System.Drawing.Point(12, 12)
        Me.radioSupplier.Name = "radioSupplier"
        Me.radioSupplier.Size = New System.Drawing.Size(63, 17)
        Me.radioSupplier.TabIndex = 0
        Me.radioSupplier.TabStop = True
        Me.radioSupplier.Text = "Supplier"
        Me.radioSupplier.UseVisualStyleBackColor = True
        '
        'radioPatient
        '
        Me.radioPatient.AutoSize = True
        Me.radioPatient.Location = New System.Drawing.Point(81, 12)
        Me.radioPatient.Name = "radioPatient"
        Me.radioPatient.Size = New System.Drawing.Size(58, 17)
        Me.radioPatient.TabIndex = 1
        Me.radioPatient.TabStop = True
        Me.radioPatient.Text = "Patient"
        Me.radioPatient.UseVisualStyleBackColor = True
        '
        'btnGetReport
        '
        Me.btnGetReport.Location = New System.Drawing.Point(12, 35)
        Me.btnGetReport.Name = "btnGetReport"
        Me.btnGetReport.Size = New System.Drawing.Size(75, 23)
        Me.btnGetReport.TabIndex = 2
        Me.btnGetReport.Text = "Get Report"
        Me.btnGetReport.UseVisualStyleBackColor = True
        '
        'CreditReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(146, 66)
        Me.Controls.Add(Me.btnGetReport)
        Me.Controls.Add(Me.radioPatient)
        Me.Controls.Add(Me.radioSupplier)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreditReport"
        Me.Text = "CreditReport"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents radioSupplier As RadioButton
    Friend WithEvents radioPatient As RadioButton
    Friend WithEvents btnGetReport As Button
End Class
