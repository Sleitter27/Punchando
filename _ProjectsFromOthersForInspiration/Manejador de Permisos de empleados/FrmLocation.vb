Public Class FrmLocation

    Dim sql
    Private Sub FolderBrowserDialog1_HelpRequest(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If TxtLocation.Text = "" Then
            MsgBox("Please Enter the Location ")
        ElseIf TxtFC.Text = "" Then
            MsgBox("Please Enter the Fixed Cost for Power ")

        Else
            sql = "Select * from Location where Location='" & TxtLocation.Text & "'"
            Rs = GetRecords(sql)
            If Not Rs.EOF Then
                MsgBox("Location Already exsist")
            Else
                sql = "insert into Location(Location,FC) values('" & TxtLocation.Text & "'," & TxtFC.Text & ")"
                conn.Execute(sql)
                Clr()
                MsgBox("record has been saved")
            End If
        End If
    End Sub

    Private Sub TxtdesId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtLocation.TextChanged

    End Sub

    Private Sub FrmDesignation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clr()

    End Sub

    Sub Clr()
        TxtLocation.Text = ""
        TxtFC.Text = ""
        BtnNew.Enabled = True
        BtnAdd.Enabled = False
        BtnDelete.Enabled = False
        BtnModify.Enabled = False
        TxtLocation.Enabled = True

        LoadMsf()
    End Sub
    Sub initMsf()
        MsfGrid.Clear()
        MsfGrid.Row = 0
        MsfGrid.Col = 0
        MsfGrid.Text = "Location"
        MsfGrid.Col = 1
        MsfGrid.Text = "Fixed Cost"
    End Sub
    Sub LoadMsf()
        Dim i
        i = 1
        initMsf()
        sql = "Select * from Location order by Location"
        Rs = GetRecords(sql)
        Do While Not Rs.EOF
            MsfGrid.Row = i
            MsfGrid.Col = 0
            MsfGrid.Text = Rs(0).Value
            MsfGrid.Col = 1
            MsfGrid.Text = Rs(1).Value
            i = i + 1
            Rs.MoveNext()


        Loop
    End Sub

    Private Sub BtnNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNew.Click
        Clr()

        BtnAdd.Enabled = True

    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        Me.Close()
    End Sub

    Private Sub BtnModify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnModify.Click
        If MsgBox("Do you want to Modify the item", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "update Location set FC=" & TxtFC.Text & " where Location='" & TxtLocation.Text & "'"
            conn.Execute(sql)
            MsgBox("Record has been Updated Succesfully")
            Clr()

        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Do you want to delete the item", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "delete * from Location where Location='" & TxtLocation.Text & "'"
            conn.Execute(sql)
            MsgBox("Record has been deleted Succesfully")
            Clr()

        End If
    End Sub

    Private Sub TxtDesName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFC.TextChanged
        TxtFC.Text = UCase(TxtFC.Text)
        TxtFC.SelectionStart = Len(TxtFC.Text)
        If UCase(MsfGrid.Text) = TxtFC.Text Or TxtFC.Text = "" Then
            BtnModify.Enabled = False
        Else
            BtnModify.Enabled = True
        End If
    End Sub

    Private Sub MsfGrid_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles MsfGrid.ClickEvent
        MsfGrid.Row = MsfGrid.RowSel
        MsfGrid.Col = 0
        TxtLocation.Text = MsfGrid.Text
        MsfGrid.Col = 1
        TxtFC.Text = MsfGrid.Text
        BtnDelete.Enabled = True
        BtnModify.Enabled = False
        TxtLocation.Enabled = False


    End Sub
End Class