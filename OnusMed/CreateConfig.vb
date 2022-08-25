Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Public Class CreateConfig
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (Not (txtServer.Text.Length > 0 And txtUsr.Text.Length > 0 And txtPwd.Text.Length > 0)) Then
            btnCreate.Enabled = False
        Else
            btnCreate.Enabled = True
        End If
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        createConfigFile(txtServer.Text, txtUsr.Text, txtPwd.Text)
        Application.Exit()
        Process.Start(Application.ExecutablePath)
    End Sub
End Class