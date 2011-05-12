<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
    Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
    Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
    Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
    Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
    Me.lblErrors = New System.Windows.Forms.Label()
    Me.lstErrors = New System.Windows.Forms.ListBox()
    Me.btnNotepad = New System.Windows.Forms.Button()
    Me.MenuStrip1.SuspendLayout()
    Me.StatusStrip1.SuspendLayout()
    Me.SuspendLayout()
    '
    'MenuStrip1
    '
    Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
    Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
    Me.MenuStrip1.Name = "MenuStrip1"
    Me.MenuStrip1.Size = New System.Drawing.Size(392, 24)
    Me.MenuStrip1.TabIndex = 0
    Me.MenuStrip1.Text = "MenuStrip1"
    '
    'FileToolStripMenuItem
    '
    Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ExitToolStripMenuItem})
    Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
    Me.FileToolStripMenuItem.Size = New System.Drawing.Size(35, 20)
    Me.FileToolStripMenuItem.Text = "File"
    '
    'OpenToolStripMenuItem
    '
    Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
    Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
    Me.OpenToolStripMenuItem.Text = "Open..."
    '
    'ExitToolStripMenuItem
    '
    Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
    Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
    Me.ExitToolStripMenuItem.Text = "Exit"
    '
    'OpenFileDialog1
    '
    Me.OpenFileDialog1.FileName = "OpenFileDialog1"
    '
    'StatusStrip1
    '
    Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
    Me.StatusStrip1.Location = New System.Drawing.Point(0, 269)
    Me.StatusStrip1.Name = "StatusStrip1"
    Me.StatusStrip1.Size = New System.Drawing.Size(392, 22)
    Me.StatusStrip1.TabIndex = 1
    Me.StatusStrip1.Text = "StatusStrip1"
    '
    'ToolStripStatusLabel1
    '
    Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
    Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 17)
    Me.ToolStripStatusLabel1.Text = "Select a file using File -> Open"
    '
    'lblErrors
    '
    Me.lblErrors.AutoSize = True
    Me.lblErrors.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
    Me.lblErrors.Location = New System.Drawing.Point(13, 28)
    Me.lblErrors.Name = "lblErrors"
    Me.lblErrors.Size = New System.Drawing.Size(40, 13)
    Me.lblErrors.TabIndex = 2
    Me.lblErrors.Text = "Errors"
    '
    'lstErrors
    '
    Me.lstErrors.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
    Me.lstErrors.FormattingEnabled = True
    Me.lstErrors.HorizontalScrollbar = True
    Me.lstErrors.Location = New System.Drawing.Point(16, 45)
    Me.lstErrors.Name = "lstErrors"
    Me.lstErrors.Size = New System.Drawing.Size(364, 186)
    Me.lstErrors.TabIndex = 3
    '
    'btnNotepad
    '
    Me.btnNotepad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
    Me.btnNotepad.Enabled = False
    Me.btnNotepad.Location = New System.Drawing.Point(16, 237)
    Me.btnNotepad.Name = "btnNotepad"
    Me.btnNotepad.Size = New System.Drawing.Size(132, 23)
    Me.btnNotepad.TabIndex = 4
    Me.btnNotepad.Text = "View this file in Notepad"
    Me.btnNotepad.UseVisualStyleBackColor = True
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(392, 291)
    Me.Controls.Add(Me.btnNotepad)
    Me.Controls.Add(Me.lstErrors)
    Me.Controls.Add(Me.lblErrors)
    Me.Controls.Add(Me.StatusStrip1)
    Me.Controls.Add(Me.MenuStrip1)
    Me.MainMenuStrip = Me.MenuStrip1
    Me.Name = "Form1"
    Me.Text = "CTR Acknowledgements"
    Me.MenuStrip1.ResumeLayout(False)
    Me.MenuStrip1.PerformLayout()
    Me.StatusStrip1.ResumeLayout(False)
    Me.StatusStrip1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
  Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents OpenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
  Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
  Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
  Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
  Friend WithEvents lblErrors As System.Windows.Forms.Label
  Friend WithEvents lstErrors As System.Windows.Forms.ListBox
  Friend WithEvents btnNotepad As System.Windows.Forms.Button

End Class
