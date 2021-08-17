using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVista
{
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var frmMenu = new frmMenu();
            frmMenu.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var frmVista = new frmVista();
            frmVista.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmCIC = new frmCIC();
            frmCIC.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmIGC = new frmIGC();
            frmIGC.Show();
            this.Hide();
        }
    }
}
