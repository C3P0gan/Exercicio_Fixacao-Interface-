using System;
using System.Globalization;
using ExercícioFixação_Interface_.Entities;
using ExercícioFixação_Interface_.Services;

namespace ExercícioFixação_Interface_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime contractDate = DateTime.Parse(Console.ReadLine());
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Contract contract = new Contract(contractNumber, contractDate, contractValue);
            ContractService contractService = new ContractService(new PaypalService());

            Console.Write("Enter number of installments: ");
            int installments = int.Parse(Console.ReadLine());
            contractService.ProcessContract(contract, installments);
            Console.WriteLine("Installments:");
            foreach (Installment installment in contract.Installments)
            {
                Console.WriteLine(installment);
            }
        }
    }
}
