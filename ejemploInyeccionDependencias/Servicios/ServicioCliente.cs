 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejemploInyeccionDependencias.Repositorio;

namespace ejemploInyeccionDependencias.Servicios
{
    public class ServicioCliente
    {
        private repositorioClientes _Repository; 

        public ServicioCliente()
        {
            _Repository = new repositorioClientes();
        }
        public List<Clientes> GetClientes()
        {
            return _Repository.GetClientes();
        }
    }
}
