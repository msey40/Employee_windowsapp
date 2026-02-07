
Imports MySql.Data.MySqlClient

Module connectionDB

    ReadOnly Property connectionString As String
        Get
            Return "server=localhost;port=3306;database=testdb;uid=root;pwd=;"
        End Get
    End Property

    Public Function getDBConnection() As MySqlConnection
        Dim conn As New MySqlConnection(connectionString)

        Try
            Return conn

        Catch ex As Exception
            MsgBox("Database connection failed: " & ex.Message, MsgBoxStyle.Critical)
            Return Nothing
            Exit Function
        End Try
    End Function


End Module
