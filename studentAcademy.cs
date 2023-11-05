namespace softUniAssociativeArraysExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if(!students.ContainsKey(name)) students.Add(name, new List<double>());
                students[name].Add(grade);
            }

            foreach(string name in students.Keys)
            {
                double averageGrade = students[name].Average();

                if(averageGrade >= 4.50) Console.WriteLine($"{name} -> {averageGrade:f2}");
            }
        }
    }
}