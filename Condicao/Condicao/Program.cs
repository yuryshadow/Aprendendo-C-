using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicao
{
    class Program
    {
        static void Main(string[] args)
        {


            #region Condição simples

            //int valor = 2;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Condição verdadeira");
            //}
            //else (valor >= 5 && valor < 10)
            //{
            //    Console.WriteLine("Condição alternitiva 1");
            //}

            #endregion

            #region Condição encadeada

            //int valor = 25;

            //if (valor < 5)
            //{
            //    Console.WriteLine("Condição verdadeira");
            //}
            //else if(valor >= 5 && valor < 10)
            //{
            //    Console.WriteLine("Condição alternitiva 1");
            //}
            //else if(valor >= 10 && valor < 20)
            //{
            //    Console.WriteLine("Condição alternitiva 2");
            //}
            //else
            //{
            //    Console.WriteLine("Condição alternitiva final");
            //}

            //Console.ReadKey();

            #endregion

            #region Condição aninhada

            //int numero = 13;

            //if (numero > 5)
            //{
            //    Console.Write("O número é maior que 5");

            //    if (numero % 2 == 0)
            //    {
            //        Console.WriteLine(" e também é par.");
            //    }
            //    else
            //    {
            //        Console.WriteLine(" mas não é par.");
            //    }
            //}

            //Console.ReadKey();

            #endregion

            int numero = 3;
            //string mensagem = numero > 5 ? "Maior que 5" : "Menor que 5";

            // condição ? true : false;

            //mensagem = numero > 5 ?  "Maior que 5" : "Menor que 5";

            //if(numero > 5)
            //{
            //    mensagem = "Maior que 5";
            //}
            //else
            //{
            //    mensagem = "Menor que 5";
            //}

            Console.WriteLine(numero > 5 ? "Maior que 5" : "Menor que 5");
            Console.ReadKey();
        }
    }
}
