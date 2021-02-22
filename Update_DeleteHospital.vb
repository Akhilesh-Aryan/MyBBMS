Imports System.Data
Imports System.Data.SqlClient
Public Class Update_DeleteHospital
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub Update_DeleteHospital_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Dashboard

    End Sub

    
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT * FROM [dbo].[Hospitals] WHERE HospitalID = '" & txtSearchBox.Text & "'"
            cmd = New SqlCommand(query, con)
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                txtHID.Text = dr("HospitalID")
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

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtCity.Text = "" Or txtSearchBox.Text = "" Or txtHID.Text = "" Or txtHName.Text = "" Or txtPin.Text = "" Or richtxtAddress.Text = "" Then
            MessageBox.Show("Please search Record to Update !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                con.Open()
                query = "UPDATE [dbo].[Hospitals] SET [HospitalID] = '" & txtHID.Text & "', [HospitalName]= '" & txtHName.Text & "', [Address] = '" & richtxtAddress.Text & "',[HCity] = '" & txtCity.Text & "',[HPinCode] = '" & txtPin.Text & "',[HPhoneNo] = '" & txtPhone.Text & "' WHERE [HospitalID] = '" & txtSearchBox.Text & "'"
                cmd = New SqlCommand(query, con)
                If cmd.ExecuteNonQuery Then
                    MessageBox.Show("Record Updated Successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCity.Clear()
                    txtHID.Clear()
                    txtHName.Clear()
                    txtPhone.Clear()
                    txtPin.Clear()
                    richtxtAddress.Clear()
                    txtSearchBox.Clear()

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

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtCity.Text = "" Or txtSearchBox.Text = "" Or txtHID.Text = "" Or txtHName.Text = "" Or txtPin.Text = "" Or richtxtAddress.Text = "" Then
            MessageBox.Show("Please search Record to Delete !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                con.Open()
                query = "DELETE FROM [dbo].[Hospitals] WHERE HospitalID = '" & txtSearchBox.Text & "'"
                cmd = New SqlCommand(query, con)
                If MessageBox.Show("Are you sure want to delete this records", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    cmd.ExecuteNonQuery()
                    MessageBox.Show(" Record Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCity.Clear()
                    txtHID.Clear()
                    txtHName.Clear()
                    txtPhone.Clear()
                    txtPin.Clear()
                    richtxtAddress.Clear()
                    txtSearchBox.Clear()

                End If
            Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()

        End Try
        End If

    End Sub
End Class