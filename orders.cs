namespace softUniAssociativeArraysExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resources = new Dictionary<string, int>();

            string command = Console.ReadLine();
            string lastOre = "";
            int linesRead = 0;
            while(command != "stop")
            {
                if(linesRead % 2 == 0)
                {
                    if(!resources.ContainsKey(command)) resources.Add(command, 0);
                    lastOre = command;
                }
                else resources[lastOre] += int.Parse(command);

                linesRead++;
                command = Console.ReadLine();
            }

            foreach(string resource in resources.Keys) Console.WriteLine($"{resource} -> {resources[resource]}");
        }
    }
}