using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminhaoCarroVeiculo
{
    abstract class Veiculo
    {
        private string modelo;
        private string fabricante;
        private int ano;
        private string cor;
        private int numero_portas;
        private string placa;

        public Veiculo()
        {
            modelo = null;
            fabricante = null;
            ano = 0;
            cor = null;
            numero_portas = 0;
            placa = null;
        }

        public Veiculo(string modelo, string fabricante, int ano, string cor, int numero_portas, string placa)
        {
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.ano = ano;
            this.cor = cor;
            this.numero_portas = numero_portas;
            this.placa = placa;
        }

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public string Fabricante
        {
            get { return fabricante; }
            set { fabricante = value; }
        }

        public int Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public int NumeroPortas
        {
            get { return numero_portas; }
            set { numero_portas = value; }
        }

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public override string ToString()
        {
            return (String.Format(" Modelo: {0}\n Fabricante: {1}\n Ano: {2}\n Cor: {3}\n Numero de Portas: {4}\n Placa: {5}", modelo,fabricante,ano,cor,numero_portas,placa));
        }
    }

}
