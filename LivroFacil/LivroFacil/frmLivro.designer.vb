<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLivro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLivro))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GbCadastro = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.cboxGenero = New System.Windows.Forms.ComboBox()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.btnInserir = New System.Windows.Forms.Button()
        Me.txtEdicaoLivro = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtVolLivro = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtOrigLivro = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtAnoLanc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtNrPagLiv = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIsbnLivro = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAutorLivro = New System.Windows.Forms.TextBox()
        Me.txtEditoraLivro = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtTituloLivro = New System.Windows.Forms.TextBox()
        Me.GbConsulta = New System.Windows.Forms.GroupBox()
        Me.btnPesqForn = New System.Windows.Forms.Button()
        Me.dgvLivro = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtGenero = New System.Windows.Forms.TextBox()
        Me.txtEditora = New System.Windows.Forms.TextBox()
        Me.txtIsbn = New System.Windows.Forms.TextBox()
        Me.txtAutor = New System.Windows.Forms.TextBox()
        Me.txtTitulo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GbCadastro.SuspendLayout()
        Me.GbConsulta.SuspendLayout()
        CType(Me.dgvLivro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbCadastro
        '
        Me.GbCadastro.Controls.Add(Me.Label11)
        Me.GbCadastro.Controls.Add(Me.txtDescricao)
        Me.GbCadastro.Controls.Add(Me.cboxGenero)
        Me.GbCadastro.Controls.Add(Me.btnExcluir)
        Me.GbCadastro.Controls.Add(Me.btnCancelar)
        Me.GbCadastro.Controls.Add(Me.btnAlterar)
        Me.GbCadastro.Controls.Add(Me.btnInserir)
        Me.GbCadastro.Controls.Add(Me.txtEdicaoLivro)
        Me.GbCadastro.Controls.Add(Me.Label16)
        Me.GbCadastro.Controls.Add(Me.txtVolLivro)
        Me.GbCadastro.Controls.Add(Me.Label15)
        Me.GbCadastro.Controls.Add(Me.txtOrigLivro)
        Me.GbCadastro.Controls.Add(Me.Label14)
        Me.GbCadastro.Controls.Add(Me.txtAnoLanc)
        Me.GbCadastro.Controls.Add(Me.Label12)
        Me.GbCadastro.Controls.Add(Me.Label13)
        Me.GbCadastro.Controls.Add(Me.txtNrPagLiv)
        Me.GbCadastro.Controls.Add(Me.Label9)
        Me.GbCadastro.Controls.Add(Me.txtIsbnLivro)
        Me.GbCadastro.Controls.Add(Me.Label8)
        Me.GbCadastro.Controls.Add(Me.txtAutorLivro)
        Me.GbCadastro.Controls.Add(Me.txtEditoraLivro)
        Me.GbCadastro.Controls.Add(Me.Label7)
        Me.GbCadastro.Controls.Add(Me.Label17)
        Me.GbCadastro.Controls.Add(Me.Label21)
        Me.GbCadastro.Controls.Add(Me.txtTituloLivro)
        Me.GbCadastro.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GbCadastro.Location = New System.Drawing.Point(0, 280)
        Me.GbCadastro.Name = "GbCadastro"
        Me.GbCadastro.Size = New System.Drawing.Size(782, 243)
        Me.GbCadastro.TabIndex = 129
        Me.GbCadastro.TabStop = False
        Me.GbCadastro.Text = "Cadastro"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 99)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 173
        Me.Label11.Text = "Descrição:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(9, 115)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(303, 117)
        Me.txtDescricao.TabIndex = 172
        '
        'cboxGenero
        '
        Me.cboxGenero.FormattingEnabled = True
        Me.cboxGenero.Location = New System.Drawing.Point(9, 71)
        Me.cboxGenero.Name = "cboxGenero"
        Me.cboxGenero.Size = New System.Drawing.Size(215, 21)
        Me.cboxGenero.TabIndex = 171
        '
        'btnExcluir
        '
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(557, 192)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(100, 40)
        Me.btnExcluir.TabIndex = 162
        Me.btnExcluir.Text = "Excluir  "
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(667, 192)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 161
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(449, 192)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(100, 40)
        Me.btnAlterar.TabIndex = 156
        Me.btnAlterar.Text = "Alterar  "
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnInserir
        '
        Me.btnInserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserir.Image = CType(resources.GetObject("btnInserir.Image"), System.Drawing.Image)
        Me.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInserir.Location = New System.Drawing.Point(340, 192)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(100, 40)
        Me.btnInserir.TabIndex = 155
        Me.btnInserir.Text = "Inserir  "
        Me.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'txtEdicaoLivro
        '
        Me.txtEdicaoLivro.Location = New System.Drawing.Point(285, 70)
        Me.txtEdicaoLivro.Name = "txtEdicaoLivro"
        Me.txtEdicaoLivro.Size = New System.Drawing.Size(104, 20)
        Me.txtEdicaoLivro.TabIndex = 148
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(282, 53)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(43, 13)
        Me.Label16.TabIndex = 147
        Me.Label16.Text = "Edição:"
        '
        'txtVolLivro
        '
        Me.txtVolLivro.Location = New System.Drawing.Point(232, 70)
        Me.txtVolLivro.Name = "txtVolLivro"
        Me.txtVolLivro.Size = New System.Drawing.Size(44, 20)
        Me.txtVolLivro.TabIndex = 146
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(231, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(45, 13)
        Me.Label15.TabIndex = 145
        Me.Label15.Text = "Volume:"
        '
        'txtOrigLivro
        '
        Me.txtOrigLivro.Location = New System.Drawing.Point(500, 70)
        Me.txtOrigLivro.Name = "txtOrigLivro"
        Me.txtOrigLivro.Size = New System.Drawing.Size(106, 20)
        Me.txtOrigLivro.TabIndex = 144
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(497, 54)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 13)
        Me.Label14.TabIndex = 143
        Me.Label14.Text = "Origem:"
        '
        'txtAnoLanc
        '
        Me.txtAnoLanc.Location = New System.Drawing.Point(395, 70)
        Me.txtAnoLanc.Name = "txtAnoLanc"
        Me.txtAnoLanc.Size = New System.Drawing.Size(99, 20)
        Me.txtAnoLanc.TabIndex = 142
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(392, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 13)
        Me.Label12.TabIndex = 141
        Me.Label12.Text = "Ano de lançamento:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(45, 13)
        Me.Label13.TabIndex = 140
        Me.Label13.Text = "Gênero:"
        '
        'txtNrPagLiv
        '
        Me.txtNrPagLiv.Location = New System.Drawing.Point(612, 70)
        Me.txtNrPagLiv.Name = "txtNrPagLiv"
        Me.txtNrPagLiv.Size = New System.Drawing.Size(109, 20)
        Me.txtNrPagLiv.TabIndex = 138
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(609, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 137
        Me.Label9.Text = "Nº de Páginas:"
        '
        'txtIsbnLivro
        '
        Me.txtIsbnLivro.Location = New System.Drawing.Point(9, 32)
        Me.txtIsbnLivro.Name = "txtIsbnLivro"
        Me.txtIsbnLivro.Size = New System.Drawing.Size(112, 20)
        Me.txtIsbnLivro.TabIndex = 136
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 15)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 135
        Me.Label8.Text = "ISBN:"
        '
        'txtAutorLivro
        '
        Me.txtAutorLivro.Location = New System.Drawing.Point(384, 31)
        Me.txtAutorLivro.Name = "txtAutorLivro"
        Me.txtAutorLivro.Size = New System.Drawing.Size(146, 20)
        Me.txtAutorLivro.TabIndex = 134
        '
        'txtEditoraLivro
        '
        Me.txtEditoraLivro.Location = New System.Drawing.Point(536, 32)
        Me.txtEditoraLivro.Name = "txtEditoraLivro"
        Me.txtEditoraLivro.Size = New System.Drawing.Size(175, 20)
        Me.txtEditoraLivro.TabIndex = 133
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(533, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 132
        Me.Label7.Text = "Editora:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(381, 15)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 13)
        Me.Label17.TabIndex = 131
        Me.Label17.Text = "Autor:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(127, 16)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(38, 13)
        Me.Label21.TabIndex = 130
        Me.Label21.Text = "Título:"
        '
        'txtTituloLivro
        '
        Me.txtTituloLivro.Location = New System.Drawing.Point(127, 32)
        Me.txtTituloLivro.Name = "txtTituloLivro"
        Me.txtTituloLivro.Size = New System.Drawing.Size(251, 20)
        Me.txtTituloLivro.TabIndex = 129
        '
        'GbConsulta
        '
        Me.GbConsulta.Controls.Add(Me.btnPesqForn)
        Me.GbConsulta.Controls.Add(Me.dgvLivro)
        Me.GbConsulta.Controls.Add(Me.txtGenero)
        Me.GbConsulta.Controls.Add(Me.txtEditora)
        Me.GbConsulta.Controls.Add(Me.txtIsbn)
        Me.GbConsulta.Controls.Add(Me.txtAutor)
        Me.GbConsulta.Controls.Add(Me.txtTitulo)
        Me.GbConsulta.Controls.Add(Me.Label5)
        Me.GbConsulta.Controls.Add(Me.Label4)
        Me.GbConsulta.Controls.Add(Me.Label3)
        Me.GbConsulta.Controls.Add(Me.Label2)
        Me.GbConsulta.Controls.Add(Me.Label1)
        Me.GbConsulta.Dock = System.Windows.Forms.DockStyle.Top
        Me.GbConsulta.Location = New System.Drawing.Point(0, 0)
        Me.GbConsulta.Name = "GbConsulta"
        Me.GbConsulta.Size = New System.Drawing.Size(782, 277)
        Me.GbConsulta.TabIndex = 130
        Me.GbConsulta.TabStop = False
        Me.GbConsulta.Text = "Consulta"
        '
        'btnPesqForn
        '
        Me.btnPesqForn.Image = CType(resources.GetObject("btnPesqForn.Image"), System.Drawing.Image)
        Me.btnPesqForn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesqForn.Location = New System.Drawing.Point(36, 225)
        Me.btnPesqForn.Name = "btnPesqForn"
        Me.btnPesqForn.Size = New System.Drawing.Size(92, 32)
        Me.btnPesqForn.TabIndex = 129
        Me.btnPesqForn.Text = "Pesquisar"
        Me.btnPesqForn.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesqForn.UseVisualStyleBackColor = True
        '
        'dgvLivro
        '
        Me.dgvLivro.AllowUserToAddRows = False
        Me.dgvLivro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLivro.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLivro.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column11, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column12})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvLivro.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvLivro.Dock = System.Windows.Forms.DockStyle.Right
        Me.dgvLivro.Location = New System.Drawing.Point(195, 16)
        Me.dgvLivro.Name = "dgvLivro"
        Me.dgvLivro.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvLivro.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvLivro.RowHeadersVisible = False
        Me.dgvLivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLivro.Size = New System.Drawing.Size(584, 258)
        Me.dgvLivro.TabIndex = 128
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "LIVISBN"
        Me.Column1.HeaderText = "ISBN"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 57
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "LIVTITULO"
        Me.Column2.HeaderText = "TÍTULO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 71
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "LIVAUTOR"
        Me.Column3.HeaderText = "AUTOR"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 70
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "LIVEDITORA"
        Me.Column4.HeaderText = "EDITORA"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 80
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "LIVSECAO"
        Me.Column5.HeaderText = "GÊNERO"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 78
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "LIVDESCRICAO"
        Me.Column6.HeaderText = "DESCRIÇÃO"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 94
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "LIVEDICAO"
        Me.Column11.HeaderText = "EDIÇÃO"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 72
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "LIVVOLUME"
        Me.Column7.HeaderText = "VOLUME"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 77
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "LIVANOLANC"
        Me.Column8.HeaderText = "ANDO LANÇAMENTO"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 128
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "LIVORIGEM"
        Me.Column9.HeaderText = "ORIGEM"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 75
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "LIVNRPAG"
        Me.Column10.HeaderText = "NRO PÁG."
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 78
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "LIVFORNEC"
        Me.Column12.HeaderText = "FORNECEDOR"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 107
        '
        'txtGenero
        '
        Me.txtGenero.Location = New System.Drawing.Point(8, 190)
        Me.txtGenero.Name = "txtGenero"
        Me.txtGenero.Size = New System.Drawing.Size(139, 20)
        Me.txtGenero.TabIndex = 126
        '
        'txtEditora
        '
        Me.txtEditora.Location = New System.Drawing.Point(8, 151)
        Me.txtEditora.Name = "txtEditora"
        Me.txtEditora.Size = New System.Drawing.Size(153, 20)
        Me.txtEditora.TabIndex = 125
        '
        'txtIsbn
        '
        Me.txtIsbn.Location = New System.Drawing.Point(8, 112)
        Me.txtIsbn.Name = "txtIsbn"
        Me.txtIsbn.Size = New System.Drawing.Size(120, 20)
        Me.txtIsbn.TabIndex = 124
        '
        'txtAutor
        '
        Me.txtAutor.Location = New System.Drawing.Point(8, 73)
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Size = New System.Drawing.Size(157, 20)
        Me.txtAutor.TabIndex = 123
        '
        'txtTitulo
        '
        Me.txtTitulo.Location = New System.Drawing.Point(8, 34)
        Me.txtTitulo.Name = "txtTitulo"
        Me.txtTitulo.Size = New System.Drawing.Size(143, 20)
        Me.txtTitulo.TabIndex = 122
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 174)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 121
        Me.Label5.Text = "Gênero:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Editora:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "ISBN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 118
        Me.Label2.Text = "Autor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 117
        Me.Label1.Text = "Titulo:"
        '
        'frmLivro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 523)
        Me.Controls.Add(Me.GbConsulta)
        Me.Controls.Add(Me.GbCadastro)
        Me.MaximizeBox = False
        Me.Name = "frmLivro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta/Cadastro de Livros"
        Me.GbCadastro.ResumeLayout(False)
        Me.GbCadastro.PerformLayout()
        Me.GbConsulta.ResumeLayout(False)
        Me.GbConsulta.PerformLayout()
        CType(Me.dgvLivro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GbCadastro As System.Windows.Forms.GroupBox
    Friend WithEvents txtEdicaoLivro As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtVolLivro As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtOrigLivro As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtAnoLanc As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNrPagLiv As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtIsbnLivro As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAutorLivro As System.Windows.Forms.TextBox
    Friend WithEvents txtEditoraLivro As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtTituloLivro As System.Windows.Forms.TextBox
    Friend WithEvents GbConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents dgvLivro As System.Windows.Forms.DataGridView
    Friend WithEvents txtGenero As System.Windows.Forms.TextBox
    Friend WithEvents txtEditora As System.Windows.Forms.TextBox
    Friend WithEvents txtIsbn As System.Windows.Forms.TextBox
    Friend WithEvents txtAutor As System.Windows.Forms.TextBox
    Friend WithEvents txtTitulo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents btnPesqForn As System.Windows.Forms.Button
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents cboxGenero As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
