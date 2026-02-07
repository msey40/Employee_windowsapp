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
                    dgvEmp.Rows.Add(
                    i,
                    reader("emp_name"),
                    reader("emp_position"),
                    Format(reader("salary"), "N2"),
                    Format(reader("emp_dob"), "yyyy-MM-dd"),
                    reader("emp_gender"),
                    reader("emp_phone"),
                    reader("create_at")
                )
                    i += 1
                    dgvEmp.Rows(dgvEmp.Rows.Count - 1).Tag = reader("emp_id")
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
        rdoMale.Checked = False
        rdoFemale.Checked = False
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
            If rdoMale.Checked Then
                gender = "Male"
            ElseIf rdoFemale.Checked Then
                gender = "Female"
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

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        ' Validation
        If String.IsNullOrEmpty(txtID.Text) Or String.IsNullOrEmpty(txtName.Text) Then
            MsgBox("Please select an employee to update.")
            Exit Sub
        End If

        If rdoMale.Checked = False And rdoFemale.Checked = False Then
            MsgBox("Please select gender")
            Exit Sub
        End If
        ' Assign gender
        Dim gender As String = If(rdoMale.Checked, "Male", "Female")

        ' Validate salary
        Dim salary As Decimal
        If Not Decimal.TryParse(txtSa.Text.Trim(), salary) Then
            MsgBox("Invalid salary format.")
            Exit Sub
        End If

        Try
            Using conn As MySqlConnection = getDBConnection()
                conn.Open()
                Dim updateQuery As String = "UPDATE tblemployee SET emp_name=@name, emp_position=@position, salary=@salary, emp_dob=@dob, emp_gender=@gender, emp_phone=@phone WHERE emp_id=@id"
                Using cmd As New MySqlCommand(updateQuery, conn)

                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(txtID.Text))
                    cmd.Parameters.AddWithValue("@name", txtName.Text.Trim())
                    cmd.Parameters.AddWithValue("@position", txtPosition.Text.Trim())
                    cmd.Parameters.AddWithValue("@salary", salary)
                    cmd.Parameters.AddWithValue("@dob", dtpDob.Value.ToString("yyyy-MM-dd"))
                    cmd.Parameters.AddWithValue("@gender", gender)
                    cmd.Parameters.AddWithValue("@phone", txtPh.Text.Trim())

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Employee updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            loadEmpData()
            ClearInputs()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub dgvEmp_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmp.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvEmp.Rows(e.RowIndex)



            txtID.Text = row.Tag.ToString()

            ' Fill textboxes
            txtName.Text = row.Cells("emp_name").Value.ToString()
            txtPosition.Text = row.Cells("emp_position").Value.ToString()
            txtSa.Text = row.Cells("salary").Value.ToString()
            txtPh.Text = row.Cells("emp_phone").Value.ToString()
            dtpDob.Value = Convert.ToDateTime(row.Cells("emp_dob").Value)

            If row.Cells("emp_gender").Value.ToString() = "Male" Then
                rdoMale.Checked = True
            Else
                rdoFemale.Checked = True
            End If
        End If
    End Sub

    Private Sub rdoMen_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMale.CheckedChanged

    End Sub
End Class