Public Class FrmLeaveSheet
    Dim sql As String


    Private Sub Cmbmonth_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmbmonth.SelectedIndexChanged

    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub FrmLeaveSheet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CLR()

    End Sub
    Sub CLR()
        Dim i, j
        For i = 1 To 12
            Cmbmonth.Items.Add(MonthName(i))
        Next
        For j = 2009 To Year(Date.Today)
            CmbYear.Items.Add(j)
        Next

    End Sub

    Sub initmsf()
        Dim i, days, rowNo
        msfGrid.Clear()
        sql = "select count(*) from employee"
        Rs = GetRecords(sql)
        msfGrid.Rows = Rs(0).Value + 1
        days = MonthDAys()
        i = 2
        msfGrid.set_ColWidth(1, 1700)
        Do While i <= 33
            msfGrid.set_ColWidth(i, 300)
            i = i + 1
        Loop
        msfGrid.Clear()
        msfGrid.Row = 0
        msfGrid.Col = 0
        msfGrid.CellFontBold = True
        msfGrid.Text = "Emp Id"
        msfGrid.Col = 1
        msfGrid.CellFontBold = True
        msfGrid.Text = "Name"
        i = 1
        Do While i <= days
            msfGrid.Col = i + 1
            msfGrid.Text = i
            Dim strDate
            strDate = i & "/" & IntMonth(Cmbmonth.Text) & "/" & CmbYear.Text
            sql = "select * from Holidays where hdate=format('" & strDate & "','dd/MM/yyyy')"
            Dim rs1 As New ADODB.Recordset
            rs1.Open(sql, conn)
            msfGrid.CellFontBold = True
            If Not rs1.EOF Then
                msfGrid.CellForeColor = Color.Blue
                msfGrid.CellBackColor = Color.Yellow
            End If
            If ChkSun(CDate(strDate)) = True Then
                msfGrid.CellForeColor = Color.Red
            End If
            i = i + 1
        Loop
        sql = "select * from employee"
        Rs = GetRecords(sql)
        rowNo = 1
        Do While Not Rs.EOF
            msfGrid.Row = rowNo
            msfGrid.Col = 0
            msfGrid.CellFontBold = True
            msfGrid.Text = Rs(0).Value
            msfGrid.Col = 1
            msfGrid.CellFontBold = True
            msfGrid.Text = Rs(1).Value
            For i = 1 To days
                msfGrid.Col = i + 1
                Dim strDate
                strDate = i & "/" & IntMonth(Cmbmonth.Text) & "/" & CmbYear.Text
                sql = "select * from Holidays where hdate=format('" & strDate & "','dd/MM/yyyy')"
                Dim rs1 As New ADODB.Recordset

                rs1.Open(sql, conn)

                If CDate(strDate) <= Date.Today Then
                    msfGrid.Text = "P"
                    msfGrid.CellFontBold = True
                    msfGrid.CellForeColor = Color.Green
                End If

                If Not rs1.EOF Then
                    msfGrid.Text = "H"
                    msfGrid.CellFontBold = True
                    msfGrid.CellForeColor = Color.Blue
                    msfGrid.CellBackColor = Color.Yellow
                End If
                If ChkSun(CDate(strDate)) = True Then
                    msfGrid.Text = "S"
                    msfGrid.CellFontBold = True
                    msfGrid.CellForeColor = Color.Red
                End If
                sql = "select * from leaveApp where empid='" & Rs(0).Value & "' and approval=true and fromdt<=format('" & strDate & "','dd/MM/yyyy') and  ToDt>format('" & strDate & "','dd/MM/yyyy')"
                If rs1.State = 1 Then rs1.Close()
                rs1.Open(sql, conn)
                If rs1.EOF = False Then
                    msfGrid.Text = "L"
                    msfGrid.CellFontBold = True
                    msfGrid.CellForeColor = Color.Brown
                End If

               
            Next
            rowNo = rowNo + 1
            Rs.MoveNext()
        Loop

    End Sub
    Function ChkSun(ByVal chkDate As Date)
        If Weekday(chkDate) = 1 Then
            Return (True)
        Else
            Return False
        End If
    End Function

    Function MonthDAys()
        Dim MonDays = 0
        Dim strdate, i, j
        For i = 1 To 31
            On Error GoTo l1
            strdate = CDate(i & "/" & IntMonth(Cmbmonth.Text) & "/" & Val(CmbYear.Text)).ToShortDateString
        Next
l1:
        MonDays = i - 1
        Return MonDays
    End Function

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

    Private Sub Btnshow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnshow.Click
        If CmbYear.Text = "" Then
            MsgBox("Kindly Select Year")
        ElseIf Cmbmonth.Text = "" Then
            MsgBox("Kindly Select Month")
        Else
            initmsf()
        End If

    End Sub
End Class