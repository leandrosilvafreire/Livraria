<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCaixa
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
        Me.DtpDtAbertura = New System.Windows.Forms.DateTimePicker
        Me.CboxOperacao = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.TxtVlEntrada = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.TxtVlParc = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TxtParcAtual = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.TxtNotaFiscal = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.TxtCodCompras = New System.Windows.Forms.TextBox
        Me.txtCodVendas = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtCodFunc = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtCliente = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.DtpFechamento = New System.Windows.Forms.DateTimePicker
        Me.TxtQtParc = New System.Windows.Forms.TextBox
        Me.DtpVencParc = New System.Windows.Forms.DateTimePicker
        Me.DtpPgParc = New System.Windows.Forms.DateTimePicker
        Me.Label19 = New System.Windows.Forms.Label
        Me.CbxConfPag = New System.Windows.Forms.ComboBox
        Me.DgvCaixa = New System.Windows.Forms.DataGridView
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtFornecedor = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.TxtVlCompra = New System.Windows.Forms.TextBox
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.DgvCaixa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtpDtAbertura
        '
        Me.DtpDtAbertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtAbertura.Location = New System.Drawing.Point(195, 112)
        Me.DtpDtAbertura.Name = "DtpDtAbertura"
        Me.DtpDtAbertura.Size = New System.Drawing.Size(118, 20)
        Me.DtpDtAbertura.TabIndex = 187
        '
        'CboxOperacao
        '
        Me.CboxOperacao.FormattingEnabled = True
        Me.CboxOperacao.Location = New System.Drawing.Point(12, 113)
        Me.CboxOperacao.Name = "CboxOperacao"
        Me.CboxOperacao.Size = New System.Drawing.Size(153, 21)
        Me.CboxOperacao.TabIndex = 186
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(192, 97)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(105, 13)
        Me.Label16.TabIndex = 181
        Me.Label16.Text = "Data Abertura Caixa:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TxtVlEntrada
        '
        Me.TxtVlEntrada.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TxtVlEntrada.Location = New System.Drawing.Point(328, 113)
        Me.TxtVlEntrada.Name = "TxtVlEntrada"
        Me.TxtVlEntrada.Size = New System.Drawing.Size(156, 20)
        Me.TxtVlEntrada.TabIndex = 180
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(631, 151)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 13)
        Me.Label14.TabIndex = 178
        Me.Label14.Text = "Dt Pg Parc"
        '
        'TxtVlParc
        '
        Me.TxtVlParc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtVlParc.Location = New System.Drawing.Point(15, 224)
        Me.TxtVlParc.MaxLength = 40
        Me.TxtVlParc.Name = "TxtVlParc"
        Me.TxtVlParc.Size = New System.Drawing.Size(133, 20)
        Me.TxtVlParc.TabIndex = 177
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(316, 151)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 176
        Me.Label12.Text = "Parc Atual:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(328, 97)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(74, 13)
        Me.Label13.TabIndex = 175
        Me.Label13.Text = "Valor Entrada:"
        '
        'TxtParcAtual
        '
        Me.TxtParcAtual.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtParcAtual.Location = New System.Drawing.Point(314, 168)
        Me.TxtParcAtual.MaxLength = 40
        Me.TxtParcAtual.Name = "TxtParcAtual"
        Me.TxtParcAtual.Size = New System.Drawing.Size(88, 20)
        Me.TxtParcAtual.TabIndex = 174
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 151)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(124, 13)
        Me.Label11.TabIndex = 173
        Me.Label11.Text = "Data Fechamento Caixa:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(444, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(71, 13)
        Me.Label10.TabIndex = 172
        Me.Label10.Text = "Dt Venc Parc"
        '
        'TxtNotaFiscal
        '
        Me.TxtNotaFiscal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNotaFiscal.Location = New System.Drawing.Point(12, 25)
        Me.TxtNotaFiscal.MaxLength = 18
        Me.TxtNotaFiscal.Name = "TxtNotaFiscal"
        Me.TxtNotaFiscal.Size = New System.Drawing.Size(283, 20)
        Me.TxtNotaFiscal.TabIndex = 170
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 13)
        Me.Label9.TabIndex = 169
        Me.Label9.Text = "Nota Fiscal:"
        '
        'TxtCodCompras
        '
        Me.TxtCodCompras.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtCodCompras.Location = New System.Drawing.Point(680, 25)
        Me.TxtCodCompras.MaxLength = 30
        Me.TxtCodCompras.Name = "TxtCodCompras"
        Me.TxtCodCompras.Size = New System.Drawing.Size(137, 20)
        Me.TxtCodCompras.TabIndex = 168
        '
        'txtCodVendas
        '
        Me.txtCodVendas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodVendas.Location = New System.Drawing.Point(500, 25)
        Me.txtCodVendas.MaxLength = 40
        Me.txtCodVendas.Name = "txtCodVendas"
        Me.txtCodVendas.Size = New System.Drawing.Size(136, 20)
        Me.txtCodVendas.TabIndex = 167
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 97)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 166
        Me.Label7.Text = "Operação:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 165
        Me.Label6.Text = "Valor Parcela:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(683, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 164
        Me.Label5.Text = "Código Compras:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(192, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 162
        Me.Label3.Text = "Quant Parcela:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(497, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 161
        Me.Label2.Text = "Código Vendas:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(316, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 160
        Me.Label1.Text = "Código Funcionário:"
        '
        'txtCodFunc
        '
        Me.txtCodFunc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodFunc.Location = New System.Drawing.Point(319, 25)
        Me.txtCodFunc.MaxLength = 40
        Me.txtCodFunc.Name = "txtCodFunc"
        Me.txtCodFunc.Size = New System.Drawing.Size(151, 20)
        Me.txtCodFunc.TabIndex = 159
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 189
        Me.Label8.Text = "Cliente:"
        '
        'TxtCliente
        '
        Me.TxtCliente.Location = New System.Drawing.Point(15, 64)
        Me.TxtCliente.Name = "TxtCliente"
        Me.TxtCliente.Size = New System.Drawing.Size(364, 20)
        Me.TxtCliente.TabIndex = 190
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(665, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(66, 13)
        Me.Label18.TabIndex = 193
        Me.Label18.Text = "Saldo Caixa:"
        '
        'TextBox1
        '
        Me.TextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.TextBox1.Location = New System.Drawing.Point(668, 115)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(177, 20)
        Me.TextBox1.TabIndex = 194
        '
        'DtpFechamento
        '
        Me.DtpFechamento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpFechamento.Location = New System.Drawing.Point(12, 167)
        Me.DtpFechamento.Name = "DtpFechamento"
        Me.DtpFechamento.Size = New System.Drawing.Size(153, 20)
        Me.DtpFechamento.TabIndex = 195
        '
        'TxtQtParc
        '
        Me.TxtQtParc.Location = New System.Drawing.Point(195, 167)
        Me.TxtQtParc.Name = "TxtQtParc"
        Me.TxtQtParc.Size = New System.Drawing.Size(75, 20)
        Me.TxtQtParc.TabIndex = 197
        '
        'DtpVencParc
        '
        Me.DtpVencParc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpVencParc.Location = New System.Drawing.Point(447, 168)
        Me.DtpVencParc.Name = "DtpVencParc"
        Me.DtpVencParc.Size = New System.Drawing.Size(153, 20)
        Me.DtpVencParc.TabIndex = 198
        '
        'DtpPgParc
        '
        Me.DtpPgParc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpPgParc.Location = New System.Drawing.Point(634, 168)
        Me.DtpPgParc.Name = "DtpPgParc"
        Me.DtpPgParc.Size = New System.Drawing.Size(153, 20)
        Me.DtpPgParc.TabIndex = 199
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(173, 208)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(111, 13)
        Me.Label19.TabIndex = 200
        Me.Label19.Text = "Confirma Pagamento: "
        '
        'CbxConfPag
        '
        Me.CbxConfPag.FormattingEnabled = True
        Me.CbxConfPag.Location = New System.Drawing.Point(176, 224)
        Me.CbxConfPag.Name = "CbxConfPag"
        Me.CbxConfPag.Size = New System.Drawing.Size(81, 21)
        Me.CbxConfPag.TabIndex = 201
        '
        'DgvCaixa
        '
        Me.DgvCaixa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvCaixa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16, Me.Column17, Me.Column18})
        Me.DgvCaixa.Location = New System.Drawing.Point(2, 266)
        Me.DgvCaixa.Name = "DgvCaixa"
        Me.DgvCaixa.Size = New System.Drawing.Size(1049, 260)
        Me.DgvCaixa.TabIndex = 202
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(405, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 203
        Me.Label4.Text = "Fornecedor:"
        '
        'TxtFornecedor
        '
        Me.TxtFornecedor.Location = New System.Drawing.Point(408, 64)
        Me.TxtFornecedor.Name = "TxtFornecedor"
        Me.TxtFornecedor.Size = New System.Drawing.Size(409, 20)
        Me.TxtFornecedor.TabIndex = 204
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(501, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 13)
        Me.Label17.TabIndex = 205
        Me.Label17.Text = "Valor Saída:"
        '
        'TxtVlCompra
        '
        Me.TxtVlCompra.Location = New System.Drawing.Point(504, 112)
        Me.TxtVlCompra.Name = "TxtVlCompra"
        Me.TxtVlCompra.Size = New System.Drawing.Size(133, 20)
        Me.TxtVlCompra.TabIndex = 206
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CAINOTAFISCAL"
        Me.Column1.HeaderText = "NOTA FISCAL"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "FUNCCODIGO"
        Me.Column2.HeaderText = "FUNCIONÁRIO"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "CODVENDAS"
        Me.Column3.HeaderText = "CÓDIGO VENDAS"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "CODCOMPRAS"
        Me.Column4.HeaderText = "CÓDIGO COMPRAS"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "CLINOME"
        Me.Column5.HeaderText = "CLIENTE"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "FORNOME"
        Me.Column6.HeaderText = "FORNECEDOR"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "OPECODIGO"
        Me.Column7.HeaderText = "OPERAÇÃO"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "CAIDTENTRACAI"
        Me.Column8.HeaderText = "DT ABERTURA"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "CAIENTRAD"
        Me.Column9.HeaderText = "VL ENTRADA"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "CAISAID"
        Me.Column10.HeaderText = "VL SAÍDA"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "CAISALDO"
        Me.Column11.HeaderText = "SALDO CAIXA"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "CAIDTFECHCAI"
        Me.Column12.HeaderText = "DT FECHAMENTO"
        Me.Column12.Name = "Column12"
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "CAIQTDPARC"
        Me.Column13.HeaderText = "QT PARCELA"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.DataPropertyName = "CAIPARCATUAL"
        Me.Column14.HeaderText = "PARCELA ATUAL"
        Me.Column14.Name = "Column14"
        '
        'Column15
        '
        Me.Column15.DataPropertyName = "CAIDTVENCPAR"
        Me.Column15.HeaderText = "DTVENCPARC "
        Me.Column15.Name = "Column15"
        '
        'Column16
        '
        Me.Column16.DataPropertyName = "CAIDTPGTOPAR"
        Me.Column16.HeaderText = "DTPGPARC"
        Me.Column16.Name = "Column16"
        '
        'Column17
        '
        Me.Column17.DataPropertyName = "CAIVALORPARC"
        Me.Column17.HeaderText = "VLPARC"
        Me.Column17.Name = "Column17"
        '
        'Column18
        '
        Me.Column18.DataPropertyName = "CAICONFIRPG"
        Me.Column18.HeaderText = "CONPAG"
        Me.Column18.Name = "Column18"
        '
        'frmCaixa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1063, 526)
        Me.Controls.Add(Me.TxtVlCompra)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.TxtFornecedor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DgvCaixa)
        Me.Controls.Add(Me.CbxConfPag)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.DtpPgParc)
        Me.Controls.Add(Me.DtpVencParc)
        Me.Controls.Add(Me.TxtQtParc)
        Me.Controls.Add(Me.DtpFechamento)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.TxtCliente)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DtpDtAbertura)
        Me.Controls.Add(Me.CboxOperacao)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.TxtVlEntrada)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TxtVlParc)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.TxtParcAtual)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtNotaFiscal)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtCodCompras)
        Me.Controls.Add(Me.txtCodVendas)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodFunc)
        Me.Name = "frmCaixa"
        Me.Text = "Caixa"
        CType(Me.DgvCaixa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DtpDtAbertura As System.Windows.Forms.DateTimePicker
    Friend WithEvents CboxOperacao As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents TxtVlEntrada As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TxtVlParc As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TxtParcAtual As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TxtNotaFiscal As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TxtCodCompras As System.Windows.Forms.TextBox
    Friend WithEvents txtCodVendas As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCodFunc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtCliente As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DtpFechamento As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtQtParc As System.Windows.Forms.TextBox
    Friend WithEvents DtpVencParc As System.Windows.Forms.DateTimePicker
    Friend WithEvents DtpPgParc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents CbxConfPag As System.Windows.Forms.ComboBox
    Friend WithEvents DgvCaixa As System.Windows.Forms.DataGridView
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtFornecedor As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents TxtVlCompra As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column18 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
