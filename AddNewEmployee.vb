Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class AddNewEmployee
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String
    Dim imgPath As String
    Private Sub AddNewEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Dashboard

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Dim folder As String = "C:\AddImg\"
        OpenFileDialog1.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png*.gif"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
            imgPath = folder + txtId.Text + ".jpg"
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim empName As String
        Dim empId As String
        Dim empFname As String
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
        Dim dob As String
        Dim quali As String
        Dim jDate As String
        Dim desig As String
        Dim salary As String
        Dim address As String
        Dim city As String
        Dim pin As String
        Dim bGroup As String
        Dim email As String
        Dim contact As String
        
        empName = txtName.Text
        empFname = txtFname.Text
        empId = txtId.Text
        dob = DateTimePicker1.Value.Date
        quali = ComboBox1.SelectedItem
        jDate = DateTimePicker2.Value.Date
        desig = ComboBox2.SelectedItem
        salary = txtSalary.Text
        address = RichTextBox1.Text
        city = txtCity.Text
        pin = txtPin.Text
        contact = txtContact.Text
        bGroup = ComboBox3.SelectedItem
        email = txtEmail.Text
        If empName = "" Or dob = "" Or desig = "" Or salary = "" Or city = "" Or pin = "" Or contact = "" Or bGroup = "" Or empId = "" Or quali = "" Or jDate = "" Then
            MessageBox.Show("You cannot Submit Blank Form Please fill all the mendatory field to continue.. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                con.Open()
                query = "INSERT INTO [dbo].[Employee]([EmpID],[EmpName],[EmpFName],[Gender],[DOB],[Qualification],[Joining_Date],[Designation],[Salary],[Address],[City],[PinNo],[Contact],[BloodGroup],[Email],[Image])VALUES('" & empId & "', '" & empName & "', '" & empFname & "', '" & gender & "', '" & dob & "', '" & quali & "', '" & jDate & "', '" & desig & "', '" & salary & "','" & address & "', '" & city & "', '" & pin & "', '" & contact & "', '" & bGroup & "', '" & email & "','" & imgPath & "')"
                Dim a As Image = PictureBox1.Image
                a.Save(imgPath)
                cmd = New SqlCommand(query, con)
                If cmd.ExecuteNonQuery() Then
                    MessageBox.Show("Data Saved Successfully! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCity.Clear()
                    txtContact.Clear()
                    txtEmail.Clear()
                    txtFname.Clear()
                    txtId.Clear()
                    txtName.Clear()
                    txtPin.Clear()
                    txtSalary.Clear()
                    RichTextBox1.Clear()
                    PictureBox1.Image = Nothing
                    RadioButton1.Checked = False
                    RadioButton2.Checked = False
                    RadioButton3.Checked = False
                    ComboBox1.SelectedItem = False

                Else
                    MessageBox.Show("Insertion Faild ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()

            End Try
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtCity.Clear()
        txtContact.Clear()
        txtEmail.Clear()
        txtFname.Clear()
        txtId.Clear()
        txtName.Clear()
        txtPin.Clear()
        txtSalary.Clear()
        RichTextBox1.Clear()

    End Sub
End Class