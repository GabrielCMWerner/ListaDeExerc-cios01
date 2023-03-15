namespace Lista01Exercício04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculando a media de combustivel consumida pelo veiculo");


            Console.WriteLine();


            Console.Write("Digite a quilometragem inicial: ");
            double quilometragemi = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quilometragem rodada: ");
            double quilometrosrodados = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a quantidade de litros consumidos: ");
            double litros = Convert.ToDouble(Console.ReadLine());

            double media = quilometrosrodados / litros;
            double quilometragemf = quilometragemi + quilometrosrodados;


            Console.WriteLine();


            Console.WriteLine("A média de consumo de combustivel por quilometro rodado foi de: " + media);


            Console.WriteLine("A quilometragem do veiculo após o percurso é de: " + quilometragemf);

            Console.ReadLine();


        }
    }
}