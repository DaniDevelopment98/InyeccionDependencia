using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploInyeccionDependencias.Servicios
{
    public class SMSService:IEnviar
    {
        public void Enviar(Clientes clientes, string Mensaje)
        {
            Console.WriteLine($"Mensaje Enviado a {clientes.Nombre} por SMS");
        }
    }
}
