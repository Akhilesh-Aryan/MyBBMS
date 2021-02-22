
Public Class ShowAllEmployee
  
    Dim bm As Bitmap
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()

    End Sub

    Private Sub ShowAllEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        Me.MdiParent = Dashboard

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'TODO: This line of code loads data into the 'MyBBMSDataSet3.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.MyBBMSDataSet3.Employee)

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        bm = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(60, 60, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()

    End Sub
End Class