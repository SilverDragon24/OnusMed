<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainScreen
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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnH1Filter = New System.Windows.Forms.Button()
        Me.btnSchedPurchase = New System.Windows.Forms.Button()
        Me.btnGSTR3B = New System.Windows.Forms.Button()
        Me.btnGSTReport = New System.Windows.Forms.Button()
        Me.btnCreditReport = New System.Windows.Forms.Button()
        Me.btnStockReport = New System.Windows.Forms.Button()
        Me.btnPretReport = New System.Windows.Forms.Button()
        Me.btnSalesReport = New System.Windows.Forms.Button()
        Me.btnPurchaseReport = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnLookup = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.btnPurchaseOrder = New System.Windows.Forms.Button()
        Me.btnSret = New System.Windows.Forms.Button()
        Me.btnPret = New System.Windows.Forms.Button()
        Me.btnSale = New System.Windows.Forms.Button()
        Me.btnPurchase = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rtbNews = New System.Windows.Forms.RichTextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblTrial = New System.Windows.Forms.ToolStripStatusLabel()
        Me.progressTrial = New System.Windows.Forms.ToolStripProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPayCredit = New System.Windows.Forms.Button()
        Me.btnStockTransfer = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PictureBox1.Image = Global.OnusMed.My.Resources.Resources.OnusMed_Banner0
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(799, 107)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnH1Filter)
        Me.GroupBox1.Controls.Add(Me.btnSchedPurchase)
        Me.GroupBox1.Controls.Add(Me.btnGSTR3B)
        Me.GroupBox1.Controls.Add(Me.btnGSTReport)
        Me.GroupBox1.Controls.Add(Me.btnCreditReport)
        Me.GroupBox1.Controls.Add(Me.btnStockReport)
        Me.GroupBox1.Controls.Add(Me.btnPretReport)
        Me.GroupBox1.Controls.Add(Me.btnSalesReport)
        Me.GroupBox1.Controls.Add(Me.btnPurchaseReport)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.GroupBox1.Location = New System.Drawing.Point(539, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 304)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnH1Filter
        '
        Me.btnH1Filter.Location = New System.Drawing.Point(6, 211)
        Me.btnH1Filter.Name = "btnH1Filter"
        Me.btnH1Filter.Size = New System.Drawing.Size(117, 42)
        Me.btnH1Filter.TabIndex = 8
        Me.btnH1Filter.Text = "Schedule Filtered Sales Report"
        Me.btnH1Filter.UseVisualStyleBackColor = True
        '
        'btnSchedPurchase
        '
        Me.btnSchedPurchase.Location = New System.Drawing.Point(129, 163)
        Me.btnSchedPurchase.Name = "btnSchedPurchase"
        Me.btnSchedPurchase.Size = New System.Drawing.Size(117, 42)
        Me.btnSchedPurchase.TabIndex = 7
        Me.btnSchedPurchase.Text = "Schedule Filtered Purchase Report"
        Me.btnSchedPurchase.UseVisualStyleBackColor = True
        '
        'btnGSTR3B
        '
        Me.btnGSTR3B.Location = New System.Drawing.Point(6, 163)
        Me.btnGSTR3B.Name = "btnGSTR3B"
        Me.btnGSTR3B.Size = New System.Drawing.Size(117, 42)
        Me.btnGSTR3B.TabIndex = 6
        Me.btnGSTR3B.Text = "GSTR-3B"
        Me.btnGSTR3B.UseVisualStyleBackColor = True
        '
        'btnGSTReport
        '
        Me.btnGSTReport.Location = New System.Drawing.Point(129, 115)
        Me.btnGSTReport.Name = "btnGSTReport"
        Me.btnGSTReport.Size = New System.Drawing.Size(117, 42)
        Me.btnGSTReport.TabIndex = 5
        Me.btnGSTReport.Text = "GSTR-1"
        Me.btnGSTReport.UseVisualStyleBackColor = True
        '
        'btnCreditReport
        '
        Me.btnCreditReport.Location = New System.Drawing.Point(6, 115)
        Me.btnCreditReport.Name = "btnCreditReport"
        Me.btnCreditReport.Size = New System.Drawing.Size(117, 42)
        Me.btnCreditReport.TabIndex = 4
        Me.btnCreditReport.Text = "Credit Report"
        Me.btnCreditReport.UseVisualStyleBackColor = True
        '
        'btnStockReport
        '
        Me.btnStockReport.Location = New System.Drawing.Point(129, 67)
        Me.btnStockReport.Name = "btnStockReport"
        Me.btnStockReport.Size = New System.Drawing.Size(117, 42)
        Me.btnStockReport.TabIndex = 3
        Me.btnStockReport.Text = "Stock Report"
        Me.btnStockReport.UseVisualStyleBackColor = True
        '
        'btnPretReport
        '
        Me.btnPretReport.Location = New System.Drawing.Point(6, 67)
        Me.btnPretReport.Name = "btnPretReport"
        Me.btnPretReport.Size = New System.Drawing.Size(117, 42)
        Me.btnPretReport.TabIndex = 2
        Me.btnPretReport.Text = "Purchase Return Report"
        Me.btnPretReport.UseVisualStyleBackColor = True
        '
        'btnSalesReport
        '
        Me.btnSalesReport.Location = New System.Drawing.Point(129, 19)
        Me.btnSalesReport.Name = "btnSalesReport"
        Me.btnSalesReport.Size = New System.Drawing.Size(117, 42)
        Me.btnSalesReport.TabIndex = 1
        Me.btnSalesReport.Text = "Sales Report"
        Me.btnSalesReport.UseVisualStyleBackColor = True
        '
        'btnPurchaseReport
        '
        Me.btnPurchaseReport.Location = New System.Drawing.Point(6, 19)
        Me.btnPurchaseReport.Name = "btnPurchaseReport"
        Me.btnPurchaseReport.Size = New System.Drawing.Size(117, 42)
        Me.btnPurchaseReport.TabIndex = 0
        Me.btnPurchaseReport.Text = "Purchase Report"
        Me.btnPurchaseReport.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btnLookup)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.btnPurchaseOrder)
        Me.GroupBox2.Controls.Add(Me.btnSret)
        Me.GroupBox2.Controls.Add(Me.btnPret)
        Me.GroupBox2.Controls.Add(Me.btnSale)
        Me.GroupBox2.Controls.Add(Me.btnPurchase)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(0, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(284, 304)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "GroupBox2"
        '
        'btnLookup
        '
        Me.btnLookup.Location = New System.Drawing.Point(12, 163)
        Me.btnLookup.Name = "btnLookup"
        Me.btnLookup.Size = New System.Drawing.Size(127, 42)
        Me.btnLookup.TabIndex = 9
        Me.btnLookup.Text = "Inventory Lookup"
        Me.btnLookup.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(145, 115)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(127, 42)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Schedule OPD"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'btnPurchaseOrder
        '
        Me.btnPurchaseOrder.Location = New System.Drawing.Point(12, 115)
        Me.btnPurchaseOrder.Name = "btnPurchaseOrder"
        Me.btnPurchaseOrder.Size = New System.Drawing.Size(127, 42)
        Me.btnPurchaseOrder.TabIndex = 4
        Me.btnPurchaseOrder.Text = "Purchase Order"
        Me.btnPurchaseOrder.UseVisualStyleBackColor = True
        '
        'btnSret
        '
        Me.btnSret.Location = New System.Drawing.Point(145, 67)
        Me.btnSret.Name = "btnSret"
        Me.btnSret.Size = New System.Drawing.Size(127, 42)
        Me.btnSret.TabIndex = 3
        Me.btnSret.Text = "Sales Return"
        Me.btnSret.UseVisualStyleBackColor = True
        '
        'btnPret
        '
        Me.btnPret.Location = New System.Drawing.Point(12, 67)
        Me.btnPret.Name = "btnPret"
        Me.btnPret.Size = New System.Drawing.Size(127, 42)
        Me.btnPret.TabIndex = 2
        Me.btnPret.Text = "Purchase Return"
        Me.btnPret.UseVisualStyleBackColor = True
        '
        'btnSale
        '
        Me.btnSale.Location = New System.Drawing.Point(145, 19)
        Me.btnSale.Name = "btnSale"
        Me.btnSale.Size = New System.Drawing.Size(127, 42)
        Me.btnSale.TabIndex = 1
        Me.btnSale.Text = "Sale Entry"
        Me.btnSale.UseVisualStyleBackColor = True
        '
        'btnPurchase
        '
        Me.btnPurchase.Location = New System.Drawing.Point(12, 19)
        Me.btnPurchase.Name = "btnPurchase"
        Me.btnPurchase.Size = New System.Drawing.Size(127, 42)
        Me.btnPurchase.TabIndex = 0
        Me.btnPurchase.Text = "Purchase Entry"
        Me.btnPurchase.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rtbNews)
        Me.GroupBox3.Controls.Add(Me.btnRefresh)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.StatusStrip1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.btnPayCredit)
        Me.GroupBox3.Controls.Add(Me.btnStockTransfer)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(284, 107)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(255, 304)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'rtbNews
        '
        Me.rtbNews.Location = New System.Drawing.Point(6, 80)
        Me.rtbNews.Name = "rtbNews"
        Me.rtbNews.ReadOnly = True
        Me.rtbNews.Size = New System.Drawing.Size(242, 167)
        Me.rtbNews.TabIndex = 6
        Me.rtbNews.Text = ""
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(155, 253)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(93, 23)
        Me.btnRefresh.TabIndex = 5
        Me.btnRefresh.Text = "Refresh Feed"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Stock Alerts:"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblTrial, Me.progressTrial})
        Me.StatusStrip1.Location = New System.Drawing.Point(3, 279)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(249, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblTrial
        '
        Me.lblTrial.Name = "lblTrial"
        Me.lblTrial.Size = New System.Drawing.Size(96, 17)
        Me.lblTrial.Text = "Time Remaining:"
        '
        'progressTrial
        '
        Me.progressTrial.Name = "progressTrial"
        Me.progressTrial.Size = New System.Drawing.Size(100, 16)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'btnPayCredit
        '
        Me.btnPayCredit.Location = New System.Drawing.Point(130, 19)
        Me.btnPayCredit.Name = "btnPayCredit"
        Me.btnPayCredit.Size = New System.Drawing.Size(118, 42)
        Me.btnPayCredit.TabIndex = 1
        Me.btnPayCredit.Text = "Credit Payment"
        Me.btnPayCredit.UseVisualStyleBackColor = True
        '
        'btnStockTransfer
        '
        Me.btnStockTransfer.Location = New System.Drawing.Point(6, 19)
        Me.btnStockTransfer.Name = "btnStockTransfer"
        Me.btnStockTransfer.Size = New System.Drawing.Size(118, 42)
        Me.btnStockTransfer.TabIndex = 0
        Me.btnStockTransfer.Text = "Stock Transfer"
        Me.btnStockTransfer.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(145, 163)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 42)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Reprint Invoice"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(799, 411)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "OnusMed"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnPret As Button
    Friend WithEvents btnSale As Button
    Friend WithEvents btnPurchase As Button
    Friend WithEvents btnSret As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents btnPurchaseOrder As Button
    Friend WithEvents btnStockTransfer As Button
    Friend WithEvents btnPayCredit As Button
    Friend WithEvents btnSalesReport As Button
    Friend WithEvents btnPurchaseReport As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents lblTrial As ToolStripStatusLabel
    Friend WithEvents progressTrial As ToolStripProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents btnStockReport As Button
    Friend WithEvents btnPretReport As Button
    Friend WithEvents btnCreditReport As Button
    Friend WithEvents btnGSTR3B As Button
    Friend WithEvents btnGSTReport As Button
    Friend WithEvents btnH1Filter As Button
    Friend WithEvents btnSchedPurchase As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnLookup As Button
    Friend WithEvents rtbNews As RichTextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
