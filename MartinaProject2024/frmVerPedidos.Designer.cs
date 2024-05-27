namespace MartinaProject2024
{
    partial class frmVerPedidos
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
            this.dgvVerPedido = new System.Windows.Forms.DataGridView();
            this.btnSalirP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVerPedido
            // 
            this.dgvVerPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerPedido.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvVerPedido.Location = new System.Drawing.Point(12, 51);
            this.dgvVerPedido.Name = "dgvVerPedido";
            this.dgvVerPedido.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVerPedido.Size = new System.Drawing.Size(843, 209);
            this.dgvVerPedido.TabIndex = 0;
            // 
            // btnSalirP
            // 
            this.btnSalirP.Location = new System.Drawing.Point(512, 384);
            this.btnSalirP.Name = "btnSalirP";
            this.btnSalirP.Size = new System.Drawing.Size(75, 23);
            this.btnSalirP.TabIndex = 1;
            this.btnSalirP.Text = "Salir";
            this.btnSalirP.UseVisualStyleBackColor = true;
            this.btnSalirP.Click += new System.EventHandler(this.btnSalirP_Click);
            // 
            // frmVerPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.btnSalirP);
            this.Controls.Add(this.dgvVerPedido);
            this.Name = "frmVerPedidos";
            this.Text = "frmVerPedidos";
            this.Load += new System.EventHandler(this.frmVerPedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVerPedido;
        private System.Windows.Forms.Button btnSalirP;
    }
}