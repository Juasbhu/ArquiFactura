using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace Edu.Uninpahu.Arquitectura.Datos.ConexionDB
{   
    public class conexion
    {
        public System.Data.Odbc.OdbcCommand Query = new OdbcCommand();
        public System.Data.Odbc.OdbcDataReader Sqlreader { get; set; }
        public System.Data.Odbc.OdbcConnection Conexion = new OdbcConnection();
        public String cadenaConexion = "";

        public void Conectar()
        {

        }
    }
}
