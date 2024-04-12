'Alex Wheelock
'RCET 0265
'Spring 2024
'Etch-O-Sketch
'https://github.com/AlexWheelock/Etch-O-Sketch.git

Option Explicit On
Option Strict On

Public Class EtchOSketchForm

    Sub SetDefaults()
        ChooseColor(Color.Black, True)
    End Sub

    Function ChooseColor(Optional newColor As Color = Nothing, Optional update As Boolean = False) As Color
        Static currentColor As Color

        If update Then
            currentcolor = newColor
        End If

        Return currentColor
    End Function

    Sub MouseDraw(newX As Integer, newY As Integer, draw As Boolean)
        Dim g As Graphics = MainPictureBox.CreateGraphics
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

    End Sub

    'Event Handlers Below



    Private Sub MainPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles MainPictureBox.MouseMove
        Me.Text = $"({e.X}, {e.Y}, Button: {e.Button}"

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

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        MainPictureBox.Refresh()
        SetDefaults()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ButtonGroupBox_Enter(sender As Object, e As EventArgs) Handles ButtonGroupBox.Enter

    End Sub

    Private Sub EtchOSketchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
    End Sub

    Private Sub MainPictureBox_Click(sender As Object, e As EventArgs) Handles MainPictureBox.Click

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
