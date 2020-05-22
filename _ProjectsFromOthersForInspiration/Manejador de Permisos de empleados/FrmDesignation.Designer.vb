<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDesignation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDesignation))
        Me.DesId = New System.Windows.Forms.Label
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog
        Me.TxtDesName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtDesdesc = New System.Windows.Forms.TextBox
        Me.BtnAdd = New System.Windows.Forms.Button
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnModify = New System.Windows.Forms.Button
        Me.BtnNew = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        Me.MsfGrid = New AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
        CType(Me.MsfGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DesId
        '
        Me.DesId.AutoSize = True
        Me.DesId.Location = New System.Drawing.Point(12, 19)
        Me.DesId.Name = "DesId"
        Me.DesId.Size = New System.Drawing.Size(63, 13)
        Me.DesId.TabIndex = 0
        Me.DesId.Text = "Designation"
        '
        'FolderBrowserDialog1
        '
        '
        'TxtDesName
        '
        Me.TxtDesName.Location = New System.Drawing.Point(83, 16)
        Me.TxtDesName.Name = "TxtDesName"
        Me.TxtDesName.Size = New System.Drawing.Size(104, 20)
        Me.TxtDesName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Description"
        '
        'TxtDesdesc
        '
        Me.TxtDesdesc.Location = New System.Drawing.Point(83, 42)
        Me.TxtDesdesc.Name = "TxtDesdesc"
        Me.TxtDesdesc.Size = New System.Drawing.Size(104, 20)
        Me.TxtDesdesc.TabIndex = 3
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(18, 75)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(57, 22)
        Me.BtnAdd.TabIndex = 4
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnDelete
        '
        Me.BtnDelete.Location = New System.Drawing.Point(83, 103)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(54, 25)
        Me.BtnDelete.TabIndex = 5
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnModify
        '
        Me.BtnModify.Location = New System.Drawing.Point(20, 103)
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.Size = New System.Drawing.Size(57, 25)
        Me.BtnModify.TabIndex = 6
        Me.BtnModify.Text = "Modify"
        Me.BtnModify.UseVisualStyleBackColor = True
        '
        'BtnNew
        '
        Me.BtnNew.Location = New System.Drawing.Point(83, 75)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(54, 23)
        Me.BtnNew.TabIndex = 7
        Me.BtnNew.Text = "New"
        Me.BtnNew.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(355, 135)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(57, 23)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'MsfGrid
        '
        Me.MsfGrid.DataSource = Nothing
        Me.MsfGrid.Location = New System.Drawing.Point(244, 12)
        Me.MsfGrid.Name = "MsfGrid"
        Me.MsfGrid.OcxState = CType(resources.GetObject("MsfGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.MsfGrid.Size = New System.Drawing.Size(168, 116)
        Me.MsfGrid.TabIndex = 9
        '
        'FrmDesignation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(434, 170)
        Me.Controls.Add(Me.MsfGrid)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.BtnModify)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.TxtDesdesc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDesName)
        Me.Controls.Add(Me.DesId)
        Me.Name = "FrmDesignation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDesignation"
        CType(Me.MsfGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DesId As System.Windows.Forms.Label
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TxtDesName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtDesdesc As System.Windows.Forms.TextBox
    Friend WithEvents BtnAdd As System.Windows.Forms.Button
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnModify As System.Windows.Forms.Button
    Friend WithEvents BtnNew As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
    Friend WithEvents MsfGrid As AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
End Class
