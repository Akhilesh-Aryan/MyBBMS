Imports System.Data
Imports System.Data.SqlClient
Public Class UpdateBloodBag
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Dim query As String
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub UpdateBloodBag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyBBMSDataSet5.newBloodBag' table. You can move, or remove it, as needed.
        Me.NewBloodBagTableAdapter.Fill(Me.MyBBMSDataSet5.newBloodBag)
        Me.MdiParent = Dashboard

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT * FROM [dbo].[newBloodBag] WHERE BagID = '" & TextBox11.Text & "'"
            cmd = New SqlCommand(query, con)
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                Label5.Text = dr("SNo")
                txtBagId.Text = dr("BagID")
                TextBox11.Text = dr("BagID")
                txtCDate.Text = dr("CollectionDate")
                txtEDate.Text = dr("ExpiryDate")
                txtBGrouo.Text = dr("BloodGroup")
                txtunt.Text = dr("Units")
                txtEtdBy.Text = dr("EnteredBy")
                Me.NewBloodBagTableAdapter.Fill(Me.MyBBMSDataSet5.newBloodBag)
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

            query = "DELETE FROM [dbo].[newBloodBag] WHERE BagID = '" & TextBox11.Text & "'"
            If txtBagId.Text <> "" Then
                cmd = New SqlCommand(query, con)
                If MessageBox.Show("Are you sure want to delete this records", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    cmd.ExecuteNonQuery()
                    MessageBox.Show(" Record Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.NewBloodBagTableAdapter.Fill(Me.MyBBMSDataSet5.newBloodBag)
                    txtBagId.Clear()
                    txtBGrouo.Clear()
                    txtCDate.Clear()
                    txtEtdBy.Clear()
                    txtunt.Clear()
                    Label5.ResetText()
                    TextBox11.Clear()
                    txtEDate.Clear()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtBagId.Text = "" Or txtBGrouo.Text = "" Or txtCDate.Text = "" Or txtEDate.Text = "" Or txtEtdBy.Text = "" Or txtunt.Text = "" Then
            MessageBox.Show("Sorry Fields Cannot be Empty to Update Records !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                con.Open()
                query = "UPDATE [dbo].[newBloodBag] SET [BagID] = '" & txtBagId.Text & "',[BloodGroup] ='" & txtBGrouo.Text & "',[Units] = '" & txtunt.Text & "',[CollectionDate] ='" & txtCDate.Text & "', [ExpiryDate] = '" & txtEDate.Text & "', [EnteredBy] = '" & txtEtdBy.Text & "' WHERE [BagID] = '" & TextBox11.Text & "'"
                cmd = New SqlCommand(query, con)
                Dim res As Integer
                res = cmd.ExecuteNonQuery
                If res > 0 Then
                    MessageBox.Show("Record Updated Successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtBagId.Clear()
                    txtBGrouo.Clear()
                    txtCDate.Clear()
                    txtEtdBy.Clear()
                    txtunt.Clear()
                    Label5.ResetText()
                    TextBox11.Clear()
                    txtEDate.Clear()
                    Me.NewBloodBagTableAdapter.Fill(Me.MyBBMSDataSet5.newBloodBag)
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
End Class