namespace Lista01Exercícios22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gerando valores impares de 100 a 200");

            Console.WriteLine();

            int contador = 101;
            Console.WriteLine();

            while(contador < 200){ 
                if(contador % 2 == 1)
                {
                    Console.WriteLine(contador);
                }
                    contador++;



            }
        }
    }
}