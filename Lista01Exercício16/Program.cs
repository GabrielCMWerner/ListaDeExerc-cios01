namespace Lista01Exercício16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculo de aumento de salário (e redução pelos impostos)");

            Console.WriteLine();

            Console.Write("Digite o salário inicial do funcionário: ");
            double salarioinicial = Convert.ToDouble(Console.ReadLine());

            double aumento = salarioinicial * 1.15;

            double salariofinal = aumento * 0.92;

            double convertido = Math.Round(salariofinal, 2);

            Console.WriteLine("O salário do funcionario com um aumento de 15% é igual a: " + aumento);

            Console.WriteLine("E após a redução dos impostos ficou igual a: " + convertido);

            Console.ReadLine();
        }
    }
}