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
using CapaPresentacion;

namespace CapaPresentacionPrincipal
{
    public partial class Form1Principal : Form
    {
        CN_Productos objetoCNProd = new CN_Productos();
        CN_Categoria objetoCNCat = new CN_Categoria();
        private string idProducto = null;
        private bool Editar = false;
        public Form1Principal()
        {
            InitializeComponent();
            this.Text = "STOCK AGENDA";
            LlenarCB();
            cbCategoria.SelectedIndex = -1;
        }
        private void Form1Principal_Load(object sender, EventArgs e)
        {
            MostrarProductos();
            MostrarVentas();
        }

        protected void LlenarCB()
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

        private void MostrarProductos()
        {
            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
            dataGridView1.Columns[0].Width = 55;
            dataGridView1.Columns[1].Width = 185;
            dataGridView1.Columns[2].Width = 235;
            dataGridView1.Columns[3].Width = 235;
            dataGridView1.Columns[4].Width = 58;
            dataGridView1.Columns[5].Width = 60;
            dataGridView1.Columns[6].Width = 60;
            dataGridView1.Columns[7].Width = 60;
        }

        private void MostrarVentas()
        {
            CN_Ventas objeto = new CN_Ventas();
            dataGridView2.DataSource = objeto.mostrarVentas();
            dataGridView2.Columns[0].Width = 55;
            dataGridView2.Columns[1].Width = 55;
            dataGridView2.Columns[2].Width = 160;
            dataGridView2.Columns[3].Width = 160;
            dataGridView2.Columns[4].Width = 55;
            dataGridView2.Columns[5].Width = 80;
            dataGridView2.Columns[6].Width = 80;
            dataGridView2.Columns[7].Width = 160;
            dataGridView2.Columns[8].Width = 142;
            dataGridView2.Columns["Nombre"].Visible = false;
            dataGridView2.Columns["Telefono"].Visible = false;
            dataGridView2.Columns["Mail"].Visible = false;
            dataGridView2.Columns["Direccion"].Visible = false;
            dataGridView2.Columns["Colegio"].Visible = false;

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                try
                {
                    objetoCNProd.InsertarProd(txtTalle.Text, txtNombre.Text, txtDesc.Text, txtPrecio.Text, txtCosto.Text, txtStock.Text,cbCategoria.Text);
                    MessageBox.Show("Se inserto correctamente");
                    MostrarProductos();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo insertar los datos por: " + ex);

                }
            }
            if (Editar == true)
            {
                try
                {
                    objetoCNProd.EditarProd(txtTalle.Text, txtNombre.Text, txtDesc.Text, txtPrecio.Text, txtCosto.Text, txtStock.Text, cbCategoria.Text, idProducto);
                    MessageBox.Show("Se edito correctamente");
                    MostrarProductos();
                    Editar = false;
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron editar los datos por: " + ex);
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (Editar == true)
            {
                limpiarForm();
                Editar = false;
            }
            else
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    Editar = true;
                    txtNombre.Text = dataGridView1.CurrentRow.Cells["Producto"].Value.ToString();
                    cbCategoria.Text = dataGridView1.CurrentRow.Cells["Categoria"].Value.ToString();
                    txtDesc.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                    txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                    txtCosto.Text = dataGridView1.CurrentRow.Cells["Costo"].Value.ToString();
                    txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                    idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                    txtTalle.Text = dataGridView1.CurrentRow.Cells["Talle"].Value.ToString();
                }
                else
                    MessageBox.Show("Seleccione una fila a editar");
            }

        }

        private void limpiarForm()
        {
            txtDesc.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtStock.Clear();
            txtTalle.Clear();
            txtCosto.Clear();
            cbCategoria.SelectedIndex = -1;

        }

        private void BtnNuevoInv_Click(object sender, EventArgs e)
        {
            Venta nuevaVenta = new Venta();
            nuevaVenta.ShowDialog();
            MostrarProductos();
            MostrarVentas();
        }

        private void BtnNuevaCat_Click(object sender, EventArgs e)
        {
            FormCategorias nuevaVentana2 = new FormCategorias();
            nuevaVentana2.ShowDialog();
            LlenarCB();
            cbCategoria.SelectedIndex = -1;
        }

        private void TxtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtTalle_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TxtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnNuevoCliente_Click(object sender, EventArgs e)
        {
            FormCliente nuevaVentana3 = new FormCliente();
            nuevaVentana3.ShowDialog();
        }

        private void DataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditarCliente f2 = new EditarCliente();
            f2.txtDNI.Text = this.dataGridView2.CurrentRow.Cells[8].Value.ToString();
            f2.txtApellido.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            f2.txtNombreCliente.Text = dataGridView2.CurrentRow.Cells["Nombre"].Value.ToString();
            f2.txtTelefono.Text = dataGridView2.CurrentRow.Cells["Telefono"].Value.ToString();
            f2.txtMail.Text = dataGridView2.CurrentRow.Cells["Mail"].Value.ToString();
            f2.txtDireccion.Text = dataGridView2.CurrentRow.Cells["Direccion"].Value.ToString();
            f2.ShowDialog();
            MostrarVentas();
        }

        private void BtnEliminarCliente_Click(object sender, EventArgs e)
        {
            EliminarCliente ventanoide = new EliminarCliente();
            ventanoide.ShowDialog();
        }

        private void BtnBorrarProd_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();
                objetoCNProd.EliminarProd(id);
                MessageBox.Show("El producto se elimino con exito");
                MostrarProductos();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar porque: "+ex);

            }
        }

        private void BtnBorrarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                CN_Ventas objeto = new CN_Ventas();
                string id = dataGridView2.CurrentRow.Cells["ID de Venta"].Value.ToString();
                objeto.eliminarVenta(id);
                MessageBox.Show("El producto se elimino con exito");
                MostrarVentas();


            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar porque: " + ex);

            }
        }
    }
}
