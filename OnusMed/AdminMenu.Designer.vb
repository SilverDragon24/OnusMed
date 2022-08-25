<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMenu
    Inherits System.Windows.Forms.Form

    'Form overrides to clean up the component list.
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
        Me.btnEmpMgr = New System.Windows.Forms.Button()
        Me.btnConfig = New System.Windows.Forms.Button()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnEmpMgr
        '
        Me.btnEmpMgr.Location = New System.Drawing.Point(12, 12)
        Me.btnEmpMgr.Name = "btnEmpMgr"
        Me.btnEmpMgr.Size = New System.Drawing.Size(128, 23)
        Me.btnEmpMgr.TabIndex = 0
        Me.btnEmpMgr.Text = "Employee Manager"
        Me.btnEmpMgr.UseVisualStyleBackColor = True
        '
        'btnConfig
        '
        Me.btnConfig.Location = New System.Drawing.Point(146, 12)
        Me.btnConfig.Name = "btnConfig"
        Me.btnConfig.Size = New System.Drawing.Size(100, 23)
        Me.btnConfig.TabIndex = 1
        Me.btnConfig.Text = "Config Generator"
        Me.btnConfig.UseVisualStyleBackColor = True
        '
        'btnEmail
        '
        Me.btnEmail.Location = New System.Drawing.Point(252, 12)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(100, 23)
        Me.btnEmail.TabIndex = 2
        Me.btnEmail.Text = "Email Config"
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(358, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "On-Call Doctor Management"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AdminMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEmail)
        Me.Controls.Add(Me.btnConfig)
        Me.Controls.Add(Me.btnEmpMgr)
        Me.Name = "AdminMenu"
        Me.Text = "AdminMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnEmpMgr As Button
    Friend WithEvents btnConfig As Button
    Friend WithEvents btnEmail As Button
    Friend WithEvents Button1 As Button
End Class
