namespace Lista01Exercício21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Condicional com valores inteiros");

            Console.WriteLine();

            Console.Write("Digite o primeiro valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());
            int resultado;

            if (valor1 != valor2)
            {
                resultado = valor1 * valor2;
                Console.WriteLine("O resultado da multiplicação é: " + resultado);
            }

            else
            {
                resultado = valor1 + valor2;
                Console.WriteLine("O resultado da soma é: " + resultado);

            }
        }
    }
}