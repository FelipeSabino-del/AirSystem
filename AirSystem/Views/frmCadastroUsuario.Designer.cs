namespace AirSystem.Views
{
    partial class frmCadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.tbxSobrenome = new System.Windows.Forms.TextBox();
            this.tbxEndereco = new System.Windows.Forms.TextBox();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxNome = new System.Windows.Forms.TextBox();
            this.tbxNendereco = new System.Windows.Forms.TextBox();
            this.tbxConfirmarSenha = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.cbxAdm = new System.Windows.Forms.CheckBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.pcbUserFoto = new System.Windows.Forms.PictureBox();
            this.lblSenhaAviso = new System.Windows.Forms.Label();
            this.lblSenhaRegex = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(62, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(45, 17);
            this.lblNome.TabIndex = 4;
            this.lblNome.Text = "Nome";
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(62, 67);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(69, 17);
            this.lblEndereco.TabIndex = 1;
            this.lblEndereco.Text = "Endereço";
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascimento.Location = new System.Drawing.Point(62, 110);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(82, 17);
            this.lblNascimento.TabIndex = 2;
            this.lblNascimento.Text = "Nascimento";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(62, 186);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(49, 17);
            this.lblSenha.TabIndex = 3;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(62, 148);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(57, 17);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarSenha.Location = new System.Drawing.Point(62, 229);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(109, 17);
            this.lblConfirmarSenha.TabIndex = 5;
            this.lblConfirmarSenha.Text = "Confirma Senha";
            // 
            // tbxSenha
            // 
            this.tbxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxSenha.Location = new System.Drawing.Point(169, 186);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(145, 20);
            this.tbxSenha.TabIndex = 6;
            this.tbxSenha.TextChanged += new System.EventHandler(this.tbxSenha_TextChanged);
            this.tbxSenha.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxSenha.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // tbxSobrenome
            // 
            this.tbxSobrenome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSobrenome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxSobrenome.Location = new System.Drawing.Point(320, 27);
            this.tbxSobrenome.Name = "tbxSobrenome";
            this.tbxSobrenome.Size = new System.Drawing.Size(145, 20);
            this.tbxSobrenome.TabIndex = 1;
            this.tbxSobrenome.Text = "Digite seu sobrenome";
            this.tbxSobrenome.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxSobrenome.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // tbxEndereco
            // 
            this.tbxEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEndereco.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxEndereco.Location = new System.Drawing.Point(169, 67);
            this.tbxEndereco.Name = "tbxEndereco";
            this.tbxEndereco.Size = new System.Drawing.Size(230, 20);
            this.tbxEndereco.TabIndex = 2;
            this.tbxEndereco.Text = "Digite seu endereço";
            this.tbxEndereco.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxEndereco.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxUsuario.Location = new System.Drawing.Point(169, 148);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(145, 20);
            this.tbxUsuario.TabIndex = 5;
            this.tbxUsuario.Text = "Insira seu usuario";
            this.tbxUsuario.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxUsuario.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // tbxNome
            // 
            this.tbxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNome.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxNome.Location = new System.Drawing.Point(169, 27);
            this.tbxNome.Name = "tbxNome";
            this.tbxNome.Size = new System.Drawing.Size(145, 20);
            this.tbxNome.TabIndex = 0;
            this.tbxNome.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxNome.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // tbxNendereco
            // 
            this.tbxNendereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNendereco.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxNendereco.Location = new System.Drawing.Point(405, 67);
            this.tbxNendereco.Name = "tbxNendereco";
            this.tbxNendereco.Size = new System.Drawing.Size(91, 20);
            this.tbxNendereco.TabIndex = 3;
            this.tbxNendereco.Text = "N°";
            this.tbxNendereco.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxNendereco.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // tbxConfirmarSenha
            // 
            this.tbxConfirmarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxConfirmarSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxConfirmarSenha.Location = new System.Drawing.Point(169, 229);
            this.tbxConfirmarSenha.Name = "tbxConfirmarSenha";
            this.tbxConfirmarSenha.PasswordChar = '*';
            this.tbxConfirmarSenha.Size = new System.Drawing.Size(145, 20);
            this.tbxConfirmarSenha.TabIndex = 7;
            this.tbxConfirmarSenha.TextChanged += new System.EventHandler(this.tbxConfirmarSenha_TextChanged);
            this.tbxConfirmarSenha.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxConfirmarSenha.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(371, 372);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(75, 23);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(618, 183);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 8;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(713, 183);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 9;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // cbxAdm
            // 
            this.cbxAdm.AutoSize = true;
            this.cbxAdm.Location = new System.Drawing.Point(662, 229);
            this.cbxAdm.Name = "cbxAdm";
            this.cbxAdm.Size = new System.Drawing.Size(89, 17);
            this.cbxAdm.TabIndex = 10;
            this.cbxAdm.Text = "Administrador";
            this.cbxAdm.UseVisualStyleBackColor = true;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.CustomFormat = "";
            this.dtpNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(169, 106);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(145, 21);
            this.dtpNascimento.TabIndex = 16;
            // 
            // pcbUserFoto
            // 
            this.pcbUserFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pcbUserFoto.Location = new System.Drawing.Point(618, 30);
            this.pcbUserFoto.Name = "pcbUserFoto";
            this.pcbUserFoto.Size = new System.Drawing.Size(170, 126);
            this.pcbUserFoto.TabIndex = 19;
            this.pcbUserFoto.TabStop = false;
            // 
            // lblSenhaAviso
            // 
            this.lblSenhaAviso.AutoSize = true;
            this.lblSenhaAviso.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaAviso.ForeColor = System.Drawing.Color.Red;
            this.lblSenhaAviso.Location = new System.Drawing.Point(62, 313);
            this.lblSenhaAviso.Name = "lblSenhaAviso";
            this.lblSenhaAviso.Size = new System.Drawing.Size(171, 13);
            this.lblSenhaAviso.TabIndex = 17;
            this.lblSenhaAviso.Text = "**As senhas precisam ser idênticas";
            // 
            // lblSenhaRegex
            // 
            this.lblSenhaRegex.AutoSize = true;
            this.lblSenhaRegex.ForeColor = System.Drawing.Color.Red;
            this.lblSenhaRegex.Location = new System.Drawing.Point(62, 290);
            this.lblSenhaRegex.Name = "lblSenhaRegex";
            this.lblSenhaRegex.Size = new System.Drawing.Size(357, 13);
            this.lblSenhaRegex.TabIndex = 18;
            this.lblSenhaRegex.Text = "*A senha deve ter: pelo menos 8 caracteres, 1 letra maiúscula e 1 Número";
            // 
            // frmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.lblSenhaRegex);
            this.Controls.Add(this.lblSenhaAviso);
            this.Controls.Add(this.dtpNascimento);
            this.Controls.Add(this.cbxAdm);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.pcbUserFoto);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.tbxConfirmarSenha);
            this.Controls.Add(this.tbxNendereco);
            this.Controls.Add(this.tbxNome);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.tbxEndereco);
            this.Controls.Add(this.tbxSobrenome);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.lblConfirmarSenha);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNascimento);
            this.Controls.Add(this.lblEndereco);
            this.Controls.Add(this.lblNome);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmCadastroUsuario";
            this.Text = "Cadastro Usuário - AirSystem";
            this.Load += new System.EventHandler(this.frmCadastroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.TextBox tbxSobrenome;
        private System.Windows.Forms.TextBox tbxEndereco;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxNome;
        private System.Windows.Forms.TextBox tbxNendereco;
        private System.Windows.Forms.TextBox tbxConfirmarSenha;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.PictureBox pcbUserFoto;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.CheckBox cbxAdm;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.Label lblSenhaAviso;
        private System.Windows.Forms.Label lblSenhaRegex;
    }
}