namespace Lista01Exercício12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a área de terrenos retângulares");

            Console.WriteLine();

            Console.Write("Digite a primeira dimensão do terreno (em metros): ");
            double dimensao1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a segunda dimensão do terreno (em metros): ");
            double dimensao2 = Convert.ToInt32(Console.ReadLine());
            
            double area = dimensao1 * dimensao2;

            Console.WriteLine("A area do terreno é de " + area + "m²");
            
        }
    }
}