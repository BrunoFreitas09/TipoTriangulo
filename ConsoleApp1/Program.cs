using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {


        static void Main(string[] args)
        {
            //faça um programa que verifique se o triângulo ele pe isóceles,escaleno ou equilatero.
            //Um dos lados deve ser maior que o valor absoluto da diferença dos outros dois lados 
            // Um dos lados deve ser menor que a soma dos outros dois lados
            Console.WriteLine("Vamos ver se o tipo do seu triângulo! " +
                "Digite o tamanho de um dos lados: ");
            double L1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do Segundo lado: ");
            double L2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do terceiro lado: ");
            double L3 = double.Parse(Console.ReadLine());


            //verificando se é um triângulo


            

            if ((L1 < L2 + L3) && (L2 < L1 + L3) && (L3 < L1 + L2))
   //passou por essa etapa é um triângulo 
            {
                //verificando o tipo do triangulo:

                //equilatero:
                    bool EQ = (L1 == L2) && (L2 == L3) ;
                //escaleno:
                    bool ES = (L1 != L2) && (L2 != L3);
                //isóceles:
                bool Iso = (L1 == L2) && (L2 != L3) || (L2 == L3) && (L3 != L1) || (L1 == L3) && (L3 != L2);


                Console.WriteLine("Se o triangulo é escaleno? " + ES);
                Console.WriteLine("Se o triângulo é equilatero? " + EQ);
                Console.WriteLine("Se o triângulo pe Isóceles? " + Iso);
            }

            else {
                Console.WriteLine("Não é um triângulo.");
                 }

            Console.ReadKey();
        }

    }
}
