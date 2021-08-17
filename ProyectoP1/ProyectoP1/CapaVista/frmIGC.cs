using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;
namespace CapaVista
{
    public partial class frmIGC : Form
    {
        clsControlador cn = new clsControlador();
        public frmIGC()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmClientes = new frmClientes();
            frmClientes.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int16.Parse(textBox1.Text);
            string nombre = textBox2.Text;
            string tel = textBox3.Text;
            cn.inserTC(id,nombre,tel);
        }
    }
}
