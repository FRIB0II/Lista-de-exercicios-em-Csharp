using Csharp;

namespace CsharpTestes
{
    class Listas
    {
        public static void ListaMain()
        {
            Console.Clear();

            List<string> listaDeNomes = new();

            Console.Write("Insira a quantidade de nomes que você deseja inserir na lista: ");
            int quantidadeDeNomes = int.Parse(Console.ReadLine());

            for(int i = 0; i < quantidadeDeNomes; i++)
            {
                Console.Write("Escreva um nome: ");
                string nomeDeEntrada = Console.ReadLine();
                listaDeNomes.Add(nomeDeEntrada);
            }

            Console.WriteLine("");

            Console.WriteLine("Sua lista ficou desta forma: ");
            Console.WriteLine("-------------------------");

            foreach(string nome in listaDeNomes)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("-------------------------");
            Console.ReadKey();
            Program.MenuDeProducao();
        }
    }
}