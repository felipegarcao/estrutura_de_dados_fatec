using System;

namespace exercicio14
{
    class Program
    {

        const int MAX = 20;

        static void Insere(int[] q, ref int f, int v)
        {
            q[f] = v;
            f++;
        }

        static int Remove(int[] q, ref int i)
        {
            return (q[i++]);
        }

        static bool EstaVazia(int i, int f)
        {
            if (i == f)
                return true;
            else
                return false;
        }

        static bool EstaCheia(int f)
        {
            if (f == MAX)
                return true;
            else
                return false;
        }

        static void Main(string[] args)
        {
            int[] fila = new int[MAX];
            int i = 0, f = 0, counterMedia = 0, z = 0, total = 0;

            Console.WriteLine("Digite a quantidade de Numero que deseja: ");
            string saveNumber = Console.ReadLine();
            int numberDoido = Convert.ToInt32(saveNumber);
            int bigger = numberDoido, smaller = numberDoido;

            while (numberDoido != 0)
            {
                if (!EstaCheia(f))
                {
                    if (numberDoido > bigger)
                        bigger = numberDoido;
                    else if (numberDoido < smaller)
                        smaller = numberDoido;

                    Insere(fila, ref f, numberDoido);
                    counterMedia++;
                }

                string show = Console.ReadLine();
                numberDoido = Convert.ToInt32(show);
            }

            Console.WriteLine("EXIBINDO TODOS OS NUMEROS DIGITALIZADOS POR VOCE: ");

            while (counterMedia > 0)
            {
                z = Remove(fila, ref i);

                Console.WriteLine(z);
                total += z;
                counterMedia--;
            }

            float media_ari = total / f;

            Console.WriteLine("\nMédia: " + media_ari);
            Console.WriteLine("Maior: " + bigger);
            Console.WriteLine("Menor: " + smaller);
        }
    }
}
