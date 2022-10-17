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
Imports System.Runtime.InteropServices
Imports ZXing
Imports ZXing.QrCode.Internal
Imports System.Drawing.Imaging
Imports ZXing.Common
'Imports WebCam_Capture
'Imports MessagingToolkit.QRCode.Codec


Public Class Login
    'WithEvents MyWebCam As WebCamCapture = New WebCamCapture
    'Dim qrreader As QRCodeDecoder
    'Private Sub StartWebCam()
    '    Try
    '        StopWebCam()
    '        MyWebCam = New WebCamCapture
    '        MyWebCam.Start(0)
    '        MyWebCam.Start(0)

    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub StopWebCam()
    '    Try
    '        MyWebCam.Stop()
    '        MyWebCam.Dispose()
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Dim cWnd As IntPtr = IntPtr.Zero
    Dim devId As Integer = 0 '0 will be the first capture device found
    Dim picnumber As Integer = 0
    Dim tmppic As String = ("Temp.dib")

    Private Const WS_CHILD As Integer = &H40000000
    Private Const WS_VISIBLE As Integer = &H10000000
    Private Const WM_USER As Integer = &H400
    Private Const WM_CAP_DRIVER_CONNECT As Integer = WM_USER + 10
    Private Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_USER + 11
    Private Const WM_CAP_SET_PREVIEW As Integer = WM_USER + 50
    Private Const WM_CAP_SET_PREVIEWRATE As Integer = WM_USER + 52
    Private Const WM_CAP_SET_SCALE As Integer = WM_USER + 53
    Private Const WM_CAP_SAVEDIB As Integer = WM_USER + 25
    Private Const WM_CAP_DLG_VIDEOFORMAT As Integer = WM_USER + 41

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Ansi)> Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As Integer, ByVal lParam As String) As IntPtr
    End Function

    <DllImport("avicap32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> Private Shared Function capCreateCaptureWindowA(ByVal lpszWindowName As String, ByVal dwStyle As Integer, ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Integer, ByVal hWndParent As IntPtr, ByVal nID As Integer) As IntPtr
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Unicode)> Private Shared Function DestroyWindow(ByVal hwnd As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

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
                    'StopWebCam()
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
        Try

            'StopWebCam()
            'qrreader = New QRCodeDecoder
            'cmbID.Text = qrreader.decode(New Data.QRCodeBitmapImage(picOut.Image))
            'Dim bmp As New Bitmap(tmppic)
            'SendMessage(cWnd, WM_CAP_SAVEDIB, 0, tmppic)
            'System.IO.File.Delete("temp.bmp")
            'bmp.Save("temp.bmp", ImageFormat.Bmp)
            'PictureBox1.Image = Image.FromFile("temp.bmp")
            'bmp.Dispose()
            'Dim qrreader As BarcodeReader = New BarcodeReader()
            'Dim qr As Bitmap = New Bitmap(vbNull)
            'Dim qrresult = qrreader.Decode(qr)
            'cmbID.Text = qrresult.Text
        Catch ex As Exception
        End Try
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
            MyProject.Forms.CreateConfig.ShowDialog()
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

        'StartWebCam()


        cWnd = capCreateCaptureWindowA(devId.ToString, WS_VISIBLE Or WS_CHILD, 0, 0, picOut.Width, picOut.Height, picOut.Handle, 0)
        If Not SendMessage(cWnd, WM_CAP_DRIVER_CONNECT, devId, Nothing) = IntPtr.Zero Then
            SendMessage(cWnd, WM_CAP_SET_SCALE, 1, Nothing)
            SendMessage(cWnd, WM_CAP_SET_PREVIEWRATE, 66, Nothing)
            SendMessage(cWnd, WM_CAP_SET_PREVIEW, 1, Nothing)
        Else
            cWnd = IntPtr.Zero
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs)
    End Sub

    Private Sub btnScan_Click(sender As Object, e As EventArgs) Handles btnScan.Click
    End Sub

    'Private Sub MyWebCam_ImageCaptured(source As Object, e As WebcamEventArgs) Handles MyWebCam.ImageCaptured
    '    picOut.Image = e.WebCamImage
    'End Sub
End Class