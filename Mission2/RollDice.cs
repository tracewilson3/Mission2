namespace Mission2;

public class RollDice
{
    public RollDice()
    {
        Console.WriteLine("Rolling!");
    }
    public int[] GenRolls(int rolls)
    {
        // declare variables
        Random random = new Random();
        int[] results = new int[11]; // Array to store counts for sums 2 to 12

        // roll dice, save sum counts to an array
        for (int i = 0; i < rolls; i++)
        {
            int die1 = random.Next(1, 7); // Roll first die (1 to 6)
            int die2 = random.Next(1, 7); // Roll second die (1 to 6)
            int sum = die1 + die2;        // Calculate the sum of the two dice

            results[sum - 2]++;
        }

        return results;
    }
}