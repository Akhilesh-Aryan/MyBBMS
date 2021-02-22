Imports System.Data
Imports System.Data.SqlClient
Public Class UpdateDonor
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Dashboard.Show()

    End Sub

    Private Sub UpdateDonor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Dashboard

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtid.ResetText()
        txtdName.ResetText()
        txtAge.ResetText()
        txtPhone.ResetText()
        txtEmail.ResetText()
        txtbWeight.ResetText()
        txtTemp.ResetText()
        txtBp.ResetText()
        txtPrate.ResetText()
        txtHemo.ResetText()
        txtWtBag.ResetText()
        txtSearchName.ResetText()
        txtOccu.ResetText()
        txtFname.ResetText()
        richtxtAddress.ResetText()
        txtBGroup.ResetText()
        txtLDdate.Clear()
        txtGender.Clear()
        txtSearchMob.Clear()
        txtTests.Clear()
        txtMstatus.Clear()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT * FROM [dbo].[Donors] WHERE Donor_Name = '" & txtSearchName.Text & "' And Contact = '" & txtSearchMob.Text & "'"
            cmd = New SqlCommand(query, con)
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                txtid.Text = dr("Id")
                txtdName.Text = dr("Donor_Name")
                txtFname.Text = dr("FatherName")
                richtxtAddress.Text = dr("Address")
                txtAge.Text = dr("Age")
                txtGender.Text = dr("Gender")
                txtPhone.Text = dr("Contact")
                txtMstatus.Text = dr("MaritalStatus")
                txtBGroup.Text = dr("BloodGroup")
                txtOccu.Text = dr("Occupation")
                txtEmail.Text = dr("Email")
                txtLDdate.Text = dr("Last_DonateDate")
                txtbWeight.Text = dr("BodyWeight")
                txtTemp.Text = dr("Temperature")
                txtBp.Text = dr("BloodPressure")
                txtPrate.Text = dr("PulseRate")
                txtHemo.Text = dr("Hemoglobin")
                txtWtBag.Text = dr("WtOfBag")
                txtTests.Text = dr("TestPositive")
            Else
                MessageBox.Show("Sorry ! Record not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()

            query = "DELETE FROM [dbo].[Donors] WHERE Donor_Name = '" & txtSearchName.Text & "' And Contact = '" & txtSearchMob.Text & "'"
            If txtGender.Text <> "" Then
                cmd = New SqlCommand(query, con)
                If MessageBox.Show("Are you sure want to delete this records", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    cmd.ExecuteNonQuery()
                    MessageBox.Show(" Record Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtid.ResetText()
                    txtdName.ResetText()
                    txtAge.ResetText()
                    txtPhone.ResetText()
                    txtEmail.ResetText()
                    txtbWeight.ResetText()
                    txtTemp.ResetText()
                    txtBp.ResetText()
                    txtPrate.ResetText()
                    txtHemo.ResetText()
                    txtWtBag.ResetText()
                    txtSearchName.ResetText()
                    txtOccu.ResetText()
                    txtFname.ResetText()
                    richtxtAddress.ResetText()
                    txtBGroup.ResetText()
                    txtLDdate.Clear()
                    txtGender.Clear()
                    txtSearchMob.Clear()
                    txtTests.Clear()
                    txtMstatus.Clear()

                End If
            Else
                MessageBox.Show(" Records, You trying to delete is no longer available |                                 Please search record to procced !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "UPDATE [dbo].[Donors] SET [Donor_Name] = '" & txtdName.Text & "', [FatherName]= '" & txtFname.Text & "', [Address] = '" & richtxtAddress.Text & "',[Age] = '" & txtAge.Text & "',[MaritalStatus] = '" & txtMstatus.Text & "',[BloodGroup] = '" & txtBGroup.Text & "',[Occupation] = '" & txtOccu.Text & "',[Email] = '" & txtEmail.Text & "',[Last_DonateDate] = '" & txtLDdate.Text & "',[BodyWeight] = '" & txtbWeight.Text & "',[Temperature] = '" & txtTemp.Text & "',[BloodPressure] = '" & txtBp.Text & "',[PulseRate] = '" & txtPrate.Text & "',[Hemoglobin] = '" & txtHemo.Text & "',[WtOfBag] = '" & txtWtBag.Text & "',[TestPositive] = '" & txtTests.Text & "' WHERE [Donor_Name] = '" & txtSearchName.Text & "' And [Contact] = '" & txtSearchMob.Text & "'"
            cmd = New SqlCommand(query, con)
            Dim res As Integer
            res = cmd.ExecuteNonQuery
            If res > 0 Then
                MessageBox.Show("Record Updated Successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txtid.ResetText()
                txtdName.ResetText()
                txtAge.ResetText()
                txtPhone.ResetText()
                txtEmail.ResetText()
                txtbWeight.ResetText()
                txtTemp.ResetText()
                txtBp.ResetText()
                txtPrate.ResetText()
                txtHemo.ResetText()
                txtWtBag.ResetText()
                txtSearchName.ResetText()
                txtOccu.ResetText()
                txtFname.ResetText()
                richtxtAddress.ResetText()
                txtBGroup.ResetText()
                txtLDdate.Clear()
                txtGender.Clear()
                txtSearchMob.Clear()
                txtTests.Clear()
                txtMstatus.Clear()

            Else
                MessageBox.Show("Worng input", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()

        End Try
    End Sub

End Class