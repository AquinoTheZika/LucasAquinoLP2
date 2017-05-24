using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MesPorExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            string data, mes;
            int D, M, A;


            data = Console.ReadLine();

            D = int.Parse(data.Substring(0, 2));

            M = int.Parse(data.Substring(3, 2));

            A = int.Parse(data.Substring(6, 4));

            if (M == 1)
            {
                mes = "Janeiro";
            }

            else if (M == 2)
            {
                mes = "Fevereiro";
            }

            else if (M == 3)
            {
                mes = "Março";
            }

            else if (M == 4)
            {
                mes = "Abril";
            }

            else if (M == 5)
            {
                mes = "Maio";
            }

            else if (M == 6)
            {
                mes = "Junho";
            }

            else if (M == 7)
            {
                mes = "Julho";
            }

            else if (M == 8)
            {
                mes = "Agosto";
            }

            else if (M == 9)
            {
                mes = "Setembro";
            }

            else if (M == 10)
            {
                mes = "Outubro";
            }

            else if (M == 11)
            {
                mes = "Novembro";
            }

            else
            {
                mes = "Dezembro";
            }

            Console.WriteLine("{0} de {1} de {2}", D, mes, A);

        }
    }
}
