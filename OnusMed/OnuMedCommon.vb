﻿Module OnuMedCommon
    Public Function getName(str As String) As String
        Try
            Dim tmpds As DataSet = New DataSet
            selectData("select name from medicine where code='" + str + "';", tmpds)
            Return tmpds.Tables(0).Rows(0).Item(0).ToString
        Catch ex As Exception
            Return vbNull
        End Try
    End Function

    Public Function getExp(str As String) As String
        Try
            Dim tmpds As New DataSet
            selectData("select date_format(expiry,'%d-%b-%Y') from inventory where batchcode='" + str + "';", tmpds)
            Return tmpds.Tables(0).Rows(0).Item(0).ToString
        Catch ex As Exception
            Return vbNull
        End Try
    End Function
End Module
