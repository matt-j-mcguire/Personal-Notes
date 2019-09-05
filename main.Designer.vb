<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.cms = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SaveAsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsTabs = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ccmain = New Personal_Notes.CleanTab()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeKeyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms.SuspendLayout()
        Me.cmsTabs.SuspendLayout()
        Me.SuspendLayout()
        '
        'cms
        '
        Me.cms.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.OpenToolStripMenuItem, Me.SaveToolStripMenuItem, Me.SaveAsToolStripMenuItem})
        Me.cms.Name = "ContextMenuStrip1"
        Me.cms.Size = New System.Drawing.Size(140, 92)
        '
        'SaveAsToolStripMenuItem
        '
        Me.SaveAsToolStripMenuItem.Name = "SaveAsToolStripMenuItem"
        Me.SaveAsToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SaveAsToolStripMenuItem.Text = "Save As"
        '
        'cmsTabs
        '
        Me.cmsTabs.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem1, Me.ChangeKeyToolStripMenuItem, Me.ToolStripMenuItem1, Me.CloseToolStripMenuItem})
        Me.cmsTabs.Name = "cmsTabs"
        Me.cmsTabs.Size = New System.Drawing.Size(153, 98)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(149, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        '
        'ccmain
        '
        Me.ccmain.AllowDrop = True
        Me.ccmain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ccmain.EmptyBackColor = System.Drawing.Color.Gray
        Me.ccmain.Location = New System.Drawing.Point(0, 0)
        Me.ccmain.Menu = Me.cms
        Me.ccmain.MenuIcon = Global.Personal_Notes.My.Resources.Resources.cog
        Me.ccmain.Name = "ccmain"
        Me.ccmain.Padding = New System.Windows.Forms.Padding(0, 25, 0, 0)
        Me.ccmain.SelectedBackColor = System.Drawing.Color.White
        Me.ccmain.SelectedForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ccmain.SelectedTab = Nothing
        Me.ccmain.Size = New System.Drawing.Size(706, 476)
        Me.ccmain.TabIndex = 0
        Me.ccmain.TabRclickMenu = Me.cmsTabs
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = Global.Personal_Notes.My.Resources.Resources.Newfile
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(139, 22)
        Me.ToolStripMenuItem2.Text = "New text file"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Image = Global.Personal_Notes.My.Resources.Resources.Open
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Image = Global.Personal_Notes.My.Resources.Resources.Save
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'SaveToolStripMenuItem1
        '
        Me.SaveToolStripMenuItem1.Image = Global.Personal_Notes.My.Resources.Resources.Save
        Me.SaveToolStripMenuItem1.Name = "SaveToolStripMenuItem1"
        Me.SaveToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.SaveToolStripMenuItem1.Text = "Save"
        '
        'ChangeKeyToolStripMenuItem
        '
        Me.ChangeKeyToolStripMenuItem.Image = Global.Personal_Notes.My.Resources.Resources.key
        Me.ChangeKeyToolStripMenuItem.Name = "ChangeKeyToolStripMenuItem"
        Me.ChangeKeyToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ChangeKeyToolStripMenuItem.Text = "Change Key"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 476)
        Me.Controls.Add(Me.ccmain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.Text = "Personal Notes"
        Me.cms.ResumeLayout(False)
        Me.cmsTabs.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ccmain As CleanTab
    Friend WithEvents cms As ContextMenuStrip
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveAsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmsTabs As ContextMenuStrip
    Friend WithEvents SaveToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ChangeKeyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
End Class
