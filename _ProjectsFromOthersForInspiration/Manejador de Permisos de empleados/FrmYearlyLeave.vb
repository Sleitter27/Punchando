Public Class FrmYearlyLeave

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub FrmYearlyLeave_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        YearlyLeave1.RecordSelectionFormula = "{LeaveApp.Approval} =true"
        YearlyLeave1.Refresh()
        CrystalReportViewer1.ReportSource = YearlyLeave1
        emp()

    End Sub

    Sub emp()
        sql = "select * from employee"
        Rs = GetRecords(sql)
        cmbempId.Items.Add("All")
        Do While Not Rs.EOF
            cmbempId.Items.Add(Rs(0).Value)

            Rs.MoveNext()
        Loop
    End Sub


   
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub cmbempId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbempId.SelectedIndexChanged
        If cmbempId.SelectedItem.ToString() <> "All" Then
            YearlyLeave1.RecordSelectionFormula = "{leaveApp.empId}=" & cmbempId.SelectedItem & " and {leaveApp.Approval} = true"
        Else
            YearlyLeave1.RecordSelectionFormula = "trim(cstr({leaveApp.empId}))<>'' and {leaveApp.Approval} = true"
        End If
        
        YearlyLeave1.Refresh()
        CrystalReportViewer1.ReportSource = YearlyLeave1
    End Sub
End Class