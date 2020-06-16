namespace AirSystem
{
    partial class Login
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTempo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.tbxUsuario = new System.Windows.Forms.TextBox();
            this.tbxSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.cbxIdioma = new System.Windows.Forms.ComboBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // lblTempo
            // 
            this.lblTempo.AutoSize = true;
            this.lblTempo.BackColor = System.Drawing.Color.AliceBlue;
            this.lblTempo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempo.ForeColor = System.Drawing.Color.Black;
            this.lblTempo.Location = new System.Drawing.Point(610, 9);
            this.lblTempo.Name = "lblTempo";
            this.lblTempo.Size = new System.Drawing.Size(43, 24);
            this.lblTempo.TabIndex = 12;
            this.lblTempo.Text = "Time";
            this.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTempo.UseCompatibleTextRendering = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(342, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 129);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.White;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(343, 192);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(64, 20);
            this.lblUsuario.TabIndex = 14;
            this.lblUsuario.Text = "Usuário";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxUsuario
            // 
            this.tbxUsuario.BackColor = System.Drawing.Color.White;
            this.tbxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUsuario.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxUsuario.Location = new System.Drawing.Point(342, 212);
            this.tbxUsuario.Name = "tbxUsuario";
            this.tbxUsuario.Size = new System.Drawing.Size(339, 20);
            this.tbxUsuario.TabIndex = 15;
            this.tbxUsuario.Text = "Digite seu usuário";
            this.tbxUsuario.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxUsuario.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // tbxSenha
            // 
            this.tbxSenha.BackColor = System.Drawing.Color.White;
            this.tbxSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSenha.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tbxSenha.Location = new System.Drawing.Point(342, 268);
            this.tbxSenha.Name = "tbxSenha";
            this.tbxSenha.PasswordChar = '*';
            this.tbxSenha.Size = new System.Drawing.Size(338, 20);
            this.tbxSenha.TabIndex = 17;
            this.tbxSenha.Text = "Password";
            this.tbxSenha.WordWrap = false;
            this.tbxSenha.Enter += new System.EventHandler(this.Inputs_Enter);
            this.tbxSenha.Leave += new System.EventHandler(this.Inputs_Leave);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.BackColor = System.Drawing.Color.White;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.ForeColor = System.Drawing.Color.Black;
            this.lblSenha.Location = new System.Drawing.Point(343, 248);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(56, 20);
            this.lblSenha.TabIndex = 16;
            this.lblSenha.Text = "Senha";
            this.lblSenha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.BackColor = System.Drawing.Color.White;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.ForeColor = System.Drawing.Color.Black;
            this.lblIdioma.Location = new System.Drawing.Point(343, 303);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(57, 20);
            this.lblIdioma.TabIndex = 18;
            this.lblIdioma.Text = "Idioma";
            this.lblIdioma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxIdioma
            // 
            this.cbxIdioma.BackColor = System.Drawing.Color.White;
            this.cbxIdioma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxIdioma.FormattingEnabled = true;
            this.cbxIdioma.Items.AddRange(new object[] {
            "Portuguê PT-BR",
            "Inglês US"});
            this.cbxIdioma.Location = new System.Drawing.Point(343, 323);
            this.cbxIdioma.Name = "cbxIdioma";
            this.cbxIdioma.Size = new System.Drawing.Size(183, 21);
            this.cbxIdioma.TabIndex = 19;
            // 
            // btnEntrar
            // 
            this.btnEntrar.BackColor = System.Drawing.Color.White;
            this.btnEntrar.ForeColor = System.Drawing.Color.Black;
            this.btnEntrar.Location = new System.Drawing.Point(342, 364);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrar.TabIndex = 20;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = false;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.White;
            this.btnSair.ForeColor = System.Drawing.Color.Black;
            this.btnSair.Location = new System.Drawing.Point(451, 364);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 21;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.White;
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(562, 364);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(119, 23);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "Novo usuário";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 399);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.cbxIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.tbxSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.tbxUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTempo);
            this.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTempo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox tbxUsuario;
        private System.Windows.Forms.TextBox tbxSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox cbxIdioma;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnCadastrar;
    }
}

