using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminhaoCarroVeiculo
{
     class Carro : Veiculo
    {
        private int capacidadePortaMala;
        private bool bagageiro;
        private string tipoTracao;

        public Carro()
            :base()
        {
            capacidadePortaMala= 0;
            bagageiro= false;
            tipoTracao = null;
        }

        public Carro(string modelo, string fabricante, int ano, string cor, int numero_portas, string placa,int capacidadePortaMala, bool bagageiro, string tipoTracao)
            :base(modelo, fabricante, ano, cor, numero_portas, placa)
        {
            this.capacidadePortaMala = capacidadePortaMala;
            this.bagageiro = bagageiro;
            this.tipoTracao = tipoTracao;
        }

        public int CapacidadePortaMala
        {
            get { return capacidadePortaMala; }
            set { capacidadePortaMala = value; }
        }

        public bool Bagageiro
        {
            get { return bagageiro; }
            set { bagageiro = value; }
        }

        public string TipoTracao
        {
            get { return tipoTracao; }
            set { tipoTracao = value; }
        }

        public override string ToString()
        {
            return (String.Format("{0}\n Capacidade do Porta Malas(Litros): {1}\n Bagageiro: {2}\n " +
                "Tipo de tração: {3}\n", base.ToString(), capacidadePortaMala, BagageiroString(bagageiro), tipoTracao));
        }

        public string BagageiroString(bool bagageiro)
        {
            if(bagageiro == true)
            {
                return "Tem Bagageiro";
            }
            else
            {
                return "Não tem Bagageiro";
            }
        }
    }
}
