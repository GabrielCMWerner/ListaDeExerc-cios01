namespace Lista01Exercício25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            Console.WriteLine();

            Console.Write("Digite o número que será fatorado: ");
            int fatorial = Convert.ToInt32(Console.ReadLine());
            int soma = Convert.ToInt32(0);

            for (int numero = 1; numero <= fatorial; numero++)
            {
                int resultadoMultiplicacao = fatorial * numero;

                Console.WriteLine(fatorial + " X " + numero + " = " + resultadoMultiplicacao);

                soma = soma + resultadoMultiplicacao;
            }

            Console.WriteLine("O resultado é: " + soma);

            Console.ReadLine();
        }
    }
}