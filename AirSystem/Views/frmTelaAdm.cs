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
    public partial class frmTelaAdm : Form
    {
        public frmTelaAdm()
        {
            InitializeComponent();
        }

        string idioma = "";
        public frmTelaAdm(string idioma)
        {
            InitializeComponent();

            if (idioma == "Inglês")
            {
                this.idioma = idioma;

                button1.Text = "List Planes";
                button2.Text = "Manage Planes";
                button3.Text = "Manage Company";
                button4.Text = "Manage Reports";
                button5.Text = "List User";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (idioma != "Inglês US")
            {
                frmListarUsuarios frm = new frmListarUsuarios();
                frm.Show();
                this.WindowState = FormWindowState.Minimized;
            }
            else
            {
                frmListarUsuarios frm = new frmListarUsuarios(idioma);
                frm.Show();
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void frmTelaAdm_Load(object sender, EventArgs e)
        {
            // Define the border style of the form to a dialog box.
            FormBorderStyle = FormBorderStyle.FixedDialog;

            // Set the MaximizeBox to false to remove the maximize box.
            MaximizeBox = false;

            // Set the start position of the form to the center of the screen.
            StartPosition = FormStartPosition.CenterScreen;
        }
    }
}
