<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLeaveApp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLeaveApp))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbEmpId = New System.Windows.Forms.ComboBox
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAppNo = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.DtpFrom = New System.Windows.Forms.DateTimePicker
        Me.DtpTo = New System.Windows.Forms.DateTimePicker
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtDays = New System.Windows.Forms.TextBox
        Me.txtReason = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.ChkLND = New System.Windows.Forms.RadioButton
        Me.ChkIOD = New System.Windows.Forms.RadioButton
        Me.ChkLWP = New System.Windows.Forms.RadioButton
        Me.ChkCML = New System.Windows.Forms.RadioButton
        Me.ChkCO = New System.Windows.Forms.RadioButton
        Me.ChkRL = New System.Windows.Forms.RadioButton
        Me.ChkSPL = New System.Windows.Forms.RadioButton
        Me.ChkHPL = New System.Windows.Forms.RadioButton
        Me.ChkML = New System.Windows.Forms.RadioButton
        Me.ChkEL = New System.Windows.Forms.RadioButton
        Me.ChkCL = New System.Windows.Forms.RadioButton
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnApply = New System.Windows.Forms.Button
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        Me.Msfgrid = New AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
        Me.txtType = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.Msfgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(224, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Name"
        '
        'CmbEmpId
        '
        Me.CmbEmpId.FormattingEnabled = True
        Me.CmbEmpId.Location = New System.Drawing.Point(307, 6)
        Me.CmbEmpId.Name = "CmbEmpId"
        Me.CmbEmpId.Size = New System.Drawing.Size(100, 21)
        Me.CmbEmpId.TabIndex = 2
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(94, 36)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Application No"
        '
        'txtAppNo
        '
        Me.txtAppNo.Location = New System.Drawing.Point(94, 6)
        Me.txtAppNo.Name = "txtAppNo"
        Me.txtAppNo.Size = New System.Drawing.Size(100, 20)
        Me.txtAppNo.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "From Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 98)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "No Of Days"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 128)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Reason"
        '
        'DtpFrom
        '
        Me.DtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFrom.Location = New System.Drawing.Point(95, 71)
        Me.DtpFrom.Name = "DtpFrom"
        Me.DtpFrom.Size = New System.Drawing.Size(99, 20)
        Me.DtpFrom.TabIndex = 9
        '
        'DtpTo
        '
        Me.DtpTo.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpTo.Location = New System.Drawing.Point(309, 71)
        Me.DtpTo.Name = "DtpTo"
        Me.DtpTo.Size = New System.Drawing.Size(99, 20)
        Me.DtpTo.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(224, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "To Date"
        '
        'txtDays
        '
        Me.txtDays.Location = New System.Drawing.Point(94, 97)
        Me.txtDays.Name = "txtDays"
        Me.txtDays.Size = New System.Drawing.Size(100, 20)
        Me.txtDays.TabIndex = 12
        '
        'txtReason
        '
        Me.txtReason.Location = New System.Drawing.Point(95, 127)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(309, 94)
        Me.txtReason.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ChkLND)
        Me.GroupBox1.Controls.Add(Me.ChkIOD)
        Me.GroupBox1.Controls.Add(Me.ChkLWP)
        Me.GroupBox1.Controls.Add(Me.ChkCML)
        Me.GroupBox1.Controls.Add(Me.ChkCO)
        Me.GroupBox1.Controls.Add(Me.ChkRL)
        Me.GroupBox1.Controls.Add(Me.ChkSPL)
        Me.GroupBox1.Controls.Add(Me.ChkHPL)
        Me.GroupBox1.Controls.Add(Me.ChkML)
        Me.GroupBox1.Controls.Add(Me.ChkEL)
        Me.GroupBox1.Controls.Add(Me.ChkCL)
        Me.GroupBox1.Location = New System.Drawing.Point(412, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 214)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Leave Type"
        '
        'ChkLND
        '
        Me.ChkLND.AutoSize = True
        Me.ChkLND.Location = New System.Drawing.Point(19, 160)
        Me.ChkLND.Name = "ChkLND"
        Me.ChkLND.Size = New System.Drawing.Size(98, 17)
        Me.ChkLND.TabIndex = 23
        Me.ChkLND.TabStop = True
        Me.ChkLND.Text = "Leave Not Due"
        Me.ChkLND.UseVisualStyleBackColor = True
        '
        'ChkIOD
        '
        Me.ChkIOD.AutoSize = True
        Me.ChkIOD.Location = New System.Drawing.Point(18, 192)
        Me.ChkIOD.Name = "ChkIOD"
        Me.ChkIOD.Size = New System.Drawing.Size(97, 17)
        Me.ChkIOD.TabIndex = 22
        Me.ChkIOD.TabStop = True
        Me.ChkIOD.Text = "Injured on Duty"
        Me.ChkIOD.UseVisualStyleBackColor = True
        '
        'ChkLWP
        '
        Me.ChkLWP.AutoSize = True
        Me.ChkLWP.Location = New System.Drawing.Point(137, 160)
        Me.ChkLWP.Name = "ChkLWP"
        Me.ChkLWP.Size = New System.Drawing.Size(116, 17)
        Me.ChkLWP.TabIndex = 21
        Me.ChkLWP.TabStop = True
        Me.ChkLWP.Text = "Leave Without Pay"
        Me.ChkLWP.UseVisualStyleBackColor = True
        '
        'ChkCML
        '
        Me.ChkCML.AutoSize = True
        Me.ChkCML.Location = New System.Drawing.Point(137, 88)
        Me.ChkCML.Name = "ChkCML"
        Me.ChkCML.Size = New System.Drawing.Size(104, 17)
        Me.ChkCML.TabIndex = 20
        Me.ChkCML.TabStop = True
        Me.ChkCML.Text = "Commuted leave"
        Me.ChkCML.UseVisualStyleBackColor = True
        '
        'ChkCO
        '
        Me.ChkCO.AutoSize = True
        Me.ChkCO.Location = New System.Drawing.Point(137, 125)
        Me.ChkCO.Name = "ChkCO"
        Me.ChkCO.Size = New System.Drawing.Size(142, 17)
        Me.ChkCO.TabIndex = 19
        Me.ChkCO.TabStop = True
        Me.ChkCO.Text = "Compensatory Off Leave"
        Me.ChkCO.UseVisualStyleBackColor = True
        '
        'ChkRL
        '
        Me.ChkRL.AutoSize = True
        Me.ChkRL.Location = New System.Drawing.Point(18, 125)
        Me.ChkRL.Name = "ChkRL"
        Me.ChkRL.Size = New System.Drawing.Size(111, 17)
        Me.ChkRL.TabIndex = 18
        Me.ChkRL.TabStop = True
        Me.ChkRL.Text = "Restricted Holiday"
        Me.ChkRL.UseVisualStyleBackColor = True
        '
        'ChkSPL
        '
        Me.ChkSPL.AutoSize = True
        Me.ChkSPL.Location = New System.Drawing.Point(137, 59)
        Me.ChkSPL.Name = "ChkSPL"
        Me.ChkSPL.Size = New System.Drawing.Size(93, 17)
        Me.ChkSPL.TabIndex = 17
        Me.ChkSPL.TabStop = True
        Me.ChkSPL.Text = "Special Leave"
        Me.ChkSPL.UseVisualStyleBackColor = True
        '
        'ChkHPL
        '
        Me.ChkHPL.AutoSize = True
        Me.ChkHPL.Location = New System.Drawing.Point(18, 93)
        Me.ChkHPL.Name = "ChkHPL"
        Me.ChkHPL.Size = New System.Drawing.Size(98, 17)
        Me.ChkHPL.TabIndex = 16
        Me.ChkHPL.TabStop = True
        Me.ChkHPL.Text = "Half Pay Leave"
        Me.ChkHPL.UseVisualStyleBackColor = True
        '
        'ChkML
        '
        Me.ChkML.AutoSize = True
        Me.ChkML.Location = New System.Drawing.Point(19, 57)
        Me.ChkML.Name = "ChkML"
        Me.ChkML.Size = New System.Drawing.Size(101, 17)
        Me.ChkML.TabIndex = 15
        Me.ChkML.TabStop = True
        Me.ChkML.Text = "Maternity Leave"
        Me.ChkML.UseVisualStyleBackColor = True
        '
        'ChkEL
        '
        Me.ChkEL.AutoSize = True
        Me.ChkEL.Location = New System.Drawing.Point(137, 29)
        Me.ChkEL.Name = "ChkEL"
        Me.ChkEL.Size = New System.Drawing.Size(92, 17)
        Me.ChkEL.TabIndex = 14
        Me.ChkEL.TabStop = True
        Me.ChkEL.Text = "Earned Leave"
        Me.ChkEL.UseVisualStyleBackColor = True
        '
        'ChkCL
        '
        Me.ChkCL.AutoSize = True
        Me.ChkCL.Location = New System.Drawing.Point(18, 27)
        Me.ChkCL.Name = "ChkCL"
        Me.ChkCL.Size = New System.Drawing.Size(90, 17)
        Me.ChkCL.TabIndex = 12
        Me.ChkCL.TabStop = True
        Me.ChkCL.Text = "Casual Leave"
        Me.ChkCL.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(183, 227)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(75, 23)
        Me.BtnNew.TabIndex = 15
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnApply
        '
        Me.BtnApply.Location = New System.Drawing.Point(278, 227)
        Me.BtnApply.Name = "BtnApply"
        Me.BtnApply.Size = New System.Drawing.Size(75, 23)
        Me.BtnApply.TabIndex = 16
        Me.BtnApply.Text = "Apply"
        Me.BtnApply.UseVisualStyleBackColor = True
        '
        'BtnEdit
        '
        Me.BtnEdit.Location = New System.Drawing.Point(376, 227)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(75, 23)
        Me.BtnEdit.TabIndex = 17
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(474, 227)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 18
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(630, 391)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 19
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'Msfgrid
        '
        Me.Msfgrid.DataSource = Nothing
        Me.Msfgrid.Location = New System.Drawing.Point(12, 256)
        Me.Msfgrid.Name = "Msfgrid"
        Me.Msfgrid.OcxState = CType(resources.GetObject("Msfgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Msfgrid.Size = New System.Drawing.Size(693, 129)
        Me.Msfgrid.TabIndex = 20
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(307, 34)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(100, 20)
        Me.txtType.TabIndex = 22
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(222, 39)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Designation type"
        '
        'FrmLeaveApp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 418)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Msfgrid)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnApply)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.txtDays)
        Me.Controls.Add(Me.DtpTo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DtpFrom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtAppNo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.CmbEmpId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLeaveApp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leave Application"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Msfgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbEmpId As System.Windows.Forms.ComboBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAppNo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DtpFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDays As System.Windows.Forms.TextBox
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnApply As System.Windows.Forms.Button
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents Msfgrid As AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
    Friend WithEvents ChkML As System.Windows.Forms.RadioButton
    Friend WithEvents ChkEL As System.Windows.Forms.RadioButton
    Friend WithEvents ChkCL As System.Windows.Forms.RadioButton
    Friend WithEvents ChkLND As System.Windows.Forms.RadioButton
    Friend WithEvents ChkIOD As System.Windows.Forms.RadioButton
    Friend WithEvents ChkLWP As System.Windows.Forms.RadioButton
    Friend WithEvents ChkCML As System.Windows.Forms.RadioButton
    Friend WithEvents ChkCO As System.Windows.Forms.RadioButton
    Friend WithEvents ChkRL As System.Windows.Forms.RadioButton
    Friend WithEvents ChkSPL As System.Windows.Forms.RadioButton
    Friend WithEvents ChkHPL As System.Windows.Forms.RadioButton
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
