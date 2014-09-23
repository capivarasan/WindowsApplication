Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ' このフォームを常に最前面に表示する
        Me.TopMost = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        '登録画面に遷移する
        Dim f As New Form2
        f.Show(Me)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        '検索画面に遷移する
        Dim f As New Form3
        f.Show(Me)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        ' このフォームを閉じる旨を表示する
        MessageBox.Show("プロフィール管理を閉じます")

        ' 自身のフォームを閉じる
        Me.Close()

    End Sub

End Class
