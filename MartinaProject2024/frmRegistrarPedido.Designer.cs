namespace MartinaProject2024
{
    partial class frmRegistrarPedido
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
            this.lblProveedor = new System.Windows.Forms.Label();
            this.lblProducto = new System.Windows.Forms.Label();
            this.lblUnidad = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.lblEnvio = new System.Windows.Forms.Label();
            this.lblGastoTotal = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.txtPrecioEnvio = new System.Windows.Forms.TextBox();
            this.txtGastoTotal = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.btnAceptarPedido = new System.Windows.Forms.Button();
            this.btnCancelarPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(40, 41);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(56, 13);
            this.lblProveedor.TabIndex = 0;
            this.lblProveedor.Text = "Proveedor";
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(40, 94);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto";
            // 
            // lblUnidad
            // 
            this.lblUnidad.AutoSize = true;
            this.lblUnidad.Location = new System.Drawing.Point(40, 139);
            this.lblUnidad.Name = "lblUnidad";
            this.lblUnidad.Size = new System.Drawing.Size(90, 13);
            this.lblUnidad.TabIndex = 2;
            this.lblUnidad.Text = "Precio por unidad";
            this.lblUnidad.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(40, 186);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 3;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Location = new System.Drawing.Point(40, 215);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(60, 13);
            this.lblPrecioTotal.TabIndex = 4;
            this.lblPrecioTotal.Text = "Precio total";
            // 
            // lblEnvio
            // 
            this.lblEnvio.AutoSize = true;
            this.lblEnvio.Location = new System.Drawing.Point(40, 251);
            this.lblEnvio.Name = "lblEnvio";
            this.lblEnvio.Size = new System.Drawing.Size(83, 13);
            this.lblEnvio.TabIndex = 5;
            this.lblEnvio.Text = "Precio de envío";
            // 
            // lblGastoTotal
            // 
            this.lblGastoTotal.AutoSize = true;
            this.lblGastoTotal.Location = new System.Drawing.Point(40, 288);
            this.lblGastoTotal.Name = "lblGastoTotal";
            this.lblGastoTotal.Size = new System.Drawing.Size(58, 13);
            this.lblGastoTotal.TabIndex = 6;
            this.lblGastoTotal.Text = "Gasto total";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(40, 324);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 7;
            this.lblFecha.Text = "Fecha";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(144, 41);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(100, 20);
            this.txtProveedor.TabIndex = 8;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(144, 94);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 9;
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Location = new System.Drawing.Point(144, 139);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioUnidad.TabIndex = 10;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(144, 186);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 11;
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Location = new System.Drawing.Point(144, 215);
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioTotal.TabIndex = 12;
            // 
            // txtPrecioEnvio
            // 
            this.txtPrecioEnvio.Location = new System.Drawing.Point(144, 251);
            this.txtPrecioEnvio.Name = "txtPrecioEnvio";
            this.txtPrecioEnvio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioEnvio.TabIndex = 13;
            // 
            // txtGastoTotal
            // 
            this.txtGastoTotal.Location = new System.Drawing.Point(144, 288);
            this.txtGastoTotal.Name = "txtGastoTotal";
            this.txtGastoTotal.Size = new System.Drawing.Size(100, 20);
            this.txtGastoTotal.TabIndex = 14;
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(144, 324);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 15;
            // 
            // btnAceptarPedido
            // 
            this.btnAceptarPedido.Location = new System.Drawing.Point(43, 380);
            this.btnAceptarPedido.Name = "btnAceptarPedido";
            this.btnAceptarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnAceptarPedido.TabIndex = 16;
            this.btnAceptarPedido.Text = "Aceptar";
            this.btnAceptarPedido.UseVisualStyleBackColor = true;
            this.btnAceptarPedido.Click += new System.EventHandler(this.btnAceptarPedido_Click);
            // 
            // btnCancelarPedido
            // 
            this.btnCancelarPedido.Location = new System.Drawing.Point(187, 380);
            this.btnCancelarPedido.Name = "btnCancelarPedido";
            this.btnCancelarPedido.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarPedido.TabIndex = 17;
            this.btnCancelarPedido.Text = "Cancelar";
            this.btnCancelarPedido.UseVisualStyleBackColor = true;
            this.btnCancelarPedido.Click += new System.EventHandler(this.btnCancelarPedido_Click);
            // 
            // frmRegistrarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 450);
            this.Controls.Add(this.btnCancelarPedido);
            this.Controls.Add(this.btnAceptarPedido);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtGastoTotal);
            this.Controls.Add(this.txtPrecioEnvio);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPrecioUnidad);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblGastoTotal);
            this.Controls.Add(this.lblEnvio);
            this.Controls.Add(this.lblPrecioTotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblUnidad);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.lblProveedor);
            this.Name = "frmRegistrarPedido";
            this.Text = "Registrar Pedido";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label lblUnidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblPrecioTotal;
        private System.Windows.Forms.Label lblEnvio;
        private System.Windows.Forms.Label lblGastoTotal;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtProveedor;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.TextBox txtPrecioUnidad;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtPrecioTotal;
        private System.Windows.Forms.TextBox txtPrecioEnvio;
        private System.Windows.Forms.TextBox txtGastoTotal;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Button btnAceptarPedido;
        private System.Windows.Forms.Button btnCancelarPedido;
    }
}