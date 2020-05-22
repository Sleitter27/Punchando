<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRatePerUnit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmRatePerUnit))
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFromUnit = New System.Windows.Forms.TextBox
        Me.txtRate = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtToUnit = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.MsfGrid = New AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnModify = New System.Windows.Forms.Button
        Me.BtnDel = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        CType(Me.MsfGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "From Unit"
        '
        'txtFromUnit
        '
        Me.txtFromUnit.Location = New System.Drawing.Point(76, 7)
        Me.txtFromUnit.Name = "txtFromUnit"
        Me.txtFromUnit.Size = New System.Drawing.Size(100, 20)
        Me.txtFromUnit.TabIndex = 1
        '
        'txtRate
        '
        Me.txtRate.Location = New System.Drawing.Point(76, 59)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 20)
        Me.txtRate.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Rate"
        '
        'txtToUnit
        '
        Me.txtToUnit.Location = New System.Drawing.Point(76, 33)
        Me.txtToUnit.Name = "txtToUnit"
        Me.txtToUnit.Size = New System.Drawing.Size(100, 20)
        Me.txtToUnit.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "To Unit"
        '
        'MsfGrid
        '
        Me.MsfGrid.DataSource = Nothing
        Me.MsfGrid.Location = New System.Drawing.Point(184, 10)
        Me.MsfGrid.Name = "MsfGrid"
        Me.MsfGrid.OcxState = CType(resources.GetObject("MsfGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MsfGrid.Size = New System.Drawing.Size(214, 69)
        Me.MsfGrid.TabIndex = 6
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(328, 85)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(70, 23)
        Me.BtnClose.TabIndex = 33
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnModify
        '
        Me.BtnModify.Location = New System.Drawing.Point(251, 85)
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.Size = New System.Drawing.Size(70, 23)
        Me.BtnModify.TabIndex = 32
        Me.BtnModify.Text = "Modify"
        Me.BtnModify.UseVisualStyleBackColor = True
        '
        'BtnDel
        '
        Me.BtnDel.Location = New System.Drawing.Point(170, 85)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(73, 23)
        Me.BtnDel.TabIndex = 31
        Me.BtnDel.Text = "Delete"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(91, 85)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(71, 23)
        Me.BtnAdd.TabIndex = 30
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(10, 85)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(71, 23)
        Me.BtnNew.TabIndex = 29
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'FrmRatePerUnit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 111)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnModify)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.MsfGrid)
        Me.Controls.Add(Me.txtToUnit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFromUnit)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmRatePerUnit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rate Per Unit Details"
        CType(Me.MsfGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFromUnit As System.Windows.Forms.TextBox
    Friend WithEvents txtRate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtToUnit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MsfGrid As AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnModify As System.Windows.Forms.Button
    Friend WithEvents BtnDel As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
End Class
