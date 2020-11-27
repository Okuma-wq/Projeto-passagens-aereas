using System;

namespace Projeto_Passagens_aereas
{
    class Program
    {
        static void Main(string[] args)
        {
            bool senhaValida;
            int escolha;
            int contador = 0;
            int bloqueio = 0;
            string resposta;
            string[] nomes = new string[5];
            string[] destino = new string [5];
            string[] origem = new string[5];
            string[] data = new string [5];

            Console.Clear();
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("----Sistema de passagens aéreas----");
            Console.WriteLine("-----------------------------------");
            
            
            do
            {
               Console.WriteLine("Digite a senha para acessar o sistema");
               string senha = Console.ReadLine();
               senhaValida = EfetuarLogin(senha);
               
            } while (!senhaValida);

            Console.Clear();

            do
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Menu principal");
                Console.ResetColor();
                Console.WriteLine("Selecione uma opção abaixo");
                Console.WriteLine("[1] - Cadastrar Passagem");
                Console.WriteLine("[2] - Listar Passagens");
                Console.WriteLine("[0] - Sair");
                escolha = int.Parse(Console.ReadLine());

                Console.Clear();

                switch (escolha)
                {
                    case 1:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Cadastro de passagens");
                        Console.ResetColor();
                        do
                        {
                            if(contador < 5 ){
                            Console.WriteLine($"Digite o nome do {contador+1}º passageiro");
                            nomes[contador] = Console.ReadLine();

                            Console.WriteLine("Digite o destino do voo");
                            destino[contador] = Console.ReadLine();

                            Console.WriteLine("Digite a origem do voo");
                            origem[contador] = Console.ReadLine();

                            Console.WriteLine("Digite a data do voo");
                            data[contador] = Console.ReadLine();
                            contador++;
                            }else{
                                Console.WriteLine("Limite excedido!");
                                break;
                            }
                            Console.WriteLine("Você gostaria de cadastrar outro passageiro? S/N");
                            resposta = Console.ReadLine();
                           }while (resposta.ToUpper() == "S");
                           Console.Clear();
                        break;

                    case 2:
                        Console.WriteLine("--------------------");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Listar passagens");
                        Console.ResetColor();
                        for (var i = 0; i < contador; i++)
                        {
                            
                            Console.Write("Passageiro: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(nomes[i]);
                            Console.ResetColor();
                            Console.Write(" -- Destino: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(destino[i]);
                            Console.ResetColor();
                            Console.Write(" -- Origem: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(origem[i]);
                            Console.ResetColor();
                            Console.Write(" -- Data do voo: ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(data[i]);
                            Console.ResetColor();
                            Console.WriteLine(" --");
                        }
                        Console.WriteLine("--------------------");

                        break;

                    case 0:
                        Console.WriteLine("----------------------------");
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Obrigado por viajar conosco!");
                        Console.ResetColor();
                        Console.WriteLine("----------------------------");
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
                
            } while (escolha != 0);
            
            bool EfetuarLogin(string senha){
               if (senha == "123456"){
                   return true;
               }else{
                   Console.WriteLine("Senha inválida, digite de novo!");
                   bloqueio++;
                   Console.WriteLine(bloqueio);
                   if(bloqueio == 3){
                        Console.WriteLine("Número máximo de tentativas excedido");
                        Environment.Exit(-1);
                   }
                   return false;
               }

            }
        }
    }
}
