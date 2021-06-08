using ProgramWorkers.entities.enums;
using System.Collections.Generic;

namespace ProgramWorkers.entities
{
    class Worker
    {
        public string Name { get; set; }

        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        public Departament departament { get; set; }

        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Departament departament)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            this.departament = departament;
        }

        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

    }
}
