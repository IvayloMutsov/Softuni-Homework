Console.ForegroundColor = ConsoleColor.DarkGreen;
Queue<string> customers = new Queue<string>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                Console.WriteLine($"{customers.Count} people remaining.");
                break;
            }
            else if (input == "Paid")
            {
                while (customers.Count > 0)
                {
                    Console.WriteLine(customers.Dequeue());
                }
            }
            else
            {
                customers.Enqueue(input);
            }
        }
//input.Split(" ").Select(int.Parse).ToArray();