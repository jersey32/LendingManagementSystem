<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login_Page
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
        Me.Guna2TileButton2 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton1 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.GunaJersey = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.GunaBaron = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.GunaAnimateWindow1 = New Guna.UI.WinForms.GunaAnimateWindow(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtbox_username = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_login = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel_login1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtbox_password = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Panel2.SuspendLayout()
        Me.Panel_login1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2TileButton2
        '
        Me.Guna2TileButton2.CheckedState.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.CustomImages.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TileButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton2.HoverState.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.Image = Global.LendingManagementSystem.My.Resources.Resources._001_cancel
        Me.Guna2TileButton2.ImageOffset = New System.Drawing.Point(1, 0)
        Me.Guna2TileButton2.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2TileButton2.Location = New System.Drawing.Point(434, 3)
        Me.Guna2TileButton2.Name = "Guna2TileButton2"
        Me.Guna2TileButton2.ShadowDecoration.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.Size = New System.Drawing.Size(33, 34)
        Me.Guna2TileButton2.TabIndex = 41
        '
        'Guna2TileButton1
        '
        Me.Guna2TileButton1.CheckedState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.CustomImages.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2TileButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TileButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton1.HoverState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.Image = Global.LendingManagementSystem.My.Resources.Resources._001_minimize
        Me.Guna2TileButton1.ImageOffset = New System.Drawing.Point(1, 0)
        Me.Guna2TileButton1.ImageSize = New System.Drawing.Size(30, 30)
        Me.Guna2TileButton1.Location = New System.Drawing.Point(395, 3)
        Me.Guna2TileButton1.Name = "Guna2TileButton1"
        Me.Guna2TileButton1.ShadowDecoration.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.Size = New System.Drawing.Size(33, 34)
        Me.Guna2TileButton1.TabIndex = 42
        '
        'GunaJersey
        '
        Me.GunaJersey.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_POSITIVE
        Me.GunaJersey.Interval = 700
        Me.GunaJersey.TargetControl = Me.Label3
        '
        'GunaBaron
        '
        Me.GunaBaron.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_NEGATIVE
        Me.GunaBaron.Interval = 700
        Me.GunaBaron.TargetControl = Me.Label4
        '
        'GunaAnimateWindow1
        '
        Me.GunaAnimateWindow1.AnimationType = Guna.UI.WinForms.GunaAnimateWindow.AnimateWindowType.AW_HOR_POSITIVE
        Me.GunaAnimateWindow1.Interval = 700
        Me.GunaAnimateWindow1.TargetControl = Me.Panel2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtbox_password)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Guna2TileButton2)
        Me.Panel2.Controls.Add(Me.Guna2TileButton1)
        Me.Panel2.Controls.Add(Me.txtbox_username)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btn_login)
        Me.Panel2.Location = New System.Drawing.Point(437, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(476, 522)
        Me.Panel2.TabIndex = 48
        Me.Panel2.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(121, 339)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(228, 30)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Forgot your password ?"
        Me.Label5.Visible = False
        '
        'txtbox_username
        '
        Me.txtbox_username.Animated = True
        Me.txtbox_username.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_username.DefaultText = ""
        Me.txtbox_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_username.DisabledState.Parent = Me.txtbox_username
        Me.txtbox_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_username.FocusedState.Parent = Me.txtbox_username
        Me.txtbox_username.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtbox_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_username.HoverState.Parent = Me.txtbox_username
        Me.txtbox_username.Location = New System.Drawing.Point(71, 221)
        Me.txtbox_username.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbox_username.Name = "txtbox_username"
        Me.txtbox_username.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox_username.PlaceholderText = "Username"
        Me.txtbox_username.SelectedText = ""
        Me.txtbox_username.ShadowDecoration.Parent = Me.txtbox_username
        Me.txtbox_username.Size = New System.Drawing.Size(326, 39)
        Me.txtbox_username.TabIndex = 45
        Me.txtbox_username.TabStop = False
        Me.txtbox_username.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(173, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 47)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Login"
        Me.Label1.Visible = False
        '
        'btn_login
        '
        Me.btn_login.Animated = True
        Me.btn_login.BorderRadius = 20
        Me.btn_login.CheckedState.Parent = Me.btn_login
        Me.btn_login.CustomImages.Parent = Me.btn_login
        Me.btn_login.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.HoverState.Parent = Me.btn_login
        Me.btn_login.Location = New System.Drawing.Point(168, 391)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.ShadowDecoration.Parent = Me.btn_login
        Me.btn_login.Size = New System.Drawing.Size(138, 45)
        Me.btn_login.TabIndex = 44
        Me.btn_login.Text = "LOG IN"
        Me.btn_login.Visible = False
        '
        'Panel_login1
        '
        Me.Panel_login1.Controls.Add(Me.Label3)
        Me.Panel_login1.Controls.Add(Me.Label4)
        Me.Panel_login1.Controls.Add(Me.Label2)
        Me.Panel_login1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel_login1.FillColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(206, Byte), Integer), CType(CType(162, Byte), Integer))
        Me.Panel_login1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(157, Byte), Integer))
        Me.Panel_login1.Location = New System.Drawing.Point(0, 0)
        Me.Panel_login1.Name = "Panel_login1"
        Me.Panel_login1.ShadowDecoration.Parent = Me.Panel_login1
        Me.Panel_login1.Size = New System.Drawing.Size(437, 522)
        Me.Panel_login1.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(211, 242)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 25)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "JERSEY"
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(211, 267)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 25)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "BARON"
        Me.Label4.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(126, 221)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 86)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "JB"
        '
        'txtbox_password
        '
        Me.txtbox_password.Animated = True
        Me.txtbox_password.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_password.DefaultText = ""
        Me.txtbox_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_password.DisabledState.Parent = Me.txtbox_password
        Me.txtbox_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_password.FocusedState.Parent = Me.txtbox_password
        Me.txtbox_password.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.txtbox_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_password.HoverState.Parent = Me.txtbox_password
        Me.txtbox_password.Location = New System.Drawing.Point(71, 280)
        Me.txtbox_password.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbox_password.Name = "txtbox_password"
        Me.txtbox_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox_password.PlaceholderText = "Password"
        Me.txtbox_password.SelectedText = ""
        Me.txtbox_password.ShadowDecoration.Parent = Me.txtbox_password
        Me.txtbox_password.Size = New System.Drawing.Size(326, 39)
        Me.txtbox_password.TabIndex = 46
        Me.txtbox_password.TabStop = False
        Me.txtbox_password.UseSystemPasswordChar = True
        Me.txtbox_password.Visible = False
        '
        'Login_Page
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 522)
        Me.Controls.Add(Me.Panel_login1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login_Page"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel_login1.ResumeLayout(False)
        Me.Panel_login1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaJersey As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents GunaBaron As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents GunaAnimateWindow1 As Guna.UI.WinForms.GunaAnimateWindow
    Friend WithEvents Guna2TileButton2 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton1 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtbox_username As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_login As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel_login1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtbox_password As Guna.UI2.WinForms.Guna2TextBox
End Class
