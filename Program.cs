using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_novembro
{
    class Program
    {
        static void Main(string[] args)
        {
            double slr_fun;
            string filhos, pln_saude;

            Console.WriteLine("Informe o Salário do Funcionário.");
            slr_fun = double.Parse(Console.ReadLine());

            Console.WriteLine("O Funcionário Possui Filhos? (S/N).");
            filhos = Console.ReadLine().ToUpper();

            if (filhos == "S")
            {
                slr_fun += 200.00;
            }

            Console.WriteLine("O Funcionário Optou por Plano de Saúde? (S/N).");
            pln_saude = Console.ReadLine().ToUpper();

            if (pln_saude == "S")
            {
                 slr_fun -= 300.00;
            }

            if (slr_fun <= 4000)
            {
                slr_fun -= slr_fun * 0.11;
            }

            else if (slr_fun > 4000)
            {
                slr_fun -= slr_fun * 0.15;
            }

            Console.WriteLine("O Salário Final do Funcionário é: " + slr_fun.ToString("C"));

            Console.ReadKey();














        }
    }
}
