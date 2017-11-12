using Edu.Uninpahu.Arquitectura.Negocio;
using Edu.Uninpahu.Arquitectura.Dominio;
using System;
using System.Windows.Forms;

namespace Edu.Uninpahu.Arquitectura.View
{
    public partial class Producto : Form
    {
        ProductoDb productoDb = new ProductoDb();
        bool newDatos;

        public Producto()
        {
            InitializeComponent();
        }

        private void Producto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'facturaDataSet.PRODUCTO' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter.Fill(this.facturaDataSet.Producto);
            newDatos = true;
        }

     
        private void ActualizarDatos()
        {
            this.productoTableAdapter.Fill(this.facturaDataSet.Producto);
        }
        private void LlenarTextbox(int row)
        {
            try
            {
                TxtCodigo.Text = Convert.ToString(Dt_Producto.Rows[row].Cells[0].Value);
                TxtNombre.Text = Convert.ToString(Dt_Producto.Rows[row].Cells[1].Value);
                TxtCantidad.Text = Convert.ToString(Dt_Producto.Rows[row].Cells[2].Value);
                TxtIva.Text = Convert.ToString(Dt_Producto.Rows[row].Cells[3].Value);
                TxtValorUnitario.Text = Convert.ToString(Dt_Producto.Rows[row].Cells[4].Value);
                TxtCodigo.ReadOnly = true;
            }
            catch
            {

            }
        }

        private void Dt_Producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarTextbox(e.RowIndex);
            newDatos = false;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            this.Close();
            Menu.Show();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Error frmE = new Error();
            DialogResult Mensaje;
            try
            {
                if (string.IsNullOrEmpty(TxtNombre.Text) || string.IsNullOrEmpty(TxtCantidad.Text) || string.IsNullOrEmpty(TxtValorUnitario.Text) || string.IsNullOrEmpty(TxtIva.Text))
                {
                    frmE.Mensaje = "Tiene que llenar todos los campos ";
                    frmE.NumError = "Upss Problmas ";
                    frmE.Show();
                    return;
                }
                string txt = TxtValorUnitario.Text;
                decimal ValorUni = Convert.ToDecimal(txt);
                if (newDatos)
                {                    
                    Mensaje = MessageBox.Show("¿Desea guardar esta información ?", "Confirmación", MessageBoxButtons.YesNoCancel);
                    if (Mensaje.Equals(DialogResult.No))
                    {
                        return;
                    }
                    Dominio.Producto producto = new Dominio.Producto(0,TxtNombre.Text, int.Parse(TxtCantidad.Text), ValorUni, int.Parse(TxtIva.Text));
                    productoDb.AgregarProducto(producto);
                }
                else
                {
                    Mensaje = MessageBox.Show("¿Desea actualizar la información ?", "Confirmación", MessageBoxButtons.YesNoCancel);
                    if (Mensaje.Equals(DialogResult.No))
                    {
                        return;
                    }
                    Dominio.Producto producto = new Dominio.Producto(int.Parse(TxtCodigo.Text), TxtNombre.Text, int.Parse(TxtCantidad.Text), ValorUni, int.Parse(TxtIva.Text));
                    productoDb.ActualizarProducto(producto);
                }
                ActualizarDatos();
                limpiar();
                //frmE.Mensaje = "Guardo EXITOSAMENTE ";
                //frmE.NumError = "Proceso";
                //frmE.Show();
            }
            catch (Exception ex)
            {
                frmE.Mensaje = "Upss Problmas " + ex;
                frmE.NumError = "Guardar ";
                frmE.Show();
            }
        }

        private void limpiar()
        {
            TxtCodigo.Text = "";
            TxtNombre.Text = "";
            TxtIva.Text = "";
            TxtCantidad.Text = "";
            TxtValorUnitario.Text = "";
            newDatos = true;
            TxtNombre.Focus();
        }

    

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Error frmE = new Error();
            DialogResult Mensaje;
            try
            {
                Mensaje = MessageBox.Show("¿Esta seguro de Eliminar este Contenido?", "Confirmación", MessageBoxButtons.YesNoCancel);
                if (Mensaje.Equals(DialogResult.No))
                {
                    return;
                }
                Dominio.Producto producto = new Dominio.Producto(int.Parse(TxtCodigo.Text), TxtNombre.Text, int.Parse(TxtCantidad.Text), 0 , int.Parse(TxtIva.Text));
                productoDb.EliminarProducto(producto);
                ActualizarDatos();
                limpiar();
            }
            catch (Exception ex)
            {
                frmE.Mensaje = "Upss Problmas ";
                frmE.NumError = "Guardar " + ex;
                frmE.Show();
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
        }

     
    }
}
