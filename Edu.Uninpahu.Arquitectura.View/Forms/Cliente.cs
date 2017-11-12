using Edu.Uninpahu.Arquitectura.Negocio;
using Edu.Uninpahu.Arquitectura.Dominio;
using System;
using System.Windows.Forms;

namespace Edu.Uninpahu.Arquitectura.View
{
    public partial class Cliente : Form
    {
        ClienteDb clienteDb = new ClienteDb();
        bool newDatos;

        public Cliente()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {            
            // TODO: esta línea de código carga datos en la tabla 'facturaDataSet.CLIENTE' Puede moverla o quitarla según sea necesario.
            this.ClienteTableAdapter.Fill(this.FacturaDataSet.Cliente);

           // ActualizarDatos();
            newDatos = true;
        }
        private void ActualizarDatos()
        {
            this.ClienteTableAdapter.Fill(this.FacturaDataSet.Cliente);
        }

        private void LlenarTextbox(int row)
        {
            try
            {
                Txt_Cedula.Text = Convert.ToString(Dg_Cliente.Rows[row].Cells[0].Value);
                Txt_Nombre.Text = Convert.ToString(Dg_Cliente.Rows[row].Cells[1].Value);
                Txt_Apellido.Text = Convert.ToString(Dg_Cliente.Rows[row].Cells[2].Value);
                Txt_Fijo.Text = Convert.ToString(Dg_Cliente.Rows[row].Cells[3].Value);
                Txt_Celular.Text = Convert.ToString(Dg_Cliente.Rows[row].Cells[4].Value);
                Txt_Cedula.ReadOnly = true;
            }
            catch
            {

            }
        }

        private void Dg_Cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LlenarTextbox(e.RowIndex);
            newDatos = false;
         //  System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
         //  messageBoxCS.AppendFormat("{0} = {1}", "ColumnIndex", e.ColumnIndex);
         //  messageBoxCS.AppendLine();
         //  messageBoxCS.AppendFormat("{0} = {1}", "RowIndex", e.RowIndex);
         //  messageBoxCS.AppendLine();
         //  MessageBox.Show(messageBoxCS.ToString(), "CellContentDoubleClick Event");
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
                if (string.IsNullOrEmpty(Txt_Cedula.Text))
                {
                    return;   
                }
                if (newDatos)
                {
                    Mensaje = MessageBox.Show("¿Desea guardar esta información ?", "Confirmación", MessageBoxButtons.YesNoCancel);
                    if (Mensaje.Equals(DialogResult.No))
                    {
                        return;
                    }
                    Dominio.Cliente cliente = new Dominio.Cliente(int.Parse(Txt_Cedula.Text), Txt_Nombre.Text, Txt_Apellido.Text, Txt_Fijo.Text, Txt_Celular.Text);
                    clienteDb.AgregarCliente(cliente);
                }
                else
                {
                    Mensaje = MessageBox.Show("¿Desea actualizar la información ?", "Confirmación", MessageBoxButtons.YesNoCancel);
                    if (Mensaje.Equals(DialogResult.No))
                    {
                        return;
                    }
                    Dominio.Cliente cliente = new Dominio.Cliente(int.Parse(Txt_Cedula.Text), Txt_Nombre.Text, Txt_Apellido.Text, Txt_Fijo.Text, Txt_Celular.Text);
                    clienteDb.ActualizarCliente(cliente);
                }
                ActualizarDatos();
                limpiar();
                //frmE.Mensaje = "Guardo EXITOSAMENTE ";
                //frmE.NumError = "Proceso";
                //frmE.Show();
            }
            catch(Exception ex)
            {
                frmE.Mensaje = "Upss Problmas ";
                frmE.NumError = "Guardar "+ ex;
                frmE.Show();
            }

        }

        private void limpiar()
        {
            Txt_Cedula.Text = "";
            Txt_Nombre.Text = "";
            Txt_Apellido.Text = "";
            Txt_Fijo.Text = "";
            Txt_Celular.Text = "";
            newDatos = true;
            Txt_Cedula.Focus();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            limpiar();
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
                Dominio.Cliente cliente = new Dominio.Cliente(int.Parse(Txt_Cedula.Text), Txt_Nombre.Text, Txt_Apellido.Text, Txt_Fijo.Text, Txt_Celular.Text);
                clienteDb.EliminarCliente(cliente);
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
    }
}
