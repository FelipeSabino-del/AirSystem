using AirSystem.Models;
using AirSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        string txtPadrao = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            // Define the border style of the form to a dialog box.
            FormBorderStyle = FormBorderStyle.FixedDialog;

            // Set the MaximizeBox to false to remove the maximize box.
            MaximizeBox = false;

            // Set the start position of the form to the center of the screen.
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            string time = DateTime.Now.ToLongTimeString();
            lblTempo.Text = time;
        }

        private void Inputs_Enter(object sender, EventArgs e)
        {
            TextBox tbx = sender as TextBox;

            txtPadrao = tbx.Text;

            if (tbx.Text == tbx.Text)
            {
                tbx.Text = "";
                tbx.ForeColor = Color.Black;
                tbx.Font = Font;
            }

        }

        private void Inputs_Leave(object sender, EventArgs e)
        {
            TextBox tbx = sender as TextBox;


            if (tbx.Text == "")
            {
                tbx.Text = txtPadrao;
                tbx.ForeColor = Color.Gray;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxIdioma.Text))
            {
                UsuarioRepository usuarioRepository = new UsuarioRepository();
                List<Usuario> usuarios = usuarioRepository.BuscarTodos();

                foreach (var item in usuarios)
                {
                    if (item.Username != tbxUsuario.Text || item.Senha != tbxSenha.Text)
                    {
                        break;
                    }
                    else
                    {
                        if (item.IsAdmin)
                        {
                            if (cbxIdioma.Text != "Inglês US")
                            {
                                frmTelaAdm frm = new frmTelaAdm();
                                frm.Show();
                                this.WindowState = FormWindowState.Minimized;
                            }
                            else
                            {
                                frmTelaAdm frm = new frmTelaAdm(cbxIdioma.Text);
                                frm.Show();

                            }
                        }
                        else
                        {
                            if (cbxIdioma.Text != "Inglês US")
                            {
                                frmTelaUser frm = new frmTelaUser();
                                frm.Show();
                                this.WindowState = FormWindowState.Minimized;
                            }
                            else
                            {
                                frmTelaUser frm = new frmTelaUser(cbxIdioma.Text);
                                frm.Show();
                                this.WindowState = FormWindowState.Minimized;

                            }
                        }
                    }
                }

                if (this.WindowState != FormWindowState.Minimized)
                {
                    MessageBox.Show(this, "Usuário ou Senha incorretos", "Confirmação", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(this, "Escolha um Idioma / Choose a language", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cbxIdioma.Text))
            {
                if (cbxIdioma.Text != "Inglês US")
                {
                    frmCadastroUsuario frmCadastro = new frmCadastroUsuario();
                    frmCadastro.Show();
                }
                else
                {
                    frmCadastroIngles frmCadastro = new frmCadastroIngles();
                    frmCadastro.Show();
                }
            }
            else
            {
                MessageBox.Show(this, "Escolha um Idioma / Choose a language", "Confirmação", MessageBoxButtons.OK);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
            {
                return;
            }
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show(this, "Você tem certeza que deseja sair?", "Confirmação", MessageBoxButtons.YesNo);
                if (result != DialogResult.Yes)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}
