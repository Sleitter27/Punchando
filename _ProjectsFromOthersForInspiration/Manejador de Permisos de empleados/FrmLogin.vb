Public Class FrmLogin

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OpenDb()
    End Sub

    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        End
    End Sub

    Private Sub BtnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLogin.Click
        If txtUserName.Text = "" Then
            MsgBox("Kindly enter username")
        ElseIf txtPassword.Text = "" Then
            MsgBox("Kindly enter Password")
        Else
            Dim sql
            sql = "select * from login where username='" & txtUserName.Text & "'"
            Rs = GetRecords(sql)
            If Rs.EOF Then
                MsgBox("User name does not exists")
            Else
                If txtPassword.Text <> Rs(2).Value Then
                    MsgBox("Password does not match")
                Else
                    If UCase(txtUserName.Text) <> "ADMIN" Then
                        MDIMain.MasterToolStripMenuItem.Visible = False
                        MDIMain.LeaveToolStripMenuItem.Visible = False
                        MDIMain.ElectricityToolStripMenuItem.Visible = False
                    Else
                        MDIMain.AplyLeaveToolStripMenuItem.Visible = False
                    End If
                    Me.Hide()
                    MDIMain.Focus()
                    MDIMain.BringToFront()
                    MDIMain.Show()

                End If
            End If
        End If
    End Sub

    Private Sub txtUserName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtUserName.TextChanged
        txtUserName.Text = UCase(txtUserName.Text)
        txtUserName.SelectionStart = Len(txtUserName.Text)
    End Sub
End Class
