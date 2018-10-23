using System;
using System.Collections.Generic;
using System.Linq;

namespace Hospital
{
    public class StartUp
    {
        public static void Main()
        {
            Dictionary<string, List<string>> doctors = new Dictionary<string, List<string>>();
            Dictionary<string, List<List<string>>> departments = new Dictionary<string, List<List<string>>>();

            string command = Console.ReadLine();
            while (command != "Output")
            {
                string[] inputArgs = command.Split();
                var departament = inputArgs[0];
                var firstName = inputArgs[1];
                var lastName = inputArgs[2];
                var patient = inputArgs[3];
                var doctorName = firstName + lastName;

                if (!doctors.ContainsKey(firstName + lastName))
                {
                    doctors[doctorName] = new List<string>();
                }
                if (!departments.ContainsKey(departament))
                {
                    departments[departament] = new List<List<string>>();
                    for (int stai = 0; stai < 20; stai++)
                    {
                        departments[departament].Add(new List<string>());
                    }
                }

                bool isDepartamentFull = departments[departament].SelectMany(x => x).Count() < 60;
                if (isDepartamentFull)
                {
                    int staq = 0;
                    doctors[doctorName].Add(patient);
                    for (int st = 0; st < departments[departament].Count; st++)
                    {
                        if (departments[departament][st].Count < 3)
                        {
                            staq = st;
                            break;
                        }
                    }
                    departments[departament][staq].Add(patient);
                }

                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "End")
            {
                string[] args = command.Split();

                if (args.Length == 1)
                {
                    Console.WriteLine(string.Join("\n", departments[args[0]].Where(x => x.Count > 0).SelectMany(x => x)));
                }
                else if (args.Length == 2 && int.TryParse(args[1], out int staq))
                {
                    Console.WriteLine(string.Join("\n", departments[args[0]][staq - 1].OrderBy(x => x)));
                }
                else
                {
                    Console.WriteLine(string.Join("\n", doctors[args[0] + args[1]].OrderBy(x => x)));
                }
                command = Console.ReadLine();
            }
        }
    }
}
