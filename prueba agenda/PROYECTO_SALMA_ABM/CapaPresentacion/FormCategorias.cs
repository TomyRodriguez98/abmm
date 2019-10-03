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
    public partial class FormCategorias : Form
    {
        CN_Categoria objetoCNCat = new CN_Categoria();
        public FormCategorias()
        {
            InitializeComponent();
            this.Text = "NUEVA CATEGORIA";
            LlenarCB();
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
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string x = txtCategoria.Text;
                objetoCNCat.InsertarCat(x);
                MessageBox.Show("Se inserto la categoria con exito");
                LlenarCB();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo insertar la categoria porque: " + ex);
            }
        }

        private void BtnNuevoInv_Click(object sender, EventArgs e)
        {
            if (txtModificarCat.Text != "")
            {
                try
                {
                    objetoCNCat.ModificarCategoria(cbCategoria.Text, txtModificarCat.Text);
                    MessageBox.Show("Se modifico la categoria con exito");
                    LlenarCB();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo modificar la categoria porque: "+ex);
                    throw;
                }
            }
            else
            {
                MessageBox.Show("No cargo la categoria");
            }
        }
    }
}
