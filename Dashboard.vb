Imports System.Data
Imports System.Data.SqlClient

Public Class Dashboard
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String
    Dim da As SqlDataAdapter
    Dim dr As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Application.Exit()

    End Sub

    Private Sub AddUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUserToolStripMenuItem.Click
        AddNewUser.Show()

    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Hide()

        Form1.Show()

    End Sub


    Private Sub AddNewDonorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewDonorToolStripMenuItem.Click
        AddNewDonor.Show()
    End Sub

    Private Sub AddNewHospitalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewHospitalToolStripMenuItem.Click
        HospitaIDetails.Show()

    End Sub

    Private Sub UpdateDetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateDetailsToolStripMenuItem1.Click
        UpdateDonor.Show()

    End Sub

    Private Sub SearchByLocationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SearchByLocationToolStripMenuItem1.Click
        SearchDonorByLocation.Show()
    End Sub

    Private Sub ShowAllDonorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllDonorToolStripMenuItem.Click
        ShowAllDonor.Show()

    End Sub

    Private Sub ByDonateDateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByDonateDateToolStripMenuItem.Click
        SearchDonorByDate.Show()

    End Sub

    Private Sub AddMoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddMoreToolStripMenuItem.Click
        BloodBag.Show()

    End Sub

    Private Sub ByToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ByToolStripMenuItem.Click
        SearchByBloodGroup.Show()

    End Sub

    Private Sub UpdateBagDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateBagDetailsToolStripMenuItem.Click
        UpdateBloodBag.Show()

    End Sub

    Private Sub StockDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StockDetailsToolStripMenuItem.Click
        ShowStockDetails.Show()

    End Sub

    Private Sub ShowAllHospitalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllHospitalsToolStripMenuItem.Click
        ShowAllHospital.Show()

    End Sub

    Private Sub UpdateUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateUserToolStripMenuItem.Click
        UpdateUser.Show()

    End Sub

    Private Sub ShowAllUsersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllUsersToolStripMenuItem.Click
        ShowAllUser.Show()

    End Sub


    Private Sub AddNewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewToolStripMenuItem.Click
        AddNewEmployee.Show()

    End Sub

    Private Sub UpdateDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateDetailsToolStripMenuItem.Click
        UpdateEmployee.Show()

    End Sub

    Private Sub ShowAllEmployeeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAllEmployeeToolStripMenuItem.Click
        ShowAllEmployee.Show()

    End Sub


    Private Sub UpdateHospitalDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateHospitalDetailsToolStripMenuItem.Click
        Update_DeleteHospital.Show()

    End Sub

    Private Sub ToHospitalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToHospitalToolStripMenuItem.Click
        ToHospital.Show()

    End Sub

    Private Sub HospitalTransactionReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HospitalTransactionReportToolStripMenuItem.Click
        HospitalTxnReport.Show()

    End Sub

    Private Sub GenerateTxnSlipToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateTxnSlipToolStripMenuItem.Click
        HospitalTxnSlip.Show()

    End Sub

    Private Sub ToRegisteredDonorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ToRegisteredDonorToolStripMenuItem.Click
        ToRegisteredDonor.Show()

    End Sub

    Private Sub RegisteredDonorTransactionREportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RegisteredDonorTransactionREportToolStripMenuItem.Click
        RegDonorTxnReport.Show()
    End Sub

    Private Sub GenerateTxnSlipsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateTxnSlipsToolStripMenuItem.Click
        RegDonorTxnSlip.Show()

    End Sub

    Private Sub EmployeeSalaryTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeSalaryTransactionToolStripMenuItem.Click
        EmployeeSalary.Show()

    End Sub

    Private Sub EmployeeSalaryTransactonReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeSalaryTransactonReportToolStripMenuItem.Click
        EmpSalaryTnxReport.Show()

    End Sub

    Private Sub GenerateTransactionSlipsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerateTransactionSlipsToolStripMenuItem.Click
        EmpSalarySlip.Show()

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT  COUNT(*) FROM [dbo].[Donors]"
            cmd = New SqlCommand(query, con)
            Dim count = Convert.ToString(cmd.ExecuteScalar)
            Label3.Text = count
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()

        End Try


        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT  COUNT(*) FROM [dbo].[Hospitals]"
            cmd = New SqlCommand(query, con)
            Dim count1 = Convert.ToString(cmd.ExecuteScalar)
            Label7.Text = count1
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()

        End Try


        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT  COUNT(BloodGroup) FROM [dbo].[newBloodBag] WHERE [status] = " & 0 & ""
            cmd = New SqlCommand(query, con)
            Dim count2 = Convert.ToString(cmd.ExecuteScalar)
            Label5.Text = count2
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()

        End Try


        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT  COUNT(BloodGroup) FROM [dbo].[newBloodBag] WHERE [status] = " & 1 & ""
            cmd = New SqlCommand(query, con)
            Dim count3 = Convert.ToString(cmd.ExecuteScalar)
            Label1.Text = count3
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()

        End Try

    End Sub

    Private Sub RefreshDashboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshDashboardToolStripMenuItem.Click
        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT  COUNT(*) FROM [dbo].[Donors]"
            cmd = New SqlCommand(query, con)
            Dim count = Convert.ToString(cmd.ExecuteScalar)
            Label3.Text = count
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()

        End Try

        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT  COUNT(*) FROM [dbo].[Hospitals]"
            cmd = New SqlCommand(query, con)
            Dim count1 = Convert.ToString(cmd.ExecuteScalar)
            Label7.Text = count1
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()

        End Try


        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT  COUNT(BloodGroup) FROM [dbo].[newBloodBag] WHERE [status] = " & 0 & ""
            cmd = New SqlCommand(query, con)
            Dim count2 = Convert.ToString(cmd.ExecuteScalar)
            Label5.Text = count2
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()

        End Try


        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT  COUNT(BloodGroup) FROM [dbo].[newBloodBag] WHERE [status] = " & 1 & ""
            cmd = New SqlCommand(query, con)
            Dim count3 = Convert.ToString(cmd.ExecuteScalar)
            Label1.Text = count3
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()

        End Try

    End Sub
End Class