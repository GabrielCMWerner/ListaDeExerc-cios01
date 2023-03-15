namespace Lista01Exercício13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lucros da padaria:");

            Console.WriteLine();

            Console.Write("Digite a quantidade de paes vendidos: ");
            double quantidadepaes = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a quantidade de broas vendidos: ");
            double quantidadebroas = Convert.ToInt32(Console.ReadLine());

            double valorarrecadado = (quantidadepaes * 0.12) + (quantidadebroas * 1.50);

            double poupanca = valorarrecadado * 0.10;

            Console.WriteLine("O total de dinheiro arrecadado no final do dia foi de: R$" + valorarrecadado);

            Console.WriteLine("E o valor da poupança é de: R$" + poupanca);

            Console.ReadLine();


        }
    }
}