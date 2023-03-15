namespace Lista01Exercício07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando o salario total de um vendedor");

            Console.WriteLine();

            Console.Write("Digite o salário base: ");
            double salariobase = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o total de vendas do vendedor: ");
            double vendas = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o percentual de comissão (em %): ");
            double comissao = Convert.ToDouble(Console.ReadLine());

            double salariototal = salariobase + (vendas * (comissao * salariobase / 100));

            Console.WriteLine();

            Console.Write("O salalrio total é igual a: " +  salariototal);

            Console.ReadLine();










        }
    }
}