namespace MartinaProject2024
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgbProductos = new System.Windows.Forms.DataGridView();
            this.pictureOpen = new System.Windows.Forms.PictureBox();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRegistrarPedidos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgbProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpen)).BeginInit();
            this.SuspendLayout();
            // 
            // dgbProductos
            // 
            this.dgbProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgbProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgbProductos.Location = new System.Drawing.Point(12, 31);
            this.dgbProductos.MultiSelect = false;
            this.dgbProductos.Name = "dgbProductos";
            this.dgbProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgbProductos.Size = new System.Drawing.Size(559, 265);
            this.dgbProductos.TabIndex = 0;
            this.dgbProductos.SelectionChanged += new System.EventHandler(this.dgbProductos_SelectionChanged);
            // 
            // pictureOpen
            // 
            this.pictureOpen.Location = new System.Drawing.Point(605, 31);
            this.pictureOpen.Name = "pictureOpen";
            this.pictureOpen.Size = new System.Drawing.Size(297, 265);
            this.pictureOpen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureOpen.TabIndex = 1;
            this.pictureOpen.TabStop = false;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(35, 370);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(145, 23);
            this.btnAgregarProducto.TabIndex = 2;
            this.btnAgregarProducto.Text = "Agregar nuevo producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Registrar venta";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(485, 371);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Ver pedidos";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegistrarPedidos
            // 
            this.btnRegistrarPedidos.Location = new System.Drawing.Point(584, 371);
            this.btnRegistrarPedidos.Name = "btnRegistrarPedidos";
            this.btnRegistrarPedidos.Size = new System.Drawing.Size(116, 23);
            this.btnRegistrarPedidos.TabIndex = 5;
            this.btnRegistrarPedidos.Text = "Registrar pedidos";
            this.btnRegistrarPedidos.UseVisualStyleBackColor = true;
            this.btnRegistrarPedidos.Click += new System.EventHandler(this.btnRegistrarPedidos_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 450);
            this.Controls.Add(this.btnRegistrarPedidos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.pictureOpen);
            this.Controls.Add(this.dgbProductos);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de productos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgbProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOpen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgbProductos;
        private System.Windows.Forms.PictureBox pictureOpen;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRegistrarPedidos;
    }
}

