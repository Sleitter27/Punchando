Public Class FrmLeaveApp
    Dim sql As String
    Dim alert As Boolean
    Dim days, spldays, Edays, HPLdays, CMLdays, RHDays
    Dim cldays As Double
    Dim LeaveType = ""

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmLeaveApp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clr()
        LoadEmp()
        IsLTypeSelected()
    End Sub

    Function IsLTypeSelected()
        If LeaveType <> "" Then
            DtpFrom.Enabled = True
            DtpTo.Enabled = True
        Else
            DtpFrom.Enabled = False
            DtpTo.Enabled = False
        End If
        Return (0)
    End Function

    Sub clr()
        LoadAppId()
        CmbEmpId.Text = ""
        txtName.Text = ""
        txtDays.Text = "0"
        txtReason.Text = ""
        alert = False
        DtpFrom.Value = Date.Today
        DtpTo.Value = Date.Today
        CalDays()
        BtnApply.Enabled = False
        BtnDelete.Enabled = False
        BtnEdit.Enabled = False

    End Sub

    Sub LoadMsf()
        Msfgrid.Clear()
        Msfgrid.Row = 0
        Msfgrid.Col = 0
        Msfgrid.Text = "Sl no"
        Msfgrid.Col = 1
        Msfgrid.Text = "App No"
        Msfgrid.Col = 2
        Msfgrid.Text = "From"
        Msfgrid.Col = 3
        Msfgrid.Text = "To"
        Msfgrid.Col = 4
        Msfgrid.Text = "Reason"
        Msfgrid.Col = 5
        Msfgrid.Text = "LeaveType"
        Msfgrid.Col = 6
        Msfgrid.Text = "Status"
        Dim rowno = 1
        If CmbEmpId.Text <> "" Then


            sql = "select * from LeaveApp where Empid=" & CmbEmpId.Text & " order by appid desc"
            Rs = GetRecords(sql)
            Do While Not Rs.EOF
                On Error Resume Next
                Msfgrid.Row = rowno
                Msfgrid.Col = 0
                Msfgrid.Text = rowno
                Msfgrid.Col = 1
                Msfgrid.Text = Rs(0).Value
                Msfgrid.Col = 2
                Msfgrid.Text = Rs(2).Value
                Msfgrid.Col = 3
                Msfgrid.Text = Rs(3).Value
                Msfgrid.Col = 4
                Msfgrid.Text = Rs(4).Value
                Msfgrid.Col = 5
                Msfgrid.Text = Rs(5).Value
                Msfgrid.Col = 6
                If Rs(7).Value = True Then
                    Msfgrid.Text = "Rejected"
                Else
                    If Rs(6).Value = True Then
                        Msfgrid.Text = "Approved"
                    Else
                        Msfgrid.Text = "Pending"
                    End If
                End If
                rowno = rowno + 1
                Rs.MoveNext()
            Loop
        End If
    End Sub

    Sub LoadAppId()
        sql = "select * from LeaveApp "
        Rs = GetRecords(sql)
        If Rs.EOF Then
            txtAppNo.Text = "1"
        Else
            sql = "select Max(appId)+1 from  LeaveApp"
            Rs = GetRecords(sql)
            txtAppNo.Text = Rs(0).Value
        End If
    End Sub

    Sub CalDays()
        Dim Days = DateDiff(DateInterval.Day, DtpFrom.Value, DtpTo.Value)
        txtDays.Text = Days + 1
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        clr()
        BtnApply.Enabled = True
    End Sub

    Sub LoadEmp()
        sql = "select * from Employee order by EmpId"
        Rs = GetRecords(sql)
        CmbEmpId.Items.Clear()
        Do While Not Rs.EOF
            CmbEmpId.Items.Add(Rs(0).Value)
            Rs.MoveNext()
        Loop
    End Sub

    Private Sub CmbEmpId_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbEmpId.SelectedIndexChanged
        If CmbEmpId.Text <> "" Then
            sql = "select * from Employee where EmpId=" & CmbEmpId.Text
            Rs = GetRecords(sql)
            txtName.Text = Rs(1).Value
            txtType.Text = Rs(7).Value
            If Rs(4).Value = "Male" Then
                ChkML.Enabled = False
            Else
                ChkML.Enabled = True
            End If
            ValidateLeave()
            LoadMsf()
        End If
    End Sub

    Private Sub DtpFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpFrom.ValueChanged
        'If DtpTo.Value < DtpFrom.Value And alert = False Then
        '    alert = True
        '    MsgBox("From Date cannot be Greater then To Date")
        '    DtpFrom.Value = Date.Today
        '    alert = False
        '    CalDays()
        '    DtpFrom.Focus()
        'Else
        '    alert = False
        '    CalDays()
        'End If
        DtpTo.Value = DtpFrom.Value
    End Sub

    Private Sub DtpTo_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpTo.ValueChanged
        If DtpTo.Value < DtpFrom.Value And alert = False Then
            alert = True
            MsgBox("To Date cannot be less then From Date")
            DtpTo.Value = DtpFrom.Value
            alert = False
            CalDays()
            DtpTo.Focus()
        Else
            alert = False
            CalDays()
            If ChkCL.Checked = True And alert = False Then
                ValidateCasualLeave()
                If txtType.Text = "Executive" Then
                    If Val(txtDays.Text) > (15 - cldays) Then
                        alert = True
                        MsgBox("You have " & (15 - cldays) & " Casual Leave(s) pending in your qouta")
                        DtpTo.Value = DtpFrom.Value
                        alert = False
                        DtpTo.Focus()
                    End If
                Else
                    If Val(txtDays.Text) > (12 - cldays) Then
                        alert = True
                        MsgBox("You have " & (15 - cldays) & " Casual Leave(s) pending in your qouta")
                        DtpTo.Value = DtpFrom.Value
                        alert = False
                        DtpTo.Focus()
                    End If
                End If
                
            ElseIf Val(txtDays.Text) > 1 And alert = False Then
                alert = True
                MsgBox("Only 1 Leave is allowed at a time")
                DtpTo.Value = DtpFrom.Value
                alert = False
                DtpTo.Focus()
            End If
        End If
    End Sub

    Sub ValidateLeave()
        ValidateCasualLeave()
        ValidateSplLv()
        ValidateEarnedLv()
        ValidateHPL()
        validateCML()
        ValidateLND()
        ValidateRH()
    End Sub

    Sub ValidateRH()
        RHDays = 0
        sql = "select * from holidays"
        Rs = GetRecords(sql)
        Do While Not Rs.EOF
            If Weekday(Rs(0).Value) = 1 Then
                RHDays = RHDays + 1

            End If
            Rs.MoveNext()
        Loop
        If RHDays > 3 Then
            RHDays = 3
        End If

        sql = "select count(*) from LeaveApp where Empid=" & CmbEmpId.Text & " and LeaveType='RL' and Approval=true"
        Rs = GetRecords(sql)
        If RHDays <= Rs(0).Value Then
            ChkRL.Enabled = False
        Else
            ChkRL.Enabled = True
        End If

    End Sub

#Region "ValidateCasualLeave"
    Sub ValidateCasualLeave()
        cldays = 0
        days = 0
        sql = "select * from LeaveApp where Empid=" & CmbEmpId.Text & " and LeaveType='CL' and Approval=true"
        Rs = GetRecords(sql)
        Do While Not Rs.EOF
            Dim date1, date2 As Date
            date1 = Rs(2).Value
            date2 = Rs(3).Value
            days = DateDiff(DateInterval.Day, date1, date2)
            cldays = cldays + days + 1
            Rs.MoveNext()
        Loop
        If txtType.Text = "Executive" Then
            If cldays > 15 Then
                ChkCL.Enabled = False
            Else
                ChkCL.Enabled = True
            End If
        Else
            If cldays > 12 Then
                ChkCL.Enabled = False
            Else
                ChkCL.Enabled = True
            End If
        End If

    End Sub
#End Region

#Region "ValidateSplLv"
    Sub ValidateSplLv()
        spldays = 0
        days = 0
        sql = "select * from LeaveApp where Empid=" & CmbEmpId.Text & " and LeaveType='SPL' and Approval=true"
        Rs = GetRecords(sql)
        Do While Not Rs.EOF
            Dim date1, date2 As Date
            date1 = Rs(2).Value
            date2 = Rs(3).Value
            days = DateDiff(DateInterval.Day, date1, date2)
            spldays = spldays + ((days + 1))
            Rs.MoveNext()
        Loop

        If spldays > 15 Then
            ChkSPL.Enabled = False
        Else
            ChkSPL.Enabled = True
        End If
    End Sub
#End Region

#Region "ValidateEarnedLv"
    Sub ValidateEarnedLv()
        Edays = 0
        days = 0
        sql = "select * from LeaveApp where Empid=" & CmbEmpId.Text & " and LeaveType='EL' and Approval=true and year(FromDt)= year(now())  and year(ToDt)= year(now()) "
        Rs = GetRecords(sql)
        Do While Not Rs.EOF
            Dim date1, date2 As Date
            date1 = Rs(2).Value
            date2 = Rs(3).Value
            days = DateDiff(DateInterval.Day, date1, date2)
            Edays = Edays + ((days + 1))
            Rs.MoveNext()
        Loop

        If Edays > 30 Then
            ChkEL.Enabled = False
        Else
            ChkEL.Enabled = True
        End If
    End Sub
#End Region

#Region "ValidateHPL"
    Sub ValidateHPL()
        HPLdays = 0
        days = 0
        sql = "select * from LeaveApp where Empid=" & CmbEmpId.Text & " and LeaveType='HPL' and Approval=true and year(FromDt)=year(now()) and year(ToDt)=year(now())"
        Rs = GetRecords(sql)
        Do While Not Rs.EOF
            Dim date1, date2 As Date
            date1 = Rs(2).Value
            date2 = Rs(3).Value
            days = DateDiff(DateInterval.Day, date1, date2)
            HPLdays = HPLdays + ((days + 1))
            Rs.MoveNext()
        Loop

        If HPLdays > 20 Then
            ChkHPL.Enabled = False
        Else
            ChkHPL.Enabled = True
        End If
    End Sub
#End Region

#Region "validateCML"
    Sub validateCML()
        Dim Dayss
        CMLdays = 0
        days = 0
        sql = "select * from LeaveApp where Empid=" & CmbEmpId.Text & " and LeaveType='CML' and Approval=true and year(FromDt)=year(now()) and year(ToDt)=year(now())"

        Rs = GetRecords(sql)
        Do While Not Rs.EOF
            Dim date1, date2 As Date
            date1 = Rs(2).Value
            date2 = Rs(3).Value
            Dayss = DateDiff(DateInterval.Day, date1, date2)
            CMLdays = CMLdays + ((Dayss + 1))
            Rs.MoveNext()
        Loop

        If CMLdays > 10 Then
            ChkCML.Enabled = False
        Else
            ChkCML.Enabled = True
        End If
    End Sub
#End Region

#Region "ValidateLND"
    Sub ValidateLND()
        If HPLdays > 10 Then
            ChkLND.Enabled = True
        Else
            ChkLND.Enabled = False
        End If
    End Sub
#End Region


    Private Sub BtnApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnApply.Click
        If CmbEmpId.Text = "" Then
            MsgBox("Kindly slect Employee Id")
        ElseIf txtReason.Text = "" Then
            MsgBox("KIndly enter Reason for leave")
        ElseIf LeaveTakenType() = "" Then
            MsgBox("Kindly select a Leave Type")
        Else
            sql = "insert into LeaveApp values(" & txtAppNo.Text & "," & CmbEmpId.Text & ",format('" & DtpFrom.Value & "','dd/MM/yyyy'),format('" & DtpTo.Value & "','dd/MM/yyyy'),'" & txtReason.Text & "','" & LeaveTakenType() & "',False,False)"
            conn.Execute(sql)
            clr()
            LoadMsf()
            MsgBox("Leave Application Saved")
        End If
    End Sub

    Function LeaveTakenType()
        If ChkCL.Checked = True Then
            LeaveType = "CL"
        ElseIf ChkCML.Checked = True Then
            LeaveType = "CML"
        ElseIf ChkCO.Checked = True Then
            LeaveType = "CO"
        ElseIf ChkEL.Checked = True Then
            LeaveType = "EL"
        ElseIf ChkHPL.Checked = True Then
            LeaveType = "HPL"
        ElseIf ChkIOD.Checked = True Then
            LeaveType = "IOD"
        ElseIf ChkLND.Checked = True Then
            LeaveType = "LND"
        ElseIf ChkLWP.Checked = True Then
            LeaveType = "LWP"
        ElseIf ChkML.Checked = True Then
            LeaveType = "ML"
        ElseIf ChkRL.Checked = True Then
            LeaveType = "RL"
        ElseIf ChkSPL.Checked = True Then
            LeaveType = "SPL"
        End If
        Return (LeaveType)
    End Function

    Function LeaveTakenType(ByVal type As String)
        If type = "CL" Then
            ChkCL.Checked = True
        ElseIf type = "CML" Then
            ChkCML.Checked = True
        ElseIf type = "CO" Then
            ChkCO.Checked = True
        ElseIf type = "EL" Then
            ChkEL.Checked = True
        ElseIf type = "HPL" Then
            ChkHPL.Checked = True
        ElseIf type = "IOD" Then
            ChkIOD.Checked = True
        ElseIf type = "LND" Then
            ChkLND.Checked = True
        ElseIf type = "LWP" Then
            ChkLWP.Checked = True
        ElseIf type = "ML" Then
            ChkML.Checked = True
        ElseIf type = "RL" Then
            ChkRL.Checked = True
        ElseIf type = "SPL" Then
            ChkSPL.Checked = True
        End If
        Return (0)
    End Function

    Private Sub Msfgrid_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles Msfgrid.ClickEvent
        Msfgrid.Row = Msfgrid.RowSel
        Msfgrid.Col = 0
        If Msfgrid.Text <> "" Then
            Msfgrid.Col = 1
            txtAppNo.Text = Msfgrid.Text
            Msfgrid.Col = 2
            DtpFrom.Value = Msfgrid.Text
            Msfgrid.Col = 3
            DtpTo.Value = Msfgrid.Text
            Msfgrid.Col = 4
            txtReason.Text = Msfgrid.Text
            Msfgrid.Col = 5
            LeaveTakenType(Msfgrid.Text)
            Msfgrid.Col = 6
            If Msfgrid.Text = "Pending" Then
                BtnDelete.Enabled = True
                BtnEdit.Enabled = True
                BtnApply.Enabled = False
            Else
                BtnDelete.Enabled = False
                BtnEdit.Enabled = False
                BtnApply.Enabled = False
            End If
        Else
            txtName.Text = ""
            txtDays.Text = "0"
            txtReason.Text = ""
            alert = False
            DtpFrom.Value = Date.Today
            DtpTo.Value = Date.Today
            CalDays()
            BtnApply.Enabled = False
            BtnDelete.Enabled = False
            BtnEdit.Enabled = False
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Do you want to delete the Leave application", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "delete * from LeaveApp where Appid=" & txtAppNo.Text
            conn.Execute(sql)
            clr()
            LoadMsf()
            MsgBox("Record Deleted")
        End If
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        If MsgBox("Do you want to Edit the Leave application", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "update LeaveApp set fromdt=format('" & DtpFrom.Value & "','dd/MM/yyyy'),ToDt=format('" & DtpTo.Value & "','dd/MM/yyyy'),Reason='" & txtReason.Text & "',LeaveType='" & LeaveTakenType() & "' where Appid=" & txtAppNo.Text
            conn.Execute(sql)
            clr()
            LoadMsf()
            MsgBox("Record Edited")
        End If
    End Sub

    Private Sub ChkCL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCL.CheckedChanged
        LeaveTakenType()
        IsLTypeSelected()
    End Sub

    Private Sub ChkEL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkEL.CheckedChanged
        LeaveTakenType()
        IsLTypeSelected()
    End Sub

    Private Sub ChkHPL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkHPL.CheckedChanged
        LeaveTakenType()
        IsLTypeSelected()
    End Sub

    Private Sub ChkRL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkRL.CheckedChanged
        LeaveTakenType()
        IsLTypeSelected()
        
    End Sub

    Private Sub ChkCML_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCML.CheckedChanged
        LeaveTakenType()
        IsLTypeSelected()
    End Sub

    Private Sub ChkIOD_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkIOD.CheckedChanged
        LeaveTakenType()
        IsLTypeSelected()
    End Sub

    Private Sub ChkHCL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        IsLTypeSelected()
    End Sub

    Private Sub ChkML_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkML.CheckedChanged
        LeaveTakenType()
        IsLTypeSelected()
    End Sub

    Private Sub ChkSPL_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkSPL.CheckedChanged
        LeaveTakenType()
        IsLTypeSelected()
    End Sub

    Private Sub ChkCO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkCO.CheckedChanged
        LeaveTakenType()
        IsLTypeSelected()
    End Sub

    Private Sub ChkLWP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkLWP.CheckedChanged
        LeaveTakenType()
        IsLTypeSelected()
    End Sub

    Private Sub ChkLND_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChkLND.CheckedChanged
        LeaveTakenType()
        IsLTypeSelected()
    End Sub
End Class