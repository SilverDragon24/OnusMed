<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PurchaseEntry
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.chkInterState = New System.Windows.Forms.CheckBox()
        Me.txtItemCode = New System.Windows.Forms.TextBox()
        Me.numMrpPiece = New System.Windows.Forms.NumericUpDown()
        Me.numMrpStrip = New System.Windows.Forms.NumericUpDown()
        Me.numMrpPack = New System.Windows.Forms.NumericUpDown()
        Me.numPrPiece = New System.Windows.Forms.NumericUpDown()
        Me.numPrStrip = New System.Windows.Forms.NumericUpDown()
        Me.numPrPack = New System.Windows.Forms.NumericUpDown()
        Me.numED = New System.Windows.Forms.NumericUpDown()
        Me.btnNewItem = New System.Windows.Forms.Button()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.numIGST = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.numSGST = New System.Windows.Forms.NumericUpDown()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.numCGST = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dateExpiry = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.numFreePiece = New System.Windows.Forms.NumericUpDown()
        Me.numFreeStrip = New System.Windows.Forms.NumericUpDown()
        Me.numFreePack = New System.Windows.Forms.NumericUpDown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dateInvoiceDate = New System.Windows.Forms.DateTimePicker()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBatchCode = New System.Windows.Forms.TextBox()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.numQtyPiece = New System.Windows.Forms.NumericUpDown()
        Me.numQtyStrip = New System.Windows.Forms.NumericUpDown()
        Me.numQtyPack = New System.Windows.Forms.NumericUpDown()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.cmbItemName = New System.Windows.Forms.ComboBox()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.cmbSuppName = New System.Windows.Forms.ComboBox()
        Me.cmbSuppID = New System.Windows.Forms.ComboBox()
        Me.btnNewSupp = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtSuppEmail = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtSuppNo = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ItemCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BatchCode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SupplierID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Supplier = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.iDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Expiry = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StripQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PieceQ = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FreePack = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FreeStrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FreePiece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MRPPack = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MRPStrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MRPPiece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRPack = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRStrip = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRPiece = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Discount = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CGST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SGST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IGST = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ED = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Amt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmbCardType = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtInstruNo = New System.Windows.Forms.TextBox()
        Me.radioInstruCHQ = New System.Windows.Forms.RadioButton()
        Me.radioInstruNA = New System.Windows.Forms.RadioButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.radioInstruDD = New System.Windows.Forms.RadioButton()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.numGross = New System.Windows.Forms.NumericUpDown()
        Me.numDiscount = New System.Windows.Forms.NumericUpDown()
        Me.numNet = New System.Windows.Forms.NumericUpDown()
        Me.numCash = New System.Windows.Forms.NumericUpDown()
        Me.numCard = New System.Windows.Forms.NumericUpDown()
        Me.numBank = New System.Windows.Forms.NumericUpDown()
        Me.numCredit = New System.Windows.Forms.NumericUpDown()
        Me.numSuppCredit = New System.Windows.Forms.NumericUpDown()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.numMrpPiece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMrpStrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numMrpPack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrPiece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrStrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPrPack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numED, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numIGST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSGST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCGST, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFreePiece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFreeStrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numFreePack, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQtyPiece, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQtyStrip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numQtyPack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox7.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.numGross, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numNet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numBank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSuppCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1264, 681)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox4)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1256, 655)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Purchase Entry"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.GroupBox9)
        Me.GroupBox4.Controls.Add(Me.GroupBox7)
        Me.GroupBox4.Controls.Add(Me.DataGridView1)
        Me.GroupBox4.Controls.Add(Me.GroupBox5)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(203, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(1050, 649)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.chkInterState)
        Me.GroupBox9.Controls.Add(Me.txtItemCode)
        Me.GroupBox9.Controls.Add(Me.numMrpPiece)
        Me.GroupBox9.Controls.Add(Me.numMrpStrip)
        Me.GroupBox9.Controls.Add(Me.numMrpPack)
        Me.GroupBox9.Controls.Add(Me.numPrPiece)
        Me.GroupBox9.Controls.Add(Me.numPrStrip)
        Me.GroupBox9.Controls.Add(Me.numPrPack)
        Me.GroupBox9.Controls.Add(Me.numED)
        Me.GroupBox9.Controls.Add(Me.btnNewItem)
        Me.GroupBox9.Controls.Add(Me.Label17)
        Me.GroupBox9.Controls.Add(Me.numIGST)
        Me.GroupBox9.Controls.Add(Me.Label10)
        Me.GroupBox9.Controls.Add(Me.numSGST)
        Me.GroupBox9.Controls.Add(Me.Label16)
        Me.GroupBox9.Controls.Add(Me.Label23)
        Me.GroupBox9.Controls.Add(Me.numCGST)
        Me.GroupBox9.Controls.Add(Me.Label24)
        Me.GroupBox9.Controls.Add(Me.Label9)
        Me.GroupBox9.Controls.Add(Me.dateExpiry)
        Me.GroupBox9.Controls.Add(Me.Label8)
        Me.GroupBox9.Controls.Add(Me.Label7)
        Me.GroupBox9.Controls.Add(Me.Label3)
        Me.GroupBox9.Controls.Add(Me.Label15)
        Me.GroupBox9.Controls.Add(Me.Label4)
        Me.GroupBox9.Controls.Add(Me.Label5)
        Me.GroupBox9.Controls.Add(Me.Label6)
        Me.GroupBox9.Controls.Add(Me.numFreePiece)
        Me.GroupBox9.Controls.Add(Me.numFreeStrip)
        Me.GroupBox9.Controls.Add(Me.numFreePack)
        Me.GroupBox9.Controls.Add(Me.Label12)
        Me.GroupBox9.Controls.Add(Me.dateInvoiceDate)
        Me.GroupBox9.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox9.Controls.Add(Me.Label2)
        Me.GroupBox9.Controls.Add(Me.Label1)
        Me.GroupBox9.Controls.Add(Me.txtBatchCode)
        Me.GroupBox9.Controls.Add(Me.btnRemove)
        Me.GroupBox9.Controls.Add(Me.btnAdd)
        Me.GroupBox9.Controls.Add(Me.Label40)
        Me.GroupBox9.Controls.Add(Me.Label39)
        Me.GroupBox9.Controls.Add(Me.Label38)
        Me.GroupBox9.Controls.Add(Me.Label37)
        Me.GroupBox9.Controls.Add(Me.numQtyPiece)
        Me.GroupBox9.Controls.Add(Me.numQtyStrip)
        Me.GroupBox9.Controls.Add(Me.numQtyPack)
        Me.GroupBox9.Controls.Add(Me.Label36)
        Me.GroupBox9.Controls.Add(Me.Label35)
        Me.GroupBox9.Controls.Add(Me.cmbItemName)
        Me.GroupBox9.Controls.Add(Me.Label34)
        Me.GroupBox9.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox9.Location = New System.Drawing.Point(203, 16)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(844, 164)
        Me.GroupBox9.TabIndex = 3
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Item Details"
        '
        'chkInterState
        '
        Me.chkInterState.AutoSize = True
        Me.chkInterState.Location = New System.Drawing.Point(341, 139)
        Me.chkInterState.Name = "chkInterState"
        Me.chkInterState.Size = New System.Drawing.Size(123, 17)
        Me.chkInterState.TabIndex = 49
        Me.chkInterState.Text = "Inter-State Purchase"
        Me.chkInterState.UseVisualStyleBackColor = True
        '
        'txtItemCode
        '
        Me.txtItemCode.Location = New System.Drawing.Point(73, 46)
        Me.txtItemCode.Name = "txtItemCode"
        Me.txtItemCode.Size = New System.Drawing.Size(165, 20)
        Me.txtItemCode.TabIndex = 48
        '
        'numMrpPiece
        '
        Me.numMrpPiece.DecimalPlaces = 2
        Me.numMrpPiece.Location = New System.Drawing.Point(489, 72)
        Me.numMrpPiece.Maximum = New Decimal(New Integer() {1494689152, 184, 0, 0})
        Me.numMrpPiece.Name = "numMrpPiece"
        Me.numMrpPiece.Size = New System.Drawing.Size(52, 20)
        Me.numMrpPiece.TabIndex = 47
        '
        'numMrpStrip
        '
        Me.numMrpStrip.DecimalPlaces = 2
        Me.numMrpStrip.Location = New System.Drawing.Point(414, 72)
        Me.numMrpStrip.Maximum = New Decimal(New Integer() {-282551263, 166, 0, 0})
        Me.numMrpStrip.Name = "numMrpStrip"
        Me.numMrpStrip.Size = New System.Drawing.Size(69, 20)
        Me.numMrpStrip.TabIndex = 46
        '
        'numMrpPack
        '
        Me.numMrpPack.DecimalPlaces = 2
        Me.numMrpPack.Location = New System.Drawing.Point(341, 72)
        Me.numMrpPack.Maximum = New Decimal(New Integer() {1684227345, 4116, 0, 0})
        Me.numMrpPack.Name = "numMrpPack"
        Me.numMrpPack.Size = New System.Drawing.Size(67, 20)
        Me.numMrpPack.TabIndex = 45
        '
        'numPrPiece
        '
        Me.numPrPiece.DecimalPlaces = 2
        Me.numPrPiece.Location = New System.Drawing.Point(774, 47)
        Me.numPrPiece.Maximum = New Decimal(New Integer() {-282620741, 166, 0, 0})
        Me.numPrPiece.Name = "numPrPiece"
        Me.numPrPiece.Size = New System.Drawing.Size(52, 20)
        Me.numPrPiece.TabIndex = 44
        '
        'numPrStrip
        '
        Me.numPrStrip.DecimalPlaces = 2
        Me.numPrStrip.Location = New System.Drawing.Point(707, 47)
        Me.numPrStrip.Maximum = New Decimal(New Integer() {-282866745, 166, 0, 0})
        Me.numPrStrip.Name = "numPrStrip"
        Me.numPrStrip.Size = New System.Drawing.Size(61, 20)
        Me.numPrStrip.TabIndex = 43
        '
        'numPrPack
        '
        Me.numPrPack.DecimalPlaces = 2
        Me.numPrPack.Location = New System.Drawing.Point(634, 46)
        Me.numPrPack.Maximum = New Decimal(New Integer() {-673766631, 1, 0, 0})
        Me.numPrPack.Name = "numPrPack"
        Me.numPrPack.Size = New System.Drawing.Size(67, 20)
        Me.numPrPack.TabIndex = 42
        '
        'numED
        '
        Me.numED.DecimalPlaces = 2
        Me.numED.Location = New System.Drawing.Point(550, 84)
        Me.numED.Name = "numED"
        Me.numED.Size = New System.Drawing.Size(78, 20)
        Me.numED.TabIndex = 41
        '
        'btnNewItem
        '
        Me.btnNewItem.Location = New System.Drawing.Point(242, 135)
        Me.btnNewItem.Name = "btnNewItem"
        Me.btnNewItem.Size = New System.Drawing.Size(75, 23)
        Me.btnNewItem.TabIndex = 40
        Me.btnNewItem.Text = "New Item"
        Me.btnNewItem.UseVisualStyleBackColor = True
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(547, 107)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(45, 13)
        Me.Label17.TabIndex = 39
        Me.Label17.Text = "E.D (%):"
        '
        'numIGST
        '
        Me.numIGST.DecimalPlaces = 2
        Me.numIGST.Location = New System.Drawing.Point(774, 84)
        Me.numIGST.Name = "numIGST"
        Me.numIGST.Size = New System.Drawing.Size(52, 20)
        Me.numIGST.TabIndex = 38
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(771, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "/Piece"
        '
        'numSGST
        '
        Me.numSGST.DecimalPlaces = 2
        Me.numSGST.Location = New System.Drawing.Point(707, 84)
        Me.numSGST.Name = "numSGST"
        Me.numSGST.Size = New System.Drawing.Size(61, 20)
        Me.numSGST.TabIndex = 36
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(771, 107)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(52, 13)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "IGST (%):"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(704, 68)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(33, 13)
        Me.Label23.TabIndex = 34
        Me.Label23.Text = "/Strip"
        '
        'numCGST
        '
        Me.numCGST.DecimalPlaces = 2
        Me.numCGST.Location = New System.Drawing.Point(634, 84)
        Me.numCGST.Name = "numCGST"
        Me.numCGST.Size = New System.Drawing.Size(67, 20)
        Me.numCGST.TabIndex = 33
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(631, 68)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 13)
        Me.Label24.TabIndex = 32
        Me.Label24.Text = "/Pack"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(547, 49)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Purchase Rate:"
        '
        'dateExpiry
        '
        Me.dateExpiry.CustomFormat = "MM/yyyy"
        Me.dateExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateExpiry.Location = New System.Drawing.Point(634, 19)
        Me.dateExpiry.Name = "dateExpiry"
        Me.dateExpiry.Size = New System.Drawing.Size(192, 20)
        Me.dateExpiry.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(547, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Expiry Date:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(270, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "MRP:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(486, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Pieces"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(704, 107)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 26
        Me.Label15.Text = "SGST (%):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(411, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Strips"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(338, 121)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Packs"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(270, 100)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Free:"
        '
        'numFreePiece
        '
        Me.numFreePiece.Location = New System.Drawing.Point(489, 98)
        Me.numFreePiece.Maximum = New Decimal(New Integer() {-1550707296, 16, 0, 0})
        Me.numFreePiece.Name = "numFreePiece"
        Me.numFreePiece.Size = New System.Drawing.Size(52, 20)
        Me.numFreePiece.TabIndex = 22
        '
        'numFreeStrip
        '
        Me.numFreeStrip.DecimalPlaces = 2
        Me.numFreeStrip.Location = New System.Drawing.Point(414, 98)
        Me.numFreeStrip.Maximum = New Decimal(New Integer() {-1657609937, 1773, 0, 0})
        Me.numFreeStrip.Name = "numFreeStrip"
        Me.numFreeStrip.Size = New System.Drawing.Size(69, 20)
        Me.numFreeStrip.TabIndex = 21
        '
        'numFreePack
        '
        Me.numFreePack.DecimalPlaces = 2
        Me.numFreePack.Location = New System.Drawing.Point(341, 98)
        Me.numFreePack.Maximum = New Decimal(New Integer() {-914636528, 17373, 0, 0})
        Me.numFreePack.Name = "numFreePack"
        Me.numFreePack.Size = New System.Drawing.Size(67, 20)
        Me.numFreePack.TabIndex = 20
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(631, 107)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "CGST (%):"
        '
        'dateInvoiceDate
        '
        Me.dateInvoiceDate.Location = New System.Drawing.Point(341, 46)
        Me.dateInvoiceDate.Name = "dateInvoiceDate"
        Me.dateInvoiceDate.Size = New System.Drawing.Size(200, 20)
        Me.dateInvoiceDate.TabIndex = 18
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.Location = New System.Drawing.Point(341, 19)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(200, 20)
        Me.txtInvoiceNo.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Date:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(270, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Invoice No.:"
        '
        'txtBatchCode
        '
        Me.txtBatchCode.Location = New System.Drawing.Point(73, 72)
        Me.txtBatchCode.Name = "txtBatchCode"
        Me.txtBatchCode.Size = New System.Drawing.Size(165, 20)
        Me.txtBatchCode.TabIndex = 14
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(730, 135)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(75, 23)
        Me.btnRemove.TabIndex = 13
        Me.btnRemove.Text = "Remove"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(649, 135)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(183, 123)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(39, 13)
        Me.Label40.TabIndex = 11
        Me.Label40.Text = "Pieces"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(132, 123)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(33, 13)
        Me.Label39.TabIndex = 10
        Me.Label39.Text = "Strips"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(70, 123)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(37, 13)
        Me.Label38.TabIndex = 9
        Me.Label38.Text = "Packs"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(6, 102)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(49, 13)
        Me.Label37.TabIndex = 8
        Me.Label37.Text = "Quantity:"
        '
        'numQtyPiece
        '
        Me.numQtyPiece.Location = New System.Drawing.Point(186, 100)
        Me.numQtyPiece.Maximum = New Decimal(New Integer() {1697127616, 0, 0, 0})
        Me.numQtyPiece.Name = "numQtyPiece"
        Me.numQtyPiece.Size = New System.Drawing.Size(52, 20)
        Me.numQtyPiece.TabIndex = 7
        '
        'numQtyStrip
        '
        Me.numQtyStrip.DecimalPlaces = 2
        Me.numQtyStrip.Location = New System.Drawing.Point(135, 100)
        Me.numQtyStrip.Maximum = New Decimal(New Integer() {-1954834418, 413, 0, 0})
        Me.numQtyStrip.Name = "numQtyStrip"
        Me.numQtyStrip.Size = New System.Drawing.Size(45, 20)
        Me.numQtyStrip.TabIndex = 6
        '
        'numQtyPack
        '
        Me.numQtyPack.DecimalPlaces = 2
        Me.numQtyPack.Location = New System.Drawing.Point(73, 100)
        Me.numQtyPack.Maximum = New Decimal(New Integer() {-1332697761, 16, 0, 0})
        Me.numQtyPack.Name = "numQtyPack"
        Me.numQtyPack.Size = New System.Drawing.Size(56, 20)
        Me.numQtyPack.TabIndex = 5
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(6, 75)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(66, 13)
        Me.Label36.TabIndex = 4
        Me.Label36.Text = "Batch Code:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(6, 49)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(58, 13)
        Me.Label35.TabIndex = 3
        Me.Label35.Text = "Item Code:"
        '
        'cmbItemName
        '
        Me.cmbItemName.FormattingEnabled = True
        Me.cmbItemName.Location = New System.Drawing.Point(73, 19)
        Me.cmbItemName.Name = "cmbItemName"
        Me.cmbItemName.Size = New System.Drawing.Size(165, 21)
        Me.cmbItemName.TabIndex = 1
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(6, 22)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(61, 13)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Item Name:"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.cmbSuppName)
        Me.GroupBox7.Controls.Add(Me.cmbSuppID)
        Me.GroupBox7.Controls.Add(Me.btnNewSupp)
        Me.GroupBox7.Controls.Add(Me.Label29)
        Me.GroupBox7.Controls.Add(Me.txtSuppEmail)
        Me.GroupBox7.Controls.Add(Me.Label28)
        Me.GroupBox7.Controls.Add(Me.Label27)
        Me.GroupBox7.Controls.Add(Me.txtSuppNo)
        Me.GroupBox7.Controls.Add(Me.Label26)
        Me.GroupBox7.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox7.Location = New System.Drawing.Point(3, 16)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(200, 164)
        Me.GroupBox7.TabIndex = 2
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Supplier Details"
        '
        'cmbSuppName
        '
        Me.cmbSuppName.FormattingEnabled = True
        Me.cmbSuppName.Location = New System.Drawing.Point(69, 45)
        Me.cmbSuppName.Name = "cmbSuppName"
        Me.cmbSuppName.Size = New System.Drawing.Size(100, 21)
        Me.cmbSuppName.TabIndex = 8
        '
        'cmbSuppID
        '
        Me.cmbSuppID.FormattingEnabled = True
        Me.cmbSuppID.Location = New System.Drawing.Point(69, 19)
        Me.cmbSuppID.Name = "cmbSuppID"
        Me.cmbSuppID.Size = New System.Drawing.Size(100, 21)
        Me.cmbSuppID.TabIndex = 7
        '
        'btnNewSupp
        '
        Me.btnNewSupp.Location = New System.Drawing.Point(61, 135)
        Me.btnNewSupp.Name = "btnNewSupp"
        Me.btnNewSupp.Size = New System.Drawing.Size(87, 23)
        Me.btnNewSupp.TabIndex = 6
        Me.btnNewSupp.Text = "New Supplier"
        Me.btnNewSupp.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(6, 100)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(39, 13)
        Me.Label29.TabIndex = 5
        Me.Label29.Text = "E-Mail:"
        '
        'txtSuppEmail
        '
        Me.txtSuppEmail.Location = New System.Drawing.Point(69, 97)
        Me.txtSuppEmail.Name = "txtSuppEmail"
        Me.txtSuppEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtSuppEmail.TabIndex = 4
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(6, 74)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(47, 13)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Number:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(6, 48)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(38, 13)
        Me.Label27.TabIndex = 2
        Me.Label27.Text = "Name:"
        '
        'txtSuppNo
        '
        Me.txtSuppNo.Location = New System.Drawing.Point(69, 71)
        Me.txtSuppNo.Name = "txtSuppNo"
        Me.txtSuppNo.Size = New System.Drawing.Size(100, 20)
        Me.txtSuppNo.TabIndex = 1
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(6, 22)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(62, 13)
        Me.Label26.TabIndex = 0
        Me.Label26.Text = "Supplier ID:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ItemCode, Me.ItemName, Me.BatchCode, Me.SupplierID, Me.Supplier, Me.iDate, Me.Expiry, Me.PackQ, Me.StripQ, Me.PieceQ, Me.FreePack, Me.FreeStrip, Me.FreePiece, Me.MRPPack, Me.MRPStrip, Me.MRPPiece, Me.PRPack, Me.PRStrip, Me.PRPiece, Me.Discount, Me.CGST, Me.SGST, Me.IGST, Me.ED, Me.Amt})
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(3, 180)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1044, 416)
        Me.DataGridView1.TabIndex = 1
        '
        'ItemCode
        '
        Me.ItemCode.HeaderText = "Item Code (0)"
        Me.ItemCode.Name = "ItemCode"
        Me.ItemCode.ReadOnly = True
        '
        'ItemName
        '
        Me.ItemName.HeaderText = "Item Name (1)"
        Me.ItemName.Name = "ItemName"
        Me.ItemName.ReadOnly = True
        '
        'BatchCode
        '
        Me.BatchCode.HeaderText = "Batch Code (2)"
        Me.BatchCode.Name = "BatchCode"
        Me.BatchCode.ReadOnly = True
        '
        'SupplierID
        '
        Me.SupplierID.HeaderText = "Supplier ID (3)"
        Me.SupplierID.Name = "SupplierID"
        Me.SupplierID.ReadOnly = True
        '
        'Supplier
        '
        Me.Supplier.HeaderText = "Supplier (4)"
        Me.Supplier.Name = "Supplier"
        Me.Supplier.ReadOnly = True
        '
        'iDate
        '
        Me.iDate.HeaderText = "Invoice Date (5)"
        Me.iDate.Name = "iDate"
        Me.iDate.ReadOnly = True
        '
        'Expiry
        '
        Me.Expiry.HeaderText = "Expiry (6)"
        Me.Expiry.Name = "Expiry"
        Me.Expiry.ReadOnly = True
        '
        'PackQ
        '
        Me.PackQ.HeaderText = "Pack Qty. (7)"
        Me.PackQ.Name = "PackQ"
        Me.PackQ.ReadOnly = True
        '
        'StripQ
        '
        Me.StripQ.HeaderText = "Strip Qty. (8)"
        Me.StripQ.Name = "StripQ"
        Me.StripQ.ReadOnly = True
        '
        'PieceQ
        '
        Me.PieceQ.HeaderText = "Piece Qty. (9)"
        Me.PieceQ.Name = "PieceQ"
        Me.PieceQ.ReadOnly = True
        '
        'FreePack
        '
        Me.FreePack.HeaderText = "Free Pack Qty. (10)"
        Me.FreePack.Name = "FreePack"
        Me.FreePack.ReadOnly = True
        '
        'FreeStrip
        '
        Me.FreeStrip.HeaderText = "Free Strip Qty. (11)"
        Me.FreeStrip.Name = "FreeStrip"
        Me.FreeStrip.ReadOnly = True
        '
        'FreePiece
        '
        Me.FreePiece.HeaderText = "Free Piece Qty. (12)"
        Me.FreePiece.Name = "FreePiece"
        Me.FreePiece.ReadOnly = True
        '
        'MRPPack
        '
        Me.MRPPack.HeaderText = "Pack MRP (13)"
        Me.MRPPack.Name = "MRPPack"
        Me.MRPPack.ReadOnly = True
        '
        'MRPStrip
        '
        Me.MRPStrip.HeaderText = "Strip MRP (14)"
        Me.MRPStrip.Name = "MRPStrip"
        Me.MRPStrip.ReadOnly = True
        '
        'MRPPiece
        '
        Me.MRPPiece.HeaderText = "Piece MRP (15)"
        Me.MRPPiece.Name = "MRPPiece"
        Me.MRPPiece.ReadOnly = True
        '
        'PRPack
        '
        Me.PRPack.HeaderText = "Pack PR (16)"
        Me.PRPack.Name = "PRPack"
        Me.PRPack.ReadOnly = True
        '
        'PRStrip
        '
        Me.PRStrip.HeaderText = "Strip PR (17)"
        Me.PRStrip.Name = "PRStrip"
        Me.PRStrip.ReadOnly = True
        '
        'PRPiece
        '
        Me.PRPiece.HeaderText = "Piece PR (18)"
        Me.PRPiece.Name = "PRPiece"
        Me.PRPiece.ReadOnly = True
        '
        'Discount
        '
        Me.Discount.HeaderText = "Discount (19)"
        Me.Discount.Name = "Discount"
        Me.Discount.ReadOnly = True
        '
        'CGST
        '
        Me.CGST.HeaderText = "CGST (20)"
        Me.CGST.Name = "CGST"
        Me.CGST.ReadOnly = True
        '
        'SGST
        '
        Me.SGST.HeaderText = "SGST (21)"
        Me.SGST.Name = "SGST"
        Me.SGST.ReadOnly = True
        '
        'IGST
        '
        Me.IGST.HeaderText = "IGST (22)"
        Me.IGST.Name = "IGST"
        Me.IGST.ReadOnly = True
        '
        'ED
        '
        Me.ED.HeaderText = "Excise Duty (23)"
        Me.ED.Name = "ED"
        Me.ED.ReadOnly = True
        '
        'Amt
        '
        Me.Amt.HeaderText = "Amount (24)"
        Me.Amt.Name = "Amt"
        Me.Amt.ReadOnly = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.ProgressBar1)
        Me.GroupBox5.Controls.Add(Me.btnComplete)
        Me.GroupBox5.Controls.Add(Me.btnExit)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox5.Location = New System.Drawing.Point(3, 596)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(1044, 50)
        Me.GroupBox5.TabIndex = 0
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Operations"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProgressBar1.Location = New System.Drawing.Point(3, 16)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(738, 31)
        Me.ProgressBar1.TabIndex = 2
        '
        'btnComplete
        '
        Me.btnComplete.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnComplete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComplete.Location = New System.Drawing.Point(741, 16)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(150, 31)
        Me.btnComplete.TabIndex = 1
        Me.btnComplete.Text = "Complete Purchase"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(891, 16)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(150, 31)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 649)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.cmbCardType)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txtInstruNo)
        Me.GroupBox3.Controls.Add(Me.radioInstruCHQ)
        Me.GroupBox3.Controls.Add(Me.radioInstruNA)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.radioInstruDD)
        Me.GroupBox3.Controls.Add(Me.Label25)
        Me.GroupBox3.Controls.Add(Me.numGross)
        Me.GroupBox3.Controls.Add(Me.numDiscount)
        Me.GroupBox3.Controls.Add(Me.numNet)
        Me.GroupBox3.Controls.Add(Me.numCash)
        Me.GroupBox3.Controls.Add(Me.numCard)
        Me.GroupBox3.Controls.Add(Me.numBank)
        Me.GroupBox3.Controls.Add(Me.numCredit)
        Me.GroupBox3.Controls.Add(Me.numSuppCredit)
        Me.GroupBox3.Controls.Add(Me.Label30)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 160)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(194, 486)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pricing"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 298)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(32, 13)
        Me.Label19.TabIndex = 22
        Me.Label19.Text = "Card:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 272)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 13)
        Me.Label18.TabIndex = 21
        Me.Label18.Text = "Cash Paid:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(76, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Gross Amount:"
        '
        'cmbCardType
        '
        Me.cmbCardType.FormattingEnabled = True
        Me.cmbCardType.Location = New System.Drawing.Point(85, 321)
        Me.cmbCardType.Name = "cmbCardType"
        Me.cmbCardType.Size = New System.Drawing.Size(103, 21)
        Me.cmbCardType.TabIndex = 19
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 324)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(59, 13)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Card Type:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(2, 351)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(35, 13)
        Me.Label21.TabIndex = 17
        Me.Label21.Text = "Bank:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(2, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "Discount (%):"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(2, 68)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 13)
        Me.Label14.TabIndex = 15
        Me.Label14.Text = "Net Amount:"
        '
        'txtInstruNo
        '
        Me.txtInstruNo.Location = New System.Drawing.Point(85, 397)
        Me.txtInstruNo.Name = "txtInstruNo"
        Me.txtInstruNo.Size = New System.Drawing.Size(103, 20)
        Me.txtInstruNo.TabIndex = 14
        '
        'radioInstruCHQ
        '
        Me.radioInstruCHQ.AutoSize = True
        Me.radioInstruCHQ.Location = New System.Drawing.Point(93, 374)
        Me.radioInstruCHQ.Name = "radioInstruCHQ"
        Me.radioInstruCHQ.Size = New System.Drawing.Size(48, 17)
        Me.radioInstruCHQ.TabIndex = 13
        Me.radioInstruCHQ.TabStop = True
        Me.radioInstruCHQ.Text = "CHQ"
        Me.radioInstruCHQ.UseVisualStyleBackColor = True
        '
        'radioInstruNA
        '
        Me.radioInstruNA.AutoSize = True
        Me.radioInstruNA.Location = New System.Drawing.Point(42, 374)
        Me.radioInstruNA.Name = "radioInstruNA"
        Me.radioInstruNA.Size = New System.Drawing.Size(45, 17)
        Me.radioInstruNA.TabIndex = 12
        Me.radioInstruNA.TabStop = True
        Me.radioInstruNA.Text = "N/A"
        Me.radioInstruNA.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(2, 400)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(74, 13)
        Me.Label22.TabIndex = 11
        Me.Label22.Text = "CHQ/DD No.:"
        '
        'radioInstruDD
        '
        Me.radioInstruDD.AutoSize = True
        Me.radioInstruDD.Location = New System.Drawing.Point(147, 374)
        Me.radioInstruDD.Name = "radioInstruDD"
        Me.radioInstruDD.Size = New System.Drawing.Size(41, 17)
        Me.radioInstruDD.TabIndex = 10
        Me.radioInstruDD.TabStop = True
        Me.radioInstruDD.Text = "DD"
        Me.radioInstruDD.UseVisualStyleBackColor = True
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(3, 426)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(37, 13)
        Me.Label25.TabIndex = 9
        Me.Label25.Text = "Credit:"
        '
        'numGross
        '
        Me.numGross.DecimalPlaces = 2
        Me.numGross.Location = New System.Drawing.Point(84, 14)
        Me.numGross.Maximum = New Decimal(New Integer() {1675053393, 3417528, 0, 0})
        Me.numGross.Name = "numGross"
        Me.numGross.Size = New System.Drawing.Size(107, 20)
        Me.numGross.TabIndex = 8
        '
        'numDiscount
        '
        Me.numDiscount.DecimalPlaces = 2
        Me.numDiscount.Location = New System.Drawing.Point(84, 40)
        Me.numDiscount.Name = "numDiscount"
        Me.numDiscount.Size = New System.Drawing.Size(107, 20)
        Me.numDiscount.TabIndex = 7
        '
        'numNet
        '
        Me.numNet.DecimalPlaces = 2
        Me.numNet.Location = New System.Drawing.Point(84, 66)
        Me.numNet.Maximum = New Decimal(New Integer() {1673637367, 0, 0, 0})
        Me.numNet.Name = "numNet"
        Me.numNet.Size = New System.Drawing.Size(107, 20)
        Me.numNet.TabIndex = 6
        '
        'numCash
        '
        Me.numCash.DecimalPlaces = 2
        Me.numCash.Location = New System.Drawing.Point(85, 270)
        Me.numCash.Maximum = New Decimal(New Integer() {152557080, 41, 0, 0})
        Me.numCash.Minimum = New Decimal(New Integer() {586924437, 1075, 0, -2147483648})
        Me.numCash.Name = "numCash"
        Me.numCash.Size = New System.Drawing.Size(103, 20)
        Me.numCash.TabIndex = 5
        '
        'numCard
        '
        Me.numCard.DecimalPlaces = 2
        Me.numCard.Location = New System.Drawing.Point(85, 296)
        Me.numCard.Maximum = New Decimal(New Integer() {-1307654255, 143, 0, 0})
        Me.numCard.Minimum = New Decimal(New Integer() {-523250763, 1790, 0, -2147483648})
        Me.numCard.Name = "numCard"
        Me.numCard.Size = New System.Drawing.Size(103, 20)
        Me.numCard.TabIndex = 4
        '
        'numBank
        '
        Me.numBank.DecimalPlaces = 2
        Me.numBank.Location = New System.Drawing.Point(85, 349)
        Me.numBank.Maximum = New Decimal(New Integer() {304615572, 38526, 0, 0})
        Me.numBank.Minimum = New Decimal(New Integer() {-877534888, 17908, 0, -2147483648})
        Me.numBank.Name = "numBank"
        Me.numBank.Size = New System.Drawing.Size(103, 20)
        Me.numBank.TabIndex = 3
        '
        'numCredit
        '
        Me.numCredit.DecimalPlaces = 2
        Me.numCredit.Location = New System.Drawing.Point(85, 424)
        Me.numCredit.Maximum = New Decimal(New Integer() {-1562656454, 229, 0, 0})
        Me.numCredit.Minimum = New Decimal(New Integer() {-602719327, 1668, 0, -2147483648})
        Me.numCredit.Name = "numCredit"
        Me.numCredit.Size = New System.Drawing.Size(103, 20)
        Me.numCredit.TabIndex = 2
        '
        'numSuppCredit
        '
        Me.numSuppCredit.DecimalPlaces = 2
        Me.numSuppCredit.Location = New System.Drawing.Point(84, 92)
        Me.numSuppCredit.Maximum = New Decimal(New Integer() {959315935, 18, 0, 0})
        Me.numSuppCredit.Name = "numSuppCredit"
        Me.numSuppCredit.Size = New System.Drawing.Size(107, 20)
        Me.numSuppCredit.TabIndex = 1
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(2, 94)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(78, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Supplier Credit:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.OnusMed.My.Resources.Resources.blinkist_ios_icon_b
        Me.PictureBox1.Location = New System.Drawing.Point(3, 16)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 144)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PurchaseEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "PurchaseEntry"
        Me.Text = "PurchaseEntry"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.numMrpPiece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMrpStrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numMrpPack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrPiece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrStrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPrPack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numED, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numIGST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSGST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCGST, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFreePiece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFreeStrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numFreePack, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQtyPiece, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQtyStrip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numQtyPack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.numGross, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numNet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numBank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numCredit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSuppCredit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents btnComplete As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cmbCardType As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtInstruNo As TextBox
    Friend WithEvents radioInstruCHQ As RadioButton
    Friend WithEvents radioInstruNA As RadioButton
    Friend WithEvents Label22 As Label
    Friend WithEvents radioInstruDD As RadioButton
    Friend WithEvents Label25 As Label
    Friend WithEvents numGross As NumericUpDown
    Friend WithEvents numDiscount As NumericUpDown
    Friend WithEvents numNet As NumericUpDown
    Friend WithEvents numCash As NumericUpDown
    Friend WithEvents numCard As NumericUpDown
    Friend WithEvents numBank As NumericUpDown
    Friend WithEvents numCredit As NumericUpDown
    Friend WithEvents numSuppCredit As NumericUpDown
    Friend WithEvents Label30 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label40 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents numQtyPiece As NumericUpDown
    Friend WithEvents numQtyStrip As NumericUpDown
    Friend WithEvents numQtyPack As NumericUpDown
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents cmbItemName As ComboBox
    Friend WithEvents Label34 As Label
    Friend WithEvents btnRemove As Button
    Friend WithEvents txtBatchCode As TextBox
    Friend WithEvents dateInvoiceDate As DateTimePicker
    Friend WithEvents txtInvoiceNo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents numFreePiece As NumericUpDown
    Friend WithEvents numFreeStrip As NumericUpDown
    Friend WithEvents numFreePack As NumericUpDown
    Friend WithEvents Label12 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dateExpiry As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents numED As NumericUpDown
    Friend WithEvents btnNewItem As Button
    Friend WithEvents Label17 As Label
    Friend WithEvents numIGST As NumericUpDown
    Friend WithEvents Label10 As Label
    Friend WithEvents numSGST As NumericUpDown
    Friend WithEvents Label16 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents numCGST As NumericUpDown
    Friend WithEvents Timer1 As Timer
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents cmbSuppName As ComboBox
    Friend WithEvents cmbSuppID As ComboBox
    Friend WithEvents btnNewSupp As Button
    Friend WithEvents Label29 As Label
    Friend WithEvents txtSuppEmail As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents txtSuppNo As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents ItemCode As DataGridViewTextBoxColumn
    Friend WithEvents ItemName As DataGridViewTextBoxColumn
    Friend WithEvents BatchCode As DataGridViewTextBoxColumn
    Friend WithEvents SupplierID As DataGridViewTextBoxColumn
    Friend WithEvents Supplier As DataGridViewTextBoxColumn
    Friend WithEvents iDate As DataGridViewTextBoxColumn
    Friend WithEvents Expiry As DataGridViewTextBoxColumn
    Friend WithEvents PackQ As DataGridViewTextBoxColumn
    Friend WithEvents StripQ As DataGridViewTextBoxColumn
    Friend WithEvents PieceQ As DataGridViewTextBoxColumn
    Friend WithEvents FreePack As DataGridViewTextBoxColumn
    Friend WithEvents FreeStrip As DataGridViewTextBoxColumn
    Friend WithEvents FreePiece As DataGridViewTextBoxColumn
    Friend WithEvents MRPPack As DataGridViewTextBoxColumn
    Friend WithEvents MRPStrip As DataGridViewTextBoxColumn
    Friend WithEvents MRPPiece As DataGridViewTextBoxColumn
    Friend WithEvents PRPack As DataGridViewTextBoxColumn
    Friend WithEvents PRStrip As DataGridViewTextBoxColumn
    Friend WithEvents PRPiece As DataGridViewTextBoxColumn
    Friend WithEvents Discount As DataGridViewTextBoxColumn
    Friend WithEvents CGST As DataGridViewTextBoxColumn
    Friend WithEvents SGST As DataGridViewTextBoxColumn
    Friend WithEvents IGST As DataGridViewTextBoxColumn
    Friend WithEvents ED As DataGridViewTextBoxColumn
    Friend WithEvents Amt As DataGridViewTextBoxColumn
    Friend WithEvents numPrStrip As NumericUpDown
    Friend WithEvents numPrPack As NumericUpDown
    Friend WithEvents numPrPiece As NumericUpDown
    Friend WithEvents numMrpPiece As NumericUpDown
    Friend WithEvents numMrpStrip As NumericUpDown
    Friend WithEvents numMrpPack As NumericUpDown
    Friend WithEvents txtItemCode As TextBox
    Friend WithEvents chkInterState As CheckBox
End Class
