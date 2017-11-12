using System;
using Edu.Uninpahu.Arquitectura.Datos;
using Edu.Uninpahu.Arquitectura.Dominio;
using System.Data;


namespace Edu.Uninpahu.Arquitectura.Negocio
{
    public class ClienteDb : Cliente
    {
        Conexion ConnSql = new Conexion();

        public DataTable ListaCliente(string nombreTabla)
        {
            String sql = "SELECT * FROM CLIENTE";
            DataTable dT;
            dT = ConnSql.Tabla(sql, nombreTabla);
            return dT;            
        }

        public void AgregarCliente(Cliente cliente)
        {
            ConnSql.ConectarSql();
            String sql = String.Format("INSERT INTO[dbo].[CLIENTE] ([ID_CLIENTE] ,[NOMBRE] ,[APELLIDO] ,[FIJO] ,[CELULAR])" +
                " VALUES ({0},'{1}','{2}','{3}','{4}')",
                cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Fijo, cliente.Celular);
            ConnSql.Ejecutar(sql);
            ConnSql.CerrarConexion();
            ConnSql.ControlError("Se agrego Correctamente", "Proceso Guardar");
            
        }
        public void ActualizarCliente(Cliente cliente)
        {
            ConnSql.ConectarSql();
            String sql = String.Format(" UPDATE[dbo].[CLIENTE]" +
                " SET [NOMBRE] = '{1}'" +
                ",[APELLIDO] = '{2}' " +
                ",[FIJO] = {3} " + 
                ",[CELULAR] = {4} " +
                " WHERE ID_CLIENTE =  {0}",
                cliente.Id, cliente.Nombre, cliente.Apellido, cliente.Fijo, cliente.Celular);
            ConnSql.Ejecutar(sql);
            ConnSql.CerrarConexion();
            ConnSql.ControlError("Se actualizo Correctamente", "Proceso Actualizar");

        }
        public void EliminarCliente(Cliente cliente)
        {
            ConnSql.ConectarSql();
            String sql = String.Format("DELETE FROM [dbo].[CLIENTE] WHERE ID_CLIENTE =  {0}",
                cliente.Id);
            ConnSql.Ejecutar(sql);
            ConnSql.CerrarConexion();
            ConnSql.ControlError("Se Elimino Correctamente", "Proceso Eliminar");

        }

    }
}
