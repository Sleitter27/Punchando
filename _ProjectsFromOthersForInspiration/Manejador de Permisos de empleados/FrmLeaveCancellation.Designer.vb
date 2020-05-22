<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLeaveCancellation
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLeaveCancellation))
        Me.CmbEmpId = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Msfgrid = New AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
        Me.BtnDelete = New System.Windows.Forms.Button
        Me.BtnClose = New System.Windows.Forms.Button
        CType(Me.Msfgrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmbEmpId
        '
        Me.CmbEmpId.FormattingEnabled = True
        Me.CmbEmpId.Location = New System.Drawing.Point(95, 3)
        Me.CmbEmpId.Name = "CmbEmpId"
        Me.CmbEmpId.Size = New System.Drawing.Size(100, 21)
        Me.CmbEmpId.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Employee Id"
        '
        'Msfgrid
        '
        Me.Msfgrid.DataSource = Nothing
        Me.Msfgrid.Location = New System.Drawing.Point(12, 30)
        Me.Msfgrid.Name = "Msfgrid"
        Me.Msfgrid.OcxState = CType(resources.GetObject("Msfgrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Msfgrid.Size = New System.Drawing.Size(681, 195)
        Me.Msfgrid.TabIndex = 21
        '
        'BtnDelete
        '
        Me.BtnDelete.Enabled = False
        Me.BtnDelete.Location = New System.Drawing.Point(212, 3)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.BtnDelete.TabIndex = 22
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = True
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(618, 4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 23)
        Me.BtnClose.TabIndex = 23
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FrmLeaveCancellation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 229)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.Msfgrid)
        Me.Controls.Add(Me.CmbEmpId)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLeaveCancellation"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmLeaveCancellation"
        CType(Me.Msfgrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CmbEmpId As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Msfgrid As AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
    Friend WithEvents BtnDelete As System.Windows.Forms.Button
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
