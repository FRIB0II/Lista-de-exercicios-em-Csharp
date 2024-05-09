using System.ComponentModel.Design;

namespace Csharp
{
    class Soma
    {
        public static void MetodoSoma()
        {
            Console.Clear();
            Console.Write("Digite um número qualquer: ");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.Write("Digite um outro número qualquer: ");
           int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            var soma = num + num2;
            Console.WriteLine($"A soma desses números é: {soma}");
            Console.ReadKey();
            
            Program.Menu();
        }
    }
}