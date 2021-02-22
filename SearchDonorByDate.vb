Imports System.Data
Imports System.Data.SqlClient
Public Class SearchDonorByDate
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim ds As New DataSet
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()

    End Sub

    Private Sub SearchDonorByDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'MyBBMSDataSet3.Donors' table. You can move, or remove it, as needed.
        Me.DonorsTableAdapter.Fill(Me.MyBBMSDataSet3.Donors)
        Me.MdiParent = Dashboard

    End Sub

    Private Sub btnSearchByDate_Click(sender As Object, e As EventArgs)

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub txtSearchByDate_TextChanged(sender As Object, e As EventArgs) Handles txtSearchByDate.TextChanged
        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT * FROM Donors WHERE Last_DonateDate LIKE '%" & txtSearchByDate.Text & "%' "
            da = New SqlDataAdapter(query, con)
            da.Fill(ds, "Donors")
            DataGridView1.DataSource = ds
            DataGridView1.DataMember = "Donors"

        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As Bitmap
        bm = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(60, 60, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()
    End Sub
End Class