﻿Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class NewPatient
    Private valid(6) As String
    Private state As DataSet = New DataSet

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        manipulateData(String.Concat(New String() {"insert into patient values('", txtPatientID.Text, "','", txtName.Text, "','", txtAddress1.Text, "','", txtAddress2.Text, "','", txtCity.Text, "','", cmbState.Text, "','", txtPIN.Text, "','", txtPhone.Text, "','", txtEmail.Text, "',0);commit;"}))
        Me.Dispose()
    End Sub

    Private Sub cmbState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbState.SelectedIndexChanged
        If (cmbState.Text.Length > 0) Then
            cmbState.BackColor = Color.LightGreen
            valid(4) = Conversions.ToString(True)
        ElseIf (cmbState.Text.Length = 0) Then
            cmbState.BackColor = Color.Pink
            valid(4) = Conversions.ToString(False)
        End If
    End Sub

    Private Sub NewPatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim num As Integer = 0
        Do
            valid(num) = Conversions.ToString(False)
            num = num + 1
        Loop While num <= 6
        txtPatientID.Text = generateID()
        selectData("select distinct state from patient", state)
        cmbState.Items.Clear()
        If (state.Tables(0).Rows.Count > 0) Then
            Dim count As Integer = state.Tables(0).Rows.Count - 1
            For i As Integer = 0 To count Step 1
                cmbState.Items.Add(state.Tables(0).Rows(i)(0).ToString())
            Next

        End If
        Timer1.Interval = 300
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As Integer = 0
        Do
            If (Conversions.ToBoolean(valid(i))) Then
                If (Conversions.ToBoolean(valid(i))) Then
                    btnAdd.Enabled = True
                End If
                i = i + 1
            Else
                btnAdd.Enabled = False
                Exit Do
            End If
        Loop While i <= 6
    End Sub

    Private Sub txtAddress1_TextChanged(sender As Object, e As EventArgs) Handles txtAddress1.TextChanged
        If (txtAddress1.Text.Length > 0) Then
            txtAddress1.BackColor = Color.LightGreen
            valid(2) = Conversions.ToString(True)
        ElseIf (txtAddress1.Text.Length = 0) Then
            txtAddress1.BackColor = Color.Pink
            valid(2) = Conversions.ToString(False)
        End If
    End Sub

    Private Sub txtCity_TextChanged(sender As Object, e As EventArgs) Handles txtCity.TextChanged
        If (txtCity.Text.Length > 0) Then
            txtCity.BackColor = Color.LightGreen
            valid(3) = Conversions.ToString(True)
        ElseIf (txtCity.Text.Length = 0) Then
            txtCity.BackColor = Color.Pink
            valid(3) = Conversions.ToString(False)
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If (txtEmail.Text.Length = 0) Then
            valid(7) = Conversions.ToString(True)
            txtEmail.BackColor = Color.LightGreen
        ElseIf (txtEmail.Text.Length > 0) Then
            If (Not (txtEmail.Text.Contains("@") And txtEmail.Text.Contains("."))) Then
                valid(7) = Conversions.ToString(False)
                txtEmail.BackColor = Color.Pink
            Else
                valid(7) = Conversions.ToString(True)
                txtEmail.BackColor = Color.LightGreen
            End If
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If (txtName.Text.Length > 0) Then
            txtName.BackColor = Color.LightGreen
            valid(1) = Conversions.ToString(True)
        ElseIf (txtName.Text.Length = 0) Then
            txtName.BackColor = Color.Pink
            valid(1) = Conversions.ToString(False)
        End If
    End Sub

    Private Sub txtPatientID_TextChanged(sender As Object, e As EventArgs) Handles txtPatientID.TextChanged
        If (txtPatientID.Text.Length > 0) Then
            txtPatientID.BackColor = Color.LightGreen
            valid(0) = Conversions.ToString(True)
        ElseIf (txtPatientID.Text.Length = 0) Then
            txtPatientID.BackColor = Color.Pink
            valid(0) = Conversions.ToString(False)
        End If
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        If (txtPhone.Text.Length > 0 And Versioned.IsNumeric(txtPhone.Text)) Then
            txtPhone.BackColor = Color.LightGreen
            valid(6) = Conversions.ToString(True)
        ElseIf (txtPhone.Text.Length = 0) Then
            txtPhone.BackColor = Color.Pink
            valid(6) = Conversions.ToString(False)
        End If
    End Sub

    Private Sub txtPIN_TextChanged(sender As Object, e As EventArgs) Handles txtPIN.TextChanged
        If (txtPIN.Text.Length > 0 And Versioned.IsNumeric(txtPIN.Text)) Then
            txtPIN.BackColor = Color.LightGreen
            valid(5) = Conversions.ToString(True)
        ElseIf (txtPIN.Text.Length = 0 Or Not Versioned.IsNumeric(txtPIN.Text)) Then
            txtPIN.BackColor = Color.Pink
            valid(5) = Conversions.ToString(False)
        End If
    End Sub
End Class