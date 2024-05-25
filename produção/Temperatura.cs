namespace Csharp
{
    class Temperatura
    {
        public static void MetodoTemperatura()
        {
            Console.Clear();

            Console.Write("Insira a temperatura em Celsius: ");
            float temperaturaEmCelcius = float.Parse(Console.ReadLine());

            float temperaturaEmFahrenheit = (temperaturaEmCelcius * 1.8f) + 32;

            Console.Write($"A temperatura em Fahrenheit é: {temperaturaEmFahrenheit}" + "°");
            
            Console.ReadKey();
            Program.MenuDeProducao();
        }
    }

}