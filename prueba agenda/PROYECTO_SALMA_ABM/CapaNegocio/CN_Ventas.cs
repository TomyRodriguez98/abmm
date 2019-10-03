using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Ventas
    {
        private CD_Ventas objetoCD_Ventas = new CD_Ventas();

        public void InsertarVenta(string cat, string prod, string desc, string talle, string cant, string apellido)
        {
            objetoCD_Ventas.crearVenta(cat, prod, desc, Convert.ToInt32(talle), Convert.ToInt32(cant), apellido);
        }

        public DataTable mostrarVentas()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD_Ventas.MostrarVentas();
            return tabla;
        }

        public void eliminarVenta(string id)
        {
            objetoCD_Ventas.Eliminar(Convert.ToInt32(id));
        }
    }
}
