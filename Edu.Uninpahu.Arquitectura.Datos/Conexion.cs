using System;
using System.Data;
using System.Data.SqlClient;


namespace Edu.Uninpahu.Arquitectura.Datos
{
    public class Conexion
    {
      
        public System.Data.SqlClient.SqlCommand Query = new System.Data.SqlClient.SqlCommand();
        //public System.Data.SqlClient.SqlDataReader DtReader;
        //public System.Data.SqlClient.SqlDataAdapter DtAdapter;
        private string Cadena = Properties.Settings.Default.FacturaConnectionString;
        public System.Data.SqlClient.SqlConnection Coneccion = new System.Data.SqlClient.SqlConnection();
        
        private Boolean result = false;    
        


        public bool ConectarSql()
        {
            result = false;
            try
            {
                if (Coneccion.State == System.Data.ConnectionState.Open)
                {
                    result = true;
                }
                else
                {
                    Coneccion.ConnectionString = Cadena;
                    Query.Connection = Coneccion;
                    Coneccion.Open();
                    Query.CommandType = System.Data.CommandType.Text;
                    //ControlError("Conexión Exitosa", "Proceso"); ;    
                    result = true;
                }
            }
            catch (Exception ex)
            {
                ControlError("Conexión Fallida, " + ex, "404 DB. ERRO" );
                result = false;
                                
            }
            return result;
        }

        public void ControlError(string Mensaje, String Error)
        {
            Error frmE = new Datos.Error();
            frmE.Mensaje = Mensaje;
            frmE.NumError = Error;            
            frmE.ShowDialog();
        }

        public bool Ejecutar(string txquery)
        {
            int registros;
            try
            {
                this.Query.CommandType = System.Data.CommandType.Text;
                this.Query.CommandText = txquery;
                this.Query.Connection = this.Coneccion;
                registros = this.Query.ExecuteNonQuery();
                if (registros != 0)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            catch(Exception ex)
            {
                ControlError("Conexión Fallida, " + ex, "404");
                result = false;
            }
            return result;
        }

        public DataTable Tabla(string sql, string nombreTabla)
        {
            DataTable table = new DataTable(nombreTabla);
            // DataSet dS = new System.Data.DataSet(nombreTabla);
            SqlConnection conn = new SqlConnection(Cadena);

            SqlCommand command = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
                                  
            table.Locale = System.Globalization.CultureInfo.InvariantCulture;
            adapter.Fill(table);
            //DtAdapter.Fill(dS);
            adapter.Dispose();
            CerrarConexion();                    

            return table;                          
        }

        public int EjecutarId(string txquery)
        {
            int result = 0;
            try
            {
                this.Query.CommandText = txquery;
                this.Query.Connection = this.Query.Connection;
                SqlDataReader dt = this.Query.ExecuteReader();
                while (dt.Read())
                {
                    result = (int)dt[0];
                }
                return result;
            }
            catch (Exception ex)
            {
                ControlError("Conexión Fallida, " + ex, "404");
            }
            return result;
        }


        public void CerrarConexion()
        {
            try
            {
                this.Coneccion.Close();
            }
            catch
            {

            }
            try
            {
                this.Query.Dispose();
            }
            catch
            {

            }
        }
    }
}
