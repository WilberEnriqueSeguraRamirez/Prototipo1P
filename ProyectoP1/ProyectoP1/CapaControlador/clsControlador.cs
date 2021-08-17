using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;
using CapaModelo;
using System.Collections;
namespace CapaControlador
{
    public class clsControlador
    {
        // LLenar una tabla CAPA CONTROLADOR
        clsSentencias sn = new clsSentencias();

        public DataTable llenarTbl(string tabla)
        {
            OdbcDataAdapter dt = sn.llenarTbl(tabla);
            DataTable table = new DataTable();
            dt.Fill(table);
            return table;
        }
        public DataTable llenarTbl2(string tabla, int id)
        {
            sn.llenarTbl2(tabla,id);
            ArrayList dt = new ArrayList();
            dt.Add(tabla);
            dt.Add(id);
            DataTable table = new DataTable();
           // dt.Fill(table);
            return table;
        }
        public void inserTC(int id, string nombre, string tel)
        {
            sn.insertT(id, nombre, tel);
        }
    }
}
