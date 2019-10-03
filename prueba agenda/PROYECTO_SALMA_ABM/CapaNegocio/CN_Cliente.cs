using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente objetoCD_Cliente = new CD_Cliente();

        public void insertarCliente(string dni, string nombre, string apellido, string telefono, string mail, string direccion, string colegio)
        {
            objetoCD_Cliente.Insertar(dni, nombre, apellido, telefono, mail, direccion, colegio);
        }

        public List<string> buscarClientes()
        {
            List<string> lista = new List<string>();
            lista = objetoCD_Cliente.buscarApellidos();
            return lista;
        }

        public List<string> buscarNombre(string dni)
        {
            List<string> lista = new List<string>();
            lista = objetoCD_Cliente.buscarnombre(dni);
            return lista;
        }

        public void actualizarCliente(string dni, string nombre, string apellido, string telefono, string mail, string direccion, string colegio)
        {
            objetoCD_Cliente.actualizar(dni, nombre, apellido, telefono, mail, direccion, colegio);
        }

        public List<string> buscarApellido(string dni)
        {
            List<string> lista = new List<string>();
            lista = objetoCD_Cliente.buscarApellido(dni);
            return lista;

        }
        public List<string> buscarTelefono(string dni)
        {
            List<string> lista = new List<string>();
            lista = objetoCD_Cliente.buscarTelefono(dni);
            return lista;

        }

        public List<string> buscarMail(string dni)
        {
            List<string> lista = new List<string>();
            lista = objetoCD_Cliente.buscarMail(dni);
            return lista;

        }

        public List<string> buscarDireccion(string dni)
        {
            List<string> lista = new List<string>();
            lista = objetoCD_Cliente.buscarDireccion(dni);
            return lista;

        }

        public List<string> buscarColegio(string dni)
        {
            List<string> lista = new List<string>();
            lista = objetoCD_Cliente.buscarColegio(dni);
            return lista;

        }

        public void eliminarCliente(string dni)
        {
            objetoCD_Cliente.Eliminar(dni);
        }

    }
}
