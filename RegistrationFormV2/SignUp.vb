Imports System.Data.SqlClient
Imports System.IO
Imports RegistrationFormV2.AdminDashboard
Public Class SignUp
    Dim connectionString As String = "Server=IICHIKA味の素; Database=Data2; Integrated Security=true;"


    Private Sub Sign_Up_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cb_gender.Items.Add("Male")
        cb_gender.Items.Add("Female")
        cb_gender.Items.Add("Unidentified Object")

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.ShowInTaskbar = False
        Me.Hide()
        'Dim Register As New Registration_Form()
        Login.ShowDialog()

        Me.Close()
    End Sub

    Private Sub btn_signup_Click(sender As Object, e As EventArgs) Handles btn_signup.Click

        'Try
        'connection.Open()

        ' Convert image to byte array
        Dim imageBytes() As Byte = Nothing
        If PictureBox1.Image IsNot Nothing Then
            Using ms As New MemoryStream()
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                imageBytes = ms.ToArray()
            End Using
        End If
        'Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim connection As New SqlConnection(connectionString)
        Try
            connection.Open()
            Dim query As String = "INSERT INTO usersaccounts2 (firstname, lastname, birthday, gender, username, password, Photo) 
                VALUES (@firstname, @lastname, @birthday, @gender, @username, @password, @Photo)"
            Dim command As New SqlCommand(query, connection)

            'command.Parameters.AddWithValue("@id", tb_id.Text)
            command.Parameters.AddWithValue("@firstname", tb_firstname.Text)
            command.Parameters.AddWithValue("@lastname", tb_lastname.Text)
            command.Parameters.AddWithValue("@birthday", DateTimePicker1.Text)
            command.Parameters.AddWithValue("@gender", cb_gender.Text)
            command.Parameters.AddWithValue("@username", tb_username.Text)
            command.Parameters.AddWithValue("@password", tb_password.Text)
            command.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = If(imageBytes, DBNull.Value)
            command.ExecuteNonQuery()

            MsgBox("Successfully Added!", MsgBoxStyle.Information, "Save!")
            tb_firstname.Clear()
            DateTimePicker1.ResetText()
            tb_username.Clear()
            tb_password.Clear()
            tb_lastname.Clear()
            cb_gender.SelectedItem = 0
            connection.Close()
            Me.ShowInTaskbar = False
            Me.Hide()
            Dim login As New Login()
            login.ShowDialog()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            connection.Dispose()
        End Try
    End Sub
    Private Sub tb_firstname_TextChanged(sender As Object, e As EventArgs) Handles tb_firstname.TextChanged
    End Sub

    Private Sub Guna2PictureBox4_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox4.Click
        Using openFileDialog As New OpenFileDialog()
            ' Set the filter to show image files
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files|*.*"

            ' Show the dialog and check if the user selects a file
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Get the file path
                Dim filePath As String = openFileDialog.FileName

                ' You can now use the file path to display the image, save it, etc.
                ' Example: Display the selected image in a PictureBox
                PictureBox1.Image = Image.FromFile(filePath)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Using
    End Sub
End Class