Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Public Class UpdateEmployee
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()

    End Sub

    Private Sub UpdateEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Dashboard

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim search As String
        search = txtSearch.Text
        Dim filename As String = txtSearch.Text + ".jpg"
        Dim folder As String = "C:\AddImg\"
        Dim fPath As String = folder + filename
        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT * FROM [dbo].[Employee] WHERE EmpID = '" & search & "'"
            cmd = New SqlCommand(query, con)
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                txtEmpId.Text = dr("EmpID")
                txtEname.Text = dr("EmpName")
                txtEFname.Text = dr("EmpFName")
                txtGender.Text = dr("Gender")
                txtdob.Text = dr("DOB")
                txtQuali.Text = dr("Qualification")
                txtJDate.Text = dr("Joining_Date")
                txtDesig.Text = dr("Designation")
                txtSalary.Text = dr("Salary")
                richtxtAddress.Text = dr("Address")
                txtCity.Text = dr("City")
                txtPin.Text = dr("PinNo")
                txtContact.Text = dr("Contact")
                txtBGroup.Text = dr("BloodGroup")
                txtEmail.Text = dr("Email")
                PictureBox1.Image = Image.FromFile(fPath)
            Else
                MessageBox.Show("Sorry ! Record not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("image not available", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Finally
            con.Close()

        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim search As String
        search = txtSearch.Text
        If txtSearch.Text = "" Or txtBGroup.Text = "" Or txtEFname.Text = "" Or txtdob.Text = "" Or txtDesig.Text = "" Or txtContact.Text = "" Or txtCity.Text = "" Then
            MessageBox.Show("Sorry Fields Cannot be Empty to Update Records !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                con.Open()
                query = "UPDATE [dbo].[Employee] SET [EmpID] = '" & txtEmpId.Text & "', [EmpName]= '" & txtEname.Text & "', [EmpFName] = '" & txtEFname.Text & "',[Gender] = '" & txtGender.Text & "',[DOB] = '" & txtdob.Text & "',[Qualification] = '" & txtQuali.Text & "',[Joining_Date] = '" & txtJDate.Text & "',[Designation] = '" & txtDesig.Text & "',[Salary] = '" & txtSalary.Text & "',[Address] = '" & richtxtAddress.Text & "',[City] = '" & txtCity.Text & "',[PinNo] = '" & txtPin.Text & "',[Contact] = '" & txtContact.Text & "',[BloodGroup] = '" & txtBGroup.Text & "',[Email] = '" & txtEmail.Text & "' WHERE [EmpID] = '" & search & "'"
                cmd = New SqlCommand(query, con)
                Dim res As Integer
                res = cmd.ExecuteNonQuery
                If res > 0 Then
                    MessageBox.Show("Record Updated Successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCity.Clear()
                    txtContact.Clear()
                    txtEmail.Clear()
                    txtdob.Clear()
                    txtEmpId.Clear()
                    txtEname.Clear()
                    txtEFname.Clear()
                    txtPin.Clear()
                    txtSalary.Clear()
                    richtxtAddress.Clear()
                    txtDesig.Clear()
                    txtBGroup.Clear()
                    txtGender.Clear()
                    txtJDate.Clear()
                    txtQuali.Clear()
                    txtSearch.Clear()
                    PictureBox1.Image = Nothing
                Else
                    MessageBox.Show("Worng input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()

            End Try
        End If

    End Sub

    Private Sub btnDeleteEmp_Click(sender As Object, e As EventArgs) Handles btnDeleteEmp.Click
        If txtSearch.Text = "" Or txtBGroup.Text = "" Or txtEFname.Text = "" Or txtdob.Text = "" Or txtDesig.Text = "" Or txtContact.Text = "" Or txtCity.Text = "" Then
            MessageBox.Show("Sorry Fields Cannot be Empty to perform delete operation !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            Try
                con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                con.Open()

                query = "DELETE FROM [dbo].[Employee] WHERE EmpID = '" & txtSearch.Text & "'"
                cmd = New SqlCommand(query, con)
                If MessageBox.Show("Are you sure want to delete this records", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    cmd.ExecuteNonQuery()
                    MessageBox.Show(" Record Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCity.Clear()
                    txtContact.Clear()
                    txtEmail.Clear()
                    txtdob.Clear()
                    txtEmpId.Clear()
                    txtEname.Clear()
                    txtEFname.Clear()
                    txtPin.Clear()
                    txtSalary.Clear()
                    richtxtAddress.Clear()
                    txtDesig.Clear()
                    txtBGroup.Clear()
                    txtGender.Clear()
                    txtJDate.Clear()
                    txtQuali.Clear()
                    txtSearch.Clear()
                    PictureBox1.Image = Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()

            End Try
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtCity.Clear()
        txtContact.Clear()
        txtEmail.Clear()
        txtdob.Clear()
        txtEmpId.Clear()
        txtEname.Clear()
        txtEFname.Clear()
        txtPin.Clear()
        txtSalary.Clear()
        richtxtAddress.Clear()
        txtDesig.Clear()
        txtBGroup.Clear()
        txtGender.Clear()
        txtJDate.Clear()
        txtQuali.Clear()
        txtSearch.Clear()
        PictureBox1.Image = Nothing
    End Sub
End Class