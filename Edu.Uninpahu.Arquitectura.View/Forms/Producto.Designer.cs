namespace Edu.Uninpahu.Arquitectura.View
{
    partial class Producto
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
            this.TxtIva = new System.Windows.Forms.TextBox();
            this.TxtValorUnitario = new System.Windows.Forms.TextBox();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Dt_Producto = new System.Windows.Forms.DataGridView();
            this.bindingSourceProducto = new System.Windows.Forms.BindingSource(this.components);
            this.facturaDataSet = new Edu.Uninpahu.Arquitectura.Negocio.FacturaDataSet();
            this.btn_atras = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.productoTableAdapter = new Edu.Uninpahu.Arquitectura.Negocio.FacturaDataSetTableAdapters.ProductoTableAdapter();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtIva
            // 
            this.TxtIva.Location = new System.Drawing.Point(22, 181);
            this.TxtIva.Margin = new System.Windows.Forms.Padding(2);
            this.TxtIva.Name = "TxtIva";
            this.TxtIva.Size = new System.Drawing.Size(155, 20);
            this.TxtIva.TabIndex = 3;
            // 
            // TxtValorUnitario
            // 
            this.TxtValorUnitario.Location = new System.Drawing.Point(22, 218);
            this.TxtValorUnitario.Margin = new System.Windows.Forms.Padding(2);
            this.TxtValorUnitario.Name = "TxtValorUnitario";
            this.TxtValorUnitario.Size = new System.Drawing.Size(155, 20);
            this.TxtValorUnitario.TabIndex = 4;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtCantidad.Location = new System.Drawing.Point(22, 141);
            this.TxtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(155, 20);
            this.TxtCantidad.TabIndex = 2;
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Location = new System.Drawing.Point(22, 104);
            this.TxtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(155, 20);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(22, 67);
            this.TxtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.ReadOnly = true;
            this.TxtCodigo.Size = new System.Drawing.Size(155, 20);
            this.TxtCodigo.TabIndex = 100;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Porsentaje Iva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 203);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Valor Unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cantidad Disponible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 89);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Codigo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(256, 28);
            this.label6.TabIndex = 28;
            this.label6.Text = "DATOS DE PRODUCTO";
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.Location = new System.Drawing.Point(543, 422);
            this.Btn_Eliminar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(92, 33);
            this.Btn_Eliminar.TabIndex = 6;
            this.Btn_Eliminar.Text = "Eliminar";
            this.Btn_Eliminar.UseVisualStyleBackColor = true;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Location = new System.Drawing.Point(447, 422);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(92, 33);
            this.btn_guardar.TabIndex = 5;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Dt_Producto);
            this.groupBox3.Location = new System.Drawing.Point(226, 52);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(612, 337);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Producto";
            // 
            // Dt_Producto
            // 
            this.Dt_Producto.AllowUserToDeleteRows = false;
            this.Dt_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dt_Producto.Location = new System.Drawing.Point(23, 18);
            this.Dt_Producto.Name = "Dt_Producto";
            this.Dt_Producto.ReadOnly = true;
            this.Dt_Producto.Size = new System.Drawing.Size(571, 296);
            this.Dt_Producto.TabIndex = 0;
            this.Dt_Producto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dt_Producto_CellContentClick);
            // 
            // bindingSourceProducto
            // 
            this.bindingSourceProducto.DataMember = "Producto";
            this.bindingSourceProducto.DataSource = this.facturaDataSet;
            // 
            // facturaDataSet
            // 
            this.facturaDataSet.DataSetName = "FacturaDataSet";
            this.facturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(735, 422);
            this.btn_atras.Margin = new System.Windows.Forms.Padding(2);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(81, 33);
            this.btn_atras.TabIndex = 9;
            this.btn_atras.Text = " <- Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo.Location = new System.Drawing.Point(639, 422);
            this.Btn_Nuevo.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(92, 33);
            this.Btn_Nuevo.TabIndex = 8;
            this.Btn_Nuevo.Text = "Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 501);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btn_atras);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtIva);
            this.Controls.Add(this.TxtValorUnitario);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Producto";
            this.Text = "Producto";
            this.Load += new System.EventHandler(this.Producto_Load);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dt_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtIva;
        private System.Windows.Forms.TextBox TxtValorUnitario;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox3;
        protected internal System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.DataGridView Dt_Producto;
        private System.Windows.Forms.BindingSource bindingSourceProducto;
        private Negocio.FacturaDataSet facturaDataSet;
        private Negocio.FacturaDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.Button Btn_Nuevo;
    }
}