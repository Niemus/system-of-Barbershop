Public Class Reg
    Dim a, b As String
    Private Sub AnomButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnomButton2.Click
        Main.Show()
        Me.Hide()

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

        Dim Valuta2 As Double = TextBox6.Text
        TextBox6.Text = String.Format("{0:c}", Valuta2)


    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected


    End Sub

    Private Sub ClsAnomTheme1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClsAnomTheme1.Click

    End Sub

    Private Sub Reg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Check_FIO.FIO_Proverka(TextBox1)
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        Check_Adress.Adress_Proverka(TextBox3)

    End Sub

    Private Sub AnomButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AnomButton1.Click
        Module_database.Regf()

    End Sub
End Class