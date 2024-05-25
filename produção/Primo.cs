namespace Csharp
{
    class Primo
    {
        public static void PrimoMetodo()
        {
            Console.Clear();

            Console.Write("Insira um número para verificação (inteiro): ");
            long numero = long.Parse(Console.ReadLine());

            int quantidadeDivisores = 0;

            for (long contador = 1; contador <= Math.Sqrt(numero); contador++)
            {
                if (numero % contador == 0)
                {
                    quantidadeDivisores++;
                }
            }

            if (quantidadeDivisores == 2)
                Console.WriteLine("É primo.");
            else
                Console.WriteLine("Não é primo.");

            Console.ReadKey();
            Program.MenuDeProducao();
        }
    }
}