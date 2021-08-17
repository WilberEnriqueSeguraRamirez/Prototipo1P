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
    public partial class frmVista : Form
    {
        clsControlador cn = new clsControlador();
        public frmVista()
        {
            InitializeComponent();
        }

        private void frmVista_Load(object sender, EventArgs e)
        {

        }
        //Mostrar los datos CAPA VISTA
        string tabla = "cliente";

        public void actualizardatagriew()
        {
            DataTable dt = cn.llenarTbl(tabla);
            dtgConsulta.DataSource = dt;

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            actualizardatagriew();
        }

        private void dtgConsulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var frmClientes = new frmClientes();
            frmClientes.Show();
            this.Close();
        }
    }
}
