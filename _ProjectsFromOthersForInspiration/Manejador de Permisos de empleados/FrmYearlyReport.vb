Public Class FrmYearlyReport



    Private Sub FrmYearlyReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadQuarter()
    End Sub

    Sub loadQuarter()
        sql = "select * from employee order by QuarterNo"
        Rs = GetRecords(sql)
        cmbQuarterNo.Items.Clear()
        Do While Not Rs.EOF
            cmbQuarterNo.Items.Add(Rs(5).Value)
            Rs.MoveNext()
        Loop
    End Sub

    Private Sub BtnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerate.Click
        ReportYearly1.RecordSelectionFormula = " {Powercon.QtrNo}='" & cmbQuarterNo.Text & "'"
        ReportYearly1.Refresh()
        CrystalReportViewer1.ReportSource = ReportYearly1
    End Sub
End Class