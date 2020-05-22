<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPowerCon
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPowerCon))
        Me.Label1 = New System.Windows.Forms.Label
        Me.CmbQtrNo = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEmpId = New System.Windows.Forms.TextBox
        Me.txtEmpName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtFC = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtLocation = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCurrRdg = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtLastRdg = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtUnits = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtAmount = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtArrears = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbMonth = New System.Windows.Forms.ComboBox
        Me.cmbyear = New System.Windows.Forms.ComboBox
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnDel = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.MsfGrid = New AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
        CType(Me.MsfGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quarter No"
        '
        'CmbQtrNo
        '
        Me.CmbQtrNo.FormattingEnabled = True
        Me.CmbQtrNo.Location = New System.Drawing.Point(87, 14)
        Me.CmbQtrNo.Name = "CmbQtrNo"
        Me.CmbQtrNo.Size = New System.Drawing.Size(121, 21)
        Me.CmbQtrNo.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Employee Id"
        '
        'txtEmpId
        '
        Me.txtEmpId.Enabled = False
        Me.txtEmpId.Location = New System.Drawing.Point(87, 41)
        Me.txtEmpId.Name = "txtEmpId"
        Me.txtEmpId.Size = New System.Drawing.Size(121, 20)
        Me.txtEmpId.TabIndex = 3
        '
        'txtEmpName
        '
        Me.txtEmpName.Enabled = False
        Me.txtEmpName.Location = New System.Drawing.Point(87, 67)
        Me.txtEmpName.Name = "txtEmpName"
        Me.txtEmpName.Size = New System.Drawing.Size(121, 20)
        Me.txtEmpName.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Name"
        '
        'txtFC
        '
        Me.txtFC.Location = New System.Drawing.Point(314, 96)
        Me.txtFC.Name = "txtFC"
        Me.txtFC.Size = New System.Drawing.Size(121, 20)
        Me.txtFC.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(233, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Fixed Cost"
        '
        'txtLocation
        '
        Me.txtLocation.Enabled = False
        Me.txtLocation.Location = New System.Drawing.Point(87, 93)
        Me.txtLocation.Name = "txtLocation"
        Me.txtLocation.Size = New System.Drawing.Size(121, 20)
        Me.txtLocation.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Location"
        '
        'txtCurrRdg
        '
        Me.txtCurrRdg.Location = New System.Drawing.Point(314, 44)
        Me.txtCurrRdg.Name = "txtCurrRdg"
        Me.txtCurrRdg.Size = New System.Drawing.Size(121, 20)
        Me.txtCurrRdg.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(233, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Curr Reading"
        '
        'txtLastRdg
        '
        Me.txtLastRdg.Location = New System.Drawing.Point(314, 17)
        Me.txtLastRdg.Name = "txtLastRdg"
        Me.txtLastRdg.Size = New System.Drawing.Size(121, 20)
        Me.txtLastRdg.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(234, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "L Reading"
        '
        'TxtUnits
        '
        Me.TxtUnits.Location = New System.Drawing.Point(314, 70)
        Me.TxtUnits.Name = "TxtUnits"
        Me.TxtUnits.Size = New System.Drawing.Size(121, 20)
        Me.TxtUnits.TabIndex = 15
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(233, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(31, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Units"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(314, 148)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(121, 20)
        Me.txtAmount.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(232, 153)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Amount"
        '
        'txtArrears
        '
        Me.txtArrears.Location = New System.Drawing.Point(314, 122)
        Me.txtArrears.Name = "txtArrears"
        Me.txtArrears.Size = New System.Drawing.Size(121, 20)
        Me.txtArrears.TabIndex = 19
        Me.txtArrears.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(233, 125)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 13)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Arrears"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Month"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(12, 129)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Year"
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Location = New System.Drawing.Point(87, 146)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(121, 21)
        Me.cmbMonth.TabIndex = 22
        '
        'cmbyear
        '
        Me.cmbyear.FormattingEnabled = True
        Me.cmbyear.Location = New System.Drawing.Point(87, 119)
        Me.cmbyear.Name = "cmbyear"
        Me.cmbyear.Size = New System.Drawing.Size(121, 21)
        Me.cmbyear.TabIndex = 23
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(365, 174)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(70, 23)
        Me.BtnClose.TabIndex = 28
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Location = New System.Drawing.Point(248, 173)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(73, 23)
        Me.BtnDel.TabIndex = 26
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(128, 173)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(71, 23)
        Me.BtnAdd.TabIndex = 25
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(12, 174)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(71, 23)
        Me.BtnNew.TabIndex = 24
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'MsfGrid
        '
        Me.MsfGrid.DataSource = Nothing
        Me.MsfGrid.Location = New System.Drawing.Point(12, 203)
        Me.MsfGrid.Name = "MsfGrid"
        Me.MsfGrid.OcxState = CType(resources.GetObject("MsfGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MsfGrid.Size = New System.Drawing.Size(423, 160)
        Me.MsfGrid.TabIndex = 29
        '
        'FrmPowerCon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 375)
        Me.Controls.Add(Me.MsfGrid)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.cmbyear)
        Me.Controls.Add(Me.cmbMonth)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtArrears)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtUnits)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtCurrRdg)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtLastRdg)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtFC)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtLocation)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEmpName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtEmpId)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CmbQtrNo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmPowerCon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Power Consumption Record"
        CType(Me.MsfGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmbQtrNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEmpId As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFC As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtLocation As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCurrRdg As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLastRdg As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtUnits As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtArrears As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbyear As System.Windows.Forms.ComboBox
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnDel As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents MsfGrid As AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
End Class
