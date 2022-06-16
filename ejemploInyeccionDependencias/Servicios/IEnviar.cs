using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploInyeccionDependencias.Servicios
{
    // Interfaz que propone a que direccion enviar para mandar los mensajes
  public  interface IEnviar
    {
        public void Enviar(Clientes clientes, string Mensaje);

    }
}
