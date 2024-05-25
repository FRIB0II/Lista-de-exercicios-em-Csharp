namespace Csharp
{
    class OrdenaArray
    {
        public static void OrdenaArrayMain()
        {
            Console.Clear();
            Console.WriteLine("");

            Console.Write("Informe o tamanho do array: ");
            int tamanho = int.Parse(Console.ReadLine());
            
            Console.WriteLine("");

            float[] arrayDeNumeros = new float[tamanho];

            float numArray;

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Digite o número do array: ");
                numArray = float.Parse(Console.ReadLine());
                arrayDeNumeros[i] = numArray;
            }

            Array.Sort(arrayDeNumeros);

            Console.WriteLine("");

            Console.WriteLine("Seu array ficou da seguinte forma: ");

            Console.WriteLine("");

            foreach (float numero in arrayDeNumeros)
            {
                Console.WriteLine(numero);    
            }

            Console.ReadKey();
            Program.MenuDeProducao();
        }
    }
}