Imports System.Data
Imports System.Data.SqlClient

' This is for Sms Api system
Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text

Public Class AddNewDonor
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String
    Private Sub AddNewDonor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Dashboard

    End Sub


    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        txtDname.ResetText()
        txtAge.ResetText()
        txtContact.ResetText()
        txtEmail.ResetText()
        txtBWeight.ResetText()
        txtTemp.ResetText()
        txtBP.ResetText()
        txtPRate.ResetText()
        txtHemo.ResetText()
        txtWtBag.ResetText()
        txtOccupation.ResetText()
        txtFname.ResetText()
        richtxtAddress.ResetText()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        BloodBag.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dashboard.Show()
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim dName As String
        Dim fName As String
        Dim address As String
        Dim age As String
        Dim gender As String = ""
        If RadioButton1.Checked Then
            gender = "Male"
        End If
        If RadioButton2.Checked Then
            gender = "Female"
        End If
        If RadioButton3.Checked Then
            gender = "Others"
        End If
        Dim contact As String
        Dim mStatus As String
        Dim bGroup As String
        Dim occu As String
        Dim email As String
        Dim lDdate As String
        Dim bweight As String
        Dim temp As String
        Dim bp As String
        Dim prate As String
        Dim hemo As String
        Dim wtBag As String
        Dim tp As String = ""
        If CheckBox1.Checked = False Or CheckBox2.Checked = False Or CheckBox3.Checked = False Or CheckBox4.Checked = False Then
            tp = "None"
        End If
        If CheckBox1.Checked Then
            tp = "Covid19"
        End If
        If CheckBox1.Checked And CheckBox2.Checked Then
            tp = "Covid19, HIV"
        End If
        If CheckBox1.Checked And CheckBox2.Checked And CheckBox3.Checked Then
            tp = "Covid19, HIV, M.P"
        End If
        If CheckBox1.Checked And CheckBox2.Checked And CheckBox3.Checked And CheckBox4.Checked Then
            tp = "Covid19, HIV, M.P, HCV"
        End If
       
        dName = txtDname.Text
        age = txtAge.Text
        bp = txtBP.Text
        bweight = txtBWeight.Text
        contact = txtContact.Text
        email = txtEmail.Text
        occu = txtOccupation.Text
        hemo = txtHemo.Text
        temp = txtTemp.Text
        wtBag = txtWtBag.Text
        fName = txtFname.Text
        address = richtxtAddress.Text
        mStatus = ComboBox1.SelectedItem
        bGroup = ComboBox2.SelectedItem
        lDdate = DateTimePicker1.Value.Date
        prate = txtPRate.Text
        If dName = "" Or age = "" Or bweight = "" Or contact = "" Or address = "" Or fName = "" Or wtBag = "" Or bGroup = "" Or mStatus = "" Or prate = "" Or lDdate = "" Then
            MessageBox.Show("You cannot Submit Blank Form Please fill all the mendatory field to continue.. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                con.Open()
                query = "INSERT INTO [dbo].[Donors]([Donor_Name],[FatherName],[Address],[Age],[Gender],[Contact],[MaritalStatus],[BloodGroup],[Occupation],[Email],[Last_DonateDate],[BodyWeight],[Temperature],[BloodPressure],[PulseRate],[Hemoglobin],[WtOfBag],[TestPositive])VALUES('" & dName & "', '" & fName & "', '" & address & "', '" & age & "', '" & gender & "', '" & contact & "', '" & mStatus & "', '" & bGroup & "', '" & occu & "','" & email & "', '" & lDdate & "', '" & bweight & "', '" & temp & "', '" & bp & "', '" & prate & "','" & hemo & "','" & wtBag & "','" & tp & "')"
                If wtBag.Length < 20 And bweight.Length < 10 And temp.Length < 10 Then
                    cmd = New SqlCommand(query, con)
                    If cmd.ExecuteNonQuery() Then
                        MessageBox.Show("Donor Registered Successfully! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        ' Yahn Par SMS API ka work ho rha hai 
                        Dim apikey = "XNlKmj2Ur2E-GuxDI2Fi3CNSWM7n4Pyt1Z7YscPJFz"
                        Dim message = "Hey There! We are from Purnia Blood Bank Thank You for your Blood Donation !Congratulations, now you are going to save someone's life!"
                        Dim numbers = txtContact.Text
                        Dim strGet As String
                        Dim senderName = "TXTLCL"
                        Dim url As String = "https://api.textlocal.in/send/?"

                        strGet = url + "apikey=" + apikey _
                           + "&numbers=" + numbers _
                         + "&message=" + WebUtility.UrlEncode(message) _
                         + "&sender=" + senderName

                        Dim webClient As New System.Net.WebClient
                        Dim result As String = webClient.DownloadString(strGet)
                        'MessageBox.Show(result, "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Return result

                        'yahn pr khatam 

                        txtDname.ResetText()
                        txtAge.ResetText()
                        txtContact.ResetText()
                        txtEmail.ResetText()
                        txtBWeight.ResetText()
                        txtTemp.ResetText()
                        txtBP.ResetText()
                        txtPRate.ResetText()
                        txtHemo.ResetText()
                        txtWtBag.ResetText()
                        txtOccupation.ResetText()
                        txtFname.ResetText()
                        richtxtAddress.ResetText()
                        RadioButton1.Checked = False
                        RadioButton2.Checked = False
                        RadioButton3.Checked = False
                        DateTimePicker1.Value = DateAndTime.Now
                        CheckBox1.Checked = False
                        CheckBox2.Checked = False
                        CheckBox3.Checked = False
                        CheckBox4.Checked = False
                    Else
                        MessageBox.Show("Insertion Faild ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show("Please enter valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()

            End Try
        End If

    End Sub

End Class