<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstoque
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEstoque))
        Me.DgvEstoque = New System.Windows.Forms.DataGridView
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.txtLivro = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TxtIsbn = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.DtpDtCadastro = New System.Windows.Forms.DateTimePicker
        Me.btnPesquisar = New System.Windows.Forms.Button
        CType(Me.DgvEstoque, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvEstoque
        '
        Me.DgvEstoque.AllowUserToAddRows = False
        Me.DgvEstoque.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DgvEstoque.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DgvEstoque.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEstoque.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DgvEstoque.Location = New System.Drawing.Point(3, 217)
        Me.DgvEstoque.Name = "DgvEstoque"
        Me.DgvEstoque.ReadOnly = True
        Me.DgvEstoque.RowHeadersVisible = False
        Me.DgvEstoque.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvEstoque.Size = New System.Drawing.Size(752, 276)
        Me.DgvEstoque.TabIndex = 14
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ESTCODIGO"
        Me.Column1.HeaderText = "CODIGO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 74
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
        Me.Column3.DataPropertyName = "ESTTITULIV"
        Me.Column3.HeaderText = "TITULO LIVRO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 97
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "ESTQUANTIDADE"
        Me.Column4.HeaderText = "QUANTIDADE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 103
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "ESTPRECOMPRA"
        Me.Column5.HeaderText = "PREÇO COMPRA"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 108
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "ESTPREVENDA"
        Me.Column6.HeaderText = "PREÇO VENDA"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "ESTDTENTR"
        Me.Column7.HeaderText = "DATA CADASTRO"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 113
        '
        'txtLivro
        '
        Me.txtLivro.Location = New System.Drawing.Point(12, 64)
        Me.txtLivro.Name = "txtLivro"
        Me.txtLivro.Size = New System.Drawing.Size(278, 20)
        Me.txtLivro.TabIndex = 244
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 243
        Me.Label8.Text = "Fornecedor:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 260
        Me.Label3.Text = "Título:"
        '
        'TxtIsbn
        '
        Me.TxtIsbn.Location = New System.Drawing.Point(12, 25)
        Me.TxtIsbn.Name = "TxtIsbn"
        Me.TxtIsbn.Size = New System.Drawing.Size(278, 20)
        Me.TxtIsbn.TabIndex = 261
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 4)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 262
        Me.Label2.Text = "Data Cadastro"
        '
        'DtpDtCadastro
        '
        Me.DtpDtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtCadastro.Location = New System.Drawing.Point(301, 20)
        Me.DtpDtCadastro.Name = "DtpDtCadastro"
        Me.DtpDtCadastro.Size = New System.Drawing.Size(200, 20)
        Me.DtpDtCadastro.TabIndex = 263
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesquisar.Location = New System.Drawing.Point(578, 21)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(92, 32)
        Me.btnPesquisar.TabIndex = 265
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'frmEstoque
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 505)
        Me.Controls.Add(Me.btnPesquisar)
        Me.Controls.Add(Me.DtpDtCadastro)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtIsbn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLivro)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DgvEstoque)
        Me.Name = "frmEstoque"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estoque"
        CType(Me.DgvEstoque, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DgvEstoque As System.Windows.Forms.DataGridView
    Friend WithEvents txtLivro As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtIsbn As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DtpDtCadastro As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
