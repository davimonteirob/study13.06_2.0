using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study13._06_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            //instanciando a classe Array
            //Em .CreateInstance(), precisamos informar dois parâmetros — o tipo dos valores do array e o tamanho dele.
            //tipo: typeof(tipo), tramanho: 5;
            Array amostra = Array.CreateInstance(typeof(double), 5);//tamanho.
            //Agora que já criamos o array amostra, vamos setar valores para ele por meio da função SetValue(),
            //que requer dois parâmetros — o valor e o índice desse valor:
            amostra.SetValue(10, 0);
            amostra.SetValue(6.5, 1);
            amostra.SetValue(7, 2);
            amostra.SetValue(4.6, 3);
            amostra.SetValue(8, 4);




        }
        //FAZER :
        // para fazer o cálculo da mediana, precisamos ordenar os valores do array
        private static void CalculaMediana(Array array)
        {
            double[] numerosOrdenados = (double[])array.Clone();
            int tamanho = numerosOrdenados.Length;
            int mrio = tamanho / 2;

        }
    }
}
