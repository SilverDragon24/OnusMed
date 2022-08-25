Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.VisualBasic.MyServices
Imports Microsoft.Win32
Imports MySql.Data.MySqlClient
Imports OnusMed.My
Imports System
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Common
Imports System.Diagnostics
Imports System.Drawing
Imports System.Net.NetworkInformation
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class ProductKey
    Private Sub btnActivate_Click(sender As Object, e As EventArgs) Handles btnActivate.Click
        Dim actDb As String = "OnusCustDB"
        Dim actServer As String = "127.0.0.1"
        Dim actUsr As String = "iont"
        Dim actPwd As String = "root"
        Dim actConn As MySqlConnection = New MySqlConnection()
        Dim actDa As MySqlDataAdapter = New MySqlDataAdapter()
        Try
            If (actConn IsNot Nothing) Then
                actConn.Close()
            End If
            actConn.ConnectionString = String.Format("server={0};port=3306; user id={1}; password={2}; database={3}; pooling=false; SslMode=none;", New Object() {actServer, actUsr, actPwd, actDb})
            actConn.Open()
        Catch exception As System.Exception
            Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, Nothing)
        End Try
        ProductData.CustId = txtCustID.Text
        Dim cmd As MySqlCommand = New MySqlCommand()
        Dim ds As DataSet = New DataSet()
        ds.Clear()
        ds.Tables.Clear()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = String.Concat(New String() {"select client_id,product_code,product_key,prime,mac,date_format(paid_till,'%Y-%m-%d'),authorizer from products where client_id='", ProductData.CustId, "' and product_code='", ProductData.ProductId, "' and mac='", getMacAddress(), "'"})
        cmd.Connection = conn
        Dim num As Integer = (New MySqlDataAdapter(cmd)).Fill(ds)
        actConn.Close()
        Try
            If (Operators.CompareString(txtProductKey.Text, encrypt(String.Concat(ds.Tables(0).Rows(0)(0).ToString(), ds.Tables(0).Rows(0)(3).ToString(), getMacAddress())), False) = 0 And Operators.CompareString(txtProductKey.Text, ds.Tables(0).Rows(0)(2).ToString(), False) = 0) Then
                MyProject.Computer.Registry.LocalMachine.CreateSubKey(encrypt(ProductData.ProductId))
                MyProject.Computer.Registry.SetValue(String.Concat("HKEY_LOCAL_MACHINE\", encrypt(ProductData.ProductId)), encrypt("paid_till"), ds.Tables(0).Rows(0)(5).ToString())
            End If
        Catch exception1 As System.Exception
            Interaction.MsgBox("Activation Unauthorized", MsgBoxStyle.OkOnly, Nothing)
            Application.Exit()
        End Try
    End Sub

    Private Sub lblBypass_Click(sender As Object, e As EventArgs) Handles lblBypass.Click
        Login.Show()
        MyBase.Hide()
    End Sub

    Public Function getMacAddress() As String
        Dim nics As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
        Return nics(0).GetPhysicalAddress().ToString()
    End Function
End Class