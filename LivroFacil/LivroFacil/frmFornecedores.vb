Public Class frmFornecedores
    Dim dt_fornecedores As New DataTable


    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub frmFornecedores_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing

    End Sub

    Private Sub cboxUF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxUF.Click
        sql = "SELECT ESTADOID, SIGLA FROM ESTADO ORDER BY SIGLA"
        dt_fornecedores = consultaSQL(sql)
        cboxUF.DataSource = dt_fornecedores
        cboxUF.DisplayMember = "SIGLA"
        cboxUF.ValueMember = "ESTADOID"
    End Sub

    Private Sub cboxCidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxCidade.Click
        Try
            If cboxUF.Text = String.Empty Then
                MsgBox("Campo UF não selecionado!", MsgBoxStyle.Exclamation, "Alerta")
                cboxUF.Focus()
            Else
                sql = "SELECT CIDADE.CIDADEID, CIDADE.NOME,ESTADO.ESTADOID, ESTADO.SIGLA FROM CIDADE  INNER JOIN ESTADO ON ESTADO.ESTADOID = CIDADE.ESTADOID WHERE ESTADO.SIGLA = '" & cboxUF.Text & "'"
                dt_fornecedores = consultaSQL(sql)
                cboxCidade.DataSource = dt_fornecedores
                cboxCidade.DisplayMember = "NOME"
                cboxCidade.ValueMember = "CIDADEID"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click
        Try
            
            If txtRazSoc.Text = String.Empty Then
                MsgBox("Campo Razão Social vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                txtRazSoc.Focus()
            ElseIf txtEndForn.Text = String.Empty Then
                MsgBox("Campo endereço vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                txtEndForn.Focus()
            ElseIf txtBairroForn.Text = String.Empty Then
                MsgBox("Campo bairro vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                txtBairroForn.Focus()
            ElseIf cboxUF.Text = String.Empty Then
                MsgBox("Campo UF vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                cboxUF.Focus()
            ElseIf txtCep.Text = String.Empty Then
                MsgBox("Campo CEP vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                txtCep.Focus()
            ElseIf txtNomeFan.Text = String.Empty Then
                MsgBox("Campo Nome Fantasia vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                txtNomeFan.Focus()
            ElseIf txtCnpj.Text = String.Empty Then
                MsgBox("Campo CNPJ vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                txtCnpj.Focus()
            ElseIf txtInscEst.Text = String.Empty Then
                MsgBox("Campo Inscrição Estadual vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                txtInscEst.Focus()
            ElseIf txtFoneFor.Text = String.Empty Then
                MsgBox("Campo Telefone do fornecedor vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                txtFoneFor.Focus()
            ElseIf txtCelForn.Text = String.Empty Then
                MsgBox("Campo Celular vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                txtCelForn.Focus()
            ElseIf txtFoneEmpresa.Text = String.Empty Then
                MsgBox("Campo Telefone vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                txtFoneEmpresa.Focus()
            ElseIf cboxCidade.Text = String.Empty Then
                MsgBox("Campo Cidade vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                cboxCidade.Focus()


            Else
                sql = "INSERT INTO TBFORNECEDOR (FORRAZAOSOC, FORENDERECO, FORBAIRRO, FORCIDADE, FORUF, FORCEP, FORCNPJ, FORIE, FORNOMEFAN, FORTELEFONE, FORCELULAR, FORTELECONT, FOREMAIL, FORDTCAD) VALUES ( '" & txtRazSoc.Text & "', '" & txtEndForn.Text & "', '" & txtBairroForn.Text & "', '" & cboxCidade.Text & "', '" & cboxUF.Text & "', '" & txtCep.Text & "', '" & txtCnpj.Text & "', '" & txtInscEst.Text & "', '" & DtpDtCadastro.Text & "', '" & txtFoneFor.Text & "', '" & txtCelForn.Text & "', '" & txtFoneEmpresa.Text & "', '" & txtEmail.Text & "', '" & DtpDtCadastro.Text & "')"
                executaSQL(sql)
                MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information, "Alerta!")
                limparCampos()
                dt_fornecedores.Clear()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub limparCampos()

        txtEndForn.Clear()
        txtBairroForn.Clear()
        txtNomeFan.Clear()
        txtRazSoc.Clear()
        txtFoneEmpresa.Clear()
        txtInscEst.Clear()
        txtCnpj.Clear()
        cboxCidade.Text = ""
        cboxUF.Text = ""
        txtBairroForn.Clear()
        txtCep.Clear()
        txtEndForn.Clear()
        txtCelForn.Clear()
        txtEmail.Clear()
        DtpDtCadastro.Text = Format(Date.Now, "dd/MM/yyyy")

    End Sub


    Private Sub dgvFornecedores_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvFornecedores.DoubleClick
        Try
            txtRazSoc.Text = dgvFornecedores.SelectedCells.Item(0).Value
            txtEndForn.Text = dgvFornecedores.SelectedCells.Item(1).Value
            txtBairroForn.Text = dgvFornecedores.SelectedCells.Item(2).Value
            cboxCidade.Text = dgvFornecedores.SelectedCells.Item(3).Value
            cboxUF.Text = dgvFornecedores.SelectedCells.Item(4).Value
            txtCep.Text = dgvFornecedores.SelectedCells.Item(5).Value
            txtCnpj.Text = dgvFornecedores.SelectedCells.Item(6).Value
            txtInscEst.Text = dgvFornecedores.SelectedCells.Item(7).Value
            txtNomeFan.Text = dgvFornecedores.SelectedCells.Item(8).Value
            txtFoneFor.Text = dgvFornecedores.SelectedCells.Item(9).Value
            txtCelForn.Text = dgvFornecedores.SelectedCells.Item(10).Value
            txtFoneEmpresa.Text = dgvFornecedores.SelectedCells.Item(11).Value
            txtEmail.Text = dgvFornecedores.SelectedCells.Item(12).Value
            DtpDtCadastro.Text = dgvFornecedores.SelectedCells.Item(13).Value

            btnInserir.Enabled = False
            btnAlterar.Enabled = True
            btnExcluir.Enabled = True
            btnCancelar.Enabled = True



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnPesquisar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        Try
            sql = "SELECT FORRAZAOSOC,FORENDERECO,FORBAIRRO,FORCIDADE,FORUF, FORCEP, FORCNPJ,	FORIE, FORNOMEFAN, FORTELEFONE, FORCELULAR, FORTELECONT, FOREMAIL, FORDTCAD	FROM TBFORNECEDOR"
            If Not txtPesquisarForn.Text = String.Empty Then
                sql = sql & " WHERE  FORRAZAOSOC LIKE '%" & txtPesquisarForn.Text & "%'"
            End If
            dt_fornecedores = consultaSQL(sql)
            dgvFornecedores.DataSource = dt_fornecedores

        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Try
            sql = "UPDATE TBFORNECEDOR SET FORRAZAOSOC = '" & txtRazSoc.Text & "',FORENDERECO = '" & txtEndForn.Text & "',FORBAIRRO = '" & txtBairroForn.Text & "', FORCIDADE = '" & cboxCidade.Text & "', FORUF = '" & cboxUF.Text & "', FORCEP = '" & txtCep.Text & "', FORCNPJ = '" & txtCnpj.Text & "',FORIE = '" & txtInscEst.Text & "',FORNOMEFAN = '" & txtNomeFan.Text & "', FORTELEFONE = '" & txtEndForn.Text & "', FORCELULAR = '" & txtCelForn.Text & "', FORTELECONT = '" & txtFoneEmpresa.Text & "', FOREMAIL = '" & txtEmail.Text & "', FORDTCAD = '" & DtpDtCadastro.Text & "' WHERE FORCNPJ = " & txtCnpj.Text
            executaSQL(sql)
            MsgBox("Alteração realizada com sucesso!", MsgBoxStyle.Information, "Alerta!")
            limparCampos()

            dt_fornecedores.Clear()
            btnInserir.Enabled = True
            btnAlterar.Enabled = False
            btnExcluir.Enabled = False
            btnCancelar.Enabled = False




        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)



        End Try
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Try
            If MsgBox("Deseja realmente excluir este registro?", MsgBoxStyle.OkCancel, "Alerta!") = MsgBoxResult.Ok Then
                sql = "DELETE FROM TBFORNECEDOR WHERE FORCNPJ LIKE '" & txtCnpj.Text & "'"
                executaSQL(sql)
                limparCampos()
                MsgBox("Exclusão realizada com sucesso!", MsgBoxStyle.Information, "Alerta!")
                dt_fornecedores.Clear()
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
            dt_fornecedores.Clear()
            btnInserir.Enabled = True
            btnAlterar.Enabled = False
            btnExcluir.Enabled = False
            btnCancelar.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class