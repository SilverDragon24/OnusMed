<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointment
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rtbProblem = New System.Windows.Forms.RichTextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.timeV = New System.Windows.Forms.DateTimePicker()
        Me.btnApprove = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dateV = New System.Windows.Forms.DateTimePicker()
        Me.chkSat = New System.Windows.Forms.CheckBox()
        Me.chkFri = New System.Windows.Forms.CheckBox()
        Me.chkThu = New System.Windows.Forms.CheckBox()
        Me.chkWed = New System.Windows.Forms.CheckBox()
        Me.chkTue = New System.Windows.Forms.CheckBox()
        Me.chkMon = New System.Windows.Forms.CheckBox()
        Me.chkSun = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSchedule = New System.Windows.Forms.Button()
        Me.cmbDocReg = New System.Windows.Forms.ComboBox()
        Me.cmbDocName = New System.Windows.Forms.ComboBox()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.cmbPatName = New System.Windows.Forms.ComboBox()
        Me.cmbPatId = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rtbProblem)
        Me.GroupBox1.Controls.Add(Me.txtAge)
        Me.GroupBox1.Controls.Add(Me.timeV)
        Me.GroupBox1.Controls.Add(Me.btnApprove)
        Me.GroupBox1.Controls.Add(Me.btnCancel)
        Me.GroupBox1.Controls.Add(Me.dateV)
        Me.GroupBox1.Controls.Add(Me.chkSat)
        Me.GroupBox1.Controls.Add(Me.chkFri)
        Me.GroupBox1.Controls.Add(Me.chkThu)
        Me.GroupBox1.Controls.Add(Me.chkWed)
        Me.GroupBox1.Controls.Add(Me.chkTue)
        Me.GroupBox1.Controls.Add(Me.chkMon)
        Me.GroupBox1.Controls.Add(Me.chkSun)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btnSchedule)
        Me.GroupBox1.Controls.Add(Me.cmbDocReg)
        Me.GroupBox1.Controls.Add(Me.cmbDocName)
        Me.GroupBox1.Controls.Add(Me.txtContact)
        Me.GroupBox1.Controls.Add(Me.cmbPatName)
        Me.GroupBox1.Controls.Add(Me.cmbPatId)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1010, 286)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(208, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Problem:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(29, 13)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "Age:"
        '
        'rtbProblem
        '
        Me.rtbProblem.Location = New System.Drawing.Point(288, 149)
        Me.rtbProblem.Multiline = False
        Me.rtbProblem.Name = "rtbProblem"
        Me.rtbProblem.Size = New System.Drawing.Size(121, 96)
        Me.rtbProblem.TabIndex = 30
        Me.rtbProblem.Text = ""
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(69, 149)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(121, 20)
        Me.txtAge.TabIndex = 29
        Me.txtAge.Text = "0"
        '
        'timeV
        '
        Me.timeV.CustomFormat = "HH:mm"
        Me.timeV.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.timeV.Location = New System.Drawing.Point(518, 59)
        Me.timeV.Name = "timeV"
        Me.timeV.Size = New System.Drawing.Size(92, 20)
        Me.timeV.TabIndex = 28
        '
        'btnApprove
        '
        Me.btnApprove.Location = New System.Drawing.Point(93, 257)
        Me.btnApprove.Name = "btnApprove"
        Me.btnApprove.Size = New System.Drawing.Size(75, 23)
        Me.btnApprove.TabIndex = 1
        Me.btnApprove.Text = "Approve"
        Me.btnApprove.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(174, 257)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 2
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dateV
        '
        Me.dateV.CustomFormat = "yyy-MMM-dd"
        Me.dateV.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dateV.Location = New System.Drawing.Point(412, 59)
        Me.dateV.Name = "dateV"
        Me.dateV.Size = New System.Drawing.Size(100, 20)
        Me.dateV.TabIndex = 27
        '
        'chkSat
        '
        Me.chkSat.AutoSize = True
        Me.chkSat.Enabled = False
        Me.chkSat.Location = New System.Drawing.Point(316, 50)
        Me.chkSat.Name = "chkSat"
        Me.chkSat.Size = New System.Drawing.Size(42, 17)
        Me.chkSat.TabIndex = 19
        Me.chkSat.Text = "Sat"
        Me.chkSat.UseVisualStyleBackColor = True
        '
        'chkFri
        '
        Me.chkFri.AutoSize = True
        Me.chkFri.Enabled = False
        Me.chkFri.Location = New System.Drawing.Point(273, 50)
        Me.chkFri.Name = "chkFri"
        Me.chkFri.Size = New System.Drawing.Size(37, 17)
        Me.chkFri.TabIndex = 18
        Me.chkFri.Text = "Fri"
        Me.chkFri.UseVisualStyleBackColor = True
        '
        'chkThu
        '
        Me.chkThu.AutoSize = True
        Me.chkThu.Enabled = False
        Me.chkThu.Location = New System.Drawing.Point(222, 50)
        Me.chkThu.Name = "chkThu"
        Me.chkThu.Size = New System.Drawing.Size(45, 17)
        Me.chkThu.TabIndex = 17
        Me.chkThu.Text = "Thu"
        Me.chkThu.UseVisualStyleBackColor = True
        '
        'chkWed
        '
        Me.chkWed.AutoSize = True
        Me.chkWed.Enabled = False
        Me.chkWed.Location = New System.Drawing.Point(167, 50)
        Me.chkWed.Name = "chkWed"
        Me.chkWed.Size = New System.Drawing.Size(45, 17)
        Me.chkWed.TabIndex = 16
        Me.chkWed.Text = "Tue"
        Me.chkWed.UseVisualStyleBackColor = True
        '
        'chkTue
        '
        Me.chkTue.AutoSize = True
        Me.chkTue.Enabled = False
        Me.chkTue.Location = New System.Drawing.Point(116, 50)
        Me.chkTue.Name = "chkTue"
        Me.chkTue.Size = New System.Drawing.Size(45, 17)
        Me.chkTue.TabIndex = 15
        Me.chkTue.Text = "Tue"
        Me.chkTue.UseVisualStyleBackColor = True
        '
        'chkMon
        '
        Me.chkMon.AutoSize = True
        Me.chkMon.Enabled = False
        Me.chkMon.Location = New System.Drawing.Point(63, 50)
        Me.chkMon.Name = "chkMon"
        Me.chkMon.Size = New System.Drawing.Size(47, 17)
        Me.chkMon.TabIndex = 14
        Me.chkMon.Text = "Mon"
        Me.chkMon.UseVisualStyleBackColor = True
        '
        'chkSun
        '
        Me.chkSun.AutoSize = True
        Me.chkSun.Enabled = False
        Me.chkSun.Location = New System.Drawing.Point(12, 50)
        Me.chkSun.Name = "chkSun"
        Me.chkSun.Size = New System.Drawing.Size(45, 17)
        Me.chkSun.TabIndex = 13
        Me.chkSun.Text = "Sun"
        Me.chkSun.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(434, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Phone No.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(208, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Patient Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Patient ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(364, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Doctor Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Doctor Registration No.:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(454, 257)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "New Patient"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(535, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnSchedule
        '
        Me.btnSchedule.Location = New System.Drawing.Point(12, 257)
        Me.btnSchedule.Name = "btnSchedule"
        Me.btnSchedule.Size = New System.Drawing.Size(75, 23)
        Me.btnSchedule.TabIndex = 5
        Me.btnSchedule.Text = "Schedule"
        Me.btnSchedule.UseVisualStyleBackColor = True
        '
        'cmbDocReg
        '
        Me.cmbDocReg.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbDocReg.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDocReg.Enabled = False
        Me.cmbDocReg.FormattingEnabled = True
        Me.cmbDocReg.Location = New System.Drawing.Point(133, 14)
        Me.cmbDocReg.Name = "cmbDocReg"
        Me.cmbDocReg.Size = New System.Drawing.Size(134, 21)
        Me.cmbDocReg.TabIndex = 4
        '
        'cmbDocName
        '
        Me.cmbDocName.FormattingEnabled = True
        Me.cmbDocName.Location = New System.Drawing.Point(443, 14)
        Me.cmbDocName.Name = "cmbDocName"
        Me.cmbDocName.Size = New System.Drawing.Size(167, 21)
        Me.cmbDocName.TabIndex = 3
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(498, 122)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(114, 20)
        Me.txtContact.TabIndex = 2
        '
        'cmbPatName
        '
        Me.cmbPatName.FormattingEnabled = True
        Me.cmbPatName.Location = New System.Drawing.Point(288, 122)
        Me.cmbPatName.Name = "cmbPatName"
        Me.cmbPatName.Size = New System.Drawing.Size(121, 21)
        Me.cmbPatName.TabIndex = 1
        '
        'cmbPatId
        '
        Me.cmbPatId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cmbPatId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPatId.FormattingEnabled = True
        Me.cmbPatId.Location = New System.Drawing.Point(69, 122)
        Me.cmbPatId.Name = "cmbPatId"
        Me.cmbPatId.Size = New System.Drawing.Size(121, 21)
        Me.cmbPatId.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(0, 286)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1010, 236)
        Me.DataGridView1.TabIndex = 0
        '
        'Appointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1010, 522)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Appointment"
        Me.Text = "Appointment"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkSun As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents btnSchedule As Button
    Friend WithEvents cmbDocReg As ComboBox
    Friend WithEvents cmbDocName As ComboBox
    Friend WithEvents txtContact As TextBox
    Friend WithEvents cmbPatName As ComboBox
    Friend WithEvents cmbPatId As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents rtbProblem As RichTextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents timeV As DateTimePicker
    Friend WithEvents btnApprove As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents dateV As DateTimePicker
    Friend WithEvents chkSat As CheckBox
    Friend WithEvents chkFri As CheckBox
    Friend WithEvents chkThu As CheckBox
    Friend WithEvents chkWed As CheckBox
    Friend WithEvents chkTue As CheckBox
    Friend WithEvents chkMon As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
End Class
