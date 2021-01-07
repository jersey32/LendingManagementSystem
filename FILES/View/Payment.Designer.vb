<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Payment))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_minimize = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_exit = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton7 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton4 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton8 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton9 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton3 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton5 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton6 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_loadledger = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_addborrow = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Datagrid_loandate = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtbox_borrowerID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TileButton11 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_save = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_compute = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Panel1.SuspendLayout()
        CType(Me.Datagrid_loandate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_minimize)
        Me.Panel1.Controls.Add(Me.btn_exit)
        Me.Panel1.Controls.Add(Me.Guna2TileButton7)
        Me.Panel1.Controls.Add(Me.Guna2TileButton4)
        Me.Panel1.Controls.Add(Me.Guna2TileButton8)
        Me.Panel1.Controls.Add(Me.Guna2TileButton9)
        Me.Panel1.Controls.Add(Me.Guna2TileButton3)
        Me.Panel1.Controls.Add(Me.Guna2TileButton5)
        Me.Panel1.Controls.Add(Me.Guna2TileButton6)
        Me.Panel1.Controls.Add(Me.btn_loadledger)
        Me.Panel1.Controls.Add(Me.btn_addborrow)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1189, 100)
        Me.Panel1.TabIndex = 5
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
        Me.btn_minimize.Location = New System.Drawing.Point(1114, 1)
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
        Me.btn_exit.Location = New System.Drawing.Point(1153, 0)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.ShadowDecoration.Parent = Me.btn_exit
        Me.btn_exit.Size = New System.Drawing.Size(33, 34)
        Me.btn_exit.TabIndex = 42
        '
        'Guna2TileButton7
        '
        Me.Guna2TileButton7.BorderRadius = 5
        Me.Guna2TileButton7.BorderThickness = 1
        Me.Guna2TileButton7.CheckedState.Parent = Me.Guna2TileButton7
        Me.Guna2TileButton7.CustomImages.Parent = Me.Guna2TileButton7
        Me.Guna2TileButton7.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2TileButton7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TileButton7.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton7.HoverState.Parent = Me.Guna2TileButton7
        Me.Guna2TileButton7.Image = Global.LendingManagementSystem.My.Resources.Resources._008_backup
        Me.Guna2TileButton7.ImageOffset = New System.Drawing.Point(5, 10)
        Me.Guna2TileButton7.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2TileButton7.Location = New System.Drawing.Point(907, 0)
        Me.Guna2TileButton7.Name = "Guna2TileButton7"
        Me.Guna2TileButton7.ShadowDecoration.Parent = Me.Guna2TileButton7
        Me.Guna2TileButton7.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton7.TabIndex = 41
        Me.Guna2TileButton7.Text = "Backup"
        '
        'Guna2TileButton4
        '
        Me.Guna2TileButton4.BorderRadius = 5
        Me.Guna2TileButton4.BorderThickness = 1
        Me.Guna2TileButton4.CheckedState.Parent = Me.Guna2TileButton4
        Me.Guna2TileButton4.CustomImages.Parent = Me.Guna2TileButton4
        Me.Guna2TileButton4.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2TileButton4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TileButton4.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton4.HoverState.Parent = Me.Guna2TileButton4
        Me.Guna2TileButton4.Image = Global.LendingManagementSystem.My.Resources.Resources._005_time
        Me.Guna2TileButton4.ImageOffset = New System.Drawing.Point(0, 10)
        Me.Guna2TileButton4.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2TileButton4.Location = New System.Drawing.Point(568, 1)
        Me.Guna2TileButton4.Name = "Guna2TileButton4"
        Me.Guna2TileButton4.ShadowDecoration.Parent = Me.Guna2TileButton4
        Me.Guna2TileButton4.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton4.TabIndex = 38
        Me.Guna2TileButton4.Text = "Process Date"
        '
        'Guna2TileButton8
        '
        Me.Guna2TileButton8.BorderRadius = 5
        Me.Guna2TileButton8.BorderThickness = 1
        Me.Guna2TileButton8.CheckedState.Parent = Me.Guna2TileButton8
        Me.Guna2TileButton8.CustomImages.Parent = Me.Guna2TileButton8
        Me.Guna2TileButton8.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2TileButton8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TileButton8.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton8.HoverState.Parent = Me.Guna2TileButton8
        Me.Guna2TileButton8.Image = Global.LendingManagementSystem.My.Resources.Resources._007_settings
        Me.Guna2TileButton8.ImageOffset = New System.Drawing.Point(3, 10)
        Me.Guna2TileButton8.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2TileButton8.Location = New System.Drawing.Point(794, 0)
        Me.Guna2TileButton8.Name = "Guna2TileButton8"
        Me.Guna2TileButton8.ShadowDecoration.Parent = Me.Guna2TileButton8
        Me.Guna2TileButton8.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton8.TabIndex = 40
        Me.Guna2TileButton8.Text = "Configuration"
        '
        'Guna2TileButton9
        '
        Me.Guna2TileButton9.BorderRadius = 5
        Me.Guna2TileButton9.BorderThickness = 1
        Me.Guna2TileButton9.CheckedState.Parent = Me.Guna2TileButton9
        Me.Guna2TileButton9.CustomImages.Parent = Me.Guna2TileButton9
        Me.Guna2TileButton9.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2TileButton9.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TileButton9.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton9.HoverState.Parent = Me.Guna2TileButton9
        Me.Guna2TileButton9.Image = Global.LendingManagementSystem.My.Resources.Resources._006_correct
        Me.Guna2TileButton9.ImageOffset = New System.Drawing.Point(0, 10)
        Me.Guna2TileButton9.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2TileButton9.Location = New System.Drawing.Point(681, 0)
        Me.Guna2TileButton9.Name = "Guna2TileButton9"
        Me.Guna2TileButton9.ShadowDecoration.Parent = Me.Guna2TileButton9
        Me.Guna2TileButton9.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton9.TabIndex = 39
        Me.Guna2TileButton9.Text = "Verify"
        '
        'Guna2TileButton3
        '
        Me.Guna2TileButton3.BorderRadius = 5
        Me.Guna2TileButton3.BorderThickness = 1
        Me.Guna2TileButton3.CheckedState.Parent = Me.Guna2TileButton3
        Me.Guna2TileButton3.CustomImages.Parent = Me.Guna2TileButton3
        Me.Guna2TileButton3.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2TileButton3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TileButton3.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton3.HoverState.Parent = Me.Guna2TileButton3
        Me.Guna2TileButton3.Image = Global.LendingManagementSystem.My.Resources.Resources._002_investment
        Me.Guna2TileButton3.ImageOffset = New System.Drawing.Point(0, 10)
        Me.Guna2TileButton3.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2TileButton3.Location = New System.Drawing.Point(343, 2)
        Me.Guna2TileButton3.Name = "Guna2TileButton3"
        Me.Guna2TileButton3.ShadowDecoration.Parent = Me.Guna2TileButton3
        Me.Guna2TileButton3.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton3.TabIndex = 35
        Me.Guna2TileButton3.Text = "Process Loan"
        '
        'Guna2TileButton5
        '
        Me.Guna2TileButton5.BorderRadius = 5
        Me.Guna2TileButton5.BorderThickness = 1
        Me.Guna2TileButton5.CheckedState.Parent = Me.Guna2TileButton5
        Me.Guna2TileButton5.CustomImages.Parent = Me.Guna2TileButton5
        Me.Guna2TileButton5.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2TileButton5.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TileButton5.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton5.HoverState.Parent = Me.Guna2TileButton5
        Me.Guna2TileButton5.Image = Global.LendingManagementSystem.My.Resources.Resources._004_report
        Me.Guna2TileButton5.ImageOffset = New System.Drawing.Point(0, 10)
        Me.Guna2TileButton5.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2TileButton5.Location = New System.Drawing.Point(455, 1)
        Me.Guna2TileButton5.Name = "Guna2TileButton5"
        Me.Guna2TileButton5.ShadowDecoration.Parent = Me.Guna2TileButton5
        Me.Guna2TileButton5.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton5.TabIndex = 37
        Me.Guna2TileButton5.Text = "Report"
        '
        'Guna2TileButton6
        '
        Me.Guna2TileButton6.BorderRadius = 5
        Me.Guna2TileButton6.BorderThickness = 1
        Me.Guna2TileButton6.CheckedState.Parent = Me.Guna2TileButton6
        Me.Guna2TileButton6.CustomImages.Parent = Me.Guna2TileButton6
        Me.Guna2TileButton6.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2TileButton6.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TileButton6.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton6.HoverState.Parent = Me.Guna2TileButton6
        Me.Guna2TileButton6.Image = Global.LendingManagementSystem.My.Resources.Resources._003_payment_method
        Me.Guna2TileButton6.ImageOffset = New System.Drawing.Point(0, 10)
        Me.Guna2TileButton6.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2TileButton6.Location = New System.Drawing.Point(231, 1)
        Me.Guna2TileButton6.Name = "Guna2TileButton6"
        Me.Guna2TileButton6.ShadowDecoration.Parent = Me.Guna2TileButton6
        Me.Guna2TileButton6.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton6.TabIndex = 36
        Me.Guna2TileButton6.Text = "Payment"
        '
        'btn_loadledger
        '
        Me.btn_loadledger.BorderRadius = 5
        Me.btn_loadledger.BorderThickness = 1
        Me.btn_loadledger.CheckedState.Parent = Me.btn_loadledger
        Me.btn_loadledger.CustomImages.Parent = Me.btn_loadledger
        Me.btn_loadledger.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btn_loadledger.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_loadledger.ForeColor = System.Drawing.Color.White
        Me.btn_loadledger.HoverState.Parent = Me.btn_loadledger
        Me.btn_loadledger.Image = CType(resources.GetObject("btn_loadledger.Image"), System.Drawing.Image)
        Me.btn_loadledger.ImageOffset = New System.Drawing.Point(0, 10)
        Me.btn_loadledger.ImageSize = New System.Drawing.Size(60, 60)
        Me.btn_loadledger.Location = New System.Drawing.Point(116, 1)
        Me.btn_loadledger.Name = "btn_loadledger"
        Me.btn_loadledger.ShadowDecoration.Parent = Me.btn_loadledger
        Me.btn_loadledger.Size = New System.Drawing.Size(109, 97)
        Me.btn_loadledger.TabIndex = 34
        Me.btn_loadledger.Text = "Tag for renewal"
        '
        'btn_addborrow
        '
        Me.btn_addborrow.BorderRadius = 5
        Me.btn_addborrow.BorderThickness = 1
        Me.btn_addborrow.CheckedState.Parent = Me.btn_addborrow
        Me.btn_addborrow.CustomImages.Parent = Me.btn_addborrow
        Me.btn_addborrow.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btn_addborrow.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_addborrow.ForeColor = System.Drawing.Color.White
        Me.btn_addborrow.HoverState.Parent = Me.btn_addborrow
        Me.btn_addborrow.Image = Global.LendingManagementSystem.My.Resources.Resources._001_sign_up
        Me.btn_addborrow.ImageOffset = New System.Drawing.Point(-5, 10)
        Me.btn_addborrow.ImageSize = New System.Drawing.Size(60, 60)
        Me.btn_addborrow.Location = New System.Drawing.Point(3, 1)
        Me.btn_addborrow.Name = "btn_addborrow"
        Me.btn_addborrow.ShadowDecoration.Parent = Me.btn_addborrow
        Me.btn_addborrow.Size = New System.Drawing.Size(109, 97)
        Me.btn_addborrow.TabIndex = 33
        Me.btn_addborrow.Text = "Add Borrower"
        '
        'Datagrid_loandate
        '
        Me.Datagrid_loandate.AllowUserToAddRows = False
        Me.Datagrid_loandate.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        Me.Datagrid_loandate.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.Datagrid_loandate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Datagrid_loandate.BackgroundColor = System.Drawing.Color.White
        Me.Datagrid_loandate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Datagrid_loandate.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Datagrid_loandate.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagrid_loandate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.Datagrid_loandate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datagrid_loandate.DefaultCellStyle = DataGridViewCellStyle9
        Me.Datagrid_loandate.Dock = System.Windows.Forms.DockStyle.Top
        Me.Datagrid_loandate.EnableHeadersVisualStyles = False
        Me.Datagrid_loandate.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_loandate.Location = New System.Drawing.Point(0, 100)
        Me.Datagrid_loandate.Name = "Datagrid_loandate"
        Me.Datagrid_loandate.ReadOnly = True
        Me.Datagrid_loandate.RowHeadersVisible = False
        Me.Datagrid_loandate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagrid_loandate.Size = New System.Drawing.Size(1189, 436)
        Me.Datagrid_loandate.TabIndex = 6
        Me.Datagrid_loandate.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Datagrid_loandate.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Datagrid_loandate.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Datagrid_loandate.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Datagrid_loandate.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Datagrid_loandate.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Datagrid_loandate.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Datagrid_loandate.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_loandate.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_loandate.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Datagrid_loandate.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Datagrid_loandate.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Datagrid_loandate.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Datagrid_loandate.ThemeStyle.HeaderStyle.Height = 23
        Me.Datagrid_loandate.ThemeStyle.ReadOnly = True
        Me.Datagrid_loandate.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Datagrid_loandate.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Datagrid_loandate.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Datagrid_loandate.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Datagrid_loandate.ThemeStyle.RowsStyle.Height = 22
        Me.Datagrid_loandate.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_loandate.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Controls.Add(Me.txtbox_borrowerID)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2TileButton11)
        Me.Guna2GroupBox2.Controls.Add(Me.btn_save)
        Me.Guna2GroupBox2.Controls.Add(Me.Label1)
        Me.Guna2GroupBox2.Controls.Add(Me.btn_compute)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2GroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(0, 542)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1189, 357)
        Me.Guna2GroupBox2.TabIndex = 29
        Me.Guna2GroupBox2.Text = "Transaction details"
        '
        'txtbox_borrowerID
        '
        Me.txtbox_borrowerID.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_borrowerID.DefaultText = ""
        Me.txtbox_borrowerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox_borrowerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox_borrowerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_borrowerID.DisabledState.Parent = Me.txtbox_borrowerID
        Me.txtbox_borrowerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_borrowerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_borrowerID.FocusedState.Parent = Me.txtbox_borrowerID
        Me.txtbox_borrowerID.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_borrowerID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_borrowerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_borrowerID.HoverState.Parent = Me.txtbox_borrowerID
        Me.txtbox_borrowerID.Location = New System.Drawing.Point(51, 134)
        Me.txtbox_borrowerID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbox_borrowerID.Name = "txtbox_borrowerID"
        Me.txtbox_borrowerID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox_borrowerID.PlaceholderText = ""
        Me.txtbox_borrowerID.SelectedText = ""
        Me.txtbox_borrowerID.ShadowDecoration.Parent = Me.txtbox_borrowerID
        Me.txtbox_borrowerID.Size = New System.Drawing.Size(248, 39)
        Me.txtbox_borrowerID.TabIndex = 44
        '
        'Guna2TileButton11
        '
        Me.Guna2TileButton11.BorderRadius = 5
        Me.Guna2TileButton11.BorderThickness = 1
        Me.Guna2TileButton11.CheckedState.Parent = Me.Guna2TileButton11
        Me.Guna2TileButton11.CustomImages.Parent = Me.Guna2TileButton11
        Me.Guna2TileButton11.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2TileButton11.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2TileButton11.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton11.HoverState.Parent = Me.Guna2TileButton11
        Me.Guna2TileButton11.Image = Global.LendingManagementSystem.My.Resources.Resources._002_eraser
        Me.Guna2TileButton11.ImageOffset = New System.Drawing.Point(5, 10)
        Me.Guna2TileButton11.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2TileButton11.Location = New System.Drawing.Point(1051, 248)
        Me.Guna2TileButton11.Name = "Guna2TileButton11"
        Me.Guna2TileButton11.ShadowDecoration.Parent = Me.Guna2TileButton11
        Me.Guna2TileButton11.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton11.TabIndex = 43
        Me.Guna2TileButton11.Text = "Clear"
        Me.Guna2TileButton11.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        '
        'btn_save
        '
        Me.btn_save.BorderRadius = 5
        Me.btn_save.BorderThickness = 1
        Me.btn_save.CheckedState.Parent = Me.btn_save
        Me.btn_save.CustomImages.Parent = Me.btn_save
        Me.btn_save.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btn_save.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.ForeColor = System.Drawing.Color.White
        Me.btn_save.HoverState.Parent = Me.btn_save
        Me.btn_save.Image = Global.LendingManagementSystem.My.Resources.Resources._001_diskette
        Me.btn_save.ImageOffset = New System.Drawing.Point(0, 8)
        Me.btn_save.ImageSize = New System.Drawing.Size(50, 50)
        Me.btn_save.Location = New System.Drawing.Point(936, 248)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.ShadowDecoration.Parent = Me.btn_save
        Me.btn_save.Size = New System.Drawing.Size(109, 97)
        Me.btn_save.TabIndex = 42
        Me.btn_save.Text = "Save"
        Me.btn_save.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(51, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 21)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Borrower ID"
        '
        'btn_compute
        '
        Me.btn_compute.BorderRadius = 5
        Me.btn_compute.BorderThickness = 1
        Me.btn_compute.CheckedState.Parent = Me.btn_compute
        Me.btn_compute.CustomImages.Parent = Me.btn_compute
        Me.btn_compute.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btn_compute.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_compute.ForeColor = System.Drawing.Color.White
        Me.btn_compute.HoverState.Parent = Me.btn_compute
        Me.btn_compute.Image = Global.LendingManagementSystem.My.Resources.Resources._001_calculator
        Me.btn_compute.ImageOffset = New System.Drawing.Point(0, 8)
        Me.btn_compute.ImageSize = New System.Drawing.Size(50, 50)
        Me.btn_compute.Location = New System.Drawing.Point(810, 248)
        Me.btn_compute.Name = "btn_compute"
        Me.btn_compute.ShadowDecoration.Parent = Me.btn_compute
        Me.btn_compute.Size = New System.Drawing.Size(109, 97)
        Me.btn_compute.TabIndex = 31
        Me.btn_compute.Text = "Compute"
        Me.btn_compute.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        '
        'Payment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 899)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Datagrid_loandate)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Payment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        Me.Panel1.ResumeLayout(False)
        CType(Me.Datagrid_loandate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_minimize As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_exit As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton7 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton4 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton8 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton9 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton3 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton5 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton6 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_loadledger As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_addborrow As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Datagrid_loandate As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtbox_borrowerID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2TileButton11 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_compute As Guna.UI2.WinForms.Guna2TileButton
End Class
