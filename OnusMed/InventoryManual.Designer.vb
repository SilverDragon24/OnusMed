<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryManual
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
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.grpSupplier = New System.Windows.Forms.GroupBox()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvList
        '
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvList.Location = New System.Drawing.Point(0, 225)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.Size = New System.Drawing.Size(1248, 417)
        Me.dgvList.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.OnusMed.My.Resources.Resources.blinkist_ios_icon_b
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(225, 225)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'grpSupplier
        '
        Me.grpSupplier.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpSupplier.Location = New System.Drawing.Point(225, 0)
        Me.grpSupplier.Name = "grpSupplier"
        Me.grpSupplier.Size = New System.Drawing.Size(211, 225)
        Me.grpSupplier.TabIndex = 2
        Me.grpSupplier.TabStop = False
        Me.grpSupplier.Text = "GroupBox1"
        '
        'InventoryManual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1248, 642)
        Me.Controls.Add(Me.grpSupplier)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvList)
        Me.Name = "InventoryManual"
        Me.Text = "InventoryManual"
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvList As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents grpSupplier As GroupBox
End Class
