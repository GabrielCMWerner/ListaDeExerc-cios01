namespace Lista01Exercício10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a média ponderada do Aluno");

            Console.WriteLine();

            Console.Write("Digite a primeira nota: ");
            int nota1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            int nota2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Levando em conta que 1 é 100%, digite o peso de cada prova: (ex: 0.5 = 50% do total)");

            Console.Write("Digite quanto vale a nota da primeira prova: ");
            double peso1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite quanto vale a nota da segunda prova: ");
            double peso2 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 * peso1) + (nota2 * peso2);

            Console.WriteLine($"A media ponderada é: " + media);

            Console.ReadLine();
        }
    }
}