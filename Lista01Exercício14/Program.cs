namespace Lista01Exercício14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a quantidade de dias vividos");

            Console.WriteLine();

            Console.Write("Digite o nome da pessoa: ");
            string nome = Convert.ToString(Console.ReadLine());

            Console.Write("Digite a idade de " + nome + ": ");
            double idade = Convert.ToInt32(Console.ReadLine());

            double dias = idade * 365;

            Console.WriteLine(nome + " já viveu " + dias + " dias");

            Console.ReadLine();

        }
    }
}