Imports System.Data
Imports System.Data.SqlClient
Public Class ToRegisteredDonor
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT * FROM [dbo].[Donors] WHERE  Donor_Name= '" & txtDName.Text & "' AND FatherName = '" & txtFName.Text & "'"
            cmd = New SqlCommand(query, con)
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                txtDName.Text = dr("Donor_Name")
                txtFName.Text = dr("FatherName")
                richtxtAddress.Text = dr("Address")
                txtGender.Text = dr("Gender")
                txtEmail.Text = dr("Email")
                txtPhone.Text = dr("Contact")

            Else
                MessageBox.Show("Sorry ! Record not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub ToRegisteredDonor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Dashboard

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click


        If txtGender.Text = "" Or richtxtAddress.Text = "" Or txtDName.Text = "" Or txtFName.Text = "" Or txtPhone.Text = "" Or txtEmail.Text = "" Or ComboBox1.SelectedItem = "" Or ComboBox2.SelectedItem = "" Or ComboBox3.SelectedItem = "" Or ComboBox5.SelectedItem = "" Or ComboBox4.SelectedItem = "" Or txtNoOfBags.Text = "" Then
            MessageBox.Show("Every fields are required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim txnDate As String
            txnDate = ComboBox1.SelectedItem + " / " + ComboBox2.SelectedItem + " / " + ComboBox3.SelectedItem

            Dim totalPrice As String
            totalPrice = (txtNoOfBags.Text * ComboBox5.SelectedItem)

            Try
                con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                con.Open()
                query = "INSERT INTO [dbo].[txnToDonor] VALUES('" & txtTxnNo.Text & "','" & txtDName.Text & "', '" & txtFName.Text & "','" & richtxtAddress.Text & "','" & txtGender.Text & "','" & txtEmail.Text & "' , '" & txtPhone.Text & "' , '" & txnDate & "' , '" & ComboBox4.SelectedItem & "', '" & Label15.Text & "', '" & txtNoOfBags.Text & "', '" & ComboBox5.SelectedItem & "' , '" & totalPrice & "')"
                cmd = New SqlCommand(query, con)
                If txtNoOfBags.Text > Label15.Text Then
                    MessageBox.Show("Please enter No Of Bags less than Stocks left ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    If cmd.ExecuteNonQuery() Then
                        MessageBox.Show("Transaction Saved Successfully! Proceed to Generate Transaction Slip ! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        query = "UPDATE TOP (" & Val(txtNoOfBags.Text) & ") [dbo].[newBloodBag] SET [status] = '" & 1 & "' WHERE [BloodGroup] = '" & ComboBox4.SelectedItem & "' And [status] = " & 0 & ""

                        cmd = New SqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                        txtGender.Clear()
                        txtDName.Clear()
                        txtNoOfBags.Clear()
                        Label15.ResetText()
                        txtTxnNo.Clear()
                        txtFName.Clear()
                        txtPhone.Clear()
                        txtEmail.Clear()
                        richtxtAddress.Clear()
                        HospitalTxnSlip.Show()
                    Else
                        MessageBox.Show("Transaction Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("Transaction No already exists ! Please try another ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()

            End Try
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT  COUNT(BloodGroup) FROM [dbo].[newBloodBag] WHERE [BloodGroup] = '" & ComboBox4.SelectedItem & "' And [status] = " & 0 & ""
            cmd = New SqlCommand(query, con)
            Dim count = Convert.ToString(cmd.ExecuteScalar)
            Label15.Text = count
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()

        End Try
    End Sub
End Class