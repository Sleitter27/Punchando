Public Class FrmLeaveApproval

    Private Sub FrmLeaveApproval_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadMsf()
        clr()
    End Sub

    Sub clr()
        txtAppId.Text = ""
        txtEmpName.Text = ""
        txtFrom.Text = ""
        txtTo.Text = ""
        txtReason.Text = ""
        TxtType.Text = ""
        CmbStatus.Text = ""
    End Sub

    Sub LoadMsf()
        Msfgrid.Clear()
        Msfgrid.Row = 0
        Msfgrid.Col = 0
        msfgrid.Text = "App No"
        Msfgrid.Col = 1
        msfgrid.Text = "Emp Id"
        Msfgrid.Col = 2
        msfgrid.Text = "Name"
        Msfgrid.Col = 3
        msfgrid.Text = "From"
        Msfgrid.Col = 4
        msfgrid.Text = "To"
        Msfgrid.Col = 5
        msfgrid.Text = "Reason"
        Msfgrid.Col = 6
        msfgrid.Text = "Type"
        Dim rowno = 1
        sql = "select * from LeaveApp where approval=false and rejected=false order by appid desc"
        Rs = GetRecords(sql)
        Do While Not Rs.EOF
            On Error Resume Next
            Msfgrid.Row = rowno
            Msfgrid.Col = 0
            msfgrid.Text = Rs(0).Value
            Msfgrid.Col = 1
            msfgrid.Text = Rs(1).Value
            Dim rs1 As New ADODB.Recordset
            rs1.Open("select * from employee where empid=" & Rs(1).Value, conn)
            If Not rs1.EOF Then
                msfgrid.Col = 2
                msfgrid.Text = rs1(1).Value
            End If
            Msfgrid.Col = 3
            msfgrid.Text = Rs(2).Value
            Msfgrid.Col = 4
            msfgrid.Text = Rs(3).Value
            Msfgrid.Col = 5
            msfgrid.Text = Rs(4).Value
            Msfgrid.Col = 6
            msfgrid.Text = Rs(5).Value
            rowno = rowno + 1
            Rs.MoveNext()
        Loop
    End Sub

    Private Sub msfgrid_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles msfgrid.ClickEvent
        msfgrid.Col = 0
        msfgrid.Row = msfgrid.RowSel
        If msfgrid.Text <> "" Then
            txtAppId.Text = msfgrid.Text
            msfgrid.Col = 2
            txtEmpName.Text = msfgrid.Text
            msfgrid.Col = 3
            txtFrom.Text = msfgrid.Text
            msfgrid.Col = 4
            txtTo.Text = msfgrid.Text
            msfgrid.Col = 5
            txtReason.Text = msfgrid.Text
            msfgrid.Col = 6
            TxtType.Text = msfgrid.Text
        End If
    End Sub

    Private Sub msfgrid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles msfgrid.Enter

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If CmbStatus.Text = "" Then
            MsgBox("Kindly select Leave Status")
        Else
            If CmbStatus.Text = "Approve" Then
                sql = "update LeaveApp set Approval=True where Appid=" & txtAppId.Text
            Else
                sql = "update LeaveApp set Rejected=True where Appid=" & txtAppId.Text
            End If
            conn.Execute(sql)
            LoadMsf()
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClear.Click
        clr()
    End Sub
End Class