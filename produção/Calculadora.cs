namespace Csharp
{
    class Calculadora
    {
        public static void MetodoMain()
        {
            Console.Clear();
            
            Console.Write("Digite um número: ");
            decimal num1 = decimal.Parse(Console.ReadLine());

            Console.Write("Qual a operação? ");
            char operacao = char.Parse(Console.ReadLine());

            Console.Write("Digite outro número: ");
            decimal num2 = decimal.Parse(Console.ReadLine());

            decimal resultado;

            switch(operacao)
            {
                case '+':
                    resultado = MetodoSoma(num1, num2);
                    Console.Write($"O resultado de sua operação é: {resultado}");
                    Console.ReadKey();
                    Program.MenuDeProducao();
                    break;

                case '-':
                    resultado = MetodoSubtracao(num1, num2);
                    Console.Write($"O resultado de sua operação é: {resultado}");
                    Console.ReadKey();
                    Program.MenuDeProducao();
                    break;

                case '*':
                    resultado = MetodoMultiplicacao(num1, num2);
                    Console.Write($"O resultado de sua operação é: {resultado}");
                    Console.ReadKey();
                    Program.MenuDeProducao();
                    break;

                case '/':
                    resultado = MetodoDivisao(num1, num2);
                    Console.Write($"O resultado de sua operação é: {resultado}");
                    Console.ReadKey();
                    Program.MenuDeProducao();
                    break;
                    
                default:
                    Console.WriteLine("Erro. Operação inválida. Tente novamente.");
                    Console.ReadKey();
                    MetodoMain();
                    break;

            }
        }

        public static decimal MetodoSoma(decimal parametro1, decimal parametro2)
        {
            decimal resultado = parametro1 + parametro2;
            return resultado;
        }

        public static decimal MetodoSubtracao(decimal parametro1, decimal parametro2)
        {
            decimal resultado = parametro1 - parametro2;
            return resultado;
        }

        public static decimal MetodoMultiplicacao(decimal parametro1, decimal parametro2)
        {
            decimal resultado = parametro1 * parametro2;
            return resultado;
        }

        public static decimal MetodoDivisao(decimal parametro1, decimal parametro2)
        {
            decimal resultado = parametro1 / parametro2;
            return resultado;
        }
    }
}