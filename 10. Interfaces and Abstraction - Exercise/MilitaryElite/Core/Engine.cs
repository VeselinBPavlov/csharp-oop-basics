namespace MilitaryElite.Core
{
    using MilitaryElite.Contracts;
    using MilitaryElite.Enums;
    using MilitaryElite.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine 
    {
        private ICollection<ISoldier> soldiers;
        private ISoldier soldier;

        public Engine()
        {
            this.soldiers = new List<ISoldier>();
        }

        public void Run() 
        {
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                var input = command.Split();
                var type = input[0];
                var id = int.Parse(input[1]);
                var firstName = input[2];
                var lastName = input[3];

                if (type == "Private") 
                {
                    var salary = decimal.Parse(input[4]);
                    soldier = GetPrivateSoldier(id, firstName, lastName, salary);
                }
                else if (type == "LieutenantGeneral") 
                {
                    var salary = decimal.Parse(input[4]);
                    soldier = GetLieutenantGeneral(id, firstName, lastName, salary, input);
                }
                else if (type == "Engineer") 
                {
                    var salary = decimal.Parse(input[4]);
                    soldier = GetEngeneer(id, firstName, lastName, salary, input);
                }
                else if (type == "Commando") 
                {
                    var salary = decimal.Parse(input[4]);
                    soldier = GetCommando(id, firstName, lastName, salary, input);
                }
                else if (type == "Spy")
                {
                    var codeNumber = int.Parse(input[4]);
                    soldier = GetSpy(id, firstName, lastName, codeNumber);
                }

                if (soldier != null)
                {
                    soldiers.Add(soldier);                    
                }
            }

            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }
        }

        private ISoldier GetSpy(int id, string firstName, string lastName, int codeNumber)
        {
            ISpy spy = new Spy(id, firstName, lastName, codeNumber);
            return spy;
        }

        private ISoldier GetCommando(int id, string firstName, string lastName, decimal salary, string[] input)
        {
            var corpsStr = input[5];

            if (!Enum.TryParse(corpsStr, out Corps corps))
            {
                return null;
            }
            ICommando commando = new Commando(id, firstName, lastName, salary, corps);

            State state;
            for (int i = 6; i < input.Length; i += 2)
            {
                var codeName = input[i];
                var stateStr = input[i + 1];

                if (Enum.TryParse(stateStr, out state) == false)
                {
                    continue;
                }

                IMission mission = new Mission(codeName, state);
                commando.Missions.Add(mission);
            }

            return commando;

        }

        private ISoldier GetEngeneer(int id, string firstName, string lastName, decimal salary, string[] input)
        {
            var corpsStr = input[5];
            Corps corps;
            if (Enum.TryParse(corpsStr, out corps) == false)
            {
                return null;
            }

            IEngineer engineer = new Engineer(id, firstName, lastName, salary, corps);
            for (int i = 6; i < input.Length; i += 2)
            {
                var partName = input[i];
                var workedHours = int.Parse(input[i + 1]);

                IRepair repair = new Repair(partName, workedHours);
                engineer.Repairs.Add(repair);
            }

            return engineer;            
        }

        private ISoldier GetLieutenantGeneral(int id, string firstName, string lastName, decimal salary, string[] input)
        {
            ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);

            for (int i = 5; i < input.Length; i++)
            {
                var privateId = int.Parse(input[i]);
                IPrivate privateSoldier = (IPrivate)this.soldiers.FirstOrDefault(x => x.Id == privateId);
                lieutenantGeneral.Privates.Add(privateSoldier);
            }

            return lieutenantGeneral;
        }

        private ISoldier GetPrivateSoldier(int id, string firstName, string lastName, decimal salary)
        {
            IPrivate privateSoldier = new Private(id, firstName, lastName, salary);
            return privateSoldier;
        }
    }
}