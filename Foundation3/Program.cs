class Program
{
    static void Main()
    {
        Address address1 = new Address("123 Main St", "Rexburg", "Idaho");
        Address address2 = new Address("456 Park Ave", "Provo", "Utah");
        Address address3 = new Address("789 Beach Rd", "Augusta", "georgia");

        Lecture lecture = new Lecture("Full Body excercise Lectures", "Learn about how to improve your health", DateTime.Now, new TimeSpan(10, 0, 0), address1, "Henry Dean Bondah", 100);
        Reception reception = new Reception("Healthy Body Reception", "register with us to commence your healthy leaving", DateTime.Now, new TimeSpan(15, 0, 0), address2, "Screate@gmail.com");
        OutdoorGathering outdoorGathering = new OutdoorGathering("Practice Activity", "practice what has been thought already outdoor with the help of teh lecturer", DateTime.Now, new TimeSpan(18, 0, 0), address3, "Sunny");

        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("1. Lectures");
            Console.WriteLine("2. Receptions");
            Console.WriteLine("3. Outdoor Gatherings");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice 0-3: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ProcessLecture(lecture);
                    break;
                case "2":
                    ProcessReception(reception);
                    break;
                case "3":
                    ProcessOutdoorGathering(outdoorGathering);
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

    static void ProcessLecture(Lecture lecture)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("1. Standard Details");
            Console.WriteLine("2. Full Details");
            Console.WriteLine("3. Short Description");
            Console.WriteLine("0. Back");
            Console.Write("Enter your choice 0-3: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(lecture.GetStandardDetails());
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine(lecture.GetFullDetails());
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine(lecture.GetShortDescription());
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
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

    static void ProcessReception(Reception reception)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("1. Standard Details");
            Console.WriteLine("2. Full Details");
            Console.WriteLine("3. Short Description");
            Console.WriteLine("0. Back");
            Console.Write("Enter your choice 0-3: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(reception.GetStandardDetails());
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine(reception.GetFullDetails());
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine(reception.GetShortDescription());
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
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

    static void ProcessOutdoorGathering(OutdoorGathering outdoorGathering)
    {
        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("1. Standard Details");
            Console.WriteLine("2. Full Details");
            Console.WriteLine("3. Short Description");
            Console.WriteLine("0. Back");
            Console.Write("Enter your choice 0-3: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine(outdoorGathering.GetStandardDetails());
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "2":
                    Console.WriteLine(outdoorGathering.GetFullDetails());
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine(outdoorGathering.GetShortDescription());
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
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
}