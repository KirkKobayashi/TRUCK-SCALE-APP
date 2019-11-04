<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TitlePanel = New System.Windows.Forms.Panel()
        Me.PanelTitle = New System.Windows.Forms.Panel()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblWelcome = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.MainPanel = New System.Windows.Forms.Panel()
        Me.s_strip = New System.Windows.Forms.StatusStrip()
        Me.s_stripLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NaviPanel = New System.Windows.Forms.Panel()
        Me.userPanel = New System.Windows.Forms.Panel()
        Me.btnReport = New System.Windows.Forms.Button()
        Me.btnWeighing = New System.Windows.Forms.Button()
        Me.adminPanel = New System.Windows.Forms.Panel()
        Me.btnSerial = New System.Windows.Forms.Button()
        Me.btnDatabase = New System.Windows.Forms.Button()
        Me.btnUser = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.buttonIndicator = New System.Windows.Forms.PictureBox()
        Me.BunifuDragControl1 = New Bunifu.Framework.UI.BunifuDragControl(Me.components)
        Me.TitlePanel.SuspendLayout()
        Me.PanelTitle.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.MainPanel.SuspendLayout()
        Me.s_strip.SuspendLayout()
        Me.NaviPanel.SuspendLayout()
        Me.userPanel.SuspendLayout()
        Me.adminPanel.SuspendLayout()
        CType(Me.buttonIndicator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TitlePanel
        '
        Me.TitlePanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.TitlePanel.Controls.Add(Me.PanelTitle)
        Me.TitlePanel.Controls.Add(Me.Panel3)
        Me.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitlePanel.Location = New System.Drawing.Point(0, 0)
        Me.TitlePanel.Name = "TitlePanel"
        Me.TitlePanel.Size = New System.Drawing.Size(1214, 48)
        Me.TitlePanel.TabIndex = 0
        '
        'PanelTitle
        '
        Me.PanelTitle.Controls.Add(Me.lblUser)
        Me.PanelTitle.Controls.Add(Me.btnLogin)
        Me.PanelTitle.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelTitle.Location = New System.Drawing.Point(0, 0)
        Me.PanelTitle.Name = "PanelTitle"
        Me.PanelTitle.Size = New System.Drawing.Size(802, 48)
        Me.PanelTitle.TabIndex = 1
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(211, 13)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(0, 13)
        Me.lblUser.TabIndex = 1
        Me.lblUser.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.White
        Me.btnLogin.Image = CType(resources.GetObject("btnLogin.Image"), System.Drawing.Image)
        Me.btnLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnLogin.Location = New System.Drawing.Point(19, 3)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(110, 44)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Log In"
        Me.btnLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblWelcome)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(950, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(264, 48)
        Me.Panel3.TabIndex = 0
        '
        'lblWelcome
        '
        Me.lblWelcome.AutoSize = True
        Me.lblWelcome.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcome.ForeColor = System.Drawing.Color.White
        Me.lblWelcome.Location = New System.Drawing.Point(13, 17)
        Me.lblWelcome.Name = "lblWelcome"
        Me.lblWelcome.Size = New System.Drawing.Size(0, 17)
        Me.lblWelcome.TabIndex = 0
        Me.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.MainPanel)
        Me.Panel2.Controls.Add(Me.NaviPanel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 48)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1214, 748)
        Me.Panel2.TabIndex = 1
        '
        'MainPanel
        '
        Me.MainPanel.Controls.Add(Me.s_strip)
        Me.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MainPanel.Location = New System.Drawing.Point(0, 58)
        Me.MainPanel.Name = "MainPanel"
        Me.MainPanel.Size = New System.Drawing.Size(1214, 690)
        Me.MainPanel.TabIndex = 1
        '
        's_strip
        '
        Me.s_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.s_stripLabel})
        Me.s_strip.Location = New System.Drawing.Point(0, 668)
        Me.s_strip.Name = "s_strip"
        Me.s_strip.Size = New System.Drawing.Size(1214, 22)
        Me.s_strip.TabIndex = 0
        Me.s_strip.Text = "StatusStrip1"
        '
        's_stripLabel
        '
        Me.s_stripLabel.Name = "s_stripLabel"
        Me.s_stripLabel.Size = New System.Drawing.Size(0, 17)
        '
        'NaviPanel
        '
        Me.NaviPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(166, Byte), Integer), CType(CType(176, Byte), Integer))
        Me.NaviPanel.Controls.Add(Me.userPanel)
        Me.NaviPanel.Controls.Add(Me.adminPanel)
        Me.NaviPanel.Controls.Add(Me.btnClose)
        Me.NaviPanel.Controls.Add(Me.buttonIndicator)
        Me.NaviPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.NaviPanel.Location = New System.Drawing.Point(0, 0)
        Me.NaviPanel.Name = "NaviPanel"
        Me.NaviPanel.Size = New System.Drawing.Size(1214, 58)
        Me.NaviPanel.TabIndex = 0
        '
        'userPanel
        '
        Me.userPanel.Controls.Add(Me.btnReport)
        Me.userPanel.Controls.Add(Me.btnWeighing)
        Me.userPanel.Location = New System.Drawing.Point(3, 0)
        Me.userPanel.Name = "userPanel"
        Me.userPanel.Size = New System.Drawing.Size(256, 47)
        Me.userPanel.TabIndex = 8
        Me.userPanel.Visible = False
        '
        'btnReport
        '
        Me.btnReport.FlatAppearance.BorderSize = 0
        Me.btnReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReport.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReport.ForeColor = System.Drawing.Color.White
        Me.btnReport.Location = New System.Drawing.Point(131, 6)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Size = New System.Drawing.Size(117, 35)
        Me.btnReport.TabIndex = 7
        Me.btnReport.Text = "Reporting"
        Me.btnReport.UseVisualStyleBackColor = True
        '
        'btnWeighing
        '
        Me.btnWeighing.FlatAppearance.BorderSize = 0
        Me.btnWeighing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnWeighing.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWeighing.ForeColor = System.Drawing.Color.White
        Me.btnWeighing.Location = New System.Drawing.Point(8, 6)
        Me.btnWeighing.Name = "btnWeighing"
        Me.btnWeighing.Size = New System.Drawing.Size(117, 35)
        Me.btnWeighing.TabIndex = 6
        Me.btnWeighing.Text = "Weighing"
        Me.btnWeighing.UseVisualStyleBackColor = True
        '
        'adminPanel
        '
        Me.adminPanel.Controls.Add(Me.btnSerial)
        Me.adminPanel.Controls.Add(Me.btnDatabase)
        Me.adminPanel.Controls.Add(Me.btnUser)
        Me.adminPanel.Location = New System.Drawing.Point(258, 0)
        Me.adminPanel.Name = "adminPanel"
        Me.adminPanel.Size = New System.Drawing.Size(428, 47)
        Me.adminPanel.TabIndex = 7
        Me.adminPanel.Visible = False
        '
        'btnSerial
        '
        Me.btnSerial.FlatAppearance.BorderSize = 0
        Me.btnSerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSerial.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSerial.ForeColor = System.Drawing.Color.White
        Me.btnSerial.Location = New System.Drawing.Point(250, 6)
        Me.btnSerial.Name = "btnSerial"
        Me.btnSerial.Size = New System.Drawing.Size(117, 35)
        Me.btnSerial.TabIndex = 8
        Me.btnSerial.Text = "Reporting"
        Me.btnSerial.UseVisualStyleBackColor = True
        Me.btnSerial.Visible = False
        '
        'btnDatabase
        '
        Me.btnDatabase.FlatAppearance.BorderSize = 0
        Me.btnDatabase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDatabase.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDatabase.ForeColor = System.Drawing.Color.White
        Me.btnDatabase.Location = New System.Drawing.Point(136, 6)
        Me.btnDatabase.Name = "btnDatabase"
        Me.btnDatabase.Size = New System.Drawing.Size(117, 35)
        Me.btnDatabase.TabIndex = 7
        Me.btnDatabase.Text = "Database"
        Me.btnDatabase.UseVisualStyleBackColor = True
        '
        'btnUser
        '
        Me.btnUser.FlatAppearance.BorderSize = 0
        Me.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUser.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUser.ForeColor = System.Drawing.Color.White
        Me.btnUser.Location = New System.Drawing.Point(13, 6)
        Me.btnUser.Name = "btnUser"
        Me.btnUser.Size = New System.Drawing.Size(117, 35)
        Me.btnUser.TabIndex = 6
        Me.btnUser.Text = "User"
        Me.btnUser.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnClose.FlatAppearance.BorderSize = 0
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Century Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.ForeColor = System.Drawing.Color.White
        Me.btnClose.Location = New System.Drawing.Point(1176, 0)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(38, 58)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "X"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'buttonIndicator
        '
        Me.buttonIndicator.BackColor = System.Drawing.Color.Gold
        Me.buttonIndicator.Location = New System.Drawing.Point(7, 50)
        Me.buttonIndicator.Name = "buttonIndicator"
        Me.buttonIndicator.Size = New System.Drawing.Size(119, 15)
        Me.buttonIndicator.TabIndex = 1
        Me.buttonIndicator.TabStop = False
        Me.buttonIndicator.Visible = False
        '
        'BunifuDragControl1
        '
        Me.BunifuDragControl1.Fixed = True
        Me.BunifuDragControl1.Horizontal = True
        Me.BunifuDragControl1.TargetControl = Me.PanelTitle
        Me.BunifuDragControl1.Vertical = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1214, 796)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TitlePanel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.Text = "frmMain"
        Me.TitlePanel.ResumeLayout(False)
        Me.PanelTitle.ResumeLayout(False)
        Me.PanelTitle.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.MainPanel.ResumeLayout(False)
        Me.MainPanel.PerformLayout()
        Me.s_strip.ResumeLayout(False)
        Me.s_strip.PerformLayout()
        Me.NaviPanel.ResumeLayout(False)
        Me.userPanel.ResumeLayout(False)
        Me.adminPanel.ResumeLayout(False)
        CType(Me.buttonIndicator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TitlePanel As Panel
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lblWelcome As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents MainPanel As Panel
    Friend WithEvents s_strip As StatusStrip
    Friend WithEvents NaviPanel As Panel
    Friend WithEvents BunifuDragControl1 As Bunifu.Framework.UI.BunifuDragControl
    Friend WithEvents buttonIndicator As PictureBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents s_stripLabel As ToolStripStatusLabel
    Friend WithEvents adminPanel As Panel
    Friend WithEvents btnSerial As Button
    Friend WithEvents btnDatabase As Button
    Friend WithEvents btnUser As Button
    Friend WithEvents userPanel As Panel
    Friend WithEvents btnReport As Button
    Friend WithEvents btnWeighing As Button
    Friend WithEvents lblUser As Label
End Class
