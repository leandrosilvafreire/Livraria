Public Class frmLivro
    Dim dtLivros As New DataTable


    Private Sub btnPesquisarLiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub dgvLivro_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnPesqForn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesqForn.Click
        Try
            sql = "SELECT LIVISBN, LIVTITULO, LIVAUTOR, LIVEDITORA, LIVSECAO, LIVDESCRICAO, LIVEDICAO, LIVVOLUME, LIVANOLANC, LIVORIGEM, LIVNRPAG, LIVFORNEC FROM TBLIVRO "
            If Not txtTitulo.Text = String.Empty Then
                sql = sql & " WHERE LIVTITULO LIKE '%" & txtTitulo.Text & "%'"
            ElseIf Not txtAutor.Text = String.Empty Then
                sql = sql & " WHERE LIVAUTOR LIKE '%" & txtAutor.Text & "%'"
            ElseIf Not txtIsbn.Text = String.Empty Then
                sql = sql & " WHERE LIVISBN LIKE '%" & txtIsbn.Text & "%'"
            ElseIf Not txtEditora.Text = String.Empty Then
                sql = sql & " WHERE LIVEDITORA LIKE '%" & txtEditora.Text & "%'"
            ElseIf Not txtGenero.Text = String.Empty Then
                sql = sql & " WHERE LIVSECAO LIKE '%" & txtGenero.Text & "%'"
            End If
            dtLivros = consultaSQL(sql)
            dgvLivro.DataSource = dtLivros


        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub GbCadastro_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GbCadastro.Enter

    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click
        Try
            If txtTituloLivro.Text = String.Empty Then
                MsgBox("Campo Nome não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                txtTituloLivro.Focus()
            ElseIf txtIsbnLivro.Text = String.Empty Then
                MsgBox("Campo Nome não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                txtIsbn.Focus()

            Else


                sql = "INSERT INTO TBLIVRO (LIVISBN, LIVTITULO, LIVAUTOR, LIVEDITORA, LIVSECAO, LIVDESCRICAO, LIVEDICAO, LIVVOLUME, LIVANOLANC, LIVORIGEM, LIVNRPAG, LIVFORNEC,ITEMPRECOVENDA, ITEMPRECOCOMPRA) VALUES ('" & txtIsbnLivro.Text & "', '" & txtTituloLivro.Text & "', '" & txtAutorLivro.Text & "', '" & txtEditoraLivro.Text & "', '" & cboxGenero.Text & "', '" & txtDescricao.Text & "', '" & txtEdicaoLivro.Text & "', '" & txtVolLivro.Text & "', '" & txtAnoLanc.Text & "', '" & txtOrigLivro.Text & "', '" & txtNrPagLiv.Text & "')"
                executaSQL(sql)
                'sql = "INSERT INTO TBESTOQUE (LIVISBN,ITEMPRECOVENDA, ITEMPRECOCOMPRA, ITEMPERCLUCRO, FUNCNOME, FORNOME) VALUES ('" & txtIsbnLivro.Text & "', '" & txtPrecVend.Text & "', '" & txtPrecComp.Text & "', '" & txtMargLucro.Text & "', '" & cboxFuncionario.Text & "', '" & cboxNomeForn.Text & "')"
                'executaSQL(sql)

                MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information, "Alerta!")
                limparCampos()
                dtLivros.Clear()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
    End Sub
    Public Sub limparCampos()
        txtDescricao.Clear()
        txtAnoLanc.Clear()
        txtAutorLivro.Clear()
        txtEdicaoLivro.Clear()
        txtEditoraLivro.Clear()
        txtVolLivro.Clear()
        txtGenero.Clear()
        txtIsbnLivro.Clear()
        txtTituloLivro.Clear()
        txtNrPagLiv.Clear()
        txtOrigLivro.Clear()





    End Sub

   

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Try
            sql = "UPDATE TBLIVRO  SET LIVISBN = '" & txtIsbnLivro.Text & "', LIVTITULO = '" & txtTituloLivro.Text & "', LIVAUTOR = '" & txtAutorLivro.Text & "', LIVEDITORA = '" & txtEditoraLivro.Text & "',LIVSECAO = '" & cboxGenero.Text & "', LIVDESCRICAO = '" & txtDescricao.Text & "', LIVEDICAO = '" & txtEdicaoLivro.Text & "', LIVVOLUME = '" & txtVolLivro.Text & "', LIVANOLANC = '" & txtAnoLanc.Text & "', LIVORIGEM = '" & txtOrigLivro.Text & "', LIVNRPAG = '" & txtNrPagLiv.Text & "'  WHERE LIVISBN LIKE '" & txtIsbnLivro.Text & "'"
            executaSQL(sql)
            MsgBox("Alteração realizada com sucesso!", MsgBoxStyle.Information, "Alerta!")
            limparCampos()

            dtLivros.Clear()
            btnInserir.Enabled = True
            btnAlterar.Enabled = False
            btnExcluir.Enabled = False
            btnCancelar.Enabled = False




        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)



        End Try
    End Sub

    Private Sub cboxGenero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxGenero.Click
        Try
            sql = "SELECT SECCODSECAO, SECNOMESECAO FROM TBSECAO ORDER BY SECNOMESECAO"
            dtLivros = consultaSQL(sql)
            cboxGenero.DataSource = dtLivros
            cboxGenero.DisplayMember = "SECNOMESECAO"
            cboxGenero.ValueMember = "SECCODSECAO"
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    'Private Sub cboxNomeForn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    'Try
    'sql = "SELECT FORCNPJ, FORNOME FROM TBFORNECEDOR ORDER BY FORNOME"
    ' dtLivros = consultaSQL(sql)
    'cboxNomeForn.DataSource = dtLivros
    'cboxNomeForn.DisplayMember = "FORNOME"
    'cboxNomeForn.ValueMember = "FORCNPJ"
    'Catch ex As Exception
    'MsgBox(ex.Message)
    'End Try
    'End Sub

    Private Sub cboxFuncionario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Try
        'sql = "SELECT FUNCCPF, FUNCNOME FROM TBFUNCIONARIOS ORDER BY FUNCNOME"
        'dtLivros = consultaSQL(sql)
        'cboxFuncionario.DataSource = dtLivros
        'cboxFuncionario.DisplayMember = "FUNCNOME"
        'cboxFuncionario.ValueMember = "FUNCCPF"
        'Catch ex As Exception
        'MsgBox(ex.Message)

        'End Try
    End Sub

    Private Sub dgvLivro_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLivro.DoubleClick
        Try
            txtIsbnLivro.Text = dgvLivro.SelectedCells.Item(0).Value
            txtTituloLivro.Text = dgvLivro.SelectedCells.Item(1).Value
            txtAutorLivro.Text = dgvLivro.SelectedCells.Item(2).Value
            txtEditoraLivro.Text = dgvLivro.SelectedCells.Item(3).Value
            cboxGenero.Text = dgvLivro.SelectedCells.Item(4).Value
            txtDescricao.Text = dgvLivro.SelectedCells.Item(5).Value
            txtEdicaoLivro.Text = dgvLivro.SelectedCells.Item(6).Value
            txtVolLivro.Text = dgvLivro.SelectedCells.Item(7).Value
            txtAnoLanc.Text = dgvLivro.SelectedCells.Item(8).Value
            txtOrigLivro.Text = dgvLivro.SelectedCells.Item(9).Value
            txtNrPagLiv.Text = dgvLivro.SelectedCells.Item(10).Value

            btnInserir.Enabled = False
            btnAlterar.Enabled = True
            btnExcluir.Enabled = True
            btnCancelar.Enabled = True



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Try
            If MsgBox("Deseja realmente excluir este registro?", MsgBoxStyle.OkCancel, "Alerta!") = MsgBoxResult.Ok Then
                sql = "DELETE FROM TBLIVRO WHERE LIVISBN LIKE '" & txtIsbnLivro.Text & "'"
                executaSQL(sql)
                limparCampos()
                MsgBox("Exclusão realizada com sucesso!", MsgBoxStyle.Information, "Alerta!")
                dtLivros.Clear()
                btnInserir.Enabled = True
                btnAlterar.Enabled = False
                btnExcluir.Enabled = False
                btnCancelar.Enabled = False

            End If
        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            limparCampos()
            dtLivros.Clear()
            btnInserir.Enabled = True
            btnAlterar.Enabled = False
            btnExcluir.Enabled = False
            btnCancelar.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtVolLivro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtVolLivro.KeyPress
        If (Asc(e.KeyChar()) < Asc("0")) Or (Asc(e.KeyChar()) > Asc("9")) Then
            If (Asc(e.KeyChar()) <> 9) Then
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub

    Private Sub txtAnoLanc_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtAnoLanc.KeyPress
        If (Asc(e.KeyChar()) < Asc("0")) Or (Asc(e.KeyChar()) > Asc("9")) Then
            If (Asc(e.KeyChar()) <> 9) Then
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub

    Private Sub txtNrPagLiv_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNrPagLiv.KeyPress
        If (Asc(e.KeyChar()) < Asc("0")) Or (Asc(e.KeyChar()) > Asc("9")) Then
            If (Asc(e.KeyChar()) <> 9) Then
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub


End Class