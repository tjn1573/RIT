namespace character_creator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // print character name
            Console.WriteLine("Name: Thomas");
            // calculate the points for each stat
            Console.WriteLine("Strength: " + (50 * .2));
            Console.WriteLine("Dexterity: " + ((50 * .2) * .5));
            Console.WriteLine("Intelligence: " + 7);
            Console.WriteLine("Health: " + ((50 * .2 * .5) + 7 - 2));
            Console.WriteLine("Charisma: " + (50 - ((50 * .2) + ((50 * .2) * .5) + (7) + ((50 * .2 * .5) + 7 - 2))));
            Console.WriteLine("Total Points: " + 50); 
        }
    }
}