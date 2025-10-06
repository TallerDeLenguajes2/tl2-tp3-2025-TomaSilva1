using Cadetes;
using Cadeteria;
using InterfazLectura;

namespace CsvRead
{
    public class LeerCsv : ILectorArchivos
    {
        private string ruta1;
        private string ruta2;

        public Empresa leerArchivos()
        {
            ruta1 = "cadeteria.csv"; //definimos las rutas de los csv
            ruta2 = "cadetes.csv";

            string[] lineas1 = File.ReadAllLines(ruta1); //leemos cadeteria.csv
            string[] lineas2 = File.ReadAllLines(ruta2); //leemos cadetes.csv

            string[] partes1 = lineas1[1].Split(";");//Aqui comenzamos en [1] porque nos salteamos los nombre de los "atributos"
                                                     //Y utilizamos split(";") para hacer un arreglo con la tupla, en este caso es 1 sola.

            Empresa empresa = new Empresa(partes1[0], partes1[1]);

            int aux = lineas2.Count();
            for (int i = 1; i < aux; i++)
            {
                string linea2 = lineas2[i];
                string[] partes2 = linea2.Split(";");

                Cadete empleado = new Cadete(int.Parse(partes2[0]), partes2[1], partes2[2], partes2[3]);
                empresa.contratarCadete(empleado);
            }

            return empresa;
        }
    }
}