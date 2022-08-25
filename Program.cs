using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chute_aleatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o numero a ser acertado de 1 a 10: ");
            int a = int.Parse(Console.ReadLine());
            if ((a > 10) || (a < 1))
            {
                Console.WriteLine("Erro, o numero digitado nao correspende as especificaçoes acima.");
                Environment.Exit(0);
            }
            Console.WriteLine("Chute um número até acertar: ");
            int b = int.Parse(Console.ReadLine());
            if ((b > 10) || (b < 1))
            {
                Console.WriteLine("Erro, o numero digitado nao correspende as especificaçoes acima.");
                Environment.Exit(0);
            }
            for (int i = b; i < 11; i = 0)
            {
                if (b < a)
                {
                    Console.WriteLine("O numero que voce digitou é menor do que o numero randomico.");
                    Console.WriteLine("Digite outro numero: ");
                    b = int.Parse(Console.ReadLine());
                }
                if (b > a)
                {
                    Console.WriteLine("O numero que voce digitou é maior do que o numero randomico.");
                    Console.WriteLine("Digite outro numero: ");
                    b = int.Parse(Console.ReadLine());
                }
                if ((b > 10) || (b < 1))
                {
                    Console.WriteLine("Erro, o numero digitado nao correspende as especificaçoes acima.");
                    break;
                }
                if (b == a)
                {
                    Console.WriteLine("Parabens o numero digitado foi igual ao randomico.");
                    break;
                }
            }
            Console.ReadKey();

        }
    }
}
