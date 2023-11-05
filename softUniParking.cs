namespace softUniAssociativeArraysExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> users = new Dictionary<string, string>();
            for(int i = 1; i <= n; i++)
            {
                string[] info = Console.ReadLine().Split();
                string command = info[0];
                string username = info[1];

                switch(command)
                {
                    case "register":
                        string licensePlateNumber = info[2];
                        if(users.ContainsKey(username))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                        }
                        else
                        {
                            users.Add(username, licensePlateNumber);
                            Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                        }
                        break;
                    case "unregister":
                        if(users.ContainsKey(username))
                        {
                            users.Remove(username);
                            Console.WriteLine($"{username} unregistered successfully");
                        }
                        else Console.WriteLine($"ERROR: user {username} not found");
                        break;
                }
            }

            foreach(string user in users.Keys) Console.WriteLine($"{user} => {users[user]}");
        }
    }
}