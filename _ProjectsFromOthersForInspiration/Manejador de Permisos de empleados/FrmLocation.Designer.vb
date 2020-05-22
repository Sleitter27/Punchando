<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLocation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLocation))
        Me.MsfGrid = New AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
        Me.BtnClose = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnModify = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.TxtFC = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.TxtLocation = New System.Windows.Forms.TextBox
        Me.DesId = New System.Windows.Forms.Label
        CType(Me.MsfGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MsfGrid
        '
        Me.MsfGrid.DataSource = Nothing
        Me.MsfGrid.Location = New System.Drawing.Point(9, 62)
        Me.MsfGrid.Name = "MsfGrid"
        Me.MsfGrid.OcxState = CType(resources.GetObject("MsfGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MsfGrid.Size = New System.Drawing.Size(191, 116)
        Me.MsfGrid.TabIndex = 19
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(206, 155)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(57, 23)
        Me.BtnClose.TabIndex = 18
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(207, 5)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(57, 23)
        Me.BtnNew.TabIndex = 17
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnModify
        '
        Me.BtnModify.Location = New System.Drawing.Point(206, 89)
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.Size = New System.Drawing.Size(57, 25)
        Me.BtnModify.TabIndex = 16
        Me.BtnModify.Text = "Modify"
        Me.BtnModify.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(207, 60)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(57, 25)
        Me.BtnDelete.TabIndex = 15
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(207, 34)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(57, 22)
        Me.BtnAdd.TabIndex = 14
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'TxtFC
        '
        Me.TxtFC.Location = New System.Drawing.Point(97, 32)
        Me.TxtFC.Name = "TxtFC"
        Me.TxtFC.Size = New System.Drawing.Size(104, 20)
        Me.TxtFC.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Power Fixed Cost"
        '
        'FolderBrowserDialog1
        '
        '
        'TxtLocation
        '
        Me.TxtLocation.Location = New System.Drawing.Point(97, 5)
        Me.TxtLocation.Name = "TxtLocation"
        Me.TxtLocation.Size = New System.Drawing.Size(104, 20)
        Me.TxtLocation.TabIndex = 11
        '
        'DesId
        '
        Me.DesId.AutoSize = True
        Me.DesId.Location = New System.Drawing.Point(4, 8)
        Me.DesId.Name = "DesId"
        Me.DesId.Size = New System.Drawing.Size(48, 13)
        Me.DesId.TabIndex = 10
        Me.DesId.Text = "Location"
        '
        'FrmLocation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 185)
        Me.Controls.Add(Me.MsfGrid)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.BtnModify)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtFC)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtLocation)
        Me.Controls.Add(Me.DesId)
        Me.Name = "FrmLocation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Location Details"
        CType(Me.MsfGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MsfGrid As AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnModify As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents TxtFC As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TxtLocation As System.Windows.Forms.TextBox
    Friend WithEvents DesId As System.Windows.Forms.Label
End Class
