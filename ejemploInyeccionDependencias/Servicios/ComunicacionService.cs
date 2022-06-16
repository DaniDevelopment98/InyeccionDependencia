using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploInyeccionDependencias.Servicios
{
    //Se crea una clase para implementar de mejor manera como juegan los servicios 
    public class ComunicacionService
    {
        private IEnviar _Enviar;

        public ComunicacionService(IEnviar enviar)
        {
            _Enviar = enviar;
        }

        public void EnviarMensaje(Clientes clientes, string mensaje)
        {
            _Enviar.Enviar(clientes,mensaje);
        }
    }
}
