Console.WriteLine("FOOBER: WE'LL GET YA THERE");

string userInput = "";
double cost = 23.74;

List<string> startPoints = new List<string>();
List<string> endPoints = new List<string>();
List<DateTime> timestamps = new List<DateTime>();

while (userInput != "Exit")
{
    Console.WriteLine("Enter Ride, Profile, or Exit:");
    var input = Console.ReadLine();
    if (input != null) { userInput = input; }
    switch (userInput)
    {
        case "Ride":
            Console.WriteLine("Where are you now?");
            startPoints.Add(Console.ReadLine());

            Console.WriteLine("Where are you headed?");
            endPoints.Add(Console.ReadLine());
            timestamps.Add(DateTime.Now);

            Console.WriteLine("Driver: Karina Daniels\nDriver Location: Bridgeville, PA (12 miles away)\nDriver Arrival Time: 12:23 pm (30 minutes)\nCost: $" + cost);
            int rating = 0;
            while (userInput != "Back")
            {
                Console.WriteLine("Enter Rate, Driver, Details, or Back");
                input = Console.ReadLine();
                if (input != null) { userInput = input; }
                switch (userInput)
                {
                    case "Rate":
                        rating = 0;
                        while (rating == 0)
                        {
                            Console.WriteLine("Rate driver Karuna Daniels (1-5): ");
                            rating = Convert.ToInt32(Console.ReadLine());
                            if (rating < 1 || rating > 5)
                            {
                                rating = 0;
                                Console.WriteLine("Enter a valid rating (1-5): ");
                            }
                        }

                        Console.WriteLine("Give a compliment?");
                        Console.ReadLine();
                        Console.WriteLine("Add a tip:");
                        Console.WriteLine("Enter a percentage:");
                        int tip = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Tip: $" + Math.Round(tip / 100.0 * cost, 2));
                        break;
                    case "Driver":
                        Console.WriteLine("Driver: Karina Daniels");
                        if (rating == 0)
                        {
                            Console.WriteLine("Rating: Not Rated; Enter 'Rate' to rate!");
                        }
                        else
                        {
                            Console.WriteLine("Rating: " + rating);
                        }
                        break;
                    case "Details":
                        Console.WriteLine("Starting Date: " + timestamps[startPoints.Count - 1].ToString("MM/dd/yyyy"));
                        Console.WriteLine("Starting Time: " + timestamps[startPoints.Count - 1].ToString("hh:mm tt"));
                        Console.WriteLine("Starting Location: " + startPoints[startPoints.Count - 1]);
                        Console.WriteLine("Destination: " + endPoints[startPoints.Count - 1]);
                        Console.WriteLine("Travel distance: 14 miles\nTravel Time: 23 minutes");
                        break;
                    case "Back":
                        break;
                    default:
                        Console.WriteLine("Please enter a valid phrase.");
                        break;
                }
            }
            break;

        case "Profile":
            while (userInput != "Back")
            {
                Console.WriteLine("Select Rewards, Help, Trips, or Back: ");
                input = Console.ReadLine();
                if (input != null) { userInput = input; }
                switch (userInput)
                {
                    case "Rewards":
                        Console.WriteLine("Earning Period: April 2022 - September 2022");
                        Console.WriteLine("Current Points: " + startPoints.Count * 50);
                        break;
                    case "Help":
                        Console.WriteLine("Enter a value from the list prompted to navigate to the desired feature.");
                        break;
                    case "Trips":
                        Console.WriteLine("Trip History:");
                        if (startPoints.Count == 0) { Console.WriteLine("No completed trips."); break; }
                        for (int i = 0; i < startPoints.Count && i < endPoints.Count; i++)
                        {
                            Console.WriteLine(startPoints[i] + " to " + endPoints[i]);
                        }
                        break;
                    case "Back":
                        break;
                    default:
                        Console.WriteLine("Please enter a valid phrase.");
                        break;
                }
            }
            break;

        case "Exit":
            Console.WriteLine("GoodBye!");
            Environment.Exit(0);
            return;

        default:
            Console.WriteLine("Please enter a valid phrase.");
            break;
    }
}