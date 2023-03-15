namespace Lista01Exercício15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertendo graus Celsius em graus Fahrenheit");

            Console.WriteLine();

            Console.Write("Digite a temperatura e graus Celsius: ");
            double celsius = Convert.ToDouble(Console.ReadLine());

            double fahrenheit = celsius * 1.8 + 32;
            Console.WriteLine("A conversão para graus Fahrenheit é: " + fahrenheit);

            Console.ReadLine();
        }
    }
}