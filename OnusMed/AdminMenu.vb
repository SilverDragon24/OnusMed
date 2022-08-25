Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports OnusMed.My
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class AdminMenu
    Private Sub AdminMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (ConnectDB(db) = 0) Then
            MsgBox("Connection Failed", MsgBoxStyle.OkOnly, Nothing)
            Application.Exit()
        End If
    End Sub

    Private Sub btnEmpMgr_Click(sender As Object, e As EventArgs) Handles btnEmpMgr.Click
        EmployeeManager.ShowDialog()
    End Sub

    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        CreateConfig.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ODocManager.Show()
    End Sub
End Class