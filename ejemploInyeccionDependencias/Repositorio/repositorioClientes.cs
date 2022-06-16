using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploInyeccionDependencias.Repositorio
{
    public class repositorioClientes
    {
        //Ejemplo de Repositorio para ejemplificar de mejor manera de com funcionaria si usaramos una BD real de manera formal
        private SqlConeection _Conecction;

        public repositorioClientes()
        {
            _Conecction = new SqlConeection();

        }
        //Crear datos para nuestra base
        public List<Clientes> GetClientes()
        {
            if (_Conecction.GetType() == typeof(SqlConeection))
                Console.WriteLine("Clientes Extraidos de la base de datos SQL");
            {
                return new List<Clientes>
                {
                    new Clientes(){id=1,Nombre="Juan",Email="juan21@hotmail.com",Telefono="987654123"},
                    new Clientes(){id=2,Nombre="David",Email="David32@gmail.com",Telefono="987564312"}
                };
            }
        }
    }
}
