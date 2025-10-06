using System.Text.Json;
using Cadeteria;
using InterfazLectura;

namespace JsonRead
{ 
    public class leerJson : ILectorArchivos
    {
        private string ruta1;

        public Empresa leerArchivos()
        {
            ruta1 = "cadeteria.json";
            string contenido1 = File.ReadAllText(ruta1);

            Empresa empresa = JsonSerializer.Deserialize<Empresa>(contenido1);

            return empresa;
        }
    }
}