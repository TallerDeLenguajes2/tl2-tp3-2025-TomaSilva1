using System.ComponentModel;

namespace Clientes
{
    public class Cliente
    {
        private string nombre;
        private string direccion;
        private string telefono;
        private string datosReferencia;


        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string DatosReferencia { get => datosReferencia; set => datosReferencia = value; }

        public Cliente(string nombre, string direccion, string telefono, string datosReferencia)
        {

            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.datosReferencia = datosReferencia;

        }

        public Cliente(){
            
        }

    }

}

