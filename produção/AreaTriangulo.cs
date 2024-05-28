namespace Csharp
{
    class AreaTriangulo
    {
        public static void AreaTrianguloMain()
        {
            Console.Clear();
            Console.WriteLine("");

            Console.WriteLine("Insira o tipo de triângulo que deseja calcular.");
            Console.WriteLine("Equilátero => eq");
            Console.WriteLine("Isóceles => is");
            Console.WriteLine("Escaleno => es");

            Console.WriteLine("");

            string tipoDeTriangulo = Console.ReadLine();
            
            if (tipoDeTriangulo == "eq")
            {   
                Console.Clear();
                Console.Write("Insira o valor dado: ");
                double valorEquilatero = double.Parse(Console.ReadLine());

                Console.WriteLine("");

                var resultado = TrinaguloEquilatero((float)valorEquilatero);
                Console.Write($"O valor da área do triângulo é: {resultado}.");

                Console.WriteLine("");
                Console.ReadKey();
                Program.MenuDeProducao();
            }
        }

        public static float TrinaguloEquilatero(float valor)
        {
            double area = Math.Round(valor * valor * Math.Sqrt(3) / 4);
            return  (float)area; 
        }

        // public static float TrianguloIsoceles(float)
        // {

        // }

        // public static float TrianguloEscaleno(float)
        // {

        // }
    }
}