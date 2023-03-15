namespace Lista01Exercício03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando o volume de um cilindro");

            Console.WriteLine();

            Console.Write("Digite a altura do cilindro: ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o raio do cilindro: ");
            double raio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            double volume = raio * raio * Math.PI * altura;
            Console.WriteLine("O volume do cilindro é: " + volume);

            Console.ReadLine(); 
        }
    }
}