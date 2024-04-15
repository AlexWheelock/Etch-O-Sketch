Option Explicit On
Option Strict On
'Alex Wheelock
'RCET 0265
'Spring 2024
'Etch-O-Sketch
'https://github.com/AlexWheelock/Etch-O-Sketch.git

Imports System.Media
Imports System.Net.Security

Public Class EtchOSketchForm

    Sub SetDefaults()
        ChooseColor(Color.Black, True)
    End Sub

    Function ChooseColor(Optional newColor As Color = Nothing, Optional update As Boolean = False) As Color
        Static currentColor As Color

        If update Then
            currentColor = newColor
        End If

        Return currentColor
    End Function

    Sub MouseDraw(newX As Integer, newY As Integer, draw As Boolean)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ChooseColor())
        Static oldX As Integer
        Static oldY As Integer

        If draw Then
            g.DrawLine(pen, oldX, oldY, newX, newY)
        End If

        oldX = newX
        oldY = newY

        pen.Dispose()
        g.Dispose()
    End Sub

    Sub DrawWaveforms()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.Red)
        Dim degree As Double = DrawingPictureBox.Width \ 360
        Dim oldX As Integer = 0
        Dim oldY As Integer = DrawingPictureBox.Height \ 2
        Dim newX As Integer
        Dim newY As Integer
        Dim radians As Double

        'vi = vp * sin(360 * f * t * theta) + DC

        For x = 0 To 360 Step degree

            radians = (Math.PI / 180) * x * degree

            newX = CInt(x)
            newY = CInt(150 * Math.Sin(radians)) + DrawingPictureBox.Height \ 2
            'newY = CInt(150 * Math.Sin((Math.PI / 180) * x)) + DrawingPictureBox.Height \ 2
            If x = 90 Then
                Debug.Print(CStr(x))
            End If
            g.DrawLine(pen, oldX, oldY, newX, newY)
            oldX = newX
            oldY = newY
        Next



        pen.Dispose()
        g.Dispose()
    End Sub

    Sub ClearDrawing()
        Dim currentX As Integer = Me.DesktopLocation.X
        Dim currentY As Integer = Me.DesktopLocation.Y

        'My.Computer.Audio.Play("clearsound.mp3")

        For i = 0 To 100
            currentX += 1
            currentY += 1
            Me.SetDesktopLocation(currentX, currentY)
        Next

        For i = 0 To 200
            currentX -= 1
            currentY -= 1
            Me.SetDesktopLocation(currentX, currentY)
        Next

        For i = 0 To 200
            currentX += 1
            currentY += 1
            Me.SetDesktopLocation(currentX, currentY)
        Next

        For i = 0 To 200
            currentX -= 1
            currentY -= 1
            Me.SetDesktopLocation(currentX, currentY)
        Next

        For i = 0 To 200
            currentX += 1
            currentY += 1
            Me.SetDesktopLocation(currentX, currentY)
        Next

        For i = 0 To 100
            currentX -= 1
            currentY -= 1
            Me.SetDesktopLocation(currentX, currentY)
        Next

        DrawingPictureBox.Refresh()
        SetDefaults()

    End Sub

    'Event Handlers Below



    Private Sub MainPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        If e.Button = MouseButtons.Left Then
            MouseDraw(e.X, e.Y, True)
        Else
            MouseDraw(e.X, e.Y, False)
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            ChooseColor(ColorDialog.Color, True)
        End If
    End Sub

    Private Sub WaveformsButton_Click(sender As Object, e As EventArgs) Handles WaveformsButton.Click
        DrawWaveforms()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ClearDrawing()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ButtonGroupBox_Enter(sender As Object, e As EventArgs) Handles ButtonGroupBox.Enter

    End Sub

    Private Sub EtchOSketchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
    End Sub

    Private Sub DrawingPictureBox_Click(sender As Object, e As EventArgs) Handles DrawingPictureBox.Click

    End Sub

    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

    End Sub

    Private Sub SelectColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColorToolStripMenuItem.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            ChooseColor(ColorDialog.Color, True)
        End If
    End Sub

    Private Sub DrawWaveformsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrawWaveformsToolStripMenuItem.Click

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click

    End Sub

    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click

    End Sub

    Private Sub MainToolTip_Popup(sender As Object, e As PopupEventArgs) Handles MainToolTip.Popup

    End Sub

    Private Sub TopMenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles TopMenuStrip.ItemClicked

    End Sub

End Class
