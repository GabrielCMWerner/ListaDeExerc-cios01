namespace Lista01Exercício02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Convertendo graus Fahrenheit em graus celsius");

            Console.WriteLine();

            Console.WriteLine("Digite a temperatura e graus Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = fahrenheit - 32 / 1.8;
            Console.WriteLine("A conversão para graus Celsius é: " + celsius);

            Console.ReadLine();
        }
    }
}