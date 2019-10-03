namespace CapaPresentacion
{
    partial class FormCategorias
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtModificarCat = new System.Windows.Forms.TextBox();
            this.btnNuevoCliente = new System.Windows.Forms.Button();
            this.btnNuevoInv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnGuardar.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(204, 99);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 33);
            this.btnGuardar.TabIndex = 15;
            this.btnGuardar.Text = "Añadir";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nueva Categoria";
            // 
            // txtCategoria
            // 
            this.txtCategoria.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtCategoria.Location = new System.Drawing.Point(19, 52);
            this.txtCategoria.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(267, 24);
            this.txtCategoria.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(36, 147);
            this.label7.MaximumSize = new System.Drawing.Size(500, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 2);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // cbCategoria
            // 
            this.cbCategoria.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(19, 202);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(267, 25);
            this.cbCategoria.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label3.Location = new System.Drawing.Point(16, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Modificar Categoria";
            // 
            // txtModificarCat
            // 
            this.txtModificarCat.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.txtModificarCat.Location = new System.Drawing.Point(19, 282);
            this.txtModificarCat.MinimumSize = new System.Drawing.Size(4, 30);
            this.txtModificarCat.Name = "txtModificarCat";
            this.txtModificarCat.Size = new System.Drawing.Size(267, 30);
            this.txtModificarCat.TabIndex = 21;
            // 
            // btnNuevoCliente
            // 
            this.btnNuevoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnNuevoCliente.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnNuevoCliente.ForeColor = System.Drawing.Color.White;
            this.btnNuevoCliente.Location = new System.Drawing.Point(19, 340);
            this.btnNuevoCliente.Name = "btnNuevoCliente";
            this.btnNuevoCliente.Size = new System.Drawing.Size(113, 33);
            this.btnNuevoCliente.TabIndex = 26;
            this.btnNuevoCliente.Text = "Eliminar";
            this.btnNuevoCliente.UseVisualStyleBackColor = false;
            // 
            // btnNuevoInv
            // 
            this.btnNuevoInv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(85)))), ((int)(((byte)(99)))));
            this.btnNuevoInv.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.btnNuevoInv.ForeColor = System.Drawing.Color.White;
            this.btnNuevoInv.Location = new System.Drawing.Point(157, 340);
            this.btnNuevoInv.Name = "btnNuevoInv";
            this.btnNuevoInv.Size = new System.Drawing.Size(129, 33);
            this.btnNuevoInv.TabIndex = 25;
            this.btnNuevoInv.Text = "Modificar";
            this.btnNuevoInv.UseVisualStyleBackColor = false;
            this.btnNuevoInv.Click += new System.EventHandler(this.BtnNuevoInv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.label1.Location = new System.Drawing.Point(16, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 27;
            this.label1.Text = "Nueva Categoria";
            // 
            // FormCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 402);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNuevoCliente);
            this.Controls.Add(this.btnNuevoInv);
            this.Controls.Add(this.txtModificarCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoria);
            this.Name = "FormCategorias";
            this.Text = "FormCategorias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtModificarCat;
        private System.Windows.Forms.Button btnNuevoCliente;
        private System.Windows.Forms.Button btnNuevoInv;
        private System.Windows.Forms.Label label1;
    }
}