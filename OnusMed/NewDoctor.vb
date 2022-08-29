Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class NewDoctor
    Private valid(1) As Boolean
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        manipulateData(String.Concat(New String() {"insert into pdoctor values('", txtReg.Text, "','", txtName.Text, "','", txtDocSpec.Text, "','", txtHospital.Text, "');commit;"}))
        Me.Dispose()
    End Sub

    Private Sub NewDoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 300
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As Integer = 0
        Do
            If (valid(i)) Then
                valid(i) = True
                btnAdd.Enabled = True
                i = i + 1
            Else
                btnAdd.Enabled = False
                Exit Do
            End If
        Loop While i <= 1
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If (txtName.Text.Length <= 0) Then
            valid(1) = False
            txtName.BackColor = Color.Pink
        Else
            valid(1) = True
            txtName.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub txtReg_TextChanged(sender As Object, e As EventArgs) Handles txtReg.TextChanged
        If (txtReg.Text.Length <= 0) Then
            valid(0) = False
            txtReg.BackColor = Color.Pink
        Else
            valid(0) = True
            txtReg.BackColor = Color.LightGreen
        End If
    End Sub
End Class