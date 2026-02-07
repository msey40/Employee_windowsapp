Imports MySql.Data.MySqlClient
Public Class empForm
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()

    End Sub
    Sub loadEmpData()
        dgvEmp.Rows.Clear()
        dgvEmp.AutoGenerateColumns = False

        Using conn As MySqlConnection = getDBConnection()
            conn.Open()

            Dim cmd As New MySqlCommand(
            "SELECT emp_id, emp_name, emp_position, emp_dob, emp_gender, salary, emp_phone, create_at FROM tblemployee",
            conn)

            Using reader As MySqlDataReader = cmd.ExecuteReader()
                Dim i As Integer = 1
                While reader.Read()
                    ' Format DOB

                    dgvEmp.Rows.Add(
                    i,                          ' Column 0: No
                    reader("emp_name"),         ' Column 1
                    reader("emp_position"),     ' Column 2
                   Format(reader("salary"), "N2"),           ' Column 5
                   Format(reader("emp_dob"), "yyyy-mm-dd"),          ' Column 3
                    reader("emp_gender"),       ' Column 4
                    reader("emp_phone"),        ' Column 6
                   reader("create_at")        ' Column 7
)
                    i += 1
                End While
            End Using
        End Using
    End Sub
    Sub ClearInputs()
        txtID.Clear()
        txtName.Clear()
        txtPosition.Clear()
        txtSa.Clear()
        txtPh.Clear()
        rdoMen.Checked = False
        rdoWomen.Checked = False
        dtpDob.Value = Date.Today
    End Sub




    Private Sub empForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadEmpData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If txtName.Text = "" Or txtPosition.Text = "" Then
            MessageBox.Show(" Please fill in all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Try
            Dim gender As String = ""
            If rdoMen.Checked Then
                gender = "Men"
            ElseIf rdoWomen.Checked Then
                gender = "Women"
            Else
                MessageBox.Show(" Please Select Gender")
                Exit Sub
            End If


            Using conn As MySqlConnection = getDBConnection()
                conn.Open()
                Dim empquery As String = "INSERT INTO tblemployee (emp_name, emp_position,salary, emp_dob, emp_gender, emp_phone, create_at)" &
                                     "VALUES (@name, @position, @salary, @dob, @gender, @phone, NOW())"
                Using cmd As New MySqlCommand(empquery, conn)
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                    cmd.Parameters.AddWithValue("@position", txtPosition.Text.Trim())
                    cmd.Parameters.AddWithValue("@salary", Decimal.Parse(txtSa.Text.Trim()))
                    cmd.Parameters.AddWithValue("@dob", dtpDob.Value.Date)
                    cmd.Parameters.AddWithValue("@gender", gender)
                    cmd.Parameters.AddWithValue("@phone", txtPh.Text.Trim())

                    cmd.ExecuteNonQuery()

                End Using
            End Using

            MessageBox.Show(" Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show(" Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            MessageBox.Show(" Employee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            dgvEmp.Rows.Clear()
            loadEmpData()
            ClearInputs()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputs()
    End Sub
End Class