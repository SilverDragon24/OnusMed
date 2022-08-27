Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports OnusMed.My
Imports OnusMed.My.Resources
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class Login
    Private users As DataSet = New DataSet
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            If (users.Tables(0).Rows.Count > 0) Then
                Dim log As Integer = 0
                Dim count As Integer = users.Tables(0).Rows.Count
                Dim i As Integer = 0
                While i <= count
                    If (Not Operators.ConditionalCompareObjectEqual(users.Tables(0).Rows(i)(0), cmbID.Text, False)) Then
                        i = i + 1
                    Else
                        log = i
                        Exit While
                    End If
                End While
                If (Operators.CompareString(encrypt(txtPwd.Text), users.Tables(0).Rows(log)(2).ToString(), False) <> 0) Then
                    Interaction.MsgBox("Invalid Credentials", MsgBoxStyle.Critical, "Login Failed")
                ElseIf (Not (Operators.CompareString(users.Tables(0).Rows(log)(3).ToString().ToLower(), "admin", False) = 0 Or Operators.CompareString(users.Tables(0).Rows(log)(3).ToString().ToLower(), "it", False) = 0)) Then
                    MyProject.Forms.MainScreen.Show()
                    employee = users.Tables(0).Rows(log)(0).ToString()
                    post = users.Tables(0).Rows(log)(3).ToString()
                    MyBase.Hide()
                Else
                    MyProject.Forms.AdminMenu.Show()
                    MyProject.Forms.MainScreen.Show()
                    employee = users.Tables(0).Rows(log)(0).ToString()
                    post = users.Tables(0).Rows(log)(3).ToString()
                    MyBase.Hide()
                End If
            End If
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (users.Tables(0).Rows.Count > 0) Then
            Dim count As Integer = users.Tables(0).Rows.Count - 1
            Dim i As Integer = 0
            While i <= count
                If (Operators.CompareString(cmbID.Text, users.Tables(0).Rows(i)(0).ToString(), False) <> 0) Then
                    i = i + 1
                Else
                    lblName.Text = users.Tables(0).Rows(i)(1).ToString()
                    Exit While
                End If
            End While
        End If
    End Sub

    Private Sub txtPwd_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPwd.KeyDown
        If (e.KeyCode = Keys.[Return] Or e.KeyCode = Keys.[Return]) Then
            btnLogin_Click(RuntimeHelpers.GetObjectValue(sender), e)
        End If
    End Sub

    Private Sub cmbID_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbID.KeyDown
        If (e.KeyCode = Keys.[Return] Or e.KeyCode = Keys.[Return]) Then
            btnLogin_Click(RuntimeHelpers.GetObjectValue(sender), e)
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If readConfig() = False Then
            Interaction.MsgBox("Config Does Not Exist", MsgBoxStyle.Critical, Nothing)
            MyProject.Forms.CreateConfig.Show()
        ElseIf (ConnectDB(db) = 1) Then
            selectData("select id,name,pwd,post from salesman", users)
            cmbID.Items.Clear()

            If (users.Tables(0).Rows.Count > 0) Then
                Dim num As Integer = (users.Tables(0).Rows.Count - 1)
                Dim i As Integer = 0
                Do While (i <= num)
                    cmbID.Items.Add(users.Tables(0).Rows(i)(0).ToString)
                    i += 1
                Loop
            End If
            Timer1.Interval = 100
            Timer1.Start()
        Else
            Interaction.MsgBox("connection Failed", MsgBoxStyle.ApplicationModal, Nothing)
            Application.Exit()
        End If
    End Sub
End Class