namespace Lista01Exercício01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                
                Console.WriteLine("Calculando o Volume de uma caixa");

                Console.WriteLine();

                Console.WriteLine("Digite a largura da caixa");
                decimal largura = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite a altura da caixa");
                decimal altura = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Digite o comprimeto da caixa");
                decimal comprimento = Convert.ToDecimal(Console.ReadLine());

                decimal volume = comprimento + altura + largura;

                Console.WriteLine("O volume da caixa é: " + volume + "metros cúbicos");

                Console.ReadLine();
            }
        }
    }
}
    
