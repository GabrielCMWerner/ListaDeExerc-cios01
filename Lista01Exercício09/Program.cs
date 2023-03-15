namespace Lista01Exercício09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a média harmonica do Aluno");

            Console.WriteLine();

            Console.Write("Digite quantas notas do aluno: ");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            double somainversos = 0;

            for (int i = 1; i <= quantidade; i++)
            {
                Console.Write($"Digite a nota {i}: ");
                double nota = Convert.ToDouble(Console.ReadLine());
                somainversos += 1.0 / nota;
            }

            double media = quantidade / somainversos;

            Console.WriteLine($"A media harmonica das notas é: {media:F2}");
        }
    }
}