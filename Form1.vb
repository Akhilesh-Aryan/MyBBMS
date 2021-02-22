Imports System.Data
Imports System.Data.SqlClient
Public Class Form1
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String
    Dim rd As SqlDataReader
    Dim userId As String
    Dim pass As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Login.Enabled = False
    End Sub

    Private Sub showHideShow_Click(sender As Object, e As EventArgs) Handles showHideShow.Click
        If showHideShow.Text = "" Then
            showHideShow.Text = "/"
            password.UseSystemPasswordChar = True
        Else
            showHideShow.Text = ""
            password.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked) Then
            Login.Enabled = True
        Else
            Login.Enabled = False
        End If
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        userId = username.Text
        pass = password.Text
        Try
            con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
            con.Open()
            query = "SELECT * FROM [dbo].[User] WHERE [UserName] = '" & userId & "' And [Password] = '" & pass & "'"
            cmd = New SqlCommand(query, con)
            rd = cmd.ExecuteReader

            If (rd.Read) Then
                If userId = rd("UserName") And pass = rd("Password") Then
                    Dashboard.Show()
                    username.Clear()
                    password.Clear()
                    CheckBox1.Checked = False
                    Me.Hide()
                Else
                    MessageBox.Show("Please Enter Valid username or password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Please Enter Valid username or password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            con.Close()

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub
End Class

