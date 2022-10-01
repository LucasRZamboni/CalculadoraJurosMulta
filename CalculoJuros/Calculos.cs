using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CalculoJuros
{
    class Calculos
    {

        public static double aluguel, jurosDiario = 0.3333333, multa = 0.1, valorFinal, juros, juros1, valorMulta;
        public static int dias;

        public static void Calculo30ComDev()
        {

            for (int i = 0; i <= dias; i++)
            {
                juros1 = (jurosDiario * i);
            }
            juros = (juros1 * aluguel) / 100;
            valorMulta = aluguel * multa;
            valorFinal = valorMulta + juros;


        }
        public static void Calculo30SemDev()
        {

            for (int i=0; i <= dias; i++)
            {
                juros1 = (jurosDiario * i);
            }
            juros = (juros1 * aluguel) / 100;
            

           valorMulta = aluguel * multa;
           valorFinal = ((aluguel*1) + juros + valorMulta);

        }
        public static void Calculo60SemDev()
        {

            

                for (int i = 0; i <= dias; i++)
                {
                    juros1 = (jurosDiario * i);
                }

                juros = ((juros1 * aluguel) / 100)*2;


                valorMulta = (aluguel * multa)*2;
                valorFinal = ((aluguel*2) + juros + valorMulta);
            
        }
        public static void Calculo90SemDev()
        {


            for (int i = 0; i <= dias; i++)
            {
                juros1 = (jurosDiario * i);
            }

            juros = ((juros1 * aluguel) / 100)*3;


            valorMulta = (aluguel * multa) * 3;
            valorFinal = ((aluguel*3) + juros + valorMulta);

        }
        public static void Calculo120SemDev()
        {


            for (int i = 0; i <= dias; i++)
            {
                juros1 = (jurosDiario * i);
            }

            juros = ((juros1 * aluguel) / 100)*4;


            valorMulta = (aluguel * multa) * 4;
            valorFinal = ((aluguel * 4) + juros + valorMulta);

        }
        public static void Calculo150SemDev()
        {


            for (int i = 0; i <= dias; i++)
            {
                juros1 = (jurosDiario * i);
            }

            juros = ((juros1 * aluguel) / 100)*5;


            valorMulta = (aluguel * multa) * 5;
            valorFinal = ((aluguel * 5) + juros + valorMulta);

        }

    }
}
