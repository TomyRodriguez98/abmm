using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class FormCliente : Form
    {
        private CN_Cliente objetoCN_Cliente = new CN_Cliente();
        public FormCliente()
        {
            InitializeComponent();
            this.Text = "NUEVO CLIENTE";
            LlenarCB();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN_Cliente.insertarCliente(txtDNI.Text, txtNombreCliente.Text, txtApellido.Text, txtTelefono.Text, txtMail.Text, txtDireccion.Text, cbCategoria.Text);
                MessageBox.Show("Se creo un nuevo cliente con exito");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo crear el nuevo cliente porque: " + ex);
            }
        }

        private void TxtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        public void LlenarCB()
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;DataBase=PROYECTO_SALMA_ABM;Integrated Security=true"))
            {
                try
                {
                    string query = "SELECT descripcion FROM Categorias";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Categorias");
                    cbCategoria.DisplayMember = "descripcion";
                    cbCategoria.DataSource = ds.Tables["Categorias"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Ocurrio un error" + ex);
                }
            }
        }
    }
}
