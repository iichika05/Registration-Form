Imports System.Drawing.Text
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO

Public Class AdminDashboard

    Dim connectionString As String = "Server = IICHIKA味の素; Database = Data3; Integrated Security = True;"
    Dim connection As New SqlConnection(connectionString)
    Dim dbDataSet As New DataTable
    Dim dbSource As New BindingSource
    Dim reader As SqlDataReader

    Dim Gender As String

    'Search Filter Feature
    Private Sub FilterData(searchTerm As String)
        Try
            If dbDataSet.Rows.Count > 0 Then
                Dim dv As New DataView(dbDataSet)

                ' Clean search term
                searchTerm = searchTerm.Replace("'", "''") ' Handle single quotes in search term

                'RowFilter
                dv.RowFilter = $"[CustomerName] LIKE '%{searchTerm}%' OR " &
                           $"[Gender] LIKE '%{searchTerm}%' OR " &
                           $"[yearr] LIKE '%{searchTerm}%' OR " &
                           $"[course] LIKE '%{searchTerm}%'"
                DataGridView1.DataSource = dv
            Else
                'MessageBox.Show("No data available to filter.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show($"Filter Error: {ex.Message}")
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Data3DataSet.registration_formV2' table. You can move, or remove it, as needed.
        Me.Registration_formV2TableAdapter.Fill(Me.Data3DataSet.registration_formV2)

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

        Load_Table()
    End Sub

    Private Sub SortByLastName()
        DataGridView1.Sort(DataGridView1.Columns("CustomerID"), System.ComponentModel.ListSortDirection.Ascending)
        'DataGridView1.Sort(DataGridView1.Columns("firstname"), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Private Sub EnableSorting()
        For Each col As DataGridViewColumn In DataGridView1.Columns
            col.SortMode = DataGridViewColumnSortMode.Automatic
        Next
    End Sub

    Private Sub Load_Table()
        Using connection As New SqlConnection(connectionString)
            Try
                connection.Open()
                dbDataSet.Clear()
                Dim query As String = "SELECT CustomerID, CustomerName, Gender, yearr, course 
                FROM registration_formV2 ORDER BY CustomerID"
                Dim command As New SqlCommand(query, connection)
                Dim adapter As New SqlDataAdapter(command)

                adapter.Fill(dbDataSet)
                Debug.WriteLine($"Rows loaded: {dbDataSet.Rows.Count}")
                dbSource.DataSource = dbDataSet
                DataGridView1.DataSource = dbSource
                DataGridView1.AutoGenerateColumns = False

                'ConfigureDataGridViewColumns()
                For Each col As DataColumn In dbDataSet.Columns
                    Debug.WriteLine(col.ColumnName)
                Next

                SortByLastName()
                EnableSorting()

                'SortByFirstName()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
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
                ElseIf rb_Female.Checked Then
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
                Load_Table()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Using
    End Sub

    Private Sub configuredatagridviewcolumns()

        DataGridView1.Columns(0).HeaderText = "Customer ID"
        DataGridView1.Columns(0).Width = 50
        DataGridView1.Columns(0).Resizable = False

        DataGridView1.Columns(1).HeaderText = "Customer Name"
        DataGridView1.Columns(1).Width = 80
        DataGridView1.Columns(1).Resizable = False

        DataGridView1.Columns(2).HeaderText = "Gender"
        DataGridView1.Columns(2).Width = 80
        DataGridView1.Columns(2).Resizable = False

        DataGridView1.Columns(3).HeaderText = "Year"
        DataGridView1.Columns(3).Width = 50
        DataGridView1.Columns(3).Resizable = False

        DataGridView1.Columns(4).HeaderText = "Course"
        DataGridView1.Columns(4).Width = 60
        DataGridView1.Columns(4).Resizable = False

    End Sub

    Private Sub Guna2RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
        'Guna2RadioButton1.Checked = True
        Gender = "Male"
    End Sub

    Private Sub Guna2RadioButton2_CheckedChanged(sender As Object, e As EventArgs)
        'Guna2RadioButton2.Checked = True
        Gender = "Female"
    End Sub
    ' ---------------------------------------UPDATE BTN
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
                Load_Table()
            Else
                MessageBox.Show("ID number cannot be changed. Data not updated.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub

    Private Sub bt_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click


    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick

        DataGridView1.BeginEdit(True)

        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            tb_customerid.Text = selectedRow.Cells("customerid").Value.ToString()
            tb_customername.Text = selectedRow.Cells("customername").Value.ToString()

            Dim gender As String = selectedRow.Cells("gender").Value.ToString()

            'GENDER
            rb_male.Checked = False
            rb_female.Checked = False

            Dim course As String = selectedRow.Cells("course").Value.ToString()

            ' Retrieve and display image
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT Photo FROM registration_formV2 WHERE CustomerID = @CustomerID"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@CustomerID", tb_customerid.Text)

                Dim result As Object = command.ExecuteScalar()
                If result IsNot DBNull.Value AndAlso result IsNot Nothing Then
                    Dim imageBytes As Byte() = CType(result, Byte())
                    Using ms As New MemoryStream(imageBytes)
                        PictureBox1.Image = Image.FromStream(ms)
                    End Using
                Else
                    PictureBox1.Image = Nothing
                End If
            End Using

            'Sex
            Dim sex As String = selectedRow.Cells("gender").Value.ToString()
            If sex = "Male" Then
                rb_male.Checked = True
            Else
                rb_female.Checked = True
            End If

            cb_year.Text = selectedRow.Cells("yearr").Value.ToString()
            cb_course.Text = selectedRow.Cells("course").Value.ToString()

            ' Retrieve and display image
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query As String = "SELECT Photo FROM registration_formV2 WHERE CustomerID = @CustomerID"
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@CustomerID", tb_customerid.Text)

                Dim result As Object = command.ExecuteScalar()
                If result IsNot Nothing AndAlso result IsNot DBNull.Value Then
                    Dim imageBytes As Byte() = CType(result, Byte())
                    Using ms As New MemoryStream(imageBytes)
                        PictureBox1.Image = Image.FromStream(ms)
                    End Using
                Else
                    PictureBox1.Image = Nothing
                End If
            End Using
        End If
    End Sub

    Friend Class Data3DataSet2
        Public Sub New()
        End Sub
    End Class

    Friend Class Registration_Form
    End Class

    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click

        ClearInputFields()
        Load_Table()

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

    Private Sub tb_search_TextChanged(sender As Object, e As EventArgs) Handles tb_search.TextChanged
        FilterData(tb_search.Text)
    End Sub

    Private Sub Guna2PictureBox2_Click(sender As Object, e As EventArgs)
        FilterData(tb_search.Text)
    End Sub



    Private Sub btn_browse_Click_1(sender As Object, e As EventArgs) Handles btn_browse.Click
        'Private Sub btn_browse_Click(sender As Object, e As EventArgs)

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
        'End Sub
    End Sub


    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim connection As New SqlConnection(connectionString)

        Dim command As New SqlCommand("DELETE FROM registration_formV2 WHERE CustomerID = @customerid", connection)

        command.Parameters.Add("@customerid", SqlDbType.NVarChar).Value = tb_customerid.Text

        connection.Open()

        If command.ExecuteNonQuery() = 1 Then
            MessageBox.Show("Data Succesfully Deleted.")
            dbDataSet.Clear()
            Load_Table()
        Else
            MessageBox.Show("Data Unsuccesfully Deleted")
        End If
        connection.Close()
    End Sub

    Private Sub btn_register_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click

    End Sub

    Private Sub Guna2PictureBox2_Click_1(sender As Object, e As EventArgs) Handles Guna2PictureBox2.Click

    End Sub

    Private Sub Guna2HtmlLabel2_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel2.Click

    End Sub

    Private Sub Guna2HtmlLabel1_Click(sender As Object, e As EventArgs) Handles Guna2HtmlLabel1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btn_load_Click_1(sender As Object, e As EventArgs) Handles btn_load.Click

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub tb_search_TextChanged_1(sender As Object, e As EventArgs) Handles tb_search.TextChanged

    End Sub

    Private Sub cb_course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_course.SelectedIndexChanged

    End Sub

    Private Sub cb_year_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cb_year.SelectedIndexChanged

    End Sub

    Private Sub rb_female_CheckedChanged(sender As Object, e As EventArgs) Handles rb_female.CheckedChanged

    End Sub

    Private Sub rb_male_CheckedChanged(sender As Object, e As EventArgs) Handles rb_male.CheckedChanged

    End Sub

    Private Sub tb_customername_TextChanged(sender As Object, e As EventArgs) Handles tb_customername.TextChanged

    End Sub

    Private Sub tb_customerid_TextChanged(sender As Object, e As EventArgs) Handles tb_customerid.TextChanged

    End Sub

    Private Sub Guna2GradientPanel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2GradientPanel1.Paint

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
