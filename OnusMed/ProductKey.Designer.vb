<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductKey
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
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.txtProductKey = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnActivate = New System.Windows.Forms.Button()
        Me.lblBypass = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(86, 17)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(300, 20)
        Me.txtCustID.TabIndex = 0
        '
        'txtProductKey
        '
        Me.txtProductKey.Location = New System.Drawing.Point(86, 43)
        Me.txtProductKey.Name = "txtProductKey"
        Me.txtProductKey.Size = New System.Drawing.Size(300, 20)
        Me.txtProductKey.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Customer ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Product Key:"
        '
        'btnActivate
        '
        Me.btnActivate.Location = New System.Drawing.Point(86, 69)
        Me.btnActivate.Name = "btnActivate"
        Me.btnActivate.Size = New System.Drawing.Size(75, 23)
        Me.btnActivate.TabIndex = 4
        Me.btnActivate.Text = "Activate"
        Me.btnActivate.UseVisualStyleBackColor = True
        '
        'lblBypass
        '
        Me.lblBypass.AutoSize = True
        Me.lblBypass.Location = New System.Drawing.Point(372, 79)
        Me.lblBypass.Name = "lblBypass"
        Me.lblBypass.Size = New System.Drawing.Size(13, 13)
        Me.lblBypass.TabIndex = 5
        Me.lblBypass.Text = "π"
        '
        'ProductKey
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 94)
        Me.Controls.Add(Me.lblBypass)
        Me.Controls.Add(Me.btnActivate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtProductKey)
        Me.Controls.Add(Me.txtCustID)
        Me.Name = "ProductKey"
        Me.Text = "ProductKey"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtCustID As TextBox
    Friend WithEvents txtProductKey As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnActivate As Button
    Friend WithEvents lblBypass As Label
End Class
