<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class empForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblstID = New System.Windows.Forms.Label()
        Me.lblstName = New System.Windows.Forms.Label()
        Me.lblGen = New System.Windows.Forms.Label()
        Me.lblstPh = New System.Windows.Forms.Label()
        Me.lblDob = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPh = New System.Windows.Forms.TextBox()
        Me.dtpDob = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.rdoMale = New System.Windows.Forms.RadioButton()
        Me.rdoFemale = New System.Windows.Forms.RadioButton()
        Me.txtSa = New System.Windows.Forms.TextBox()
        Me.lblSa = New System.Windows.Forms.Label()
        Me.dgvEmp = New System.Windows.Forms.DataGridView()
        Me.no = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.salary = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_dob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.emp_phone = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.create_at = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(415, 11)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(341, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee Menagement"
        '
        'lblstID
        '
        Me.lblstID.AutoSize = True
        Me.lblstID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstID.Location = New System.Drawing.Point(35, 82)
        Me.lblstID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblstID.Name = "lblstID"
        Me.lblstID.Size = New System.Drawing.Size(104, 20)
        Me.lblstID.TabIndex = 1
        Me.lblstID.Text = "Employee ID"
        '
        'lblstName
        '
        Me.lblstName.AutoSize = True
        Me.lblstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstName.Location = New System.Drawing.Point(49, 130)
        Me.lblstName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblstName.Name = "lblstName"
        Me.lblstName.Size = New System.Drawing.Size(85, 20)
        Me.lblstName.TabIndex = 2
        Me.lblstName.Text = "Full Name"
        '
        'lblGen
        '
        Me.lblGen.AutoSize = True
        Me.lblGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGen.Location = New System.Drawing.Point(696, 229)
        Me.lblGen.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGen.Name = "lblGen"
        Me.lblGen.Size = New System.Drawing.Size(64, 20)
        Me.lblGen.TabIndex = 3
        Me.lblGen.Text = "Gender"
        '
        'lblstPh
        '
        Me.lblstPh.AutoSize = True
        Me.lblstPh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblstPh.Location = New System.Drawing.Point(79, 180)
        Me.lblstPh.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblstPh.Name = "lblstPh"
        Me.lblstPh.Size = New System.Drawing.Size(56, 20)
        Me.lblstPh.TabIndex = 4
        Me.lblstPh.Text = "Phone"
        '
        'lblDob
        '
        Me.lblDob.AutoSize = True
        Me.lblDob.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDob.Location = New System.Drawing.Point(656, 180)
        Me.lblDob.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDob.Name = "lblDob"
        Me.lblDob.Size = New System.Drawing.Size(110, 20)
        Me.lblDob.TabIndex = 5
        Me.lblDob.Text = "Birth of Date "
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(169, 82)
        Me.txtID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(332, 22)
        Me.txtID.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(169, 129)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(332, 22)
        Me.txtName.TabIndex = 7
        '
        'txtPh
        '
        Me.txtPh.Location = New System.Drawing.Point(169, 180)
        Me.txtPh.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPh.Name = "txtPh"
        Me.txtPh.Size = New System.Drawing.Size(332, 22)
        Me.txtPh.TabIndex = 8
        '
        'dtpDob
        '
        Me.dtpDob.Location = New System.Drawing.Point(771, 175)
        Me.dtpDob.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpDob.Name = "dtpDob"
        Me.dtpDob.Size = New System.Drawing.Size(332, 22)
        Me.dtpDob.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Orange
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1179, 54)
        Me.Panel1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1135, 11)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 36)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "X"
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(55, 271)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(121, 41)
        Me.btnClear.TabIndex = 13
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(611, 271)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(121, 41)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(807, 271)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(121, 41)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Silver
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(995, 271)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(121, 41)
        Me.btnAdd.TabIndex = 16
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'rdoMale
        '
        Me.rdoMale.AutoSize = True
        Me.rdoMale.Location = New System.Drawing.Point(812, 228)
        Me.rdoMale.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoMale.Name = "rdoMale"
        Me.rdoMale.Size = New System.Drawing.Size(58, 20)
        Me.rdoMale.TabIndex = 17
        Me.rdoMale.TabStop = True
        Me.rdoMale.Text = "Male"
        Me.rdoMale.UseVisualStyleBackColor = True
        '
        'rdoFemale
        '
        Me.rdoFemale.AutoSize = True
        Me.rdoFemale.Location = New System.Drawing.Point(917, 228)
        Me.rdoFemale.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoFemale.Name = "rdoFemale"
        Me.rdoFemale.Size = New System.Drawing.Size(74, 20)
        Me.rdoFemale.TabIndex = 18
        Me.rdoFemale.TabStop = True
        Me.rdoFemale.Text = "Female"
        Me.rdoFemale.UseVisualStyleBackColor = True
        '
        'txtSa
        '
        Me.txtSa.Location = New System.Drawing.Point(771, 129)
        Me.txtSa.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtSa.Name = "txtSa"
        Me.txtSa.Size = New System.Drawing.Size(332, 22)
        Me.txtSa.TabIndex = 20
        '
        'lblSa
        '
        Me.lblSa.AutoSize = True
        Me.lblSa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSa.Location = New System.Drawing.Point(701, 129)
        Me.lblSa.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSa.Name = "lblSa"
        Me.lblSa.Size = New System.Drawing.Size(56, 20)
        Me.lblSa.TabIndex = 19
        Me.lblSa.Text = "Salary"
        '
        'dgvEmp
        '
        Me.dgvEmp.AllowUserToAddRows = False
        Me.dgvEmp.AllowUserToDeleteRows = False
        Me.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.no, Me.emp_name, Me.emp_position, Me.salary, Me.emp_dob, Me.emp_gender, Me.emp_phone, Me.create_at})
        Me.dgvEmp.Location = New System.Drawing.Point(0, 338)
        Me.dgvEmp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvEmp.Name = "dgvEmp"
        Me.dgvEmp.ReadOnly = True
        Me.dgvEmp.RowHeadersVisible = False
        Me.dgvEmp.RowHeadersWidth = 51
        Me.dgvEmp.Size = New System.Drawing.Size(1179, 314)
        Me.dgvEmp.TabIndex = 21
        '
        'no
        '
        Me.no.HeaderText = "No."
        Me.no.MinimumWidth = 6
        Me.no.Name = "no"
        Me.no.ReadOnly = True
        Me.no.Width = 50
        '
        'emp_name
        '
        Me.emp_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.emp_name.HeaderText = "Full Name"
        Me.emp_name.MinimumWidth = 6
        Me.emp_name.Name = "emp_name"
        Me.emp_name.ReadOnly = True
        '
        'emp_position
        '
        Me.emp_position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.emp_position.HeaderText = "Position"
        Me.emp_position.MinimumWidth = 6
        Me.emp_position.Name = "emp_position"
        Me.emp_position.ReadOnly = True
        '
        'salary
        '
        Me.salary.HeaderText = "Salary"
        Me.salary.MinimumWidth = 6
        Me.salary.Name = "salary"
        Me.salary.ReadOnly = True
        Me.salary.Width = 125
        '
        'emp_dob
        '
        Me.emp_dob.HeaderText = "Date Of birth"
        Me.emp_dob.MinimumWidth = 6
        Me.emp_dob.Name = "emp_dob"
        Me.emp_dob.ReadOnly = True
        Me.emp_dob.Width = 125
        '
        'emp_gender
        '
        Me.emp_gender.HeaderText = "Gender"
        Me.emp_gender.MinimumWidth = 6
        Me.emp_gender.Name = "emp_gender"
        Me.emp_gender.ReadOnly = True
        Me.emp_gender.Width = 80
        '
        'emp_phone
        '
        Me.emp_phone.HeaderText = "Phone"
        Me.emp_phone.MinimumWidth = 6
        Me.emp_phone.Name = "emp_phone"
        Me.emp_phone.ReadOnly = True
        Me.emp_phone.Width = 125
        '
        'create_at
        '
        Me.create_at.HeaderText = "Create at"
        Me.create_at.MinimumWidth = 6
        Me.create_at.Name = "create_at"
        Me.create_at.ReadOnly = True
        Me.create_at.Width = 125
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(771, 82)
        Me.txtPosition.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(332, 22)
        Me.txtPosition.TabIndex = 23
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(689, 84)
        Me.lblPosition.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(69, 20)
        Me.lblPosition.TabIndex = 22
        Me.lblPosition.Text = "Position"
        '
        'empForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(1179, 652)
        Me.Controls.Add(Me.txtPosition)
        Me.Controls.Add(Me.lblPosition)
        Me.Controls.Add(Me.dgvEmp)
        Me.Controls.Add(Me.txtSa)
        Me.Controls.Add(Me.lblSa)
        Me.Controls.Add(Me.rdoFemale)
        Me.Controls.Add(Me.rdoMale)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtpDob)
        Me.Controls.Add(Me.txtPh)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblDob)
        Me.Controls.Add(Me.lblstPh)
        Me.Controls.Add(Me.lblGen)
        Me.Controls.Add(Me.lblstName)
        Me.Controls.Add(Me.lblstID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "empForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Menagement"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblstID As Label
    Friend WithEvents lblstName As Label
    Friend WithEvents lblGen As Label
    Friend WithEvents lblstPh As Label
    Friend WithEvents lblDob As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPh As TextBox
    Friend WithEvents dtpDob As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents rdoMale As RadioButton
    Friend WithEvents rdoFemale As RadioButton
    Friend WithEvents txtSa As TextBox
    Friend WithEvents lblSa As Label
    Friend WithEvents dgvEmp As DataGridView
    Friend WithEvents txtPosition As TextBox
    Friend WithEvents lblPosition As Label
    Friend WithEvents no As DataGridViewTextBoxColumn
    Friend WithEvents emp_name As DataGridViewTextBoxColumn
    Friend WithEvents emp_position As DataGridViewTextBoxColumn
    Friend WithEvents salary As DataGridViewTextBoxColumn
    Friend WithEvents emp_dob As DataGridViewTextBoxColumn
    Friend WithEvents emp_gender As DataGridViewTextBoxColumn
    Friend WithEvents emp_phone As DataGridViewTextBoxColumn
    Friend WithEvents create_at As DataGridViewTextBoxColumn
End Class
