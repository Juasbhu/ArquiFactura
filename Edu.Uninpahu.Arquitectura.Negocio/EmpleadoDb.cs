using System;
using Edu.Uninpahu.Arquitectura.Datos;
using Edu.Uninpahu.Arquitectura.Dominio;
using System.Data;

namespace Edu.Uninpahu.Arquitectura.Negocio
{
    public class EmpleadoDb : Empleado
    {
        Conexion ConnSql = new Conexion();

        public DataTable ListaEmpleado(string nombreTabla)
        {
            String sql = "SELECT * FROM Empleado";
            DataTable dT;
            dT = ConnSql.Tabla(sql, nombreTabla);
            return dT;
        }

        public void AgregarEmpleado(Empleado empleado)
        {
            ConnSql.ConectarSql();
            String sql = String.Format("INSERT INTO [dbo].[Empleado] ([NOMBRE], [APELLIDO], [DIRECCION], [CARGO], [FIJO], [CELULAR])"+
                " VALUES ('{0}','{1}','{2}','{3}', '{4}', '{5}')",
                empleado.Nombre, empleado.Apellido, empleado.Direccion, empleado.Cargo, empleado.Fijo, empleado.Celular);
            ConnSql.Ejecutar(sql);
            ConnSql.CerrarConexion();
            ConnSql.ControlError("Se agrego Correctamente", "Proceso Guardar");

        }
        public void ActualizarEmpleado(Empleado empleado)
        {
            ConnSql.ConectarSql();
            String sql = String.Format("UPDATE [dbo].[EMPLEADO]" +
               "SET[NOMBRE] = '{1}' " +
               ",[APELLIDO] = '{2}' " +
               ",[DIRECCION] = '{3}' " +
               ",[CARGO] = '{4}' " +
               ",[FIJO] = '{5}' " +
               ",[CELULAR] = '{6}' " +
                " WHERE ID_EMPLEADO =  {0}",
                empleado.Id, empleado.Nombre, empleado.Apellido, empleado.Direccion, empleado.Cargo, empleado.Fijo, empleado.Celular);
            ConnSql.Ejecutar(sql);
            ConnSql.CerrarConexion();
            ConnSql.ControlError("Se actualizo Correctamente", "Proceso Actualizar");

        }
        public void EliminarEmpleado(Empleado empleado)
        {
            ConnSql.ConectarSql();
            String sql = String.Format("DELETE FROM [dbo].[EMPLEADO] WHERE ID_EMPLEADO =  {0}",
                empleado.Id);
            ConnSql.Ejecutar(sql);
            ConnSql.CerrarConexion();
            ConnSql.ControlError("Se Elimino Correctamente", "Proceso Eliminar");

        }
    }
}
