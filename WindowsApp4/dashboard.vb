Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports Mysqlx.XDevAPI.Common
Public Class dashboard
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        getDBConnection()
    End Sub

    Private Sub dashboard_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        Dim result As DialogResult = MessageBox.Show(
        "Are you sure you want to exit?",
        "Confirm Exit",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    )

        If result = DialogResult.Yes Then
            Application.Exit()

        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub btnAddEmp_Click(sender As Object, e As EventArgs)
        empForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        empForm.ShowDialog()
    End Sub


End Class