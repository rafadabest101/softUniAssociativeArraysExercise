namespace softUniAssociativeArraysExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command = Console.ReadLine();
            while(command != "end")
            {
                string[] info = command.Split(" : ");
                string courseName = info[0];
                string username = info[1];

                if(!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                }
                courses[courseName].Add(username);

                command = Console.ReadLine();
            }

            foreach(string course in courses.Keys)
            {
                Console.WriteLine($"{course}: {courses[course].Count}");
                foreach(string username in courses[course])
                {
                    Console.WriteLine($"-- {username}");
                }
            }
        }
    }
}