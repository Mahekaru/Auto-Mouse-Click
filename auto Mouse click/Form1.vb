Imports System.Runtime.InteropServices
Public Class frmAutoClick
    Private start As Integer = 10
    Private clicks As Integer = 0
    Private Delay As Integer = 0
    Private ClkAmt As Integer = 1


    <DllImport("user32.dll", SetLastError:=True)> _
    Private Shared Function SendInput( _
    ByVal cInputs As Integer, _
    ByRef pInputs As INPUT, _
    ByVal cbSize As Integer) As Integer
    End Function

    Private Structure INPUT
        Public Type As Integer
        Public mi As MOUSEINPUT
    End Structure

    <StructLayout(LayoutKind.Sequential)> _
    Private Structure MOUSEINPUT
        Public X As Integer
        Public Y As Integer
        Public mouseData As UInteger
        Public Flags As UInteger
        Public time As UInteger
        Public Info As IntPtr
    End Structure

    Const MOUSEEVENTF_LEFTDOWN As Integer = &H2
    Const MOUSEEVENTF_LEFTUP As Integer = &H4
    
    Sub ClickMouse(ByVal MouseButton As Integer)
        Dim MouseInput As New MOUSEINPUT
        MouseInput.Flags = MouseButton
        Dim i As New INPUT
        i.mi = MOUSEINPUT
        Dim cbSize As Integer = Marshal.SizeOf(i)
        Dim result As Integer = SendInput(1, i, cbSize)
        If result = 0 Then
            Throw New System.ComponentModel.Win32Exception
        End If
    End Sub

    Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click
        If txtAmount.Text = "" Then
        Else
            tmrClick.Interval = Convert.ToInt32(txtDelay.Text)
            ClkAmt = Convert.ToInt32(txtClickAmount.Text)
            start = 20
        End If
    End Sub

    Sub MouseClicks()
        Dim Clicked As Integer = 0

        Do Until Clicked = ClkAmt
            Windows.Forms.Application.DoEvents()
            ClickMouse(MOUSEEVENTF_LEFTDOWN)
            ClickMouse(MOUSEEVENTF_LEFTUP)

            Clicked += 1

        Loop

    End Sub

    Private Sub tmrClick_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrClick.Tick
        txtclicks.Text = clicks
       
        If start = 20 Then
            If clicks = txtAmount.Text Then
                start = 10
                clicks = 0
            Else
                MouseClicks()
                clicks += 1
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        start = 10
        clicks = 0
    End Sub

    Private Sub txtDelay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDelay.TextChanged
        If Not IsNumeric(txtDelay.Text) Then
            txtDelay.Text = 1
        End If
    End Sub

    Private Sub txtClickAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtClickAmount.TextChanged
        If Not IsNumeric(txtClickAmount.Text) Then
            txtClickAmount.Text = 1
        End If
    End Sub

    Private Sub txtAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAmount.TextChanged
        If Not IsNumeric(txtAmount.Text) Then
            txtAmount.Text = 1
        End If
    End Sub
End Class


