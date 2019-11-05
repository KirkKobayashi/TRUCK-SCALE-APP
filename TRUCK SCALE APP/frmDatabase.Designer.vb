<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmDatabase
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GB_Constring = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtDatabase = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.GB_Constring.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(24, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 46)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Database Settings"
        '
        'GB_Constring
        '
        Me.GB_Constring.Controls.Add(Me.btnClose)
        Me.GB_Constring.Controls.Add(Me.btnClear)
        Me.GB_Constring.Controls.Add(Me.btnSave)
        Me.GB_Constring.Controls.Add(Me.txtDatabase)
        Me.GB_Constring.Controls.Add(Me.Label7)
        Me.GB_Constring.Controls.Add(Me.txtUser)
        Me.GB_Constring.Controls.Add(Me.Label6)
        Me.GB_Constring.Controls.Add(Me.txtPassword)
        Me.GB_Constring.Controls.Add(Me.Label5)
        Me.GB_Constring.Controls.Add(Me.txtServer)
        Me.GB_Constring.Controls.Add(Me.Label2)
        Me.GB_Constring.Location = New System.Drawing.Point(7, 68)
        Me.GB_Constring.Name = "GB_Constring"
        Me.GB_Constring.Size = New System.Drawing.Size(432, 241)
        Me.GB_Constring.TabIndex = 1
        Me.GB_Constring.TabStop = False
        Me.GB_Constring.Text = "Connection Settings"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(83, 157)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(106, 33)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(259, 157)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(106, 33)
        Me.btnSave.TabIndex = 5
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'txtDatabase
        '
        Me.txtDatabase.Location = New System.Drawing.Point(82, 66)
        Me.txtDatabase.MaxLength = 500
        Me.txtDatabase.Name = "txtDatabase"
        Me.txtDatabase.Size = New System.Drawing.Size(284, 21)
        Me.txtDatabase.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(20, 69)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 15)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Database"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(83, 93)
        Me.txtUser.MaxLength = 500
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(284, 21)
        Me.txtUser.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(33, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "User"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(83, 123)
        Me.txtPassword.MaxLength = 500
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(284, 21)
        Me.txtPassword.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Password"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(82, 39)
        Me.txtServer.MaxLength = 500
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(284, 21)
        Me.txtServer.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 42)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Server"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(259, 196)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(106, 33)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Exit"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmDatabase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 342)
        Me.Controls.Add(Me.GB_Constring)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmDatabase"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmDatabase"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GB_Constring.ResumeLayout(False)
        Me.GB_Constring.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GB_Constring As GroupBox
    Friend WithEvents txtDatabase As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtServer As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClose As Button
End Class
