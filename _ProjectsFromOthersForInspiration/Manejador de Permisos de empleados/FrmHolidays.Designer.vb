<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmHolidays
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHolidays))
        Me.MsfHolidays = New AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnModify = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.TxtDesc = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DtpDate = New System.Windows.Forms.DateTimePicker
        CType(Me.MsfHolidays, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MsfHolidays
        '
        Me.MsfHolidays.DataSource = Nothing
        Me.MsfHolidays.Location = New System.Drawing.Point(187, 2)
        Me.MsfHolidays.Name = "MsfHolidays"
        Me.MsfHolidays.OcxState = CType(resources.GetObject("MsfHolidays.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MsfHolidays.Size = New System.Drawing.Size(237, 114)
        Me.MsfHolidays.TabIndex = 19
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(349, 122)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 18
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnModify
        '
        Me.BtnModify.Location = New System.Drawing.Point(106, 93)
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.Size = New System.Drawing.Size(75, 23)
        Me.BtnModify.TabIndex = 17
        Me.BtnModify.Text = "Modify"
        Me.BtnModify.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(5, 93)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(74, 23)
        Me.BtnDelete.TabIndex = 16
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(106, 61)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(75, 23)
        Me.BtnAdd.TabIndex = 15
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(4, 61)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(75, 23)
        Me.BtnNew.TabIndex = 14
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'TxtDesc
        '
        Me.TxtDesc.Location = New System.Drawing.Point(81, 29)
        Me.TxtDesc.Name = "TxtDesc"
        Me.TxtDesc.Size = New System.Drawing.Size(100, 20)
        Me.TxtDesc.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Description"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Department Id"
        '
        'DtpDate
        '
        Me.DtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDate.Location = New System.Drawing.Point(82, 4)
        Me.DtpDate.Name = "DtpDate"
        Me.DtpDate.Size = New System.Drawing.Size(99, 20)
        Me.DtpDate.TabIndex = 20
        '
        'FrmHolidays
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 148)
        Me.Controls.Add(Me.DtpDate)
        Me.Controls.Add(Me.MsfHolidays)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnModify)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.TxtDesc)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmHolidays"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Holidays"
        CType(Me.MsfHolidays, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MsfHolidays As AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnModify As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents TxtDesc As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DtpDate As System.Windows.Forms.DateTimePicker
End Class
