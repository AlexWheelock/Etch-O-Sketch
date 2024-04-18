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

    'Reverts the picture box to blank, and changes the pen color back to black
    Sub SetDefaults()
        DrawingPictureBox.Refresh()
        ChooseColor(Color.Black, True)
        DrawingPictureBox.BackColor = Color.LightYellow
    End Sub

    'Loads in the pen color constantly as the user moves their mouse across DrawingPictureBox
    Function ChooseColor(Optional newColor As Color = Nothing, Optional update As Boolean = False) As Color
        Static currentColor As Color

        'If update is true then the color loaded in changes currentColor, otherwise currentColor remains the same
        If update Then
            currentColor = newColor
        End If

        Return currentColor
    End Function

    'Allows the user to draw on the picture box. It is constantly called as the user moves their cursor over DrawingPictureBox.
    'However it only draws when draw is true, which happens when left-click is held
    Sub MouseDraw(newX As Integer, newY As Integer, draw As Boolean)
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(ChooseColor())
        Static oldX As Integer
        Static oldY As Integer

        'Draws from where the cursor was, to where the user moves their cursor as long as left-click is held
        'Does nothing if left-click is not held
        If draw Then
            g.DrawLine(pen, oldX, oldY, newX, newY)
        End If

        'Constantly update the current cursor location to the old as the user moves their mouse across DrawingPictureBox
        oldX = newX
        oldY = newY

        pen.Dispose()
        g.Dispose()
    End Sub

    'Draws the 10x10 grid that appears behind the waveforms when the "Draw Waveforms" button is pressed
    Sub DrawGraticules()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        Dim pen As New Pen(Color.DarkGray)

        Const TOP = 0%, LEFT = 0%
        Dim Bottom As Integer = DrawingPictureBox.Height
        Dim Right As Integer = DrawingPictureBox.Width

        Dim xIncrement = DrawingPictureBox.Width \ 10
        Dim yIncrement = DrawingPictureBox.Height \ 10

        'Draws the vertical lines from 1/10 of DrawingPictureBox's width to the right edge
        For x = xIncrement To Right Step xIncrement
            g.DrawLine(pen, x, TOP, x, Bottom)
        Next

        'Draws the horizontal lines from 1/10 of DrawingPictureBox's height to the top
        For y = yIncrement To Bottom - yIncrement Step yIncrement
            g.DrawLine(pen, LEFT, y, Right, y)
        Next

        pen.Dispose()
        g.Dispose()
    End Sub

    'Draws a sine wave across the DrawingPictureBox when the "Draw Waveforms" button is pressed
    Sub DrawSineWave()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        g.PageUnit = GraphicsUnit.Pixel
        Dim pen As New Pen(Color.Red)
        Dim degree As Double = DrawingPictureBox.Width \ 360
        Dim angle#, newX#, newY#, oldX#, oldY#

        Dim xMax As Single = 360 '360 made up units
        Dim xScale As Single = DrawingPictureBox.Width / xMax

        Dim yMax As Single = 100 '100 made up units
        Dim yScale As Single = CSng(DrawingPictureBox.Height / 2) / yMax * -1 'calculate the y scale factor

        'apply the scale
        g.ScaleTransform(xScale, yScale)

        'Set the origin to the y middle of the picture box
        g.TranslateTransform(0, yMax * -1)

        'vi = vp * sin(360 * f * t * theta) + DC
        'Draws 360 lines that make up a sine wave
        For newX = 0 To 360 Step degree

            'converts degrees to radians
            angle = (Math.PI / 180) * newX

            'sets the newY location based on where it is on the x-axis, with the limit being 10 less than the maximum to limit it from clipping
            newY = (yMax - 10) * Math.Sin(angle)

            'Draws the waveform
            g.DrawLine(pen, CInt(oldX), CInt(oldY), CInt(newX), CInt(newY))

            'Sets the old point to the current point to have a nice line be drawn
            oldX = newX
            oldY = newY

        Next

        pen.Dispose()
        g.Dispose()
    End Sub

    'Draws a cosine wave across the DrawingPictureBox when the "Draw Waveforms" button is pressed
    Sub DrawCosineWave()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        g.PageUnit = GraphicsUnit.Pixel
        Dim pen As New Pen(Color.Blue)
        Dim degree As Double = DrawingPictureBox.Width \ 360
        Dim angle#, newX#, newY#, oldX#, oldY#

        Dim xMax As Single = 360 '360 made up units
        Dim xScale As Single = DrawingPictureBox.Width / xMax

        Dim yMax As Single = 100 '100 made up units
        Dim yScale As Single = CSng(DrawingPictureBox.Height / 2) / yMax * -1 'calculate the y scale factor

        'apply the scale
        g.ScaleTransform(xScale, yScale)

        'Set the origin to the y middle of the picture box
        g.TranslateTransform(0, yMax * -1)

        'Draws 360 lines that make up a sine wave
        For newX = 0 To 360 Step degree

            'converts degrees to radians
            angle = (Math.PI / 180) * newX

            'Sets the first location to yMax - 10 in order to prevent there from being a line at x = 0 from the center, down to where the waveform starts
            If newX = 0 Then
                newY = yMax - 10
                oldY = newY
            Else
                'sets the newY location based on where it is on the x-axis, with the limit being 10 less than the maximum to limit it from clipping
                newY = (yMax - 10) * Math.Cos(angle)
            End If

            'Draws the waveform
            g.DrawLine(pen, CInt(oldX), CInt(oldY), CInt(newX), CInt(newY))

            'Sets the old point to the current point to have a nice line be drawn
            oldX = newX
            oldY = newY

        Next

        pen.Dispose()
        g.Dispose()
    End Sub

    'Draws a tangent wave across the DrawingPictureBox when the "Draw Waveforms" button is pressed
    Sub DrawTangentLine()
        Dim g As Graphics = DrawingPictureBox.CreateGraphics
        g.PageUnit = GraphicsUnit.Pixel
        Dim pen As New Pen(Color.Green)
        Dim degree As Double = DrawingPictureBox.Width \ 360
        Dim angle#, newX#, newY#, oldX#, oldY#

        Dim xMax As Single = 360 '360 made up units
        Dim xScale As Single = DrawingPictureBox.Width / xMax

        Dim yMax As Single = 100 '100 made up units
        Dim yScale As Single = CSng(DrawingPictureBox.Height / 2) / yMax * -1 'calculate the y scale factor

        'apply the scale
        g.ScaleTransform(xScale, yScale)

        'Set the origin to the y middle of the picture box
        g.TranslateTransform(0, yMax * -1)

        For newX = 0 To 360 Step degree

            'converts degrees to radians
            angle = (Math.PI / 180) * newX

            newY = (yMax - 10) * Math.Tan(angle)

            'Tries to draw the tangent wave, but since the tangent wave goes to infinity it will crash the form
            'To prevent this it runs it through a try-catch, to prevent it from crashing, only drawing what can be seen in the picture box
            Try
                'Draws the Waveform
                g.DrawLine(pen, CInt(oldX), CInt(oldY), CInt(newX), CInt(newY))
            Catch ex As Exception
                'The line that was attempted to be drawn was outside the bounds of DrawingPictureBox
            End Try

            'Sets the old point to the current point to have a nice line be drawn
            oldX = newX
            oldY = newY

        Next

        pen.Dispose()
        g.Dispose()
    End Sub

    'Clears the drawing when the "Clear" button is pressed
    'Moves the form back and forth to shake it as you would an etch-a-sketch
    Sub ClearDrawing()
        Dim currentX As Integer = Me.DesktopLocation.X
        Dim currentY As Integer = Me.DesktopLocation.Y

        'plays the Shaker resource that was originally downloaded on freesound.org and trimmed down
        Try
            My.Computer.Audio.Play(My.Resources.Shaker, AudioPlayMode.Background)
        Catch ex As Exception
        End Try

        'Moves form down and to the right 100 pixels
        For i = 0 To 50
            currentX += 2
            currentY += 2
            Me.SetDesktopLocation(currentX, currentY)
        Next

        'Moves the form up and to the left 200 pixels
        For i = 0 To 100
            currentX -= 2
            currentY -= 2
            Me.SetDesktopLocation(currentX, currentY)
        Next

        'Moves the form down and to the right 200 pixels
        For i = 0 To 100
            currentX += 2
            currentY += 2
            Me.SetDesktopLocation(currentX, currentY)
        Next

        'Moves the form up and to the left 200 pixels
        For i = 0 To 100
            currentX -= 2
            currentY -= 2
            Me.SetDesktopLocation(currentX, currentY)
        Next

        'Moves the form down and to the right 200 pixels
        For i = 0 To 100
            currentX += 2
            currentY += 2
            Me.SetDesktopLocation(currentX, currentY)
        Next

        'Moves the form up and to the left 200 pixels
        For i = 0 To 100
            currentX -= 2
            currentY -= 2
            Me.SetDesktopLocation(currentX, currentY)
        Next

        'Moves the form down and to the right 100 pixels, back to its original location
        For i = 0 To 50
            currentX += 2
            currentY += 2
            Me.SetDesktopLocation(currentX, currentY)
        Next

        'Clears DrawingPictureBox and sets it back to default settings
        SetDefaults()
    End Sub

    'Displays a message about the form when one of the About buttons are pressed
    Sub About()
        MsgBox("Welcome to Etch-O-Sketch!" & vbCrLf _
               & vbCrLf _
               & "To begin, hold down the left mouse button as you move your mouse across the picture box. You can change the color of your cursor by clicking the " & Chr(34) & "Select Color" & Chr(34) &
               " button. To draw sine, cosine, and tangent waves, click the " & Chr(34) & "Draw Waveforms" & Chr(34) & " button. To clear the picture box, press the " & Chr(34) & "Clear" & Chr(34) &
               " button. And when you wish to leave, click the " & Chr(34) & "Exit" & Chr(34) & " button.")
    End Sub

    'Event Handlers Below Here

    'Updates the position of the cursor on DrawingPictureBox constantly as it moves
    'If left-click is held down then it makes draw true, drawing on the picture box
    Private Sub MainPictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles DrawingPictureBox.MouseMove
        If e.Button = MouseButtons.Left Then
            MouseDraw(e.X, e.Y, True)
        Else
            MouseDraw(e.X, e.Y, False)
        End If
    End Sub

    'Closes the form
    'Exit button in the tool strip under the file button
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    'Opens the color dialog and allows the user to select a pen color, changing currentColor to the selected color when OK is pressed
    'Select Color button in the bottom right
    Private Sub SelectColorButton_Click(sender As Object, e As EventArgs) Handles SelectColorButton.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            ChooseColor(ColorDialog.Color, True)
        End If
    End Sub

    'Clears DrawingPictureBox, Draws a 10x10 grid, Draws a sine wave, Draws a cosine wave, then Draws a tangent wave
    'Draw Waveforms button in the bottom right
    Private Sub WaveformsButton_Click(sender As Object, e As EventArgs) Handles WaveformsButton.Click
        SetDefaults()
        DrawGraticules()
        DrawSineWave()
        DrawCosineWave()
        DrawTangentLine()
    End Sub

    'Shakes the form and then clears DrawingPictureBox, setting it to default
    'Clear button in the bottom right
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ClearDrawing()
    End Sub

    'Closes the form
    'Exit button in the bottom right
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Group box that holds the buttons in the bottom right of the form
    Private Sub ButtonGroupBox_Enter(sender As Object, e As EventArgs) Handles ButtonGroupBox.Enter

    End Sub

    'Sets the form to defaults when ran
    Private Sub EtchOSketchForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetDefaults()
    End Sub

    'Picture box that allows the user to draw on it
    Private Sub DrawingPictureBox_Click(sender As Object, e As EventArgs) Handles DrawingPictureBox.Click

    End Sub

    'File Strip that appears at the top of the screen
    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    'Edit button in the tool strip menu
    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click

    End Sub

    'Opens the color dialog and allows the user to select a pen color, changing currentColor to the selected color when OK is pressed
    'Select Colors button in the tool strip menu under the edit button
    Private Sub SelectColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectColorToolStripMenuItem.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            ChooseColor(ColorDialog.Color, True)
        End If
    End Sub

    'Clears DrawingPictureBox, Draws a 10x10 grid, Draws a sine wave, Draws a cosine wave, then Draws a tangent wave
    'Draw Waveforms button in the tool strip menu under the edit button
    Private Sub DrawWaveformsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrawWaveformsToolStripMenuItem.Click
        SetDefaults()
        DrawGraticules()
        DrawSineWave()
        DrawCosineWave()
        DrawTangentLine()
    End Sub

    'Shakes the form and then clears DrawingPictureBox, setting it to default
    'Clear button in the tool strip menu under the edit button
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ClearDrawing()
    End Sub

    'Help button in the tool strip menu
    Private Sub HelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem.Click

    End Sub

    'Displays a message about the form and how to use it
    'About button in the tool strip menu under the help button
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About()
    End Sub

    'Main tool tip that gives tips for each control and button in the form
    Private Sub MainToolTip_Popup(sender As Object, e As PopupEventArgs) Handles MainToolTip.Popup

    End Sub

    'Event for when a button in the top menu is pressed
    Private Sub TopMenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles TopMenuStrip.ItemClicked

    End Sub

    'Context Menu for the form
    Private Sub PictureBoxContextMenuStrip_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs)

    End Sub

    'Opens the context menu strip
    Private Sub PictureBoxContextMenuStrip_Opening_1(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MainContextMenuStrip.Opening

    End Sub

    'File button in the context menu
    Private Sub FileContextMenuButton_Click(sender As Object, e As EventArgs) Handles FileContextMenuButton.Click

    End Sub

    'Exit button in the context menu under the file button
    Private Sub ExitContextMenuButton_Click(sender As Object, e As EventArgs) Handles ExitContextMenuButton.Click
        Me.Close()
    End Sub

    'Edit button in the context menu
    Private Sub EditContextMenuButton_Click(sender As Object, e As EventArgs) Handles EditContextMenuButton.Click

    End Sub

    'Opens the color dialog and allows the user to select a pen color, changing currentColor to the selected color when OK is pressed
    'Select Color button in the context menu under the edit button
    Private Sub SelectColorContextMenuButton_Click(sender As Object, e As EventArgs) Handles SelectColorContextMenuButton.Click
        If ColorDialog.ShowDialog() = DialogResult.OK Then
            ChooseColor(ColorDialog.Color, True)
        End If
    End Sub

    'Clears DrawingPictureBox, Draws a 10x10 grid, Draws a sine wave, Draws a cosine wave, then Draws a tangent wave
    'Draw Waveforms button in the context menu under the edit button
    Private Sub DrawWaveformsContextMenuButton_Click(sender As Object, e As EventArgs) Handles DrawWaveformsContextMenuButton.Click
        SetDefaults()
        DrawGraticules()
        DrawSineWave()
        DrawCosineWave()
        DrawTangentLine()
    End Sub

    'Shakes the form and then clears DrawingPictureBox, setting it to default
    'Clear button in the context menu under the edit button
    Private Sub ClearContextMenuButton_Click(sender As Object, e As EventArgs) Handles ClearContextMenuButton.Click
        ClearDrawing()
    End Sub

    'Help button in the context menu
    Private Sub HelpContextMenuButton_Click(sender As Object, e As EventArgs) Handles HelpContextMenuButton.Click

    End Sub

    'Displays a message about the form and how to use it
    'About button in the context menu under the help button
    Private Sub AboutContextMenuButton_Click(sender As Object, e As EventArgs) Handles AboutContextMenuButton.Click
        About()
    End Sub
End Class
