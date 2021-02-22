Imports System.Data
Imports System.Data.SqlClient
Public Class EmpSalarySlip
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String
    Dim dr As SqlDataReader
    Dim bm As Bitmap

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If txtSBox.Text = "" Or txnNo.Text = "" Then
            MessageBox.Show("Please Search record by Transaction ID to Generate Slip  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                con.Open()
                query = "SELECT * FROM [dbo].[EmpSalaryTnx] WHERE TxnID = '" & txtSBox.Text & "'"
                cmd = New SqlCommand(query, con)
                dr = cmd.ExecuteReader
                If (dr.Read) Then
                    txnNo.Text = dr("TxnID")
                    empid.Text = dr("EmpID")
                    empName.Text = dr("EmpName")
                    address.Text = dr("Address")
                    email.Text = dr("Email")
                    mobile.Text = dr("PhoneNo")
                    smonth.Text = dr("SalaryMonth")
                    jdate.Text = dr("Joining_Date")
                    basicpay.Text = dr("Basic_Pay")
                    Adays.Text = dr("AttendedDays")
                    dA.Text = dr("DA")
                    hra.Text = dr("HRA")
                    gsalary.Text = dr("Gross_Salary")
                    deductions.Text = dr("Deductions")
                    netSalary.Text = dr("Net_Salary")
                    paymentDate.Text = dr("Payment_Date")

                Else
                    MessageBox.Show("Sorry ! Record not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            Finally
                con.Close()

            End Try
        End If
    End Sub

    Private Sub EmpSalarySlip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Dashboard

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()

    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        bm = New Bitmap(Me.Panel1.Width, Me.Panel1.Height)
        Panel1.DrawToBitmap(bm, New Rectangle(60, 60, Me.Panel1.Width, Me.Panel1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintPreviewDialog1.ShowDialog()
        PrintDocument1.Print()
    End Sub
End Class