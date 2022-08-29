Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class NewSupplier
    Private valid(11) As Boolean
    Private city As DataSet = New DataSet
    Private state As DataSet = New DataSet

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        manipulateData(String.Concat(New String() {"insert into supplier values('", txtSuppID.Text, "','", txtSuppName.Text, "','", txtAddress1.Text, "','", txtAddress2.Text, "','", cmbCity.Text, "','", cmbState.Text, "',", txtPIN.Text, ",", txtContact.Text, ",'", txtEmail.Text, "','", txtDLBio.Text, "','", txtDLNonBio.Text, "','", txtGSTIN.Text, "',", txtCredit.Text, ");commit;"}))
        Me.Dispose()
    End Sub

    Private Sub cmbCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCity.SelectedIndexChanged
        If (cmbCity.Text.Length > 0) Then
            valid(3) = True
        Else
            valid(3) = False
        End If
    End Sub

    Private Sub cmbState_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbState.SelectedIndexChanged
        If (cmbState.Text.Length > 0) Then
            valid(4) = True
        Else
            valid(4) = False
        End If
    End Sub

    Private Sub NewSupplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim enumerator As IEnumerator = Nothing
        Dim enumerator1 As IEnumerator = Nothing
        If (ConnectDB(db) <> 1) Then
            Interaction.MsgBox("Conection Failed", MsgBoxStyle.OkOnly, Nothing)
            Application.[Exit]()
        Else
            Dim i As Integer = 0
            Do
                valid(i) = False
                i = i + 1
            Loop While i <= 11
            selectData("select distinct city from supplier", city)
            selectData("select distinct state from supplier", state)
            cmbCity.Items.Clear()
            cmbCity.Items.Clear()
            If (city.Tables(0).Rows.Count > 0) Then
                Try
                    enumerator = city.Tables(0).Rows.GetEnumerator()
                    While enumerator.MoveNext()
                        Dim current As DataRow = DirectCast(enumerator.Current, DataRow)
                        cmbCity.Items.Add(current(0).ToString())
                    End While
                Finally
                    If (TypeOf enumerator Is IDisposable) Then
                        TryCast(enumerator, IDisposable).Dispose()
                    End If
                End Try
            End If
            If (state.Tables(0).Rows.Count > 0) Then
                Try
                    enumerator1 = state.Tables(0).Rows.GetEnumerator()
                    While enumerator1.MoveNext()
                        Dim row As DataRow = DirectCast(enumerator1.Current, DataRow)
                        cmbState.Items.Add(RuntimeHelpers.GetObjectValue(row(0)))
                    End While
                Finally
                    If (TypeOf enumerator1 Is IDisposable) Then
                        TryCast(enumerator1, IDisposable).Dispose()
                    End If
                End Try
            End If
            txtCredit.Text = "0.00"
            Timer1.Interval = 300
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim num As Integer = 0
        Do
            If (valid(num) = True) Then
                btnAdd.Enabled = True
            ElseIf (valid(num) = False) Then
                btnAdd.Enabled = False
                Exit Do
            End If
            num = num + 1
        Loop While num <= 11
        Dim str As String = ""
        Dim i As Integer = 0
        Do
            str = String.Concat(str, valid(i).ToString(), " ")
            i = i + 1
        Loop While i <= 11
        Debug.WriteLine(str)
    End Sub

    Private Sub txtAddress1_TextChanged(sender As Object, e As EventArgs) Handles txtAddress1.TextChanged
        If (txtAddress1.Text.Length > 0) Then
            valid(2) = True
        Else
            valid(2) = False
        End If
    End Sub

    Private Sub txtContact_TextChanged(sender As Object, e As EventArgs) Handles txtContact.TextChanged
        If (txtContact.Text.Length = 0 And IsNumeric(txtContact.Text) = False) Then
            valid(6) = False
        ElseIf (txtContact.Text.Length > 0 And IsNumeric(txtContact.Text) = True) Then
            valid(6) = True
        End If
    End Sub

    Private Sub txtCredit_TextChanged(sender As Object, e As EventArgs) Handles txtCredit.TextChanged
        If (txtCredit.Text.Length = 0 And Not Versioned.IsNumeric(txtCredit.Text)) Then
            valid(11) = False
        ElseIf (txtCredit.Text.Length > 0 And Versioned.IsNumeric(txtCredit.Text)) Then
            valid(11) = True
        End If
    End Sub

    Private Sub txtDLBio_TextChanged(sender As Object, e As EventArgs) Handles txtDLBio.TextChanged
        If (Operators.CompareString(txtDLBio.Text, "", False) <> 0) Then
            valid(8) = True
        Else
            valid(8) = False
        End If
    End Sub

    Private Sub txtDLNonBio_TextChanged(sender As Object, e As EventArgs) Handles txtDLNonBio.TextChanged
        If (Operators.CompareString(txtDLNonBio.Text, "", False) <> 0) Then
            valid(9) = True
        Else
            valid(9) = False
        End If
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        If (txtEmail.Text.Length = 0 And Not txtEmail.Text.Contains("@") And Not txtEmail.Text.Contains(".")) Then
            valid(7) = False
        ElseIf (txtEmail.Text.Length > 0 And txtEmail.Text.Contains("@") And txtEmail.Text.Contains(".")) Then
            valid(7) = True
        End If
    End Sub

    Private Sub txtGSTIN_TextChanged(sender As Object, e As EventArgs) Handles txtGSTIN.TextChanged
        If (Operators.CompareString(txtGSTIN.Text, "", False) <> 0) Then
            valid(10) = True
        Else
            valid(10) = False
        End If
    End Sub

    Private Sub txtPIN_TextChanged(sender As Object, e As EventArgs) Handles txtPIN.TextChanged
        If (txtPIN.Text.Length = 0 And Not Versioned.IsNumeric(txtPIN.Text)) Then
            valid(5) = False
        ElseIf (txtPIN.Text.Length > 0 And Versioned.IsNumeric(txtPIN.Text)) Then
            valid(5) = True
        End If
    End Sub

    Private Sub txtSuppID_TextChanged(sender As Object, e As EventArgs) Handles txtSuppID.TextChanged
        Dim ds As DataSet = New DataSet()
        selectData(String.Concat("select * from supplier where id='", txtSuppID.Text, "';"), ds)
        If (ds.Tables(0).Rows.Count > 0) Then
            valid(0) = False
        ElseIf (ds.Tables(0).Rows.Count = 0) Then
            valid(0) = True
        End If
    End Sub

    Private Sub txtSuppName_TextChanged(sender As Object, e As EventArgs) Handles txtSuppName.TextChanged
        If (Operators.CompareString(txtSuppName.Text, "", False) <> 0) Then
            valid(1) = True
        Else
            valid(1) = False
        End If
    End Sub
End Class