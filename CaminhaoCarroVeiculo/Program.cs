using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaminhaoCarroVeiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            int carVar = 0;
            int camVar = 0;
            
            const int TAMcarro = 300;
            const int TAMcaminhao = 200;
            
            Carro[] Car = new Carro[TAMcarro];
            Caminhao[] Cam = new Caminhao[TAMcaminhao];

            do
            {
                Console.Clear();
                 opc = MenuOpc();
                switch (opc)
                {
                    case 1:
                        if(carVar < TAMcarro)
                        {
                            Car[carVar++] = CadastrarCarro();
                        }
                        else
                        {
                            Console.WriteLine("Não há mais espaço no banco de dados");
                        }
                        break;
                    case 2:
                        if(camVar < TAMcaminhao)
                        {
                            Cam[camVar++] = CadastrarCaminhao();
                        }
                        else
                        {
                            Console.WriteLine("Não há mais espaço no banco de dados");
                        }
                        break;
                    case 3:
                        ConsultarPlaca(Cam, Car, carVar, camVar);
                        break;
                    case 4:
                        ConsultaMarcaModelo(Cam, camVar);
                        break;
                    case 5:
                        ConsultaCorCarro(Car, carVar);
                        break;
                    case 6:
                        ExibirCarro(Car, carVar);
                        break;
                    case 7:
                        ExibirCaminhao(Cam, camVar);
                        break;
                    case 0:
                        break;
                }
            } while (opc != 0);
            Console.Clear();
            Console.WriteLine("Fechando Programa...");
            Console.WriteLine("Aperte Qualquer tecla para encerrar...");
            Console.ReadKey();
        }

        static int MenuOpc()
        {
            Console.WriteLine("Escolha uma opção\n1-Cadastro de Carro\n2-Cadastro de Caminhão" +
                "\n3-Consulta por placa\n4-Consulta Caminhão por modelo/marca\n5-Consultar Carro por cor" +
                "\n6-Exibir todos os Carros cadastrados\n7-Exibr todos os Caminhões cadastrados\n0-Sair");
            return int.Parse(Console.ReadLine());  
        }

        static Carro CadastrarCarro()
        {
            Console.Clear();
            Console.WriteLine("\n*********Cadastrando Carro*********\n");

            Console.Write("Digite o Modelo do carro: "); 
            string md = Console.ReadLine();
            
            Console.Write("Digite o Fabricante do carro: ");
            string fb = Console.ReadLine();

            Console.Write("Digite o Ano do carro: ");
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Digite a Cor do carro: ");
            string cor = Console.ReadLine();

            Console.Write("Digite a quantidade do Numero de Portas: ");
            int num_Portas = int.Parse(Console.ReadLine());

            Console.Write("Digite a Placa do carro: ");
            string placa = Console.ReadLine();

            Console.Write("Digite a Capacidade do Porta-Malas(litros): ");
            int capPortaMalas = int.Parse(Console.ReadLine());

            Console.Write("Tem bageiro? (S/N): ");
            string bg = Console.ReadLine().ToLower();
            bool bagageiro = bg == "s" ? true : false;

            Console.Write("Digite a Tração do seu carro: ");
            string trac = Console.ReadLine();

            Console.WriteLine("*********Carro Cadastrado*********");
            Console.WriteLine("Aperte Enter para continuar...");
            Console.ReadKey();
            return new Carro(md, fb, ano, cor, num_Portas, placa, capPortaMalas, bagageiro, trac);
        }

        static Caminhao CadastrarCaminhao()
        {
            Console.Clear();
            Console.WriteLine("\n*********Cadastrando Caminhãop*********\n");

            Console.Write("Digite o Modelo do Caminhão: "); 
            string md = Console.ReadLine();

            Console.Write("Digite o Fabricante do Caminhão: "); 
            string fb = Console.ReadLine();

            Console.Write("Digite o Ano do Caminhão: "); 
            int ano = int.Parse(Console.ReadLine());

            Console.Write("Digite a Cor do Caminhão: "); 
            string cor = Console.ReadLine();

            Console.Write("Digite a quantidade do Numero de Portas: ");
            int num_Portas = int.Parse(Console.ReadLine());

            Console.Write("Digite a Placa do Caminhão: "); 
            string placa = Console.ReadLine();

            Console.Write("Quantidade de eixos: ");
            int eixo = int.Parse(Console.ReadLine());

            Console.Write("Digite a Carga Maxima(kg): ");
            double carga_Max = double.Parse(Console.ReadLine());

            Console.Write("Há mais de uma caixa de marcha?(S/N): "); 
            string caixa = Console.ReadLine().ToLower();
            bool caixaCamb = caixa == "s" ? true : false;

            Console.Write("Digite o Tipo de Carga: ");
            string tipoCarga = Console.ReadLine();

            Console.Write("Digite o Tipo da Carroceria: ");
            string tipoCarroca = Console.ReadLine();

            Console.WriteLine("*********Caminhão Cadastrado*********");
            Console.WriteLine("Aperte Enter para continuar...");
            Console.ReadKey();
            return new Caminhao(md, fb, ano, cor, num_Portas, placa, eixo, carga_Max, caixaCamb, tipoCarga, tipoCarroca);
        }

        static void ConsultarPlaca(Caminhao[] Cam, Carro[] Car, int carVar, int camVar)
        {
            Console.Clear();
            Console.Write("Digite a placa do veiculo no qual está procurando: ");
            string placaUser = Console.ReadLine();

            int verificador = 0;

            for(int j = 0; j < carVar; j++)
            {
                if(placaUser.ToLower() == Car[j].Placa.ToLower())
                {
                    Console.WriteLine(Car[j].ToString());
                    verificador++;
                }
                else
                {
                    Console.WriteLine();
                }
            }
            for(int j = 0; j < camVar; j++)
            {
                if(placaUser.ToLower() == Cam[j].Placa.ToLower())
                {
                    verificador++;
                    Console.WriteLine(Cam[j].ToString());
                }
                else
                {
                    Console.WriteLine();
                }
            }

            if(verificador == 0)
            {
                Console.WriteLine("Não há veiculo cadastrado com essa placa");
                Console.WriteLine("Aperte Enter para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Aperte Enter para continuar...");
                Console.ReadKey();
            }

        }

        static void ConsultaMarcaModelo(Caminhao[] Cam, int camVar )
        {
            Console.Clear();
            Console.Write("Digite o Modelo/Marca do Caminhão: ");
            string modmarca = Console.ReadLine();

            int verificador = 0;
            for(int j = 0; j < camVar; j++)
            {
                if(modmarca.ToLower() == Cam[j].Modelo.ToLower())
                {
                    Console.WriteLine(Cam[j].ToString());
                    verificador++;
                }
                else
                {
                    Console.WriteLine();
                }
            }

            if (verificador == 0)
            {
                Console.WriteLine("Não há caminhoes cadastrados desta marca");
                Console.WriteLine("Aperte Enter para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Aperte Enter para continuar...");
                Console.ReadKey();
            }
          }

        static void ConsultaCorCarro(Carro[] Car, int carVar)
        {
            Console.Clear();
            Console.Write("Digite a cor do carro: ");
            string corUser = Console.ReadLine();

            int verificador = 0;

            for(int j = 0; j < carVar; j++)
            {
                if(corUser.ToLower() == Car[j].Cor.ToLower())
                {
                    verificador++;
                    Console.WriteLine(Car[j].ToString());
                }
                else
                {
                    Console.WriteLine();
                }
            }
            if (verificador == 0)
            {
                Console.WriteLine("Não há carros cadastrados desta cor");
                Console.WriteLine("Aperte Enter para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Aperte Enter para continuar...");
                Console.ReadKey();
            }
        }

        static void ExibirCarro(Carro[] Car, int carVar)
        {
            Console.Clear();
            if(carVar == 0)
            {
                Console.WriteLine("Não há Carros cadastrados!!");
                Console.WriteLine("Aperte Enter para continuar...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("********Exibindo-Carros-Cadastrados********");
                for(int j = 0; j < carVar; j++)
                {
                    Console.WriteLine(Car[j].ToString());
                }
                Console.WriteLine("Aperte Enter para continuar...");
                Console.ReadKey();
            }

        }
        static void ExibirCaminhao(Caminhao[] Cam, int camVar)
        {
            Console.Clear();
            if(camVar == 0)
            {
                Console.WriteLine("Não há Caminhões cadastrados!!");
                Console.WriteLine("Aperte Enter para continuar...");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine("********Exibindo-Caminhões-Cadastrados********");
                for (int j = 0; j < camVar; j++)
                {
                    Console.WriteLine(Cam[j].ToString());
                }
                Console.WriteLine("Aperte Enter para continuar...");
                Console.ReadKey();
            }

        }
    }
}
