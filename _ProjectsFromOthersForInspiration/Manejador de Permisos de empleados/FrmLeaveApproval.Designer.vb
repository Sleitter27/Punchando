<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLeaveApproval
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLeaveApproval))
        Me.msfgrid = New AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAppId = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEmpName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmbStatus = New System.Windows.Forms.ComboBox
        Me.txtFrom = New System.Windows.Forms.TextBox
        Me.txtTo = New System.Windows.Forms.TextBox
        Me.txtReason = New System.Windows.Forms.TextBox
        Me.TxtType = New System.Windows.Forms.TextBox
        Me.BtnClear = New System.Windows.Forms.Button
        Me.BtnSave = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        CType(Me.msfgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'msfgrid
        '
        Me.msfgrid.DataSource = Nothing
        Me.msfgrid.Location = New System.Drawing.Point(5, 6)
        Me.msfgrid.Name = "msfgrid"
        Me.msfgrid.OcxState = CType(resources.GetObject("msfgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.msfgrid.Size = New System.Drawing.Size(469, 164)
        Me.msfgrid.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Application Id"
        '
        'txtAppId
        '
        Me.txtAppId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAppId.Location = New System.Drawing.Point(82, 176)
        Me.txtAppId.Name = "txtAppId"
        Me.txtAppId.Size = New System.Drawing.Size(122, 20)
        Me.txtAppId.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(221, 182)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Employee Name"
        '
        'txtEmpName
        '
        Me.txtEmpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpName.Location = New System.Drawing.Point(325, 176)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(130, 20)
        Me.txtEmpName.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "From "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(221, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(20, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "To"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(2, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Reason"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 277)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 279)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Status"
        '
        'CmbStatus
        '
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Items.AddRange(New Object() {"Approve", "Reject"})
        Me.CmbStatus.Location = New System.Drawing.Point(325, 279)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(130, 21)
        Me.CmbStatus.TabIndex = 10
        '
        'txtFrom
        '
        Me.txtFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFrom.Location = New System.Drawing.Point(82, 199)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(122, 20)
        Me.txtFrom.TabIndex = 11
        '
        'txtTo
        '
        Me.txtTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTo.Location = New System.Drawing.Point(325, 199)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(130, 20)
        Me.txtTo.TabIndex = 12
        '
        'txtReason
        '
        Me.txtReason.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReason.Location = New System.Drawing.Point(82, 222)
        Me.txtReason.Multiline = True
        Me.txtReason.Name = "txtReason"
        Me.txtReason.Size = New System.Drawing.Size(373, 53)
        Me.txtReason.TabIndex = 13
        '
        'TxtType
        '
        Me.TxtType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtType.Location = New System.Drawing.Point(82, 277)
        Me.TxtType.Name = "TxtType"
        Me.TxtType.Size = New System.Drawing.Size(122, 20)
        Me.TxtType.TabIndex = 14
        '
        'BtnClear
        '
        Me.BtnClear.Location = New System.Drawing.Point(8, 303)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(75, 23)
        Me.BtnClear.TabIndex = 15
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = True
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(210, 306)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(75, 23)
        Me.BtnSave.TabIndex = 16
        Me.BtnSave.Text = "Save"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(380, 306)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 17
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FrmLeaveApproval
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 333)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.TxtType)
        Me.Controls.Add(Me.txtReason)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.CmbStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAppId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.msfgrid)
        Me.Name = "FrmLeaveApproval"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Leave Approval"
        CType(Me.msfgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents msfgrid As AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAppId As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents txtReason As System.Windows.Forms.TextBox
    Friend WithEvents TxtType As System.Windows.Forms.TextBox
    Friend WithEvents BtnClear As System.Windows.Forms.Button
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
