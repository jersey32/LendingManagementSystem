<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Backup
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_minimize = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_exit = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_restore = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_backup = New Guna.UI2.WinForms.Guna2TileButton()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btn_minimize)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(440, 100)
        Me.Panel1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label2.Location = New System.Drawing.Point(2, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(327, 47)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Backup and Restore"
        '
        'btn_minimize
        '
        Me.btn_minimize.CheckedState.Parent = Me.btn_minimize
        Me.btn_minimize.CustomImages.Parent = Me.btn_minimize
        Me.btn_minimize.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btn_minimize.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_minimize.ForeColor = System.Drawing.Color.White
        Me.btn_minimize.HoverState.Parent = Me.btn_minimize
        Me.btn_minimize.Image = Global.LendingManagementSystem.My.Resources.Resources._001_minimize
        Me.btn_minimize.ImageOffset = New System.Drawing.Point(1, 0)
        Me.btn_minimize.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_minimize.Location = New System.Drawing.Point(365, 3)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.ShadowDecoration.Parent = Me.btn_minimize
        Me.btn_minimize.Size = New System.Drawing.Size(33, 34)
        Me.btn_minimize.TabIndex = 43
        '
        'btn_exit
        '
        Me.btn_exit.CheckedState.Parent = Me.btn_exit
        Me.btn_exit.CustomImages.Parent = Me.btn_exit
        Me.btn_exit.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btn_exit.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_exit.ForeColor = System.Drawing.Color.White
        Me.btn_exit.HoverState.Parent = Me.btn_exit
        Me.btn_exit.Image = Global.LendingManagementSystem.My.Resources.Resources._001_cancel
        Me.btn_exit.ImageOffset = New System.Drawing.Point(1, 0)
        Me.btn_exit.ImageSize = New System.Drawing.Size(30, 30)
        Me.btn_exit.Location = New System.Drawing.Point(404, 3)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.ShadowDecoration.Parent = Me.btn_exit
        Me.btn_exit.Size = New System.Drawing.Size(33, 34)
        Me.btn_exit.TabIndex = 42
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 37)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Label1"
        '
        'btn_restore
        '
        Me.btn_restore.BorderRadius = 5
        Me.btn_restore.BorderThickness = 1
        Me.btn_restore.CheckedState.Parent = Me.btn_restore
        Me.btn_restore.CustomImages.Parent = Me.btn_restore
        Me.btn_restore.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btn_restore.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_restore.ForeColor = System.Drawing.Color.White
        Me.btn_restore.HoverState.Parent = Me.btn_restore
        Me.btn_restore.Image = Global.LendingManagementSystem.My.Resources.Resources._001_restore
        Me.btn_restore.ImageOffset = New System.Drawing.Point(0, 15)
        Me.btn_restore.ImageSize = New System.Drawing.Size(75, 75)
        Me.btn_restore.Location = New System.Drawing.Point(235, 231)
        Me.btn_restore.Name = "btn_restore"
        Me.btn_restore.ShadowDecoration.Parent = Me.btn_restore
        Me.btn_restore.Size = New System.Drawing.Size(138, 126)
        Me.btn_restore.TabIndex = 34
        Me.btn_restore.Text = "RESTORE"
        Me.btn_restore.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        '
        'btn_backup
        '
        Me.btn_backup.BorderRadius = 5
        Me.btn_backup.BorderThickness = 1
        Me.btn_backup.CheckedState.Parent = Me.btn_backup
        Me.btn_backup.CustomImages.Parent = Me.btn_backup
        Me.btn_backup.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btn_backup.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_backup.ForeColor = System.Drawing.Color.White
        Me.btn_backup.HoverState.Parent = Me.btn_backup
        Me.btn_backup.Image = Global.LendingManagementSystem.My.Resources.Resources._008_backup
        Me.btn_backup.ImageOffset = New System.Drawing.Point(10, 10)
        Me.btn_backup.ImageSize = New System.Drawing.Size(75, 75)
        Me.btn_backup.Location = New System.Drawing.Point(61, 231)
        Me.btn_backup.Name = "btn_backup"
        Me.btn_backup.ShadowDecoration.Parent = Me.btn_backup
        Me.btn_backup.Size = New System.Drawing.Size(138, 126)
        Me.btn_backup.TabIndex = 31
        Me.btn_backup.Text = "BACKUP"
        Me.btn_backup.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        '
        'Backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 521)
        Me.Controls.Add(Me.btn_restore)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_backup)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Backup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_minimize As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_exit As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_backup As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_restore As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
End Class
