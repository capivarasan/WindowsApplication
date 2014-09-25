Imports Npgsql

Module Module1

    Function DoSql(ByVal strSQL As String)

        Dim conn As NpgsqlConnection =
        New NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=iwata; Database=test-profile;")

        Return conn

    End Function

End Module
