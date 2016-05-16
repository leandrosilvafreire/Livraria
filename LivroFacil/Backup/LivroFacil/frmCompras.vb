Public Class frmCompras
    Dim dt_Compras As New DataTable
    

   
    
    Private Sub dgvCompras_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCompras.DoubleClick
        
        Try
            txtCodigo.Text = dgvCompras.SelectedCells.Item(0).Value
            TxtFornecedor.Text = dgvCompras.SelectedCells.Item(1).Value
            TxtIsbn.Text = dgvCompras.SelectedCells.Item(2).Value
            TxtQuantidade.Text = dgvCompras.SelectedCells.Item(3).Value
            TxtPrCompra.Text = dgvCompras.SelectedCells.Item(4).Value
            DtpDtCompra.Text = dgvCompras.SelectedCells.Item(5).Value

            'btnAdicionar.Enabled = True
            'btnAlterar.Enabled = True
            'BtnCancelarCom.Enabled = True
            'BtnConcluir.Enabled = True
            BtnCancelar.Enabled = True




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    
    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Try
            sql = "UPDATE TBCOMPRAS SET FORNOME = '" & TxtFornecedor.Text & "', LIVISBN = '" & TxtIsbn.Text & "', COMQUANTIDADE = '" & TxtQuantidade.Text & "', COMPRECO = '" & TxtPrCompra.Text & "', COMDATA = '" & DtpDtCompra.Text & "' WHERE CODCOMPRAS LIKE '" & TxtCodigo.Text & "'"
            executaSQL(sql)
            MsgBox("Alteração realizada com sucesso!", MsgBoxStyle.Information, "Alerta!")
            limparCampos()

            dt_Compras.Clear()
            btnAdicionar.Enabled = True
            btnAlterar.Enabled = False
            BtnCancelarCom.Enabled = False
            BtnConcluir.Enabled = False
            BtnCancelar.Enabled = False



        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)



        End Try  
    End Sub

    Private Sub bnRetirar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            sql = "DELETE TBCOMPTEMP WHERE CTCODIGO = '" & TxtCodigo.Text & "'"
            executaSQL(sql)

            sql = "SELECT CTCODIGO, CTFORN, CTLIV, CTQTDE, CTPRECOMP, CTPREVEND FROM TBCOMPTEMP"
            dt_Compras = consultaSQL(sql)
            dgvCompras.DataSource = dt_Compras
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        
        Try
            If TxtFornecedor.Text = String.Empty Then
                MsgBox("Campo Fornecedor não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                TxtFornecedor.Focus()
                ' ElseIf TxtIsbn.Text = String.Empty Then
                'MsgBox("Campo ISBN não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                ' TxtIsbn.Focus()
            ElseIf TxtQuantidade.Text = String.Empty Then
                MsgBox("Campo   Quantidade não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                TxtQuantidade.Focus()
            ElseIf TxtPrCompra.Text = String.Empty Then
                MsgBox("Campo Preço de Compra não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                TxtPrCompra.Focus()


            Else


                sql = "INSERT INTO TBCOMPRAS (FORNOME, LIVISBN, COMQUANTIDADE, COMPRECO, COMDATA) VALUES ('" & TxtFornecedor.Text & "', '" & TxtIsbn.Text & "', '" & TxtQuantidade.Text & "', '" & TxtPrCompra.Text & "','" & DtpDtCompra.Text & "')"
                executaSQL(sql)
                'MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information, "Alerta!")
                limparCampos()
                dt_Compras.Clear()

                sql = "SELECT CODCOMPRAS, FORNOME, LIVISBN, COMQUANTIDADE, COMPRECO, COMDATA,(COMQUANTIDADE*COMPRECO) AS TOTAL FROM TBCOMPRAS WHERE FORNOME LIKE '" & TxtFornecedor.Text & "' AND COMDATA LIKE'" & DtpDtCompra.Text & "'"
                dt_Compras = consultaSQL(sql)
                dgvCompras.DataSource = dt_Compras


            End If
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
    End Sub

    Private Sub frmCompras_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'btnAdicionar.Enabled = True
        btnAlterar.Enabled = False
        'BtnCancelarCom.Enabled = False
        'BtnConcluir.Enabled = False
        BtnCancelar.Enabled = False
    End Sub
    Public Sub limparCampos()
        TxtCodigo.Clear()
        TxtFornecedor.Text = String.Empty
        TxtIsbn.Clear()
        TxtQuantidade.Clear()
        TxtPrCompra.Clear()
        DtpDtCompra.Text = Format(Date.Now, "dd/MM/yyyy")
        TxtTotal.Clear()

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        Try
            limparCampos()
            dt_Compras.Clear()
            btnAdicionar.Enabled = True
            btnAlterar.Enabled = False
            BtnCancelarCom.Enabled = False
            BtnConcluir.Enabled = False
            BtnCancelar.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub BtnCancelarCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelarCom.Click
        Try
            If MsgBox("Deseja realmente cancelar esta compra?", MsgBoxStyle.OkCancel, "Alerta!") = MsgBoxResult.Ok Then
                sql = "DELETE FROM TBCOMPRAS WHERE FORNOME LIKE '" & TxtFornecedor.Text & "' AND COMDATA LIKE'" & DtpDtCompra.Text & "'"
                executaSQL(sql)
                limparCampos()
                MsgBox("Cancelamento realizado com sucesso!", MsgBoxStyle.Information, "Alerta!")
                dt_Compras.Clear()
                btnAdicionar.Enabled = True
                btnAlterar.Enabled = False
                BtnCancelarCom.Enabled = False
                BtnConcluir.Enabled = False
                BtnCancelar.Enabled = False


            End If
        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub dgvCompras_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvCompras.CellContentClick

    End Sub

    Private Sub frmCompras_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        limparCampos()
        dt_Compras.Clear()
    End Sub

    
    Private Sub BtnConcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnConcluir.Click
        'Dim DBLTotal As Double
        'DBLTotal = Val(TxtTotal.Text)

        TxtTotal.Text = CDbl(TxtQuantidade.Text) * CDbl(TxtPrCompra.Text)


    End Sub

    Private Sub txtTitulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTitulo.Click
        Try
            sql = "SELECT LIVISBN, LIVTITULO, LIVSECAO FROM TBLIVRO ORDER BY LIVTITULO"
            dt_Compras = consultaSQL(sql)
            txtTitulo.DataSource = dt_Compras
            txtTitulo.DisplayMember = "LIVTITULO"
            txtTitulo.ValueMember = "LIVISBN"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TxtFornecedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFornecedor.Click
        Try
            sql = "SELECT FORCNPJ, FORRAZAOSOC FROM TBFORNECEDOR"
            dt_Compras = consultaSQL(sql)
            TxtFornecedor.DataSource = dt_Compras
            TxtFornecedor.DisplayMember = "FORRAZAOSOC"
            TxtFornecedor.ValueMember = "FORCNPJ"
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class