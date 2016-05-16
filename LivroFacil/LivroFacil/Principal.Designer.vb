<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.mnuOpcoes = New System.Windows.Forms.MenuStrip()
        Me.mnuCadastros = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiteClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiteLivros = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuitFornecedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCaixa = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiteRegistrarConsultarVenda = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiteCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuiteSobre = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCompras = New System.Windows.Forms.Button()
        Me.btnEmail = New System.Windows.Forms.Button()
        Me.btnCliente = New System.Windows.Forms.Button()
        Me.btnfornecedores = New System.Windows.Forms.Button()
        Me.btnVendas = New System.Windows.Forms.Button()
        Me.btnFuncionarios = New System.Windows.Forms.Button()
        Me.btnLivro = New System.Windows.Forms.Button()
        Me.mnuOpcoes.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnuOpcoes
        '
        Me.mnuOpcoes.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuCadastros, Me.mnuCaixa, Me.mnuiteCadastro})
        Me.mnuOpcoes.Location = New System.Drawing.Point(0, 0)
        Me.mnuOpcoes.Name = "mnuOpcoes"
        Me.mnuOpcoes.Size = New System.Drawing.Size(1290, 24)
        Me.mnuOpcoes.TabIndex = 0
        Me.mnuOpcoes.Text = "MenuStrip1"
        '
        'mnuCadastros
        '
        Me.mnuCadastros.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiteClientes, Me.mnuiteLivros, Me.mnuitFornecedores, Me.FuncionáriosToolStripMenuItem})
        Me.mnuCadastros.Name = "mnuCadastros"
        Me.mnuCadastros.Size = New System.Drawing.Size(128, 20)
        Me.mnuCadastros.Text = "Cadastros/Consultas"
        '
        'mnuiteClientes
        '
        Me.mnuiteClientes.Name = "mnuiteClientes"
        Me.mnuiteClientes.Size = New System.Drawing.Size(145, 22)
        Me.mnuiteClientes.Text = "Clientes"
        '
        'mnuiteLivros
        '
        Me.mnuiteLivros.Name = "mnuiteLivros"
        Me.mnuiteLivros.Size = New System.Drawing.Size(145, 22)
        Me.mnuiteLivros.Text = "Livros"
        '
        'mnuitFornecedores
        '
        Me.mnuitFornecedores.Name = "mnuitFornecedores"
        Me.mnuitFornecedores.Size = New System.Drawing.Size(145, 22)
        Me.mnuitFornecedores.Text = "Fornecedores"
        '
        'FuncionáriosToolStripMenuItem
        '
        Me.FuncionáriosToolStripMenuItem.Name = "FuncionáriosToolStripMenuItem"
        Me.FuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.FuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'mnuCaixa
        '
        Me.mnuCaixa.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiteRegistrarConsultarVenda, Me.VendasToolStripMenuItem})
        Me.mnuCaixa.Name = "mnuCaixa"
        Me.mnuCaixa.Size = New System.Drawing.Size(71, 20)
        Me.mnuCaixa.Text = "Relatórios"
        '
        'mnuiteRegistrarConsultarVenda
        '
        Me.mnuiteRegistrarConsultarVenda.Name = "mnuiteRegistrarConsultarVenda"
        Me.mnuiteRegistrarConsultarVenda.Size = New System.Drawing.Size(116, 22)
        Me.mnuiteRegistrarConsultarVenda.Text = "Caixa"
        '
        'VendasToolStripMenuItem
        '
        Me.VendasToolStripMenuItem.Name = "VendasToolStripMenuItem"
        Me.VendasToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.VendasToolStripMenuItem.Text = "Estoque"
        '
        'mnuiteCadastro
        '
        Me.mnuiteCadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuiteSobre, Me.ToolStripSeparator1, Me.mnuSair})
        Me.mnuiteCadastro.Name = "mnuiteCadastro"
        Me.mnuiteCadastro.Size = New System.Drawing.Size(59, 20)
        Me.mnuiteCadastro.Text = "Opções"
        '
        'mnuiteSobre
        '
        Me.mnuiteSobre.Name = "mnuiteSobre"
        Me.mnuiteSobre.Size = New System.Drawing.Size(158, 22)
        Me.mnuiteSobre.Text = "Sobre o Sistema"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(155, 6)
        '
        'mnuSair
        '
        Me.mnuSair.Name = "mnuSair"
        Me.mnuSair.Size = New System.Drawing.Size(158, 22)
        Me.mnuSair.Text = "Sair"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.btnCompras)
        Me.Panel1.Controls.Add(Me.btnEmail)
        Me.Panel1.Controls.Add(Me.btnCliente)
        Me.Panel1.Controls.Add(Me.btnfornecedores)
        Me.Panel1.Controls.Add(Me.btnVendas)
        Me.Panel1.Controls.Add(Me.btnFuncionarios)
        Me.Panel1.Controls.Add(Me.btnLivro)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1290, 581)
        Me.Panel1.TabIndex = 9
        '
        'btnCompras
        '
        Me.btnCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompras.Image = CType(resources.GetObject("btnCompras.Image"), System.Drawing.Image)
        Me.btnCompras.Location = New System.Drawing.Point(420, 51)
        Me.btnCompras.Name = "btnCompras"
        Me.btnCompras.Size = New System.Drawing.Size(130, 109)
        Me.btnCompras.TabIndex = 10
        Me.btnCompras.Text = "Compras"
        Me.btnCompras.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCompras.UseVisualStyleBackColor = True
        '
        'btnEmail
        '
        Me.btnEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmail.Image = CType(resources.GetObject("btnEmail.Image"), System.Drawing.Image)
        Me.btnEmail.Location = New System.Drawing.Point(828, 51)
        Me.btnEmail.Name = "btnEmail"
        Me.btnEmail.Size = New System.Drawing.Size(130, 109)
        Me.btnEmail.TabIndex = 9
        Me.btnEmail.Text = "E-mailing"
        Me.btnEmail.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnEmail.UseVisualStyleBackColor = True
        '
        'btnCliente
        '
        Me.btnCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCliente.Image = CType(resources.GetObject("btnCliente.Image"), System.Drawing.Image)
        Me.btnCliente.Location = New System.Drawing.Point(692, 51)
        Me.btnCliente.Name = "btnCliente"
        Me.btnCliente.Size = New System.Drawing.Size(130, 109)
        Me.btnCliente.TabIndex = 8
        Me.btnCliente.Text = "Clientes"
        Me.btnCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCliente.UseVisualStyleBackColor = True
        '
        'btnfornecedores
        '
        Me.btnfornecedores.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfornecedores.Image = CType(resources.GetObject("btnfornecedores.Image"), System.Drawing.Image)
        Me.btnfornecedores.Location = New System.Drawing.Point(284, 51)
        Me.btnfornecedores.Name = "btnfornecedores"
        Me.btnfornecedores.Size = New System.Drawing.Size(130, 109)
        Me.btnfornecedores.TabIndex = 4
        Me.btnfornecedores.Text = "Fornecedores"
        Me.btnfornecedores.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnfornecedores.UseVisualStyleBackColor = True
        '
        'btnVendas
        '
        Me.btnVendas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVendas.Image = CType(resources.GetObject("btnVendas.Image"), System.Drawing.Image)
        Me.btnVendas.Location = New System.Drawing.Point(556, 51)
        Me.btnVendas.Name = "btnVendas"
        Me.btnVendas.Size = New System.Drawing.Size(130, 109)
        Me.btnVendas.TabIndex = 6
        Me.btnVendas.Text = "Vendas"
        Me.btnVendas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnVendas.UseVisualStyleBackColor = True
        '
        'btnFuncionarios
        '
        Me.btnFuncionarios.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFuncionarios.Image = CType(resources.GetObject("btnFuncionarios.Image"), System.Drawing.Image)
        Me.btnFuncionarios.Location = New System.Drawing.Point(148, 51)
        Me.btnFuncionarios.Name = "btnFuncionarios"
        Me.btnFuncionarios.Size = New System.Drawing.Size(130, 109)
        Me.btnFuncionarios.TabIndex = 3
        Me.btnFuncionarios.Text = "Funcionários"
        Me.btnFuncionarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnFuncionarios.UseVisualStyleBackColor = True
        '
        'btnLivro
        '
        Me.btnLivro.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLivro.Image = CType(resources.GetObject("btnLivro.Image"), System.Drawing.Image)
        Me.btnLivro.Location = New System.Drawing.Point(12, 51)
        Me.btnLivro.Name = "btnLivro"
        Me.btnLivro.Size = New System.Drawing.Size(130, 109)
        Me.btnLivro.TabIndex = 2
        Me.btnLivro.Text = "Livros"
        Me.btnLivro.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnLivro.UseVisualStyleBackColor = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1290, 581)
        Me.Controls.Add(Me.mnuOpcoes)
        Me.Controls.Add(Me.Panel1)
        Me.MainMenuStrip = Me.mnuOpcoes
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.Text = "Livro Fácil"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.mnuOpcoes.ResumeLayout(False)
        Me.mnuOpcoes.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuOpcoes As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuiteCadastro As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiteSobre As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCadastros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCaixa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuSair As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiteClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiteLivros As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuitFornecedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuiteRegistrarConsultarVenda As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncionáriosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VendasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnLivro As System.Windows.Forms.Button
    Friend WithEvents btnFuncionarios As System.Windows.Forms.Button
    Friend WithEvents btnfornecedores As System.Windows.Forms.Button
    Friend WithEvents btnVendas As System.Windows.Forms.Button
    Friend WithEvents btnCliente As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnEmail As System.Windows.Forms.Button
    Friend WithEvents btnCompras As System.Windows.Forms.Button
End Class
