Imports System.Data
Imports System.Data.SqlClient
Public Class AddNewUser

    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()

    End Sub

    Private Sub AddNewUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Dashboard

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fname As String
        Dim lname As String
        Dim email As String
        Dim gender As String = ""
        Dim uname As String
        Dim pass As String
        Dim cpass As String
        fname = txtFName.Text
        lname = txtLName.Text
        email = txtEmail.Text

        If RadioButton1.Checked Then
            gender = "Male"
        End If

        If RadioButton2.Checked Then
            gender = "Female"
        End If
        If RadioButton3.Checked Then
            gender = "Others"
        End If
        uname = txtUserName.Text
        pass = txtPassword.Text
        cpass = txtCPassword.Text
        If uname = "" Or pass = "" Or cpass = "" Or gender = "" Or email = "" Or lname = "" Or fname = "" Then
            MessageBox.Show("Every Fields are mendatory !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            Try
                con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                con.Open()
                query = "INSERT INTO [dbo].[User]([FName],[LName],[Email],[Gender],[UserName],[Password],[CPassword])VALUES('" & fname & "','" & lname & "', '" & email & "', '" & gender & "', '" & uname & "', '" & pass & "', '" & cpass & "')"
                cmd = New SqlCommand(query, con)
                If pass = cpass Then
                    Dim res As Integer
                    res = cmd.ExecuteNonQuery
                    If res > 0 Then
                        MessageBox.Show("Data Saved Successfully! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        txtFName.ResetText()
                        txtLName.ResetText()
                        txtCPassword.ResetText()
                        txtPassword.ResetText()
                        txtEmail.ResetText()
                        txtUserName.ResetText()

                    End If
                Else
                    MessageBox.Show("Please Enter Same Password! ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Catch ex As Exception
                MessageBox.Show("Username already exists! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                con.Close()

            End Try
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtFName.ResetText()
        txtLName.ResetText()
        txtCPassword.ResetText()
        txtPassword.ResetText()
        txtEmail.ResetText()
        txtUserName.ResetText()
    End Sub

End Class