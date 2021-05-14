using System;
using System.Globalization;
using System.Collections.Generic;
using Exercicio11ImpostoRenda.Entities;

namespace Exercicio11ImpostoRenda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> list = new List<TaxPayer>();
            
            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new IndividualPayer(name, anualIncome, healthExpenditures));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());
                    list.Add(new CompanyPayer(name, anualIncome, numberOfEmployees));
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0.0;

            foreach (TaxPayer payer in list)
            {
                Console.WriteLine(payer.Name + ": $ " + payer.TaxesPaid().ToString("F2", CultureInfo.InvariantCulture));
                sum += payer.TaxesPaid();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
