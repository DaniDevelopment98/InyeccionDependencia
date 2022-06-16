using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ejemploInyeccionDependencias.Repositorio;
using ejemploInyeccionDependencias.Servicios;
namespace ejemploInyeccionDependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dependencias

            var envia = new SMSService();
            var ServicioCliente = new ServicioCliente();
            var ServicioComunicacion = new ComunicacionService(envia);
            var Nomcliente = ServicioCliente.GetClientes();

            var mensaje = "Mensaje enviado a todos los clientes";

            foreach (var clientes in Nomcliente)
            {
                ServicioComunicacion.EnviarMensaje(clientes, mensaje);
            }
            Console.ReadLine();
        }
    }
}
