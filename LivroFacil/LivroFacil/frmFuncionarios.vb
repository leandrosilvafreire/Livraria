Public Class frmFuncionarioS
    Dim dt_funcionarios As New DataTable
    Private Sub cboxUF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sql = "SELECT ESTADOID, SIGLA FROM ESTADO ORDER BY SIGLA"
        dt_funcionarios = consultaSQL(sql)
        cboxUF.DataSource = dt_funcionarios
        cboxUF.DisplayMember = "SIGLA"
        cboxUF.ValueMember = "ESTADOID"
    End Sub

    Private Sub cboxCidade_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            If cboxUF.Text = String.Empty Then
                MsgBox("Campo UF não selecionado!", MsgBoxStyle.Exclamation, "Alerta")
                cboxUF.Focus()
            Else
                sql = "SELECT CIDADE.CIDADEID, CIDADE.NOME,ESTADO.ESTADOID, ESTADO.SIGLA FROM CIDADE  INNER JOIN ESTADO ON ESTADO.ESTADOID = CIDADE.ESTADOID WHERE ESTADO.SIGLA = '" & cboxUF.Text & "'"
                dt_funcionarios = consultaSQL(sql)
                cboxCidade.DataSource = dt_funcionarios
                cboxCidade.DisplayMember = "NOME"
                cboxCidade.ValueMember = "CIDADEID"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click

        Try
            If txtCpf.Text = String.Empty Then
                MsgBox("Campo CPF não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                txtCpf.Focus()
            ElseIf txtNome.Text = String.Empty Then
                MsgBox("Campo Nome não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                txtNome.Focus()
            ElseIf txtEndereco.Text = String.Empty Then
                MsgBox("Campo Endereço não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                txtEndereco.Focus()
            ElseIf txtCep.Text = String.Empty Then
                MsgBox("Campo CEP não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                txtCep.Focus()
            ElseIf txtBairro.Text = String.Empty Then
                MsgBox("Campo Bairro não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                txtBairro.Focus()
            ElseIf cboxCidade.Text = String.Empty Then
                MsgBox("Campo Cidade vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                cboxCidade.Focus()
            ElseIf cboxUF.Text = String.Empty Then
                MsgBox("Campo Uf Vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                cboxUF.Focus()
            ElseIf txtCargo.Text = String.Empty Then
                MsgBox("Campo Cargo Vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                txtCargo.Focus()
            ElseIf dtpDtAdmis.Text = Format(Date.Now, "dd/MM/yyyy") Then
                MsgBox("Campo Data de Admissão Vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                dtpDtAdmis.Focus()
            ElseIf txtRG.Text = String.Empty Then
                MsgBox("Campo RG não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                txtRG.Focus()
            ElseIf txtEstCivil.Text = String.Empty Then
                MsgBox("Campo Estado Civil Vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                txtEstCivil.Focus()
            ElseIf txtSexo.Text = String.Empty Then
                MsgBox("Campo Sexo Vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                txtSexo.Focus()
            ElseIf DtpDtaNasc.Text = Format(Date.Now, "dd/MM/yyyy") Then
                MsgBox("Campo Data não pode ser a data atual!", MsgBoxStyle.Exclamation, "Alerta!")
                DtpDtaNasc.Focus()
            ElseIf txtSenha.Text = String.Empty Then
                MsgBox("Campo Senha Vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                txtSenha.Focus()
            ElseIf txtLoginUsuario.Text = String.Empty Then
                MsgBox("Campo Login de Usuário Vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                txtLoginUsuario.Focus()





            Else



                sql = "INSERT INTO TBFUNCIONARIOS (FUNCCPF, FUNCNOME, FUNCENDERECO, FUNCCEP, FUNCBAIRRO, FUNCCIDADE, FUNCUF, FUNCCARGO, FUNCDTADMIS, FUNCRG, FUNCTELEFONE, FUNCCELULAR, FUNCEMAIL, FUNCESTADOCIVIL, FUNCSEXO, FUNCDTNASC, FUNCNOMECONJ, FUNCTELECONJ, FUNCSENHA, FUNCUSUARIO) VALUES ('" & txtCpf.Text & "','" & txtNome.Text & "','" & txtEndereco.Text & "'," & txtCep.Text & "','" & txtBairro.Text & "','" & cboxCidade.Text & "','" & cboxUF.Text & "','" & txtCargo.Text & "','" & dtpDtAdmis.Text & "','" & txtRG.Text & "','" & txtFone.Text & "','" & txtCelular.Text & "','" & txtEmail.Text & "','" & txtEstCivil.Text & "','" & txtSexo.Text & "','" & DtpDtaNasc.Text & "','" & txtNomeConj.Text & "','" & txtTelConj.Text & "','" & txtSenha.Text & "', '" & txtLoginUsuario.Text & "')"
                executaSQL(sql)
                MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information, "Alerta!")
                limparCampos()
                dt_funcionarios.Clear()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
    End Sub
    'Public Sub limparCampos()
    '   txtCodigo.Clear()
    '  txtNome.Clear()
    ' txtEndereco.Clear()
    'txtRG.Clear()
    'txtCpf.Clear()
    'txtSexo.Clear()
    'txtEstCivil.Clear()
    'txtCep.Clear()
    'txtFone.Clear()
    'txtCelular.Clear()
    'txtEmail.Clear()
    'DtpDtaNasc.Text = Format(Date.Now, "dd/MM/yyyy")
    'DtpDtCadastro.Text = Format(Date.Now, "dd/MM/yyyy")
    'End Sub


    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        Try
            sql = "SELECT FUNCCPF, FUNCNOME, FUNCENDERECO, FUNCCEP, FUNCBAIRRO, FUNCCIDADE, FUNCUF, FUNCCARGO, FUNCDTADMIS, FUNCRG, FUNCTELEFONE, FUNCCELULAR, FUNCEMAIL, FUNCESTADOCIVIL, FUNCSEXO, FUNCDTNASC, FUNCNOMECONJ, FUNCTELECONJ, FUNCSENHA, FUNCUSUARIO FROM TBFUNCIONARIOS"
            If Not txtPesquisarFunc.Text = String.Empty Then
                sql = sql & " WHERE FUNCNOME LIKE '%" & txtPesquisarFunc.Text & "%'"
            End If
            dt_funcionarios = consultaSQL(sql)
            dgvFuncionarios.DataSource = dt_funcionarios

        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click
        Try
            If MsgBox("Deseja realmente excluir este registro?", MsgBoxStyle.OkCancel, "Alerta!") = MsgBoxResult.Ok Then
                sql = "DELETE FROM TBFUNCIONARIOS WHERE FUNCCPF = " & txtCpf.Text
                executaSQL(sql)
                limparCampos()
                MsgBox("Exclusão realizada com sucesso!", MsgBoxStyle.Information, "Alerta!")
                dt_funcionarios.Clear()
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

    Private Sub cboxUF_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxUF.Click
        sql = "SELECT ESTADOID, SIGLA FROM ESTADO ORDER BY SIGLA"
        dt_funcionarios = consultaSQL(sql)
        cboxUF.DataSource = dt_funcionarios
        cboxUF.DisplayMember = "SIGLA"
        cboxUF.ValueMember = "ESTADOID"
    End Sub

    Private Sub cboxCidade_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxCidade.Click
        Try
            If cboxUF.Text = String.Empty Then
                MsgBox("Campo UF não selecionado!", MsgBoxStyle.Exclamation, "Alerta")
                cboxUF.Focus()
            Else
                sql = "SELECT CIDADE.CIDADEID, CIDADE.NOME, ESTADO.ESTADOID, ESTADO.SIGLA FROM CIDADE  INNER JOIN ESTADO ON ESTADO.ESTADOID = CIDADE.ESTADOID WHERE ESTADO.SIGLA = '" & cboxUF.Text & "'"
                dt_funcionarios = consultaSQL(sql)
                cboxCidade.DataSource = dt_funcionarios
                cboxCidade.DisplayMember = "NOME"
                cboxCidade.ValueMember = "CIDADEID"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub



    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Try
            sql = "UPDATE TBFUNCIONARIOS SET FUNCCPF = '" & txtCpf.Text & "', FUNCNOME = '" & txtNome.Text & "', FUNCENDERECO = '" & txtEndereco.Text & "', FUNCCEP = '" & txtCep.Text & "', FUNCBAIRO = '" & txtBairro.Text & "', FUNCCIDADE = '" & cboxCidade.Text & "', FUNCUF = '" & cboxUF.Text & "', FUNCCARGO = '" & txtCargo.Text & "', FUNCDTADMIS = '" & dtpDtAdmis.Text & "', FUNCRG = '" & txtRG.Text & "', FUNCTELEFONE = '" & txtFone.Text & "', FUNCCELULAR = '" & txtCelular.Text & "', FUNCEMAIL = '" & txtEmail.Text & "', FUNCESTADOCIVIL = '" & txtEstCivil.Text & "', FUNCSEXO = '" & txtSexo.Text & "', FUNCDTNASC = ' " & DtpDtaNasc.Text & " ', FUNCNOMECONJ = ' " & txtNomeConj.Text & " ', FUNCTELECONJ = ' " & txtTelConj.Text & " ', FUNCSENHA = ' " & txtSenha.Text & " ', FUNCUSUARIO = ' " & txtLoginUsuario.Text & " ' WHERE CLICPF LIKE '" & txtCpf.Text & "'"
            executaSQL(sql)
            MsgBox("Alteração realizada com sucesso!", MsgBoxStyle.Information, "Alerta!")
            limparCampos()

            dt_funcionarios.Clear()
            btnInserir.Enabled = True
            btnAlterar.Enabled = False
            btnExcluir.Enabled = False
            btnCancelar.Enabled = False




        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)



        End Try
    End Sub


    Private Sub dgvFuncionarios_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvFuncionarios.DoubleClick
        Try
            txtCpf.Text = dgvFuncionarios.SelectedCells.Item(0).Value
            txtNome.Text = dgvFuncionarios.SelectedCells.Item(1).Value
            txtEndereco.Text = dgvFuncionarios.SelectedCells.Item(2).Value
            txtCep.Text = dgvFuncionarios.SelectedCells.Item(3).Value
            txtBairro.Text = dgvFuncionarios.SelectedCells.Item(4).Value
            cboxCidade.Text = dgvFuncionarios.SelectedCells.Item(5).Value
            cboxUF.Text = dgvFuncionarios.SelectedCells.Item(6).Value
            txtCargo.Text = dgvFuncionarios.SelectedCells.Item(7).Value
            'dtpDtAdmis.Text = dgvFuncionarios.SelectedCells.Item(8).Value
            txtRG.Text = dgvFuncionarios.SelectedCells.Item(9).Value
            txtFone.Text = dgvFuncionarios.SelectedCells.Item(10).Value
            txtCelular.Text = dgvFuncionarios.SelectedCells.Item(11).Value
            txtEmail.Text = dgvFuncionarios.SelectedCells.Item(12).Value
            txtEstCivil.Text = dgvFuncionarios.SelectedCells.Item(13).Value
            txtSexo.Text = dgvFuncionarios.SelectedCells.Item(14).Value
            'DtpDtaNasc.Text = dgvFuncionarios.SelectedCells.Item(15).Value
            txtNomeConj.Text = dgvFuncionarios.SelectedCells.Item(16).Value
            txtTelConj.Text = dgvFuncionarios.SelectedCells.Item(17).Value
            txtSenha.Text = dgvFuncionarios.SelectedCells.Item(18).Value
            txtLoginUsuario.Text = dgvFuncionarios.SelectedCells.Item(19).Value

            btnInserir.Enabled = False
            btnAlterar.Enabled = True
            btnExcluir.Enabled = True
            btnCancelar.Enabled = True

        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            limparCampos()
            dt_funcionarios.Clear()
            btnInserir.Enabled = True
            btnAlterar.Enabled = False
            btnExcluir.Enabled = False
            btnCancelar.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try


    End Sub
    Public Sub limparCampos()
        txtCpf.Clear()
        txtNome.Clear()
        txtEndereco.Clear()
        txtCep.Clear()
        txtBairro.Clear()
        cboxCidade.Text = ""
        cboxUF.Text = ""
        txtCargo.Clear()
        dtpDtAdmis.Text = Format(Date.Now, "dd/MM/yyyy")
        txtRG.Clear()
        txtFone.Clear()
        txtCelular.Clear()
        txtEmail.Clear()
        txtEstCivil.Clear()
        txtSexo.Clear()
        DtpDtaNasc.Text = Format(Date.Now, "dd/MM/yyyy")
        txtNomeConj.Clear()
        txtTelConj.Clear()
        txtSenha.Clear()
        txtLoginUsuario.Clear()




    End Sub

    Private Sub frmFuncionarios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnInserir.Enabled = True
        btnAlterar.Enabled = False
        btnExcluir.Enabled = False
        btnCancelar.Enabled = False
    End Sub

    Private Sub frmFuncionarioS_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        limparCampos()
        dt_funcionarios.Clear()
    End Sub

    Private Sub dgvFuncionarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFuncionarios.CellContentClick

    End Sub
End Class