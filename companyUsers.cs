namespace softUniAssociativeArraysExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();
            while(command != "End")
            {
                string name = command.Split(" -> ")[0];
                string id = command.Split(" -> ")[1];

                if(!companies.ContainsKey(name)) companies.Add(name, new List<string>());
                if(!companies[name].Contains(id)) companies[name].Add(id);

                command = Console.ReadLine();
            }

            foreach(string name in companies.Keys)
            {
                Console.WriteLine(name);
                foreach(string id in companies[name])
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}