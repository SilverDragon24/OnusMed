Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class SchedFilter
    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        Dim value As DateTime = dateFrom.Value
        Dim dfrom As String = value.ToString("yyyy-MM-dd")
        value = dateTo.Value
        Dim dto As String = value.ToString("yyyy-MM-dd")
        Dim codes As DataSet = New DataSet()
        selectData(String.Concat("select code from medicine where sched='", cmbSched.Text, "';"), codes)
        Dim docpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString()
        Dim folderpath As String = String.Concat(docpath, "\Onus_SchedFilter")
        If (Not Directory.Exists(folderpath)) Then
            Directory.CreateDirectory(folderpath)
        End If
        value = DateTime.Now
        Dim filepath As String = String.Concat(folderpath, "\Onus_Schedule_Report_", value.ToString("MM.dd.yyyy_HH.mm.ss"), ".html")
        Using fileStream As System.IO.FileStream = System.IO.File.Create(filepath)
        End Using
        Dim file As StreamWriter = New StreamWriter(filepath)
        file.WriteLine("<html>")
        file.WriteLine(String.Concat("<title>Schedule Filtered Report for Schedule ", cmbSched.Text, " Drugs</title>"))
        file.WriteLine("<head>")
        file.WriteLine("<style media=""screen"" type=""text/css"">")
        file.WriteLine("@media print {")
        file.WriteLine("thead {display: table-header-group;}")
        file.WriteLine("}")
        file.WriteLine("</style>")
        file.WriteLine("</head>")
        file.WriteLine("<body>")
        file.WriteLine(String.Concat("<center><h1>Schedule Filtered Report for Schedule ", cmbSched.Text, " Drugs</h1></center>"))
        file.WriteLine("<table border=1 width=100%>")
        file.Write("<tr>")
        file.Write("<th>Date</th><th>Item Code</th><th>Item Name</th><th>Patient ID</th><th>Name</th><th>Packs</th><th>Strips</th><th>Pieces</th><th>Doctor Reg.</th><th>Doctor</th>")
        file.WriteLine("</tr>")
        Try
            If (codes.Tables(0).Rows.Count > 0) Then
                Dim count As Integer = codes.Tables(0).Rows.Count - 1
                For i As Integer = 0 To count Step 1
                    Dim info As DataSet = New DataSet()
                    selectData(String.Concat(New String() {"select date_format(s.idate,'%d-%b-%Y'),s.icode,(select name from medicine m where m.code=s.icode),s.pid,s.pname,s.pack_q,s.stripq,s.pieceq,s.pdoctor_reg,s.pdoctor_name from sales s where s.icode='", codes.Tables(0).Rows(i)(0).ToString(), "' and (s.idate between '", dfrom, "' and '", dto, "');"}), info)
                    If (info.Tables(0).Rows.Count > 0) Then
                        Dim num As Integer = info.Tables(0).Rows.Count - 1
                        For j As Integer = 0 To num Step 1
                            file.Write("<tr>")
                            file.Write(String.Concat("<td>", info.Tables(0).Rows(i)(0).ToString(), "</td>"))
                            file.Write(String.Concat("<td>", info.Tables(0).Rows(i)(1).ToString(), "</td>"))
                            file.Write(String.Concat("<td>", info.Tables(0).Rows(i)(2).ToString(), "</td>"))
                            file.Write(String.Concat("<td>", info.Tables(0).Rows(i)(3).ToString(), "</td>"))
                            file.Write(String.Concat("<td>", info.Tables(0).Rows(i)(4).ToString(), "</td>"))
                            file.Write(String.Concat("<td>", info.Tables(0).Rows(i)(5).ToString(), "</td>"))
                            file.Write(String.Concat("<td>", info.Tables(0).Rows(i)(6).ToString(), "</td>"))
                            file.Write(String.Concat("<td>", info.Tables(0).Rows(i)(7).ToString(), "</td>"))
                            file.Write(String.Concat("<td>", info.Tables(0).Rows(i)(8).ToString(), "</td>"))
                            file.Write(String.Concat("<td>", info.Tables(0).Rows(i)(9).ToString(), "</td>"))
                            file.WriteLine("</tr>")
                        Next

                    End If
                Next

            End If
        Catch exception As System.Exception

        End Try
        file.WriteLine("</table>")
        file.WriteLine("</body>")
        file.WriteLine("</html>")
        file.Close()
        Process.Start(filepath)
    End Sub

    Private Sub SchedFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim sched As DataSet = New DataSet()
        selectData("select distinct sched from medicine", sched)
        Try
            If (sched.Tables(0).Rows.Count > 0) Then
                Dim count As Integer = sched.Tables(0).Rows.Count - 1
                For i As Integer = 0 To count Step 1
                    If (Not cmbSched.Items.Contains(sched.Tables(0).Rows(i)(0).ToString())) Then
                        cmbSched.Items.Add(sched.Tables(0).Rows(i)(0).ToString())
                    End If
                Next

            End If
        Catch exception As System.Exception

        End Try
        Timer1.Interval = 50
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (DateTime.Compare(dateFrom.Value, dateTo.Value) <= 0) Then
            btnReport.Enabled = True
        Else
            btnReport.Enabled = False
        End If
    End Sub
End Class