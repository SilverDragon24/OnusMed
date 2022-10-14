<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReprintInvoice
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
        Me.grpSearch = New System.Windows.Forms.GroupBox()
        Me.grpInvoice = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpSearch
        '
        Me.grpSearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpSearch.Location = New System.Drawing.Point(0, 0)
        Me.grpSearch.Name = "grpSearch"
        Me.grpSearch.Size = New System.Drawing.Size(1264, 100)
        Me.grpSearch.TabIndex = 0
        Me.grpSearch.TabStop = False
        Me.grpSearch.Text = "Search"
        '
        'grpInvoice
        '
        Me.grpInvoice.Dock = System.Windows.Forms.DockStyle.Top
        Me.grpInvoice.Location = New System.Drawing.Point(0, 100)
        Me.grpInvoice.Name = "grpInvoice"
        Me.grpInvoice.Size = New System.Drawing.Size(1264, 100)
        Me.grpInvoice.TabIndex = 1
        Me.grpInvoice.TabStop = False
        Me.grpInvoice.Text = "Invoice"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 200)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1264, 481)
        Me.DataGridView1.TabIndex = 2
        '
        'ReprintInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.grpInvoice)
        Me.Controls.Add(Me.grpSearch)
        Me.Name = "ReprintInvoice"
        Me.Text = "ReprintInvoice"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grpSearch As GroupBox
    Friend WithEvents grpInvoice As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
