public class ToDoList
{

    public static string[] tasks = new string[10];
    public static int taskCount = 0;

   public static void AddTask()
    {
        Console.WriteLine("Enter a new task:");
        tasks[taskCount] = Console.ReadLine();
        taskCount++;
    }

    public static void ViewTasks()
    {
        for (int i = 0; i < taskCount; i++)
        {
            Console.WriteLine((i + 1) + ". " + tasks[i]);
        }
    }

    public static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    ViewTasks();
                    break;
                case "3":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}