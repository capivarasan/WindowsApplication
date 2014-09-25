Imports Npgsql

Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim strSQL As String = String.Empty

        ' SQL文作成
        strSQL = "INSERT INTO profile1 "
        strSQL &= "(name1, name2, btype) "
        strSQL &= "VALUES ('" & TextBox2.Text & "',"
        strSQL &= "'" & TextBox3.Text & "',"
        strSQL &= "'" & TextBox4.Text & "')"

        'DB
        Dim conn As NpgsqlConnection = DoSql(strSQL)

        conn.Open()

        Dim command As NpgsqlCommand =
        New NpgsqlCommand((strSQL), conn)

        Dim sResult As String = command.ExecuteScalar()

        conn.Close()

        MessageBox.Show("登録しました")

        End

    End Sub


End Class