using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        int breathingTotal = 0;
        int reflectionTotal = 0;
        int listingTotal = 0;

        while (choice != "5")
        {
            Console.Clear();

            Console.WriteLine("Mindfulness Program");
            Console.WriteLine();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflection activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. View Statistics");
            Console.WriteLine("  5. Quit");

            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity();
                    breathing.Run();

                    breathingTotal += breathing.GetDuration();
                    break;

                case "2":
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.Run();

                    reflectionTotal += reflection.GetDuration();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity();
                    listing.Run();

                    listingTotal += listing.GetDuration();
                    break;

                case "4":
                    Console.Clear();

                    Console.WriteLine("Mindfulness Statistics");
                    Console.WriteLine("----------------------");

                    TimeSpan breathingTime =
                        TimeSpan.FromSeconds(breathingTotal);

                    TimeSpan reflectionTime =
                        TimeSpan.FromSeconds(reflectionTotal);

                    TimeSpan listingTime =
                        TimeSpan.FromSeconds(listingTotal);

                    TimeSpan totalTime =
                        TimeSpan.FromSeconds(
                            breathingTotal +
                            reflectionTotal +
                            listingTotal);

                    Console.WriteLine(
                        $"Breathing Activity: {breathingTime.Minutes} minute(s) {breathingTime.Seconds} second(s)");

                    Console.WriteLine(
                        $"Reflection Activity: {reflectionTime.Minutes} minute(s) {reflectionTime.Seconds} second(s)");

                    Console.WriteLine(
                        $"Listing Activity: {listingTime.Minutes} minute(s) {listingTime.Seconds} second(s)");

                    Console.WriteLine();
                    Console.WriteLine(
                        $"Total Mindfulness Time: {totalTime.Minutes} minute(s) {totalTime.Seconds} second(s)");

                    break;

                case "5":
                    Console.WriteLine("Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }

            if (choice != "5")
            {
                Console.WriteLine();
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
            }
        }
    }
}