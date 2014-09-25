Imports Npgsql

Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        Dim strSQL As String = String.Empty

        ' SQL文作成
        'SELECT * FROM profile1 WHERE name1 = '岩田'
        strSQL = "SELECT * FROM profile1 "
        strSQL &= "WHERE name1 = "
        strSQL &= "('" & TextBox1.Text & "')"

        'DB
        Dim conn As NpgsqlConnection = DoSql(strSQL)

        conn.Open()

        Dim command As NpgsqlCommand =
        New NpgsqlCommand((strSQL), conn)

        Dim sResult As NpgsqlDataReader = command.ExecuteReader()

        Dim strProfileData As String = String.Empty
        Dim index As Integer = 0

        If sResult.HasRows Then

            While sResult.Read()

                '苗字を取得する()
                strProfileData &= sResult("name1")
                ' 名前を取得する
                strProfileData &= sResult("name2")
                ' 血液型を取得する
                strProfileData &= sResult("btype")

            End While

        End If

        ' 表示
        MessageBox.Show(strProfileData)

    End Sub
End Class