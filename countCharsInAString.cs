namespace softUniAssociativeArraysExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();

            string str = Console.ReadLine();
            foreach(char ch in str)
            {
                if(!chars.ContainsKey(ch)) chars.Add(ch, 1);
                else chars[ch]++;
            }

            foreach(char ch in chars.Keys)
            {
                if(ch != ' ') Console.WriteLine($"{ch} -> {chars[ch]}");
            }
        }
    }
}