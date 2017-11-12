using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edu.Uninpahu.Arquitectura.View
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            Cliente Cliente = new Cliente();
            this.Hide();
            Cliente.Show();

        }

        private void btn_empleado_Click(object sender, EventArgs e)
        {
            Empleado Empleado = new Empleado();
            this.Hide();
            Empleado.Show();
        }

        private void btn_producto_Click(object sender, EventArgs e)
        {
            Producto Producto = new Producto();
            this.Hide();
            Producto.Show();
        }

        private void btn_factura_Click(object sender, EventArgs e)
        {
            Factura Factura = new Factura();
            this.Hide();
            Factura.Show();
        }

        private void btn_dfactura_Click(object sender, EventArgs e)
        {
            DFactura DFactura = new DFactura();
            this.Hide();
            DFactura.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
