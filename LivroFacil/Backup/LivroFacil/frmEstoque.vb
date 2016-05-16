Public Class frmEstoque
    Dim dt_estoque As New DataTable


    Private Sub btnPesqCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnIncluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmEstoque_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load











    End Sub

    Private Sub txtPrecComp_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs)

    End Sub

   
    Public Sub limparcampos()
        txtLivro.Clear()
        DtpDtCadastro.Text = Format(Date.Now, "dd/MM/yyyy")
        TxtIsbn.Clear()

    End Sub
    'Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
    'Try
    'sql = " SELECT ESTCODIGO, ESTTITULLIV, ESTQUANTIDADE, ESTPRECOMPRA, ESTPREVENDA, ESTDTENTR, LIVISBN FROM TBESTOQUE"
    'If Not txtPesquisar.Text = String.Empty Then
    'sql = sql & " WHERE LIVISBN LIKE '%" & txtPesquisar.Text & "%'"
    'End If
    'dt_estoque = consultaSQL(sql)
    'DgvEstoque.DataSource = dt_estoque

    'Catch ex As Exception
    'conexao.Close()
    'MsgBox(ex.Message)

    'End Try
    'End Sub
    Private Sub frmEstoque_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        limparcampos()
        dt_estoque.Clear()
    End Sub
End Class