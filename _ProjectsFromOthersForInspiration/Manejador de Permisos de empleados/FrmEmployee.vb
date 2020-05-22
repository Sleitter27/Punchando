
Public Class FrmEmployee
    Dim sql As String
    Dim Gender As String
    Sub clr()
        LoadMsf()
        TxtEmpId.Text = ""
        RdMale.Checked = True
        Gender = "Male"
        TxtEmpName.Text = ""
        txtQuarter.Text = ""
        CmbLocation.Text = ""
        CmbDept.Text = ""
        CmbDes.Text = ""
        BtnAdd.Enabled = False
        BtnModify.Enabled = False
        BtnDel.Enabled = False

    End Sub
    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        clr()
        BtnAdd.Enabled = True

    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If TxtEmpId.Text = "" Or TxtEmpName.Text = "" Or CmbDes.Text = "" Or CmbDept.Text = "" Or cmbType.Text = "" Then
            MsgBox("Enter all the values")
        Else
            sql = "insert into Employee(EmpId,EmpName,Desg,Dept,Gender,QuarterNo,Location,Type) values(" & TxtEmpId.Text & ",'" & TxtEmpName.Text & "','" & CmbDes.Text & "','" & CmbDept.Text & "','" & Gender & "','" & txtQuarter.Text & "','" & CmbLocation.Text & "','" & cmbType.Text & "')"
            conn.Execute(sql)
            clr()
            MsgBox("Record saved")

        End If
    End Sub

    Private Sub MsfGrid_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles MsfGrid.ClickEvent
        MsfGrid.Row = MsfGrid.RowSel
        MsfGrid.Col = 0
        If MsfGrid.Text <> "" Then
            TxtEmpId.Text = MsfGrid.Text
            MsfGrid.Col = 1
            TxtEmpName.Text = MsfGrid.Text
            MsfGrid.Col = 2
            cmbType.Text = MsfGrid.Text
            MsfGrid.Col = 3
            CmbDes.Text = MsfGrid.Text
            MsfGrid.Col = 4
            CmbDept.Text = MsfGrid.Text
            MsfGrid.Col = 5
            If MsfGrid.Text = "Male" Then
                RdMale.Checked = True

            Else
                RdFemale.Checked = True
            End If
            MsfGrid.Col = 6
            txtQuarter.Text = MsfGrid.Text
            MsfGrid.Col = 7
            CmbLocation.Text = MsfGrid.Text
            BtnAdd.Enabled = False
            BtnDel.Enabled = True
            BtnModify.Enabled = True
        Else
            BtnDel.Enabled = False
            BtnModify.Enabled = False
        End If
    End Sub

    Private Sub MsfGrid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsfGrid.Enter

    End Sub

    Private Sub FrmEmployee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clr()
        LoadLocation()
        LoadDept()
        LoadDesg()
    End Sub


    Sub initMsfGrid()
        MsfGrid.Clear()
        MsfGrid.Row = 0
        MsfGrid.Col = 0
        MsfGrid.Text = "Employee Id"
        MsfGrid.Col = 1
        MsfGrid.Text = "Employee Name"
        MsfGrid.Col = 2
        MsfGrid.Text = "Type"
        MsfGrid.Col = 3
        MsfGrid.Text = "Designation"
        MsfGrid.Col = 4
        MsfGrid.Text = "Department"
        MsfGrid.Col = 5
        MsfGrid.Text = "Gender"
        MsfGrid.Col = 6
        MsfGrid.Text = "Quarter No"
        MsfGrid.Col = 7
        MsfGrid.Text = "Location"
    End Sub
    Sub LoadMsf()
        initMsfGrid()
        Dim i
        i = 1
        sql = "select * from Employee order by EmpId"
        Rs = GetRecords(sql)
        Do While Not Rs.EOF
            MsfGrid.Row = i
            MsfGrid.Col = 0
            MsfGrid.Text = Rs(0).Value
            MsfGrid.Col = 1
            MsfGrid.Text = Rs(1).Value
            MsfGrid.Col = 2
            MsfGrid.Text = Rs(7).Value
            MsfGrid.Col = 3
            MsfGrid.Text = Rs(2).Value
            MsfGrid.Col = 4
            MsfGrid.Text = Rs(3).Value
            MsfGrid.Col = 5
            MsfGrid.Text = Rs(4).Value
            MsfGrid.Col = 6
            On Error Resume Next
            MsfGrid.Text = Rs(5).Value
            MsfGrid.Col = 7
            MsfGrid.Text = Rs(6).Value
            i = i + 1
            Rs.MoveNext()
        Loop
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Sub LoadDept()
        sql = "select * from Department order by depName"
        Rs = GetRecords(sql)
        CmbDept.Items.Clear()
        Do While Not Rs.EOF
            CmbDept.Items.Add(Rs(1).Value)
            Rs.MoveNext()
        Loop
    End Sub

    Sub LoadDesg()
        sql = "select * from Designation order by desName"
        Rs = GetRecords(sql)
        CmbDes.Items.Clear()
        Do While Not Rs.EOF
            CmbDes.Items.Add(Rs(1).Value)
            Rs.MoveNext()
        Loop
    End Sub

    Sub LoadLocation()
        sql = "select * from Location order by Location"
        Rs = GetRecords(sql)
        CmbLocation.Items.Clear()
        Do While Not Rs.EOF
            CmbLocation.Items.Add(Rs(0).Value)
            Rs.MoveNext()
        Loop
    End Sub

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        If MsgBox("Do you want to delete the employee record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "delete * from employee where empid=" & TxtEmpId.Text
            conn.Execute(sql)
            clr()
            MsgBox("Record Deleted")
        End If
    End Sub

    Private Sub BtnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModify.Click
        If MsgBox("Do you want to Edit the employee record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "update employee set empname='" & TxtEmpName.Text & "',type='" & cmbType.Text & "',desg='" & CmbDes.Text & "',dept='" & CmbDept.Text & "',Gender='" & Gender & "',QuarterNo='" & txtQuarter.Text & "',Location='" & CmbLocation.Text & "' where empid=" & TxtEmpId.Text
            conn.Execute(sql)
            clr()
            MsgBox("Record Edited")
        End If
    End Sub

    Private Sub CmbDes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbDes.SelectedIndexChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdMale.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdFemale.CheckedChanged
        Gender = "Female"
    End Sub

    Private Sub TxtEmpName_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtEmpName.KeyDown
        CheckAlpha(e)
    End Sub




End Class