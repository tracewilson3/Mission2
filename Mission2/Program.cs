// See https://aka.ms/new-console-template for more information

using Mission2;

internal class Program
{
    public static void Main(string[] args)
    {
        // declare variables
        RollDice rd;
        rd = new RollDice();
        int rolls = 0;
        
        // initial prompts
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate? ");
        
        rolls = int.Parse(Console.ReadLine());
        
        // declare result variables
        int[] results = new int[11];;
        results = rd.GenRolls(rolls: rolls);
        
        // result headers
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + rolls);
            
        // calculate and round percentage, then print as asterisks
        for (int i = 0; i < results.Length; i++)
        {
            float ratio = ((float)results[i] / rolls) * 100; 
            int percentage = (int)Math.Round(ratio);      
            Console.WriteLine($"{i + 2}: {new string('*', percentage)}");
        }
        // finish
        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
        
    }
}