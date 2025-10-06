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

        public void cambiarEstado(int opc)
        {
            if (opc == 1)
            {
                this.estado = Estado.asignado;
            }else if (opc == 2)
            {
                this.estado = Estado.enCamino;
            }else if (opc == 3)
            {
                this.estado = Estado.entregado;
            }else if (opc == 4)
            {
                this.estado = Estado.cancelado;
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