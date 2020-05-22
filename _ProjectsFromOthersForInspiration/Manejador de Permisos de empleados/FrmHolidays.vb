Public Class FrmHolidays

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        clr()
        BtnAdd.Enabled = True
    End Sub

    Sub clr()
        DtpDate.Value = Date.Today
        TxtDesc.Text = ""
        BtnNew.Enabled = True
        BtnAdd.Enabled = False
        BtnDelete.Enabled = False
        BtnModify.Enabled = False
        DtpDate.Enabled = True
        LoadMsf()
    End Sub

    Sub InitMsf()
        MsfHolidays.Clear()
        MsfHolidays.Row = 0
        MsfHolidays.Col = 0
        MsfHolidays.Text = "Date"
        MsfHolidays.Col = 1
        MsfHolidays.Text = "Description"
        MsfHolidays.set_ColWidth(1, 2000)
    End Sub

    Sub LoadMsf()
        InitMsf()
        Dim i
        i = 1
        sql = "select * from Holidays order by Hdate"
        Rs = GetRecords(sql)
        Do While Not Rs.EOF
            MsfHolidays.Row = i
            MsfHolidays.Col = 0
            MsfHolidays.Text = Rs(0).Value
            MsfHolidays.Col = 1
            MsfHolidays.Text = Rs(1).Value
            i = i + 1
            Rs.MoveNext()
        Loop
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If TxtDesc.Text = "" Then
            MsgBox("Kindly enter Holiday Description")
        Else
            sql = "insert into holidays values(format('" & DtpDate.Text & "','dd/MM/yyyy'),'" & TxtDesc.Text & "')"
            conn.Execute(sql)
            clr()
            MsgBox("Record saved")
        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Do you want to delete the Holiday", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = " DELETE * from holidays where hdate=format('" & DtpDate.Text & "','dd/MM/yyyy')"
            conn.Execute(sql)
            clr()
            MsgBox("Record Deleted")
        End If
        clr()
    End Sub

    Private Sub BtnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModify.Click
        MsfHolidays.Col = 0
        If MsgBox("Do you want to edit the Holiday", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = " update holidays set description='" & TxtDesc.Text & "' where hdate=format('" & MsfHolidays.Text & "','dd/MM/yyyy')"
            conn.Execute(sql)
            clr()
            MsgBox("Record Updated")
        End If
        clr()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmHolidays_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        InitMsf()
        clr()
    End Sub

    Private Sub MsfHolidays_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles MsfHolidays.ClickEvent
        MsfHolidays.Row = MsfHolidays.RowSel
        MsfHolidays.Col = 0
        If MsfHolidays.Text <> "" Then
            DtpDate.Value = MsfHolidays.Text
            MsfHolidays.Col = 1
            TxtDesc.Text = MsfHolidays.Text
            BtnDelete.Enabled = True
            BtnModify.Enabled = True
            BtnAdd.Enabled = False
            DtpDate.Enabled = False
        Else
            TxtDesc.Text = ""
            BtnDelete.Enabled = False
            BtnModify.Enabled = False
            BtnAdd.Enabled = False
            clr()
        End If
    End Sub

    Private Sub MsfHolidays_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsfHolidays.Enter

    End Sub
End Class