namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }

        public static void Menu()
        {   
            Console.Clear();

            Console.WriteLine("Bem vindo ao nosso sistema!");
            Console.WriteLine("Temos diversos códigos para você testar.");
            
            Console.WriteLine("");

            Console.WriteLine("Escolha uma das opções abaixo: ");
            Console.WriteLine("0 - Sair.");
            Console.WriteLine("1 - Soma de dois números.");
            Console.WriteLine("2 - Média de um conjunto de números.");
            Console.WriteLine("3 - Verifica número primo.");
            Console.WriteLine("4 - Conversão Celcius para Fahrenheit.");
            Console.WriteLine("5 - Inversão de string.");
            Console.WriteLine("6 - Calculadora simples.");
            Console.WriteLine("7 - Validador de CPF.");

            Console.WriteLine("----------------------------------------");

            Console.WriteLine("");

            var opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 0:
                    Sair();
                    break;

                case 1:
                    Soma.MetodoSoma();
                    break;

                case 2:
                    Media.MetodoMedia();
                    break;

                case 3:
                    Primo.PrimoMetodo();
                    break;

                case 4:
                    Temperatura.MetodoTemperatura();
                    break;

                case 5:
                    StringReversa.MetodoMain();
                    break;

                case 6:
                    Calculadora.MetodoMain();
                    break;

                case 7:
                    ValidaCPF.MetodoCPFMain();
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