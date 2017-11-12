namespace Edu.Uninpahu.Arquitectura.View
{
    partial class Menu
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
            this.btn_cliente = new System.Windows.Forms.Button();
            this.btn_empleado = new System.Windows.Forms.Button();
            this.btn_producto = new System.Windows.Forms.Button();
            this.btn_factura = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_cliente
            // 
            this.btn_cliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_cliente.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btn_cliente.Location = new System.Drawing.Point(273, 12);
            this.btn_cliente.Name = "btn_cliente";
            this.btn_cliente.Size = new System.Drawing.Size(103, 76);
            this.btn_cliente.TabIndex = 0;
            this.btn_cliente.Text = "Cliente";
            this.btn_cliente.UseVisualStyleBackColor = true;
            this.btn_cliente.Click += new System.EventHandler(this.btn_cliente_Click);
            // 
            // btn_empleado
            // 
            this.btn_empleado.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btn_empleado.Location = new System.Drawing.Point(12, 12);
            this.btn_empleado.Name = "btn_empleado";
            this.btn_empleado.Size = new System.Drawing.Size(103, 76);
            this.btn_empleado.TabIndex = 1;
            this.btn_empleado.Text = "Empleado";
            this.btn_empleado.UseVisualStyleBackColor = true;
            this.btn_empleado.Click += new System.EventHandler(this.btn_empleado_Click);
            // 
            // btn_producto
            // 
            this.btn_producto.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btn_producto.Location = new System.Drawing.Point(148, 12);
            this.btn_producto.Name = "btn_producto";
            this.btn_producto.Size = new System.Drawing.Size(103, 76);
            this.btn_producto.TabIndex = 2;
            this.btn_producto.Text = "Producto";
            this.btn_producto.UseVisualStyleBackColor = true;
            this.btn_producto.Click += new System.EventHandler(this.btn_producto_Click);
            // 
            // btn_factura
            // 
            this.btn_factura.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold);
            this.btn_factura.Location = new System.Drawing.Point(82, 111);
            this.btn_factura.Name = "btn_factura";
            this.btn_factura.Size = new System.Drawing.Size(103, 76);
            this.btn_factura.TabIndex = 3;
            this.btn_factura.Text = "Factura";
            this.btn_factura.UseVisualStyleBackColor = true;
            this.btn_factura.Click += new System.EventHandler(this.btn_factura_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(213, 110);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(97, 76);
            this.button5.TabIndex = 5;
            this.button5.Text = "Finalizar Sesión";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 217);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_factura);
            this.Controls.Add(this.btn_producto);
            this.Controls.Add(this.btn_empleado);
            this.Controls.Add(this.btn_cliente);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cliente;
        private System.Windows.Forms.Button btn_empleado;
        private System.Windows.Forms.Button btn_producto;
        private System.Windows.Forms.Button btn_factura;
        private System.Windows.Forms.Button button5;
    }
}