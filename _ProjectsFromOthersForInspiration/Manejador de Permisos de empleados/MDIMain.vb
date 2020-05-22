Imports System.Windows.Forms

Public Class MDIMain


    Private Sub MDIMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        FrmLogin.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub AplyLeaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AplyLeaveToolStripMenuItem.Click
        FrmLeaveApp.Show()
        FrmLeaveApp.BringToFront()
    End Sub

    Private Sub EmployeeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem.Click
        FrmDepartment.Show()
        FrmDepartment.Focus()
    End Sub

    Private Sub DesignationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DesignationToolStripMenuItem.Click
        FrmDesignation.Show()

    End Sub

    Private Sub EmployeeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmployeeToolStripMenuItem1.Click
        FrmEmployee.Show()

    End Sub

    Private Sub LeaveApplicationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub LocationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LocationToolStripMenuItem.Click
        FrmLocation.Focus()
        FrmLocation.Show()

    End Sub

    Private Sub EntryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EntryToolStripMenuItem.Click
        FrmPowerCon.Show()
    End Sub

    Private Sub LeaveApprovalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeaveApprovalToolStripMenuItem.Click
        FrmLeaveApproval.Show()
    End Sub

    Private Sub RatePerUnitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RatePerUnitToolStripMenuItem.Click
        FrmRatePerUnit.Show()
    End Sub

    Private Sub HolidaysToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HolidaysToolStripMenuItem.Click
        FrmHolidays.Show()
        FrmHolidays.Focus()
    End Sub

    Private Sub LeaveSheetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeaveSheetToolStripMenuItem.Click
        FrmLeaveSheet.Show()
        FrmLeaveSheet.Focus()
    End Sub

    Private Sub MonthlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyToolStripMenuItem.Click
        FrmPowerConMonthly.Show()
    End Sub

    Private Sub YearlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearlyToolStripMenuItem.Click
        FrmYearlyReport.Show()
    End Sub

    Private Sub YearlyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YearlyToolStripMenuItem1.Click
        FrmYearlyLeave.Show()

    End Sub

    Private Sub LeaveCancellationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LeaveCancellationToolStripMenuItem.Click
        FrmLeaveCancellation.Show()
        FrmLeaveCancellation.BringToFront()
    End Sub

    Private Sub MonthlyToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyToolStripMenuItem1.Click
        FrmMonthlyLeave.Show()
    End Sub
End Class
