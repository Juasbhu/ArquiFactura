using System;
using Edu.Uninpahu.Arquitectura.Datos;
using Edu.Uninpahu.Arquitectura.Dominio;
using System.Data;

namespace Edu.Uninpahu.Arquitectura.Negocio
{
    public class FacturaDb : Factura
    {
        Conexion ConnSql = new Conexion();

        public DataTable ListaFactura(string nombreTabla)
        {
            String sql = "SELECT * FROM Factura";
            DataTable dT;
            dT = ConnSql.Tabla(sql, nombreTabla);
            return dT;
        }

        public int AgregarFactura(Factura factura)
        {
            ConnSql.ConectarSql();
            String sql = String.Format("INSERT INTO [dbo].[FACTURA] ([ID_CLIENTE_FK] ,[ID_EMPLEADO_FK] ,[FECHA])" +
                " OUTPUT inserted.ID_FACTURA" +
                " VALUES ('{0}','{1}','{2}')",
                factura.IdCliente, factura.IdEmpleado, factura.Fecha);
            int id = ConnSql.EjecutarId(sql);
            ConnSql.CerrarConexion();
            ConnSql.ControlError("Se agrego Correctamente", "Proceso Guardar");

            return id;
        }

        public void ActualizarFactura(Factura factura)
        {
            ConnSql.ConectarSql();
            String sql = String.Format("UPDATE[dbo].[FACTURA]" +
                "SET[ID_CLIENTE_FK] = '{1}'" +
                ",[ID_EMPLEADO_FK] = '{2}'" +
                ",[FECHA] = '{3}' " +
                " WHERE CODIGO =  {0}",
                factura.Id, factura.IdCliente, factura.IdEmpleado, factura.Fecha);
            ConnSql.Ejecutar(sql);
            ConnSql.CerrarConexion();
            ConnSql.ControlError("Se actualizo Correctamente", "Proceso Actualizar");

        }

        public void EliminarFactura(Factura factura)
        {
            ConnSql.ConectarSql();
            String sql = String.Format("DELETE FROM [dbo].[FACTURA] WHERE ID_CLIENTE =  {0}",
                 factura.Id);
            ConnSql.Ejecutar(sql);
            ConnSql.CerrarConexion();
            ConnSql.ControlError("Se Elimino Correctamente", "Proceso Eliminar");

        }

        public void AgregarProducto(Producto producto)
        {
            ConnSql.ConectarSql();
            String sql = String.Format("INSERT INTO [dbo].[PRODUCTO] ([NOMBRE] ,[CANTIDAD] ,[VALOR_UNITARIO] ,[PORCENTAJE_IVA]) VALUES)" +
                " VALUES ('{0}','{1}','{2}', '{3}'. '{4}')",
                producto.Nombre, producto.Cantidad, producto.ValorUnitario, producto.PorcetajeIva);
            ConnSql.Ejecutar(sql);
            ConnSql.CerrarConexion();
            ConnSql.ControlError("Se agrego Correctamente", "Proceso Guardar");

        }

    }
}