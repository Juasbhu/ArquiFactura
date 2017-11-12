using Edu.Uninpahu.Arquitectura.Negocio;
using Edu.Uninpahu.Arquitectura.Dominio;
using System;
using System.Windows.Forms;

namespace Edu.Uninpahu.Arquitectura.View
{
    public partial class Empleado : Form
    {
        EmpleadoDb EmpleadoDb = new EmpleadoDb();
        bool newDatos;

        public Empleado()
        {
            InitializeComponent();
        }
        private void Empleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'facturaDataSet.Empleado' Puede moverla o quitarla según sea necesario.
            this.empleadoTableAdapter.Fill(this.facturaDataSet.Empleado);
            newDatos = true;
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            Menu Menu = new Menu();
            this.Close();
            Menu.Show();
        }

        private void ActualizarDatos()
        {
            this.empleadoTableAdapter.Fill(this.facturaDataSet.Empleado);
        }

        private void LlenarTextbox(int row)
        {
            try
            {
                Txt_Id.Text = Convert.ToString(Dg_Empleados.Rows[row].Cells[0].Value);
                Txt_Nombre.Text = Convert.ToString(Dg_Empleados.Rows[row].Cells[1].Value);
                Txt_Apellido.Text = Convert.ToString(Dg_Empleados.Rows[row].Cells[2].Value);
                Txt_Direccion.Text = Convert.ToString(Dg_Empleados.Rows[row].Cells[3].Value);
                Txt_Cargo.Text = Convert.ToString(Dg_Empleados.Rows[row].Cells[4].Value);
                Txt_Fijo.Text = Convert.ToString(Dg_Empleados.Rows[row].Cells[4].Value);
                Txt_Celular.Text = Convert.ToString(Dg_Empleados.Rows[row].Cells[4].Value);
                Txt_Id.ReadOnly = true;
            }
            catch
            {

            }
        }

        private void Dg_Empleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
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


      
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            Error frmE = new Error();
            DialogResult Mensaje;
            try
            {
                if (string.IsNullOrEmpty(Txt_Nombre.Text) || string.IsNullOrEmpty(Txt_Apellido.Text) || string.IsNullOrEmpty(Txt_Direccion.Text) || string.IsNullOrEmpty(Txt_Cargo.Text) || string.IsNullOrEmpty(Txt_Fijo.Text) || string.IsNullOrEmpty(Txt_Celular.Text))
                {
                    frmE.Mensaje = "Tiene que llenar todos los campos ";
                    frmE.NumError = "Upss Problmas ";
                    frmE.Show();
                    return;
                }
                if (newDatos)
                {
                    Mensaje = MessageBox.Show("¿Desea guardar esta información ?", "Confirmación", MessageBoxButtons.YesNoCancel);
                    if (Mensaje.Equals(DialogResult.No))
                    {
                        return;
                    }
                    Dominio.Empleado empleado = new Dominio.Empleado(0, Txt_Nombre.Text, Txt_Apellido.Text, Txt_Direccion.Text, Txt_Cargo.Text, Txt_Fijo.Text, Txt_Celular.Text);
                    EmpleadoDb.AgregarEmpleado(empleado);
                }
                else
                {
                    Mensaje = MessageBox.Show("¿Desea actualizar la información ?", "Confirmación", MessageBoxButtons.YesNoCancel);
                    if (Mensaje.Equals(DialogResult.No))
                    {
                        return;
                    }
                    Dominio.Empleado empleado = new Dominio.Empleado(int.Parse(Txt_Id.Text), Txt_Nombre.Text, Txt_Apellido.Text, Txt_Direccion.Text, Txt_Cargo.Text, Txt_Fijo.Text, Txt_Celular.Text);
                    EmpleadoDb.ActualizarEmpleado(empleado);
                }
                ActualizarDatos();
                limpiar();
                //frmE.Mensaje = "Guardo EXITOSAMENTE ";
                //frmE.NumError = "Proceso";
                //frmE.Show();
            }
            catch (Exception ex)
            {
                frmE.Mensaje = "Upss Problmas ";
                frmE.NumError = "Guardar " + ex;
                frmE.Show();
            }

        }

        private void limpiar()
        {
            Txt_Id.Text = "";
            Txt_Nombre.Text = "";
            Txt_Apellido.Text = "";
            Txt_Direccion.Text = "";
            Txt_Fijo.Text = "";
            Txt_Celular.Text = "";
            Txt_Cargo.Text = "";
            newDatos = true;
            Txt_Nombre.Focus();
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
                Dominio.Empleado empleado = new Dominio.Empleado(int.Parse(Txt_Id.Text), Txt_Nombre.Text, Txt_Apellido.Text, Txt_Direccion.Text, Txt_Cargo.Text, Txt_Fijo.Text, Txt_Celular.Text);
                EmpleadoDb.EliminarEmpleado(empleado);
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
