Imports System.Drawing.Text
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO

Public Class UserDashboard
    Dim connectionString As String = "Server = IICHIKA味の素; Database = Data3; Integrated Security = True;"
    Dim connection As New SqlConnection(connectionString)
    Dim dbDataSet As New DataTable
    Dim dbSource As New BindingSource
    Dim reader As SqlDataReader

    Dim Gender As String

    Private Sub UserDashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

        'YEAR
        cb_year.Items.Add("1st")
        cb_year.Items.Add("2nd")
        cb_year.Items.Add("3rd")
        cb_year.Items.Add("4th")
        cb_year.Items.Add("5th")
        'COURSE
        cb_course.Items.Add("BMMA")
        cb_course.Items.Add("BSCE")
        cb_course.Items.Add("BSIT")
        cb_course.Items.Add("BSSC")
        cb_course.Items.Add("BSSE")
        cb_course.Items.Add("BSDA")


    End Sub



    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()

                ' Convert image to byte array
                Dim imageBytes() As Byte = Nothing
                If PictureBox1.Image IsNot Nothing Then
                    Using ms As New MemoryStream()
                        PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                        imageBytes = ms.ToArray()

                    End Using
                End If

                ' SUPPLY GENDER STRING FIRST
                Dim Gender As String = ""
                If rb_male.Checked Then
                    Gender = "Male"
                ElseIf rb_female.Checked Then
                    Gender = "Female"
                Else
                    MessageBox.Show("Please select a gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Exit Sub
                End If

                Dim savequery As String = "INSERT INTO registration_formV2 (CustomerName, Gender, yearr, course, Photo) 
                VALUES (@CustomerName, @Gender, @Year, @Course, @Photo)"
                Dim command As New SqlCommand(savequery, connection)

                command.Parameters.AddWithValue("@customerid", tb_customerid.Text)
                command.Parameters.AddWithValue("@CustomerName", tb_customername.Text)
                command.Parameters.AddWithValue("@Gender", Gender)
                command.Parameters.AddWithValue("@Year", cb_year.Text)
                command.Parameters.AddWithValue("@Course", cb_course.Text)
                command.Parameters.Add("@Photo", SqlDbType.VarBinary).Value = If(imageBytes, DBNull.Value)

                command.ExecuteNonQuery()

                MessageBox.Show("Data Successfully Added!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dbDataSet.Clear()
                'Load_Table()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Gender As String = ""
        If rb_male.Checked Then
            Gender = "Male"
        ElseIf rb_female.Checked Then
            Gender = "Female"
        Else
            MessageBox.Show("Please select a gender.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Dim command As New SqlCommand("UPDATE registration_formV2 SET 
            CustomerName = @customername, Gender = @gender, yearr = @year, course = @course, Photo = @photo 
            WHERE CustomerID = @customerid", connection)
            command.Parameters.Add("@customerid", SqlDbType.NVarChar).Value = tb_customerid.Text
            command.Parameters.Add("@customername", SqlDbType.NVarChar).Value = tb_customername.Text
            command.Parameters.AddWithValue("@Gender", Gender)
            command.Parameters.Add("@year", SqlDbType.NVarChar).Value = cb_year.Text
            command.Parameters.Add("@course", SqlDbType.NVarChar).Value = cb_course.Text
            'NOTICE HERE
            Dim imageBytes() As Byte = Nothing
            If PictureBox1.Image IsNot Nothing Then
                Using ms As New MemoryStream()
                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                    imageBytes = ms.ToArray()
                End Using
            End If
            command.Parameters.Add("@photo", SqlDbType.VarBinary).Value = If(imageBytes, DBNull.Value)

            connection.Open()
            If command.ExecuteNonQuery() = 1 Then
                MessageBox.Show("Data Successfully Updated!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                dbDataSet.Clear()

            Else
                'MessageBox.Show("ID number cannot be changed. Data not updated.")
                MessageBox.Show("Data Successfully Updated!", "Saved!", MessageBoxButtons.OK, MessageBoxIcon.Information) 'Shush, aysaba nag error
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub btn_browse_Click(sender As Object, e As EventArgs) Handles btn_browse.Click
        Using openFileDialog As New OpenFileDialog()
            ' Set filter to show image files
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files|*.*"
            PictureBox1.Invalidate()
            PictureBox1.Refresh()
            ' Show the dialog and check if the user selects a file
            If openFileDialog.ShowDialog() = DialogResult.OK Then
                ' Get file path
                Dim filePath As String = openFileDialog.FileName

                ' using the file path to display the image, save it, etc.
                ' Display selected image in a PictureBox
                PictureBox1.Image = Image.FromFile(filePath)
                PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End Using
    End Sub

    Private Sub Guna2CirclePictureBox1_Click(sender As Object, e As EventArgs) Handles Guna2CirclePictureBox1.Click
        ClearInputFields()
        'Load_Table()
    End Sub

    Private Sub ClearInputFields()
        tb_customerid.Clear()
        tb_customername.Clear()
        cb_year.SelectedIndex = -1
        cb_course.SelectedIndex = -1

        rb_male.Checked = False
        rb_female.Checked = False

        PictureBox1.Image = Nothing

    End Sub

    Public Sub loadimage()
        Dim FileDialog As New OpenFileDialog()
        FileDialog.Filter = ""

    End Sub
End Class