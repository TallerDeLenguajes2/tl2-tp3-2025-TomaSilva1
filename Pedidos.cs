using Clientes;
using Cadetes;

namespace Pedido
{
    public class Pedidos
    {
        private int nro;
        private string obs;
        private Cliente cliente;
        private Estado estado;
        private Cadete cadete;


        public int Nro { get => nro; }
        public string Obs { get => obs; set => obs = value; }
        public Cliente Cliente { get => cliente; }
        public Estado Estado { get => estado; set => estado = value; }
        public Cadete Cadete { get => cadete; set => cadete = value; }

        public Pedidos(int nro, string obs, Cliente cliente)
        {
            this.nro = nro;
            this.obs = obs;
            this.cliente = cliente;
            estado = Estado.asignado;
        }

        public void cambiarEstado(Estado nuevoEstado)
        {
            estado = nuevoEstado;   
        }

        public void mostrarPedidos(){
            if(estado == Estado.pendiente){
                Console.WriteLine($"nro: {nro}, desc: {obs}");
            }
        }
    }

}

public enum Estado
{
    pendiente = 0,
    asignado = 1,
    enCamino = 2,
    entregado = 3,
    cancelado = 4
}