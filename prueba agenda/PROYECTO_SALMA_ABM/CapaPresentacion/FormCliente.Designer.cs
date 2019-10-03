namespace CapaPresentacion
{
    partial class FormCliente
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
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.textbox7 = new System.Windows.Forms.Label();
            this.labl4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.Label();
            this.label555 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtDireccion.Location = new System.Drawing.Point(33, 365);
            this.txtDireccion.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(267, 24);
            this.txtDireccion.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label13.Location = new System.Drawing.Point(36, 343);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 18);
            this.label13.TabIndex = 57;
            this.label13.Text = "Direccion";
            // 
            // txtDNI
            // 
            this.txtDNI.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtDNI.Location = new System.Drawing.Point(33, 77);
            this.txtDNI.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(267, 24);
            this.txtDNI.TabIndex = 1;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDNI_KeyPress);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtNombreCliente.Location = new System.Drawing.Point(33, 131);
            this.txtNombreCliente.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(267, 24);
            this.txtNombreCliente.TabIndex = 2;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtApellido.Location = new System.Drawing.Point(33, 186);
            this.txtApellido.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(267, 24);
            this.txtApellido.TabIndex = 3;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtTelefono.Location = new System.Drawing.Point(33, 247);
            this.txtTelefono.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(267, 24);
            this.txtTelefono.TabIndex = 4;
            // 
            // textbox7
            // 
            this.textbox7.AutoSize = true;
            this.textbox7.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.textbox7.Location = new System.Drawing.Point(36, 165);
            this.textbox7.Name = "textbox7";
            this.textbox7.Size = new System.Drawing.Size(55, 18);
            this.textbox7.TabIndex = 52;
            this.textbox7.Text = "Apellido";
            // 
            // labl4
            // 
            this.labl4.AutoSize = true;
            this.labl4.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.labl4.Location = new System.Drawing.Point(36, 225);
            this.labl4.Name = "labl4";
            this.labl4.Size = new System.Drawing.Size(65, 18);
            this.labl4.TabIndex = 51;
            this.labl4.Text = "Telefono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label10.Location = new System.Drawing.Point(34, 56);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 18);
            this.label10.TabIndex = 50;
            this.label10.Text = "DNI";
            // 
            // textbox
            // 
            this.textbox.AutoSize = true;
            this.textbox.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.textbox.Location = new System.Drawing.Point(34, 110);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(60, 18);
            this.textbox.TabIndex = 49;
            this.textbox.Text = "Nombre";
            // 
            // label555
            // 
            this.label555.AutoSize = true;
            this.label555.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label555.Location = new System.Drawing.Point(34, 284);
            this.label555.Name = "label555";
            this.label555.Size = new System.Drawing.Size(32, 18);
            this.label555.TabIndex = 48;
            this.label555.Text = "Mail";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtMail.Location = new System.Drawing.Point(33, 305);
            this.txtMail.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(267, 24);
            this.txtMail.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 23);
            this.label7.TabIndex = 46;
            this.label7.Text = "Cliente";
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(208, 474);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 33);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label1.Location = new System.Drawing.Point(36, 407);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 60;
            this.label1.Text = "Categoria";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(33, 428);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(267, 25);
            this.cbCategoria.TabIndex = 61;
            // 
            // FormCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(237)))), ((int)(((byte)(238)))));
            this.ClientSize = new System.Drawing.Size(341, 531);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.textbox7);
            this.Controls.Add(this.labl4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.label555);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label7);
            this.Name = "FormCliente";
            this.Text = "FormCliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label textbox7;
        private System.Windows.Forms.Label labl4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label textbox;
        private System.Windows.Forms.Label label555;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtDireccion;
        public System.Windows.Forms.TextBox txtDNI;
        public System.Windows.Forms.TextBox txtNombreCliente;
        public System.Windows.Forms.TextBox txtApellido;
        public System.Windows.Forms.TextBox txtTelefono;
        public System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.ComboBox cbCategoria;
    }
}