namespace Csharp
{
    class SomaDigitos
    {
        public static void SomaDigitosMain()
        {
            Console.Clear();

            Console.Write("Insira um dígito para calcular a soma de seus dígitos: ");
            string numeroEntrada = Console.ReadLine();

            Console.WriteLine("");

            int resultado = SomaDigitosMetodo(numeroEntrada);

            Console.Write($"A soma dos dígitos é: {resultado}.");
            Console.WriteLine("");
            Console.ReadKey();
            Program.Menu();
        }

        public static int SomaDigitosMetodo(string num)
        {
            int soma = 0;

            foreach (char digito in num)
            {
                if (char.IsDigit(digito))
                {
                    soma += digito - '0';
                }
            }

            return soma;
        }
    }
}