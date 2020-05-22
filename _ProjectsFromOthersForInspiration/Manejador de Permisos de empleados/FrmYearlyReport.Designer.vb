<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmYearlyReport
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
        Me.cmbQuarterNo = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer
        Me.ReportYearly1 = New KIOCLLeaveMgt.ReportYearly
        Me.BtnGenerate = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmbQuarterNo
        '
        Me.cmbQuarterNo.FormattingEnabled = True
        Me.cmbQuarterNo.Location = New System.Drawing.Point(639, 6)
        Me.cmbQuarterNo.Name = "cmbQuarterNo"
        Me.cmbQuarterNo.Size = New System.Drawing.Size(121, 21)
        Me.cmbQuarterNo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(559, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Quarter No"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.DisplayGroupTree = False
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.ReportYearly1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(876, 450)
        Me.CrystalReportViewer1.TabIndex = 0
        '
        'BtnGenerate
        '
        Me.BtnGenerate.Location = New System.Drawing.Point(776, 4)
        Me.BtnGenerate.Name = "BtnGenerate"
        Me.BtnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.BtnGenerate.TabIndex = 4
        Me.BtnGenerate.Text = "Generate"
        Me.BtnGenerate.UseVisualStyleBackColor = True
        '
        'FrmYearlyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 450)
        Me.Controls.Add(Me.BtnGenerate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbQuarterNo)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "FrmYearlyReport"
        Me.Text = "Power Consumption Yearly Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents ReportYearly1 As KIOCLLeaveMgt.ReportYearly
    Friend WithEvents cmbQuarterNo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnGenerate As System.Windows.Forms.Button
End Class
