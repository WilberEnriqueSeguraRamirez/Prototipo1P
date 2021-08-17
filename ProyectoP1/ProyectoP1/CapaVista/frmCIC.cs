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
    public partial class frmCIC : Form
    {
        int id;
        clsControlador cn = new clsControlador();
        public frmCIC()
        {
            InitializeComponent();
        }
        //Mostrar los datos CAPA VISTA
        string tabla = "cliente";

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl2(tabla,id);
            dtgConsulta.DataSource = dt;

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var frmClientes = new frmClientes();
            frmClientes.Show();
            this.Close();
        }
    }
}
