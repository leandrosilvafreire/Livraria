<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSisMail
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
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtBcc = New System.Windows.Forms.TextBox
        Me.txtCc = New System.Windows.Forms.TextBox
        Me.txtMensagem = New System.Windows.Forms.TextBox
        Me.txtAssunto = New System.Windows.Forms.TextBox
        Me.lstAnexos = New System.Windows.Forms.ListBox
        Me.btnEnviarEmail = New System.Windows.Forms.Button
        Me.btnEnviaEmail = New System.Windows.Forms.Button
        Me.btnIncluirAnexo = New System.Windows.Forms.Button
        Me.btnExcluirAnexo = New System.Windows.Forms.Button
        Me.OFD = New System.Windows.Forms.OpenFileDialog
        Me.chboxEnviarComoHtml = New System.Windows.Forms.CheckBox
        Me.txtPara = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Para"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Bcc"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Assunto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(21, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CC"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Anexos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Mensagem"
        '
        'txtBcc
        '
        Me.txtBcc.Location = New System.Drawing.Point(97, 65)
        Me.txtBcc.Name = "txtBcc"
        Me.txtBcc.Size = New System.Drawing.Size(319, 20)
        Me.txtBcc.TabIndex = 11
        '
        'txtCc
        '
        Me.txtCc.Location = New System.Drawing.Point(97, 91)
        Me.txtCc.Name = "txtCc"
        Me.txtCc.Size = New System.Drawing.Size(319, 20)
        Me.txtCc.TabIndex = 12
        '
        'txtMensagem
        '
        Me.txtMensagem.Location = New System.Drawing.Point(99, 260)
        Me.txtMensagem.Multiline = True
        Me.txtMensagem.Name = "txtMensagem"
        Me.txtMensagem.Size = New System.Drawing.Size(426, 191)
        Me.txtMensagem.TabIndex = 5
        '
        'txtAssunto
        '
        Me.txtAssunto.Location = New System.Drawing.Point(98, 217)
        Me.txtAssunto.Name = "txtAssunto"
        Me.txtAssunto.Size = New System.Drawing.Size(427, 20)
        Me.txtAssunto.TabIndex = 4
        '
        'lstAnexos
        '
        Me.lstAnexos.FormattingEnabled = True
        Me.lstAnexos.Location = New System.Drawing.Point(98, 124)
        Me.lstAnexos.Name = "lstAnexos"
        Me.lstAnexos.Size = New System.Drawing.Size(319, 82)
        Me.lstAnexos.TabIndex = 17
        '
        'btnEnviarEmail
        '
        Me.btnEnviarEmail.Location = New System.Drawing.Point(97, 476)
        Me.btnEnviarEmail.Name = "btnEnviarEmail"
        Me.btnEnviarEmail.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviarEmail.TabIndex = 18
        Me.btnEnviarEmail.Text = "Enviar Email"
        Me.btnEnviarEmail.UseVisualStyleBackColor = True
        '
        'btnEnviaEmail
        '
        Me.btnEnviaEmail.Location = New System.Drawing.Point(194, 476)
        Me.btnEnviaEmail.Name = "btnEnviaEmail"
        Me.btnEnviaEmail.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviaEmail.TabIndex = 19
        Me.btnEnviaEmail.Text = "Envia Email"
        Me.btnEnviaEmail.UseVisualStyleBackColor = True
        '
        'btnIncluirAnexo
        '
        Me.btnIncluirAnexo.Location = New System.Drawing.Point(423, 124)
        Me.btnIncluirAnexo.Name = "btnIncluirAnexo"
        Me.btnIncluirAnexo.Size = New System.Drawing.Size(101, 23)
        Me.btnIncluirAnexo.TabIndex = 20
        Me.btnIncluirAnexo.Text = "Incluir Anexo"
        Me.btnIncluirAnexo.UseVisualStyleBackColor = True
        '
        'btnExcluirAnexo
        '
        Me.btnExcluirAnexo.Location = New System.Drawing.Point(423, 184)
        Me.btnExcluirAnexo.Name = "btnExcluirAnexo"
        Me.btnExcluirAnexo.Size = New System.Drawing.Size(101, 23)
        Me.btnExcluirAnexo.TabIndex = 21
        Me.btnExcluirAnexo.Text = "Excluir Anexo"
        Me.btnExcluirAnexo.UseVisualStyleBackColor = True
        '
        'OFD
        '
        Me.OFD.FileName = "OpenFileDialog1"
        '
        'chboxEnviarComoHtml
        '
        Me.chboxEnviarComoHtml.AutoSize = True
        Me.chboxEnviarComoHtml.Location = New System.Drawing.Point(405, 480)
        Me.chboxEnviarComoHtml.Name = "chboxEnviarComoHtml"
        Me.chboxEnviarComoHtml.Size = New System.Drawing.Size(118, 17)
        Me.chboxEnviarComoHtml.TabIndex = 22
        Me.chboxEnviarComoHtml.Text = "Enviar como HTML"
        Me.chboxEnviarComoHtml.UseVisualStyleBackColor = True
        '
        'txtPara
        '
        Me.txtPara.FormattingEnabled = True
        Me.txtPara.Location = New System.Drawing.Point(97, 38)
        Me.txtPara.Name = "txtPara"
        Me.txtPara.Size = New System.Drawing.Size(320, 21)
        Me.txtPara.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "temporario"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(99, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(317, 20)
        Me.TextBox1.TabIndex = 25
        '
        'frmSisMail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 514)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPara)
        Me.Controls.Add(Me.chboxEnviarComoHtml)
        Me.Controls.Add(Me.btnExcluirAnexo)
        Me.Controls.Add(Me.btnIncluirAnexo)
        Me.Controls.Add(Me.btnEnviaEmail)
        Me.Controls.Add(Me.btnEnviarEmail)
        Me.Controls.Add(Me.lstAnexos)
        Me.Controls.Add(Me.txtAssunto)
        Me.Controls.Add(Me.txtMensagem)
        Me.Controls.Add(Me.txtCc)
        Me.Controls.Add(Me.txtBcc)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmSisMail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de envio de emails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtBcc As System.Windows.Forms.TextBox
    Friend WithEvents txtCc As System.Windows.Forms.TextBox
    Friend WithEvents txtMensagem As System.Windows.Forms.TextBox
    Friend WithEvents txtAssunto As System.Windows.Forms.TextBox
    Friend WithEvents lstAnexos As System.Windows.Forms.ListBox
    Friend WithEvents btnEnviarEmail As System.Windows.Forms.Button
    Friend WithEvents btnEnviaEmail As System.Windows.Forms.Button
    Friend WithEvents btnIncluirAnexo As System.Windows.Forms.Button
    Friend WithEvents btnExcluirAnexo As System.Windows.Forms.Button
    Friend WithEvents OFD As System.Windows.Forms.OpenFileDialog
    Friend WithEvents chboxEnviarComoHtml As System.Windows.Forms.CheckBox
    Friend WithEvents txtPara As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
