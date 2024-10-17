<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EtchOSketchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ButtonGroupBox = New System.Windows.Forms.GroupBox()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SelectColorButton = New System.Windows.Forms.Button()
        Me.WaveformsButton = New System.Windows.Forms.Button()
        Me.MainToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.TopMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawingPictureBox = New System.Windows.Forms.PictureBox()
        Me.ColorDialog = New System.Windows.Forms.ColorDialog()
        Me.MainContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileContextMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitContextMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditContextMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorContextMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsContextMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearContextMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpContextMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutContextMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.HorizontalTrackBar = New System.Windows.Forms.TrackBar()
        Me.VerticalTrackBar = New System.Windows.Forms.TrackBar()
        Me.MouseDrawRadioButton = New System.Windows.Forms.RadioButton()
        Me.SliderDrawRadioButton = New System.Windows.Forms.RadioButton()
        Me.SerialDrawRadioButton = New System.Windows.Forms.RadioButton()
        Me.DrawGroupBox = New System.Windows.Forms.GroupBox()
        Me.XLabel = New System.Windows.Forms.Label()
        Me.YLabel = New System.Windows.Forms.Label()
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialComPortsComboBox = New System.Windows.Forms.ComboBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.ButtonGroupBox.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainContextMenuStrip.SuspendLayout()
        CType(Me.HorizontalTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerticalTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DrawGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.ButtonGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Controls.Add(Me.SelectColorButton)
        Me.ButtonGroupBox.Controls.Add(Me.WaveformsButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(120, 575)
        Me.ButtonGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.ButtonGroupBox.Size = New System.Drawing.Size(584, 81)
        Me.ButtonGroupBox.TabIndex = 0
        Me.ButtonGroupBox.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(296, 14)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(136, 58)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "&Clear"
        Me.MainToolTip.SetToolTip(Me.ClearButton, "Clears the current drawing")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(440, 14)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(4)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(136, 58)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.MainToolTip.SetToolTip(Me.ExitButton, "Closes the form")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(8, 14)
        Me.SelectColorButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(136, 58)
        Me.SelectColorButton.TabIndex = 0
        Me.SelectColorButton.Text = "&Select Color"
        Me.MainToolTip.SetToolTip(Me.SelectColorButton, "Select a new drawing color")
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'WaveformsButton
        '
        Me.WaveformsButton.Location = New System.Drawing.Point(152, 14)
        Me.WaveformsButton.Margin = New System.Windows.Forms.Padding(4)
        Me.WaveformsButton.Name = "WaveformsButton"
        Me.WaveformsButton.Size = New System.Drawing.Size(136, 58)
        Me.WaveformsButton.TabIndex = 1
        Me.WaveformsButton.Text = "&Draw Waveforms"
        Me.MainToolTip.SetToolTip(Me.WaveformsButton, "Draw a 10x10 grid, sine, cosine, and tangent waves")
        Me.WaveformsButton.UseVisualStyleBackColor = True
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.TopMenuStrip.Size = New System.Drawing.Size(816, 28)
        Me.TopMenuStrip.TabIndex = 1
        Me.TopMenuStrip.Text = "TopMenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "&File"
        Me.FileToolStripMenuItem.ToolTipText = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(116, 26)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        Me.ExitToolStripMenuItem.ToolTipText = "Exit the form"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWaveformsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(49, 24)
        Me.EditToolStripMenuItem.Text = "&Edit"
        Me.EditToolStripMenuItem.ToolTipText = "Edit drawing"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.SelectColorToolStripMenuItem.Text = "&Select Color"
        Me.SelectColorToolStripMenuItem.ToolTipText = "Select a new drawing color"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.DrawWaveformsToolStripMenuItem.Text = "&Draw Waveforms"
        Me.DrawWaveformsToolStripMenuItem.ToolTipText = "Draw a 10x10 grid, sine, cosine, and tangent waves"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        Me.ClearToolStripMenuItem.ToolTipText = "Clear the current drawing"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        Me.HelpToolStripMenuItem.ToolTipText = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(133, 26)
        Me.AboutToolStripMenuItem.Text = "&About"
        Me.AboutToolStripMenuItem.ToolTipText = "About this form"
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawingPictureBox.BackColor = System.Drawing.Color.LightYellow
        Me.DrawingPictureBox.Location = New System.Drawing.Point(16, 46)
        Me.DrawingPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DrawingPictureBox.MinimumSize = New System.Drawing.Size(747, 406)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(747, 406)
        Me.DrawingPictureBox.TabIndex = 2
        Me.DrawingPictureBox.TabStop = False
        '
        'MainContextMenuStrip
        '
        Me.MainContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileContextMenuButton, Me.EditContextMenuButton, Me.HelpContextMenuButton})
        Me.MainContextMenuStrip.Name = "PictureBoxContextMenuStrip"
        Me.MainContextMenuStrip.Size = New System.Drawing.Size(111, 76)
        '
        'FileContextMenuButton
        '
        Me.FileContextMenuButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitContextMenuButton})
        Me.FileContextMenuButton.Name = "FileContextMenuButton"
        Me.FileContextMenuButton.Size = New System.Drawing.Size(110, 24)
        Me.FileContextMenuButton.Text = "&File"
        Me.FileContextMenuButton.ToolTipText = "File"
        '
        'ExitContextMenuButton
        '
        Me.ExitContextMenuButton.Name = "ExitContextMenuButton"
        Me.ExitContextMenuButton.Size = New System.Drawing.Size(116, 26)
        Me.ExitContextMenuButton.Text = "E&xit"
        Me.ExitContextMenuButton.ToolTipText = "Closes the form"
        '
        'EditContextMenuButton
        '
        Me.EditContextMenuButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorContextMenuButton, Me.DrawWaveformsContextMenuButton, Me.ClearContextMenuButton})
        Me.EditContextMenuButton.Name = "EditContextMenuButton"
        Me.EditContextMenuButton.Size = New System.Drawing.Size(110, 24)
        Me.EditContextMenuButton.Text = "&Edit"
        Me.EditContextMenuButton.ToolTipText = "Edit"
        '
        'SelectColorContextMenuButton
        '
        Me.SelectColorContextMenuButton.Name = "SelectColorContextMenuButton"
        Me.SelectColorContextMenuButton.Size = New System.Drawing.Size(205, 26)
        Me.SelectColorContextMenuButton.Text = "&Select Color"
        Me.SelectColorContextMenuButton.ToolTipText = "Select a new drawing color"
        '
        'DrawWaveformsContextMenuButton
        '
        Me.DrawWaveformsContextMenuButton.Name = "DrawWaveformsContextMenuButton"
        Me.DrawWaveformsContextMenuButton.Size = New System.Drawing.Size(205, 26)
        Me.DrawWaveformsContextMenuButton.Text = "&Draw Waveforms"
        Me.DrawWaveformsContextMenuButton.ToolTipText = "Draws a 10x10 grid, sine, cosine, and tangent waves"
        '
        'ClearContextMenuButton
        '
        Me.ClearContextMenuButton.Name = "ClearContextMenuButton"
        Me.ClearContextMenuButton.Size = New System.Drawing.Size(205, 26)
        Me.ClearContextMenuButton.Text = "&Clear"
        Me.ClearContextMenuButton.ToolTipText = "Clears the current drawing"
        '
        'HelpContextMenuButton
        '
        Me.HelpContextMenuButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutContextMenuButton})
        Me.HelpContextMenuButton.Name = "HelpContextMenuButton"
        Me.HelpContextMenuButton.Size = New System.Drawing.Size(110, 24)
        Me.HelpContextMenuButton.Text = "&Help"
        Me.HelpContextMenuButton.ToolTipText = "Help"
        '
        'AboutContextMenuButton
        '
        Me.AboutContextMenuButton.Name = "AboutContextMenuButton"
        Me.AboutContextMenuButton.Size = New System.Drawing.Size(133, 26)
        Me.AboutContextMenuButton.Text = "&About"
        Me.AboutContextMenuButton.ToolTipText = "About this form"
        '
        'HorizontalTrackBar
        '
        Me.HorizontalTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.HorizontalTrackBar.Location = New System.Drawing.Point(16, 459)
        Me.HorizontalTrackBar.Margin = New System.Windows.Forms.Padding(4)
        Me.HorizontalTrackBar.Maximum = 100
        Me.HorizontalTrackBar.Name = "HorizontalTrackBar"
        Me.HorizontalTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HorizontalTrackBar.RightToLeftLayout = True
        Me.HorizontalTrackBar.Size = New System.Drawing.Size(747, 56)
        Me.HorizontalTrackBar.TabIndex = 3
        Me.HorizontalTrackBar.TickFrequency = 10
        '
        'VerticalTrackBar
        '
        Me.VerticalTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.VerticalTrackBar.Location = New System.Drawing.Point(771, 46)
        Me.VerticalTrackBar.Margin = New System.Windows.Forms.Padding(4)
        Me.VerticalTrackBar.Maximum = 100
        Me.VerticalTrackBar.Name = "VerticalTrackBar"
        Me.VerticalTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.VerticalTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VerticalTrackBar.RightToLeftLayout = True
        Me.VerticalTrackBar.Size = New System.Drawing.Size(56, 406)
        Me.VerticalTrackBar.TabIndex = 4
        Me.VerticalTrackBar.TickFrequency = 10
        '
        'MouseDrawRadioButton
        '
        Me.MouseDrawRadioButton.AutoSize = True
        Me.MouseDrawRadioButton.Checked = True
        Me.MouseDrawRadioButton.ForeColor = System.Drawing.Color.White
        Me.MouseDrawRadioButton.Location = New System.Drawing.Point(8, 23)
        Me.MouseDrawRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.MouseDrawRadioButton.Name = "MouseDrawRadioButton"
        Me.MouseDrawRadioButton.Size = New System.Drawing.Size(69, 20)
        Me.MouseDrawRadioButton.TabIndex = 5
        Me.MouseDrawRadioButton.TabStop = True
        Me.MouseDrawRadioButton.Text = "Mouse"
        Me.MouseDrawRadioButton.UseVisualStyleBackColor = True
        '
        'SliderDrawRadioButton
        '
        Me.SliderDrawRadioButton.AutoSize = True
        Me.SliderDrawRadioButton.ForeColor = System.Drawing.Color.White
        Me.SliderDrawRadioButton.Location = New System.Drawing.Point(92, 23)
        Me.SliderDrawRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SliderDrawRadioButton.Name = "SliderDrawRadioButton"
        Me.SliderDrawRadioButton.Size = New System.Drawing.Size(70, 20)
        Me.SliderDrawRadioButton.TabIndex = 6
        Me.SliderDrawRadioButton.Text = "Sliders"
        Me.SliderDrawRadioButton.UseVisualStyleBackColor = True
        '
        'SerialDrawRadioButton
        '
        Me.SerialDrawRadioButton.AutoSize = True
        Me.SerialDrawRadioButton.ForeColor = System.Drawing.Color.White
        Me.SerialDrawRadioButton.Location = New System.Drawing.Point(175, 23)
        Me.SerialDrawRadioButton.Margin = New System.Windows.Forms.Padding(4)
        Me.SerialDrawRadioButton.Name = "SerialDrawRadioButton"
        Me.SerialDrawRadioButton.Size = New System.Drawing.Size(63, 20)
        Me.SerialDrawRadioButton.TabIndex = 7
        Me.SerialDrawRadioButton.Text = "Serial"
        Me.SerialDrawRadioButton.UseVisualStyleBackColor = True
        '
        'DrawGroupBox
        '
        Me.DrawGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.DrawGroupBox.Controls.Add(Me.MouseDrawRadioButton)
        Me.DrawGroupBox.Controls.Add(Me.SerialDrawRadioButton)
        Me.DrawGroupBox.Controls.Add(Me.SliderDrawRadioButton)
        Me.DrawGroupBox.ForeColor = System.Drawing.Color.White
        Me.DrawGroupBox.Location = New System.Drawing.Point(128, 507)
        Me.DrawGroupBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DrawGroupBox.Name = "DrawGroupBox"
        Me.DrawGroupBox.Padding = New System.Windows.Forms.Padding(4)
        Me.DrawGroupBox.Size = New System.Drawing.Size(248, 60)
        Me.DrawGroupBox.TabIndex = 8
        Me.DrawGroupBox.TabStop = False
        Me.DrawGroupBox.Text = "Drawing Input"
        '
        'XLabel
        '
        Me.XLabel.AutoSize = True
        Me.XLabel.ForeColor = System.Drawing.Color.White
        Me.XLabel.Location = New System.Drawing.Point(58, 519)
        Me.XLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.XLabel.Name = "XLabel"
        Me.XLabel.Size = New System.Drawing.Size(48, 16)
        Me.XLabel.TabIndex = 9
        Me.XLabel.Text = "Label1"
        '
        'YLabel
        '
        Me.YLabel.AutoSize = True
        Me.YLabel.ForeColor = System.Drawing.Color.White
        Me.YLabel.Location = New System.Drawing.Point(58, 536)
        Me.YLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.YLabel.Name = "YLabel"
        Me.YLabel.Size = New System.Drawing.Size(48, 16)
        Me.YLabel.TabIndex = 10
        Me.YLabel.Text = "Label1"
        '
        'SerialPort
        '
        Me.SerialPort.PortName = "COM3"
        '
        'SerialComPortsComboBox
        '
        Me.SerialComPortsComboBox.FormattingEnabled = True
        Me.SerialComPortsComboBox.Location = New System.Drawing.Point(416, 533)
        Me.SerialComPortsComboBox.Name = "SerialComPortsComboBox"
        Me.SerialComPortsComboBox.Size = New System.Drawing.Size(121, 24)
        Me.SerialComPortsComboBox.TabIndex = 11
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(624, 533)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(75, 23)
        Me.ConnectButton.TabIndex = 12
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(543, 533)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(75, 23)
        Me.RefreshButton.TabIndex = 13
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'Timer2
        '
        Me.Timer2.Interval = 15
        '
        'EtchOSketchForm
        '
        Me.AcceptButton = Me.WaveformsButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(816, 671)
        Me.ContextMenuStrip = Me.MainContextMenuStrip
        Me.Controls.Add(Me.RefreshButton)
        Me.Controls.Add(Me.ConnectButton)
        Me.Controls.Add(Me.SerialComPortsComboBox)
        Me.Controls.Add(Me.YLabel)
        Me.Controls.Add(Me.XLabel)
        Me.Controls.Add(Me.DrawGroupBox)
        Me.Controls.Add(Me.VerticalTrackBar)
        Me.Controls.Add(Me.HorizontalTrackBar)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(795, 611)
        Me.Name = "EtchOSketchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etch-O-Sketch"
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MainContextMenuStrip.ResumeLayout(False)
        CType(Me.HorizontalTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VerticalTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DrawGroupBox.ResumeLayout(False)
        Me.DrawGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ButtonGroupBox As GroupBox
    Friend WithEvents SelectColorButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents WaveformsButton As Button
    Friend WithEvents MainToolTip As ToolTip
    Friend WithEvents TopMenuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DrawingPictureBox As PictureBox
    Friend WithEvents ColorDialog As ColorDialog
    Friend WithEvents MainContextMenuStrip As ContextMenuStrip
    Friend WithEvents FileContextMenuButton As ToolStripMenuItem
    Friend WithEvents ExitContextMenuButton As ToolStripMenuItem
    Friend WithEvents EditContextMenuButton As ToolStripMenuItem
    Friend WithEvents SelectColorContextMenuButton As ToolStripMenuItem
    Friend WithEvents DrawWaveformsContextMenuButton As ToolStripMenuItem
    Friend WithEvents ClearContextMenuButton As ToolStripMenuItem
    Friend WithEvents HelpContextMenuButton As ToolStripMenuItem
    Friend WithEvents AboutContextMenuButton As ToolStripMenuItem
    Friend WithEvents HorizontalTrackBar As TrackBar
    Friend WithEvents VerticalTrackBar As TrackBar
    Friend WithEvents MouseDrawRadioButton As RadioButton
    Friend WithEvents SliderDrawRadioButton As RadioButton
    Friend WithEvents SerialDrawRadioButton As RadioButton
    Friend WithEvents DrawGroupBox As GroupBox
    Friend WithEvents XLabel As Label
    Friend WithEvents YLabel As Label
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents SerialComPortsComboBox As ComboBox
    Friend WithEvents ConnectButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
End Class
