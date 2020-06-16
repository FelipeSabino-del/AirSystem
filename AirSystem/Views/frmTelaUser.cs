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
    public partial class frmTelaUser : Form
    {
        public frmTelaUser()
        {
            InitializeComponent();
        }

        string idioma = "";

        public frmTelaUser(string idioma)
        {
            InitializeComponent();

            if (idioma == "Inglês")
            {
                this.idioma = idioma;

                button1.Text = "List Planes";
                button2.Text = "Manage Planes";
                button3.Text = "Manage Company";
                button4.Text = "Manage Reports";
            }
        }

        private void frmTelaUser_Load(object sender, EventArgs e)
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
