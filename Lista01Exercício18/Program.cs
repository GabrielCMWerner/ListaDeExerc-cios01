namespace Lista01Exercício18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Organizando valores inteiros");

            Console.WriteLine();

            Console.Write("Digite o primeiro valor: ");
            int valor1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o terceiro valor: ");
            int valor3 = Convert.ToInt32(Console.ReadLine());

            if (valor1 > valor2 && valor2 > valor3)
            {
                Console.WriteLine("A ordem decrescente dos valores é " + valor3 + ", " + valor2 + ", " + valor1);
            }

            else if (valor2 > valor1 && valor1 > valor3)
            {
                Console.WriteLine("A ordem decrescente dos valores é " + valor3 + ", " + valor1 + ", " + valor2);
            }

            else if (valor3 > valor2 && valor2 > valor1)
            {
                Console.WriteLine("A ordem decrescente dos valores é " + valor1 + ", " + valor2 + ", " + valor3);
            }

            else if (valor3 > valor1 && valor1 > valor2)
            {
                Console.WriteLine("A ordem decrescente dos valores é " + valor2 + ", " + valor1 + ", " + valor3);
            }

            else if (valor1 > valor3 && valor3 > valor2)
            {
                Console.WriteLine("A ordem decrescente dos valores é " + valor2 + ", " + valor3 + ", " + valor1);
            }

            else if (valor2 > valor3 && valor3 > valor1)
            {
                Console.WriteLine("A ordem decrescente dos valores é " + valor1 + ", " + valor3 + ", " + valor2);
            }
        }
    }
}