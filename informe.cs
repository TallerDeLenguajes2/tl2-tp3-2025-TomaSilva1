namespace InformeEmpresa
{
    public class Informe
    {
        private int totalPedidosEntregados;
        private float totalEmpresa;
        private List<CadeteInfo> totales;
        private float promedio;

        public Informe()
        {

        }

        public Informe(int totalPedidosEntregados, float totalEmpresa, List<CadeteInfo> totales, float promedio)
        {
            this.TotalPedidosEntregados = totalPedidosEntregados;
            this.TotalEmpresa = totalEmpresa;
            this.Totales = totales;
            this.Promedio = promedio;
        }

        public int TotalPedidosEntregados { get => totalPedidosEntregados; set => totalPedidosEntregados = value; }
        public float TotalEmpresa { get => totalEmpresa; set => totalEmpresa = value; }
        public List<CadeteInfo> Totales { get => totales; set => totales = value; }
        public float Promedio { get => promedio; set => promedio = value; }
    }

    public class CadeteInfo
    {
        private int id;
        private string nombre;
        private int entregados;
        private decimal cobro;
        
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Entregados { get => entregados; set => entregados = value; }
        public decimal Cobro { get => cobro; set => cobro = value; }

        public CadeteInfo()
        {

        }

        public CadeteInfo(int id, int entregados)
        {
            this.Id = id;
            this.Entregados = entregados;
            this.Cobro = entregados*500;

        }

    }
}