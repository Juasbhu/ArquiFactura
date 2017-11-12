using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Edu.Uninpahu.Arquitectura.Negocio;

namespace Edu.Uninpahu.Arquitectura.View
{
    public partial class Factura : Form
    {
        int posi = 0;
        DataTable dt = new DataTable();
        FacturaDb facturaDb = new FacturaDb();

        public Factura()
        {
            InitializeComponent();
        }

        private void Factura_Load(object sender, EventArgs e)
        {
            this.clienteTableAdapter.Fill(this.facturaDataSet.Cliente);
            this.empleadoTableAdapter.Fill(this.facturaDataSet.Empleado);
            Cmb_Cliente_SelectedIndexChanged(null, null);
        }    

        private void CargarOrden(string _Codigo, String _Nombre, String _Cantidad, String _vlrUni, String _Valor, String _Iva, String _Subtotal)
        {
            if (string.IsNullOrEmpty(_Codigo)) { return; }
            if (posi == 0)
            {
                
                DataColumn dCCo = new DataColumn("Codigo", typeof(int));                
                dt.Columns.Add(dCCo);
                dt.PrimaryKey = new DataColumn[] { dt.Columns["Codigo"] };
                DataColumn dCNom = new DataColumn("Nombre", typeof(String));
                dt.Columns.Add(dCNom);
                DataColumn dCCan = new DataColumn("Cantidad", typeof(String));
                dt.Columns.Add(dCCan);
                DataColumn dCVlUn = new DataColumn("ValorUnit", typeof(String));
                dt.Columns.Add(dCVlUn);
                DataColumn dCIva = new DataColumn("Iva", typeof(String));
                dt.Columns.Add(dCIva);
                DataColumn dCVal = new DataColumn("Valor", typeof(String));
                dt.Columns.Add(dCVal);
                DataColumn dCSub = new DataColumn("Subtotal", typeof(String));
                dt.Columns.Add(dCSub);
                dt.Locale = System.Globalization.CultureInfo.InvariantCulture;
                DataRow dR = dt.NewRow();
                dt.PrimaryKey = new DataColumn[] { dt.Columns["Codigo"] };
                
                dR[0] = _Codigo;
                dR[1] = _Nombre;
                dR[2] = _Cantidad;
                dR[3] = _vlrUni;                
                dR[4] = _Iva;
                dR[5] = _Valor;
                dR[6] = _Subtotal;
                dt.Rows.Add(dR);
                posi++;
            }
            else
            {
                DataRow dR = dt.NewRow();
                dR[0] = _Codigo;
                dR[1] = _Nombre;
                dR[2] = _Cantidad;
                dR[3] = _vlrUni;  
                dR[4] = _Iva;
                dR[5] = _Valor;
                dR[6] = _Subtotal;
                try
                {
                    dt.Rows.Add(dR);
                }catch(Exception e)
                {
                    Error frmE = new Error();
                    frmE.Mensaje = "El elemento ya ha sido ingresado,\n intentelo nuevamente";
                    frmE.NumError = " Error";
                    frmE.ShowDialog();
                }
                
            }
           

            bindingSourceProducto.DataSource = dt;
            Dg_Productos.DataSource = bindingSourceProducto;

            // Factura_Load(0, null);
            //Dg_Productos.Update();

            Sum();
        }
        private void Sum()
        {
            Txt_Total.Text = Convert.ToString(Dg_Productos.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells["Subtotal"].Value)));
        }

        private void Txt_Eliminar_Click(object sender, EventArgs e)
        {
            Dg_Productos.Rows.Remove(Dg_Productos.CurrentRow);
            Sum();
        }

        private void Cmbox_Empleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cmb_Cliente_SelectedIndexChanged(null, null);
        }

        private void Cmb_Cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)Cmb_Cliente.SelectedItem;
                int selecCliente = (int)drv.Row.ItemArray[0];
                txt_cliente.Text = Convert.ToString(facturaDataSet.Cliente.FindById_Cliente(selecCliente).Nombre)+ " " + Convert.ToString(facturaDataSet.Cliente.FindById_Cliente(selecCliente).Apellido);
                Txt_IdCliente.Text = Convert.ToString(facturaDataSet.Cliente.FindById_Cliente(selecCliente).Id_Cliente);

                DataRowView drvE = (DataRowView)Cmbox_Empleado.SelectedItem;
                int selecEmplead = (int)drvE.Row.ItemArray[0];
                Txt_IdEmpleado.Text = Convert.ToString(facturaDataSet.Empleado.FindById_Empleado(selecEmplead).Id_Empleado);
            }
            catch
            {

            }
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Error frmE = new Error();
            DialogResult Mensaje;
            try
            {
                if (Dg_Productos.Rows.Count == 0)
                {
                    frmE.Mensaje = "Falta llenar con Facturas ";
                    frmE.NumError = "Upss Problmas ";
                    frmE.Show();
                    return;
                }
                string txt = Txt_Total.Text;
                decimal Valor = Convert.ToDecimal(txt);
                int id;
                if (0 == 0)
                {
                    Mensaje = MessageBox.Show("¿Desea guardar esta información ?", "Confirmación", MessageBoxButtons.YesNoCancel);
                    if (Mensaje.Equals(DialogResult.No))
                    {
                        return;
                    }
                    Dominio.Factura factura = new Dominio.Factura(int.Parse(Txt_IdCliente.Text), int.Parse(Txt_IdEmpleado.Text), txt_fecha.Value.Date);
                    id = facturaDb.AgregarFactura(factura);
                    foreach (DataRow row in dt.Rows)
                    {

                    }
                }                
                //frmE.Mensaje = "Guardo EXITOSAMENTE ";
                //frmE.NumError = "Proceso";
                //frmE.Show();
            }
            catch (Exception ex)
            {
                frmE.Mensaje = "Upss Problmas " + ex;
                frmE.NumError = "Guardar ";
                frmE.ShowDialog();
            }

           
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            this.Close();
            Menu.Show();
        }

        private void btn_add_producto_Click(object sender, EventArgs e)
        {
            DFactura DF = new DFactura();
            DialogResult res = DF.ShowDialog();

            if (res == DialogResult.OK)
            {
                CargarOrden(DF.codigo, DF.nombre, DF.cantidad, DF.vlrUnit, DF.valor, DF.iva, DF.subtotal);
            }
        }
        
        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            this.Close();
            Menu.Show();
        }

      
    }
}
