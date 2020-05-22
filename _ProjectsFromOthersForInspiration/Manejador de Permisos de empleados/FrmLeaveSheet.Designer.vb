<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLeaveSheet
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLeaveSheet))
        Me.Label1 = New System.Windows.Forms.Label
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.Cmbmonth = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.CmbYear = New System.Windows.Forms.ComboBox
        Me.Btnshow = New System.Windows.Forms.Button
        Me.msfGrid = New AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
        Me.BtnClose = New System.Windows.Forms.Button
        CType(Me.msfGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Month"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'Cmbmonth
        '
        Me.Cmbmonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmbmonth.FormattingEnabled = True
        Me.Cmbmonth.Location = New System.Drawing.Point(48, 7)
        Me.Cmbmonth.Name = "Cmbmonth"
        Me.Cmbmonth.Size = New System.Drawing.Size(94, 21)
        Me.Cmbmonth.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(164, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Year"
        '
        'CmbYear
        '
        Me.CmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbYear.FormattingEnabled = True
        Me.CmbYear.Location = New System.Drawing.Point(199, 7)
        Me.CmbYear.Name = "CmbYear"
        Me.CmbYear.Size = New System.Drawing.Size(101, 21)
        Me.CmbYear.TabIndex = 3
        '
        'Btnshow
        '
        Me.Btnshow.Location = New System.Drawing.Point(327, 7)
        Me.Btnshow.Name = "Btnshow"
        Me.Btnshow.Size = New System.Drawing.Size(100, 20)
        Me.Btnshow.TabIndex = 4
        Me.Btnshow.Text = "Show Result"
        Me.Btnshow.UseVisualStyleBackColor = True
        '
        'msfGrid
        '
        Me.msfGrid.DataSource = Nothing
        Me.msfGrid.Location = New System.Drawing.Point(4, 34)
        Me.msfGrid.Name = "msfGrid"
        Me.msfGrid.OcxState = CType(resources.GetObject("msfGrid.OcxState"), System.Windows.Forms.AxHost.State)
        Me.msfGrid.Size = New System.Drawing.Size(827, 359)
        Me.msfGrid.TabIndex = 5
        '
        'BtnClose
        '
        Me.BtnClose.Location = New System.Drawing.Point(756, 7)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(75, 21)
        Me.BtnClose.TabIndex = 6
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = True
        '
        'FrmLeaveSheet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 399)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.msfGrid)
        Me.Controls.Add(Me.Btnshow)
        Me.Controls.Add(Me.CmbYear)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Cmbmonth)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLeaveSheet"
        Me.Text = "Monthly Attendance Report"
        CType(Me.msfGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents Cmbmonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents Btnshow As System.Windows.Forms.Button
    Friend WithEvents msfGrid As AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
    Friend WithEvents BtnClose As System.Windows.Forms.Button
End Class
