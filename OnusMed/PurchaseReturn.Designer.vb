<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseReturn
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
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.numFreePiece = New System.Windows.Forms.NumericUpDown()
        Me.numFreeStrip = New System.Windows.Forms.NumericUpDown()
        Me.numFreePack = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dateInvoice = New System.Windows.Forms.DateTimePicker()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblStockPack = New System.Windows.Forms.Label()
        Me.lblStockStrip = New System.Windows.Forms.Label()
        Me.lblStockPiece = New System.Windows.Forms.Label()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.numQtyPiece = New System.Windows.Forms.NumericUpDown()
        Me.numQtyStrip = New System.Windows.Forms.NumericUpDown()
        Me.numQtyPack = New System.Windows.Forms.NumericUpDown()
        Me.cmbItemCode = New System.Windows.Forms.ComboBox()
        Me.cmbItemName = New System.Windows.Forms.ComboBox()
        Me.txtItemBatch = New System.Windows.Forms.TextBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbSuppName = New System.Windows.Forms.ComboBox()
        Me.cmbSuppId = New System.Windows.Forms.ComboBox()
        Me.txtSuppNo = New System.Windows.Forms.TextBox()
        Me.grpFind = New System.Windows.Forms.GroupBox()
        Me.radioInvoice = New System.Windows.Forms.RadioButton()
        Me.radioSupplier = New System.Windows.Forms.RadioButton()
        Me.radioBatch = New System.Windows.Forms.RadioButton()
        Me.btnFInd = New System.Windows.Forms.Button()
        Me.cmbInvoice = New System.Windows.Forms.ComboBox()
        Me.cmbSupplier = New System.Windows.Forms.ComboBox()
        Me.cmbBatchCode = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.numCredit = New System.Windows.Forms.NumericUpDown()
        Me.numBank = New System.Windows.Forms.NumericUpDown()
        Me.radioDD = New System.Windows.Forms.RadioButton()
        Me.radioCHQ = New System.Windows.Forms.RadioButton()
        Me.radioNA = New System.Windows.Forms.RadioButton()
        Me.numCash = New System.Windows.Forms.NumericUpDown()
        Me.numCard = New System.Windows.Forms.NumericUpDown()
        Me.txtInstruNo = New System.Windows.Forms.TextBox()
        Me.cmbCardType = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.numNet = New System.Windows.Forms.NumericUpDown()
        Me.numDiscount = New System.Windows.Forms.NumericUpDown()
        Me.numGross = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.dgvList = New System.Windows.Forms.DataGridView()
        Me.invoice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.icode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.batchcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.supplierID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.packQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stripQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pieceQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.freePack = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.freeStrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.freePiece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.prPack = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stripPR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.piecePR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cgst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sgst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.igst = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ed = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvSearch = New System.Windows.Forms.DataGridView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.numFreePiece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFreeStrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFreePack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        CType(Me.numQtyPiece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQtyStrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQtyPack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.grpFind.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numGross, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.numFreePiece)
        Me.GroupBox1.Controls.Add(Me.numFreeStrip)
        Me.GroupBox1.Controls.Add(Me.numFreePack)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.dateInvoice)
        Me.GroupBox1.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.grpFind)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1264, 207)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(1183, 110)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 13)
        Me.Label19.TabIndex = 17
        Me.Label19.Text = "Pieces"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(1113, 110)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(33, 13)
        Me.Label18.TabIndex = 16
        Me.Label18.Text = "Strips"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(1047, 110)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 13)
        Me.Label17.TabIndex = 15
        Me.Label17.Text = "Packs"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(982, 89)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 14
        Me.Label16.Text = "Free:"
        '
        'numFreePiece
        '
        Me.numFreePiece.Location = New System.Drawing.Point(1186, 87)
        Me.numFreePiece.Maximum = New Decimal(New Integer() {563848092, 3904, 0, 0})
        Me.numFreePiece.Name = "numFreePiece"
        Me.numFreePiece.Size = New System.Drawing.Size(64, 20)
        Me.numFreePiece.TabIndex = 13
        '
        'numFreeStrip
        '
        Me.numFreeStrip.DecimalPlaces = 2
        Me.numFreeStrip.Location = New System.Drawing.Point(1116, 87)
        Me.numFreeStrip.Maximum = New Decimal(New Integer() {-2028659564, 3904, 0, 0})
        Me.numFreeStrip.Name = "numFreeStrip"
        Me.numFreeStrip.Size = New System.Drawing.Size(64, 20)
        Me.numFreeStrip.TabIndex = 12
        '
        'numFreePack
        '
        Me.numFreePack.DecimalPlaces = 2
        Me.numFreePack.Location = New System.Drawing.Point(1050, 87)
        Me.numFreePack.Maximum = New Decimal(New Integer() {1139672251, 390, 0, 0})
        Me.numFreePack.Name = "numFreePack"
        Me.numFreePack.Size = New System.Drawing.Size(60, 20)
        Me.numFreePack.TabIndex = 11
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(982, 65)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(33, 13)
        Me.Label15.TabIndex = 10
        Me.Label15.Text = "Date:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(982, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(62, 13)
        Me.Label14.TabIndex = 9
        Me.Label14.Text = "Invoice No:"
        '
        'dateInvoice
        '
        Me.dateInvoice.Location = New System.Drawing.Point(1050, 59)
        Me.dateInvoice.Name = "dateInvoice"
        Me.dateInvoice.Size = New System.Drawing.Size(200, 20)
        Me.dateInvoice.TabIndex = 8
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(1050, 35)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(200, 20)
        Me.txtInvoiceNo.TabIndex = 7
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label1)
        Me.GroupBox6.Controls.Add(Me.lblStockPack)
        Me.GroupBox6.Controls.Add(Me.lblStockStrip)
        Me.GroupBox6.Controls.Add(Me.lblStockPiece)
        Me.GroupBox6.Controls.Add(Me.btnRemove)
        Me.GroupBox6.Controls.Add(Me.btnAdd)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.numQtyPiece)
        Me.GroupBox6.Controls.Add(Me.numQtyStrip)
        Me.GroupBox6.Controls.Add(Me.numQtyPack)
        Me.GroupBox6.Controls.Add(Me.cmbItemCode)
        Me.GroupBox6.Controls.Add(Me.cmbItemName)
        Me.GroupBox6.Controls.Add(Me.txtItemBatch)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox6.Location = New System.Drawing.Point(679, 16)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(287, 188)
        Me.GroupBox6.TabIndex = 3
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Item Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 143)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Available:"
        '
        'lblStockPack
        '
        Me.lblStockPack.AutoSize = True
        Me.lblStockPack.Location = New System.Drawing.Point(80, 143)
        Me.lblStockPack.Name = "lblStockPack"
        Me.lblStockPack.Size = New System.Drawing.Size(0, 13)
        Me.lblStockPack.TabIndex = 17
        '
        'lblStockStrip
        '
        Me.lblStockStrip.AutoSize = True
        Me.lblStockStrip.Location = New System.Drawing.Point(150, 143)
        Me.lblStockStrip.Name = "lblStockStrip"
        Me.lblStockStrip.Size = New System.Drawing.Size(0, 13)
        Me.lblStockStrip.TabIndex = 16
        '
        'lblStockPiece
        '
        Me.lblStockPiece.AutoSize = True
        Me.lblStockPiece.Location = New System.Drawing.Point(213, 143)
        Me.lblStockPiece.Name = "lblStockPiece"
        Me.lblStockPiece.Size = New System.Drawing.Size(0, 13)
        Me.lblStockPiece.TabIndex = 15
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(153, 159)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 14
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(54, 159)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(213, 122)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Pieces"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(150, 123)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Strips"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(80, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Packs"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Quantity:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 76)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Batch Code:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 49)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Item Code:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Item Name:"
        '
        'numQtyPiece
        '
        Me.numQtyPiece.Location = New System.Drawing.Point(216, 99)
        Me.numQtyPiece.Maximum = New Decimal(New Integer() {570426531, 416, 0, 0})
        Me.numQtyPiece.Name = "numQtyPiece"
        Me.numQtyPiece.Size = New System.Drawing.Size(55, 20)
        Me.numQtyPiece.TabIndex = 5
        '
        'numQtyStrip
        '
        Me.numQtyStrip.DecimalPlaces = 2
        Me.numQtyStrip.Location = New System.Drawing.Point(153, 100)
        Me.numQtyStrip.Maximum = New Decimal(New Integer() {393562477, 1672139, 0, 0})
        Me.numQtyStrip.Name = "numQtyStrip"
        Me.numQtyStrip.Size = New System.Drawing.Size(57, 20)
        Me.numQtyStrip.TabIndex = 4
        '
        'numQtyPack
        '
        Me.numQtyPack.DecimalPlaces = 2
        Me.numQtyPack.Location = New System.Drawing.Point(83, 99)
        Me.numQtyPack.Maximum = New Decimal(New Integer() {968177193, 11343, 0, 0})
        Me.numQtyPack.Name = "numQtyPack"
        Me.numQtyPack.Size = New System.Drawing.Size(64, 20)
        Me.numQtyPack.TabIndex = 3
        '
        'cmbItemCode
        '
        Me.cmbItemCode.FormattingEnabled = True
        Me.cmbItemCode.Location = New System.Drawing.Point(83, 46)
        Me.cmbItemCode.Name = "cmbItemCode"
        Me.cmbItemCode.Size = New System.Drawing.Size(188, 21)
        Me.cmbItemCode.TabIndex = 2
        '
        'cmbItemName
        '
        Me.cmbItemName.FormattingEnabled = True
        Me.cmbItemName.Location = New System.Drawing.Point(83, 19)
        Me.cmbItemName.Name = "cmbItemName"
        Me.cmbItemName.Size = New System.Drawing.Size(188, 21)
        Me.cmbItemName.TabIndex = 1
        '
        'txtItemBatch
        '
        Me.txtItemBatch.Location = New System.Drawing.Point(83, 73)
        Me.txtItemBatch.Name = "txtItemBatch"
        Me.txtItemBatch.Size = New System.Drawing.Size(188, 20)
        Me.txtItemBatch.TabIndex = 0
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.cmbSuppName)
        Me.GroupBox5.Controls.Add(Me.cmbSuppId)
        Me.GroupBox5.Controls.Add(Me.txtSuppNo)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox5.Location = New System.Drawing.Point(469, 16)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(210, 188)
        Me.GroupBox5.TabIndex = 2
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Supplier Info"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Phone No:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Supplier ID:"
        '
        'cmbSuppName
        '
        Me.cmbSuppName.FormattingEnabled = True
        Me.cmbSuppName.Location = New System.Drawing.Point(74, 46)
        Me.cmbSuppName.Name = "cmbSuppName"
        Me.cmbSuppName.Size = New System.Drawing.Size(121, 21)
        Me.cmbSuppName.TabIndex = 2
        '
        'cmbSuppId
        '
        Me.cmbSuppId.FormattingEnabled = True
        Me.cmbSuppId.Location = New System.Drawing.Point(74, 19)
        Me.cmbSuppId.Name = "cmbSuppId"
        Me.cmbSuppId.Size = New System.Drawing.Size(121, 21)
        Me.cmbSuppId.TabIndex = 1
        '
        'txtSuppNo
        '
        Me.txtSuppNo.Location = New System.Drawing.Point(74, 73)
        Me.txtSuppNo.Name = "txtSuppNo"
        Me.txtSuppNo.Size = New System.Drawing.Size(121, 20)
        Me.txtSuppNo.TabIndex = 0
        '
        'grpFind
        '
        Me.grpFind.Controls.Add(Me.radioInvoice)
        Me.grpFind.Controls.Add(Me.radioSupplier)
        Me.grpFind.Controls.Add(Me.radioBatch)
        Me.grpFind.Controls.Add(Me.btnFInd)
        Me.grpFind.Controls.Add(Me.cmbInvoice)
        Me.grpFind.Controls.Add(Me.cmbSupplier)
        Me.grpFind.Controls.Add(Me.cmbBatchCode)
        Me.grpFind.Dock = System.Windows.Forms.DockStyle.Left
        Me.grpFind.Location = New System.Drawing.Point(224, 16)
        Me.grpFind.Name = "grpFind"
        Me.grpFind.Size = New System.Drawing.Size(245, 188)
        Me.grpFind.TabIndex = 1
        Me.grpFind.TabStop = False
        Me.grpFind.Text = "Search"
        '
        'radioInvoice
        '
        Me.radioInvoice.AutoSize = True
        Me.radioInvoice.Location = New System.Drawing.Point(24, 77)
        Me.radioInvoice.Name = "radioInvoice"
        Me.radioInvoice.Size = New System.Drawing.Size(83, 17)
        Me.radioInvoice.TabIndex = 9
        Me.radioInvoice.TabStop = True
        Me.radioInvoice.Text = "Invoice No.:"
        Me.radioInvoice.UseVisualStyleBackColor = True
        '
        'radioSupplier
        '
        Me.radioSupplier.AutoSize = True
        Me.radioSupplier.Location = New System.Drawing.Point(24, 50)
        Me.radioSupplier.Name = "radioSupplier"
        Me.radioSupplier.Size = New System.Drawing.Size(80, 17)
        Me.radioSupplier.TabIndex = 8
        Me.radioSupplier.TabStop = True
        Me.radioSupplier.Text = "Supplier ID:"
        Me.radioSupplier.UseVisualStyleBackColor = True
        '
        'radioBatch
        '
        Me.radioBatch.AutoSize = True
        Me.radioBatch.Location = New System.Drawing.Point(24, 23)
        Me.radioBatch.Name = "radioBatch"
        Me.radioBatch.Size = New System.Drawing.Size(84, 17)
        Me.radioBatch.TabIndex = 7
        Me.radioBatch.TabStop = True
        Me.radioBatch.Text = "Batch Code:"
        Me.radioBatch.UseVisualStyleBackColor = True
        '
        'btnFInd
        '
        Me.btnFInd.Location = New System.Drawing.Point(114, 103)
        Me.btnFInd.Name = "btnFInd"
        Me.btnFInd.Size = New System.Drawing.Size(80, 27)
        Me.btnFInd.TabIndex = 6
        Me.btnFInd.Text = "Find"
        Me.btnFInd.UseVisualStyleBackColor = True
        '
        'cmbInvoice
        '
        Me.cmbInvoice.FormattingEnabled = True
        Me.cmbInvoice.Location = New System.Drawing.Point(114, 76)
        Me.cmbInvoice.Name = "cmbInvoice"
        Me.cmbInvoice.Size = New System.Drawing.Size(121, 21)
        Me.cmbInvoice.TabIndex = 2
        '
        'cmbSupplier
        '
        Me.cmbSupplier.FormattingEnabled = True
        Me.cmbSupplier.Location = New System.Drawing.Point(114, 49)
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.Size = New System.Drawing.Size(121, 21)
        Me.cmbSupplier.TabIndex = 1
        '
        'cmbBatchCode
        '
        Me.cmbBatchCode.FormattingEnabled = True
        Me.cmbBatchCode.Location = New System.Drawing.Point(114, 22)
        Me.cmbBatchCode.Name = "cmbBatchCode"
        Me.cmbBatchCode.Size = New System.Drawing.Size(121, 21)
        Me.cmbBatchCode.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = Global.OnusMed.My.Resources.Resources.blinkist_ios_icon_b
        Me.PictureBox1.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.numCredit)
        Me.GroupBox2.Controls.Add(Me.numBank)
        Me.GroupBox2.Controls.Add(Me.radioDD)
        Me.GroupBox2.Controls.Add(Me.radioCHQ)
        Me.GroupBox2.Controls.Add(Me.radioNA)
        Me.GroupBox2.Controls.Add(Me.numCash)
        Me.GroupBox2.Controls.Add(Me.numCard)
        Me.GroupBox2.Controls.Add(Me.txtInstruNo)
        Me.GroupBox2.Controls.Add(Me.cmbCardType)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.numNet)
        Me.GroupBox2.Controls.Add(Me.numDiscount)
        Me.GroupBox2.Controls.Add(Me.numGross)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(0, 207)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 474)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Payment Info"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(12, 375)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(37, 13)
        Me.Label28.TabIndex = 19
        Me.Label28.Text = "Credit:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(12, 350)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(74, 13)
        Me.Label27.TabIndex = 18
        Me.Label27.Text = "CHQ/DD No.:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(12, 300)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(35, 13)
        Me.Label26.TabIndex = 17
        Me.Label26.Text = "Bank:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(12, 274)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(59, 13)
        Me.Label25.TabIndex = 16
        Me.Label25.Text = "Card Type:"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(12, 247)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(32, 13)
        Me.Label24.TabIndex = 15
        Me.Label24.Text = "Card:"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(12, 221)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(58, 13)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Cash Paid:"
        '
        'numCredit
        '
        Me.numCredit.DecimalPlaces = 2
        Me.numCredit.Location = New System.Drawing.Point(92, 373)
        Me.numCredit.Maximum = New Decimal(New Integer() {1100381901, 3445, 0, 0})
        Me.numCredit.Name = "numCredit"
        Me.numCredit.Size = New System.Drawing.Size(120, 20)
        Me.numCredit.TabIndex = 14
        '
        'numBank
        '
        Me.numBank.DecimalPlaces = 2
        Me.numBank.Location = New System.Drawing.Point(92, 298)
        Me.numBank.Maximum = New Decimal(New Integer() {689896868, 1, 0, 0})
        Me.numBank.Name = "numBank"
        Me.numBank.Size = New System.Drawing.Size(120, 20)
        Me.numBank.TabIndex = 13
        '
        'radioDD
        '
        Me.radioDD.AutoSize = True
        Me.radioDD.Location = New System.Drawing.Point(165, 324)
        Me.radioDD.Name = "radioDD"
        Me.radioDD.Size = New System.Drawing.Size(41, 17)
        Me.radioDD.TabIndex = 12
        Me.radioDD.TabStop = True
        Me.radioDD.Text = "DD"
        Me.radioDD.UseVisualStyleBackColor = True
        '
        'radioCHQ
        '
        Me.radioCHQ.AutoSize = True
        Me.radioCHQ.Location = New System.Drawing.Point(111, 324)
        Me.radioCHQ.Name = "radioCHQ"
        Me.radioCHQ.Size = New System.Drawing.Size(48, 17)
        Me.radioCHQ.TabIndex = 11
        Me.radioCHQ.TabStop = True
        Me.radioCHQ.Text = "CHQ"
        Me.radioCHQ.UseVisualStyleBackColor = True
        '
        'radioNA
        '
        Me.radioNA.AutoSize = True
        Me.radioNA.Location = New System.Drawing.Point(60, 324)
        Me.radioNA.Name = "radioNA"
        Me.radioNA.Size = New System.Drawing.Size(45, 17)
        Me.radioNA.TabIndex = 10
        Me.radioNA.TabStop = True
        Me.radioNA.Text = "N/A"
        Me.radioNA.UseVisualStyleBackColor = True
        '
        'numCash
        '
        Me.numCash.DecimalPlaces = 2
        Me.numCash.Location = New System.Drawing.Point(93, 221)
        Me.numCash.Maximum = New Decimal(New Integer() {-476840427, 1669212, 0, 0})
        Me.numCash.Name = "numCash"
        Me.numCash.Size = New System.Drawing.Size(120, 20)
        Me.numCash.TabIndex = 9
        '
        'numCard
        '
        Me.numCard.DecimalPlaces = 2
        Me.numCard.Location = New System.Drawing.Point(93, 245)
        Me.numCard.Maximum = New Decimal(New Integer() {1607948677, 4, 0, 0})
        Me.numCard.Name = "numCard"
        Me.numCard.Size = New System.Drawing.Size(120, 20)
        Me.numCard.TabIndex = 8
        '
        'txtInstruNo
        '
        Me.txtInstruNo.Location = New System.Drawing.Point(92, 347)
        Me.txtInstruNo.Name = "txtInstruNo"
        Me.txtInstruNo.Size = New System.Drawing.Size(120, 20)
        Me.txtInstruNo.TabIndex = 7
        '
        'cmbCardType
        '
        Me.cmbCardType.FormattingEnabled = True
        Me.cmbCardType.Location = New System.Drawing.Point(92, 271)
        Me.cmbCardType.Name = "cmbCardType"
        Me.cmbCardType.Size = New System.Drawing.Size(121, 21)
        Me.cmbCardType.TabIndex = 6
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 69)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(27, 13)
        Me.Label22.TabIndex = 5
        Me.Label22.Text = "Net:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 43)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(66, 13)
        Me.Label21.TabIndex = 4
        Me.Label21.Text = "Discount(%):"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 17)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(37, 13)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Gross:"
        '
        'numNet
        '
        Me.numNet.DecimalPlaces = 2
        Me.numNet.Location = New System.Drawing.Point(74, 67)
        Me.numNet.Maximum = New Decimal(New Integer() {-463652567, 3, 0, 0})
        Me.numNet.Name = "numNet"
        Me.numNet.Size = New System.Drawing.Size(120, 20)
        Me.numNet.TabIndex = 2
        '
        'numDiscount
        '
        Me.numDiscount.DecimalPlaces = 2
        Me.numDiscount.Location = New System.Drawing.Point(74, 41)
        Me.numDiscount.Name = "numDiscount"
        Me.numDiscount.Size = New System.Drawing.Size(120, 20)
        Me.numDiscount.TabIndex = 1
        '
        'numGross
        '
        Me.numGross.DecimalPlaces = 2
        Me.numGross.Location = New System.Drawing.Point(74, 15)
        Me.numGross.Maximum = New Decimal(New Integer() {696407634, 4, 0, 0})
        Me.numGross.Name = "numGross"
        Me.numGross.Size = New System.Drawing.Size(120, 20)
        Me.numGross.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.ProgressBar1)
        Me.GroupBox3.Controls.Add(Me.btnComplete)
        Me.GroupBox3.Controls.Add(Me.btnExit)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(224, 618)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1040, 63)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Operations"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(767, 44)
        Me.ProgressBar1.TabIndex = 7
        '
        'btnComplete
        '
        Me.btnComplete.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplete.Location = New System.Drawing.Point(770, 16)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(136, 44)
        Me.btnComplete.TabIndex = 5
        Me.btnComplete.Text = "Complete Return"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(906, 16)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(131, 44)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'dgvList
        '
        Me.dgvList.AllowUserToAddRows = False
        Me.dgvList.AllowUserToDeleteRows = False
        Me.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.invoice, Me.icode, Me.batchcode, Me.supplierID, Me.iDate, Me.packQ, Me.stripQ, Me.pieceQ, Me.freePack, Me.freeStrip, Me.freePiece, Me.prPack, Me.stripPR, Me.piecePR, Me.discount, Me.cgst, Me.sgst, Me.igst, Me.ed})
        Me.dgvList.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvList.Location = New System.Drawing.Point(224, 394)
        Me.dgvList.Name = "dgvList"
        Me.dgvList.ReadOnly = True
        Me.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvList.Size = New System.Drawing.Size(1040, 224)
        Me.dgvList.TabIndex = 3
        '
        'invoice
        '
        Me.invoice.HeaderText = "Invoice No. (0)"
        Me.invoice.Name = "invoice"
        Me.invoice.ReadOnly = True
        '
        'icode
        '
        Me.icode.HeaderText = "Item Code (1)"
        Me.icode.Name = "icode"
        Me.icode.ReadOnly = True
        '
        'batchcode
        '
        Me.batchcode.HeaderText = "Batch Code (2)"
        Me.batchcode.Name = "batchcode"
        Me.batchcode.ReadOnly = True
        '
        'supplierID
        '
        Me.supplierID.HeaderText = "Supplier ID (3)"
        Me.supplierID.Name = "supplierID"
        Me.supplierID.ReadOnly = True
        '
        'iDate
        '
        Me.iDate.HeaderText = "Return Date (4)"
        Me.iDate.Name = "iDate"
        Me.iDate.ReadOnly = True
        '
        'packQ
        '
        Me.packQ.HeaderText = "Pack Qty. (5)"
        Me.packQ.Name = "packQ"
        Me.packQ.ReadOnly = True
        '
        'stripQ
        '
        Me.stripQ.HeaderText = "Strip Qty. (6)"
        Me.stripQ.Name = "stripQ"
        Me.stripQ.ReadOnly = True
        '
        'pieceQ
        '
        Me.pieceQ.HeaderText = "Piece Qty. (7)"
        Me.pieceQ.Name = "pieceQ"
        Me.pieceQ.ReadOnly = True
        '
        'freePack
        '
        Me.freePack.HeaderText = "Free Pack (8)"
        Me.freePack.Name = "freePack"
        Me.freePack.ReadOnly = True
        '
        'freeStrip
        '
        Me.freeStrip.HeaderText = "Free Strip (9)"
        Me.freeStrip.Name = "freeStrip"
        Me.freeStrip.ReadOnly = True
        '
        'freePiece
        '
        Me.freePiece.HeaderText = "Free Piece (10)"
        Me.freePiece.Name = "freePiece"
        Me.freePiece.ReadOnly = True
        '
        'prPack
        '
        Me.prPack.HeaderText = "Pack PR (11)"
        Me.prPack.Name = "prPack"
        Me.prPack.ReadOnly = True
        '
        'stripPR
        '
        Me.stripPR.HeaderText = "Strip PR"
        Me.stripPR.Name = "stripPR"
        Me.stripPR.ReadOnly = True
        '
        'piecePR
        '
        Me.piecePR.HeaderText = "Piece PR (13)"
        Me.piecePR.Name = "piecePR"
        Me.piecePR.ReadOnly = True
        '
        'discount
        '
        Me.discount.HeaderText = "Discount (14)"
        Me.discount.Name = "discount"
        Me.discount.ReadOnly = True
        '
        'cgst
        '
        Me.cgst.HeaderText = "CGST (15)"
        Me.cgst.Name = "cgst"
        Me.cgst.ReadOnly = True
        '
        'sgst
        '
        Me.sgst.HeaderText = "SGST (16)"
        Me.sgst.Name = "sgst"
        Me.sgst.ReadOnly = True
        '
        'igst
        '
        Me.igst.HeaderText = "IGST (17)"
        Me.igst.Name = "igst"
        Me.igst.ReadOnly = True
        '
        'ed
        '
        Me.ed.HeaderText = "E.D (18)"
        Me.ed.Name = "ed"
        Me.ed.ReadOnly = True
        '
        'dgvSearch
        '
        Me.dgvSearch.AllowUserToAddRows = False
        Me.dgvSearch.AllowUserToDeleteRows = False
        Me.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearch.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSearch.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvSearch.Location = New System.Drawing.Point(224, 207)
        Me.dgvSearch.MultiSelect = False
        Me.dgvSearch.Name = "dgvSearch"
        Me.dgvSearch.ReadOnly = True
        Me.dgvSearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearch.Size = New System.Drawing.Size(1040, 187)
        Me.dgvSearch.TabIndex = 4
        '
        'PurchaseReturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.dgvSearch)
        Me.Controls.Add(Me.dgvList)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "PurchaseReturn"
        Me.Text = "PurchaseReturn"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numFreePiece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFreeStrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFreePack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.numQtyPiece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQtyStrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQtyPack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.grpFind.ResumeLayout(False)
        Me.grpFind.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numCredit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numGross, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents numQtyPiece As NumericUpDown
    Friend WithEvents numQtyStrip As NumericUpDown
    Friend WithEvents numQtyPack As NumericUpDown
    Friend WithEvents cmbItemCode As ComboBox
    Friend WithEvents cmbItemName As ComboBox
    Friend WithEvents txtItemBatch As TextBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents grpFind As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lblStockPack As Label
    Friend WithEvents lblStockStrip As Label
    Friend WithEvents lblStockPiece As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbSuppName As ComboBox
    Friend WithEvents cmbSuppId As ComboBox
    Friend WithEvents txtSuppNo As TextBox
    Friend WithEvents radioInvoice As RadioButton
    Friend WithEvents radioSupplier As RadioButton
    Friend WithEvents radioBatch As RadioButton
    Friend WithEvents btnFInd As Button
    Friend WithEvents cmbInvoice As ComboBox
    Friend WithEvents cmbSupplier As ComboBox
    Friend WithEvents cmbBatchCode As ComboBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents numCredit As NumericUpDown
    Friend WithEvents numBank As NumericUpDown
    Friend WithEvents radioDD As RadioButton
    Friend WithEvents radioCHQ As RadioButton
    Friend WithEvents radioNA As RadioButton
    Friend WithEvents numCash As NumericUpDown
    Friend WithEvents numCard As NumericUpDown
    Friend WithEvents txtInstruNo As TextBox
    Friend WithEvents cmbCardType As ComboBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents numNet As NumericUpDown
    Friend WithEvents numDiscount As NumericUpDown
    Friend WithEvents numGross As NumericUpDown
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnComplete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents dgvList As DataGridView
    Friend WithEvents invoice As DataGridViewTextBoxColumn
    Friend WithEvents icode As DataGridViewTextBoxColumn
    Friend WithEvents batchcode As DataGridViewTextBoxColumn
    Friend WithEvents supplierID As DataGridViewTextBoxColumn
    Friend WithEvents iDate As DataGridViewTextBoxColumn
    Friend WithEvents packQ As DataGridViewTextBoxColumn
    Friend WithEvents stripQ As DataGridViewTextBoxColumn
    Friend WithEvents pieceQ As DataGridViewTextBoxColumn
    Friend WithEvents freePack As DataGridViewTextBoxColumn
    Friend WithEvents freeStrip As DataGridViewTextBoxColumn
    Friend WithEvents freePiece As DataGridViewTextBoxColumn
    Friend WithEvents prPack As DataGridViewTextBoxColumn
    Friend WithEvents stripPR As DataGridViewTextBoxColumn
    Friend WithEvents piecePR As DataGridViewTextBoxColumn
    Friend WithEvents discount As DataGridViewTextBoxColumn
    Friend WithEvents cgst As DataGridViewTextBoxColumn
    Friend WithEvents sgst As DataGridViewTextBoxColumn
    Friend WithEvents igst As DataGridViewTextBoxColumn
    Friend WithEvents ed As DataGridViewTextBoxColumn
    Friend WithEvents dgvSearch As DataGridView
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents numFreePiece As NumericUpDown
    Friend WithEvents numFreeStrip As NumericUpDown
    Friend WithEvents numFreePack As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents dateInvoice As DateTimePicker
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents Timer1 As Timer
End Class
