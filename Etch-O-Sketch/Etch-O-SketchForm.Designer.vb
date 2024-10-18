<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EtchOSketchForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.SerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.SerialComPortsComboBox = New System.Windows.Forms.ComboBox()
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RefreshToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConnectContextMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshContextMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonGroupBox.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MainContextMenuStrip.SuspendLayout()
        CType(Me.HorizontalTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VerticalTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DrawGroupBox.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
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
        Me.ButtonGroupBox.Location = New System.Drawing.Point(90, 467)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(438, 66)
        Me.ButtonGroupBox.TabIndex = 0
        Me.ButtonGroupBox.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ClearButton.Location = New System.Drawing.Point(222, 11)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(102, 47)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "&Clear"
        Me.MainToolTip.SetToolTip(Me.ClearButton, "Clears the current drawing")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(330, 11)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(102, 47)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.MainToolTip.SetToolTip(Me.ExitButton, "Closes the form")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(6, 11)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(102, 47)
        Me.SelectColorButton.TabIndex = 0
        Me.SelectColorButton.Text = "&Select Color"
        Me.MainToolTip.SetToolTip(Me.SelectColorButton, "Select a new drawing color")
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'WaveformsButton
        '
        Me.WaveformsButton.Location = New System.Drawing.Point(114, 11)
        Me.WaveformsButton.Name = "WaveformsButton"
        Me.WaveformsButton.Size = New System.Drawing.Size(102, 47)
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
        Me.TopMenuStrip.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.TopMenuStrip.Size = New System.Drawing.Size(612, 24)
        Me.TopMenuStrip.TabIndex = 1
        Me.TopMenuStrip.Text = "TopMenuStrip"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RefreshToolStripMenuItem, Me.ConnectToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        Me.FileToolStripMenuItem.ToolTipText = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        Me.ExitToolStripMenuItem.ToolTipText = "Exit the form"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWaveformsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        Me.EditToolStripMenuItem.ToolTipText = "Edit drawing"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SelectColorToolStripMenuItem.Text = "&Select Color"
        Me.SelectColorToolStripMenuItem.ToolTipText = "Select a new drawing color"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DrawWaveformsToolStripMenuItem.Text = "&Draw Waveforms"
        Me.DrawWaveformsToolStripMenuItem.ToolTipText = "Draw a 10x10 grid, sine, cosine, and tangent waves"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        Me.ClearToolStripMenuItem.ToolTipText = "Clear the current drawing"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        Me.HelpToolStripMenuItem.ToolTipText = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        Me.AboutToolStripMenuItem.ToolTipText = "About this form"
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawingPictureBox.BackColor = System.Drawing.Color.LightYellow
        Me.DrawingPictureBox.Location = New System.Drawing.Point(12, 37)
        Me.DrawingPictureBox.MinimumSize = New System.Drawing.Size(560, 330)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(560, 330)
        Me.DrawingPictureBox.TabIndex = 2
        Me.DrawingPictureBox.TabStop = False
        '
        'MainContextMenuStrip
        '
        Me.MainContextMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MainContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileContextMenuButton, Me.EditContextMenuButton, Me.HelpContextMenuButton})
        Me.MainContextMenuStrip.Name = "PictureBoxContextMenuStrip"
        Me.MainContextMenuStrip.Size = New System.Drawing.Size(100, 70)
        '
        'FileContextMenuButton
        '
        Me.FileContextMenuButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectContextMenuButton, Me.RefreshContextMenuButton, Me.ExitContextMenuButton})
        Me.FileContextMenuButton.Name = "FileContextMenuButton"
        Me.FileContextMenuButton.Size = New System.Drawing.Size(180, 22)
        Me.FileContextMenuButton.Text = "&File"
        Me.FileContextMenuButton.ToolTipText = "File"
        '
        'ExitContextMenuButton
        '
        Me.ExitContextMenuButton.Name = "ExitContextMenuButton"
        Me.ExitContextMenuButton.Size = New System.Drawing.Size(180, 22)
        Me.ExitContextMenuButton.Text = "E&xit"
        Me.ExitContextMenuButton.ToolTipText = "Closes the form"
        '
        'EditContextMenuButton
        '
        Me.EditContextMenuButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorContextMenuButton, Me.DrawWaveformsContextMenuButton, Me.ClearContextMenuButton})
        Me.EditContextMenuButton.Name = "EditContextMenuButton"
        Me.EditContextMenuButton.Size = New System.Drawing.Size(180, 22)
        Me.EditContextMenuButton.Text = "&Edit"
        Me.EditContextMenuButton.ToolTipText = "Edit"
        '
        'SelectColorContextMenuButton
        '
        Me.SelectColorContextMenuButton.Name = "SelectColorContextMenuButton"
        Me.SelectColorContextMenuButton.Size = New System.Drawing.Size(164, 22)
        Me.SelectColorContextMenuButton.Text = "&Select Color"
        Me.SelectColorContextMenuButton.ToolTipText = "Select a new drawing color"
        '
        'DrawWaveformsContextMenuButton
        '
        Me.DrawWaveformsContextMenuButton.Name = "DrawWaveformsContextMenuButton"
        Me.DrawWaveformsContextMenuButton.Size = New System.Drawing.Size(164, 22)
        Me.DrawWaveformsContextMenuButton.Text = "&Draw Waveforms"
        Me.DrawWaveformsContextMenuButton.ToolTipText = "Draws a 10x10 grid, sine, cosine, and tangent waves"
        '
        'ClearContextMenuButton
        '
        Me.ClearContextMenuButton.Name = "ClearContextMenuButton"
        Me.ClearContextMenuButton.Size = New System.Drawing.Size(164, 22)
        Me.ClearContextMenuButton.Text = "&Clear"
        Me.ClearContextMenuButton.ToolTipText = "Clears the current drawing"
        '
        'HelpContextMenuButton
        '
        Me.HelpContextMenuButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutContextMenuButton})
        Me.HelpContextMenuButton.Name = "HelpContextMenuButton"
        Me.HelpContextMenuButton.Size = New System.Drawing.Size(180, 22)
        Me.HelpContextMenuButton.Text = "&Help"
        Me.HelpContextMenuButton.ToolTipText = "Help"
        '
        'AboutContextMenuButton
        '
        Me.AboutContextMenuButton.Name = "AboutContextMenuButton"
        Me.AboutContextMenuButton.Size = New System.Drawing.Size(107, 22)
        Me.AboutContextMenuButton.Text = "&About"
        Me.AboutContextMenuButton.ToolTipText = "About this form"
        '
        'HorizontalTrackBar
        '
        Me.HorizontalTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.HorizontalTrackBar.Location = New System.Drawing.Point(12, 373)
        Me.HorizontalTrackBar.Maximum = 100
        Me.HorizontalTrackBar.Name = "HorizontalTrackBar"
        Me.HorizontalTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.HorizontalTrackBar.RightToLeftLayout = True
        Me.HorizontalTrackBar.Size = New System.Drawing.Size(560, 45)
        Me.HorizontalTrackBar.TabIndex = 3
        Me.HorizontalTrackBar.TickFrequency = 10
        '
        'VerticalTrackBar
        '
        Me.VerticalTrackBar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.VerticalTrackBar.Location = New System.Drawing.Point(578, 37)
        Me.VerticalTrackBar.Maximum = 100
        Me.VerticalTrackBar.Name = "VerticalTrackBar"
        Me.VerticalTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.VerticalTrackBar.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.VerticalTrackBar.RightToLeftLayout = True
        Me.VerticalTrackBar.Size = New System.Drawing.Size(45, 330)
        Me.VerticalTrackBar.TabIndex = 4
        Me.VerticalTrackBar.TickFrequency = 10
        '
        'MouseDrawRadioButton
        '
        Me.MouseDrawRadioButton.AutoSize = True
        Me.MouseDrawRadioButton.Checked = True
        Me.MouseDrawRadioButton.ForeColor = System.Drawing.Color.White
        Me.MouseDrawRadioButton.Location = New System.Drawing.Point(6, 19)
        Me.MouseDrawRadioButton.Name = "MouseDrawRadioButton"
        Me.MouseDrawRadioButton.Size = New System.Drawing.Size(57, 17)
        Me.MouseDrawRadioButton.TabIndex = 5
        Me.MouseDrawRadioButton.TabStop = True
        Me.MouseDrawRadioButton.Text = "Mouse"
        Me.MouseDrawRadioButton.UseVisualStyleBackColor = True
        '
        'SliderDrawRadioButton
        '
        Me.SliderDrawRadioButton.AutoSize = True
        Me.SliderDrawRadioButton.ForeColor = System.Drawing.Color.White
        Me.SliderDrawRadioButton.Location = New System.Drawing.Point(78, 19)
        Me.SliderDrawRadioButton.Name = "SliderDrawRadioButton"
        Me.SliderDrawRadioButton.Size = New System.Drawing.Size(56, 17)
        Me.SliderDrawRadioButton.TabIndex = 6
        Me.SliderDrawRadioButton.Text = "Sliders"
        Me.SliderDrawRadioButton.UseVisualStyleBackColor = True
        '
        'SerialDrawRadioButton
        '
        Me.SerialDrawRadioButton.AutoSize = True
        Me.SerialDrawRadioButton.ForeColor = System.Drawing.Color.White
        Me.SerialDrawRadioButton.Location = New System.Drawing.Point(151, 19)
        Me.SerialDrawRadioButton.Name = "SerialDrawRadioButton"
        Me.SerialDrawRadioButton.Size = New System.Drawing.Size(51, 17)
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
        Me.DrawGroupBox.Location = New System.Drawing.Point(90, 412)
        Me.DrawGroupBox.Name = "DrawGroupBox"
        Me.DrawGroupBox.Size = New System.Drawing.Size(208, 49)
        Me.DrawGroupBox.TabIndex = 8
        Me.DrawGroupBox.TabStop = False
        Me.DrawGroupBox.Text = "Drawing Input"
        '
        'SerialPort
        '
        Me.SerialPort.PortName = "COM3"
        '
        'SerialComPortsComboBox
        '
        Me.SerialComPortsComboBox.FormattingEnabled = True
        Me.SerialComPortsComboBox.Location = New System.Drawing.Point(5, 21)
        Me.SerialComPortsComboBox.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SerialComPortsComboBox.Name = "SerialComPortsComboBox"
        Me.SerialComPortsComboBox.Size = New System.Drawing.Size(92, 21)
        Me.SerialComPortsComboBox.TabIndex = 11
        '
        'ConnectButton
        '
        Me.ConnectButton.ForeColor = System.Drawing.Color.Black
        Me.ConnectButton.Location = New System.Drawing.Point(163, 19)
        Me.ConnectButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(56, 23)
        Me.ConnectButton.TabIndex = 12
        Me.ConnectButton.Text = "C&onnect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.ForeColor = System.Drawing.Color.Black
        Me.RefreshButton.Location = New System.Drawing.Point(103, 19)
        Me.RefreshButton.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(56, 23)
        Me.RefreshButton.TabIndex = 13
        Me.RefreshButton.Text = "&Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.GroupBox1.Controls.Add(Me.SerialComPortsComboBox)
        Me.GroupBox1.Controls.Add(Me.RefreshButton)
        Me.GroupBox1.Controls.Add(Me.ConnectButton)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(304, 412)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(224, 49)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "COM Port"
        '
        'RefreshToolStripMenuItem
        '
        Me.RefreshToolStripMenuItem.Name = "RefreshToolStripMenuItem"
        Me.RefreshToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RefreshToolStripMenuItem.Text = "&Refresh"
        '
        'ConnectToolStripMenuItem
        '
        Me.ConnectToolStripMenuItem.Name = "ConnectToolStripMenuItem"
        Me.ConnectToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ConnectToolStripMenuItem.Text = "C&onnect"
        '
        'ConnectContextMenuButton
        '
        Me.ConnectContextMenuButton.Name = "ConnectContextMenuButton"
        Me.ConnectContextMenuButton.Size = New System.Drawing.Size(180, 22)
        Me.ConnectContextMenuButton.Text = "C&onnect"
        '
        'RefreshContextMenuButton
        '
        Me.RefreshContextMenuButton.Name = "RefreshContextMenuButton"
        Me.RefreshContextMenuButton.Size = New System.Drawing.Size(180, 22)
        Me.RefreshContextMenuButton.Text = "&Refresh"
        '
        'EtchOSketchForm
        '
        Me.AcceptButton = Me.WaveformsButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.CancelButton = Me.ClearButton
        Me.ClientSize = New System.Drawing.Size(612, 545)
        Me.ContextMenuStrip = Me.MainContextMenuStrip
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DrawGroupBox)
        Me.Controls.Add(Me.VerticalTrackBar)
        Me.Controls.Add(Me.HorizontalTrackBar)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MinimumSize = New System.Drawing.Size(600, 504)
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
        Me.GroupBox1.ResumeLayout(False)
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
    Friend WithEvents SerialPort As IO.Ports.SerialPort
    Friend WithEvents SerialComPortsComboBox As ComboBox
    Friend WithEvents ConnectButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RefreshToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConnectContextMenuButton As ToolStripMenuItem
    Friend WithEvents RefreshContextMenuButton As ToolStripMenuItem
End Class
