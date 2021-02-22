<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAllUsersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAllEmployeeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BloodDonorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewDonorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateDetailsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAllDonorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchDonorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchByLocationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByDonateDateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BloodInventoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddMoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateBagDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StockDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HospitalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewHospitalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateHospitalDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowAllHospitalsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToHospitalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToRegisteredDonorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeSalaryTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HospitalTransactionReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateTxnSlipToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegisteredDonorTransactionREportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateTxnSlipsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeSalaryTransactonReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateTransactionSlipsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RefreshDashboardToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.XuiBanner1 = New XanderUI.XUIBanner()
        Me.XuiClock1 = New XanderUI.XUIClock()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightCoral
        Me.MenuStrip1.Font = New System.Drawing.Font("Open Sans Semibold", 10.0!)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.EmployeeToolStripMenuItem, Me.BloodDonorToolStripMenuItem, Me.BloodInventoryToolStripMenuItem, Me.HospitalToolStripMenuItem, Me.TToolStripMenuItem, Me.ReportsToolStripMenuItem, Me.RefreshDashboardToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1920, 81)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddUserToolStripMenuItem, Me.UpdateUserToolStripMenuItem, Me.ShowAllUsersToolStripMenuItem})
        Me.UserToolStripMenuItem.Image = CType(resources.GetObject("UserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(86, 77)
        Me.UserToolStripMenuItem.Text = "User"
        '
        'AddUserToolStripMenuItem
        '
        Me.AddUserToolStripMenuItem.Image = CType(resources.GetObject("AddUserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddUserToolStripMenuItem.Name = "AddUserToolStripMenuItem"
        Me.AddUserToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.AddUserToolStripMenuItem.Size = New System.Drawing.Size(368, 32)
        Me.AddUserToolStripMenuItem.Text = "Add New"
        '
        'UpdateUserToolStripMenuItem
        '
        Me.UpdateUserToolStripMenuItem.Image = CType(resources.GetObject("UpdateUserToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateUserToolStripMenuItem.Name = "UpdateUserToolStripMenuItem"
        Me.UpdateUserToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UpdateUserToolStripMenuItem.Size = New System.Drawing.Size(368, 32)
        Me.UpdateUserToolStripMenuItem.Text = "Update / Delete User "
        '
        'ShowAllUsersToolStripMenuItem
        '
        Me.ShowAllUsersToolStripMenuItem.Image = CType(resources.GetObject("ShowAllUsersToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowAllUsersToolStripMenuItem.Name = "ShowAllUsersToolStripMenuItem"
        Me.ShowAllUsersToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ShowAllUsersToolStripMenuItem.Size = New System.Drawing.Size(368, 32)
        Me.ShowAllUsersToolStripMenuItem.Text = "Show All Users"
        '
        'EmployeeToolStripMenuItem
        '
        Me.EmployeeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewToolStripMenuItem, Me.UpdateDetailsToolStripMenuItem, Me.ShowAllEmployeeToolStripMenuItem})
        Me.EmployeeToolStripMenuItem.Image = CType(resources.GetObject("EmployeeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmployeeToolStripMenuItem.Name = "EmployeeToolStripMenuItem"
        Me.EmployeeToolStripMenuItem.Size = New System.Drawing.Size(135, 77)
        Me.EmployeeToolStripMenuItem.Text = "Employee"
        '
        'AddNewToolStripMenuItem
        '
        Me.AddNewToolStripMenuItem.Image = CType(resources.GetObject("AddNewToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddNewToolStripMenuItem.Name = "AddNewToolStripMenuItem"
        Me.AddNewToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.AddNewToolStripMenuItem.Size = New System.Drawing.Size(447, 32)
        Me.AddNewToolStripMenuItem.Text = "Add New"
        '
        'UpdateDetailsToolStripMenuItem
        '
        Me.UpdateDetailsToolStripMenuItem.Image = CType(resources.GetObject("UpdateDetailsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateDetailsToolStripMenuItem.Name = "UpdateDetailsToolStripMenuItem"
        Me.UpdateDetailsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UpdateDetailsToolStripMenuItem.Size = New System.Drawing.Size(447, 32)
        Me.UpdateDetailsToolStripMenuItem.Text = "Update  / Delete Details"
        '
        'ShowAllEmployeeToolStripMenuItem
        '
        Me.ShowAllEmployeeToolStripMenuItem.Image = CType(resources.GetObject("ShowAllEmployeeToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowAllEmployeeToolStripMenuItem.Name = "ShowAllEmployeeToolStripMenuItem"
        Me.ShowAllEmployeeToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ShowAllEmployeeToolStripMenuItem.Size = New System.Drawing.Size(447, 32)
        Me.ShowAllEmployeeToolStripMenuItem.Text = "Show All Employee"
        '
        'BloodDonorToolStripMenuItem
        '
        Me.BloodDonorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewDonorToolStripMenuItem, Me.UpdateDetailsToolStripMenuItem1, Me.ShowAllDonorToolStripMenuItem, Me.SearchDonorToolStripMenuItem})
        Me.BloodDonorToolStripMenuItem.Image = CType(resources.GetObject("BloodDonorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BloodDonorToolStripMenuItem.Name = "BloodDonorToolStripMenuItem"
        Me.BloodDonorToolStripMenuItem.Size = New System.Drawing.Size(161, 77)
        Me.BloodDonorToolStripMenuItem.Text = "Blood Donor"
        '
        'AddNewDonorToolStripMenuItem
        '
        Me.AddNewDonorToolStripMenuItem.Image = CType(resources.GetObject("AddNewDonorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddNewDonorToolStripMenuItem.Name = "AddNewDonorToolStripMenuItem"
        Me.AddNewDonorToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.AddNewDonorToolStripMenuItem.Size = New System.Drawing.Size(416, 32)
        Me.AddNewDonorToolStripMenuItem.Text = "Add New"
        '
        'UpdateDetailsToolStripMenuItem1
        '
        Me.UpdateDetailsToolStripMenuItem1.Image = CType(resources.GetObject("UpdateDetailsToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.UpdateDetailsToolStripMenuItem1.Name = "UpdateDetailsToolStripMenuItem1"
        Me.UpdateDetailsToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UpdateDetailsToolStripMenuItem1.Size = New System.Drawing.Size(416, 32)
        Me.UpdateDetailsToolStripMenuItem1.Text = "Update / Delete Donor"
        '
        'ShowAllDonorToolStripMenuItem
        '
        Me.ShowAllDonorToolStripMenuItem.Image = CType(resources.GetObject("ShowAllDonorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowAllDonorToolStripMenuItem.Name = "ShowAllDonorToolStripMenuItem"
        Me.ShowAllDonorToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ShowAllDonorToolStripMenuItem.Size = New System.Drawing.Size(416, 32)
        Me.ShowAllDonorToolStripMenuItem.Text = "Show All Donors"
        '
        'SearchDonorToolStripMenuItem
        '
        Me.SearchDonorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchByLocationToolStripMenuItem1, Me.ByDonateDateToolStripMenuItem, Me.ByToolStripMenuItem})
        Me.SearchDonorToolStripMenuItem.Image = CType(resources.GetObject("SearchDonorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SearchDonorToolStripMenuItem.Name = "SearchDonorToolStripMenuItem"
        Me.SearchDonorToolStripMenuItem.Size = New System.Drawing.Size(416, 32)
        Me.SearchDonorToolStripMenuItem.Text = "Search Donor"
        '
        'SearchByLocationToolStripMenuItem1
        '
        Me.SearchByLocationToolStripMenuItem1.Image = CType(resources.GetObject("SearchByLocationToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.SearchByLocationToolStripMenuItem1.Name = "SearchByLocationToolStripMenuItem1"
        Me.SearchByLocationToolStripMenuItem1.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.SearchByLocationToolStripMenuItem1.Size = New System.Drawing.Size(349, 32)
        Me.SearchByLocationToolStripMenuItem1.Text = "By Location"
        '
        'ByDonateDateToolStripMenuItem
        '
        Me.ByDonateDateToolStripMenuItem.Image = CType(resources.GetObject("ByDonateDateToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ByDonateDateToolStripMenuItem.Name = "ByDonateDateToolStripMenuItem"
        Me.ByDonateDateToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.ByDonateDateToolStripMenuItem.Size = New System.Drawing.Size(349, 32)
        Me.ByDonateDateToolStripMenuItem.Text = "By Donate Date"
        '
        'ByToolStripMenuItem
        '
        Me.ByToolStripMenuItem.Image = CType(resources.GetObject("ByToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ByToolStripMenuItem.Name = "ByToolStripMenuItem"
        Me.ByToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Alt) _
            Or System.Windows.Forms.Keys.B), System.Windows.Forms.Keys)
        Me.ByToolStripMenuItem.Size = New System.Drawing.Size(349, 32)
        Me.ByToolStripMenuItem.Text = "By Blood Group"
        '
        'BloodInventoryToolStripMenuItem
        '
        Me.BloodInventoryToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddMoreToolStripMenuItem, Me.UpdateBagDetailsToolStripMenuItem, Me.StockDetailsToolStripMenuItem})
        Me.BloodInventoryToolStripMenuItem.Image = CType(resources.GetObject("BloodInventoryToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BloodInventoryToolStripMenuItem.Name = "BloodInventoryToolStripMenuItem"
        Me.BloodInventoryToolStripMenuItem.Size = New System.Drawing.Size(152, 77)
        Me.BloodInventoryToolStripMenuItem.Text = "Blood Stock"
        '
        'AddMoreToolStripMenuItem
        '
        Me.AddMoreToolStripMenuItem.Image = CType(resources.GetObject("AddMoreToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddMoreToolStripMenuItem.Name = "AddMoreToolStripMenuItem"
        Me.AddMoreToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.AddMoreToolStripMenuItem.Size = New System.Drawing.Size(432, 32)
        Me.AddMoreToolStripMenuItem.Text = "Add More Bags"
        '
        'UpdateBagDetailsToolStripMenuItem
        '
        Me.UpdateBagDetailsToolStripMenuItem.Image = CType(resources.GetObject("UpdateBagDetailsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateBagDetailsToolStripMenuItem.Name = "UpdateBagDetailsToolStripMenuItem"
        Me.UpdateBagDetailsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UpdateBagDetailsToolStripMenuItem.Size = New System.Drawing.Size(432, 32)
        Me.UpdateBagDetailsToolStripMenuItem.Text = "Update / Remove Bag Details"
        '
        'StockDetailsToolStripMenuItem
        '
        Me.StockDetailsToolStripMenuItem.Image = CType(resources.GetObject("StockDetailsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.StockDetailsToolStripMenuItem.Name = "StockDetailsToolStripMenuItem"
        Me.StockDetailsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.StockDetailsToolStripMenuItem.Size = New System.Drawing.Size(432, 32)
        Me.StockDetailsToolStripMenuItem.Text = "Stock Details"
        '
        'HospitalToolStripMenuItem
        '
        Me.HospitalToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddNewHospitalToolStripMenuItem, Me.UpdateHospitalDetailsToolStripMenuItem, Me.ShowAllHospitalsToolStripMenuItem})
        Me.HospitalToolStripMenuItem.Image = CType(resources.GetObject("HospitalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HospitalToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.PaleTurquoise
        Me.HospitalToolStripMenuItem.Name = "HospitalToolStripMenuItem"
        Me.HospitalToolStripMenuItem.Size = New System.Drawing.Size(121, 77)
        Me.HospitalToolStripMenuItem.Text = "Hospital"
        '
        'AddNewHospitalToolStripMenuItem
        '
        Me.AddNewHospitalToolStripMenuItem.Image = CType(resources.GetObject("AddNewHospitalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AddNewHospitalToolStripMenuItem.Name = "AddNewHospitalToolStripMenuItem"
        Me.AddNewHospitalToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.AddNewHospitalToolStripMenuItem.Size = New System.Drawing.Size(519, 32)
        Me.AddNewHospitalToolStripMenuItem.Text = "Add New Hospital"
        '
        'UpdateHospitalDetailsToolStripMenuItem
        '
        Me.UpdateHospitalDetailsToolStripMenuItem.Image = CType(resources.GetObject("UpdateHospitalDetailsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.UpdateHospitalDetailsToolStripMenuItem.Name = "UpdateHospitalDetailsToolStripMenuItem"
        Me.UpdateHospitalDetailsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.U), System.Windows.Forms.Keys)
        Me.UpdateHospitalDetailsToolStripMenuItem.Size = New System.Drawing.Size(519, 32)
        Me.UpdateHospitalDetailsToolStripMenuItem.Text = "Update / Delete Hospital Details"
        '
        'ShowAllHospitalsToolStripMenuItem
        '
        Me.ShowAllHospitalsToolStripMenuItem.Image = CType(resources.GetObject("ShowAllHospitalsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ShowAllHospitalsToolStripMenuItem.Name = "ShowAllHospitalsToolStripMenuItem"
        Me.ShowAllHospitalsToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.ShowAllHospitalsToolStripMenuItem.Size = New System.Drawing.Size(519, 32)
        Me.ShowAllHospitalsToolStripMenuItem.Text = "Show All Hospitals"
        '
        'TToolStripMenuItem
        '
        Me.TToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToHospitalToolStripMenuItem, Me.ToRegisteredDonorToolStripMenuItem, Me.EmployeeSalaryTransactionToolStripMenuItem})
        Me.TToolStripMenuItem.Image = CType(resources.GetObject("TToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TToolStripMenuItem.Name = "TToolStripMenuItem"
        Me.TToolStripMenuItem.Size = New System.Drawing.Size(156, 77)
        Me.TToolStripMenuItem.Text = "Transaction"
        '
        'ToHospitalToolStripMenuItem
        '
        Me.ToHospitalToolStripMenuItem.Image = CType(resources.GetObject("ToHospitalToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ToHospitalToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.ToHospitalToolStripMenuItem.Name = "ToHospitalToolStripMenuItem"
        Me.ToHospitalToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1
        Me.ToHospitalToolStripMenuItem.Size = New System.Drawing.Size(400, 32)
        Me.ToHospitalToolStripMenuItem.Text = "To Hospitals"
        '
        'ToRegisteredDonorToolStripMenuItem
        '
        Me.ToRegisteredDonorToolStripMenuItem.Image = CType(resources.GetObject("ToRegisteredDonorToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ToRegisteredDonorToolStripMenuItem.Name = "ToRegisteredDonorToolStripMenuItem"
        Me.ToRegisteredDonorToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2
        Me.ToRegisteredDonorToolStripMenuItem.Size = New System.Drawing.Size(400, 32)
        Me.ToRegisteredDonorToolStripMenuItem.Text = "To Registered Donors"
        '
        'EmployeeSalaryTransactionToolStripMenuItem
        '
        Me.EmployeeSalaryTransactionToolStripMenuItem.Image = CType(resources.GetObject("EmployeeSalaryTransactionToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmployeeSalaryTransactionToolStripMenuItem.Name = "EmployeeSalaryTransactionToolStripMenuItem"
        Me.EmployeeSalaryTransactionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3
        Me.EmployeeSalaryTransactionToolStripMenuItem.Size = New System.Drawing.Size(400, 32)
        Me.EmployeeSalaryTransactionToolStripMenuItem.Text = "Employee Salary Transaction"
        '
        'ReportsToolStripMenuItem
        '
        Me.ReportsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HospitalTransactionReportToolStripMenuItem, Me.RegisteredDonorTransactionREportToolStripMenuItem, Me.EmployeeSalaryTransactonReportToolStripMenuItem})
        Me.ReportsToolStripMenuItem.Font = New System.Drawing.Font("Open Sans Semibold", 10.0!)
        Me.ReportsToolStripMenuItem.Image = CType(resources.GetObject("ReportsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ReportsToolStripMenuItem.Name = "ReportsToolStripMenuItem"
        Me.ReportsToolStripMenuItem.Size = New System.Drawing.Size(116, 77)
        Me.ReportsToolStripMenuItem.Text = "Reports"
        '
        'HospitalTransactionReportToolStripMenuItem
        '
        Me.HospitalTransactionReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateTxnSlipToolStripMenuItem})
        Me.HospitalTransactionReportToolStripMenuItem.Image = CType(resources.GetObject("HospitalTransactionReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.HospitalTransactionReportToolStripMenuItem.Name = "HospitalTransactionReportToolStripMenuItem"
        Me.HospitalTransactionReportToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4
        Me.HospitalTransactionReportToolStripMenuItem.Size = New System.Drawing.Size(481, 32)
        Me.HospitalTransactionReportToolStripMenuItem.Text = "Hospital Transaction Report"
        '
        'GenerateTxnSlipToolStripMenuItem
        '
        Me.GenerateTxnSlipToolStripMenuItem.Image = CType(resources.GetObject("GenerateTxnSlipToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GenerateTxnSlipToolStripMenuItem.Name = "GenerateTxnSlipToolStripMenuItem"
        Me.GenerateTxnSlipToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.GenerateTxnSlipToolStripMenuItem.Size = New System.Drawing.Size(347, 32)
        Me.GenerateTxnSlipToolStripMenuItem.Text = "Generate Txns Slips"
        '
        'RegisteredDonorTransactionREportToolStripMenuItem
        '
        Me.RegisteredDonorTransactionREportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateTxnSlipsToolStripMenuItem})
        Me.RegisteredDonorTransactionREportToolStripMenuItem.Image = CType(resources.GetObject("RegisteredDonorTransactionREportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RegisteredDonorTransactionREportToolStripMenuItem.Name = "RegisteredDonorTransactionREportToolStripMenuItem"
        Me.RegisteredDonorTransactionREportToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6
        Me.RegisteredDonorTransactionREportToolStripMenuItem.Size = New System.Drawing.Size(481, 32)
        Me.RegisteredDonorTransactionREportToolStripMenuItem.Text = "Registered Donor Transaction Report"
        '
        'GenerateTxnSlipsToolStripMenuItem
        '
        Me.GenerateTxnSlipsToolStripMenuItem.Image = CType(resources.GetObject("GenerateTxnSlipsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GenerateTxnSlipsToolStripMenuItem.Name = "GenerateTxnSlipsToolStripMenuItem"
        Me.GenerateTxnSlipsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.D), System.Windows.Forms.Keys)
        Me.GenerateTxnSlipsToolStripMenuItem.Size = New System.Drawing.Size(351, 32)
        Me.GenerateTxnSlipsToolStripMenuItem.Text = "Generate Txns Slips"
        '
        'EmployeeSalaryTransactonReportToolStripMenuItem
        '
        Me.EmployeeSalaryTransactonReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GenerateTransactionSlipsToolStripMenuItem})
        Me.EmployeeSalaryTransactonReportToolStripMenuItem.Image = CType(resources.GetObject("EmployeeSalaryTransactonReportToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EmployeeSalaryTransactonReportToolStripMenuItem.Name = "EmployeeSalaryTransactonReportToolStripMenuItem"
        Me.EmployeeSalaryTransactonReportToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7
        Me.EmployeeSalaryTransactonReportToolStripMenuItem.Size = New System.Drawing.Size(481, 32)
        Me.EmployeeSalaryTransactonReportToolStripMenuItem.Text = "Employee Salary Transacton Report"
        '
        'GenerateTransactionSlipsToolStripMenuItem
        '
        Me.GenerateTransactionSlipsToolStripMenuItem.Image = CType(resources.GetObject("GenerateTransactionSlipsToolStripMenuItem.Image"), System.Drawing.Image)
        Me.GenerateTransactionSlipsToolStripMenuItem.Name = "GenerateTransactionSlipsToolStripMenuItem"
        Me.GenerateTransactionSlipsToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.E), System.Windows.Forms.Keys)
        Me.GenerateTransactionSlipsToolStripMenuItem.Size = New System.Drawing.Size(347, 32)
        Me.GenerateTransactionSlipsToolStripMenuItem.Text = "Generate Txns Slips"
        '
        'RefreshDashboardToolStripMenuItem
        '
        Me.RefreshDashboardToolStripMenuItem.Image = CType(resources.GetObject("RefreshDashboardToolStripMenuItem.Image"), System.Drawing.Image)
        Me.RefreshDashboardToolStripMenuItem.Name = "RefreshDashboardToolStripMenuItem"
        Me.RefreshDashboardToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5
        Me.RefreshDashboardToolStripMenuItem.Size = New System.Drawing.Size(116, 77)
        Me.RefreshDashboardToolStripMenuItem.Text = "Refresh"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Image = CType(resources.GetObject("LogOutToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.ShortcutKeys = CType(((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Shift) _
            Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(116, 77)
        Me.LogOutToolStripMenuItem.Text = "Log Out"
        '
        'XuiBanner1
        '
        Me.XuiBanner1.BackColor = System.Drawing.Color.Transparent
        Me.XuiBanner1.BannerColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.XuiBanner1.BorderColor = System.Drawing.Color.Transparent
        Me.XuiBanner1.Font = New System.Drawing.Font("Lucida Calligraphy", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XuiBanner1.ForeColor = System.Drawing.Color.Silver
        Me.XuiBanner1.Location = New System.Drawing.Point(-24, 84)
        Me.XuiBanner1.Name = "XuiBanner1"
        Me.XuiBanner1.Size = New System.Drawing.Size(1968, 52)
        Me.XuiBanner1.TabIndex = 3
        Me.XuiBanner1.Text = "Purnia  Blood   Bank  Management  System"
        '
        'XuiClock1
        '
        Me.XuiClock1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.XuiClock1.BackColor = System.Drawing.Color.LightCoral
        Me.XuiClock1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.XuiClock1.CircleThickness = 3
        Me.XuiClock1.DisplayFormat = XanderUI.XUIClock.HourFormat.TwelveHour
        Me.XuiClock1.FilledHourColor = System.Drawing.Color.Red
        Me.XuiClock1.FilledMinuteColor = System.Drawing.Color.Yellow
        Me.XuiClock1.FilledSecondColor = System.Drawing.Color.Aqua
        Me.XuiClock1.Font = New System.Drawing.Font("Matura MT Script Capitals", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.XuiClock1.HexagonColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.XuiClock1.Location = New System.Drawing.Point(1780, 3)
        Me.XuiClock1.Name = "XuiClock1"
        Me.XuiClock1.ShowAmPm = False
        Me.XuiClock1.ShowHexagon = True
        Me.XuiClock1.ShowMinutesCircle = True
        Me.XuiClock1.ShowSecondsCircle = True
        Me.XuiClock1.Size = New System.Drawing.Size(126, 78)
        Me.XuiClock1.TabIndex = 5
        Me.XuiClock1.Text = "XuiClock1"
        Me.XuiClock1.UnfilledHourColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(85, Byte), Integer))
        Me.XuiClock1.UnfilledMinuteColor = System.Drawing.Color.Yellow
        Me.XuiClock1.UnfilledSecondColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(70, Byte), Integer))
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Teal
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(3, 138)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(230, 111)
        Me.Panel1.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Yellow
        Me.Label3.Location = New System.Drawing.Point(146, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Marlett", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(121, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Donors"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(0, -5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 111)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Location = New System.Drawing.Point(3, 752)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(230, 115)
        Me.Panel2.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Yellow
        Me.Label7.Location = New System.Drawing.Point(150, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 32)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Marlett", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(118, 66)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 21)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Hospitals"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = CType(resources.GetObject("PictureBox4.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox4.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(114, 115)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Teal
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Location = New System.Drawing.Point(1686, 139)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(228, 110)
        Me.Panel3.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Yellow
        Me.Label5.Location = New System.Drawing.Point(150, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 32)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Marlett", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(124, 67)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 21)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "In Stock"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox3.Location = New System.Drawing.Point(1, 1)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(103, 109)
        Me.PictureBox3.TabIndex = 1
        Me.PictureBox3.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Teal
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.PictureBox2)
        Me.Panel4.Location = New System.Drawing.Point(1686, 752)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(228, 115)
        Me.Panel4.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Yellow
        Me.Label1.Location = New System.Drawing.Point(154, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 32)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Marlett", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(126, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 21)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Transfer"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox2.Location = New System.Drawing.Point(1, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(116, 115)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1920, 914)
        Me.Controls.Add(Me.XuiClock1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.XuiBanner1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.IsMdiContainer = True
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Dashboard"
        Me.TransparencyKey = System.Drawing.Color.Red
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HospitalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BloodDonorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowAllEmployeeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowAllUsersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewDonorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateDetailsToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowAllDonorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BloodInventoryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddMoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StockDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewHospitalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateHospitalDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowAllHospitalsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchDonorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchByLocationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByDonateDateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ByToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateBagDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XuiBanner1 As XanderUI.XUIBanner
    Friend WithEvents ToHospitalToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToRegisteredDonorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeSalaryTransactionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HospitalTransactionReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegisteredDonorTransactionREportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeSalaryTransactonReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateTxnSlipToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateTxnSlipsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GenerateTransactionSlipsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents XuiClock1 As XanderUI.XUIClock
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents RefreshDashboardToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
