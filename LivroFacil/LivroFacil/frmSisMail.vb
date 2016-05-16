Imports System.Net.Mail
Public Class frmSisMail
    Dim dt_email As New DataTable

    'usado para armazenar os anexos
    Dim Attachment As System.Net.Mail.Attachment
    'cria uma mensagem a enviar
    Dim MailMsg As New System.Net.Mail.MailMessage
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnIncluirAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIncluirAnexo.Click
        'Mostra caixa de dialogo para selecionar anexos
        Dim Conta As Integer
        OFD.CheckFileExists = True
        OFD.Title = "Selecione um arquivo para anexar"
        OFD.ShowDialog()

        For Conta = 0 To UBound(OFD.FileNames)
            lstAnexos.Items.Add(OFD.FileNames(Conta))
        Next
    End Sub

    Private Sub btnExcluirAnexo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcluirAnexo.Click
        If lstAnexos.SelectedIndex > -1 Then
            lstAnexos.Items.RemoveAt(lstAnexos.SelectedIndex)
        End If
    End Sub

    Private Sub btnEnviarEmail_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviarEmail.Click
        Try
            Dim i As Integer = 0
            'validação de dados

            If txtPara.Text = "" Then
                MsgBox("Informe o endereço de destino!", MsgBoxStyle.Information, "Enviar Email!")
                Exit Sub
            End If

            If txtAssunto.Text = "" Then
                MsgBox("Informe o assunto do email!", MsgBoxStyle.Information, "Enviar Email!")
                Exit Sub
            End If
            'endereça o remetente
            MailMsg.From = New MailAddress("severocostav2@gmail.com", "Sergio", System.Text.Encoding.UTF8)

            'endereça o recipiente
            MailMsg.To.Add(New MailAddress(txtPara.Text))

            Dim mSmtpCliente As New SmtpClient '(txtSmtp.Text)

            'Especifica o formato
            If chboxEnviarComoHtml.Checked = True Then
                MailMsg.IsBodyHtml = True
            End If

            'define o assunto
            MailMsg.Subject = txtAssunto.Text

            'Anexa os arquivos um por um
            For i = 0 To lstAnexos.Items.Count - 1
                MailMsg.Attachments.Add(New Attachment(lstAnexos.Items(i)))
            Next
            'Corpo do email
            MailMsg.Body = txtMensagem.Text
            mSmtpCliente.Host = "smtp.gmail.com"
            mSmtpCliente.Credentials = New System.Net.NetworkCredential("severocostav2@gmail.com", "samsung300")
            mSmtpCliente.EnableSsl = True

            'Envia o email
            mSmtpCliente.Send(MailMsg)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub txtPara_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPara.Click
        Try
            'TAINCOMPLETOAKI()
            sql = "SELECT CLI.CLICPF, CLI.CLINOME, CLI.CLIEMAIL, LIV.LIVDESCRICAO, SUM(VEN.QTDEITEM), FROM TBCLIENTE"
            dt_email = consultaSQL(sql)
            txtPara.DataSource = dt_email
            txtPara.DisplayMember = "CLIEMAIL"
            txtPara.ValueMember = "CLICPF"
            txtCc.Text = txtPara.SelectedItem(1)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
