namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Stack<string> friends = new Stack<string>();
           
            friends.Push("Rachel");
            friends.Push("Joey");
            friends.Push("Chandler");
            friends.Push("Ross");
            friends.Push("Monica");
           

            Console.WriteLine($"Is Pheobe with her friends? {friends.Contains("Pheobe")}");
            Console.WriteLine("This friend did not make it to Central Perk today.");
           
            
            Console.WriteLine($"{friends.Count()} friends made it to Central Perk today:");
            
            foreach (var m in friends)
            {
                Console.WriteLine(m);
            }
            string firstFriend = friends.Peek();
            Console.WriteLine($"{firstFriend} has to go to work. They are leaving the coffee shop now.");
            friends.Pop();
                
            Console.WriteLine($"There are {friends.Count} friends still at Central Perk.");

        }
    }
}