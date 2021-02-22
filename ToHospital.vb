Imports System.Data
Imports System.Data.SqlClient

Public Class ToHospital
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub ToHospital_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Dashboard

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT * FROM [dbo].[Hospitals] WHERE HospitalID = '" & txtHIDSBox.Text & "'"
            cmd = New SqlCommand(query, con)
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                txtHIDSBox.Text = dr("HospitalID")
                txtHName.Text = dr("HospitalName")
                richtxtAddress.Text = dr("Address")
                txtCity.Text = dr("HCity")
                txtPin.Text = dr("HPinCode")
                txtPhone.Text = dr("HPhoneNo")

            Else
                MessageBox.Show("Sorry ! Record not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click

        If txtCity.Text = "" Or richtxtAddress.Text = "" Or txtHIDSBox.Text = "" Or txtHName.Text = "" Or txtPhone.Text = "" Or txtPin.Text = "" Or ComboBox1.SelectedItem = "" Or ComboBox2.SelectedItem = "" Or ComboBox3.SelectedItem = "" Or ComboBox5.SelectedItem = "" Or ComboBox4.SelectedItem = "" Or txtNoOfBags.Text = "" Then
            MessageBox.Show("Every fields are required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim txnDate As String
            txnDate = ComboBox1.SelectedItem + " / " + ComboBox2.SelectedItem + " / " + ComboBox3.SelectedItem

            Dim totalPrice As String
            totalPrice = (txtNoOfBags.Text * ComboBox5.SelectedItem)

            Try
                con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                con.Open()
                query = "INSERT INTO [dbo].[txnToHospital] VALUES('" & txtTxnNo.Text & "','" & txtHIDSBox.Text & "', '" & txtHName.Text & "','" & richtxtAddress.Text & "','" & txtCity.Text & "','" & txtPin.Text & "' , '" & txtPhone.Text & "' , '" & txnDate & "' , '" & ComboBox4.SelectedItem & "', '" & Label15.Text & "', '" & txtNoOfBags.Text & "', '" & ComboBox5.SelectedItem & "' , '" & totalPrice & "')"
                cmd = New SqlCommand(query, con)
                If txtNoOfBags.Text > Label15.Text Then
                    MessageBox.Show("Please enter No Of Bags less than Stocks left ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Else

                    If cmd.ExecuteNonQuery() Then
                        MessageBox.Show("Txn Saved Successfully! Please Click on ( Generate Slip ) to  get Transaction Slip  ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                        query = "UPDATE TOP (" & Val(txtNoOfBags.Text) & ") [dbo].[newBloodBag] SET [status] = '" & 1 & "' WHERE [BloodGroup] = '" & ComboBox4.SelectedItem & "' And [status] = " & 0 & ""

                        cmd = New SqlCommand(query, con)
                        cmd.ExecuteNonQuery()
                        txtCity.Clear()
                        txtHIDSBox.Clear()
                        txtNoOfBags.Clear()
                        Label15.ResetText()
                        txtTxnNo.Clear()
                        txtHName.Clear()
                        txtPhone.Clear()
                        txtPin.Clear()
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