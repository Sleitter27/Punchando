Public Class FrmDepartment
    Dim sql As String
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        clr()
        BtnAdd.Enabled = True
    End Sub

    Sub clr()
        LoadDepId()
        TxtDepName.Text = ""
        BtnNew.Enabled = True
        BtnAdd.Enabled = False
        BtnDelete.Enabled = False
        BtnModify.Enabled = False
        LoadMsf()
    End Sub

    Sub LoadDepId()
        Rs = GetRecords("select * from department")
        If Not Rs.EOF Then
            Rs = GetRecords("select max(depid)+ 1 from department")
            txtDepId.Text = Rs(0).Value
        Else
            txtDepId.Text = "1"
        End If
    End Sub

    Private Sub FrmDepartment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clr()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If TxtDepName.Text = "" Then
            MsgBox("Kindly enter department name")
        Else
            Sql = "insert into department(depid,depname) values(" & txtDepId.Text & ",'" & TxtDepName.Text & "')"
            conn.Execute(sql)
            clr()
            MsgBox("Record saved")
        End If
    End Sub

    Sub InitMsf()
        MsfDep.Clear()
        MsfDep.Row = 0
        MsfDep.Col = 0
        MsfDep.Text = "Dep Id"
        MsfDep.Col = 1
        MsfDep.Text = "Name"
        MsfDep.set_ColWidth(1, 2000)
    End Sub

    Sub LoadMsf()
        InitMsf()
        Dim i
        i = 1
        sql = "select * from department order by depid"
        Rs = GetRecords(sql)
        Do While Not Rs.EOF
            MsfDep.Row = i
            MsfDep.Col = 0
            MsfDep.Text = Rs(0).Value
            MsfDep.Col = 1
            MsfDep.Text = Rs(1).Value
            i = i + 1
            Rs.MoveNext()
        Loop
    End Sub

    Private Sub MsfDep_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles MsfDep.ClickEvent

        MsfDep.Row = MsfDep.RowSel
        MsfDep.Col = 0
        If MsfDep.Text <> "" Then
            txtDepId.Text = MsfDep.Text
            MsfDep.Col = 1
            TxtDepName.Text = MsfDep.Text
            BtnDelete.Enabled = True
            BtnModify.Enabled = True
            BtnAdd.Enabled = False
        Else
            LoadDepId()
            TxtDepName.Text = ""
            BtnDelete.Enabled = False
            BtnModify.Enabled = False
            BtnAdd.Enabled = False
        End If
    End Sub

    Private Sub MsfDep_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsfDep.Enter

    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Do you want to delete the department", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = " DELETE * from department where depid=" & txtDepId.Text
            conn.Execute(sql)
            clr()
            MsgBox("Record Deleted")
        End If
        clr()
    End Sub

    Private Sub BtnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModify.Click
        If MsgBox("Do you want to edit the department", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = " update department set depname='" & TxtDepName.Text & "' where depid=" & txtDepId.Text
            conn.Execute(sql)
            clr()
            MsgBox("Record Updated")
        End If
        clr()
    End Sub

    Private Sub TxtDepName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDepName.TextChanged
        TxtDepName.Text = UCase(TxtDepName.Text)
        TxtDepName.SelectionStart = Len(TxtDepName.Text)
        If MsfDep.Text <> TxtDepName.Text And TxtDepName.Text <> "" And BtnAdd.Enabled <> True Then
            BtnModify.Enabled = True
        Else
            BtnModify.Enabled = False
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub txtDepId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDepId.TextChanged

    End Sub
End Class