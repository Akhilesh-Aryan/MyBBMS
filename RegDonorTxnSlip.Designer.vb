<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegDonorTxnSlip
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RegDonorTxnSlip))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtHIDSBox = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.totalAmount = New System.Windows.Forms.Label()
        Me.pricePerBag = New System.Windows.Forms.Label()
        Me.noofBags = New System.Windows.Forms.Label()
        Me.bloodGroup = New System.Windows.Forms.Label()
        Me.txndate = New System.Windows.Forms.Label()
        Me.phoneNo = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.Label()
        Me.txnNo = New System.Windows.Forms.Label()
        Me.email = New System.Windows.Forms.Label()
        Me.did = New System.Windows.Forms.Label()
        Me.address = New System.Windows.Forms.Label()
        Me.fname = New System.Windows.Forms.Label()
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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Malgun Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(1053, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(38, 35)
        Me.Button1.TabIndex = 235
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Snow
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Malgun Gothic", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Black
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(68, 681)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(127, 51)
        Me.Button2.TabIndex = 234
        Me.Button2.Text = "Print"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Transparent
        Me.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSearch.Font = New System.Drawing.Font("Lucida Sans Typewriter", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.Color.Black
        Me.btnSearch.Image = CType(resources.GetObject("btnSearch.Image"), System.Drawing.Image)
        Me.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSearch.Location = New System.Drawing.Point(663, 16)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(145, 45)
        Me.btnSearch.TabIndex = 233
        Me.btnSearch.Text = "Generate"
        Me.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtHIDSBox
        '
        Me.txtHIDSBox.BackColor = System.Drawing.Color.White
        Me.txtHIDSBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHIDSBox.Location = New System.Drawing.Point(475, 15)
        Me.txtHIDSBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtHIDSBox.Multiline = True
        Me.txtHIDSBox.Name = "txtHIDSBox"
        Me.txtHIDSBox.Size = New System.Drawing.Size(173, 45)
        Me.txtHIDSBox.TabIndex = 232
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(232, 26)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(230, 25)
        Me.Label26.TabIndex = 231
        Me.Label26.Text = "Enter Transaction No -"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.totalAmount)
        Me.Panel1.Controls.Add(Me.pricePerBag)
        Me.Panel1.Controls.Add(Me.noofBags)
        Me.Panel1.Controls.Add(Me.bloodGroup)
        Me.Panel1.Controls.Add(Me.txndate)
        Me.Panel1.Controls.Add(Me.phoneNo)
        Me.Panel1.Controls.Add(Me.Gender)
        Me.Panel1.Controls.Add(Me.txnNo)
        Me.Panel1.Controls.Add(Me.email)
        Me.Panel1.Controls.Add(Me.did)
        Me.Panel1.Controls.Add(Me.address)
        Me.Panel1.Controls.Add(Me.fname)
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
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.Location = New System.Drawing.Point(68, 120)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(953, 558)
        Me.Panel1.TabIndex = 230
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(693, 520)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 21)
        Me.Label16.TabIndex = 272
        Me.Label16.Text = "Signature"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(352, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(244, 31)
        Me.Label15.TabIndex = 271
        Me.Label15.Text = "Purnia Blood Bank"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Maiandra GD", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(367, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(211, 31)
        Me.Label14.TabIndex = 270
        Me.Label14.Text = "Transaction Slip"
        '
        'totalAmount
        '
        Me.totalAmount.AutoSize = True
        Me.totalAmount.BackColor = System.Drawing.Color.Transparent
        Me.totalAmount.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalAmount.ForeColor = System.Drawing.Color.Black
        Me.totalAmount.Location = New System.Drawing.Point(750, 456)
        Me.totalAmount.Name = "totalAmount"
        Me.totalAmount.Size = New System.Drawing.Size(145, 21)
        Me.totalAmount.TabIndex = 268
        Me.totalAmount.Text = "..........................."
        '
        'pricePerBag
        '
        Me.pricePerBag.AutoSize = True
        Me.pricePerBag.BackColor = System.Drawing.Color.Transparent
        Me.pricePerBag.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pricePerBag.ForeColor = System.Drawing.Color.Black
        Me.pricePerBag.Location = New System.Drawing.Point(748, 384)
        Me.pricePerBag.Name = "pricePerBag"
        Me.pricePerBag.Size = New System.Drawing.Size(145, 21)
        Me.pricePerBag.TabIndex = 267
        Me.pricePerBag.Text = "..........................."
        '
        'noofBags
        '
        Me.noofBags.AutoSize = True
        Me.noofBags.BackColor = System.Drawing.Color.Transparent
        Me.noofBags.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noofBags.ForeColor = System.Drawing.Color.Black
        Me.noofBags.Location = New System.Drawing.Point(750, 316)
        Me.noofBags.Name = "noofBags"
        Me.noofBags.Size = New System.Drawing.Size(145, 21)
        Me.noofBags.TabIndex = 266
        Me.noofBags.Text = "..........................."
        '
        'bloodGroup
        '
        Me.bloodGroup.AutoSize = True
        Me.bloodGroup.BackColor = System.Drawing.Color.Transparent
        Me.bloodGroup.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bloodGroup.ForeColor = System.Drawing.Color.Black
        Me.bloodGroup.Location = New System.Drawing.Point(744, 247)
        Me.bloodGroup.Name = "bloodGroup"
        Me.bloodGroup.Size = New System.Drawing.Size(145, 21)
        Me.bloodGroup.TabIndex = 265
        Me.bloodGroup.Text = "..........................."
        '
        'txndate
        '
        Me.txndate.AutoSize = True
        Me.txndate.BackColor = System.Drawing.Color.Transparent
        Me.txndate.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txndate.ForeColor = System.Drawing.Color.Black
        Me.txndate.Location = New System.Drawing.Point(725, 115)
        Me.txndate.Name = "txndate"
        Me.txndate.Size = New System.Drawing.Size(145, 21)
        Me.txndate.TabIndex = 264
        Me.txndate.Text = "..........................."
        '
        'phoneNo
        '
        Me.phoneNo.AutoSize = True
        Me.phoneNo.BackColor = System.Drawing.Color.Transparent
        Me.phoneNo.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phoneNo.ForeColor = System.Drawing.Color.Black
        Me.phoneNo.Location = New System.Drawing.Point(725, 176)
        Me.phoneNo.Name = "phoneNo"
        Me.phoneNo.Size = New System.Drawing.Size(145, 21)
        Me.phoneNo.TabIndex = 263
        Me.phoneNo.Text = "..........................."
        '
        'Gender
        '
        Me.Gender.AutoSize = True
        Me.Gender.BackColor = System.Drawing.Color.Transparent
        Me.Gender.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.ForeColor = System.Drawing.Color.Black
        Me.Gender.Location = New System.Drawing.Point(233, 401)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(145, 21)
        Me.Gender.TabIndex = 262
        Me.Gender.Text = "..........................."
        '
        'txnNo
        '
        Me.txnNo.AutoSize = True
        Me.txnNo.BackColor = System.Drawing.Color.Transparent
        Me.txnNo.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txnNo.ForeColor = System.Drawing.Color.Black
        Me.txnNo.Location = New System.Drawing.Point(236, 106)
        Me.txnNo.Name = "txnNo"
        Me.txnNo.Size = New System.Drawing.Size(145, 21)
        Me.txnNo.TabIndex = 261
        Me.txnNo.Text = "..........................."
        '
        'email
        '
        Me.email.AutoSize = True
        Me.email.BackColor = System.Drawing.Color.Transparent
        Me.email.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.email.ForeColor = System.Drawing.Color.Black
        Me.email.Location = New System.Drawing.Point(230, 472)
        Me.email.Name = "email"
        Me.email.Size = New System.Drawing.Size(145, 21)
        Me.email.TabIndex = 260
        Me.email.Text = "..........................."
        '
        'did
        '
        Me.did.AutoSize = True
        Me.did.BackColor = System.Drawing.Color.Transparent
        Me.did.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.did.ForeColor = System.Drawing.Color.Black
        Me.did.Location = New System.Drawing.Point(236, 179)
        Me.did.Name = "did"
        Me.did.Size = New System.Drawing.Size(145, 21)
        Me.did.TabIndex = 259
        Me.did.Text = "..........................."
        '
        'address
        '
        Me.address.AutoSize = True
        Me.address.BackColor = System.Drawing.Color.Transparent
        Me.address.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.address.ForeColor = System.Drawing.Color.Black
        Me.address.Location = New System.Drawing.Point(226, 324)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(145, 21)
        Me.address.TabIndex = 258
        Me.address.Text = "..........................."
        '
        'fname
        '
        Me.fname.AutoSize = True
        Me.fname.BackColor = System.Drawing.Color.Transparent
        Me.fname.Font = New System.Drawing.Font("Lucida Calligraphy", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fname.ForeColor = System.Drawing.Color.Black
        Me.fname.Location = New System.Drawing.Point(234, 252)
        Me.fname.Name = "fname"
        Me.fname.Size = New System.Drawing.Size(145, 21)
        Me.fname.TabIndex = 257
        Me.fname.Text = "..........................."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(574, 456)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(129, 22)
        Me.Label9.TabIndex = 256
        Me.Label9.Text = "Total Amount"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(574, 384)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(134, 22)
        Me.Label13.TabIndex = 254
        Me.Label13.Text = "Price Per Bag"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(577, 316)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 22)
        Me.Label11.TabIndex = 253
        Me.Label11.Text = "No of Bags"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(574, 247)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(122, 22)
        Me.Label12.TabIndex = 252
        Me.Label12.Text = "Blood Group"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(591, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 22)
        Me.Label8.TabIndex = 251
        Me.Label8.Text = "Date"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(64, 106)
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
        Me.Label1.Location = New System.Drawing.Point(574, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 22)
        Me.Label1.TabIndex = 249
        Me.Label1.Text = "Phone No."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(64, 472)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 22)
        Me.Label2.TabIndex = 248
        Me.Label2.Text = "Email Id"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(64, 401)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 22)
        Me.Label4.TabIndex = 247
        Me.Label4.Text = "Gender"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(64, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(167, 22)
        Me.Label5.TabIndex = 246
        Me.Label5.Text = "Registered Donor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(64, 326)
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
        Me.Label6.Location = New System.Drawing.Point(64, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 22)
        Me.Label6.TabIndex = 244
        Me.Label6.Text = "Father's Name"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(953, 558)
        Me.ShapeContainer1.TabIndex = 255
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 2
        Me.LineShape1.X2 = 949
        Me.LineShape1.Y1 = 31
        Me.LineShape1.Y2 = 31
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Javanese Text", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(256, 67)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(609, 32)
        Me.Label10.TabIndex = 271
        Me.Label10.Text = "Note - if you dont't remember transaction no ? Please go to Reporrts menu to find" & _
    " transaction no!"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Snow
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Lucida Sans Typewriter", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(891, 680)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 54)
        Me.Button4.TabIndex = 270
        Me.Button4.Text = "Close"
        Me.Button4.UseVisualStyleBackColor = False
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
        'RegDonorTxnSlip
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1092, 793)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtHIDSBox)
        Me.Controls.Add(Me.Label26)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RegDonorTxnSlip"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegDonorTxnSlip"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtHIDSBox As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents totalAmount As System.Windows.Forms.Label
    Friend WithEvents pricePerBag As System.Windows.Forms.Label
    Friend WithEvents noofBags As System.Windows.Forms.Label
    Friend WithEvents bloodGroup As System.Windows.Forms.Label
    Friend WithEvents txndate As System.Windows.Forms.Label
    Friend WithEvents phoneNo As System.Windows.Forms.Label
    Friend WithEvents Gender As System.Windows.Forms.Label
    Friend WithEvents txnNo As System.Windows.Forms.Label
    Friend WithEvents email As System.Windows.Forms.Label
    Friend WithEvents did As System.Windows.Forms.Label
    Friend WithEvents address As System.Windows.Forms.Label
    Friend WithEvents fname As System.Windows.Forms.Label
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
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
End Class
