using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variaveis
{
    class Program
    {
        enum Notas
        {
            Minimo = 10,
            Media = 15,
            Maxima = 20
        }

        struct Pessoa
        {
            public string nome;
            public int idade;
            public double altura;
        }

        static void Main(string[] args)
        {
            #region Numericas Integrais
            // Integral assinado
            //sbyte num1 = 10; // 8 bits, de -128 a 127
            //short num2 = 20; 
            //int num3 = 30;
            //long num4 = 40L;

            //// Integral sem sinal
            //byte num5 = 10;
            //ushort num6 = 20;
            //uint num7 = 30;
            //ulong num8 = 40L;

            //sbyte numero;
            //numero = 100;

            //numero = 120;
            //numero = num1;
            #endregion

            #region Números Reais
            //float real1 = 100.75f;
            //double real2 = 500.754;
            //decimal real3 = 752538.437m;

            //double valor;
            //valor = real1;
            #endregion

            #region Caractere
            //char letra = '\u0041';
            //char escape = '\n';
            //char literal = 'C';
            #endregion

            #region Boolean
            //bool verificar = false;
            //verificar = true;
            #endregion

            #region String (Cadeia de Caracteres)
            //string texto = @"Gabriel Artigas\n 1985 @@??$$";
            //string mensagem = null;
            //mensagem = texto;
            #endregion

            #region Tipo Implícito Var
            //var valor = 100;
            //valor = 20;
            //valor = "Gabriel";
            #endregion

            #region Tipo Object (Base para todos os tipos)
            //object obj = false;
            //obj = 200;
            //obj = "Gabriel";
            #endregion

            #region Constantes
            const double pi = 3.1415;
            const string nome = "Yuri";
            #endregion

            #region Enumeração
            //Notas notasAlunos = Notas.Media;
            #endregion

            Pessoa p1 = new Pessoa();
            p1.altura = 1.65;
            p1.idade = 35;
            p1.nome = "Gabriel";

            Pessoa p2 = new Pessoa()
            {
                nome = "Arthur",
                idade = 9,
                altura = 1.35
            };

            p1.nome = "Logan";

            Console.WriteLine(p1.nome);
            Console.WriteLine(p1.idade);
            Console.WriteLine(p1.altura);

            Console.WriteLine();

            Console.WriteLine(p2.nome);
            Console.WriteLine(p2.idade);
            Console.WriteLine(p2.altura);

            Console.ReadKey();
        }
    }
}
