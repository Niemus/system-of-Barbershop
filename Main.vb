Public Class Main

    Private Sub AnomButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnomButton1.Click
        Reg.Show()
        Me.Hide()
    End Sub

    Private Sub AnomButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnomButton2.Click
        DataBase.Show()
        Me.Hide()
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AnomButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnomButton3.Click
        Me.Close()
    End Sub
End Class
