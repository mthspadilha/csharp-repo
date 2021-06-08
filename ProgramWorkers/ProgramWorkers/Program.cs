using System;
using ProgramWorkers.entities.enums;
using ProgramWorkers.entities;
using System.Globalization;



namespace ProgramWorkers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome do Derpartamento:");
            string deptName = Console.ReadLine();
            Console.WriteLine("Worker Data:");
            Console.Write("Nome do funcionario:");
            string name = Console.ReadLine();
            Console.Write("Level(Junior/Mid/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary:");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departament dept = new Departament(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.Write("Quantos contratos:");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Data(DD/MM/AA):");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor Por Hora:");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duração(Horas):");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }


        }
    }
}
