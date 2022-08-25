<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockTransfer
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.txtItemName = New System.Windows.Forms.TextBox()
        Me.txtBatchCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnToGD = New System.Windows.Forms.Button()
        Me.btnToSTO = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbItem = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnFind = New System.Windows.Forms.Button()
        Me.numQtyPack = New System.Windows.Forms.NumericUpDown()
        Me.numQtyStrip = New System.Windows.Forms.NumericUpDown()
        Me.numQtyPiece = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQtyPack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQtyStrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQtyPiece, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(0, 198)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(949, 303)
        Me.DataGridView1.TabIndex = 0
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(694, 12)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(147, 20)
        Me.txtItemCode.TabIndex = 1
        '
        'txtItemName
        '
        Me.txtItemName.Location = New System.Drawing.Point(694, 38)
        Me.txtItemName.Name = "txtItemName"
        Me.txtItemName.Size = New System.Drawing.Size(147, 20)
        Me.txtItemName.TabIndex = 2
        '
        'txtBatchCode
        '
        Me.txtBatchCode.Location = New System.Drawing.Point(694, 64)
        Me.txtBatchCode.Name = "txtBatchCode"
        Me.txtBatchCode.Size = New System.Drawing.Size(147, 20)
        Me.txtBatchCode.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(622, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Item Code:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(622, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Item Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(622, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Batch Code:"
        '
        'btnToGD
        '
        Me.btnToGD.Location = New System.Drawing.Point(694, 129)
        Me.btnToGD.Name = "btnToGD"
        Me.btnToGD.Size = New System.Drawing.Size(74, 23)
        Me.btnToGD.TabIndex = 7
        Me.btnToGD.Text = "To Godown"
        Me.btnToGD.UseVisualStyleBackColor = True
        '
        'btnToSTO
        '
        Me.btnToSTO.Location = New System.Drawing.Point(774, 129)
        Me.btnToSTO.Name = "btnToSTO"
        Me.btnToSTO.Size = New System.Drawing.Size(61, 23)
        Me.btnToSTO.TabIndex = 8
        Me.btnToSTO.Text = "To Store"
        Me.btnToSTO.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.OnusMed.My.Resources.Resources.blinkist_ios_icon_b
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(210, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'cmbItem
        '
        Me.cmbItem.FormattingEnabled = True
        Me.cmbItem.Location = New System.Drawing.Point(257, 12)
        Me.cmbItem.Name = "cmbItem"
        Me.cmbItem.Size = New System.Drawing.Size(238, 21)
        Me.cmbItem.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Item:"
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(420, 39)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 12
        Me.btnFind.Text = "Find"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'numQtyPack
        '
        Me.numQtyPack.DecimalPlaces = 2
        Me.numQtyPack.Location = New System.Drawing.Point(694, 90)
        Me.numQtyPack.Maximum = New Decimal(New Integer() {1408191236, 42, 0, 0})
        Me.numQtyPack.Name = "numQtyPack"
        Me.numQtyPack.Size = New System.Drawing.Size(45, 20)
        Me.numQtyPack.TabIndex = 13
        '
        'numQtyStrip
        '
        Me.numQtyStrip.DecimalPlaces = 2
        Me.numQtyStrip.Location = New System.Drawing.Point(745, 90)
        Me.numQtyStrip.Maximum = New Decimal(New Integer() {-1750529015, 228, 0, 0})
        Me.numQtyStrip.Name = "numQtyStrip"
        Me.numQtyStrip.Size = New System.Drawing.Size(45, 20)
        Me.numQtyStrip.TabIndex = 14
        '
        'numQtyPiece
        '
        Me.numQtyPiece.Location = New System.Drawing.Point(796, 90)
        Me.numQtyPiece.Maximum = New Decimal(New Integer() {517107792, 4, 0, 0})
        Me.numQtyPiece.Name = "numQtyPiece"
        Me.numQtyPiece.Size = New System.Drawing.Size(45, 20)
        Me.numQtyPiece.TabIndex = 15
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(691, 113)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Packs"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(742, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Strips"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(793, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Pieces"
        '
        'StockTransfer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 501)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.numQtyPiece)
        Me.Controls.Add(Me.numQtyStrip)
        Me.Controls.Add(Me.numQtyPack)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbItem)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnToSTO)
        Me.Controls.Add(Me.btnToGD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBatchCode)
        Me.Controls.Add(Me.txtItemName)
        Me.Controls.Add(Me.txtItemCode)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StockTransfer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StockTransfer"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQtyPack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQtyStrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQtyPiece, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents txtItemName As TextBox
    Friend WithEvents txtBatchCode As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnToGD As Button
    Friend WithEvents btnToSTO As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmbItem As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnFind As Button
    Friend WithEvents numQtyPack As NumericUpDown
    Friend WithEvents numQtyStrip As NumericUpDown
    Friend WithEvents numQtyPiece As NumericUpDown
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Timer1 As Timer
End Class
