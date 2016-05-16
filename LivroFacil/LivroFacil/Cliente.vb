Public Class FrmCliente
    Dim dt_cliente As New DataTable

    Private Sub dgvCliente_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Label12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Btn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub BtnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        End
    End Sub

    Private Sub DgvCliente_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub btnInserir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInserir.Click
        Try
            If txtNome.Text = String.Empty Then
                MsgBox("Campo Nome não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                txtNome.Focus()
            ElseIf txtEndereco.Text = String.Empty Then
                MsgBox("Campo Endereço não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                txtEndereco.Focus()
            ElseIf txtBairro.Text = String.Empty Then
                MsgBox("Campo Bairro não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                txtBairro.Focus()
            ElseIf txtCep.Text = String.Empty Then
                MsgBox("Campo CEP não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                txtCep.Focus()
            ElseIf txtCpfCnpj.Text = String.Empty Then
                MsgBox("Campo CPF não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                txtCpfCnpj.Focus()
                'ElseIf txtRG.Text = String.Empty Then
                '   MsgBox("Campo RG não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                '  txtRG.Focus()
                'ElseIf DtpDtaNasc.Text = Format(Date.Now, "dd/MM/yyyy") Then
                '   MsgBox("Campo Data não pode ser a data atual!", MsgBoxStyle.Exclamation, "Alerta!")
                '  DtpDtaNasc.Focus()
                ' ElseIf txtSexo.Text = String.Empty Then
                '    MsgBox("Campo Sexo não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                '   txtSexo.Focus()
                'ElseIf txtEstCivil.Text = String.Empty Then
                '   MsgBox("Campo Estado Civil não preenchido!", MsgBoxStyle.Exclamation, "Alerta!")
                '  txtEstCivil.Focus()
            ElseIf cboxUF.Text = String.Empty Then
                MsgBox("Campo Uf Vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                cboxUF.Focus()
            ElseIf cboxCidade.Text = String.Empty Then
                MsgBox("Campo Cidade vazio!", MsgBoxStyle.Exclamation, "Alerta!")
                cboxCidade.Focus()


            Else


                sql = "INSERT INTO TBCLIENTE (CLINOME, CLIENDERECO, CLIBAIRRO, CLICEP, CLICPFCNPJ, CLIRG, CLIDTNASC, CLISEXO, CLIESTADOCIVIL, CLITELEFONE, CLICELULAR, CLIEMAIL, CLIDTCAD, CLIUF, CLICIDADE) VALUES ('" & txtNome.Text & "', '" & txtEndereco.Text & "', '" & txtBairro.Text & "', '" & txtCep.Text & "','" & txtCpfCnpj.Text & "', '" & txtRG.Text & "', '" & DtpDtaNasc.Text & "', '" & txtSexo.Text & "', '" & txtEstCivil.Text & "', '" & txtFone.Text & "', '" & txtCelular.Text & "', '" & txtEmail.Text & "', '" & DtpDtCadastro.Text & "', '" & cboxUF.Text & "', '" & cboxCidade.Text & "')"
                executaSQL(sql)
                MsgBox("Cadastro realizado com sucesso!", MsgBoxStyle.Information, "Alerta!")
                limparCampos()
                dt_cliente.Clear()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)


        End Try
    End Sub

    Private Sub cboxUF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxUF.Click
        sql = "SELECT ESTADOID, SIGLA FROM ESTADO ORDER BY SIGLA"
        dt_cliente = consultaSQL(sql)
        cboxUF.DataSource = dt_cliente
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
                dt_cliente = consultaSQL(sql)
                cboxCidade.DataSource = dt_cliente
                cboxCidade.DisplayMember = "NOME"
                cboxCidade.ValueMember = "CIDADEID"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
    Public Sub limparCampos()
        txtNome.Clear()
        txtEndereco.Clear()
        txtRG.Clear()
        txtCpfCnpj.Clear()
        txtSexo.Clear()
        txtEstCivil.Clear()
        cboxCidade.Text = ""
        cboxUF.Text = ""
        txtBairro.Clear()
        txtCep.Clear()
        txtFone.Clear()
        txtCelular.Clear()
        txtEmail.Clear()
        DtpDtaNasc.Text = Format(Date.Now, "dd/MM/yyyy")
        DtpDtCadastro.Text = Format(Date.Now, "dd/MM/yyyy")

    End Sub

    Private Sub btnPesquisar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPesquisar.Click
        Try
            sql = "SELECT CLINOME, CLIENDERECO, CLIBAIRRO, CLICIDADE, CLIUF, CLICEP, CLICPFCNPJ, CLIRG, CLIDTNASC, CLISEXO, CLIESTADOCIVIL, CLITELEFONE, CLICELULAR, CLIEMAIL, CLIDTCAD  FROM TBCLIENTE"
            If Not txtPesquisarCli.Text = String.Empty Then
                sql = sql & " WHERE CLINOME LIKE '%" & txtPesquisarCli.Text & "%'"
            End If
            dt_cliente = consultaSQL(sql)
            dgvCliente.DataSource = dt_cliente

        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub dgvCliente_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvCliente.DoubleClick
        Try
            txtNome.Text = dgvCliente.SelectedCells.Item(0).Value
            txtEndereco.Text = dgvCliente.SelectedCells.Item(1).Value
            txtBairro.Text = dgvCliente.SelectedCells.Item(2).Value
            cboxCidade.Text = IIf(dgvCliente.SelectedCells.Item(3).Value Is DBNull.Value, String.Empty, dgvCliente.SelectedCells.Item(3).Value)
            cboxUF.Text = IIf(dgvCliente.SelectedCells.Item(4).Value Is DBNull.Value, String.Empty, dgvCliente.SelectedCells.Item(4).Value)
            txtCep.Text = dgvCliente.SelectedCells.Item(5).Value
            txtRG.Text = dgvCliente.SelectedCells.Item(7).Value
            txtCpfCnpj.Text = dgvCliente.SelectedCells.Item(6).Value
            DtpDtaNasc.Text = dgvCliente.SelectedCells.Item(8).Value
            txtSexo.Text = dgvCliente.SelectedCells.Item(9).Value
            txtEstCivil.Text = dgvCliente.SelectedCells.Item(10).Value
            txtFone.Text = dgvCliente.SelectedCells.Item(11).Value
            txtCelular.Text = dgvCliente.SelectedCells.Item(12).Value
            txtEmail.Text = IIf(dgvCliente.SelectedCells.Item(13).Value Is DBNull.Value, String.Empty, dgvCliente.SelectedCells.Item(13).Value)
            DtpDtCadastro.Text = dgvCliente.SelectedCells.Item(14).Value

            btnInserir.Enabled = False
            btnAlterar.Enabled = True
            btnExcluir.Enabled = True
            btnCancelar.Enabled = True


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click, Button1.Click
        Try
            sql = "UPDATE TBCLIENTE SET CLINOME = '" & txtNome.Text & "', CLIENDERECO = '" & txtEndereco.Text & "', CLIBAIRRO = '" & txtBairro.Text & "', CLICEP = '" & txtCep.Text & "', CLICPFCNPJ = '" & txtCpfCnpj.Text & "', CLIRG = '" & txtRG.Text & "', CLIDTNASC = '" & DtpDtaNasc.Text & "', CLISEXO = '" & txtSexo.Text & "', CLIESTADOCIVIL = '" & txtEstCivil.Text & "', CLITELEFONE = '" & txtFone.Text & "', CLICELULAR = '" & txtCelular.Text & "', CLIEMAIL = '" & txtEmail.Text & "', CLIDTCAD = '" & DtpDtCadastro.Text & "', CLIUF = '" & cboxUF.Text & "', CLICIDADE = '" & cboxCidade.Text & "' WHERE CLICPFCNPJ LIKE '" & txtCpfCnpj.Text & "'"
            executaSQL(sql)
            MsgBox("Alteração realizada com sucesso!", MsgBoxStyle.Information, "Alerta!")
            limparCampos()

            dt_cliente.Clear()
            btnInserir.Enabled = True
            btnAlterar.Enabled = False
            btnExcluir.Enabled = False
            btnCancelar.Enabled = False




        Catch ex As Exception
            conexao.Close()
            MsgBox(ex.Message)



        End Try
    End Sub

    Private Sub FrmCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        btnInserir.Enabled = True
        btnAlterar.Enabled = False
        btnExcluir.Enabled = False
        btnCancelar.Enabled = False


    End Sub

    Private Sub btnExcluir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluir.Click, Button3.Click
        Try
            If MsgBox("Deseja realmente excluir este registro?", MsgBoxStyle.OkCancel, "Alerta!") = MsgBoxResult.Ok Then
                sql = "DELETE FROM TBCLIENTE WHERE CLICPFCNPJ = " & txtCpfCnpj.Text
                executaSQL(sql)
                limparCampos()
                MsgBox("Exclusão realizada com sucesso!", MsgBoxStyle.Information, "Alerta!")
                dt_cliente.Clear()
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click, Button2.Click
        Try
            limparCampos()
            dt_cliente.Clear()
            btnInserir.Enabled = True
            btnAlterar.Enabled = False
            btnExcluir.Enabled = False
            btnCancelar.Enabled = False

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub

    Private Sub FrmCliente_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        limparCampos()
        dt_cliente.Clear()

    End Sub

    Private Sub DtpDtCadastro_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DtpDtCadastro.ValueChanged

    End Sub

    Private Sub txtPesquisar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPesquisarCli.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    
End Class