namespace Lista01Exercício08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando o volume de uma lata de oleo");

            Console.WriteLine();

            Console.Write("Digite a altura da lata de oleo: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o raio da lata de oleo: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double volume = raio * raio * Math.PI * altura;
            Console.WriteLine("O volume da lata de oleo é: " + volume);

            Console.ReadLine();
        }
    }
}