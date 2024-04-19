namespace DesafioDiamanteAcademia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número impar para criar o diamanteX: ");
            //int tamanhoDiamante = Convert.ToInt32(Console.ReadLine());

            if (int.TryParse(Console.ReadLine(), out int tamanhoDiamante))
            {
                if (tamanhoDiamante % 2 == 0)
                {
                    Console.WriteLine("O número digitado não é um número ímpar!");
                    return;
                }
            }

            //int inicio = 1;

            //int metade = (inicio - tamanhoDiamante) / 2;

            int metade = tamanhoDiamante / 2;

            PrintarDiamante(metade, tamanhoDiamante);


        }

        static void PrintarDiamante(int metade, int tamanhoDiamante)
        {
            Console.WriteLine();

            for (int i = 0; i <= metade; i++)
            {
                for (int j = 0; j < tamanhoDiamante; j++)
                {
                    if (j >= metade - i && j <= metade + i)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }

            for (int i = metade - 1; i >= 0; i--)
            {
                for (int j = 0; j < tamanhoDiamante; j++)
                {
                    if (j >= metade - i && j <= metade + i)
                    {
                        Console.Write("X");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}

