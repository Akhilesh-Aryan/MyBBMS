Public Class RegDonorTxnReport

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub RegDonorTxnReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MdiParent = Dashboard

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        'TODO: This line of code loads data into the 'MyBBMSDataSet6.txnToDonor' table. You can move, or remove it, as needed.
        Me.TxnToDonorTableAdapter.Fill(Me.MyBBMSDataSet6.txnToDonor)
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As Bitmap
        bm = New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm, New Rectangle(60, 60, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()
    End Sub
End Class