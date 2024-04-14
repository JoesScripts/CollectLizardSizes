using System;

class Program
{
    static void Main()
    {
        // Variables to keep track of lizard sizes and count
        int lizardCount = 0;
        double lizardSum = 0.0;

        // Prompt user to enter lizard sizes until -1 is entered
        while (true)
        {
            Console.Write("Enter lizard size in inches (or -1 to stop): ");
            string input = Console.ReadLine();

            // Check if the input is a valid number
            if (double.TryParse(input, out double lizardSize))
            {
                // Check if the sentinel value is entered
                if (lizardSize == -1)
                {
                    break; // Exit the loop if -1 is entered
                }

                // Accumulate lizard size and increment count
                lizardSum += lizardSize;
                lizardCount++;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
        }

        // Output the results
        if (lizardCount > 0)
        {
            double averageLizardSize = lizardSum / lizardCount;
            Console.WriteLine($"Number of lizard sizes collected: {lizardCount}");
            Console.WriteLine($"Sum of lizard sizes: {lizardSum} inches");
            Console.WriteLine($"Average lizard size: {averageLizardSize:F2} inches");
        }
        else
        {
            Console.WriteLine("No lizard sizes were collected.");
        }
    }
}
