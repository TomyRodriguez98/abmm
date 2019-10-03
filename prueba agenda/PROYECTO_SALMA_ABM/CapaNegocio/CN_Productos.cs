 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Productos
    {
        private CD_Productos objetoCD = new CD_Productos();

        public DataTable MostrarProd()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }

        public void InsertarProd(string talle, string nombre, string desc, string precio, string costo,string stock, string categoria)
        {

            objetoCD.Insertar(Convert.ToInt32(talle), nombre, desc, Convert.ToDouble(precio), Convert.ToDouble(costo),Convert.ToInt32(stock), categoria);
        }

        public void EditarProd(string talle, string nombre, string desc, string precio, string costo,string stock, string categoria, string id)
        {
            objetoCD.Editar(Convert.ToInt32(talle), nombre, desc, Convert.ToDouble(precio), Convert.ToDouble(costo),Convert.ToInt32(stock), categoria, Convert.ToInt32(id));
        }

        public void EliminarProd(string id)
        {
            objetoCD.Eliminar(Convert.ToInt32(id));
        }

        public List<string> buscarProductos(string cat)
        {
            List<string> lista = new List<string>();
            lista = objetoCD.Buscar(cat);
            return lista;
        }

        public List<string> buscarDescripciones(string nombre, string cat)
        {
            List<string> lista = new List<string>();
            lista = objetoCD.BuscarDesc(nombre,cat);
            return lista;
        }

        public List<string> buscarTal(string nombre, string cat, string desc)
        {
            List<string> lista = new List<string>();
            lista = objetoCD.Buscartalles(nombre, cat, desc);
            return lista;
        }

        public int buscarStock(string cat, string nombre, string desc, string talle)
        {
            int i = objetoCD.BuscarStock(nombre, cat, desc, Convert.ToInt32(talle));
            return i;
        }
    }
}
