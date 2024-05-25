using CsharpTestes;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            MenuDeProducao();
        }

        public static void MenuDeProducao()
        {   
            Console.Clear();

            Console.WriteLine("");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Bem vindo ao nosso sistema!");
            Console.WriteLine("Temos vários códigos prontos.");
            
            Console.WriteLine("");

            Console.WriteLine("Escolha uma das opções abaixo: ");
            Console.WriteLine("0 - Sair.");
            Console.WriteLine("1 - Menu de testes.");
            Console.WriteLine("2 - Soma de dois números.");
            Console.WriteLine("3 - Média de um conjunto de números.");
            Console.WriteLine("4 - Verifica número primo.");
            Console.WriteLine("5 - Conversão Celcius para Fahrenheit.");
            Console.WriteLine("6 - Inversão de string.");
            Console.WriteLine("7 - Calculadora simples.");
            Console.WriteLine("8 - Validador de CPF.");
            Console.WriteLine("9 - Contador de palavras.");
            Console.WriteLine("10 - Soma dos digítos de um número.");
            Console.WriteLine("11 - Ordernação de array.");
            Console.WriteLine("----------------------------------------");

            Console.WriteLine("");

            var opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    Sair();
                    break;
                
                case 1:
                    MenuDeTestes();
                    break;

                case 2:
                    Soma.MetodoSoma();
                    break;

                case 3:
                    Media.MetodoMedia();
                    break;

                case 4:
                    Primo.PrimoMetodo();
                    break;

                case 5:
                    Temperatura.MetodoTemperatura();
                    break;

                case 6:
                    StringReversa.MetodoMain();
                    break;

                case 7:
                    Calculadora.MetodoMain();
                    break;

                case 8:
                    ValidaCPF.MetodoCPFMain();
                    break;
                
                case 9:
                    ContaPalavras.ContaPalavrasMain();
                    break;

                case 10:
                    SomaDigitos.SomaDigitosMain();
                    break;

                case 11:
                    OrdenaArray.OrdenaArrayMain();
                    break;
            }
        }

        public static void MenuDeTestes()
        {
            Console.Clear();

            Console.WriteLine("");

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Este é o menu de teste!");
            Console.WriteLine("Aqui temos diversos códigos para você testar.");
            
            Console.WriteLine("");

            Console.WriteLine("Escolha uma das opções abaixo: ");
            Console.WriteLine("0 - Sair.");
            Console.WriteLine("1 - Menu de produção.");
            Console.WriteLine("2 - Listas.");

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("");

            var opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    Sair();
                    break;
                
                case 1:
                    MenuDeProducao();
                    break;

                case 2:
                    Listas.ListaMain();
                    break;
            }
        }

        public static void Sair()
        {
            Console.Clear();
            Console.WriteLine("Programa finalizado.");
            Console.WriteLine("");
            Environment.Exit(0);
        }
    }
}