using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyApp
{
    class Program
    {

        static int potencia(int x, int y)
        {
            if (y == 0)
            {
                return 1;
            }
            else
            {
                return x * potencia(x, y - 1);
            }
            
        }

        static double cubos(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return (cubos(n - 1) + Math.Pow(n, 3));
            }
        }

        static int mdc(int x, int y)
        {
            if (y == x)
                return x;
            else
            {
                return mdc(y, x % y);
            }
        }


        static int fibonacci(int n)
        {
            if (n == 1 || n == 0)
            {
                return 1;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }

        static int decimalTobinario(int numero_decimal)
        {
            if (numero_decimal <= 1) return numero_decimal;

            return (numero_decimal % 2 + 10 * decimalTobinario(numero_decimal/2) );


        }

        

        static void Main(string[] args)
        {
            int op = 1, x, y, n, numberdec;
            


#pragma warning disable CS0642 // Possible mistaken empty statement
            while (op != 0) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
            {
                Console.WriteLine("MENU");
                Console.WriteLine("1 - Potencia\n"+
                    "2 - CUBOS\n"+
                    "3 - MDC\n"+
                    "4 - Serie de Fibonacci\n"+
                    "5 - Conversão de Inteiro para Binario\n"+
                    "Digite a opção Deseajada: ");
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("Numero da Base: ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Numero do Expoente");
                        y = Convert.ToInt32(Console.ReadLine());
                        int resultado = potencia(x, y);
                        Console.WriteLine(resultado);
                        break;
                    case 2:
                        Console.WriteLine("Informe um inteiro positivo: ");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine("%d\n", cubos(n));
                        break;
                    case 3:
                        Console.WriteLine("Informe o primeiro Numero inteiro: ");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Informe o segundo numero inteiro: ");
                        y = int.Parse(Console.ReadLine());
                        Console.WriteLine("O MDC dos valores" + x + " e " + y + " é " + mdc(x, y);
                        Console.WriteLine("\n");
                        break;

                    case 4:
                        Console.WriteLine("Digite o tamanho da sequencia");
                        n = int.Parse(Console.ReadLine());

                        Console.WriteLine("resultado");
                        for (int c=0; c<=n; c++)
                        {
                            Console.WriteLine(" "+ fibonacci(c+ 1));
                        }

                        break;

                    case 5:
                        Console.WriteLine("Digite o numero decimal a converter: ");
                        numberdec = int.Parse(Console.ReadLine());
                        Console.WriteLine(decimalTobinario(numberdec));
                        break;
                }


            }

        }


    }
}