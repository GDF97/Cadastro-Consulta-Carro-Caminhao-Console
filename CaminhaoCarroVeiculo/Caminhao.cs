using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminhaoCarroVeiculo
{
    class Caminhao : Veiculo
    {
        private int numero_eixos;
        private double carga_max;
        private bool caixaCambio;
        private string tipoCarga;
        private string tipoCarroceria;

        public Caminhao()
            : base()
        {
            numero_eixos = 0;
            carga_max = 0;
            caixaCambio = false;
            tipoCarga = null;
            tipoCarroceria = null;
        }

        public Caminhao(string modelo, string fabricante, int ano, string cor, int numero_portas, string placa, int numero_eixos, double carga_max, bool caixaCambio, string tipoCarga, string tipoCarroceria)
            :base(modelo, fabricante, ano, cor, numero_portas, placa)
        {
            this.numero_eixos = numero_eixos;
            this.carga_max = carga_max;
            this.caixaCambio = caixaCambio;
            this.tipoCarga = tipoCarga;
            this.tipoCarroceria = tipoCarroceria;
        }

        public int Numero_eixos
        {
            get { return numero_eixos; }
            set { numero_eixos = value; }
        }

        public double Carga_max
        {
            get { return carga_max; }
            set { carga_max = value; }
        }

        public bool CaixaCambio
        {
            get { return caixaCambio; }
            set { caixaCambio = value; }
        }

        public string TipoCarga
        {
            get { return tipoCarga; }
            set { tipoCarga = value; }
        }

        public string TipoCarroceria
        {
            get { return tipoCarroceria;}
            set { tipoCarroceria = value; }
        }

        public override string ToString()
        {
            return (String.Format("{0}\n Numero de Eixos: {1}\n Carga Máxima(kg): {2}\n Tem duas caixas de marcha?: {3}\n" +
                " Tipo da Carga: {4}\n Tipo da Carroceria: {5}\n", base.ToString(), numero_eixos, carga_max, CaixaCambioString(caixaCambio), tipoCarga, tipoCarroceria));
        }

        public string CaixaCambioString(bool CaixaCambio)
        {
            if(CaixaCambio == true)
            {
                return "Sim";
            }
            else
            {
                return "Não";
            }
        }
    }
}
