Public Class FrmDesignation
    Dim sql
    Private Sub FolderBrowserDialog1_HelpRequest(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FolderBrowserDialog1.HelpRequest

    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        If TxtDesdesc.Text = "" Then
            MsgBox("Please Enter the Description ")
        ElseIf TxtDesName.Text = "" Then
            MsgBox("Please Enter the Designation ")
        Else
            sql = "Select * from Designation where DesId='" & TxtDesName.Text & "'"
            Rs = GetRecords(sql)
            If Not Rs.EOF Then
                MsgBox("Designation Already exsist")
            Else
                sql = "insert into designation(DesId,DesName) values('" & TxtDesName.Text & "','" & TxtDesdesc.Text & "')"
                conn.Execute(sql)
                MsgBox("record has been saved")
                Clr()
            End If
        End If
    End Sub

    Private Sub TxtdesId_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDesName.TextChanged

    End Sub

    Private Sub FrmDesignation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Clr()

    End Sub
    
    Sub Clr()
        TxtDesName.Text = ""
        TxtDesdesc.Text = ""
        BtnNew.Enabled = True
        BtnAdd.Enabled = False
        BtnDelete.Enabled = False
        BtnModify.Enabled = False
        TxtDesName.Enabled = True

        LoadMsf()
    End Sub
    Sub initMsf()
        MsfGrid.Clear()
        MsfGrid.Row = 0
        MsfGrid.Col = 0
        MsfGrid.Text = "Id"
        MsfGrid.Col = 1
        MsfGrid.Text = "Designation"
    End Sub
    Sub LoadMsf()
        Dim i
        i = 1
        initMsf()
        sql = "Select * from Designation order by DesId"
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
            sql = "update Designation set DesName='" & TxtDesdesc.Text & "' where DesId='" & TxtDesName.Text & "'"
            conn.Execute(sql)
            MsgBox("Record has been Updated Succesfully")
            Clr()

        End If
    End Sub

    Private Sub BtnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDelete.Click
        If MsgBox("Do you want to delete the item", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            sql = "delete * from Designation where DesId='" & TxtDesName.Text & "'"
            conn.Execute(sql)
            MsgBox("Record has been deleted Succesfully")
            Clr()

        End If
    End Sub

    Private Sub TxtDesName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDesdesc.TextChanged
        TxtDesdesc.Text = UCase(TxtDesdesc.Text)
        TxtDesdesc.SelectionStart = Len(TxtDesdesc.Text)
        If UCase(MsfGrid.Text) = TxtDesdesc.Text Or TxtDesdesc.Text = "" Then
            BtnModify.Enabled = False
        Else
            BtnModify.Enabled = True
        End If
    End Sub

    Private Sub MsfGrid_ClickEvent(ByVal sender As Object, ByVal e As System.EventArgs) Handles MsfGrid.ClickEvent
        MsfGrid.Row = MsfGrid.RowSel
        MsfGrid.Col = 0
        TxtDesName.Text = MsfGrid.Text
        MsfGrid.Col = 1
        TxtDesdesc.Text = MsfGrid.Text
        BtnDelete.Enabled = True
        BtnModify.Enabled = False
        TxtDesName.Enabled = False


    End Sub

    Private Sub MsfGrid_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MsfGrid.Enter

    End Sub
End Class