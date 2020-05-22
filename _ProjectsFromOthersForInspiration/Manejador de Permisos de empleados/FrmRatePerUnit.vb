Public Class FrmRatePerUnit

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        clr()
        BtnAdd.Enabled = True
    End Sub

    Sub clr()
        txtFromUnit.Text = ""
        txtToUnit.Text = ""
        txtRate.Text = ""
        txtFromUnit.Enabled = True
        txtToUnit.Enabled = True
        BtnAdd.Enabled = False
        BtnDel.Enabled = False
        BtnModify.Enabled = False
        LoadMsf()
    End Sub

    Private Sub FrmRatePerUnit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        clr()
    End Sub

    Sub LoadMsf()
        MsfGrid.Clear()
        MsfGrid.Row = 0
        MsfGrid.Col = 0
        MsfGrid.Text = "From"
        MsfGrid.Col = 1
        MsfGrid.Text = "To"
        MsfGrid.Col = 2
        MsfGrid.Text = "Rate"
        Dim rowno = 1
        sql = "select * from RatePerUnit order by FromUnit"
        Rs = GetRecords(sql)
        Do While Not Rs.EOF
            MsfGrid.Row = rowno
            MsfGrid.Col = 0
            MsfGrid.Text = Rs(0).Value
            MsfGrid.Col = 1
            MsfGrid.Text = Rs(1).Value
            MsfGrid.Col = 2
            MsfGrid.Text = Rs(2).Value
            rowno = rowno + 1
            Rs.MoveNext()
        Loop
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If txtFromUnit.Text = "" Then
            MsgBox("Kindly enter the From Unit")
        ElseIf txtToUnit.Text = "" Then
            MsgBox("Kindly enter the To Unit ")
        ElseIf txtRate.Text = "" Then
            MsgBox("Kindly enter Rate")
        Else
            sql = "select * from RatePerUnit where FromUnit=" & txtFromUnit.Text
            Rs = GetRecords(sql)
            If Not Rs.EOF Then
                MsgBox("Entry for this From value is already made")
            Else
                sql = "select * from RatePerUnit where tounit=" & txtToUnit.Text
                Rs = GetRecords(sql)
                If Not Rs.EOF Then
                    MsgBox("Entry for this To value is already made")
                Else
                    sql = "insert into RatePerUnit values(" & txtFromUnit.Text & "," & txtToUnit.Text & "," & txtRate.Text & ")"
                    conn.Execute(sql)
                    clr()
                    MsgBox("Record Saved")
                End If
            End If
        End If
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnDel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDel.Click
        If MsgBox("Do you want to delete the record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "delete * from RatePerUnit where FromUnit=" & txtFromUnit.Text & " and tounit=" & txtToUnit.Text
            conn.Execute(sql)
            clr()
            MsgBox("Record Deleted")
        End If
    End Sub

    Private Sub BtnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModify.Click
        If MsgBox("Do you want to Edit the record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "update RatePerUnit set rate=" & txtRate.Text & " where FromUnit=" & txtFromUnit.Text & " and tounit=" & txtToUnit.Text
            conn.Execute(sql)
            clr()
            MsgBox("Record Deleted")
        End If
    End Sub

    Private Sub MsfGrid_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles MsfGrid.ClickEvent
        MsfGrid.Row = MsfGrid.RowSel
        MsfGrid.Col = 0
        If MsfGrid.Text <> "" Then
            txtFromUnit.Text = MsfGrid.Text
            MsfGrid.Col = 1
            txtToUnit.Text = MsfGrid.Text
            MsfGrid.Col = 2
            txtRate.Text = MsfGrid.Text
            BtnModify.Enabled = True
            BtnDel.Enabled = True
            txtFromUnit.Enabled = False
            txtToUnit.Enabled = False
        Else
            clr()
        End If
    End Sub

    Private Sub MsfGrid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsfGrid.Enter

    End Sub

    Private Sub txtRate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRate.KeyDown
        CheckNum(e)
    End Sub


    Private Sub txtRate_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRate.TextChanged

    End Sub
End Class