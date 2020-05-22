Public Class FrmPowerConMonthly

    Private Sub FrmPowerConMonthly_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        loadMonth()
    End Sub

    Sub loadMonth()
        Dim i = 1
        Do While i <= 12
            cmbMonth.Items.Add(MonthName(i))
            i = i + 1
        Loop
    End Sub

    Private Sub BtnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGenerate.Click
        PowerConMonthly1.RecordSelectionFormula = " month({leaveapp.fromdt})=" & IntMonth(CmbMonth.Text)
        PowerConMonthly1.Refresh()
        CrystalReportViewer1.ReportSource = PowerConMonthly1
    End Sub

    Function IntMonth(ByVal MonName As String)
        Dim monNum As Integer
        monNum = 1
        Select Case MonName
            Case "January"
                monNum = 1
            Case "February"
                monNum = 2
            Case "March"
                monNum = 3
            Case "April"
                monNum = 4
            Case "May"
                monNum = 5
            Case "June"
                monNum = 6
            Case "July"
                monNum = 7
            Case "August"
                monNum = 8
            Case "September"
                monNum = 9
            Case "October"
                monNum = 10
            Case "November"
                monNum = 11
            Case "December"
                monNum = 12
        End Select
        Return monNum
    End Function

    Private Sub CrystalReportViewer1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CrystalReportViewer1.Load

    End Sub

    Private Sub CmbMonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbMonth.SelectedIndexChanged

    End Sub
End Class