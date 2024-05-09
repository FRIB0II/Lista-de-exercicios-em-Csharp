namespace Csharp
{
    class StringReversa
    {   

        public static void MetodoMain()
        {
            Console.Clear();

            Console.Write("Insira seu texto para inverte-lo: ");
            string texto = Console.ReadLine();

            string textoReverso = MetodoReverso(texto);
            Console.WriteLine($"O texto invertido fica assim: {textoReverso}");

            Console.ReadKey();
            Program.Menu();
        }

        public static string MetodoReverso(string texto)
        {
            char[] arrayDeCaracteres = texto.ToCharArray();
            Array.Reverse(arrayDeCaracteres);
            return new string(arrayDeCaracteres);
        }
    }
}