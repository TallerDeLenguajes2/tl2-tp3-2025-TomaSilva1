using Cadetes;
using Pedido;

#pragma warning disable IDE0130 // Namespace does not match folder structure
namespace Cadeteria
#pragma warning restore IDE0130 // Namespace does not match folder structure
{
    public class Empresa
    {
        private string nombreEmpresa;
        private string telefonoEmpresa;
        List<Cadete> listadoDeCadetes;

        List<Pedidos> listaDePedidos;

        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public string TelefonoEmpresa { get => telefonoEmpresa; set => telefonoEmpresa = value; }
        public List<Cadete> ListadoDeCadetes { get => listadoDeCadetes; set => listadoDeCadetes = value; }
        public List<Pedidos> ListaDePedidos { get => listaDePedidos; set => listaDePedidos = value; }

        public Empresa()
        {
            listadoDeCadetes = new List<Cadete>();
            listaDePedidos = new List<Pedidos>();            
        }
        public Empresa(string nombre, string telefono)
        {
            nombreEmpresa = nombre;
            telefonoEmpresa = telefono;
            listadoDeCadetes = new List<Cadete>();
            listaDePedidos = new List<Pedidos>();
        }

        public void contratarCadete(Cadete c)
        {
            listadoDeCadetes.Add(c);
        }

        public void despedirCadete(Cadete c)
        {
            listadoDeCadetes.Remove(c);
        }

        public void agregarPedido(Pedidos p)
        {
            listaDePedidos.Add(p);
        }

        public List<Cadete> mostrarCadetes()
        {
            List<Cadete> cadetesActuales = new List<Cadete>();
            foreach (var c in listadoDeCadetes)
            {
                cadetesActuales.Add(c);
            }

            return cadetesActuales;
        }

        
        public void reasignarPedido(Pedidos p, int idCadete1)
        {
            var cadete = listadoDeCadetes.FirstOrDefault(c => c.Id == idCadete1);
            if (cadete != null)
            {
                p.Cadete = cadete;
            }
        }

        public void informeEmpresa()
        {
            var pedidosEntregados = ListaDePedidos.Where(p => p.Estado == Estado.entregado);
            Console.WriteLine("La cadeteria Cobra 700$ por cada pedido entregado");
            Console.WriteLine("500 para cada cadete, 200 para la cadeteria");
            int entregados = pedidosEntregados.Count();
            float total = entregados * 200;

            Console.WriteLine("Ganancias totales empresa: " + total);

            float promedio = 0;
            int count;
            foreach (var c in ListadoDeCadetes)
            {
                var entrega = ListaDePedidos.Where(k => k.Cadete.Id == c.Id);
                count = entrega.Count();
                Console.WriteLine("Cadete: " + c.Nombre + ", Total a cobrar: " + count * 500);
                promedio += count;
                count = 0;
            }
            
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Promedio de pedidos entregados por cadete: " + (promedio / 4));
        }

        public float jornalACobrar(int id)
        {
            var cad = listadoDeCadetes.FirstOrDefault(c => c.Id == id);
            if (cad != null)
            {
                var entregados = listaDePedidos.Where(p => p.Cadete.Id == cad.Id && p.Estado == Estado.entregado);
                int cant = entregados.Count();

                Console.WriteLine("Total a cobrar: " + cant * 500);
                return (cant * 500);
            }
            else
            {
                return 0;
            }
        }

        public void asignarPedido(int idCadete, int idPedido)
        {
            var cadete = listadoDeCadetes.FirstOrDefault(c => c.Id == idCadete);
            var pedido = listaDePedidos.FirstOrDefault(p => p.Nro == idPedido);

            if (cadete == null || pedido == null)
            {
                
            }
            else
            {
                pedido.Cadete = cadete;
            }
        }
    }
}