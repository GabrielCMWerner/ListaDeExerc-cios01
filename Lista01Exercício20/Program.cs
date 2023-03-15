namespace Lista01Exercício20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Verificando se o número é par ou impar");

            Console.WriteLine();

            Console.Write("Digite o número que será verificado: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            int resultado = numero % 2;
           
            if (resultado == 0)
            {
                Console.Write("O número é par");
            }

            else
            {
                Console.Write("O número é impar: ");
            }

            Console.ReadLine();
        }

            
    }   

    
}