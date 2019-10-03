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
    public partial class EliminarCliente : Form
    {
        private CN_Cliente objetoCN_Cliente = new CN_Cliente();
        public EliminarCliente()
        {
            InitializeComponent();
            LlenarCB();
        }

        protected void LlenarCB()
        {
            using (SqlConnection conn = new SqlConnection("Server=localhost\\SQLEXPRESS;DataBase=PROYECTO_SALMA_ABM;Integrated Security=true"))
            {
                try
                {
                    string query = "SELECT dni FROM Clientes";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    conn.Open();
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Clientes");
                    cbDNI.DisplayMember = "dni";
                    cbDNI.DataSource = ds.Tables["Clientes"];
                }
                catch (Exception ex)
                {
                    // write exception info to log or anything else
                    MessageBox.Show("Ocurrio un error" + ex);
                }
            }
        }

        private void CbDNI_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtApellido.Text = objetoCN_Cliente.buscarApellido(cbDNI.Text)[0];
            txtNombreCliente.Text = objetoCN_Cliente.buscarNombre(cbDNI.Text)[0];
            txtTelefono.Text = objetoCN_Cliente.buscarTelefono(cbDNI.Text)[0];
            txtMail.Text = objetoCN_Cliente.buscarMail(cbDNI.Text)[0];
            txtDireccion.Text = objetoCN_Cliente.buscarDireccion(cbDNI.Text)[0];
            txtColegio.Text = objetoCN_Cliente.buscarColegio(cbDNI.Text)[0];
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN_Cliente.eliminarCliente(cbDNI.Text);
                LlenarCB();
                MessageBox.Show("El cliente se elimino con exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show("El cliente no se pudo eliminar porque: "+ex);
            }
        }
    }
}
