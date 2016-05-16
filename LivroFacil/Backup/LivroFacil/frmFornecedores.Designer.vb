<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFornecedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFornecedores))
        Me.gbConsulta = New System.Windows.Forms.GroupBox
        Me.dgvFornecedores = New System.Windows.Forms.DataGridView
        Me.btnPesquisar = New System.Windows.Forms.Button
        Me.txtPesquisarForn = New System.Windows.Forms.TextBox
        Me.gbCadastro = New System.Windows.Forms.GroupBox
        Me.txtCep = New System.Windows.Forms.MaskedTextBox
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.DtpDtCadastro = New System.Windows.Forms.DateTimePicker
        Me.cboxUF = New System.Windows.Forms.ComboBox
        Me.txtFoneFor = New System.Windows.Forms.MaskedTextBox
        Me.txtFoneEmpresa = New System.Windows.Forms.MaskedTextBox
        Me.txtCelForn = New System.Windows.Forms.MaskedTextBox
        Me.cboxCidade = New System.Windows.Forms.ComboBox
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtRazSoc = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtNomeFan = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtInscEst = New System.Windows.Forms.TextBox
        Me.txtCnpj = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnInserir = New System.Windows.Forms.Button
        Me.txtBairroForn = New System.Windows.Forms.TextBox
        Me.txtEndForn = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.gbConsulta.SuspendLayout()
        CType(Me.dgvFornecedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbCadastro.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbConsulta
        '
        Me.gbConsulta.Controls.Add(Me.dgvFornecedores)
        Me.gbConsulta.Controls.Add(Me.btnPesquisar)
        Me.gbConsulta.Controls.Add(Me.txtPesquisarForn)
        Me.gbConsulta.Dock = System.Windows.Forms.DockStyle.Top
        Me.gbConsulta.Location = New System.Drawing.Point(0, 0)
        Me.gbConsulta.Name = "gbConsulta"
        Me.gbConsulta.Size = New System.Drawing.Size(782, 239)
        Me.gbConsulta.TabIndex = 46
        Me.gbConsulta.TabStop = False
        Me.gbConsulta.Text = "Consulta"
        '
        'dgvFornecedores
        '
        Me.dgvFornecedores.AllowUserToAddRows = False
        Me.dgvFornecedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvFornecedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFornecedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column11, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column12, Me.Column13, Me.Column14, Me.Column15, Me.Column16})
        Me.dgvFornecedores.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvFornecedores.Location = New System.Drawing.Point(3, 51)
        Me.dgvFornecedores.Name = "dgvFornecedores"
        Me.dgvFornecedores.ReadOnly = True
        Me.dgvFornecedores.RowHeadersVisible = False
        Me.dgvFornecedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFornecedores.Size = New System.Drawing.Size(776, 185)
        Me.dgvFornecedores.TabIndex = 51
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesquisar.Location = New System.Drawing.Point(559, 13)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(92, 32)
        Me.btnPesquisar.TabIndex = 50
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'txtPesquisarForn
        '
        Me.txtPesquisarForn.Location = New System.Drawing.Point(10, 19)
        Me.txtPesquisarForn.Name = "txtPesquisarForn"
        Me.txtPesquisarForn.Size = New System.Drawing.Size(543, 20)
        Me.txtPesquisarForn.TabIndex = 49
        '
        'gbCadastro
        '
        Me.gbCadastro.Controls.Add(Me.txtCep)
        Me.gbCadastro.Controls.Add(Me.btnExcluir)
        Me.gbCadastro.Controls.Add(Me.btnCancelar)
        Me.gbCadastro.Controls.Add(Me.DtpDtCadastro)
        Me.gbCadastro.Controls.Add(Me.cboxUF)
        Me.gbCadastro.Controls.Add(Me.txtFoneFor)
        Me.gbCadastro.Controls.Add(Me.txtFoneEmpresa)
        Me.gbCadastro.Controls.Add(Me.txtCelForn)
        Me.gbCadastro.Controls.Add(Me.cboxCidade)
        Me.gbCadastro.Controls.Add(Me.Label16)
        Me.gbCadastro.Controls.Add(Me.txtEmail)
        Me.gbCadastro.Controls.Add(Me.Label15)
        Me.gbCadastro.Controls.Add(Me.Label14)
        Me.gbCadastro.Controls.Add(Me.txtRazSoc)
        Me.gbCadastro.Controls.Add(Me.Label12)
        Me.gbCadastro.Controls.Add(Me.Label13)
        Me.gbCadastro.Controls.Add(Me.txtNomeFan)
        Me.gbCadastro.Controls.Add(Me.Label11)
        Me.gbCadastro.Controls.Add(Me.Label10)
        Me.gbCadastro.Controls.Add(Me.txtInscEst)
        Me.gbCadastro.Controls.Add(Me.txtCnpj)
        Me.gbCadastro.Controls.Add(Me.Label9)
        Me.gbCadastro.Controls.Add(Me.btnAlterar)
        Me.gbCadastro.Controls.Add(Me.btnInserir)
        Me.gbCadastro.Controls.Add(Me.txtBairroForn)
        Me.gbCadastro.Controls.Add(Me.txtEndForn)
        Me.gbCadastro.Controls.Add(Me.Label7)
        Me.gbCadastro.Controls.Add(Me.Label6)
        Me.gbCadastro.Controls.Add(Me.Label5)
        Me.gbCadastro.Controls.Add(Me.Label4)
        Me.gbCadastro.Controls.Add(Me.Label3)
        Me.gbCadastro.Controls.Add(Me.Label2)
        Me.gbCadastro.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbCadastro.Location = New System.Drawing.Point(0, 245)
        Me.gbCadastro.Name = "gbCadastro"
        Me.gbCadastro.Size = New System.Drawing.Size(782, 278)
        Me.gbCadastro.TabIndex = 47
        Me.gbCadastro.TabStop = False
        Me.gbCadastro.Text = "Cadastro"
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(708, 73)
        Me.txtCep.Mask = "00000-999"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(61, 20)
        Me.txtCep.TabIndex = 158
        '
        'btnExcluir
        '
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(558, 226)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(100, 40)
        Me.btnExcluir.TabIndex = 157
        Me.btnExcluir.Text = "Excluir  "
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(664, 226)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 156
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'DtpDtCadastro
        '
        Me.DtpDtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtCadastro.Location = New System.Drawing.Point(14, 205)
        Me.DtpDtCadastro.Name = "DtpDtCadastro"
        Me.DtpDtCadastro.Size = New System.Drawing.Size(107, 20)
        Me.DtpDtCadastro.TabIndex = 83
        '
        'cboxUF
        '
        Me.cboxUF.FormattingEnabled = True
        Me.cboxUF.Location = New System.Drawing.Point(461, 72)
        Me.cboxUF.Name = "cboxUF"
        Me.cboxUF.Size = New System.Drawing.Size(47, 21)
        Me.cboxUF.TabIndex = 82
        '
        'txtFoneFor
        '
        Me.txtFoneFor.Location = New System.Drawing.Point(15, 112)
        Me.txtFoneFor.Mask = "(99) 0000-0000"
        Me.txtFoneFor.Name = "txtFoneFor"
        Me.txtFoneFor.Size = New System.Drawing.Size(85, 20)
        Me.txtFoneFor.TabIndex = 80
        '
        'txtFoneEmpresa
        '
        Me.txtFoneEmpresa.Location = New System.Drawing.Point(253, 112)
        Me.txtFoneEmpresa.Mask = "(99) 0000-0000"
        Me.txtFoneEmpresa.Name = "txtFoneEmpresa"
        Me.txtFoneEmpresa.Size = New System.Drawing.Size(85, 20)
        Me.txtFoneEmpresa.TabIndex = 79
        '
        'txtCelForn
        '
        Me.txtCelForn.Location = New System.Drawing.Point(139, 112)
        Me.txtCelForn.Mask = "(99) 0000-0000"
        Me.txtCelForn.Name = "txtCelForn"
        Me.txtCelForn.Size = New System.Drawing.Size(85, 20)
        Me.txtCelForn.TabIndex = 78
        '
        'cboxCidade
        '
        Me.cboxCidade.FormattingEnabled = True
        Me.cboxCidade.Location = New System.Drawing.Point(525, 72)
        Me.cboxCidade.Name = "cboxCidade"
        Me.cboxCidade.Size = New System.Drawing.Size(121, 21)
        Me.cboxCidade.TabIndex = 77
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(227, 95)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(111, 13)
        Me.Label16.TabIndex = 76
        Me.Label16.Text = "Telefone de Empresa:"
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Location = New System.Drawing.Point(527, 112)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(243, 20)
        Me.txtEmail.TabIndex = 75
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(524, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 74
        Me.Label15.Text = "E-mail:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 188)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(93, 13)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "Data do Cadastro:"
        '
        'txtRazSoc
        '
        Me.txtRazSoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRazSoc.Location = New System.Drawing.Point(126, 33)
        Me.txtRazSoc.MaxLength = 40
        Me.txtRazSoc.Name = "txtRazSoc"
        Me.txtRazSoc.Size = New System.Drawing.Size(520, 20)
        Me.txtRazSoc.TabIndex = 72
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(123, 16)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(73, 13)
        Me.Label12.TabIndex = 71
        Me.Label12.Text = "Razão Social:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(140, 96)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 70
        Me.Label13.Text = "Celular:"
        '
        'txtNomeFan
        '
        Me.txtNomeFan.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNomeFan.Location = New System.Drawing.Point(15, 165)
        Me.txtNomeFan.MaxLength = 40
        Me.txtNomeFan.Name = "txtNomeFan"
        Me.txtNomeFan.Size = New System.Drawing.Size(371, 20)
        Me.txtNomeFan.TabIndex = 69
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 13)
        Me.Label11.TabIndex = 68
        Me.Label11.Text = "Nome Fantasia:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(136, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 13)
        Me.Label10.TabIndex = 67
        Me.Label10.Text = "Inscrição Estadual:"
        '
        'txtInscEst
        '
        Me.txtInscEst.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtInscEst.Location = New System.Drawing.Point(136, 204)
        Me.txtInscEst.MaxLength = 15
        Me.txtInscEst.Name = "txtInscEst"
        Me.txtInscEst.Size = New System.Drawing.Size(100, 20)
        Me.txtInscEst.TabIndex = 66
        '
        'txtCnpj
        '
        Me.txtCnpj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCnpj.Location = New System.Drawing.Point(15, 33)
        Me.txtCnpj.MaxLength = 18
        Me.txtCnpj.Name = "txtCnpj"
        Me.txtCnpj.Size = New System.Drawing.Size(106, 20)
        Me.txtCnpj.TabIndex = 65
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(37, 13)
        Me.Label9.TabIndex = 64
        Me.Label9.Text = "CNPJ:"
        '
        'btnAlterar
        '
        Me.btnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(452, 226)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(100, 40)
        Me.btnAlterar.TabIndex = 59
        Me.btnAlterar.Text = "Alterar  "
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnInserir
        '
        Me.btnInserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserir.Image = CType(resources.GetObject("btnInserir.Image"), System.Drawing.Image)
        Me.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInserir.Location = New System.Drawing.Point(343, 226)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(100, 40)
        Me.btnInserir.TabIndex = 58
        Me.btnInserir.Text = "Inserir  "
        Me.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'txtBairroForn
        '
        Me.txtBairroForn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairroForn.Location = New System.Drawing.Point(305, 72)
        Me.txtBairroForn.MaxLength = 30
        Me.txtBairroForn.Name = "txtBairroForn"
        Me.txtBairroForn.Size = New System.Drawing.Size(138, 20)
        Me.txtBairroForn.TabIndex = 55
        '
        'txtEndForn
        '
        Me.txtEndForn.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndForn.Location = New System.Drawing.Point(14, 73)
        Me.txtEndForn.MaxLength = 40
        Me.txtEndForn.Name = "txtEndForn"
        Me.txtEndForn.Size = New System.Drawing.Size(283, 20)
        Me.txtEndForn.TabIndex = 54
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 13)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Telefone do Fornecedor:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(705, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 52
        Me.Label6.Text = "CEP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(302, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 51
        Me.Label5.Text = "Bairro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(524, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Cidade:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(458, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "UF:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Endereço:"
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "FORRAZAOSOC"
        Me.Column11.HeaderText = "RAZÃO SOCIAL"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 101
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "FORENDERECO"
        Me.Column3.HeaderText = "ENDEREÇO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 92
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "FORBAIRRO"
        Me.Column4.HeaderText = "BAIRRO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 73
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "FORCIDADE"
        Me.Column5.HeaderText = "CIDADE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 72
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "FORUF"
        Me.Column6.HeaderText = "UF"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 46
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "FORCEP"
        Me.Column7.HeaderText = "CEP"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 53
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "FORCNPJ"
        Me.Column8.HeaderText = "CNPJ"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 59
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "FORIE"
        Me.Column9.HeaderText = "INSCRIÇÃO ESTADUAL"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 137
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "FORNOMEFAN"
        Me.Column10.HeaderText = "NOME FANTASIA"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 109
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "FORTELEFONE"
        Me.Column12.HeaderText = "TELEFONE"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 88
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "FORCELULAR"
        Me.Column13.HeaderText = "CELULAR"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 81
        '
        'Column14
        '
        Me.Column14.DataPropertyName = "FORTELECONT"
        Me.Column14.HeaderText = "TELEFONE EMPRESA"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 131
        '
        'Column15
        '
        Me.Column15.DataPropertyName = "FOREMAIL"
        Me.Column15.HeaderText = "E-MAIL"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 67
        '
        'Column16
        '
        Me.Column16.DataPropertyName = "FORDTCAD"
        Me.Column16.HeaderText = "DATA DO CADASTRO"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 130
        '
        'frmFornecedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(782, 523)
        Me.Controls.Add(Me.gbCadastro)
        Me.Controls.Add(Me.gbConsulta)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmFornecedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta/Cadastro de Fornecedores"
        Me.gbConsulta.ResumeLayout(False)
        Me.gbConsulta.PerformLayout()
        CType(Me.dgvFornecedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbCadastro.ResumeLayout(False)
        Me.gbCadastro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents txtPesquisarForn As System.Windows.Forms.TextBox
    Friend WithEvents gbCadastro As System.Windows.Forms.GroupBox
    Friend WithEvents txtFoneFor As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFoneEmpresa As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCelForn As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cboxCidade As System.Windows.Forms.ComboBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtRazSoc As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtNomeFan As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtInscEst As System.Windows.Forms.TextBox
    Friend WithEvents txtCnpj As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents txtBairroForn As System.Windows.Forms.TextBox
    Friend WithEvents txtEndForn As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboxUF As System.Windows.Forms.ComboBox
    Friend WithEvents DtpDtCadastro As System.Windows.Forms.DateTimePicker
    Friend WithEvents dgvFornecedores As System.Windows.Forms.DataGridView
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents txtCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column16 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
