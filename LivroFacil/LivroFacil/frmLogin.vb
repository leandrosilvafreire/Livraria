Public Class FrmLogin

    Dim dt_Login As New DataTable

    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            vServidor = "LSF-PC\SQLEXPRESS"
            vBanco = "BDLIVROFACIL"
            vUsuario = "sa"
            vSenha = "l3@ndr0"

            criarConexao()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Try
            If txtUsuario.Text = "" Then
                MsgBox("Campo usu�rio est� em branco!", MsgBoxStyle.Exclamation, "Alerta")
                txtUsuario.Focus()
            ElseIf txtSenha.Text = "" Then
                MsgBox("Campo senha est� em branco!", MsgBoxStyle.Exclamation, "Alerta")
                txtSenha.Focus()
            Else
                sql = "SELECT FUNCUSUARIO, FUNCSENHA FROM TBFUNCIONARIOS WHERE FUNCUSUARIO = '" & txtUsuario.Text & "'"
                dt_Login = consultaSQL(sql)
                If dt_Login.Rows.Count > 0 Then
                    If dt_Login.Rows(0)(1).ToString = txtSenha.Text Then
                        Me.Hide()
                        frmPrincipal.Show()



                    Else
                        MsgBox("Senha inv�lida", MsgBoxStyle.Exclamation, "Alerta")

                    End If
                Else
                    MsgBox("Usu�rio inv�lido!", MsgBoxStyle.Exclamation, "Alerta")
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        End
    End Sub
End Class
