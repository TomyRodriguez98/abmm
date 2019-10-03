using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CapaNegocio;
using CapaPresentacionPrincipal;

namespace CapaPresentacion
{
    public partial class Venta : Form
    {
        private CN_Productos objetoCN_Prod = new CN_Productos();
        private CN_Categoria objetoCN_Cat = new CN_Categoria();
        private CN_Ventas objetoCN_Ventas = new CN_Ventas();
        private CN_Cliente objetocN_Cliente = new CN_Cliente();

        public Venta()
        {
            InitializeComponent();
            this.Text = "NUEVA VENTA";
            ObtenerCategorias();
            ObtenerClientes();
        }

        protected void ObtenerClientes()
        {
            cbNombreCliente.DataSource = objetocN_Cliente.buscarClientes();
        }
        protected void ObtenerCategorias()
        {
            cbCategorias.DataSource = objetoCN_Cat.BuscarCat();   
        }

        private void CbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = cbCategorias.Text;
            cbProductos.DataSource = objetoCN_Prod.buscarProductos(x);
        }

        private void CbProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = cbCategorias.Text;
            string y = cbProductos.Text;
            cbDescripcion.DataSource = objetoCN_Prod.buscarDescripciones(y,x);
        }

        private void CbDescripcion_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = cbCategorias.Text;
            string y = cbProductos.Text;
            string z = cbDescripcion.Text;
            cbTalles.DataSource = objetoCN_Prod.buscarTal(y, x, z);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            string x = cbCategorias.Text;
            string y = cbProductos.Text;
            string z = cbDescripcion.Text;
            string a = cbTalles.Text;
            string b = txtCantidad.Text;
            string c = cbNombreCliente.Text;
            if (Convert.ToInt32(b) > Convert.ToInt32(stock.Text))
            {
                MessageBox.Show("Stock insuficiente");
            }
            else
            {
                try
                {
                    objetoCN_Ventas.InsertarVenta(x, y, z, a, b, c);
                    MessageBox.Show("La venta se cargo con exito");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar la venta porque: " + ex);
                }

            }


        }

        private void TxtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void CbTalles_SelectedIndexChanged(object sender, EventArgs e)
        {
            string x = cbCategorias.Text;
            string y = cbProductos.Text;
            string z = cbDescripcion.Text;
            string a = cbTalles.Text;
            stock.Text = Convert.ToString(objetoCN_Prod.buscarStock(x, y, z, a));
        }
    }
}
