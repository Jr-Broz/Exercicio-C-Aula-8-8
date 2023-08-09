using System;
using System.Net;
//Exercicio 8
namespace Aula_Presencial_8_80
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ip; 

            Console.Write("Entre com o IP: ");
            ip =  Int32.Parse(Console.ReadLine());

            //Classe A

            if ((ip >= 0 )  && (ip <= 127)) {

                Console.WriteLine("Ip classe A");
            }

            //Classe B
            else if ((ip >= 128) && (ip <= 192)){


              Console.WriteLine("Ip classe B");
            }
            //Classe C
            else if ((ip >= 192) && (ip <= 223)) {

                Console.WriteLine("Ip classe C");
            }

            //Classe D
            else if ((ip >= 224) && (ip <= 239)) {

                Console.WriteLine(("Ip Classe D"));
            }

            //Classe E
            else if ((ip >= 248) && (ip <= 1255)) {

                Console.WriteLine("Ip Classe E");
            }
            else {
                Console.WriteLine("Ip invalido");
            }
        }
    }
}
