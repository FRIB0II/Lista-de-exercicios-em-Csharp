namespace Csharp
{
    class ContaPalavras
    {
        public static void ContaPalavrasMain()
        {
            Console.Clear();

            Console.Write("Insira uma frase: ");
            string frase = Console.ReadLine();
            
            string resultado = MetodoContador(frase);

            Console.Write($"O número de palavras na frase é: {resultado}");
            
            Console.WriteLine("");

            Console.ReadKey();
            Program.MenuDeProducao();
        }

        public static string MetodoContador(string frase)
        {
            string[] arrayDePalavras = frase.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int quantidadeDePalavras = 0;


            foreach(string palavra in arrayDePalavras)
            {
                quantidadeDePalavras++;
            }

            return Convert.ToString(quantidadeDePalavras);
        }
    }
}