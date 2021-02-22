Imports System.Data
Imports System.Data.SqlClient
Public Class EmployeeSalary
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String
    Dim dr As SqlDataReader
    Dim da As SqlDataAdapter
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()

    End Sub

    Private Sub EmployeeSalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Dashboard

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT * FROM [dbo].[Employee] WHERE EmpID = '" & txtEId.Text & "'"
            cmd = New SqlCommand(query, con)
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                txtEId.Text = dr("EmpID")
                txtEname.Text = dr("EmpName")
                txtJdate.Text = dr("Joining_Date")
                txtDesig.Text = dr("Designation")
                txtBpay.Text = dr("Salary")
                richtxtAddress.Text = dr("Address")
                txtEmail.Text = dr("Email")
                txtPhone.Text = dr("Contact")
                txtEmail.Text = dr("Email")
            Else
                MessageBox.Show("Sorry ! Record not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()

        End Try

    End Sub

    Private Sub btn_Save_Click(sender As Object, e As EventArgs) Handles btn_Save.Click
        Dim smonth As String
        Dim pdate As String
        Dim calculated As Single
        Dim onedaysalary As Single
        Dim gsalary As Single
        Dim netsalary As Single
        Dim deductions As Single
        pdate = DateTimePicker1.Value.Date
        onedaysalary = Val(txtBpay.Text) / 30
        calculated = (Val(txtADays.SelectedItem) * onedaysalary)
        gsalary = Val(txtBpay.Text) + Val(txtDA.Text) + Val(txtHRA.Text)
        deductions = Val(txtBpay.Text) - calculated
        netsalary = gsalary - deductions
        smonth = ComboBox2.SelectedItem + " " + ComboBox3.SelectedItem
        If txtTxnNo.Text = "" Or txtADays.SelectedItem = "" Or txtEId.Text = "" Or txtDA.Text = "" Or txtHRA.Text = "" Or ComboBox2.SelectedItem = "" Or ComboBox3.SelectedItem = "" Then
            MessageBox.Show("All the fields are compulsory please fill first! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                con.Open()
                query = "INSERT INTO [dbo].[EmpSalaryTnx] VALUES('" & txtTxnNo.Text & "', '" & txtEId.Text & "', '" & txtEname.Text & "', '" & txtDesig.Text & "', '" & richtxtAddress.Text & "', '" & txtEmail.Text & "', '" & txtPhone.Text & "', '" & smonth & "', '" & txtJdate.Text & "','" & txtBpay.Text & "', '" & txtADays.Text & "', '" & txtDA.Text & "', '" & txtHRA.Text & "', '" & gsalary & "', '" & deductions & "','" & netsalary & "' , '" & pdate & "')"
                cmd = New SqlCommand(query, con)
                If cmd.ExecuteNonQuery() Then
                    MessageBox.Show("Transection Record Saved Successfully! Proceed to Generate Transaction Slip.. ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtDA.Clear()
                    txtHRA.Clear()
                    txtDesig.Clear()
                    txtBpay.Clear()
                    txtEId.Clear()
                    txtEmail.Clear()
                    txtJdate.Clear()
                    txtEname.Clear()
                    txtPhone.Clear()
                    richtxtAddress.Clear()
                    txtTxnNo.Clear()
                    EmpSalarySlip.Show()

                Else
                    MessageBox.Show("Insertion Faild ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                MessageBox.Show("Transaction no already exists try another ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()

            End Try
        End If

    End Sub
End Class