<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEmployee))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtEmpId = New System.Windows.Forms.TextBox
        Me.TxtEmpName = New System.Windows.Forms.TextBox
        Me.CmbDes = New System.Windows.Forms.ComboBox
        Me.CmbDept = New System.Windows.Forms.ComboBox
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnDel = New System.Windows.Forms.Button
        Me.BtnModify = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        Me.MsfGrid = New AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
        Me.Label5 = New System.Windows.Forms.Label
        Me.RdMale = New System.Windows.Forms.RadioButton
        Me.RdFemale = New System.Windows.Forms.RadioButton
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtQuarter = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmbLocation = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbType = New System.Windows.Forms.ComboBox
        CType(Me.MsfGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Employee Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Designation"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Department"
        '
        'TxtEmpId
        '
        Me.TxtEmpId.Location = New System.Drawing.Point(102, 9)
        Me.TxtEmpId.Name = "TxtEmpId"
        Me.TxtEmpId.Size = New System.Drawing.Size(109, 20)
        Me.TxtEmpId.TabIndex = 4
        '
        'TxtEmpName
        '
        Me.TxtEmpName.Location = New System.Drawing.Point(102, 32)
        Me.TxtEmpName.Name = "TxtEmpName"
        Me.TxtEmpName.Size = New System.Drawing.Size(109, 20)
        Me.TxtEmpName.TabIndex = 5
        '
        'CmbDes
        '
        Me.CmbDes.FormattingEnabled = True
        Me.CmbDes.Location = New System.Drawing.Point(102, 80)
        Me.CmbDes.Name = "CmbDes"
        Me.CmbDes.Size = New System.Drawing.Size(109, 21)
        Me.CmbDes.TabIndex = 6
        '
        'CmbDept
        '
        Me.CmbDept.FormattingEnabled = True
        Me.CmbDept.Location = New System.Drawing.Point(102, 107)
        Me.CmbDept.Name = "CmbDept"
        Me.CmbDept.Size = New System.Drawing.Size(109, 21)
        Me.CmbDept.TabIndex = 7
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(7, 203)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(71, 23)
        Me.BtnNew.TabIndex = 8
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(111, 203)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(71, 23)
        Me.BtnAdd.TabIndex = 9
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Location = New System.Drawing.Point(207, 205)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(73, 23)
        Me.BtnDel.TabIndex = 10
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnModify
        '
        Me.BtnModify.Location = New System.Drawing.Point(319, 203)
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.Size = New System.Drawing.Size(70, 23)
        Me.BtnModify.TabIndex = 11
        Me.BtnModify.Text = "Modify"
        Me.BtnModify.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(435, 203)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(70, 23)
        Me.BtnClose.TabIndex = 12
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'MsfGrid
        '
        Me.MsfGrid.DataSource = Nothing
        Me.MsfGrid.Location = New System.Drawing.Point(220, 9)
        Me.MsfGrid.Name = "MsfGrid"
        Me.MsfGrid.OcxState = CType(resources.GetObject("MsfGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MsfGrid.Size = New System.Drawing.Size(289, 190)
        Me.MsfGrid.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Gender"
        '
        'RdMale
        '
        Me.RdMale.AutoSize = True
        Me.RdMale.Checked = True
        Me.RdMale.Location = New System.Drawing.Point(105, 136)
        Me.RdMale.Name = "RdMale"
        Me.RdMale.Size = New System.Drawing.Size(48, 17)
        Me.RdMale.TabIndex = 15
        Me.RdMale.TabStop = True
        Me.RdMale.Text = "Male"
        Me.RdMale.UseVisualStyleBackColor = True
        '
        'RdFemale
        '
        Me.RdFemale.AutoSize = True
        Me.RdFemale.Location = New System.Drawing.Point(155, 135)
        Me.RdFemale.Name = "RdFemale"
        Me.RdFemale.Size = New System.Drawing.Size(59, 17)
        Me.RdFemale.TabIndex = 16
        Me.RdFemale.TabStop = True
        Me.RdFemale.Text = "Female"
        Me.RdFemale.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Quarter No"
        '
        'txtQuarter
        '
        Me.txtQuarter.Location = New System.Drawing.Point(102, 154)
        Me.txtQuarter.Name = "txtQuarter"
        Me.txtQuarter.Size = New System.Drawing.Size(109, 20)
        Me.txtQuarter.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 186)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Location"
        '
        'CmbLocation
        '
        Me.CmbLocation.FormattingEnabled = True
        Me.CmbLocation.Location = New System.Drawing.Point(102, 178)
        Me.CmbLocation.Name = "CmbLocation"
        Me.CmbLocation.Size = New System.Drawing.Size(109, 21)
        Me.CmbLocation.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Type"
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Items.AddRange(New Object() {"Executive", "Non-Executive"})
        Me.cmbType.Location = New System.Drawing.Point(102, 56)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(109, 21)
        Me.cmbType.TabIndex = 22
        '
        'FrmEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 231)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.CmbLocation)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtQuarter)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.RdFemale)
        Me.Controls.Add(Me.RdMale)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.MsfGrid)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnModify)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.CmbDept)
        Me.Controls.Add(Me.CmbDes)
        Me.Controls.Add(Me.TxtEmpName)
        Me.Controls.Add(Me.TxtEmpId)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmEmployee"
        CType(Me.MsfGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents CmbDes As System.Windows.Forms.ComboBox
    Friend WithEvents CmbDept As System.Windows.Forms.ComboBox
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnDel As System.Windows.Forms.Button
    Friend WithEvents BtnModify As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents MsfGrid As AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RdMale As System.Windows.Forms.RadioButton
    Friend WithEvents RdFemale As System.Windows.Forms.RadioButton
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtQuarter As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmbLocation As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
End Class
