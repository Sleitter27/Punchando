Public Class FrmLeaveCancellation

    Private Sub FrmLeaveCancellation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEmp()
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
            LoadMsf()
        End If
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

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        Msfgrid.Row = Msfgrid.RowSel
        Msfgrid.Col = 0
        If Msfgrid.Text <> "" Then
            Msfgrid.Col = 1
            sql = "delete * from leaveapp where appid=" & Msfgrid.Text
            conn.Execute(sql)
            LoadMsf()
            MsgBox("Leave Record Deleted")
        End If
    End Sub

    Private Sub Msfgrid_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles Msfgrid.ClickEvent
        Msfgrid.Row = Msfgrid.RowSel
        Msfgrid.Col = 0
        If Msfgrid.Text <> "" Then
            BtnDelete.Enabled = True
        Else
            BtnDelete.Enabled = False
        End If
    End Sub

    Private Sub Msfgrid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Msfgrid.Enter

    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub
End Class