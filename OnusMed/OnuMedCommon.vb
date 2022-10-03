Module OnuMedCommon
    Public Function getName(str As String) As String
        Try
            Dim tmpds As DataSet = New DataSet
            selectData("select name from medicine where code='" + str + "';", tmpds)
            Return tmpds.Tables(0).Rows(0).Item(0).ToString
        Catch ex As Exception
            Return vbNull
        End Try
    End Function
End Module
