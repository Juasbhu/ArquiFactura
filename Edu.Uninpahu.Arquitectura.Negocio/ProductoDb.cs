using System;
using Edu.Uninpahu.Arquitectura.Datos;
using Edu.Uninpahu.Arquitectura.Dominio;
using System.Data;

namespace Edu.Uninpahu.Arquitectura.Negocio
{
    public class ProductoDb : Producto
    {
        Conexion ConnSql = new Conexion();

        public DataTable ListaProducto(string nombreTabla)
        {
            String sql = "SELECT * FROM PRODUCTO";
            DataTable dT;
            dT = ConnSql.Tabla(sql, nombreTabla);
            return dT;
        }

        public void AgregarProducto(Producto Producto)
        {
            ConnSql.ConectarSql();
            String sql = String.Format("INSERT INTO [dbo].[PRODUCTO] ([NOMBRE] ,[CANTIDAD] ,[VALOR_UNITARIO] ,[PORCENTAJE_IVA])" +
                " VALUES ('{0}','{1}','{2}','{3}')",
                Producto.Nombre, Producto.Cantidad, Producto.ValorUnitario, Producto.PorcetajeIva);
            ConnSql.Ejecutar(sql);
            ConnSql.CerrarConexion();
            ConnSql.ControlError("Se agrego Correctamente", "Proceso Guardar");

        }
        public void ActualizarProducto(Producto Producto)
        {
            ConnSql.ConectarSql();
            String sql = String.Format("UPDATE [dbo].[PRODUCTO]"+
               "SET[NOMBRE] = '{1}' "+
               ",[CANTIDAD] = '{2}' "+
               ",[VALOR_UNITARIO] = '{3}' "+
               ",[PORCENTAJE_IVA] = '{4}' "+
                " WHERE CODIGO =  {0}",                   
                Producto.Codigo, Producto.Nombre, Producto.Cantidad, Producto.ValorUnitario, Producto.PorcetajeIva);
            ConnSql.Ejecutar(sql);
            ConnSql.CerrarConexion();
            ConnSql.ControlError("Se actualizo Correctamente", "Proceso Actualizar");

        }
        public void EliminarProducto(Producto Producto)
        {
            ConnSql.ConectarSql();
            String sql = String.Format("DELETE FROM [dbo].[PRODUCTO] WHERE CODIGO =  {0}",
                Producto.Codigo);
            ConnSql.Ejecutar(sql);
            ConnSql.CerrarConexion();
            ConnSql.ControlError("Se Elimino Correctamente", "Proceso Eliminar");

        }

    }
}
