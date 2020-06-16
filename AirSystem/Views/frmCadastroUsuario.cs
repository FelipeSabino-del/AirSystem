using AirSystem.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class frmCadastroUsuario : Form
    {
        public frmCadastroUsuario()
        {
            InitializeComponent();
        }

        string textoPadrao = "";

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            lblSenhaAviso.Visible = false;
            lblSenhaRegex.Visible = false;

            // Define the border style of the form to a dialog box.
            FormBorderStyle = FormBorderStyle.FixedDialog;

            // Set the MaximizeBox to false to remove the maximize box.
            MaximizeBox = false;

            // Set the start position of the form to the center of the screen.
            StartPosition = FormStartPosition.CenterScreen;

        }

        private void Inputs_Enter(Object sender, EventArgs e)
        {
            TextBox tbx = sender as TextBox;

            textoPadrao = tbx.Text;

            if (tbx.Text == tbx.Text)
            {
                tbx.Text = "";
                tbx.ForeColor = Color.Black;
                tbx.Font = Font;
            }
        }

        private void Inputs_Leave(Object sender, EventArgs e)
        {
            TextBox tbx = sender as TextBox;

            if (tbx.Text == "")
            {
                tbx.Text = textoPadrao;
                tbx.ForeColor = Color.Gray;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();

            bool camposVazio = false;

            foreach (Control c in this.Controls)
            {
                TextBox tbx = c as TextBox;

                if (tbx != null && tbx.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Preencha todos os campos.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                continue;
            }


            if (!camposVazio)
            {
                if (lblSenhaRegex.Visible == true)
                {
                    MessageBox.Show("A senha deve obedecer o esperado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (lblSenhaAviso.Visible == true)
                {
                    MessageBox.Show("Senhas precisam ser idênticas.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                Usuario usuario = new Usuario
                {
                    Id = 0,
                    Nome = tbxNome.Text,
                    Sobrenome = tbxSobrenome.Text,
                    DataNascimento = Convert.ToDateTime(dtpNascimento.Text),
                    Endereco = $"{tbxEndereco.Text}, {tbxNendereco.Text}",
                    Username = tbxUsuario.Text,
                    Senha = tbxSenha.Text,
                    IsAdmin = Convert.ToBoolean(cbxAdm.Checked)
                };


                if (usuarioRepository.Cadastrar(usuario))
                {
                    var result = MessageBox.Show("Cadastrado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                    }
                }
            }
        }

        private void tbxConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            _ = tbxSenha.Text == tbxConfirmarSenha.Text ? lblSenhaAviso.Visible = false : lblSenhaAviso.Visible = true;
        }

        private void tbxSenha_TextChanged(object sender, EventArgs e)
        {
            string pattern = "[A-Z, a-z, 0-9]{1,}[0-9]{1,}[A-Z, a-z, 0-9]{1,}";

            lblSenhaRegex.Visible = !Regex.IsMatch(tbxSenha.Text, pattern);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Arquivos de imagens(*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcbUserFoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            pcbUserFoto.Image = null;
        }
    }
}
