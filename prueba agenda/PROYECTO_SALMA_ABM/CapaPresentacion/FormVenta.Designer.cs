namespace CapaPresentacion
{
    partial class Venta
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.cbProductos = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTalles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbDescripcion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNombreCliente = new System.Windows.Forms.ComboBox();
            this.stock = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtCantidad.Location = new System.Drawing.Point(24, 369);
            this.txtCantidad.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(267, 30);
            this.txtCantidad.TabIndex = 5;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(201, 430);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 33);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // cbProductos
            // 
            this.cbProductos.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.cbProductos.FormattingEnabled = true;
            this.cbProductos.Location = new System.Drawing.Point(24, 145);
            this.cbProductos.Name = "cbProductos";
            this.cbProductos.Size = new System.Drawing.Size(267, 25);
            this.cbProductos.TabIndex = 2;
            this.cbProductos.SelectedIndexChanged += new System.EventHandler(this.CbProductos_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label4.Location = new System.Drawing.Point(25, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Producto";
            // 
            // cbCategorias
            // 
            this.cbCategorias.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(24, 91);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(267, 25);
            this.cbCategorias.TabIndex = 1;
            this.cbCategorias.SelectedValueChanged += new System.EventHandler(this.CbCategorias_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label3.Location = new System.Drawing.Point(25, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label2.Location = new System.Drawing.Point(25, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cantidad";
            // 
            // cbTalles
            // 
            this.cbTalles.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.cbTalles.FormattingEnabled = true;
            this.cbTalles.Location = new System.Drawing.Point(24, 260);
            this.cbTalles.Name = "cbTalles";
            this.cbTalles.Size = new System.Drawing.Size(267, 25);
            this.cbTalles.TabIndex = 4;
            this.cbTalles.SelectedIndexChanged += new System.EventHandler(this.CbTalles_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label1.Location = new System.Drawing.Point(27, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Talle";
            // 
            // cbDescripcion
            // 
            this.cbDescripcion.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.cbDescripcion.FormattingEnabled = true;
            this.cbDescripcion.Location = new System.Drawing.Point(24, 200);
            this.cbDescripcion.Name = "cbDescripcion";
            this.cbDescripcion.Size = new System.Drawing.Size(267, 25);
            this.cbDescripcion.TabIndex = 3;
            this.cbDescripcion.SelectedIndexChanged += new System.EventHandler(this.CbDescripcion_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label5.Location = new System.Drawing.Point(27, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 23);
            this.label6.TabIndex = 26;
            this.label6.Text = "Producto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label7.Location = new System.Drawing.Point(25, 294);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Nombre";
            // 
            // cbNombreCliente
            // 
            this.cbNombreCliente.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.cbNombreCliente.FormattingEnabled = true;
            this.cbNombreCliente.Location = new System.Drawing.Point(24, 315);
            this.cbNombreCliente.Name = "cbNombreCliente";
            this.cbNombreCliente.Size = new System.Drawing.Size(267, 25);
            this.cbNombreCliente.TabIndex = 29;
            // 
            // stock
            // 
            this.stock.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.stock.Location = new System.Drawing.Point(62, 430);
            this.stock.MinimumSize = new System.Drawing.Size(4, 30);
            this.stock.Name = "stock";
            this.stock.Size = new System.Drawing.Size(28, 30);
            this.stock.TabIndex = 30;
            this.stock.Visible = false;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(324, 483);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.cbNombreCliente);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbDescripcion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbTalles);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProductos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.Name = "Venta";
            this.Text = "FormInventario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ComboBox cbProductos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbDescripcion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbNombreCliente;
        private System.Windows.Forms.TextBox stock;
    }
}