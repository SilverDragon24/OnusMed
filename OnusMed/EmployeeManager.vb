Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class EmployeeManager
    Private emp As DataSet = New DataSet
    Private state As DataSet = New DataSet
    Private city As DataSet = New DataSet
    Private post As DataSet = New DataSet
    Private valid(10) As Boolean

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim text() As String = {"insert into salesman values('", txtEmpId.Text, "','", encrypt(txtPwd.Text), "','", txtName.Text, "','", txtAddr1.Text, "','", txtAddr2.Text, "','", cmbCity.Text, "','", cmbState.Text, "',", txtPin.Text, ",'", cmbPost.Text, "','", txtPhone.Text, "','", txtEmail.Text, "',", Nothing, Nothing}
        text(23) = Me.numComm.Value.ToString()
        text(24) = ");commit;"
        manipulateData(String.Concat(text))
        selectData("select * from salesman", Me.emp)
        selectData("select distinct state from salesman", Me.state)
        selectData("select distinct city from salesman", Me.city)
        selectData("select distinct post from salesman", Me.post)
        txtEmpId.Text = String.Concat("E", generateID())
        Try
            DataGridView1.DataSource = emp.Tables(0)
            cmbState.Items.Clear()
            cmbCity.Items.Clear()
            cmbPost.Items.Clear()
            If (state.Tables(0).Rows.Count > 0) Then
                Dim count As Integer = state.Tables(0).Rows.Count - 1
                For num As Integer = 0 To count Step 1
                    cmbState.Items.Add(state.Tables(0).Rows(num)(0).ToString())
                Next

            End If
            If (city.Tables(0).Rows.Count > 0) Then
                Dim count1 As Integer = city.Tables(0).Rows.Count - 1
                For j As Integer = 0 To count1 Step 1
                    cmbCity.Items.Add(city.Tables(0).Rows(j)(0).ToString())
                Next

            End If
            If (post.Tables(0).Rows.Count > 0) Then
                Dim num1 As Integer = post.Tables(0).Rows.Count - 1
                For i As Integer = 0 To num1 Step 1
                    cmbPost.Items.Add(post.Tables(0).Rows(i)(0).ToString())
                Next
            End If
        Catch exception As System.Exception

        End Try
    End Sub

    Private Sub cmbCity_TextChanged(sender As Object, e As EventArgs) Handles cmbCity.TextChanged
        If (cmbCity.Text.Length <> 0) Then
            valid(5) = True
            cmbCity.BackColor = Color.LightGreen
        Else
            valid(5) = False
            cmbCity.BackColor = Color.Pink
        End If
    End Sub

    Private Sub cmbPost_TextChanged(sender As Object, e As EventArgs) Handles cmbPost.TextChanged
        If (cmbPost.Text.Length <> 0) Then
            valid(8) = True
            cmbPost.BackColor = Color.LightGreen
        Else
            valid(8) = False
            cmbPost.BackColor = Color.Pink
        End If
    End Sub

    Private Sub cmbState_TextChanged(sender As Object, e As EventArgs) Handles cmbState.TextChanged
        If (cmbState.Text.Length <> 0) Then
            valid(6) = True
            cmbState.BackColor = Color.LightGreen
        Else
            valid(6) = False
            cmbState.BackColor = Color.Pink
        End If
    End Sub

    Private Sub EmployeeManager_Load(sender As Object, e As EventArgs) Handles Me.Load
        selectData("select * from salesman", emp)
        selectData("select distinct state from salesman", state)
        selectData("select distinct city from salesman", city)
        selectData("select distinct post from salesman", post)
        txtEmpId.Text = String.Concat("E", generateID())
        Try
            DataGridView1.DataSource = emp.Tables(0)
            cmbState.Items.Clear()
            cmbCity.Items.Clear()
            cmbPost.Items.Clear()
            If (state.Tables(0).Rows.Count > 0) Then
                Dim count As Integer = state.Tables(0).Rows.Count - 1
                For num As Integer = 0 To count Step 1
                    cmbState.Items.Add(state.Tables(0).Rows(num)(0).ToString())
                Next

            End If
            If (city.Tables(0).Rows.Count > 0) Then
                Dim count1 As Integer = city.Tables(0).Rows.Count - 1
                For i As Integer = 0 To count1 Step 1
                    cmbCity.Items.Add(city.Tables(0).Rows(i)(0).ToString())
                Next

            End If
            cmbPost.Items.Add("IT")
            cmbPost.Items.Add("Admin")
        Catch exception As System.Exception

        End Try
        Timer1.Interval = 300
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim i As Integer = 0
        Do
            If (valid(i)) Then
                If (valid(i)) Then
                    btnAdd.Enabled = True
                End If
                i = i + 1
            Else
                btnAdd.Enabled = False
                Exit Do
            End If
        Loop While i <= 10
    End Sub

    Private Sub txtAddr1_TextChanged(sender As Object, e As EventArgs) Handles txtAddr1.TextChanged
        If (txtAddr1.Text.Length <> 0) Then
            valid(4) = True
            txtAddr1.BackColor = Color.LightGreen
        Else
            valid(4) = False
            txtAddr1.BackColor = Color.Pink
        End If
    End Sub

    Private Sub txtConPwd_TextChanged(sender As Object, e As EventArgs) Handles txtConPwd.TextChanged
        If (Not (valid(1) And Operators.CompareString(txtConPwd.Text, txtPwd.Text, False) = 0)) Then
            valid(2) = False
            txtConPwd.BackColor = Color.Pink
        Else
            valid(2) = True
            txtConPwd.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If (txtEmail.Text.Length = 0) Then
            valid(10) = True
            txtEmail.BackColor = Color.LightGreen
        ElseIf (txtEmail.Text.Length > 0) Then
            If (Not (txtEmail.Text.Contains("@") And txtEmail.Text.Contains("."))) Then
                valid(10) = False
                txtEmail.BackColor = Color.Pink
            Else
                valid(10) = True
                txtEmail.BackColor = Color.LightGreen
            End If
        End If
    End Sub

    Private Sub txtEmpId_TextChanged(sender As Object, e As EventArgs) Handles txtEmpId.TextChanged
        If (txtEmpId.Text.Length <> 0) Then
            valid(0) = True
            txtEmpId.BackColor = Color.LightGreen
        Else
            valid(0) = False
            txtEmpId.BackColor = Color.Pink
        End If
    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        If (txtName.Text.Length <> 0) Then
            valid(3) = True
            txtName.BackColor = Color.LightGreen
        Else
            valid(3) = False
            txtName.BackColor = Color.Pink
        End If
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        If (Not (txtPhone.Text.Length > 0 And Versioned.IsNumeric(txtPhone.Text))) Then
            valid(9) = False
            txtPhone.BackColor = Color.Pink
        Else
            valid(9) = True
            txtPhone.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub txtPin_TextChanged(sender As Object, e As EventArgs) Handles txtPin.TextChanged
        If (Not (txtPin.Text.Length > 0 And Versioned.IsNumeric(txtPin.Text))) Then
            valid(7) = False
            txtPin.BackColor = Color.Pink
        Else
            valid(7) = True
            txtPin.BackColor = Color.LightGreen
        End If
    End Sub

    Private Sub txtPwd_TextChanged(sender As Object, e As EventArgs) Handles txtPwd.TextChanged
        If (Not (txtPwd.Text.Length >= 6 And txtPwd.Text.Length <= 12)) Then
            valid(1) = False
            txtPwd.BackColor = Color.Pink
        Else
            valid(1) = True
            txtPwd.BackColor = Color.LightGreen
        End If
    End Sub
End Class