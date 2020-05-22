Public Class FrmPowerCon

    Dim CurrMonth = 0
    Dim Amount = 0
    Private Sub FrmPowerCon_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadQuarter()
        loadMonth()
        LoadYear()
        clr()
        InitMsf()
    End Sub

    Sub clr()
        CmbQtrNo.Text = ""
        txtEmpId.Text = ""
        txtEmpName.Text = ""
        txtLocation.Text = ""
        txtLastRdg.Enabled = False
        txtCurrRdg.Enabled = False
        cmbMonth.Text = ""
        cmbyear.Text = ""
        txtLastRdg.Text = ""
        txtCurrRdg.Text = ""
        TxtUnits.Text = ""
        txtArrears.Text = "0"
        txtAmount.Text = ""
        cmbyear.Enabled = True
        cmbMonth.Enabled = True
        LoadMsf()
        BtnAdd.Enabled = False
        BtnDel.Enabled = False


    End Sub

    Sub loadQuarter()
        sql = "select * from employee order by QuarterNo"
        Rs = GetRecords(sql)
        CmbQtrNo.Items.Clear()
        Do While Not Rs.EOF
            CmbQtrNo.Items.Add(Rs(5).Value)
            Rs.MoveNext()
        Loop
    End Sub

    Private Sub CmbQtrNo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbQtrNo.SelectedIndexChanged
        sql = "select * from employee where QuarterNo='" & CmbQtrNo.Text & "'"
        Rs = GetRecords(sql)
        If Not Rs.EOF Then
            txtEmpId.Text = Rs(0).Value
            txtEmpName.Text = Rs(1).Value
            txtLocation.Text = Rs(6).Value
        End If
        sql = "select * from Location where Location='" & txtLocation.Text & "'"
        Rs = GetRecords(sql)
        If Not Rs.EOF Then
            txtFC.Text = Rs(1).Value
        End If
        sql = "select * from PowerCon where QtrNo='" & CmbQtrNo.Text & "' and empid=" & txtEmpId.Text & " order by PMonth desc,Pyear desc"
        Rs = GetRecords(sql)
        If Not Rs.EOF Then
            txtLastRdg.Text = Rs(6).Value
            txtLastRdg.Enabled = False
            cmbMonth.Text = MonthName(Rs(3).Value + 1)
            cmbMonth.Enabled = False
            cmbyear.Text = Rs(4).Value
            cmbyear.Enabled = False

        Else
            txtLastRdg.Enabled = True
        End If

        LoadMsf()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Sub loadMonth()
        Dim i = 1
        Do While i <= 12
            cmbMonth.Items.Add(MonthName(i))
            i = i + 1
        Loop
    End Sub

    Sub LoadYear()
        Dim i = 2009
        Do While i <= Year(Date.Today)
            cmbyear.Items.Add(i)
            i = i + 1
        Loop
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        clr()
        BtnAdd.Enabled = True
        txtCurrRdg.Enabled = True
    End Sub

    Private Sub txtCurrRdg_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCurrRdg.LostFocus
        If Val(txtCurrRdg.Text) < Val(txtLastRdg.Text) Then
            MsgBox("Current Reading must be Greater than Last Reading")
            txtCurrRdg.Text = txtLastRdg.Text
        End If
        CalUnits()
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

    Private Sub txtCurrRdg_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCurrRdg.TextChanged
        CalUnits()
        CalAmount()
    End Sub

    Sub InitMsf()
        MsfGrid.Clear()
        MsfGrid.Row = 0
        MsfGrid.Col = 0
        MsfGrid.Text = "Sl No"
        MsfGrid.Col = 1
        MsfGrid.Text = "Month"
        MsfGrid.Col = 2
        MsfGrid.Text = "Last Rdg"
        MsfGrid.Col = 3
        MsfGrid.Text = "Currrent Rdg"
        MsfGrid.Col = 4
        MsfGrid.Text = "Units"
        MsfGrid.Col = 5
        MsfGrid.Text = "Amount"
    End Sub

    Sub LoadMsf()
        InitMsf()
        Dim rowno = 1
        If CmbQtrNo.Text <> "" Then
            sql = "select * from powercon where qtrno='" & CmbQtrNo.Text & "' order by Pmonth"
            Rs = GetRecords(sql)
            Do While Not Rs.EOF
                MsfGrid.Row = rowno
                MsfGrid.Col = 0
                MsfGrid.Text = rowno
                MsfGrid.Col = 1
                MsfGrid.Text = MonthName(Rs(3).Value)
                MsfGrid.Col = 2
                MsfGrid.Text = Rs(5).Value
                MsfGrid.Col = 3
                MsfGrid.Text = Rs(6).Value
                MsfGrid.Col = 4
                MsfGrid.Text = Val(Rs(6).Value) - Val(Rs(5).Value)
                MsfGrid.Col = 5
                MsfGrid.Text = Rs(8).Value
                rowno = rowno + 1
                Rs.MoveNext()
            Loop
        End If
    End Sub

    Sub CalUnits()
        TxtUnits.Text = Val(txtCurrRdg.Text) - Val(txtLastRdg.Text)
    End Sub

    Sub CalAmount()
        Dim rate As Double
        Dim FromUnit As Integer
        Amount = 0
        sql = "select * from rateperunit order by FromUnit"
        Rs = GetRecords(sql)
        Do While Not Rs.EOF
            rate = Rs(2).Value
            FromUnit = Rs(0).Value
            If Val(TxtUnits.Text) >= Rs(1).Value Then
                If Rs(0).Value = 0 Then
                    Amount = Amount + (Rs(1).Value - Rs(0).Value) * rate
                Else
                    Amount = Amount + ((Rs(1).Value - Rs(0).Value) + 1) * rate
                End If
            Else
                Amount = Amount + (Val(TxtUnits.Text) - FromUnit + 1) * rate
                Exit Do
            End If
                Rs.MoveNext()
        Loop
        txtAmount.Text = Amount + Val(txtFC.Text)
        txtAmount.Text = Val(txtAmount.Text) * 1.05
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If CmbQtrNo.Text = "" Then
            MsgBox("Kindly selct Quarter no")
        ElseIf cmbMonth.Text = "" Then
            MsgBox("Kindly select Month")
        ElseIf cmbyear.Text = "" Then
            MsgBox("Kindly select Year")
        ElseIf txtLastRdg.Text = "" Then
            MsgBox("Kindly enter Last Meter Reading")
        ElseIf txtCurrRdg.Text = "" Then
            MsgBox("Kindly enter Current Meter Reading")
        Else
            sql = "insert into Powercon(Qtrno,EmpId,Pmonth,Pyear,LastRdg,CurrRdg,Amt) values('" & CmbQtrNo.Text & "'," & txtEmpId.Text & "," & IntMonth(cmbMonth.Text) & "," & cmbyear.Text & "," & txtLastRdg.Text & "," & txtCurrRdg.Text & "," & txtAmount.Text & ")"
            conn.Execute(sql)
            clr()
            MsgBox("Record Saved")
        End If
    End Sub

    Private Sub MsfGrid_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles MsfGrid.ClickEvent
        MsfGrid.Row = MsfGrid.RowSel
        MsfGrid.Col = 0
        If MsfGrid.Text <> "" Then
            MsfGrid.Col = 1
            cmbMonth.Text = MsfGrid.Text
            MsfGrid.Col = 2
            txtLastRdg.Text = MsfGrid.Text
            MsfGrid.Col = 3
            txtCurrRdg.Text = MsfGrid.Text
            BtnDel.Enabled = True
            BtnAdd.Enabled = False

        End If
    End Sub

    Private Sub MsfGrid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsfGrid.Enter

    End Sub

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        sql = "select * from powercon where QtrNo='" & CmbQtrNo.Text & "' and Pyear=" & cmbyear.Text & " order by Pmonth desc"
        Rs = GetRecords(sql)
        If Not Rs.EOF Then
            If cmbMonth.Text <> MonthName(Rs(3).Value) Then
                MsgBox("You cannot Delete Record Other than of Last Month")
            Else
                If MsgBox("Do you want to delete the record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    sql = "delete * from powercon where qtrno='" & CmbQtrNo.Text & "' and Pyear=" & cmbyear.Text & " and Pmonth=" & IntMonth(cmbMonth.Text) & ""
                    conn.Execute(sql)
                    clr()
                    MsgBox("Record Deleted")
                End If
            End If
        End If
    End Sub
End Class