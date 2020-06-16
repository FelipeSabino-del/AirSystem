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
    public partial class frmCadastroIngles : Form
    {
        public frmCadastroIngles()
        {
            InitializeComponent();
        }

        string textoPadrao = "";

        private void frmCadastroUsuario_Load(object sender, EventArgs e)
        {
            lblSenhaAviso.Visible = false;
            lblSenhaRegex.Visible = false;

            cbxAdm.Parent = panel2;
            cbxAdm.BackColor = Color.Transparent;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            UsuarioRepository usuarioRepository = new UsuarioRepository();

            bool campoVazio = false;
            foreach (Control item in this.Controls)
            {
                TextBox tbx = item as TextBox;

                if (tbx != null && tbx.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Fill in all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                continue;
            }

            if (!campoVazio)
            {
                if (lblSenhaRegex.Visible == true)
                {
                    MessageBox.Show("The password must have all requirements.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (lblSenhaAviso.Visible == true)
                {
                    MessageBox.Show("The passwords must match.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    var result = MessageBox.Show("Registered Successfully.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            string pattern = "[A-Z]{1}[a-z]{1,}[0-9]{1,}";

            lblSenhaRegex.Visible = !Regex.IsMatch(tbxSenha.Text, pattern);

        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image File(*.jpg;*.png)|*.jpg;*.png";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pcbUserFoto.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            pcbUserFoto.Image = null;
        }

        private void Focus_enter(object sender, EventArgs e)
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

        private void Focus_leave(object sender, EventArgs e)
        {
            TextBox tbx = sender as TextBox;

            if (tbx.Text == "")
            {
                tbx.Text = textoPadrao;
                tbx.ForeColor = Color.Gray;
            }
        }
    }
}
