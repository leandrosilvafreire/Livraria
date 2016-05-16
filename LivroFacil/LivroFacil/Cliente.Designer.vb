<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCliente))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnPesquisar = New System.Windows.Forms.Button
        Me.txtPesquisarCli = New System.Windows.Forms.TextBox
        Me.dgvCliente = New System.Windows.Forms.DataGridView
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
        Me.GbCadastro = New System.Windows.Forms.GroupBox
        Me.DtpDtaNasc = New System.Windows.Forms.DateTimePicker
        Me.txtCep = New System.Windows.Forms.MaskedTextBox
        Me.txtRG = New System.Windows.Forms.TextBox
        Me.txtCelular = New System.Windows.Forms.MaskedTextBox
        Me.txtFone = New System.Windows.Forms.MaskedTextBox
        Me.DtpDtCadastro = New System.Windows.Forms.DateTimePicker
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtEstCivil = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtSexo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.cboxUF = New System.Windows.Forms.ComboBox
        Me.Button3 = New System.Windows.Forms.Button
        Me.btnExcluir = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnAlterar = New System.Windows.Forms.Button
        Me.btnInserir = New System.Windows.Forms.Button
        Me.cboxCidade = New System.Windows.Forms.ComboBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtBairro = New System.Windows.Forms.TextBox
        Me.txtEndereco = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.txtCpfCnpj = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GbCadastro.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnPesquisar)
        Me.GroupBox1.Controls.Add(Me.txtPesquisarCli)
        Me.GroupBox1.Controls.Add(Me.dgvCliente)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(783, 294)
        Me.GroupBox1.TabIndex = 87
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta"
        '
        'btnPesquisar
        '
        Me.btnPesquisar.Image = CType(resources.GetObject("btnPesquisar.Image"), System.Drawing.Image)
        Me.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnPesquisar.Location = New System.Drawing.Point(561, 12)
        Me.btnPesquisar.Name = "btnPesquisar"
        Me.btnPesquisar.Size = New System.Drawing.Size(92, 32)
        Me.btnPesquisar.TabIndex = 159
        Me.btnPesquisar.Text = "Pesquisar"
        Me.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnPesquisar.UseVisualStyleBackColor = True
        '
        'txtPesquisarCli
        '
        Me.txtPesquisarCli.Location = New System.Drawing.Point(12, 19)
        Me.txtPesquisarCli.Name = "txtPesquisarCli"
        Me.txtPesquisarCli.Size = New System.Drawing.Size(543, 20)
        Me.txtPesquisarCli.TabIndex = 76
        '
        'dgvCliente
        '
        Me.dgvCliente.AllowUserToAddRows = False
        Me.dgvCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCliente.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14, Me.Column15})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvCliente.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvCliente.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvCliente.Location = New System.Drawing.Point(3, 49)
        Me.dgvCliente.Name = "dgvCliente"
        Me.dgvCliente.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvCliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvCliente.RowHeadersVisible = False
        Me.dgvCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvCliente.Size = New System.Drawing.Size(777, 242)
        Me.dgvCliente.TabIndex = 75
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "CLINOME"
        Me.Column1.HeaderText = "NOME"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 64
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "CLIENDERECO"
        Me.Column2.HeaderText = "ENDEREÇO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 92
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "CLIBAIRRO"
        Me.Column3.HeaderText = "BAIRRO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 73
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "CLICIDADE"
        Me.Column4.HeaderText = "CIDADE"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 72
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "CLIUF"
        Me.Column5.HeaderText = "ESTADO"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 76
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "CLICEP"
        Me.Column6.HeaderText = "CEP"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 53
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "CLICPFCNPJ"
        Me.Column7.HeaderText = "CPF/CNPJ"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 84
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "CLIRG"
        Me.Column8.HeaderText = "RG"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 48
        '
        'Column9
        '
        Me.Column9.DataPropertyName = "CLIDTNASC"
        Me.Column9.HeaderText = "DATA NASC."
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 88
        '
        'Column10
        '
        Me.Column10.DataPropertyName = "CLISEXO"
        Me.Column10.HeaderText = "SEXO"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 61
        '
        'Column11
        '
        Me.Column11.DataPropertyName = "CLIESTADOCIVIL"
        Me.Column11.HeaderText = "EST. CIVIL"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 79
        '
        'Column12
        '
        Me.Column12.DataPropertyName = "CLITELEFONE"
        Me.Column12.HeaderText = "TELEFONE"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 88
        '
        'Column13
        '
        Me.Column13.DataPropertyName = "CLICELULAR"
        Me.Column13.HeaderText = "CELULAR"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 81
        '
        'Column14
        '
        Me.Column14.DataPropertyName = "CLIEMAIL"
        Me.Column14.HeaderText = "E-MAIL"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 67
        '
        'Column15
        '
        Me.Column15.DataPropertyName = "CLIDTCAD"
        Me.Column15.HeaderText = "DATA CADASTRO"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 113
        '
        'GbCadastro
        '
        Me.GbCadastro.Controls.Add(Me.txtCpfCnpj)
        Me.GbCadastro.Controls.Add(Me.DtpDtaNasc)
        Me.GbCadastro.Controls.Add(Me.txtCep)
        Me.GbCadastro.Controls.Add(Me.txtRG)
        Me.GbCadastro.Controls.Add(Me.txtCelular)
        Me.GbCadastro.Controls.Add(Me.txtFone)
        Me.GbCadastro.Controls.Add(Me.DtpDtCadastro)
        Me.GbCadastro.Controls.Add(Me.Label16)
        Me.GbCadastro.Controls.Add(Me.Label14)
        Me.GbCadastro.Controls.Add(Me.txtEstCivil)
        Me.GbCadastro.Controls.Add(Me.Label12)
        Me.GbCadastro.Controls.Add(Me.txtSexo)
        Me.GbCadastro.Controls.Add(Me.Label11)
        Me.GbCadastro.Controls.Add(Me.Label10)
        Me.GbCadastro.Controls.Add(Me.Label9)
        Me.GbCadastro.Controls.Add(Me.cboxUF)
        Me.GbCadastro.Controls.Add(Me.Button3)
        Me.GbCadastro.Controls.Add(Me.btnExcluir)
        Me.GbCadastro.Controls.Add(Me.Button2)
        Me.GbCadastro.Controls.Add(Me.btnCancelar)
        Me.GbCadastro.Controls.Add(Me.Button1)
        Me.GbCadastro.Controls.Add(Me.btnAlterar)
        Me.GbCadastro.Controls.Add(Me.btnInserir)
        Me.GbCadastro.Controls.Add(Me.cboxCidade)
        Me.GbCadastro.Controls.Add(Me.Label13)
        Me.GbCadastro.Controls.Add(Me.txtEmail)
        Me.GbCadastro.Controls.Add(Me.Label15)
        Me.GbCadastro.Controls.Add(Me.txtBairro)
        Me.GbCadastro.Controls.Add(Me.txtEndereco)
        Me.GbCadastro.Controls.Add(Me.Label7)
        Me.GbCadastro.Controls.Add(Me.Label6)
        Me.GbCadastro.Controls.Add(Me.Label5)
        Me.GbCadastro.Controls.Add(Me.Label4)
        Me.GbCadastro.Controls.Add(Me.Label3)
        Me.GbCadastro.Controls.Add(Me.Label2)
        Me.GbCadastro.Controls.Add(Me.Label1)
        Me.GbCadastro.Controls.Add(Me.txtNome)
        Me.GbCadastro.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GbCadastro.Location = New System.Drawing.Point(0, 300)
        Me.GbCadastro.Name = "GbCadastro"
        Me.GbCadastro.Size = New System.Drawing.Size(783, 223)
        Me.GbCadastro.TabIndex = 86
        Me.GbCadastro.TabStop = False
        Me.GbCadastro.Text = "Cadastro"
        '
        'DtpDtaNasc
        '
        Me.DtpDtaNasc.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtaNasc.Location = New System.Drawing.Point(9, 149)
        Me.DtpDtaNasc.Name = "DtpDtaNasc"
        Me.DtpDtaNasc.Size = New System.Drawing.Size(100, 20)
        Me.DtpDtaNasc.TabIndex = 169
        '
        'txtCep
        '
        Me.txtCep.Location = New System.Drawing.Point(600, 66)
        Me.txtCep.Mask = "00000-999"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(61, 20)
        Me.txtCep.TabIndex = 6
        '
        'txtRG
        '
        Me.txtRG.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRG.Location = New System.Drawing.Point(440, 110)
        Me.txtRG.MaxLength = 11
        Me.txtRG.Name = "txtRG"
        Me.txtRG.Size = New System.Drawing.Size(100, 20)
        Me.txtRG.TabIndex = 11
        '
        'txtCelular
        '
        Me.txtCelular.Location = New System.Drawing.Point(95, 110)
        Me.txtCelular.Mask = "(99) 0000-0000"
        Me.txtCelular.Name = "txtCelular"
        Me.txtCelular.Size = New System.Drawing.Size(80, 20)
        Me.txtCelular.TabIndex = 8
        '
        'txtFone
        '
        Me.txtFone.Location = New System.Drawing.Point(9, 110)
        Me.txtFone.Mask = "(99) 0000-0000"
        Me.txtFone.Name = "txtFone"
        Me.txtFone.Size = New System.Drawing.Size(80, 20)
        Me.txtFone.TabIndex = 7
        '
        'DtpDtCadastro
        '
        Me.DtpDtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DtpDtCadastro.Location = New System.Drawing.Point(291, 149)
        Me.DtpDtCadastro.Name = "DtpDtCadastro"
        Me.DtpDtCadastro.Size = New System.Drawing.Size(100, 20)
        Me.DtpDtCadastro.TabIndex = 15
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(288, 133)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(93, 13)
        Me.Label16.TabIndex = 167
        Me.Label16.Text = "Data do Cadastro:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(155, 134)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 166
        Me.Label14.Text = "Estado Civil:"
        '
        'txtEstCivil
        '
        Me.txtEstCivil.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstCivil.Location = New System.Drawing.Point(155, 149)
        Me.txtEstCivil.MaxLength = 20
        Me.txtEstCivil.Name = "txtEstCivil"
        Me.txtEstCivil.Size = New System.Drawing.Size(130, 20)
        Me.txtEstCivil.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(115, 134)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 164
        Me.Label12.Text = "Sexo:"
        '
        'txtSexo
        '
        Me.txtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSexo.Location = New System.Drawing.Point(115, 149)
        Me.txtSexo.Name = "txtSexo"
        Me.txtSexo.Size = New System.Drawing.Size(34, 20)
        Me.txtSexo.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 133)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 161
        Me.Label11.Text = "Data de Nascimento:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(437, 95)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 13)
        Me.Label10.TabIndex = 159
        Me.Label10.Text = "RG:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 12)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 13)
        Me.Label9.TabIndex = 157
        Me.Label9.Text = "CPF/CNPJ:"
        '
        'cboxUF
        '
        Me.cboxUF.DropDownHeight = 99
        Me.cboxUF.FormattingEnabled = True
        Me.cboxUF.IntegralHeight = False
        Me.cboxUF.Location = New System.Drawing.Point(422, 68)
        Me.cboxUF.Name = "cboxUF"
        Me.cboxUF.Size = New System.Drawing.Size(45, 21)
        Me.cboxUF.TabIndex = 4
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(545, 177)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 40)
        Me.Button3.TabIndex = 155
        Me.Button3.Text = "Excluir  "
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExcluir.Image = CType(resources.GetObject("btnExcluir.Image"), System.Drawing.Image)
        Me.btnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnExcluir.Location = New System.Drawing.Point(545, 177)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(100, 40)
        Me.btnExcluir.TabIndex = 155
        Me.btnExcluir.Text = "Excluir  "
        Me.btnExcluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(672, 177)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 40)
        Me.Button2.TabIndex = 154
        Me.Button2.Text = "Cancelar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Image = CType(resources.GetObject("btnCancelar.Image"), System.Drawing.Image)
        Me.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCancelar.Location = New System.Drawing.Point(672, 177)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(100, 40)
        Me.btnCancelar.TabIndex = 154
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(424, 177)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 40)
        Me.Button1.TabIndex = 153
        Me.Button1.Text = "Alterar  "
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.Image = CType(resources.GetObject("btnAlterar.Image"), System.Drawing.Image)
        Me.btnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnAlterar.Location = New System.Drawing.Point(424, 177)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(100, 40)
        Me.btnAlterar.TabIndex = 153
        Me.btnAlterar.Text = "Alterar  "
        Me.btnAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'btnInserir
        '
        Me.btnInserir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInserir.Image = CType(resources.GetObject("btnInserir.Image"), System.Drawing.Image)
        Me.btnInserir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInserir.Location = New System.Drawing.Point(301, 177)
        Me.btnInserir.Name = "btnInserir"
        Me.btnInserir.Size = New System.Drawing.Size(100, 40)
        Me.btnInserir.TabIndex = 152
        Me.btnInserir.Text = "Inserir  "
        Me.btnInserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInserir.UseVisualStyleBackColor = True
        '
        'cboxCidade
        '
        Me.cboxCidade.DropDownHeight = 99
        Me.cboxCidade.FormattingEnabled = True
        Me.cboxCidade.IntegralHeight = False
        Me.cboxCidade.Location = New System.Drawing.Point(473, 66)
        Me.cboxCidade.Name = "cboxCidade"
        Me.cboxCidade.Size = New System.Drawing.Size(121, 21)
        Me.cboxCidade.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(92, 95)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(42, 13)
        Me.Label13.TabIndex = 142
        Me.Label13.Text = "Celular:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(181, 110)
        Me.txtEmail.MaxLength = 40
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 20)
        Me.txtEmail.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(178, 93)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 147
        Me.Label15.Text = "E-mail:"
        '
        'txtBairro
        '
        Me.txtBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBairro.Location = New System.Drawing.Point(288, 69)
        Me.txtBairro.MaxLength = 30
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(128, 20)
        Me.txtBairro.TabIndex = 3
        '
        'txtEndereco
        '
        Me.txtEndereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEndereco.Location = New System.Drawing.Point(8, 69)
        Me.txtEndereco.MaxLength = 30
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(274, 20)
        Me.txtEndereco.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 127
        Me.Label7.Text = "Telefone:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(597, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "CEP:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(285, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 125
        Me.Label5.Text = "Bairro:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(472, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 124
        Me.Label4.Text = "Cidade:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(420, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 123
        Me.Label3.Text = "UF:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 122
        Me.Label2.Text = "Endereço:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(226, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 121
        Me.Label1.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNome.Location = New System.Drawing.Point(229, 27)
        Me.txtNome.MaxLength = 40
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(432, 20)
        Me.txtNome.TabIndex = 1
        '
        'txtCpfCnpj
        '
        Me.txtCpfCnpj.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCpfCnpj.Location = New System.Drawing.Point(12, 27)
        Me.txtCpfCnpj.MaxLength = 18
        Me.txtCpfCnpj.Name = "txtCpfCnpj"
        Me.txtCpfCnpj.Size = New System.Drawing.Size(208, 20)
        Me.txtCpfCnpj.TabIndex = 170
        '
        'FrmCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 523)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GbCadastro)
        Me.Name = "FrmCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cliente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GbCadastro.ResumeLayout(False)
        Me.GbCadastro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPesquisarCli As System.Windows.Forms.TextBox
    Friend WithEvents dgvCliente As System.Windows.Forms.DataGridView
    Friend WithEvents GbCadastro As System.Windows.Forms.GroupBox
    Friend WithEvents cboxCidade As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtEndereco As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents btnExcluir As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
    Friend WithEvents btnInserir As System.Windows.Forms.Button
    Friend WithEvents btnPesquisar As System.Windows.Forms.Button
    Friend WithEvents cboxUF As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtEstCivil As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtSexo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents DtpDtCadastro As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtCelular As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtFone As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCep As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtRG As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents DtpDtaNasc As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
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
    Friend WithEvents txtCpfCnpj As System.Windows.Forms.TextBox
End Class
