class Program
{
    static void Main()
    {
        List<Order> orders = new List<Order>();

        bool exit = false;
        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("1. Create Order");
            Console.WriteLine("2. Display Orders");
            Console.WriteLine("0. Exit");
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CreateOrder(orders);
                    break;
                case "2":
                    DisplayOrders(orders);
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

    static void CreateOrder(List<Order> orders)
    {
        Console.WriteLine("Creating Order:");

        Console.Write("Enter customer name: ");
        string customerName = Console.ReadLine();

        Console.Write("Enter customer address - Street Address: ");
        string streetAddress = Console.ReadLine();

        Console.Write("Enter customer address - City: ");
        string city = Console.ReadLine();

        Console.Write("Enter customer address - State/Province: ");
        string stateProvince = Console.ReadLine();

        Console.Write("Enter customer address - Country: ");
        string country = Console.ReadLine();

        Address address = new Address(streetAddress, city, stateProvince, country);
        Customer customer = new Customer(customerName, address);
        Order order = new Order(customer);

        bool addProducts = true;
        while (addProducts)
        {
            Console.WriteLine("\nEnter Product Details:");

            Console.Write("Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Product ID: ");
            string productId = Console.ReadLine();

            Console.Write("Product Price: ");
            double price = double.Parse(Console.ReadLine());

            Console.Write("Product Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = new Product(productName, productId, price, quantity);
            order.AddProduct(product);

            Console.WriteLine("Product added to the order!");

            Console.Write("\nAdd another product? (Y/N): ");
            string choice = Console.ReadLine();
            addProducts = (choice.ToUpper() == "Y");
        }

        orders.Add(order);
        Console.WriteLine("\nOrder created successfully!");

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    static void DisplayOrders(List<Order> orders)
    {
        Console.Clear();
        if (orders.Count == 0)
        {
            Console.WriteLine("No orders available.");
        }
        else
        {
            Console.WriteLine("Orders:");
            foreach (Order order in orders)
            {
                Console.WriteLine(order.GetPackingLabel());
                Console.WriteLine(order.GetShippingLabel());
                Console.WriteLine("Total Price: $" + order.CalculateTotalPrice());
                Console.WriteLine("----------------------------------");
            }
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}