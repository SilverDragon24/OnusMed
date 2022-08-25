<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreditPayment
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbPatID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnGetPatCredit = New System.Windows.Forms.Button()
        Me.numPatCredit = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numPatCash = New System.Windows.Forms.NumericUpDown()
        Me.radioPatNA = New System.Windows.Forms.RadioButton()
        Me.radioPatCHQ = New System.Windows.Forms.RadioButton()
        Me.radioPatDD = New System.Windows.Forms.RadioButton()
        Me.numPatBank = New System.Windows.Forms.NumericUpDown()
        Me.txtPatInstru = New System.Windows.Forms.TextBox()
        Me.numPatCard = New System.Windows.Forms.NumericUpDown()
        Me.cmbPatCardType = New System.Windows.Forms.ComboBox()
        Me.numPatWallet = New System.Windows.Forms.NumericUpDown()
        Me.txtPatWalletRem = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnPatPay = New System.Windows.Forms.Button()
        Me.btnSuppPay = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbSuppCardType = New System.Windows.Forms.ComboBox()
        Me.numSuppCard = New System.Windows.Forms.NumericUpDown()
        Me.txtSuppInstru = New System.Windows.Forms.TextBox()
        Me.numSuppBank = New System.Windows.Forms.NumericUpDown()
        Me.radioSuppDD = New System.Windows.Forms.RadioButton()
        Me.radioSuppCHQ = New System.Windows.Forms.RadioButton()
        Me.radioSuppNA = New System.Windows.Forms.RadioButton()
        Me.numSuppCash = New System.Windows.Forms.NumericUpDown()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.numSuppCredit = New System.Windows.Forms.NumericUpDown()
        Me.btnGetSuppCredit = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbSuppID = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.numPatCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPatCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPatBank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPatCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPatWallet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSuppCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSuppBank, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSuppCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSuppCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPatPay)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPatWalletRem)
        Me.GroupBox1.Controls.Add(Me.numPatWallet)
        Me.GroupBox1.Controls.Add(Me.cmbPatCardType)
        Me.GroupBox1.Controls.Add(Me.numPatCard)
        Me.GroupBox1.Controls.Add(Me.txtPatInstru)
        Me.GroupBox1.Controls.Add(Me.numPatBank)
        Me.GroupBox1.Controls.Add(Me.radioPatDD)
        Me.GroupBox1.Controls.Add(Me.radioPatCHQ)
        Me.GroupBox1.Controls.Add(Me.radioPatNA)
        Me.GroupBox1.Controls.Add(Me.numPatCash)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.numPatCredit)
        Me.GroupBox1.Controls.Add(Me.btnGetPatCredit)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbPatID)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 366)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Patient Credit"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbSuppID)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.btnGetSuppCredit)
        Me.GroupBox2.Controls.Add(Me.numSuppCredit)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.numSuppCash)
        Me.GroupBox2.Controls.Add(Me.radioSuppNA)
        Me.GroupBox2.Controls.Add(Me.radioSuppCHQ)
        Me.GroupBox2.Controls.Add(Me.radioSuppDD)
        Me.GroupBox2.Controls.Add(Me.numSuppBank)
        Me.GroupBox2.Controls.Add(Me.txtSuppInstru)
        Me.GroupBox2.Controls.Add(Me.numSuppCard)
        Me.GroupBox2.Controls.Add(Me.cmbSuppCardType)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.btnSuppPay)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(241, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 366)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Supplier Credit"
        '
        'cmbPatID
        '
        Me.cmbPatID.FormattingEnabled = True
        Me.cmbPatID.Location = New System.Drawing.Point(75, 22)
        Me.cmbPatID.Name = "cmbPatID"
        Me.cmbPatID.Size = New System.Drawing.Size(121, 21)
        Me.cmbPatID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Patient ID:"
        '
        'btnGetPatCredit
        '
        Me.btnGetPatCredit.Location = New System.Drawing.Point(75, 49)
        Me.btnGetPatCredit.Name = "btnGetPatCredit"
        Me.btnGetPatCredit.Size = New System.Drawing.Size(75, 23)
        Me.btnGetPatCredit.TabIndex = 2
        Me.btnGetPatCredit.Text = "Get Credit"
        Me.btnGetPatCredit.UseVisualStyleBackColor = True
        '
        'numPatCredit
        '
        Me.numPatCredit.DecimalPlaces = 2
        Me.numPatCredit.Location = New System.Drawing.Point(75, 78)
        Me.numPatCredit.Maximum = New Decimal(New Integer() {1410065408, 0, 0, 0})
        Me.numPatCredit.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.numPatCredit.Name = "numPatCredit"
        Me.numPatCredit.Size = New System.Drawing.Size(121, 20)
        Me.numPatCredit.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Credit:"
        '
        'numPatCash
        '
        Me.numPatCash.DecimalPlaces = 2
        Me.numPatCash.Location = New System.Drawing.Point(103, 127)
        Me.numPatCash.Maximum = New Decimal(New Integer() {140065408, 0, 0, 0})
        Me.numPatCash.Name = "numPatCash"
        Me.numPatCash.Size = New System.Drawing.Size(120, 20)
        Me.numPatCash.TabIndex = 5
        '
        'radioPatNA
        '
        Me.radioPatNA.AutoSize = True
        Me.radioPatNA.Location = New System.Drawing.Point(78, 151)
        Me.radioPatNA.Name = "radioPatNA"
        Me.radioPatNA.Size = New System.Drawing.Size(45, 17)
        Me.radioPatNA.TabIndex = 6
        Me.radioPatNA.TabStop = True
        Me.radioPatNA.Text = "N/A"
        Me.radioPatNA.UseVisualStyleBackColor = True
        '
        'radioPatCHQ
        '
        Me.radioPatCHQ.AutoSize = True
        Me.radioPatCHQ.Location = New System.Drawing.Point(129, 151)
        Me.radioPatCHQ.Name = "radioPatCHQ"
        Me.radioPatCHQ.Size = New System.Drawing.Size(48, 17)
        Me.radioPatCHQ.TabIndex = 7
        Me.radioPatCHQ.TabStop = True
        Me.radioPatCHQ.Text = "CHQ"
        Me.radioPatCHQ.UseVisualStyleBackColor = True
        '
        'radioPatDD
        '
        Me.radioPatDD.AutoSize = True
        Me.radioPatDD.Location = New System.Drawing.Point(183, 151)
        Me.radioPatDD.Name = "radioPatDD"
        Me.radioPatDD.Size = New System.Drawing.Size(41, 17)
        Me.radioPatDD.TabIndex = 8
        Me.radioPatDD.TabStop = True
        Me.radioPatDD.Text = "DD"
        Me.radioPatDD.UseVisualStyleBackColor = True
        '
        'numPatBank
        '
        Me.numPatBank.DecimalPlaces = 2
        Me.numPatBank.Location = New System.Drawing.Point(103, 174)
        Me.numPatBank.Maximum = New Decimal(New Integer() {1410065408, 0, 0, 0})
        Me.numPatBank.Name = "numPatBank"
        Me.numPatBank.Size = New System.Drawing.Size(120, 20)
        Me.numPatBank.TabIndex = 9
        '
        'txtPatInstru
        '
        Me.txtPatInstru.Location = New System.Drawing.Point(103, 200)
        Me.txtPatInstru.Name = "txtPatInstru"
        Me.txtPatInstru.Size = New System.Drawing.Size(121, 20)
        Me.txtPatInstru.TabIndex = 10
        '
        'numPatCard
        '
        Me.numPatCard.DecimalPlaces = 2
        Me.numPatCard.Location = New System.Drawing.Point(103, 226)
        Me.numPatCard.Maximum = New Decimal(New Integer() {1410065408, 0, 0, 0})
        Me.numPatCard.Name = "numPatCard"
        Me.numPatCard.Size = New System.Drawing.Size(120, 20)
        Me.numPatCard.TabIndex = 11
        '
        'cmbPatCardType
        '
        Me.cmbPatCardType.FormattingEnabled = True
        Me.cmbPatCardType.Location = New System.Drawing.Point(103, 252)
        Me.cmbPatCardType.Name = "cmbPatCardType"
        Me.cmbPatCardType.Size = New System.Drawing.Size(121, 21)
        Me.cmbPatCardType.TabIndex = 12
        '
        'numPatWallet
        '
        Me.numPatWallet.DecimalPlaces = 2
        Me.numPatWallet.Location = New System.Drawing.Point(103, 279)
        Me.numPatWallet.Maximum = New Decimal(New Integer() {1410065408, 0, 0, 0})
        Me.numPatWallet.Name = "numPatWallet"
        Me.numPatWallet.Size = New System.Drawing.Size(120, 20)
        Me.numPatWallet.TabIndex = 13
        '
        'txtPatWalletRem
        '
        Me.txtPatWalletRem.Location = New System.Drawing.Point(103, 305)
        Me.txtPatWalletRem.Name = "txtPatWalletRem"
        Me.txtPatWalletRem.Size = New System.Drawing.Size(121, 20)
        Me.txtPatWalletRem.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cash:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Bank:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 203)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "CHQ/DD No.:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Card:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 255)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Card Type:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 281)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Wallet:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 308)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(85, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Wallet Remarks:"
        '
        'btnPatPay
        '
        Me.btnPatPay.Location = New System.Drawing.Point(103, 331)
        Me.btnPatPay.Name = "btnPatPay"
        Me.btnPatPay.Size = New System.Drawing.Size(75, 23)
        Me.btnPatPay.TabIndex = 22
        Me.btnPatPay.Text = "Pay"
        Me.btnPatPay.UseVisualStyleBackColor = True
        '
        'btnSuppPay
        '
        Me.btnSuppPay.Location = New System.Drawing.Point(97, 279)
        Me.btnSuppPay.Name = "btnSuppPay"
        Me.btnSuppPay.Size = New System.Drawing.Size(75, 23)
        Me.btnSuppPay.TabIndex = 45
        Me.btnSuppPay.Text = "Pay"
        Me.btnSuppPay.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 255)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(59, 13)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "Card Type:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 228)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "Card:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 203)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "CHQ/DD No.:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 176)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(35, 13)
        Me.Label13.TabIndex = 39
        Me.Label13.Text = "Bank:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 127)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(34, 13)
        Me.Label14.TabIndex = 38
        Me.Label14.Text = "Cash:"
        '
        'cmbSuppCardType
        '
        Me.cmbSuppCardType.FormattingEnabled = True
        Me.cmbSuppCardType.Location = New System.Drawing.Point(97, 252)
        Me.cmbSuppCardType.Name = "cmbSuppCardType"
        Me.cmbSuppCardType.Size = New System.Drawing.Size(121, 21)
        Me.cmbSuppCardType.TabIndex = 35
        '
        'numSuppCard
        '
        Me.numSuppCard.DecimalPlaces = 2
        Me.numSuppCard.Location = New System.Drawing.Point(97, 226)
        Me.numSuppCard.Maximum = New Decimal(New Integer() {1410065408, 0, 0, 0})
        Me.numSuppCard.Name = "numSuppCard"
        Me.numSuppCard.Size = New System.Drawing.Size(120, 20)
        Me.numSuppCard.TabIndex = 34
        '
        'txtSuppInstru
        '
        Me.txtSuppInstru.Location = New System.Drawing.Point(97, 200)
        Me.txtSuppInstru.Name = "txtSuppInstru"
        Me.txtSuppInstru.Size = New System.Drawing.Size(121, 20)
        Me.txtSuppInstru.TabIndex = 33
        '
        'numSuppBank
        '
        Me.numSuppBank.DecimalPlaces = 2
        Me.numSuppBank.Location = New System.Drawing.Point(97, 174)
        Me.numSuppBank.Maximum = New Decimal(New Integer() {1410065408, 0, 0, 0})
        Me.numSuppBank.Name = "numSuppBank"
        Me.numSuppBank.Size = New System.Drawing.Size(121, 20)
        Me.numSuppBank.TabIndex = 32
        '
        'radioSuppDD
        '
        Me.radioSuppDD.AutoSize = True
        Me.radioSuppDD.Location = New System.Drawing.Point(177, 151)
        Me.radioSuppDD.Name = "radioSuppDD"
        Me.radioSuppDD.Size = New System.Drawing.Size(41, 17)
        Me.radioSuppDD.TabIndex = 31
        Me.radioSuppDD.TabStop = True
        Me.radioSuppDD.Text = "DD"
        Me.radioSuppDD.UseVisualStyleBackColor = True
        '
        'radioSuppCHQ
        '
        Me.radioSuppCHQ.AutoSize = True
        Me.radioSuppCHQ.Location = New System.Drawing.Point(123, 151)
        Me.radioSuppCHQ.Name = "radioSuppCHQ"
        Me.radioSuppCHQ.Size = New System.Drawing.Size(48, 17)
        Me.radioSuppCHQ.TabIndex = 30
        Me.radioSuppCHQ.TabStop = True
        Me.radioSuppCHQ.Text = "CHQ"
        Me.radioSuppCHQ.UseVisualStyleBackColor = True
        '
        'radioSuppNA
        '
        Me.radioSuppNA.AutoSize = True
        Me.radioSuppNA.Location = New System.Drawing.Point(72, 151)
        Me.radioSuppNA.Name = "radioSuppNA"
        Me.radioSuppNA.Size = New System.Drawing.Size(45, 17)
        Me.radioSuppNA.TabIndex = 29
        Me.radioSuppNA.TabStop = True
        Me.radioSuppNA.Text = "N/A"
        Me.radioSuppNA.UseVisualStyleBackColor = True
        '
        'numSuppCash
        '
        Me.numSuppCash.DecimalPlaces = 2
        Me.numSuppCash.Location = New System.Drawing.Point(97, 127)
        Me.numSuppCash.Maximum = New Decimal(New Integer() {1410065408, 0, 0, 0})
        Me.numSuppCash.Name = "numSuppCash"
        Me.numSuppCash.Size = New System.Drawing.Size(120, 20)
        Me.numSuppCash.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 80)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 13)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Credit:"
        '
        'numSuppCredit
        '
        Me.numSuppCredit.DecimalPlaces = 2
        Me.numSuppCredit.Location = New System.Drawing.Point(74, 78)
        Me.numSuppCredit.Maximum = New Decimal(New Integer() {1410065408, 0, 0, 0})
        Me.numSuppCredit.Minimum = New Decimal(New Integer() {-2147483648, 0, 0, -2147483648})
        Me.numSuppCredit.Name = "numSuppCredit"
        Me.numSuppCredit.Size = New System.Drawing.Size(120, 20)
        Me.numSuppCredit.TabIndex = 26
        '
        'btnGetSuppCredit
        '
        Me.btnGetSuppCredit.Location = New System.Drawing.Point(74, 49)
        Me.btnGetSuppCredit.Name = "btnGetSuppCredit"
        Me.btnGetSuppCredit.Size = New System.Drawing.Size(75, 23)
        Me.btnGetSuppCredit.TabIndex = 25
        Me.btnGetSuppCredit.Text = "Get Credit"
        Me.btnGetSuppCredit.UseVisualStyleBackColor = True
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 25)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(62, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "Supplier ID:"
        '
        'cmbSuppID
        '
        Me.cmbSuppID.FormattingEnabled = True
        Me.cmbSuppID.Location = New System.Drawing.Point(74, 22)
        Me.cmbSuppID.Name = "cmbSuppID"
        Me.cmbSuppID.Size = New System.Drawing.Size(121, 21)
        Me.cmbSuppID.TabIndex = 23
        '
        'Timer1
        '
        '
        'CreditPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(474, 366)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreditPayment"
        Me.Text = "Credit Payment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.numPatCredit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPatCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPatBank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPatCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPatWallet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSuppCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSuppBank, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSuppCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSuppCredit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnPatPay As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPatWalletRem As TextBox
    Friend WithEvents numPatWallet As NumericUpDown
    Friend WithEvents cmbPatCardType As ComboBox
    Friend WithEvents numPatCard As NumericUpDown
    Friend WithEvents txtPatInstru As TextBox
    Friend WithEvents numPatBank As NumericUpDown
    Friend WithEvents radioPatDD As RadioButton
    Friend WithEvents radioPatCHQ As RadioButton
    Friend WithEvents radioPatNA As RadioButton
    Friend WithEvents numPatCash As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents numPatCredit As NumericUpDown
    Friend WithEvents btnGetPatCredit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cmbPatID As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents numSuppCard As NumericUpDown
    Friend WithEvents cmbSuppCardType As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnSuppPay As Button
    Friend WithEvents txtSuppInstru As TextBox
    Friend WithEvents numSuppBank As NumericUpDown
    Friend WithEvents cmbSuppID As ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents btnGetSuppCredit As Button
    Friend WithEvents numSuppCredit As NumericUpDown
    Friend WithEvents Label15 As Label
    Friend WithEvents numSuppCash As NumericUpDown
    Friend WithEvents radioSuppNA As RadioButton
    Friend WithEvents radioSuppCHQ As RadioButton
    Friend WithEvents radioSuppDD As RadioButton
    Friend WithEvents Timer1 As Timer
End Class
