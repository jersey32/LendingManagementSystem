<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoanLedger
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoanLedger))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2Panel1 = New Guna.UI2.WinForms.Guna2Panel()
        Me.Guna2TileButton1 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_minimize = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_exit = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton7 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton4 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton8 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton9 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton3 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton5 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_payment = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Guna2TileButton2 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Datagrid_loans = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.Guna2GroupBox2 = New Guna.UI2.WinForms.Guna2GroupBox()
        Me.txtbox_borrowerID = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2TileButton11 = New Guna.UI2.WinForms.Guna2TileButton()
        Me.btn_save = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combo_collectors = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.combo_interest = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.txtbox_monthstopay = New Guna.UI2.WinForms.Guna2TextBox()
        Me.btn_compute = New Guna.UI2.WinForms.Guna2TileButton()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtbox_daily = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtbox_total = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Due_date = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Date_released = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Date_applied = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.txtbox_amount = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.combo_loan = New Guna.UI2.WinForms.Guna2ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Guna2Panel1.SuspendLayout()
        CType(Me.Datagrid_loans, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Guna2GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Panel1
        '
        Me.Guna2Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2Panel1.BorderRadius = 5
        Me.Guna2Panel1.Controls.Add(Me.Guna2TileButton1)
        Me.Guna2Panel1.Controls.Add(Me.btn_minimize)
        Me.Guna2Panel1.Controls.Add(Me.btn_exit)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TileButton7)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TileButton4)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TileButton8)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TileButton9)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TileButton3)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TileButton5)
        Me.Guna2Panel1.Controls.Add(Me.btn_payment)
        Me.Guna2Panel1.Controls.Add(Me.Guna2TileButton2)
        Me.Guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Guna2Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2Panel1.Name = "Guna2Panel1"
        Me.Guna2Panel1.ShadowDecoration.Parent = Me.Guna2Panel1
        Me.Guna2Panel1.Size = New System.Drawing.Size(1189, 100)
        Me.Guna2Panel1.TabIndex = 2
        '
        'Guna2TileButton1
        '
        Me.Guna2TileButton1.BorderRadius = 5
        Me.Guna2TileButton1.BorderThickness = 1
        Me.Guna2TileButton1.CheckedState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.CustomImages.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2TileButton1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TileButton1.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton1.HoverState.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.Image = Global.LendingManagementSystem.My.Resources.Resources._001_sign_up
        Me.Guna2TileButton1.ImageOffset = New System.Drawing.Point(-5, 10)
        Me.Guna2TileButton1.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2TileButton1.Location = New System.Drawing.Point(3, 1)
        Me.Guna2TileButton1.Name = "Guna2TileButton1"
        Me.Guna2TileButton1.ShadowDecoration.Parent = Me.Guna2TileButton1
        Me.Guna2TileButton1.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton1.TabIndex = 35
        Me.Guna2TileButton1.Text = "Add borrower"
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
        Me.btn_minimize.Location = New System.Drawing.Point(1114, 0)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.ShadowDecoration.Parent = Me.btn_minimize
        Me.btn_minimize.Size = New System.Drawing.Size(33, 34)
        Me.btn_minimize.TabIndex = 34
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
        Me.btn_exit.TabIndex = 33
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
        Me.Guna2TileButton7.Location = New System.Drawing.Point(907, 1)
        Me.Guna2TileButton7.Name = "Guna2TileButton7"
        Me.Guna2TileButton7.ShadowDecoration.Parent = Me.Guna2TileButton7
        Me.Guna2TileButton7.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton7.TabIndex = 32
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
        Me.Guna2TileButton4.Location = New System.Drawing.Point(568, 2)
        Me.Guna2TileButton4.Name = "Guna2TileButton4"
        Me.Guna2TileButton4.ShadowDecoration.Parent = Me.Guna2TileButton4
        Me.Guna2TileButton4.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton4.TabIndex = 29
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
        Me.Guna2TileButton8.Location = New System.Drawing.Point(794, 1)
        Me.Guna2TileButton8.Name = "Guna2TileButton8"
        Me.Guna2TileButton8.ShadowDecoration.Parent = Me.Guna2TileButton8
        Me.Guna2TileButton8.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton8.TabIndex = 31
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
        Me.Guna2TileButton9.Location = New System.Drawing.Point(681, 1)
        Me.Guna2TileButton9.Name = "Guna2TileButton9"
        Me.Guna2TileButton9.ShadowDecoration.Parent = Me.Guna2TileButton9
        Me.Guna2TileButton9.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton9.TabIndex = 30
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
        Me.Guna2TileButton3.Location = New System.Drawing.Point(343, 1)
        Me.Guna2TileButton3.Name = "Guna2TileButton3"
        Me.Guna2TileButton3.ShadowDecoration.Parent = Me.Guna2TileButton3
        Me.Guna2TileButton3.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton3.TabIndex = 26
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
        Me.Guna2TileButton5.Location = New System.Drawing.Point(455, 2)
        Me.Guna2TileButton5.Name = "Guna2TileButton5"
        Me.Guna2TileButton5.ShadowDecoration.Parent = Me.Guna2TileButton5
        Me.Guna2TileButton5.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton5.TabIndex = 28
        Me.Guna2TileButton5.Text = "Report"
        '
        'btn_payment
        '
        Me.btn_payment.BorderRadius = 5
        Me.btn_payment.BorderThickness = 1
        Me.btn_payment.CheckedState.Parent = Me.btn_payment
        Me.btn_payment.CustomImages.Parent = Me.btn_payment
        Me.btn_payment.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.btn_payment.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.btn_payment.ForeColor = System.Drawing.Color.White
        Me.btn_payment.HoverState.Parent = Me.btn_payment
        Me.btn_payment.Image = Global.LendingManagementSystem.My.Resources.Resources._003_payment_method
        Me.btn_payment.ImageOffset = New System.Drawing.Point(0, 10)
        Me.btn_payment.ImageSize = New System.Drawing.Size(60, 60)
        Me.btn_payment.Location = New System.Drawing.Point(230, 1)
        Me.btn_payment.Name = "btn_payment"
        Me.btn_payment.ShadowDecoration.Parent = Me.btn_payment
        Me.btn_payment.Size = New System.Drawing.Size(109, 97)
        Me.btn_payment.TabIndex = 27
        Me.btn_payment.Text = "Payment"
        '
        'Guna2TileButton2
        '
        Me.Guna2TileButton2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Guna2TileButton2.BorderRadius = 5
        Me.Guna2TileButton2.BorderThickness = 1
        Me.Guna2TileButton2.CheckedState.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.CustomImages.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.FillColor = System.Drawing.Color.MediumSeaGreen
        Me.Guna2TileButton2.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2TileButton2.ForeColor = System.Drawing.Color.White
        Me.Guna2TileButton2.HoverState.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.Image = CType(resources.GetObject("Guna2TileButton2.Image"), System.Drawing.Image)
        Me.Guna2TileButton2.ImageOffset = New System.Drawing.Point(0, 10)
        Me.Guna2TileButton2.ImageSize = New System.Drawing.Size(60, 60)
        Me.Guna2TileButton2.Location = New System.Drawing.Point(116, 1)
        Me.Guna2TileButton2.Name = "Guna2TileButton2"
        Me.Guna2TileButton2.ShadowDecoration.Parent = Me.Guna2TileButton2
        Me.Guna2TileButton2.Size = New System.Drawing.Size(109, 97)
        Me.Guna2TileButton2.TabIndex = 1
        Me.Guna2TileButton2.Text = "Loan Ledger"
        '
        'Datagrid_loans
        '
        Me.Datagrid_loans.AllowUserToAddRows = False
        Me.Datagrid_loans.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.Datagrid_loans.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Datagrid_loans.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Datagrid_loans.BackgroundColor = System.Drawing.Color.White
        Me.Datagrid_loans.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Datagrid_loans.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Datagrid_loans.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Datagrid_loans.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Datagrid_loans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Datagrid_loans.DefaultCellStyle = DataGridViewCellStyle3
        Me.Datagrid_loans.Dock = System.Windows.Forms.DockStyle.Top
        Me.Datagrid_loans.EnableHeadersVisualStyles = False
        Me.Datagrid_loans.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_loans.Location = New System.Drawing.Point(0, 100)
        Me.Datagrid_loans.Name = "Datagrid_loans"
        Me.Datagrid_loans.ReadOnly = True
        Me.Datagrid_loans.RowHeadersVisible = False
        Me.Datagrid_loans.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Datagrid_loans.Size = New System.Drawing.Size(1189, 363)
        Me.Datagrid_loans.TabIndex = 3
        Me.Datagrid_loans.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.[Default]
        Me.Datagrid_loans.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.Datagrid_loans.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.Datagrid_loans.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.Datagrid_loans.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.Datagrid_loans.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.Datagrid_loans.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.Datagrid_loans.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_loans.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_loans.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.Datagrid_loans.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Datagrid_loans.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.Datagrid_loans.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.Datagrid_loans.ThemeStyle.HeaderStyle.Height = 23
        Me.Datagrid_loans.ThemeStyle.ReadOnly = True
        Me.Datagrid_loans.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.Datagrid_loans.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.Datagrid_loans.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.Datagrid_loans.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.Datagrid_loans.ThemeStyle.RowsStyle.Height = 22
        Me.Datagrid_loans.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Datagrid_loans.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'Guna2GroupBox2
        '
        Me.Guna2GroupBox2.BackColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Controls.Add(Me.txtbox_borrowerID)
        Me.Guna2GroupBox2.Controls.Add(Me.Guna2TileButton11)
        Me.Guna2GroupBox2.Controls.Add(Me.btn_save)
        Me.Guna2GroupBox2.Controls.Add(Me.Label1)
        Me.Guna2GroupBox2.Controls.Add(Me.combo_collectors)
        Me.Guna2GroupBox2.Controls.Add(Me.Label16)
        Me.Guna2GroupBox2.Controls.Add(Me.combo_interest)
        Me.Guna2GroupBox2.Controls.Add(Me.txtbox_monthstopay)
        Me.Guna2GroupBox2.Controls.Add(Me.btn_compute)
        Me.Guna2GroupBox2.Controls.Add(Me.Label15)
        Me.Guna2GroupBox2.Controls.Add(Me.txtbox_daily)
        Me.Guna2GroupBox2.Controls.Add(Me.Label14)
        Me.Guna2GroupBox2.Controls.Add(Me.txtbox_total)
        Me.Guna2GroupBox2.Controls.Add(Me.Label13)
        Me.Guna2GroupBox2.Controls.Add(Me.Label12)
        Me.Guna2GroupBox2.Controls.Add(Me.Due_date)
        Me.Guna2GroupBox2.Controls.Add(Me.Label11)
        Me.Guna2GroupBox2.Controls.Add(Me.Date_released)
        Me.Guna2GroupBox2.Controls.Add(Me.Label10)
        Me.Guna2GroupBox2.Controls.Add(Me.Date_applied)
        Me.Guna2GroupBox2.Controls.Add(Me.txtbox_amount)
        Me.Guna2GroupBox2.Controls.Add(Me.Label9)
        Me.Guna2GroupBox2.Controls.Add(Me.Label8)
        Me.Guna2GroupBox2.Controls.Add(Me.combo_loan)
        Me.Guna2GroupBox2.Controls.Add(Me.Label7)
        Me.Guna2GroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Guna2GroupBox2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2GroupBox2.ForeColor = System.Drawing.Color.White
        Me.Guna2GroupBox2.Location = New System.Drawing.Point(3, 469)
        Me.Guna2GroupBox2.Name = "Guna2GroupBox2"
        Me.Guna2GroupBox2.ShadowDecoration.Parent = Me.Guna2GroupBox2
        Me.Guna2GroupBox2.Size = New System.Drawing.Size(1183, 425)
        Me.Guna2GroupBox2.TabIndex = 28
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
        Me.txtbox_borrowerID.Location = New System.Drawing.Point(32, 82)
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
        Me.Guna2TileButton11.Location = New System.Drawing.Point(1065, 302)
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
        Me.btn_save.Location = New System.Drawing.Point(941, 302)
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
        Me.Label1.Location = New System.Drawing.Point(32, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 21)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Borrower ID"
        '
        'combo_collectors
        '
        Me.combo_collectors.BackColor = System.Drawing.Color.Transparent
        Me.combo_collectors.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combo_collectors.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_collectors.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_collectors.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_collectors.FocusedState.Parent = Me.combo_collectors
        Me.combo_collectors.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.combo_collectors.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.combo_collectors.HoverState.Parent = Me.combo_collectors
        Me.combo_collectors.ItemHeight = 30
        Me.combo_collectors.ItemsAppearance.Parent = Me.combo_collectors
        Me.combo_collectors.Location = New System.Drawing.Point(308, 149)
        Me.combo_collectors.Name = "combo_collectors"
        Me.combo_collectors.ShadowDecoration.Parent = Me.combo_collectors
        Me.combo_collectors.Size = New System.Drawing.Size(253, 36)
        Me.combo_collectors.TabIndex = 39
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.White
        Me.Label16.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(307, 125)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 21)
        Me.Label16.TabIndex = 38
        Me.Label16.Text = "Collectors"
        '
        'combo_interest
        '
        Me.combo_interest.BackColor = System.Drawing.Color.Transparent
        Me.combo_interest.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combo_interest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_interest.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_interest.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_interest.FocusedState.Parent = Me.combo_interest
        Me.combo_interest.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.combo_interest.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.combo_interest.HoverState.Parent = Me.combo_interest
        Me.combo_interest.ItemHeight = 30
        Me.combo_interest.ItemsAppearance.Parent = Me.combo_interest
        Me.combo_interest.Location = New System.Drawing.Point(32, 348)
        Me.combo_interest.Name = "combo_interest"
        Me.combo_interest.ShadowDecoration.Parent = Me.combo_interest
        Me.combo_interest.Size = New System.Drawing.Size(248, 36)
        Me.combo_interest.TabIndex = 37
        '
        'txtbox_monthstopay
        '
        Me.txtbox_monthstopay.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_monthstopay.DefaultText = ""
        Me.txtbox_monthstopay.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox_monthstopay.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox_monthstopay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_monthstopay.DisabledState.Parent = Me.txtbox_monthstopay
        Me.txtbox_monthstopay.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_monthstopay.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_monthstopay.FocusedState.Parent = Me.txtbox_monthstopay
        Me.txtbox_monthstopay.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_monthstopay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_monthstopay.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_monthstopay.HoverState.Parent = Me.txtbox_monthstopay
        Me.txtbox_monthstopay.Location = New System.Drawing.Point(32, 213)
        Me.txtbox_monthstopay.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbox_monthstopay.Name = "txtbox_monthstopay"
        Me.txtbox_monthstopay.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox_monthstopay.PlaceholderText = ""
        Me.txtbox_monthstopay.SelectedText = ""
        Me.txtbox_monthstopay.ShadowDecoration.Parent = Me.txtbox_monthstopay
        Me.txtbox_monthstopay.Size = New System.Drawing.Size(248, 39)
        Me.txtbox_monthstopay.TabIndex = 36
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
        Me.btn_compute.Location = New System.Drawing.Point(729, 302)
        Me.btn_compute.Name = "btn_compute"
        Me.btn_compute.ShadowDecoration.Parent = Me.btn_compute
        Me.btn_compute.Size = New System.Drawing.Size(109, 97)
        Me.btn_compute.TabIndex = 31
        Me.btn_compute.Text = "Compute"
        Me.btn_compute.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.White
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(31, 324)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(124, 21)
        Me.Label15.TabIndex = 35
        Me.Label15.Text = "Interest Rate (%)"
        '
        'txtbox_daily
        '
        Me.txtbox_daily.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_daily.DefaultText = ""
        Me.txtbox_daily.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox_daily.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox_daily.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_daily.DisabledState.Parent = Me.txtbox_daily
        Me.txtbox_daily.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_daily.Enabled = False
        Me.txtbox_daily.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_daily.FocusedState.Parent = Me.txtbox_daily
        Me.txtbox_daily.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_daily.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_daily.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_daily.HoverState.Parent = Me.txtbox_daily
        Me.txtbox_daily.Location = New System.Drawing.Point(585, 213)
        Me.txtbox_daily.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbox_daily.Name = "txtbox_daily"
        Me.txtbox_daily.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox_daily.PlaceholderText = ""
        Me.txtbox_daily.ReadOnly = True
        Me.txtbox_daily.SelectedText = ""
        Me.txtbox_daily.ShadowDecoration.Parent = Me.txtbox_daily
        Me.txtbox_daily.Size = New System.Drawing.Size(253, 39)
        Me.txtbox_daily.TabIndex = 33
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.White
        Me.Label14.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(587, 190)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(128, 21)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "Daily Collectibles"
        '
        'txtbox_total
        '
        Me.txtbox_total.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_total.DefaultText = ""
        Me.txtbox_total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox_total.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox_total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_total.DisabledState.Parent = Me.txtbox_total
        Me.txtbox_total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_total.Enabled = False
        Me.txtbox_total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_total.FocusedState.Parent = Me.txtbox_total
        Me.txtbox_total.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_total.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_total.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_total.HoverState.Parent = Me.txtbox_total
        Me.txtbox_total.Location = New System.Drawing.Point(585, 149)
        Me.txtbox_total.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbox_total.Name = "txtbox_total"
        Me.txtbox_total.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox_total.PlaceholderText = ""
        Me.txtbox_total.ReadOnly = True
        Me.txtbox_total.SelectedText = ""
        Me.txtbox_total.ShadowDecoration.Parent = Me.txtbox_total
        Me.txtbox_total.Size = New System.Drawing.Size(253, 36)
        Me.txtbox_total.TabIndex = 31
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(586, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(123, 21)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Total recievables"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.White
        Me.Label12.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(307, 324)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 21)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "Due Date"
        '
        'Due_date
        '
        Me.Due_date.CheckedState.Parent = Me.Due_date
        Me.Due_date.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Due_date.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Due_date.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Due_date.HoverState.Parent = Me.Due_date
        Me.Due_date.Location = New System.Drawing.Point(308, 348)
        Me.Due_date.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Due_date.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Due_date.Name = "Due_date"
        Me.Due_date.ShadowDecoration.Parent = Me.Due_date
        Me.Due_date.Size = New System.Drawing.Size(253, 36)
        Me.Due_date.TabIndex = 28
        Me.Due_date.Value = New Date(2020, 11, 17, 19, 52, 52, 85)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.White
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(309, 256)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(104, 21)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Date released"
        '
        'Date_released
        '
        Me.Date_released.CheckedState.Parent = Me.Date_released
        Me.Date_released.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Date_released.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Date_released.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Date_released.HoverState.Parent = Me.Date_released
        Me.Date_released.Location = New System.Drawing.Point(308, 282)
        Me.Date_released.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Date_released.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Date_released.Name = "Date_released"
        Me.Date_released.ShadowDecoration.Parent = Me.Date_released
        Me.Date_released.Size = New System.Drawing.Size(253, 39)
        Me.Date_released.TabIndex = 24
        Me.Date_released.Value = New Date(2020, 11, 17, 19, 52, 52, 85)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.White
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(307, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 21)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Date applied"
        '
        'Date_applied
        '
        Me.Date_applied.CheckedState.Parent = Me.Date_applied
        Me.Date_applied.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(148, Byte), Integer))
        Me.Date_applied.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Date_applied.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.Date_applied.HoverState.Parent = Me.Date_applied
        Me.Date_applied.Location = New System.Drawing.Point(308, 213)
        Me.Date_applied.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.Date_applied.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.Date_applied.Name = "Date_applied"
        Me.Date_applied.ShadowDecoration.Parent = Me.Date_applied
        Me.Date_applied.Size = New System.Drawing.Size(253, 40)
        Me.Date_applied.TabIndex = 22
        Me.Date_applied.Value = New Date(2020, 11, 17, 19, 52, 52, 85)
        '
        'txtbox_amount
        '
        Me.txtbox_amount.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbox_amount.DefaultText = ""
        Me.txtbox_amount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.txtbox_amount.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.txtbox_amount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_amount.DisabledState.Parent = Me.txtbox_amount
        Me.txtbox_amount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.txtbox_amount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_amount.FocusedState.Parent = Me.txtbox_amount
        Me.txtbox_amount.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbox_amount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtbox_amount.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_amount.HoverState.Parent = Me.txtbox_amount
        Me.txtbox_amount.Location = New System.Drawing.Point(32, 281)
        Me.txtbox_amount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtbox_amount.Name = "txtbox_amount"
        Me.txtbox_amount.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbox_amount.PlaceholderText = ""
        Me.txtbox_amount.SelectedText = ""
        Me.txtbox_amount.ShadowDecoration.Parent = Me.txtbox_amount
        Me.txtbox_amount.Size = New System.Drawing.Size(248, 39)
        Me.txtbox_amount.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.White
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(31, 256)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 21)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(31, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 21)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Months to pay"
        '
        'combo_loan
        '
        Me.combo_loan.BackColor = System.Drawing.Color.Transparent
        Me.combo_loan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.combo_loan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_loan.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_loan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combo_loan.FocusedState.Parent = Me.combo_loan
        Me.combo_loan.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.combo_loan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.combo_loan.HoverState.Parent = Me.combo_loan
        Me.combo_loan.ItemHeight = 30
        Me.combo_loan.Items.AddRange(New Object() {"Personal Loan", "Credit cards", "Cash Advance", "Small Business Loan"})
        Me.combo_loan.ItemsAppearance.Parent = Me.combo_loan
        Me.combo_loan.Location = New System.Drawing.Point(32, 149)
        Me.combo_loan.Name = "combo_loan"
        Me.combo_loan.ShadowDecoration.Parent = Me.combo_loan
        Me.combo_loan.Size = New System.Drawing.Size(248, 36)
        Me.combo_loan.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.White
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(28, 125)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 21)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Loan Type"
        '
        'LoanLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1189, 899)
        Me.Controls.Add(Me.Guna2GroupBox2)
        Me.Controls.Add(Me.Datagrid_loans)
        Me.Controls.Add(Me.Guna2Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LoanLedger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoanLedger"
        Me.Guna2Panel1.ResumeLayout(False)
        CType(Me.Datagrid_loans, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Guna2GroupBox2.ResumeLayout(False)
        Me.Guna2GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Panel1 As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents btn_minimize As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_exit As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton7 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton4 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton8 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton9 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton3 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton5 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_payment As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton2 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Guna2TileButton1 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Datagrid_loans As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2GroupBox2 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents combo_collectors As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label16 As Label
    Friend WithEvents combo_interest As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents txtbox_monthstopay As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents btn_compute As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents Label15 As Label
    Friend WithEvents txtbox_daily As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txtbox_total As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Due_date As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Date_released As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Label10 As Label
    Friend WithEvents Date_applied As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents txtbox_amount As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents combo_loan As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2TileButton11 As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents btn_save As Guna.UI2.WinForms.Guna2TileButton
    Friend WithEvents txtbox_borrowerID As Guna.UI2.WinForms.Guna2TextBox
End Class
