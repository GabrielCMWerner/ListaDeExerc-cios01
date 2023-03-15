namespace Lista01Exercício05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando o volume de uma esfera");

            Console.WriteLine();

            Console.Write("Digite o valor do raio: ");
            double raio = Convert.ToDouble(Console.ReadLine()); 
            double raio3 = raio * raio * raio;

            double volume = 4 / 3 * Math.PI * raio3;
            Console.WriteLine("O volume da esfera é: " + volume);

            Console.ReadLine();
        }
    }
}