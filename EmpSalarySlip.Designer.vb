<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmpSalarySlip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmpSalarySlip))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtSBox = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.netSalary = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.deductions = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.gsalary = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.hra = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.paymentDate = New System.Windows.Forms.Label()
        Me.dA = New System.Windows.Forms.Label()
        Me.Adays = New System.Windows.Forms.Label()
        Me.basicpay = New System.Windows.Forms.Label()
        Me.smonth = New System.Windows.Forms.Label()
        Me.jdate = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.txnNo = New System.Windows.Forms.Label()
        Me.mobile = New System.Windows.Forms.Label()
        Me.empid = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.Label()
        Me.empName = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Javanese Text", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(233, 62)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(609, 32)
        Me.Label10.TabIndex = 277
        Me.Label10.Text = "Note - if you dont't remember transaction no ? Please go to Reporrts menu to find" & _
    " transaction no!"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Lucida Sans Typewriter", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(874, 672)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(129, 54)
        Me.Button4.TabIndex = 276
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Malgun Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(1025, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(44, 36)
        Me.Button1.TabIndex = 275
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Malgun Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(52, 673)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 51)
        Me.Button2.TabIndex = 274
        Me.Button2.Text = "Print"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.White
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Lucida Sans Typewriter", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(674, 12)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(145, 45)
        Me.btnSearch.TabIndex = 273
        Me.btnSearch.Text = "Generate"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtSBox
        '
        Me.txtSBox.BackColor = System.Drawing.Color.White
        Me.txtSBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSBox.Location = New System.Drawing.Point(486, 11)
        Me.txtSBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtSBox.Multiline = True
        Me.txtSBox.Name = "txtSBox"
        Me.txtSBox.Size = New System.Drawing.Size(173, 45)
        Me.txtSBox.TabIndex = 272
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(247, 22)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(230, 25)
        Me.Label26.TabIndex = 271
        Me.Label26.Text = "Enter Transaction No.-"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.netSalary)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.deductions)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.gsalary)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.hra)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.paymentDate)
        Me.Panel1.Controls.Add(Me.dA)
        Me.Panel1.Controls.Add(Me.Adays)
        Me.Panel1.Controls.Add(Me.basicpay)
        Me.Panel1.Controls.Add(Me.smonth)
        Me.Panel1.Controls.Add(Me.jdate)
        Me.Panel1.Controls.Add(Me.email)
        Me.Panel1.Controls.Add(Me.txnNo)
        Me.Panel1.Controls.Add(Me.mobile)
        Me.Panel1.Controls.Add(Me.empid)
        Me.Panel1.Controls.Add(Me.address)
        Me.Panel1.Controls.Add(Me.empName)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(50, 102)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(953, 567)
        Me.Panel1.TabIndex = 270
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(365, 1)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(244, 31)
        Me.Label15.TabIndex = 277
        Me.Label15.Text = "Purnia Blood Bank"
        '
        'netSalary
        '
        Me.netSalary.AutoSize = True
        Me.netSalary.BackColor = System.Drawing.Color.Transparent
        Me.netSalary.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.netSalary.ForeColor = System.Drawing.Color.Black
        Me.netSalary.Location = New System.Drawing.Point(734, 437)
        Me.netSalary.Name = "netSalary"
        Me.netSalary.Size = New System.Drawing.Size(145, 21)
        Me.netSalary.TabIndex = 276
        Me.netSalary.Text = "..........................."
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Transparent
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(558, 435)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(104, 22)
        Me.Label21.TabIndex = 275
        Me.Label21.Text = "Net Salary"
        '
        'deductions
        '
        Me.deductions.AutoSize = True
        Me.deductions.BackColor = System.Drawing.Color.Transparent
        Me.deductions.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deductions.ForeColor = System.Drawing.Color.Black
        Me.deductions.Location = New System.Drawing.Point(734, 386)
        Me.deductions.Name = "deductions"
        Me.deductions.Size = New System.Drawing.Size(145, 21)
        Me.deductions.TabIndex = 274
        Me.deductions.Text = "..........................."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.BackColor = System.Drawing.Color.Transparent
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(561, 388)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(110, 22)
        Me.Label19.TabIndex = 273
        Me.Label19.Text = "Deductions"
        '
        'gsalary
        '
        Me.gsalary.AutoSize = True
        Me.gsalary.BackColor = System.Drawing.Color.Transparent
        Me.gsalary.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gsalary.ForeColor = System.Drawing.Color.Black
        Me.gsalary.Location = New System.Drawing.Point(734, 331)
        Me.gsalary.Name = "gsalary"
        Me.gsalary.Size = New System.Drawing.Size(145, 21)
        Me.gsalary.TabIndex = 272
        Me.gsalary.Text = "..........................."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(558, 334)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(126, 22)
        Me.Label17.TabIndex = 271
        Me.Label17.Text = "Gross Salary"
        '
        'hra
        '
        Me.hra.AutoSize = True
        Me.hra.BackColor = System.Drawing.Color.Transparent
        Me.hra.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hra.ForeColor = System.Drawing.Color.Black
        Me.hra.Location = New System.Drawing.Point(734, 271)
        Me.hra.Name = "hra"
        Me.hra.Size = New System.Drawing.Size(145, 21)
        Me.hra.TabIndex = 270
        Me.hra.Text = "..........................."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(596, 274)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(51, 22)
        Me.Label16.TabIndex = 269
        Me.Label16.Text = "HRA"
        '
        'paymentDate
        '
        Me.paymentDate.AutoSize = True
        Me.paymentDate.BackColor = System.Drawing.Color.Transparent
        Me.paymentDate.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.paymentDate.ForeColor = System.Drawing.Color.Black
        Me.paymentDate.Location = New System.Drawing.Point(734, 493)
        Me.paymentDate.Name = "paymentDate"
        Me.paymentDate.Size = New System.Drawing.Size(145, 21)
        Me.paymentDate.TabIndex = 268
        Me.paymentDate.Text = "..........................."
        '
        'dA
        '
        Me.dA.AutoSize = True
        Me.dA.BackColor = System.Drawing.Color.Transparent
        Me.dA.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dA.ForeColor = System.Drawing.Color.Black
        Me.dA.Location = New System.Drawing.Point(734, 225)
        Me.dA.Name = "dA"
        Me.dA.Size = New System.Drawing.Size(145, 21)
        Me.dA.TabIndex = 267
        Me.dA.Text = "..........................."
        '
        'Adays
        '
        Me.Adays.AutoSize = True
        Me.Adays.BackColor = System.Drawing.Color.Transparent
        Me.Adays.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Adays.ForeColor = System.Drawing.Color.Black
        Me.Adays.Location = New System.Drawing.Point(734, 187)
        Me.Adays.Name = "Adays"
        Me.Adays.Size = New System.Drawing.Size(145, 21)
        Me.Adays.TabIndex = 266
        Me.Adays.Text = "..........................."
        '
        'basicpay
        '
        Me.basicpay.AutoSize = True
        Me.basicpay.BackColor = System.Drawing.Color.Transparent
        Me.basicpay.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.basicpay.ForeColor = System.Drawing.Color.Black
        Me.basicpay.Location = New System.Drawing.Point(727, 136)
        Me.basicpay.Name = "basicpay"
        Me.basicpay.Size = New System.Drawing.Size(145, 21)
        Me.basicpay.TabIndex = 265
        Me.basicpay.Text = "..........................."
        '
        'smonth
        '
        Me.smonth.AutoSize = True
        Me.smonth.BackColor = System.Drawing.Color.Transparent
        Me.smonth.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.smonth.ForeColor = System.Drawing.Color.Black
        Me.smonth.Location = New System.Drawing.Point(727, 86)
        Me.smonth.Name = "smonth"
        Me.smonth.Size = New System.Drawing.Size(145, 21)
        Me.smonth.TabIndex = 264
        Me.smonth.Text = "..........................."
        '
        'jdate
        '
        Me.jdate.AutoSize = True
        Me.jdate.BackColor = System.Drawing.Color.Transparent
        Me.jdate.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.jdate.ForeColor = System.Drawing.Color.Black
        Me.jdate.Location = New System.Drawing.Point(233, 497)
        Me.jdate.Name = "jdate"
        Me.jdate.Size = New System.Drawing.Size(145, 21)
        Me.jdate.TabIndex = 263
        Me.jdate.Text = "..........................."
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.BackColor = System.Drawing.Color.Transparent
        Me.email.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.Color.Black
        Me.email.Location = New System.Drawing.Point(230, 360)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(145, 21)
        Me.email.TabIndex = 262
        Me.email.Text = "..........................."
        '
        'txnNo
        '
        Me.txnNo.AutoSize = True
        Me.txnNo.BackColor = System.Drawing.Color.Transparent
        Me.txnNo.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txnNo.ForeColor = System.Drawing.Color.Black
        Me.txnNo.Location = New System.Drawing.Point(233, 90)
        Me.txnNo.Name = "txnNo"
        Me.txnNo.Size = New System.Drawing.Size(145, 21)
        Me.txnNo.TabIndex = 261
        Me.txnNo.Text = "..........................."
        '
        'mobile
        '
        Me.mobile.AutoSize = True
        Me.mobile.BackColor = System.Drawing.Color.Transparent
        Me.mobile.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mobile.ForeColor = System.Drawing.Color.Black
        Me.mobile.Location = New System.Drawing.Point(230, 430)
        Me.mobile.Name = "mobile"
        Me.mobile.Size = New System.Drawing.Size(145, 21)
        Me.mobile.TabIndex = 260
        Me.mobile.Text = "..........................."
        '
        'empid
        '
        Me.empid.AutoSize = True
        Me.empid.BackColor = System.Drawing.Color.Transparent
        Me.empid.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empid.ForeColor = System.Drawing.Color.Black
        Me.empid.Location = New System.Drawing.Point(237, 148)
        Me.empid.Name = "empid"
        Me.empid.Size = New System.Drawing.Size(145, 21)
        Me.empid.TabIndex = 259
        Me.empid.Text = "..........................."
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.BackColor = System.Drawing.Color.Transparent
        Me.address.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.ForeColor = System.Drawing.Color.Black
        Me.address.Location = New System.Drawing.Point(233, 286)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(145, 21)
        Me.address.TabIndex = 258
        Me.address.Text = "..........................."
        '
        'empName
        '
        Me.empName.AutoSize = True
        Me.empName.BackColor = System.Drawing.Color.Transparent
        Me.empName.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.empName.ForeColor = System.Drawing.Color.Black
        Me.empName.Location = New System.Drawing.Point(235, 213)
        Me.empName.Name = "empName"
        Me.empName.Size = New System.Drawing.Size(145, 21)
        Me.empName.TabIndex = 257
        Me.empName.Text = "..........................."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(558, 495)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(135, 22)
        Me.Label9.TabIndex = 256
        Me.Label9.Text = "Payment Date"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(596, 228)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 22)
        Me.Label13.TabIndex = 254
        Me.Label13.Text = "DA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(555, 187)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(141, 22)
        Me.Label11.TabIndex = 253
        Me.Label11.Text = "Attended Days"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(556, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(99, 22)
        Me.Label12.TabIndex = 252
        Me.Label12.Text = "Basic Pay"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(548, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 22)
        Me.Label8.TabIndex = 251
        Me.Label8.Text = "Salary Month "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(64, 87)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 22)
        Me.Label3.TabIndex = 250
        Me.Label3.Text = "Transaction no."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(67, 497)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 22)
        Me.Label1.TabIndex = 249
        Me.Label1.Text = "Joining Date"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(64, 430)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 22)
        Me.Label2.TabIndex = 248
        Me.Label2.Text = "Mobile No."
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(61, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 22)
        Me.Label4.TabIndex = 247
        Me.Label4.Text = "Email Id"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(64, 145)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(122, 22)
        Me.Label5.TabIndex = 246
        Me.Label5.Text = "Employee ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(64, 288)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 22)
        Me.Label7.TabIndex = 245
        Me.Label7.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(60, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 22)
        Me.Label6.TabIndex = 244
        Me.Label6.Text = "Employee Name"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(401, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(140, 31)
        Me.Label14.TabIndex = 243
        Me.Label14.Text = "Salary Slip"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(953, 567)
        Me.ShapeContainer1.TabIndex = 255
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 2
        Me.LineShape1.X2 = 949
        Me.LineShape1.Y1 = 32
        Me.LineShape1.Y2 = 32
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'EmpSalarySlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1070, 757)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtSBox)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "EmpSalarySlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmpSalarySlip"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtSBox As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents paymentDate As System.Windows.Forms.Label
    Friend WithEvents dA As System.Windows.Forms.Label
    Friend WithEvents Adays As System.Windows.Forms.Label
    Friend WithEvents basicpay As System.Windows.Forms.Label
    Friend WithEvents smonth As System.Windows.Forms.Label
    Friend WithEvents jdate As System.Windows.Forms.Label
    Friend WithEvents email As System.Windows.Forms.Label
    Friend WithEvents txnNo As System.Windows.Forms.Label
    Friend WithEvents mobile As System.Windows.Forms.Label
    Friend WithEvents empid As System.Windows.Forms.Label
    Friend WithEvents address As System.Windows.Forms.Label
    Friend WithEvents empName As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents netSalary As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents deductions As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents gsalary As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents hra As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
