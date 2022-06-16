using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploInyeccionDependencias.Servicios
{
    //Envia el mensaje via email
   public class EmailService:IEnviar
    {
        public void Enviar(Clientes clientes,string Mensaje)
        {
            Console.WriteLine($"Mensaje Enviado a {clientes.Nombre} por Email");
        }
    }
}
