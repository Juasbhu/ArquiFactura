namespace Edu.Uninpahu.Arquitectura.View
{
    partial class Factura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txt_fecha = new System.Windows.Forms.DateTimePicker();
            this.Cmbox_Empleado = new System.Windows.Forms.ComboBox();
            this.BindingSourceEmpleado = new System.Windows.Forms.BindingSource(this.components);
            this.facturaDataSet = new Edu.Uninpahu.Arquitectura.Negocio.FacturaDataSet();
            this.Cmb_Cliente = new System.Windows.Forms.ComboBox();
            this.BindingSourceCliente = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_add_producto = new System.Windows.Forms.Button();
            this.Txt_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.GrBox = new System.Windows.Forms.GroupBox();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Dg_Productos = new System.Windows.Forms.DataGridView();
            this.bindingSourceProducto = new System.Windows.Forms.BindingSource(this.components);
            this.btn_atras = new System.Windows.Forms.Button();
            this.clienteTableAdapter = new Edu.Uninpahu.Arquitectura.Negocio.FacturaDataSetTableAdapters.ClienteTableAdapter();
            this.empleadoTableAdapter = new Edu.Uninpahu.Arquitectura.Negocio.FacturaDataSetTableAdapters.EmpleadoTableAdapter();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_cliente = new System.Windows.Forms.Label();
            this.Txt_IdCliente = new System.Windows.Forms.Label();
            this.Txt_IdEmpleado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceEmpleado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCliente)).BeginInit();
            this.GrBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Productos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(22, 208);
            this.txt_fecha.Margin = new System.Windows.Forms.Padding(2);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(163, 20);
            this.txt_fecha.TabIndex = 22;
            // 
            // Cmbox_Empleado
            // 
            this.Cmbox_Empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmbox_Empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmbox_Empleado.DataSource = this.BindingSourceEmpleado;
            this.Cmbox_Empleado.DisplayMember = "Id_Empleado";
            this.Cmbox_Empleado.FormattingEnabled = true;
            this.Cmbox_Empleado.Location = new System.Drawing.Point(22, 170);
            this.Cmbox_Empleado.Margin = new System.Windows.Forms.Padding(2);
            this.Cmbox_Empleado.Name = "Cmbox_Empleado";
            this.Cmbox_Empleado.Size = new System.Drawing.Size(163, 21);
            this.Cmbox_Empleado.TabIndex = 21;
            this.Cmbox_Empleado.ValueMember = "Nombre";
            this.Cmbox_Empleado.SelectedIndexChanged += new System.EventHandler(this.Cmbox_Empleado_SelectedIndexChanged);
            // 
            // BindingSourceEmpleado
            // 
            this.BindingSourceEmpleado.DataMember = "Empleado";
            this.BindingSourceEmpleado.DataSource = this.facturaDataSet;
            // 
            // facturaDataSet
            // 
            this.facturaDataSet.DataSetName = "FacturaDataSet";
            this.facturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Cmb_Cliente
            // 
            this.Cmb_Cliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Cmb_Cliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Cmb_Cliente.BackColor = System.Drawing.Color.White;
            this.Cmb_Cliente.DataSource = this.BindingSourceCliente;
            this.Cmb_Cliente.DisplayMember = "Id_Cliente";
            this.Cmb_Cliente.FormattingEnabled = true;
            this.Cmb_Cliente.Location = new System.Drawing.Point(23, 132);
            this.Cmb_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.Cmb_Cliente.Name = "Cmb_Cliente";
            this.Cmb_Cliente.Size = new System.Drawing.Size(163, 21);
            this.Cmb_Cliente.TabIndex = 20;
            this.Cmb_Cliente.ValueMember = "Nombre";
            this.Cmb_Cliente.SelectedIndexChanged += new System.EventHandler(this.Cmb_Cliente_SelectedIndexChanged);
            // 
            // BindingSourceCliente
            // 
            this.BindingSourceCliente.DataMember = "Cliente";
            this.BindingSourceCliente.DataSource = this.facturaDataSet;
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(23, 95);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 20);
            this.textBox1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(192, 9);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 28);
            this.label5.TabIndex = 18;
            this.label5.Text = "FACTURA REGISTRO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 193);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 117);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Cedula Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Codigo Enpleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Codigo Factura";
            // 
            // btn_add_producto
            // 
            this.btn_add_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_producto.Location = new System.Drawing.Point(242, 416);
            this.btn_add_producto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_producto.Name = "btn_add_producto";
            this.btn_add_producto.Size = new System.Drawing.Size(105, 27);
            this.btn_add_producto.TabIndex = 40;
            this.btn_add_producto.Text = "Agregar Pr";
            this.btn_add_producto.UseVisualStyleBackColor = true;
            this.btn_add_producto.Click += new System.EventHandler(this.btn_add_producto_Click);
            // 
            // Txt_Eliminar
            // 
            this.Txt_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Eliminar.Location = new System.Drawing.Point(351, 416);
            this.Txt_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Eliminar.Name = "Txt_Eliminar";
            this.Txt_Eliminar.Size = new System.Drawing.Size(105, 27);
            this.Txt_Eliminar.TabIndex = 45;
            this.Txt_Eliminar.Text = "Eliminar Pr";
            this.Txt_Eliminar.UseVisualStyleBackColor = true;
            this.Txt_Eliminar.Click += new System.EventHandler(this.Txt_Eliminar_Click);
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Cancelar.Location = new System.Drawing.Point(823, 472);
            this.Btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(92, 33);
            this.Btn_Cancelar.TabIndex = 44;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = true;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(727, 472);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(92, 33);
            this.btn_guardar.TabIndex = 43;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // GrBox
            // 
            this.GrBox.Controls.Add(this.Txt_Total);
            this.GrBox.Controls.Add(this.label7);
            this.GrBox.Controls.Add(this.Dg_Productos);
            this.GrBox.Location = new System.Drawing.Point(234, 62);
            this.GrBox.Margin = new System.Windows.Forms.Padding(2);
            this.GrBox.Name = "GrBox";
            this.GrBox.Padding = new System.Windows.Forms.Padding(2);
            this.GrBox.Size = new System.Drawing.Size(733, 350);
            this.GrBox.TabIndex = 42;
            this.GrBox.TabStop = false;
            this.GrBox.Text = "Productos";
            // 
            // Txt_Total
            // 
            this.Txt_Total.Enabled = false;
            this.Txt_Total.Location = new System.Drawing.Point(636, 316);
            this.Txt_Total.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.Size = new System.Drawing.Size(91, 20);
            this.Txt_Total.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(563, 316);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total:";
            // 
            // Dg_Productos
            // 
            this.Dg_Productos.AllowUserToAddRows = false;
            this.Dg_Productos.AllowUserToDeleteRows = false;
            this.Dg_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Productos.Location = new System.Drawing.Point(16, 18);
            this.Dg_Productos.Margin = new System.Windows.Forms.Padding(2);
            this.Dg_Productos.Name = "Dg_Productos";
            this.Dg_Productos.ReadOnly = true;
            this.Dg_Productos.RowTemplate.Height = 24;
            this.Dg_Productos.Size = new System.Drawing.Size(711, 283);
            this.Dg_Productos.TabIndex = 12;
            // 
            // bindingSourceProducto
            // 
            this.bindingSourceProducto.DataMember = "Producto";
            this.bindingSourceProducto.DataSource = this.facturaDataSet;
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(919, 472);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(81, 33);
            this.btn_atras.TabIndex = 41;
            this.btn_atras.Text = " <- Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // empleadoTableAdapter
            // 
            this.empleadoTableAdapter.ClearBeforeFill = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 251);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Nombre Cliente";
            // 
            // txt_cliente
            // 
            this.txt_cliente.AutoSize = true;
            this.txt_cliente.Location = new System.Drawing.Point(22, 273);
            this.txt_cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(79, 13);
            this.txt_cliente.TabIndex = 47;
            this.txt_cliente.Text = "Codigo Factura";
            // 
            // Txt_IdCliente
            // 
            this.Txt_IdCliente.AutoSize = true;
            this.Txt_IdCliente.ForeColor = System.Drawing.Color.Transparent;
            this.Txt_IdCliente.Location = new System.Drawing.Point(22, 299);
            this.Txt_IdCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_IdCliente.Name = "Txt_IdCliente";
            this.Txt_IdCliente.Size = new System.Drawing.Size(0, 13);
            this.Txt_IdCliente.TabIndex = 48;
            // 
            // Txt_IdEmpleado
            // 
            this.Txt_IdEmpleado.AutoSize = true;
            this.Txt_IdEmpleado.ForeColor = System.Drawing.Color.Transparent;
            this.Txt_IdEmpleado.Location = new System.Drawing.Point(22, 323);
            this.Txt_IdEmpleado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_IdEmpleado.Name = "Txt_IdEmpleado";
            this.Txt_IdEmpleado.Size = new System.Drawing.Size(0, 13);
            this.Txt_IdEmpleado.TabIndex = 49;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 516);
            this.Controls.Add(this.Txt_IdEmpleado);
            this.Controls.Add(this.Txt_IdCliente);
            this.Controls.Add(this.txt_cliente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Eliminar);
            this.Controls.Add(this.Btn_Cancelar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.GrBox);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.btn_add_producto);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.Cmbox_Empleado);
            this.Controls.Add(this.Cmb_Cliente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceEmpleado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceCliente)).EndInit();
            this.GrBox.ResumeLayout(false);
            this.GrBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Productos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker txt_fecha;
        private System.Windows.Forms.ComboBox Cmbox_Empleado;
        private System.Windows.Forms.ComboBox Cmb_Cliente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_add_producto;
        private System.Windows.Forms.Button Txt_Eliminar;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox GrBox;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView Dg_Productos;
        protected internal System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.BindingSource BindingSourceEmpleado;
        private Negocio.FacturaDataSet facturaDataSet;
        private System.Windows.Forms.BindingSource BindingSourceCliente;
        private Negocio.FacturaDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private Negocio.FacturaDataSetTableAdapters.EmpleadoTableAdapter empleadoTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label txt_cliente;
        private System.Windows.Forms.Label Txt_IdCliente;
        private System.Windows.Forms.Label Txt_IdEmpleado;
    }
}