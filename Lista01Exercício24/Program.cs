namespace Lista01Exercício24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada");

            Console.WriteLine();

            Console.Write("Digite o número que será utilizado na tabuada: ");
            int tabuada = Convert.ToInt32(Console.ReadLine());

            for (int numero = 1; numero <= 10; numero++)
            {
                int resultadoMultiplicacao = tabuada * numero;

                Console.WriteLine(tabuada + " X " + numero + " = " + resultadoMultiplicacao);
            }

            Console.ReadLine();
        }
    }
}