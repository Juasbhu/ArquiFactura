using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.Uninpahu.Arquitectura.View
{
    public partial class DFactura : Form
    {
        public string codigo;
        public string nombre;
        public string cantidad;
        public string vlrUnit;
        public string iva;
        public string valor;
        public string subtotal;

        public DFactura()
        {
            InitializeComponent();

        }

        private void btn_add_producto_Click(object sender, EventArgs e)
        {
            Error frmE = new Error();

            int cntdad = int.Parse(Txt_Cantidad.Text);
            int stock = int.Parse(LblCantidadStock.Text);

            if (cntdad > stock || Txt_Cantidad.Text == "")
            {
                frmE.Mensaje = " Revise la cantidad del Stock";
                frmE.NumError = "Error";
                frmE.ShowDialog();

                return;
            }
            else
            {
                codigo = txtCodigo.Text;
                nombre = Txt_Nombre.Text;
                cantidad = Txt_Cantidad.Text;
                vlrUnit = LblValorUnitario.Text;
                iva = lbl_Iva.Text.Substring(6, 4);
                valor = TxtValor.Text;
                subtotal = TxtSubtotal.Text;
            }  
            
            // Factura Factura = new Factura();
             this.Hide();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Factura Factura = new Factura();
            this.Close();
        }

        private void DFactura_Load(object sender, EventArgs e)
        {
            this.productoTableAdapter.Fill(this.facturaDataSet.Producto);
            CmboxProducto_SelectedIndexChanged(null, null);
            precios();
        }



        private void precios()
        {
            CultureInfo culture;
            NumberStyles style;

            // Parse currency value using en-GB culture.
            style = NumberStyles.Number | NumberStyles.AllowCurrencySymbol;
            culture = CultureInfo.CreateSpecificCulture("es-Es");

            int cnt;
            int iva;
            double valor;
            if(Int32.TryParse(Txt_Cantidad.Text, out cnt) )
            {
                if (double.TryParse(LblValorUnitario.Text, out valor))
                {
                    // if (Int32.TryParse(lbl_Iva.Text, style, culture, out iva))
                    if (Int32.TryParse(lbl_Iva.Text.Substring(6,4), out iva))
                    {
                        Double val = cnt * valor;
                        double valIva = val * iva;
                        TxtValor.Text = Convert.ToString(val);
                        TxtSubtotal.Text = Convert.ToString(valIva);
                    }
                }
            }            

        }

        private void Txt_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsNumber(e.KeyChar)) { e.Handled = true; }           
        }

        private void TxtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo ci = System.Threading.Thread.CurrentThread.CurrentCulture;
            if (char.IsNumber(e.KeyChar) || e.KeyChar.ToString() == ci.NumberFormat.NumberDecimalSeparator)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void Txt_Cantidad_TextChanged(object sender, EventArgs e)
        {
            precios();
        }

        private void CmboxProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)CmboxProducto.SelectedItem;
                int selecProduct = (int)drv.Row.ItemArray[0];
                Txt_Nombre.Text = Convert.ToString(facturaDataSet.Producto.FindByCodigo(selecProduct).Nombre);
                txtCodigo.Text = Convert.ToString(facturaDataSet.Producto.FindByCodigo(selecProduct).Codigo);
                LblCantidadStock.Text = Convert.ToString(facturaDataSet.Producto.FindByCodigo(selecProduct).Cantidad);
                LblValorUnitario.Text = Convert.ToString(facturaDataSet.Producto.FindByCodigo(selecProduct).Valor_Unitario);
                lbl_Iva.Text = string.Format("Iva = {0}    % ", this.facturaDataSet.Producto.FindByCodigo(selecProduct).PorcentajeIva);
            }
            catch
            {

            }
        }
    }
}
