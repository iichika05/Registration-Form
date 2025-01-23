Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports RegistrationFormV2.AdminDashboard

Public Class Login
    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim connection As New SqlConnection("Server = IICHIKA味の素; Database = Data2; Integrated Security = true")
        Dim command As New SqlCommand("SELECT * FROM usersaccounts2 WHERE username = @username AND password = @password", connection)

        command.Parameters.Add("@username", SqlDbType.NVarChar).Value = tb_username.Text
        command.Parameters.Add("@password", SqlDbType.NVarChar).Value = tb_password.Text

        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then
            MessageBox.Show("Username or Password are Invalid.")
        Else
            'admin login will not work if ang database username and password cridentials -
            'values doesn't exist in the actual database value
            If tb_username.Text = "Admin" AndAlso tb_password.Text = "Admin123" Or
               tb_username.Text = "Admin2" AndAlso tb_password.Text = "Admin1234" Or
               tb_username.Text = "Admin3" AndAlso tb_password.Text = "Admin12345" Then
                MessageBox.Show("Admin Login Successful!")
                Me.Hide()
                AdminDashboard.ShowDialog() ' Admin-specific form
                Me.Close()

            Else
                MessageBox.Show("Login Successful!") ' Normal users
                Me.Hide()


                'Dim userDashboard As New UserDashboard()
                UserDashboard.ShowDialog()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.ShowInTaskbar = False
        Me.Hide()

        Dim SignUp As New SignUp
        SignUp.ShowDialog()
        Me.Close()
    End Sub
End Class