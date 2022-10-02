Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class CreditReport
    Private Sub btnGetReport_Click(sender As Object, e As EventArgs) Handles btnGetReport.Click
        Dim now As DateTime
        If (radioSupplier.Checked) Then
            Dim str As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString()
            Dim str1 As String = String.Concat(str, "\CreditReports")
            If Not Directory.Exists(str1) Then
                Directory.CreateDirectory(str1)
            End If
            now = DateTime.Now
            Dim str2 As String = String.Concat(str1, "\SupplierCreditReport_", now.ToString("MM.dd.yyyy_HH.mm.ss"), ".html")
            Using fileStream As System.IO.FileStream = System.IO.File.Create(str2)
            End Using
            Dim streamWriter As System.IO.StreamWriter = New System.IO.StreamWriter(str2)
            streamWriter.WriteLine("<html>")
            now = DateTime.Today
            streamWriter.WriteLine(String.Concat("<title>Supplier Credit Report for ", now.ToString("MM-dd-yyyy"), "</title>"))
            streamWriter.WriteLine("<head>")
            streamWriter.WriteLine("<style media=""screen"" type=""text/css"">")
            streamWriter.WriteLine("@media print {")
            streamWriter.WriteLine("thead {display: table-header-group;}")
            streamWriter.WriteLine("}")
            streamWriter.WriteLine("</style>")
            streamWriter.WriteLine("</head>")
            streamWriter.WriteLine("<body>")
            now = DateTime.Today
            streamWriter.WriteLine(String.Concat("<center><h1>Supplier Credit Report for ", now.ToString("MM-dd-yyyy"), "</h1></center>"))
            streamWriter.WriteLine("<table border=1 width=100%>")
            Dim dataSet As System.Data.DataSet = New System.Data.DataSet()
            selectData("select id,name,credit from supplier where credit>0", dataSet)
            streamWriter.WriteLine("<tr><th>ID</th><th>Name</th><th>Credit</th></tr>")
            If (dataSet.Tables(0).Rows.Count > 0) Then
                Dim count As Integer = dataSet.Tables(0).Rows.Count - 1
                For num As Integer = 0 To count Step 1
                    streamWriter.WriteLine("<tr>")
                    streamWriter.Write(String.Concat("<td>", dataSet.Tables(0).Rows(num)(0).ToString(), "</td>"))
                    streamWriter.Write(String.Concat("<td>", dataSet.Tables(0).Rows(num)(1).ToString(), "</td>"))
                    streamWriter.WriteLine(String.Concat("<td>", dataSet.Tables(0).Rows(num)(2).ToString(), "</td>"))
                    streamWriter.WriteLine("</tr>")
                Next

            End If
            streamWriter.WriteLine("</table>")
            streamWriter.WriteLine("</body>")
            streamWriter.WriteLine("</html>")
            streamWriter.Close()
            If ConvertToPdf(str2) = False Then
                Process.Start(str2)
            End If
        ElseIf (radioPatient.Checked) Then
            Dim docpath As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal).ToString()
            Dim folderpath As String = String.Concat(docpath, "\CreditReports")
            If (Not Directory.Exists(folderpath)) Then
                Directory.CreateDirectory(folderpath)
            End If
            now = DateTime.Now
            Dim filepath As String = String.Concat(folderpath, "\PatientCreditReport_", now.ToString("MM.dd.yyyy_HH.mm.ss"), ".html")
            Using fileStream1 As System.IO.FileStream = System.IO.File.Create(filepath)
            End Using
            Dim file As System.IO.StreamWriter = New System.IO.StreamWriter(filepath)
            file.WriteLine("<html>")
            now = DateTime.Today
            file.WriteLine(String.Concat("<title>Patient Credit Report for ", now.ToString("MM-dd-yyyy"), "</title>"))
            file.WriteLine("<head>")
            file.WriteLine("<style media=""screen"" type=""text/css"">")
            file.WriteLine("@media print {")
            file.WriteLine("thead {display: table-header-group;}")
            file.WriteLine("}")
            file.WriteLine("</style>")
            file.WriteLine("</head>")
            file.WriteLine("<body>")
            now = DateTime.Today
            file.WriteLine(String.Concat("<center><h1>Patient Credit Report for ", now.ToString("MM-dd-yyyy"), "</h1></center>"))
            file.WriteLine("<table border=1 width=100%>")
            Dim credit As System.Data.DataSet = New System.Data.DataSet()
            selectData("select id,name,credit from patient where credit>0", credit)
            file.WriteLine("<tr><th>ID</th><th>Name</th><th>Credit</th></tr>")
            If (credit.Tables(0).Rows.Count > 0) Then
                Dim count1 As Integer = credit.Tables(0).Rows.Count - 1
                For i As Integer = 0 To count1 Step 1
                    file.WriteLine("<tr>")
                    file.Write(String.Concat("<td>", credit.Tables(0).Rows(i)(0).ToString(), "</td>"))
                    file.Write(String.Concat("<td>", credit.Tables(0).Rows(i)(1).ToString(), "</td>"))
                    file.WriteLine(String.Concat("<td>", credit.Tables(0).Rows(i)(2).ToString(), "</td>"))
                    file.WriteLine("</tr>")
                Next

            End If
            file.WriteLine("</table>")
            file.WriteLine("</body>")
            file.WriteLine("</html>")
            file.Close()
            If ConvertToPdf(filepath) = False Then
                Process.Start(filepath)
            End If
        End If
    End Sub
End Class