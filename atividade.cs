namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] time = new string[5];
            int[] pontos = new int[5];

            for(int l = 0; l < 5; l++)
            {
                Console.WriteLine("Escreva o nome do {0}° Time", l + 1);
                time[l] = Console.ReadLine();
            }
            for(int c = 0; c < 5; c++)
            {
                Console.WriteLine("Digite a pontuação do time {0}", time[c]);
                pontos[c] = int.Parse(Console.ReadLine());
            }
        }
    }
}
