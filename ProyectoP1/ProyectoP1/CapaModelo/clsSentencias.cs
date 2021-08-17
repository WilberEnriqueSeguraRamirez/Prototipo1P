using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Odbc;

namespace CapaModelo
{
    public class clsSentencias
    {
        // obtener datos de una tabla CAPA MODELO
        clsConexion con = new clsConexion();
        public OdbcDataAdapter llenarTbl(string tabla)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "  ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
        public OdbcDataAdapter llenarTbl2(string tabla, int id)// metodo  que obtinene el contenio de una tabla
        {
            //string para almacenar los campos de OBTENERCAMPOS y utilizar el 1ro
            string sql = "SELECT * FROM " + tabla + "where id = "+id+" ;";
            OdbcDataAdapter dataTable = new OdbcDataAdapter(sql, con.conexion());
            return dataTable;
        }
        public void insertT(int id, string nombre, string tel)// metodo  que obtinene el contenio de una tabla
        {
            try
            {
                string cadena = "call insertCliente(" + id + ",'" + nombre + "','"+tel+"');";
                OdbcCommand ingreso = new OdbcCommand(cadena, con.conexion());
                ingreso.ExecuteNonQuery();
            }
            catch (OdbcException Error)
            {
                Console.WriteLine("Error al ingresar " + Error);

            }
        }
    }
}
