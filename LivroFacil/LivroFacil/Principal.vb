Public Class frmPrincipal

    Private Sub mnuSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSair.Click
        Close()

    End Sub

    Private Sub mnuiteSobre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuiteSobre.Click
        MsgBox("Livro Fácil - Gerenciador de Livrarias")

    End Sub

    Private Sub frmPrincipal_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If MsgBox("Deseja realmente sair?", MsgBoxStyle.OkCancel, "Alerta") = MsgBoxResult.Ok Then
            End
        Else
            e.Cancel = True
        End If

    End Sub

    Private Sub btnForn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub mnuiteRegistrarConsultarVenda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuiteRegistrarConsultarVenda.Click
        frmCaixa.ShowDialog()

    End Sub

    Private Sub btnLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLivro.Click
        frmLivro.ShowDialog()

    End Sub

    Private Sub btnFuncionarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFuncionarios.Click
        frmFuncionarios.ShowDialog()


    End Sub

    Private Sub btnfornecedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfornecedores.Click
        frmFornecedores.ShowDialog()

    End Sub

    Private Sub btnEstoque_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmEstoque.ShowDialog()
    End Sub

    Private Sub mnuiteLivros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuiteLivros.Click
        frmLivro.ShowDialog()

    End Sub

    Private Sub mnuitFornecedores_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuitFornecedores.Click
        frmFornecedores.ShowDialog()

    End Sub

    Private Sub btnCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCliente.Click
        FrmCliente.ShowDialog()

    End Sub

    Private Sub mnuiteClientes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuiteClientes.Click
        FrmCliente.ShowDialog()

    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        frmFuncionarios.ShowDialog()

    End Sub

    Private Sub btnVendas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVendas.Click
        frmVendas.ShowDialog()

    End Sub

    Private Sub btnCompras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        frmCompras.ShowDialog()

    End Sub

    Private Sub btnEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEmail.Click
        frmSisMail.ShowDialog()

    End Sub

    Private Sub btnCompras_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompras.Click
        frmCompras.ShowDialog()

    End Sub

    Private Sub VendasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VendasToolStripMenuItem.Click
        frmEstoque.ShowDialog()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class