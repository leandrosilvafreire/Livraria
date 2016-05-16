Public Class frmCaixa
    Dim dt_Caixa As New DataTable

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CboxOperacao_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboxOperacao.SelectedIndexChanged
        Try
            sql = "SELECT OPECODIGO, OPETIPO FROM TBOPERACAO ORDER BY OPETIPO"
            dt_Caixa = consultaSQL(sql)
            CboxOperacao.DataSource = dt_Caixa
            CboxOperacao.DisplayMember = "OPETIPO"
            CboxOperacao.ValueMember = "OPECODIGO"
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub DgvCaixa_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DgvCaixa.CellContentClick

    End Sub
End Class