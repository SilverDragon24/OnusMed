Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports MySql.Data.MySqlClient
Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Common
Imports System.Drawing
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System.Windows.Forms

Public Module SilverNexusPlatform
    Public server As String = ""
    Public db As String = "med_test"
    Public user As String = ""
    Public pwd As String = ""
    Public trial As Integer = 900
    Public conn As MySqlConnection = New MySqlConnection()
    Public da As MySqlDataAdapter = New MySqlDataAdapter()
    Public employee As String = ""
    Public post As String = ""
    Public purchasing As Boolean = False
    Public selling As Boolean = False
    Public pret As Boolean = False
    Public sret As Boolean = False
    Public selected As String = ""

    Public Function choosePeptide(n As String) As String
        Dim str As String = Nothing
        Dim rnd As Random = New Random()
        Dim i0() As String = {"A", "G"}
        Dim i1() As String = {"C", "T"}
        If n.Equals("0") = True Then
            str = i0(rnd.Next(0, 65536) Mod 2)
        ElseIf n.Equals("1") = True Then
            str = i1(rnd.Next(0, 65536) Mod 2)
        End If
        Return str
    End Function

    Public Function CloseDB() As Integer
        Dim num As Integer
        Try
            conn.Close()
            num = 1
        Catch exception As System.Exception
            num = 0
        End Try
        Return num
    End Function

    Public Function cmbNumChk(temp As ComboBox, str As String) As Integer
        Dim num As Integer = 0
        If (Not IsNumeric(str)) Then
            temp.BackColor = Color.Pink
            num = 0
        ElseIf (str.Length > 0 And IsNumeric(str)) Then
            temp.BackColor = Color.LightGreen
            num = 1
        End If
        Return num
    End Function

    Public Function ConnectDB(db0 As String) As Integer
        Dim num As Integer
        Try
            If (conn IsNot Nothing) Then
                conn.Close()
            End If
            conn.ConnectionString = String.Format("server={0};port=3306; user id={1}; password={2}; database={3}; pooling=false; SslMode=none;", server, user, pwd, db0)
            conn.Open()
            num = 1
        Catch exception As System.Exception
            Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, Nothing)
            num = 0
        End Try
        Return num
    End Function

    Public Function createConfigFile(s As String, u As String, p As String) As Boolean
        Dim flag As Boolean = False
        Dim filepath As String = String.Concat(Application.StartupPath, "\SilverNexus.cfg")
        If (System.IO.File.Exists(filepath) = True) Then
            System.IO.File.Delete(filepath)
        End If
        Using fileStream As System.IO.FileStream = System.IO.File.Create(filepath)
        End Using
        Dim file As StreamWriter = New StreamWriter(filepath)
        Dim str As String = s
        Dim num As Integer = 0
        While num < str.Length
            Dim chr As Char = str(num)
            Dim str1 As String = Convert.ToString(Asc(chr), 2).PadLeft(8, "0")
            Dim str2 As String = str1
            Dim num1 As Integer = 0
            While num1 < str2.Length
                Dim chr1 As Char = str2(num1)
                file.Write(choosePeptide(chr1.ToString()))
                num1 = num1 + 1
            End While
            num = num + 1
        End While
        file.WriteLine()
        Dim str3 As String = u
        Dim num2 As Integer = 0
        While num2 < str3.Length
            Dim chr2 As Char = str3(num2)
            Dim str4 As String = Convert.ToString(Asc(chr2), 2).PadLeft(8, "0")
            Dim str5 As String = str4
            Dim num3 As Integer = 0
            While num3 < str5.Length
                Dim chr3 As Char = str5(num3)
                file.Write(choosePeptide(chr3.ToString()))
                num3 = num3 + 1
            End While
            num2 = num2 + 1
        End While
        file.WriteLine()
        Dim str6 As String = p
        Dim num4 As Integer = 0
        While num4 < str6.Length
            Dim c As Char = str6(num4)
            Dim temp As String = Convert.ToString(Asc(c), 2).PadLeft(8, "0")
            Dim str7 As String = temp
            Dim num5 As Integer = 0
            While num5 < str7.Length
                Dim t As Char = str7(num5)
                file.Write(choosePeptide(t.ToString()))
                num5 = num5 + 1
            End While
            num4 = num4 + 1
        End While
        file.Close()
        Return flag
    End Function

    Public Function createDB(query As String) As Integer
        Dim num As Integer
        Try
            If (conn IsNot Nothing) Then
                Dim mySqlCommand As MySqlCommand = New MySqlCommand() With
                    {
                        .CommandType = CommandType.Text,
                        .CommandText = query,
                        .Connection = conn
                    }
                mySqlCommand.ExecuteNonQuery()
                num = 1
            Else
                ConnectDB(db)
                Dim cmd As MySqlCommand = New MySqlCommand() With
                    {
                        .CommandType = CommandType.Text,
                        .CommandText = query,
                        .Connection = conn
                    }
                cmd.ExecuteNonQuery()
                num = 1
            End If
        Catch exception As System.Exception
            num = 0
        End Try
        Return num
    End Function

    Public Function decodePeptide(n As String) As String
        Dim str As String = Nothing
        If n.Equals("A") = True Or n.Equals("G") = True Then
            str = "0"
        ElseIf n.Equals("C") = True Or n.Equals("T") = True Then
            str = "1"
        End If
        Return str
    End Function

    Public Function encrypt(str As String) As String
        Dim Osha1 As New System.Security.Cryptography.SHA1CryptoServiceProvider
        Dim bytestosha1() As Byte = System.Text.Encoding.ASCII.GetBytes(str)
        Dim strsha1 As String = ""
        bytestosha1 = Osha1.ComputeHash(bytestosha1)
        For Each item As Byte In bytestosha1
            strsha1 += item.ToString("x2")
        Next
        Dim Osha256 As New System.Security.Cryptography.SHA256CryptoServiceProvider
        Dim bytestosha256() As Byte = System.Text.Encoding.ASCII.GetBytes(strsha1)
        Dim strsha256 As String = ""
        bytestosha256 = Osha256.ComputeHash(bytestosha256)
        For Each item As Byte In bytestosha256
            strsha256 += item.ToString("x2")
        Next
        Dim Osha384 As New System.Security.Cryptography.SHA384CryptoServiceProvider
        Dim bytestosha384() As Byte = System.Text.Encoding.ASCII.GetBytes(strsha256)
        Dim strsha384 As String = ""
        bytestosha384 = Osha384.ComputeHash(bytestosha384)
        For Each item As Byte In bytestosha384
            strsha384 += item.ToString("x2")
        Next
        Dim Osha512 As New System.Security.Cryptography.SHA512CryptoServiceProvider
        Dim bytestosha512() As Byte = System.Text.Encoding.ASCII.GetBytes(strsha384)
        Dim strsha512 As String = ""
        bytestosha512 = Osha512.ComputeHash(bytestosha512)
        For Each item As Byte In bytestosha512
            strsha512 += item.ToString("x2")
        Next
        Dim Omd5 As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bytestomd5() As Byte = System.Text.Encoding.ASCII.GetBytes(strsha512)
        Dim strmd5 As String = ""
        bytestomd5 = Omd5.ComputeHash(bytestomd5)
        For Each item As Byte In bytestomd5
            strmd5 += item.ToString("x2")
        Next
        Return strmd5
    End Function

    Public Function generateID() As String
        Dim year As Integer = DateTime.Today.Year
        Dim yr As String = year.ToString()
        year = DateTime.Today.Month
        Dim m As String = year.ToString()
        If (m.Length = 1) Then
            m = String.Concat("0", m)
        End If
        year = DateTime.Today.Day
        Dim d As String = year.ToString()
        If (d.Length = 1) Then
            d = String.Concat("0", d)
        End If
        year = DateTime.Now.Hour
        Dim h As String = year.ToString()
        If (h.Length = 1) Then
            h = String.Concat("0", h)
        End If
        year = DateTime.Now.Minute
        Dim mm As String = year.ToString()
        If (mm.Length = 1) Then
            mm = String.Concat("0", mm)
        End If
        year = DateTime.Now.Second
        Dim ss As String = year.ToString()
        If (ss.Length = 1) Then
            ss = String.Concat("0", ss)
        End If
        Return String.Concat(New String() {yr, m, d, h, mm, ss})
    End Function

    Public Function manipulateData(query As String) As Integer
        Dim num As Integer
        Try
            Dim lfs As FileStream = Nothing
            Dim lfilepath As String = String.Concat(Application.ExecutablePath.ToString(), ".log")
            If (Not File.Exists(lfilepath)) Then
                lfs = File.Create(lfilepath)
            End If
            Using lfs
            End Using
            Dim lfile As StreamWriter = New StreamWriter(lfilepath, True)
            lfile.WriteLine(query)
            lfile.Close()
            If (conn IsNot Nothing) Then
                Dim mySqlCommand As MySqlCommand = New MySqlCommand() With
                {
                    .CommandType = CommandType.Text,
                    .CommandText = query,
                    .Connection = conn
                }
                mySqlCommand.ExecuteNonQuery()
                num = 1
            Else
                ConnectDB(db)
                Dim cmd As MySqlCommand = New MySqlCommand() With
                {
                    .CommandType = CommandType.Text,
                    .CommandText = query,
                    .Connection = conn
                }
                cmd.ExecuteNonQuery()
                num = 1
            End If
        Catch exception As System.Exception
            MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, Nothing)
            num = 0
        End Try
        Return num
    End Function

    Public Function readConfig() As Boolean
        Dim flag As Boolean
        Dim filepath As String = String.Concat(Application.StartupPath, "\SilverNexus.cfg")
        If (File.Exists(filepath) = True) Then
            Dim reader As StreamReader = New StreamReader(filepath)
            Dim i As Integer = 0
            Do
                Dim lineDNA As String = reader.ReadLine()
                Dim lineBin As String = ""
                Dim line As String = ""
                Dim ascii As Integer = 0
                If (Not IsNothing(lineDNA)) Then
                    Dim str As String = lineDNA
                    Dim chr() As Char = str.ToCharArray
                    Dim num As Integer = 0
                    While num < str.Length
                        Dim c As Char = chr(num)
                        lineBin = String.Concat(lineBin, decodePeptide(c.ToString))
                        num = num + 1
                    End While
                End If
                Dim characters As List(Of String) = New List(Of String)()
                Dim length As Integer = lineBin.Length - 1
                Dim num1 As Integer = 0
                Do
                    characters.Add(lineBin.Substring(num1, 8))
                    num1 = num1 + 8
                Loop While num1 <= length
                Dim count As Integer = characters.Count - 1
                Dim j As Integer = 0
                Do
                    Dim i7 As Integer = Math.Round(Integer.Parse(Conversions.ToString(characters(j).ToCharArray()(0))) * Math.Pow(2, 7))
                    Dim i6 As Integer = Math.Round(Integer.Parse(Conversions.ToString(characters(j).ToCharArray()(1))) * Math.Pow(2, 6))
                    Dim i5 As Integer = Math.Round(Integer.Parse(Conversions.ToString(characters(j).ToCharArray()(2))) * Math.Pow(2, 5))
                    Dim i4 As Integer = Math.Round(Integer.Parse(Conversions.ToString(characters(j).ToCharArray()(3))) * Math.Pow(2, 4))
                    Dim i3 As Integer = Math.Round(Integer.Parse(Conversions.ToString(characters(j).ToCharArray()(4))) * Math.Pow(2, 3))
                    Dim i2 As Integer = Math.Round(Integer.Parse(Conversions.ToString(characters(j).ToCharArray()(5))) * Math.Pow(2, 2))
                    Dim i1 As Integer = Math.Round(Integer.Parse(Conversions.ToString(characters(j).ToCharArray()(6))) * Math.Pow(2, 1))
                    Dim i0 As Integer = Integer.Parse(Conversions.ToString(characters(j).ToCharArray()(7))) * 1
                    ascii = i0 + i1 + i2 + i3 + i4 + i5 + i6 + i7
                    Dim chr As Char = Strings.ChrW(ascii)
                    line = String.Concat(line, chr.ToString())
                    j = j + 1
                Loop While j <= count
                If (i = 0) Then
                    server = line
                ElseIf (i = 1) Then
                    user = line
                ElseIf (i = 2) Then
                    pwd = line
                End If
                i = i + 1
            Loop While i <= 2
            flag = True
        Else
            flag = False
        End If
        Return flag
    End Function

    Public Function selectData(query As String, ds As DataSet) As Integer
        Dim num As Integer
        Try
            Dim lfs As FileStream = Nothing
            Dim lfilepath As String = String.Concat(Application.ExecutablePath.ToString(), ".log")
            If (Not File.Exists(lfilepath)) Then
                lfs = File.Create(lfilepath)
            End If
            Using lfs
            End Using
            Dim lfile As StreamWriter = New StreamWriter(lfilepath, True)
            lfile.WriteLine(query)
            lfile.Close()
            If (conn IsNot Nothing) Then
                Dim mySqlCommand As MySqlCommand = New MySqlCommand()
                Try
                    ds.Clear()
                    ds.Tables.Clear()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                'ds = New DataSet()
                mySqlCommand.CommandType = CommandType.Text
                mySqlCommand.CommandText = query
                mySqlCommand.Connection = conn
                da = New MySqlDataAdapter(mySqlCommand)
                da.Fill(ds)
                num = 1
            Else
                ConnectDB(db)
                Dim cmd As MySqlCommand = New MySqlCommand()
                Try
                    ds.Clear()
                    ds.Tables.Clear()
                Catch ex As Exception
                    MsgBox(ex.ToString)
                End Try
                'ds = New DataSet()
                cmd.CommandType = CommandType.Text
                cmd.CommandText = query
                cmd.Connection = conn
                da = New MySqlDataAdapter(cmd)
                da.Fill(ds)
                num = 1
            End If
        Catch exception As System.Exception
            MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, Nothing)
            num = 0
        End Try
        Return num
    End Function

    Public Function setDB(d As String) As Boolean
        Dim flag As Boolean = False
        Return flag
    End Function

    Public Function txtNumChk(temp As TextBox, str As String) As Integer
        Dim num As Integer = 0
        If (Not IsNumeric(str)) Then
            temp.BackColor = Color.Pink
            num = 0
        ElseIf (str.Length > 0 And IsNumeric(str)) Then
            temp.BackColor = Color.LightGreen
            num = 1
        End If
        Return num
    End Function

    Public Function validCmb(temp As ComboBox, str As String) As Integer
        Dim num As Integer = 0
        If (str.Length = 0) Then
            temp.BackColor = Color.Pink
            num = 0
        ElseIf (str.Length > 0) Then
            temp.BackColor = Color.LightGreen
            num = 1
        End If
        Return num
    End Function

    Public Function validTxt(temp As TextBox, str As String) As Integer
        Dim num As Integer = 0
        If (str.Length = 0) Then
            temp.BackColor = Color.Pink
            num = 0
        ElseIf (str.Length > 0) Then
            temp.BackColor = Color.LightGreen
            num = 1
        End If
        Return num
    End Function
End Module
