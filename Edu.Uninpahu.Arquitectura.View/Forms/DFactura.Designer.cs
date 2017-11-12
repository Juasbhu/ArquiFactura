namespace Edu.Uninpahu.Arquitectura.View
{
    partial class DFactura
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
            this.TxtSubtotal = new System.Windows.Forms.TextBox();
            this.TxtValor = new System.Windows.Forms.TextBox();
            this.Txt_Cantidad = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_add_producto = new System.Windows.Forms.Button();
            this.CmboxProducto = new System.Windows.Forms.ComboBox();
            this.bindingSourceProductoCmbox = new System.Windows.Forms.BindingSource(this.components);
            this.facturaDataSet = new Edu.Uninpahu.Arquitectura.Negocio.FacturaDataSet();
            this.productoTableAdapter = new Edu.Uninpahu.Arquitectura.Negocio.FacturaDataSetTableAdapters.ProductoTableAdapter();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_Iva = new System.Windows.Forms.Label();
            this.LblCantidadStock = new System.Windows.Forms.Label();
            this.LblValorUnitario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Txt_Nombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProductoCmbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Location = new System.Drawing.Point(31, 270);
            this.TxtSubtotal.Margin = new System.Windows.Forms.Padding(2);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.ReadOnly = true;
            this.TxtSubtotal.Size = new System.Drawing.Size(190, 20);
            this.TxtSubtotal.TabIndex = 45;
            // 
            // TxtValor
            // 
            this.TxtValor.Location = new System.Drawing.Point(31, 233);
            this.TxtValor.Margin = new System.Windows.Forms.Padding(2);
            this.TxtValor.Name = "TxtValor";
            this.TxtValor.ReadOnly = true;
            this.TxtValor.Size = new System.Drawing.Size(190, 20);
            this.TxtValor.TabIndex = 44;
            // 
            // Txt_Cantidad
            // 
            this.Txt_Cantidad.Location = new System.Drawing.Point(31, 196);
            this.Txt_Cantidad.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Cantidad.Name = "Txt_Cantidad";
            this.Txt_Cantidad.Size = new System.Drawing.Size(190, 20);
            this.Txt_Cantidad.TabIndex = 2;
            this.Txt_Cantidad.Text = "1";
            this.Txt_Cantidad.TextChanged += new System.EventHandler(this.Txt_Cantidad_TextChanged);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(31, 159);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(190, 20);
            this.txtCodigo.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 255);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Subtotal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Valor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 181);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 38;
            this.label5.Text = "Cantidad";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 144);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 37;
            this.label4.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 28);
            this.label1.TabIndex = 34;
            this.label1.Text = "DATOS FACTURA";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.Location = new System.Drawing.Point(127, 316);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(94, 27);
            this.btn_cancelar.TabIndex = 4;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_add_producto
            // 
            this.btn_add_producto.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btn_add_producto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_producto.Location = new System.Drawing.Point(31, 316);
            this.btn_add_producto.Margin = new System.Windows.Forms.Padding(2);
            this.btn_add_producto.Name = "btn_add_producto";
            this.btn_add_producto.Size = new System.Drawing.Size(92, 27);
            this.btn_add_producto.TabIndex = 3;
            this.btn_add_producto.Text = "Agregar Pr";
            this.btn_add_producto.UseVisualStyleBackColor = true;
            this.btn_add_producto.Click += new System.EventHandler(this.btn_add_producto_Click);
            // 
            // CmboxProducto
            // 
            this.CmboxProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CmboxProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CmboxProducto.DataSource = this.bindingSourceProductoCmbox;
            this.CmboxProducto.DisplayMember = "Nombre";
            this.CmboxProducto.FormattingEnabled = true;
            this.CmboxProducto.Location = new System.Drawing.Point(31, 120);
            this.CmboxProducto.Name = "CmboxProducto";
            this.CmboxProducto.Size = new System.Drawing.Size(190, 21);
            this.CmboxProducto.TabIndex = 1;
            this.CmboxProducto.ValueMember = "Codigo";
            this.CmboxProducto.SelectedIndexChanged += new System.EventHandler(this.CmboxProducto_SelectedIndexChanged);
            // 
            // bindingSourceProductoCmbox
            // 
            this.bindingSourceProductoCmbox.DataMember = "Producto";
            this.bindingSourceProductoCmbox.DataSource = this.facturaDataSet;
            // 
            // facturaDataSet
            // 
            this.facturaDataSet.DataSetName = "FacturaDataSet";
            this.facturaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 104);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Nombre";
            // 
            // lbl_Iva
            // 
            this.lbl_Iva.AutoSize = true;
            this.lbl_Iva.Location = new System.Drawing.Point(141, 70);
            this.lbl_Iva.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Iva.Name = "lbl_Iva";
            this.lbl_Iva.Size = new System.Drawing.Size(0, 13);
            this.lbl_Iva.TabIndex = 35;
            // 
            // LblCantidadStock
            // 
            this.LblCantidadStock.AutoSize = true;
            this.LblCantidadStock.Location = new System.Drawing.Point(184, 83);
            this.LblCantidadStock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblCantidadStock.Name = "LblCantidadStock";
            this.LblCantidadStock.Size = new System.Drawing.Size(0, 13);
            this.LblCantidadStock.TabIndex = 50;
            // 
            // LblValorUnitario
            // 
            this.LblValorUnitario.AutoSize = true;
            this.LblValorUnitario.Location = new System.Drawing.Point(192, 96);
            this.LblValorUnitario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblValorUnitario.Name = "LblValorUnitario";
            this.LblValorUnitario.Size = new System.Drawing.Size(0, 13);
            this.LblValorUnitario.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Stock = ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 96);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Vlr Uni = ";
            // 
            // Txt_Nombre
            // 
            this.Txt_Nombre.AutoSize = true;
            this.Txt_Nombre.ForeColor = System.Drawing.Color.Transparent;
            this.Txt_Nombre.Location = new System.Drawing.Point(240, 341);
            this.Txt_Nombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Txt_Nombre.Name = "Txt_Nombre";
            this.Txt_Nombre.Size = new System.Drawing.Size(0, 13);
            this.Txt_Nombre.TabIndex = 54;
            // 
            // DFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 374);
            this.Controls.Add(this.Txt_Nombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblValorUnitario);
            this.Controls.Add(this.LblCantidadStock);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CmboxProducto);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_add_producto);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.TxtValor);
            this.Controls.Add(this.Txt_Cantidad);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_Iva);
            this.Controls.Add(this.label1);
            this.Name = "DFactura";
            this.Text = "DFactura";
            this.Load += new System.EventHandler(this.DFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceProductoCmbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TxtSubtotal;
        private System.Windows.Forms.TextBox TxtValor;
        private System.Windows.Forms.TextBox Txt_Cantidad;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_add_producto;
        private System.Windows.Forms.ComboBox CmboxProducto;
        private Negocio.FacturaDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceProductoCmbox;
        private Negocio.FacturaDataSet facturaDataSet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_Iva;
        private System.Windows.Forms.Label LblCantidadStock;
        private System.Windows.Forms.Label LblValorUnitario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Txt_Nombre;
    }
}