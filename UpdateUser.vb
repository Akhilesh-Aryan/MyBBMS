Imports System.Data
Imports System.Data.SqlClient
Public Class UpdateUser
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String
    Dim dr As SqlDataReader
    Dim search As String

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()

    End Sub

    Private Sub UpdateUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Dashboard

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        search = txtSearch.Text

        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT *FROM [dbo].[User] WHERE UserName = '" & search & "'"
            cmd = New SqlCommand(query, con)
            dr = cmd.ExecuteReader
            If (dr.Read) Then
                txtFname.Text = dr("FName")
                txtLname.Text = dr("LName")
                txtEmail.Text = dr("Email")
                txtGender.Text = dr("Gender")
                txtUsername.Text = dr("UserName")
                txtPassword.Text = dr("Password")
                txtCPassword.Text = dr("CPassword")
            Else
                MessageBox.Show("Sorry ! Record not Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        Finally
            con.Close()

        End Try


    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If txtCPassword.Text = "" Or txtEmail.Text = "" Or txtFname.Text = "" Or txtGender.Text = "" Or txtSearch.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Every Fields are mendatory please ensure none of fields are empty !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtCPassword.Text <> txtPassword.Text Then
            MessageBox.Show("Please Enter Same Password to continue", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                Try
                    con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                    con.Open()
                query = "UPDATE [dbo].[User] SET FName = '" & txtFname.Text & "',LName ='" & txtLname.Text & "',[Email] ='" & txtEmail.Text & "' ,[Gender] = '" & txtGender.Text & "',[UserName] = '" & txtUsername.Text & "',[Password] = '" & txtPassword.Text & "' ,[CPassword] = '" & txtCPassword.Text & "' WHERE [UserName] = '" & txtSearch.Text & "'"

                    cmd = New SqlCommand(query, con)
                    Dim res As Integer
                    res = cmd.ExecuteNonQuery
                    If res > 0 Then
                        MessageBox.Show("Record Updated Successfully !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCPassword.Clear()
                    txtEmail.Clear()
                    txtGender.Clear()
                    txtSearch.Clear()
                    txtPassword.Clear()
                    txtFname.Clear()
                    txtUsername.Clear()
                    txtLname.Clear()
                Else
                    MsgBox("Some Error Detcated")

                    End If
                Catch ex As Exception
                MessageBox.Show("Username already exists try different ! ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    con.Close()

                End Try
            End If
    End Sub

    Private Sub btnDeleteUser_Click(sender As Object, e As EventArgs) Handles btnDeleteUser.Click
        If txtCPassword.Text = "" Or txtEmail.Text = "" Or txtFname.Text = "" Or txtGender.Text = "" Or txtSearch.Text = "" Or txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("No record selected to delete!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            Try
                con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                con.Open()

                query = "DELETE FROM [dbo].[User] WHERE UserName = '" & txtSearch.Text & "'"
                cmd = New SqlCommand(query, con)
                If MessageBox.Show("Are you sure want to delete this records", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    cmd.ExecuteNonQuery()
                    MessageBox.Show(" Record Deleted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    txtCPassword.Clear()
                    txtEmail.Clear()
                    txtGender.Clear()
                    txtSearch.Clear()
                    txtPassword.Clear()
                    txtFname.Clear()
                    txtUsername.Clear()
                    txtLname.Clear()
                End If
            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()

            End Try
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtSearch.ResetText()
        txtFname.ResetText()
        txtCPassword.ResetText()
        txtEmail.ResetText()
        txtGender.ResetText()
        txtUsername.ResetText()
        txtLname.ResetText()
        txtPassword.ResetText()
    End Sub
End Class