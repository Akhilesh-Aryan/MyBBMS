Imports System.Data
Imports System.Data.SqlClient

Public Class BloodBag
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()

    End Sub

    Private Sub BloodBag_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyBBMSDataSet5.newBloodBag' table. You can move, or remove it, as needed.
        Me.NewBloodBagTableAdapter.Fill(Me.MyBBMSDataSet5.newBloodBag)
        Me.MdiParent = Dashboard
    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Or ComboBox2.SelectedItem = "" Then
            MessageBox.Show("You cannot Submit Blank Form Please fill all the mendatory field to continue.. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                con.Open()
                query = "INSERT INTO [dbo].[newBloodBag]([BagID],[BloodGroup],[Units],[CollectionDate],[ExpiryDate],[EnteredBy],[status]) VALUES ('" & TextBox2.Text & "', '" & ComboBox2.SelectedItem & "','" & TextBox1.Text & "', '" & DateTimePicker1.Value.Date & "', '" & DateTimePicker2.Value.Date & "', '" & TextBox3.Text & "', '" & 0 & "')"
                cmd = New SqlCommand(query, con)
                If cmd.ExecuteNonQuery() Then
                    MessageBox.Show("Record Inserted Successfully! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.NewBloodBagTableAdapter.Fill(Me.MyBBMSDataSet5.newBloodBag)
                    DateTimePicker1.Value = DateAndTime.Now
                    DateTimePicker2.Value = DateAndTime.Now
                    TextBox2.Clear()
                    TextBox3.Clear()


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

  
End Class