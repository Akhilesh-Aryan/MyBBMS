Imports System.Data
Imports System.Data.SqlClient


' This is for Sms Api system
Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text


Public Class HospitaIDetails
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim query As String

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()

    End Sub

    Private Sub HospitaIDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = Dashboard

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If txtCity.Text = "" Or richtxtAddress.Text = "" Or txtHID.Text = "" Or txtHName.Text = "" Or txtPhone.Text = "" Or txtPin.Text = "" Then
            MessageBox.Show("Every fields is required ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                con = New SqlConnection("Data Source=DESKTOP-DR2EJ9Q;Initial Catalog=MyBBMS;Integrated Security=True")
                con.Open()
                query = "INSERT INTO [dbo].[Hospitals] VALUES('" & txtHID.Text & "', '" & txtHName.Text & "','" & richtxtAddress.Text & "','" & txtCity.Text & "','" & txtPin.Text & "' , '" & txtPhone.Text & "')"
                cmd = New SqlCommand(query, con)
                If cmd.ExecuteNonQuery() Then
                    MessageBox.Show("Record Inserted Successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    ' Yahn Par SMS API ka work ho rha hai 
                    Dim apikey = "XNlKmj2Ur2E-GuxDI2Fi3CNSWM7n4Pyt1Z7YscPJFz"
                    Dim message = "Hey there! We are from Purnia Blood Bank Your Hospital's Registration is Done. Thank You!"
                    Dim numbers = txtPhone.Text
                    Dim strGet As String
                    Dim senderName = "TXTLCL"
                    Dim url As String = "https://api.textlocal.in/send/?"

                    strGet = url + "apikey=" + apikey _
                       + "&numbers=" + numbers _
                     + "&message=" + WebUtility.UrlEncode(message) _
                     + "&sender=" + senderName

                    Dim webClient As New System.Net.WebClient
                    Dim result As String = webClient.DownloadString(strGet)
                    ' MessageBox.Show(result, "information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Return result

                    'yahn pr khatam 


                    txtCity.Clear()
                    txtHID.Clear()
                    txtHName.Clear()
                    txtPhone.Clear()
                    txtPin.Clear()
                    richtxtAddress.Clear()

                Else
                    MessageBox.Show("Data Insertion Failed ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            Finally
                con.Close()

            End Try
        End If
    End Sub
End Class