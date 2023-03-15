namespace Lista01Exercício17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificando valores");

            Console.WriteLine();

            Console.Write("Digite o primeiro valor: ");
            double valor1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            double valor2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            double valor3 = Convert.ToDouble(Console.ReadLine());

            if (valor1 + valor2 > valor3)
            {
                Console.WriteLine("A soma dos dois primeiro valores é maior que o terceiro valor");
            }

            else
            {
                Console.WriteLine("A soma dos dois primeiro valores NÂO é maior que o terceiro valor");

            }
        }
    }
}