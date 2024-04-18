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
        Me.WaveformsButton = New System.Windows.Forms.Button()
        Me.SelectColorButton = New System.Windows.Forms.Button()
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
        Me.PictureBoxContextMenuStrip = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.FileContextMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectColorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DrawWaveformsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitContextMenuButton = New System.Windows.Forms.ToolStripMenuItem()
        Me.ButtonGroupBox.SuspendLayout()
        Me.TopMenuStrip.SuspendLayout()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PictureBoxContextMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'ButtonGroupBox
        '
        Me.ButtonGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonGroupBox.Controls.Add(Me.WaveformsButton)
        Me.ButtonGroupBox.Controls.Add(Me.SelectColorButton)
        Me.ButtonGroupBox.Location = New System.Drawing.Point(142, 368)
        Me.ButtonGroupBox.Name = "ButtonGroupBox"
        Me.ButtonGroupBox.Size = New System.Drawing.Size(438, 80)
        Me.ButtonGroupBox.TabIndex = 0
        Me.ButtonGroupBox.TabStop = False
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(222, 19)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(102, 47)
        Me.ClearButton.TabIndex = 4
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(330, 19)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(102, 47)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'WaveformsButton
        '
        Me.WaveformsButton.Location = New System.Drawing.Point(114, 19)
        Me.WaveformsButton.Name = "WaveformsButton"
        Me.WaveformsButton.Size = New System.Drawing.Size(102, 47)
        Me.WaveformsButton.TabIndex = 1
        Me.WaveformsButton.Text = "&Draw Waveforms"
        Me.WaveformsButton.UseVisualStyleBackColor = True
        '
        'SelectColorButton
        '
        Me.SelectColorButton.Location = New System.Drawing.Point(6, 19)
        Me.SelectColorButton.Name = "SelectColorButton"
        Me.SelectColorButton.Size = New System.Drawing.Size(102, 47)
        Me.SelectColorButton.TabIndex = 0
        Me.SelectColorButton.Text = "&Select Color"
        Me.SelectColorButton.UseVisualStyleBackColor = True
        '
        'MainToolTip
        '
        '
        'TopMenuStrip
        '
        Me.TopMenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.TopMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.TopMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.TopMenuStrip.Name = "TopMenuStrip"
        Me.TopMenuStrip.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.TopMenuStrip.Size = New System.Drawing.Size(593, 24)
        Me.TopMenuStrip.TabIndex = 1
        Me.TopMenuStrip.Text = "TopMenuStrip"
        Me.TopMenuStrip.Visible = False
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem, Me.DrawWaveformsToolStripMenuItem, Me.ClearToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'SelectColorToolStripMenuItem
        '
        Me.SelectColorToolStripMenuItem.Name = "SelectColorToolStripMenuItem"
        Me.SelectColorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SelectColorToolStripMenuItem.Text = "&Select Color"
        '
        'DrawWaveformsToolStripMenuItem
        '
        Me.DrawWaveformsToolStripMenuItem.Name = "DrawWaveformsToolStripMenuItem"
        Me.DrawWaveformsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DrawWaveformsToolStripMenuItem.Text = "&Draw Waveforms"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "&About"
        '
        'DrawingPictureBox
        '
        Me.DrawingPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DrawingPictureBox.BackColor = System.Drawing.Color.LightYellow
        Me.DrawingPictureBox.Location = New System.Drawing.Point(12, 37)
        Me.DrawingPictureBox.MinimumSize = New System.Drawing.Size(568, 325)
        Me.DrawingPictureBox.Name = "DrawingPictureBox"
        Me.DrawingPictureBox.Size = New System.Drawing.Size(568, 325)
        Me.DrawingPictureBox.TabIndex = 2
        Me.DrawingPictureBox.TabStop = False
        '
        'PictureBoxContextMenuStrip
        '
        Me.PictureBoxContextMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileContextMenuButton, Me.EditToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.PictureBoxContextMenuStrip.Name = "PictureBoxContextMenuStrip"
        Me.PictureBoxContextMenuStrip.Size = New System.Drawing.Size(181, 92)
        '
        'FileContextMenuButton
        '
        Me.FileContextMenuButton.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitContextMenuButton})
        Me.FileContextMenuButton.Name = "FileContextMenuButton"
        Me.FileContextMenuButton.Size = New System.Drawing.Size(180, 22)
        Me.FileContextMenuButton.Text = "&File"
        '
        'EditToolStripMenuItem1
        '
        Me.EditToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SelectColorToolStripMenuItem1, Me.DrawWaveformsToolStripMenuItem1, Me.ClearToolStripMenuItem1})
        Me.EditToolStripMenuItem1.Name = "EditToolStripMenuItem1"
        Me.EditToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.EditToolStripMenuItem1.Text = "&Edit"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem1})
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(180, 22)
        Me.ToolStripMenuItem2.Text = "&Help"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AboutToolStripMenuItem1.Text = "&About"
        '
        'SelectColorToolStripMenuItem1
        '
        Me.SelectColorToolStripMenuItem1.Name = "SelectColorToolStripMenuItem1"
        Me.SelectColorToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.SelectColorToolStripMenuItem1.Text = "&Select Color"
        '
        'DrawWaveformsToolStripMenuItem1
        '
        Me.DrawWaveformsToolStripMenuItem1.Name = "DrawWaveformsToolStripMenuItem1"
        Me.DrawWaveformsToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.DrawWaveformsToolStripMenuItem1.Text = "&Draw Waveforms"
        '
        'ClearToolStripMenuItem1
        '
        Me.ClearToolStripMenuItem1.Name = "ClearToolStripMenuItem1"
        Me.ClearToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem1.Text = "&Clear"
        '
        'ExitContextMenuButton
        '
        Me.ExitContextMenuButton.Name = "ExitContextMenuButton"
        Me.ExitContextMenuButton.Size = New System.Drawing.Size(180, 22)
        Me.ExitContextMenuButton.Text = "E&xit"
        '
        'EtchOSketchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(593, 466)
        Me.Controls.Add(Me.DrawingPictureBox)
        Me.Controls.Add(Me.ButtonGroupBox)
        Me.Controls.Add(Me.TopMenuStrip)
        Me.MinimumSize = New System.Drawing.Size(609, 505)
        Me.Name = "EtchOSketchForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Etch-O-Sketch"
        Me.ButtonGroupBox.ResumeLayout(False)
        Me.TopMenuStrip.ResumeLayout(False)
        Me.TopMenuStrip.PerformLayout()
        CType(Me.DrawingPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PictureBoxContextMenuStrip.ResumeLayout(False)
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
    Friend WithEvents PictureBoxContextMenuStrip As ContextMenuStrip
    Friend WithEvents FileContextMenuButton As ToolStripMenuItem
    Friend WithEvents ExitContextMenuButton As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents SelectColorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents DrawWaveformsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
End Class
