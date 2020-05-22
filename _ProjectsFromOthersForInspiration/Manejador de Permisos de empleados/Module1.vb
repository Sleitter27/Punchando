Public Module Module1
    Public conn As New ADODB.Connection
    Public Rss As New ADODB.Recordset
    Public Rs As New ADODB.Recordset
    Public sql As String

    Public Function OpenDb()
        If conn.State = 1 Then conn.Close()
        conn.Open("Provider=Microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\KIOCL.mdb")
        Return (0)
    End Function

    Public Function GetRecords(ByVal Sql As String)
        If Rss.State = 1 Then Rss.Close()
        Rss.Open(Sql, conn)
        Return (Rss)
    End Function

    Function CheckAlpha(ByVal e As KeyEventArgs)
        If e.KeyCode > 48 And e.KeyCode < 57 Then
            e.SuppressKeyPress = True
        End If
        Return 0
    End Function

    Function CheckNum(ByVal e As KeyEventArgs)
        If e.KeyCode < 48 Or e.KeyCode > 57 Then
            e.SuppressKeyPress = True
        End If
        Return 0
    End Function
End Module

