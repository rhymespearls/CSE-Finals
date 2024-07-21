class Program
{
    static void Main()
    {
        List<Activity> activities = new List<Activity>();

        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("1. Add Running Activity");
            Console.WriteLine("2. Add Stationary Bicycles Activity");
            Console.WriteLine("3. Add Swimming Activity");
            Console.WriteLine("4. Display Summary");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddRunningActivity(activities);
                    break;
                case "2":
                    AddStationaryBicyclesActivity(activities);
                    break;
                case "3":
                    AddSwimmingActivity(activities);
                    break;
                case "4":
                    DisplaySummary(activities);
                    break;
                case "0":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice! Please try again.");
                    break;
            }
        }
    }

    static void AddRunningActivity(List<Activity> activities)
    {
        Console.Write("Enter the date (yyyy-MM-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the length in minutes: ");
        int lengthInMinutes = int.Parse(Console.ReadLine());

        Console.Write("Enter the distance in miles: ");
        double distance = double.Parse(Console.ReadLine());

        Running running = new Running(date, lengthInMinutes, distance);
        activities.Add(running);

        Console.WriteLine("Running activity added successfully!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void AddStationaryBicyclesActivity(List<Activity> activities)
    {
        Console.Write("Enter the date (yyyy-MM-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the length in minutes: ");
        int lengthInMinutes = int.Parse(Console.ReadLine());

        Console.Write("Enter the speed in mph: ");
        double speed = double.Parse(Console.ReadLine());

        StationaryBicycles stationaryBicycles = new StationaryBicycles(date, lengthInMinutes, speed);
        activities.Add(stationaryBicycles);

        Console.WriteLine("Stationary Bicycles activity added successfully!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void AddSwimmingActivity(List<Activity> activities)
    {
        Console.Write("Enter the date (yyyy-MM-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter the length in minutes: ");
        int lengthInMinutes = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of laps: ");
        int laps = int.Parse(Console.ReadLine());

        Swimming swimming = new Swimming(date, lengthInMinutes, laps);
        activities.Add(swimming);

        Console.WriteLine("Swimming activity added successfully!");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }

    static void DisplaySummary(List<Activity> activities)
    {
        Console.Clear();
        if (activities.Count == 0)
        {
            Console.WriteLine("No activities added yet.");
        }
        else
        {
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }

        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();
    }
}
