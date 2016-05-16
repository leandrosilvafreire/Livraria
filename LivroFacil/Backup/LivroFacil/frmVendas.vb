Public Class frmVendas
    Dim dt_vendas As New DataTable


    Private Sub frmVendas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnPesqCli_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnPesqLiv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub btnAdicionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdicionar.Click
        Try
            sql = "INSERT INTO TBVENDAS(CLINOME, LIVTITULO, DTVENDA, QTDEITEM) VALUES('" & txtCliente.Text & "', '" & txtLivro.Text & "', '" & DtpDtVenda.Text & "', '" & txtQtde.Text & "')"
            executaSQL(sql)
            sql = "SELECT V.CLINOME, V.LIVTITULO, V.DTVENDA, V.QTDEITEM, L.ITEMPRECOVENDA FROM TBVENDAS AS V INNER JOIN TBLIVRO AS L ON L.LIVISBN = V.LIVISBN WHERE V.CLINOME LIKE '" & txtCliente.Text & "' AND V.DTVENDA LIKE '" & DtpDtVenda.Text & "'"
            dt_vendas = consultaSQL(sql)
            dgvVendas.DataSource = dt_vendas


        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtCliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCliente.Click
        Try
            sql = "SELECT CLICPF, CLINOME FROM TBCLIENTE ORDER BY CLINOME"
            dt_vendas = consultaSQL(sql)
            txtCliente.DataSource = dt_vendas
            txtCliente.DisplayMember = "CLINOME"
            txtCliente.ValueMember = "CLICPF"

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub txtLivro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLivro.Click
        Try
            sql = "SELECT LIVISBN, LIVTITULO, LIVSECAO FROM TBLIVRO ORDER BY LIVTITULO"
            dt_vendas = consultaSQL(sql)
            txtLivro.DataSource = dt_vendas
            txtLivro.DisplayMember = "LIVTITULO"
            txtLivro.ValueMember = "LIVISBN"
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

   
    Private Sub txtQtde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtQtde.KeyPress
        If (Asc(e.KeyChar()) < Asc("0")) Or (Asc(e.KeyChar()) > Asc("9")) Then
            If (Asc(e.KeyChar()) <> 9) Then
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub

    Private Sub txtParcelas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If (Asc(e.KeyChar()) < Asc("0")) Or (Asc(e.KeyChar()) > Asc("9")) Then
            If (Asc(e.KeyChar()) <> 9) Then
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub

   
    Private Sub cboxOperacao_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboxOperacao.Click
        Try
            sql = "SELECT OPECODIGO, OPETIPO FROM TBOPERACAO ORDER BY OPETIPO"
            dt_vendas = consultaSQL(sql)
            cboxOperacao.DataSource = dt_vendas
            cboxOperacao.DisplayMember = "OPETIPO"
            cboxOperacao.ValueMember = "OPECODIGO"
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub
End Class