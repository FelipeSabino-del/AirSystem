using AirSystem.Models;
using AirSystem.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirSystem.Views
{
    public partial class frmListarUsuarios : Form
    {
        UsuarioRepository usuarioRepository = new UsuarioRepository();

        Usuario userGrid = new Usuario();
        string idioma = "";

        public frmListarUsuarios()
        {
            InitializeComponent();
        }

        public frmListarUsuarios(string idioma)
        {
            InitializeComponent();

            //traduçao form
            if (idioma == "Inglês US")
            {
                this.idioma = idioma;

                lblNome.Text = "First Name";
                lblSobrenome.Text = "Last Name";
                lblEndereco.Text = "Adress";
                lblNascimento.Text = "Birthday";
                lblSenha.Text = "Password";
                lblUsuario.Text = "Username";
                label1.Text = "Name";

                cbxAdm.Text = "Administrator";
                btnAlterar.Text = "Change";
                btnRemover.Text = "Remove";
                btnSalvar.Text = "Save";
                btnDeletar.Text = "Delete";
                btnNovoUser.Text = "New User";
                btnVoltar.Text = "Return";


            }

        }

        private void frmListarUsuarios_Load(object sender, EventArgs e)
        {
            // Define the border style of the form to a dialog box.
            FormBorderStyle = FormBorderStyle.FixedDialog;

            // Set the MaximizeBox to false to remove the maximize box.
            MaximizeBox = false;

            // Set the start position of the form to the center of the screen.
            StartPosition = FormStartPosition.CenterScreen;

            List<Usuario> usuarios = usuarioRepository.BuscarTodos();

            atualizaLista();
        }

        private void atualizaLista()
        {
            dgvListaUsuario.DataSource = null;

            List<Usuario> usuarios = usuarioRepository.BuscarTodos();

            List<UsuarioViewModel> userFiltro = new List<UsuarioViewModel>();

            foreach (var item in usuarios)
            {
                UsuarioViewModel usuarioFiltro = new UsuarioViewModel
                {
                    Id = item.Id,
                    Nome = item.Nome,
                    Sobrenome = item.Sobrenome,
                    IsAdm = item.IsAdmin
                };

                userFiltro.Add(usuarioFiltro);
            }

            dgvListaUsuario.DataSource = userFiltro;

            Contador();
        }

        private void Contador()
        {
            if (idioma != "Inglês US")
            {
                lblQuantidade.Text = $"{dgvListaUsuario.RowCount} itens de {usuarioRepository.BuscarTodos().Count}"; 
            }
            else
            {
                lblQuantidade.Text = $"{dgvListaUsuario.RowCount} items of {usuarioRepository.BuscarTodos().Count}";

            }
        }

        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            dgvListaUsuario.DataSource = null;
            dgvListaUsuario.DataSource = usuarioRepository.BuscarTodos().
                FindAll(x => x.Nome.ToUpper().Contains(tbxFiltro.Text.ToUpper()));

            Contador();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            new frmTelaAdm().Show();

            this.Close();

        }

        private void btnNovoUser_Click(object sender, EventArgs e)
        {
            new frmCadastroUsuario().ShowDialog();

            atualizaLista();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você tem certeza que deseja deletar?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                usuarioRepository.Deletar(userGrid.Id);
                atualizaLista();
            }

        }

        private void dgvListaUsuario_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridViewRow linha = dgvListaUsuario.Rows[e.RowIndex];

                Usuario usuario = new Usuario
                {
                    Id = Convert.ToInt32(linha.Cells[0].Value.ToString())
                };

                Usuario userSelect = usuarioRepository.BuscarId(usuario.Id);
                userSelect.Id = usuario.Id;

                tbxNome.Text = userSelect.Nome;
                tbxSobrenome.Text = userSelect.Sobrenome;
                tbxUsuario.Text = userSelect.Username;
                tbxSenha.Text = userSelect.Senha;
                dtpNascimento.Value = userSelect.DataNascimento;

                cbxAdm.Checked = userSelect.IsAdmin;

                string[] stringSplitada = userSelect.Endereco.Split(',');
                tbxEndereco.Text = stringSplitada[0];
                tbxNendereco.Text = stringSplitada[1];

                userGrid = userSelect;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Você tem certeza que deseja salvar?", "Confirmação", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                userGrid.Nome = tbxNome.Text;
                userGrid.Sobrenome = tbxSobrenome.Text;
                var adress = $"{tbxEndereco.Text}, {tbxNendereco.Text}";

                userGrid.Endereco = adress;
                userGrid.DataNascimento = Convert.ToDateTime(dtpNascimento.Text);
                userGrid.Username = tbxUsuario.Text;
                userGrid.Senha = tbxSenha.Text;
                userGrid.IsAdmin = cbxAdm.Checked;

                usuarioRepository.Salvar(userGrid);

                atualizaLista();
            }
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
