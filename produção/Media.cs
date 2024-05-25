namespace Csharp
{
    class Media
    {
        public static void MetodoMedia()
        {
            Console.Clear();

            Console.Write("Digite a quantidade de números a ser calculada: ");
            int quantidadeDeNumeros = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            float somaParaMedia = 0;
            float numeroParaMedia;

            for (int contador = 0; contador < quantidadeDeNumeros; contador++)
            {
                Console.Write("Digite o número: ");
                numeroParaMedia = float.Parse(Console.ReadLine());

                somaParaMedia += numeroParaMedia;  
            }

            float media = somaParaMedia / quantidadeDeNumeros;

            Console.WriteLine("");
        
            Console.WriteLine($"A média é: {media}");
            Console.ReadKey();

            Program.MenuDeProducao();
        }
    }
}