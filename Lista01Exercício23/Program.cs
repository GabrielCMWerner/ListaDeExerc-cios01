namespace Lista01Exercício23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerando a soma de valores multiplos de 3 de 1 a 500");

            Console.WriteLine();

            int soma = 0;
            int contador = 1;
            Console.WriteLine();

            while (contador < 501){
                if (contador % 2 == 0)
                {
                    if (contador % 3 == 0)
                    {
                        soma = soma + contador;
                    }
                }


                contador++;

            }

            Console.WriteLine("O resultado da soma é: " + soma);
            Console.ReadLine();
        }
    }
}