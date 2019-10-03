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
    public partial class EditarCliente : Form
    {
        private CN_Cliente objetoCN_Cliente = new CN_Cliente();
        public EditarCliente()
        {
            this.Text = "EDITAR CLIENTE";
            InitializeComponent();
            LlenarCB();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN_Cliente.actualizarCliente(txtDNI.Text, txtNombreCliente.Text, txtApellido.Text, txtTelefono.Text, txtMail.Text, txtDireccion.Text, cbCategoria1.Text);
                MessageBox.Show("Se actualizo correctamente");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar el cliente porque: " + ex);
            }
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
                    cbCategoria1.DisplayMember = "descripcion";
                    cbCategoria1.DataSource = ds.Tables["Categorias"];
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
