namespace Lista01Exercício11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificando se o número é primo");

            Console.WriteLine();

            Console.Write("Digite o número que será verificado: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int cont = 0;

            for (int i = numero; i > 0; i--)
            {
                if (numero % i == 0)
                {
                    cont++;
                }

            }
            if (cont == 2)
            {
                Console.WriteLine("O número " + numero + " é um numero primo");
            }
            else
            {
                {
                    Console.WriteLine("O número " + numero + " não é um numero primo");


            }

            }
        }
    }
}