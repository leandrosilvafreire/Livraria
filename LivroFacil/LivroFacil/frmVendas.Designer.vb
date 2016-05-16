<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVendas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVendas))
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.dgvVendas = New System.Windows.Forms.DataGridView
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.cboxOperacao = New System.Windows.Forms.ComboBox
        Me.Button4 = New System.Windows.Forms.Button
        Me.txtFinalVend = New System.Windows.Forms.Button
        Me.btnAdicionar = New System.Windows.Forms.Button
        Me.txtCliente = New System.Windows.Forms.ComboBox
        Me.txtLivro = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.txtQtde = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DtpDtVenda = New System.Windows.Forms.DateTimePicker
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvVendas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 180
        Me.Label5.Text = "Nome do cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(331, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 187
        Me.Label2.Text = "Título do livro:"
        '
        'dgvVendas
        '
        Me.dgvVendas.AllowUserToAddRows = False
        Me.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVendas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvVendas.Location = New System.Drawing.Point(6, 97)
        Me.dgvVendas.Name = "dgvVendas"
        Me.dgvVendas.RowHeadersVisible = False
        Me.dgvVendas.Size = New System.Drawing.Size(689, 216)
        Me.dgvVendas.TabIndex = 190
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 13)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "Qtde:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 195
        Me.Label6.Text = "Forma de pagamento:"
        '
        'cboxOperacao
        '
        Me.cboxOperacao.FormattingEnabled = True
        Me.cboxOperacao.Location = New System.Drawing.Point(127, 322)
        Me.cboxOperacao.Name = "cboxOperacao"
        Me.cboxOperacao.Size = New System.Drawing.Size(220, 21)
        Me.cboxOperacao.TabIndex = 196
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(430, 353)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(125, 40)
        Me.Button4.TabIndex = 201
        Me.Button4.Text = "Cancelar venda"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtFinalVend
        '
        Me.txtFinalVend.Image = CType(resources.GetObject("txtFinalVend.Image"), System.Drawing.Image)
        Me.txtFinalVend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.txtFinalVend.Location = New System.Drawing.Point(570, 353)
        Me.txtFinalVend.Name = "txtFinalVend"
        Me.txtFinalVend.Size = New System.Drawing.Size(125, 40)
        Me.txtFinalVend.TabIndex = 198
        Me.txtFinalVend.Text = "Concluir venda"
        Me.txtFinalVend.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.txtFinalVend.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionar.Location = New System.Drawing.Point(595, 56)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(90, 31)
        Me.btnAdicionar.TabIndex = 197
        Me.btnAdicionar.Text = "Adicionar  "
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'txtCliente
        '
        Me.txtCliente.FormattingEnabled = True
        Me.txtCliente.Location = New System.Drawing.Point(12, 25)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(316, 21)
        Me.txtCliente.TabIndex = 204
        '
        'txtLivro
        '
        Me.txtLivro.FormattingEnabled = True
        Me.txtLivro.Location = New System.Drawing.Point(334, 25)
        Me.txtLivro.Name = "txtLivro"
        Me.txtLivro.Size = New System.Drawing.Size(354, 21)
        Me.txtLivro.TabIndex = 205
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(547, 325)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 206
        Me.Label1.Text = "Total:"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(585, 323)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 207
        '
        'txtQtde
        '
        Me.txtQtde.Location = New System.Drawing.Point(14, 65)
        Me.txtQtde.Name = "txtQtde"
        Me.txtQtde.Size = New System.Drawing.Size(100, 20)
        Me.txtQtde.TabIndex = 208
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(427, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 13)
        Me.Label4.TabIndex = 209
        Me.Label4.Text = "Data da venda:"
        Me.Label4.Visible = False
        '
        'DtpDtVenda
        '
        Me.DtpDtVenda.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtVenda.Location = New System.Drawing.Point(430, 65)
        Me.DtpDtVenda.Name = "DtpDtVenda"
        Me.DtpDtVenda.Size = New System.Drawing.Size(151, 20)
        Me.DtpDtVenda.TabIndex = 210
        Me.DtpDtVenda.Visible = False
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CLINOME"
        Me.Column1.HeaderText = "NOME DO CLIENTE"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "LIVTITULO"
        Me.Column2.HeaderText = "TITULO"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "QTDEITEM"
        Me.Column3.HeaderText = "QUANTIDADE"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "VALORVENDA"
        Me.Column4.HeaderText = "VALOR DO LIVRO"
        Me.Column4.Name = "Column4"
        '
        'frmVendas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 400)
        Me.Controls.Add(Me.DtpDtVenda)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQtde)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLivro)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.txtFinalVend)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.cboxOperacao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgvVendas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Name = "frmVendas"
        Me.Text = "Vendas"
        CType(Me.dgvVendas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvVendas As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cboxOperacao As System.Windows.Forms.ComboBox
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents txtFinalVend As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtCliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtLivro As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents txtQtde As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DtpDtVenda As System.Windows.Forms.DateTimePicker
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
