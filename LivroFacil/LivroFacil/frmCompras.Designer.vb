<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompras
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompras))
        Me.Label6 = New System.Windows.Forms.Label
        Me.dgvCompras = New System.Windows.Forms.DataGridView
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnAdicionar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtIsbn = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtQuantidade = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtPrCompra = New System.Windows.Forms.TextBox
        Me.DtpDtCompra = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.BtnCancelarCom = New System.Windows.Forms.Button
        Me.BtnConcluir = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtTotal = New System.Windows.Forms.TextBox
        Me.BtnCancelar = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTitulo = New System.Windows.Forms.ComboBox
        Me.TxtFornecedor = New System.Windows.Forms.ComboBox
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 44)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 218
        Me.Label6.Text = "Fornecedor:"
        '
        'dgvCompras
        '
        Me.dgvCompras.AllowUserToAddRows = False
        Me.dgvCompras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvCompras.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompras.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column7})
        Me.dgvCompras.Location = New System.Drawing.Point(6, 179)
        Me.dgvCompras.Name = "dgvCompras"
        Me.dgvCompras.ReadOnly = True
        Me.dgvCompras.RowHeadersVisible = False
        Me.dgvCompras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCompras.Size = New System.Drawing.Size(689, 210)
        Me.dgvCompras.TabIndex = 213
        '
        'btnAlterar
        '
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(489, 142)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(90, 31)
        Me.btnAlterar.TabIndex = 230
        Me.btnAlterar.Text = "Alterar  "
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Image = CType(resources.GetObject("btnAdicionar.Image"), System.Drawing.Image)
        Me.btnAdicionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAdicionar.Location = New System.Drawing.Point(600, 142)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(90, 31)
        Me.btnAdicionar.TabIndex = 227
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 5)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 236
        Me.Label4.Text = "Código Compra:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(19, 21)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.ReadOnly = True
        Me.TxtCodigo.Size = New System.Drawing.Size(196, 20)
        Me.TxtCodigo.TabIndex = 239
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(222, 126)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 240
        Me.Label1.Text = "ISBN:"
        '
        'TxtIsbn
        '
        Me.TxtIsbn.Location = New System.Drawing.Point(225, 142)
        Me.TxtIsbn.Name = "TxtIsbn"
        Me.TxtIsbn.Size = New System.Drawing.Size(192, 20)
        Me.TxtIsbn.TabIndex = 241
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 13)
        Me.Label2.TabIndex = 242
        Me.Label2.Text = "Quantidade:"
        '
        'TxtQuantidade
        '
        Me.TxtQuantidade.Location = New System.Drawing.Point(19, 100)
        Me.TxtQuantidade.Name = "TxtQuantidade"
        Me.TxtQuantidade.Size = New System.Drawing.Size(91, 20)
        Me.TxtQuantidade.TabIndex = 243
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(163, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 244
        Me.Label3.Text = "Preço Compra:"
        '
        'TxtPrCompra
        '
        Me.TxtPrCompra.Location = New System.Drawing.Point(166, 100)
        Me.TxtPrCompra.Name = "TxtPrCompra"
        Me.TxtPrCompra.Size = New System.Drawing.Size(144, 20)
        Me.TxtPrCompra.TabIndex = 245
        '
        'DtpDtCompra
        '
        Me.DtpDtCompra.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtCompra.Location = New System.Drawing.Point(12, 147)
        Me.DtpDtCompra.Name = "DtpDtCompra"
        Me.DtpDtCompra.Size = New System.Drawing.Size(193, 20)
        Me.DtpDtCompra.TabIndex = 246
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 136)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 13)
        Me.Label5.TabIndex = 247
        Me.Label5.Text = "Data da Compra:"
        '
        'BtnCancelarCom
        '
        Me.BtnCancelarCom.Image = CType(resources.GetObject("BtnCancelarCom.Image"), System.Drawing.Image)
        Me.BtnCancelarCom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelarCom.Location = New System.Drawing.Point(6, 466)
        Me.BtnCancelarCom.Name = "BtnCancelarCom"
        Me.BtnCancelarCom.Size = New System.Drawing.Size(125, 40)
        Me.BtnCancelarCom.TabIndex = 249
        Me.BtnCancelarCom.Text = "Cancelar Compra"
        Me.BtnCancelarCom.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelarCom.UseVisualStyleBackColor = True
        '
        'BtnConcluir
        '
        Me.BtnConcluir.Image = CType(resources.GetObject("BtnConcluir.Image"), System.Drawing.Image)
        Me.BtnConcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnConcluir.Location = New System.Drawing.Point(146, 466)
        Me.BtnConcluir.Name = "BtnConcluir"
        Me.BtnConcluir.Size = New System.Drawing.Size(125, 40)
        Me.BtnConcluir.TabIndex = 248
        Me.BtnConcluir.Text = "Concluir Compra"
        Me.BtnConcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnConcluir.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(486, 404)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 250
        Me.Label7.Text = "Total:"
        '
        'TxtTotal
        '
        Me.TxtTotal.Location = New System.Drawing.Point(521, 401)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(174, 20)
        Me.TxtTotal.TabIndex = 251
        '
        'BtnCancelar
        '
        Me.BtnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelar.Image = CType(resources.GetObject("BtnCancelar.Image"), System.Drawing.Image)
        Me.BtnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BtnCancelar.Location = New System.Drawing.Point(287, 466)
        Me.BtnCancelar.Name = "BtnCancelar"
        Me.BtnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.BtnCancelar.TabIndex = 254
        Me.BtnCancelar.Text = "Cancelar"
        Me.BtnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnCancelar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(353, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 255
        Me.Label8.Text = "Título do livro:"
        '
        'txtTitulo
        '
        Me.txtTitulo.FormattingEnabled = True
        Me.txtTitulo.Location = New System.Drawing.Point(356, 60)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(334, 21)
        Me.txtTitulo.TabIndex = 256
        '
        'TxtFornecedor
        '
        Me.TxtFornecedor.FormattingEnabled = True
        Me.TxtFornecedor.Location = New System.Drawing.Point(19, 60)
        Me.TxtFornecedor.Name = "TxtFornecedor"
        Me.TxtFornecedor.Size = New System.Drawing.Size(330, 21)
        Me.TxtFornecedor.TabIndex = 257
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "CODCOMPRAS"
        Me.Column6.HeaderText = "CODIGO"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 74
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "FORNOME"
        Me.Column1.HeaderText = "FORNECEDOR"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 107
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "LIVISBN"
        Me.Column2.HeaderText = "ISBN"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 57
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "COMQUANTIDADE"
        Me.Column3.HeaderText = "QUANTIDADE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 103
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "COMPRECO"
        Me.Column4.HeaderText = "PREÇ. COMP."
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 101
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "COMDATA"
        Me.Column5.HeaderText = "DATA COMPRA"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 101
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "TOTAL"
        Me.Column7.HeaderText = "TOTAL"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 67
        '
        'frmCompras
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(702, 508)
        Me.Controls.Add(Me.TxtFornecedor)
        Me.Controls.Add(Me.txtTitulo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.BtnCancelar)
        Me.Controls.Add(Me.TxtTotal)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnCancelarCom)
        Me.Controls.Add(Me.BtnConcluir)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DtpDtCompra)
        Me.Controls.Add(Me.TxtPrCompra)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtQuantidade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtIsbn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtCodigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dgvCompras)
        Me.Name = "frmCompras"
        Me.Text = "Compras"
        CType(Me.dgvCompras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgvCompras As System.Windows.Forms.DataGridView
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnAdicionar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtIsbn As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtQuantidade As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtPrCompra As System.Windows.Forms.TextBox
    Friend WithEvents DtpDtCompra As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents BtnCancelarCom As System.Windows.Forms.Button
    Friend WithEvents BtnConcluir As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents BtnCancelar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTitulo As System.Windows.Forms.ComboBox
    Friend WithEvents TxtFornecedor As System.Windows.Forms.ComboBox
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
