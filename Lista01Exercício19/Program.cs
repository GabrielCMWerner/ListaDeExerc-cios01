namespace Lista01Exercício19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("IMC");

            Console.WriteLine();

            Console.Write("Digite a sua altura (em CM): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o seu peso: ");
            double peso = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("IMC: Abaixo do peso");
            }

            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("IMC: Peso normal");
            }

            else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("IMC: Acima do peso");
            }

            else if (imc >= 30)
            {
                Console.WriteLine("IMC: Obeso");
            }

            Console.ReadLine();
        }
    }
}