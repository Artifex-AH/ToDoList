
namespace ToDoList;

class Program
{
    static void Main(string[] args)
    {
        List<string> taskList = new List<string>();
        string option = "";

        Console.WriteLine("=== To-Do List ===");
        Console.WriteLine("Welcome to your To-Do List!");

        while (option != "4")
        {
            Console.WriteLine("\nWhat would you like to do?");
            Console.WriteLine("1. Add a task");
            Console.WriteLine("2. Remove a task");
            Console.WriteLine("3. View all tasks");
            Console.WriteLine("4. Exit");
            Console.Write("\nChoose an option: ");

            option = Console.ReadLine() ?? "";

            if (option == "1")
            {
                Console.Write("\nEnter task name: ");
                string task = Console.ReadLine() ?? "";

                if (string.IsNullOrWhiteSpace(task))
                {
                    Console.WriteLine("Task name cannot be empty.");
                }
                else
                {
                    taskList.Add(task.Trim());
                    Console.WriteLine("Task added successfully!");
                }
            }
            else if (option == "2")
            {
                if (taskList.Count == 0)
                {
                    Console.WriteLine("\nYour task list is empty.");
                    continue;
                }

                Console.WriteLine("\nYour tasks:");

                for (int i = 0; i < taskList.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {taskList[i]}");
                }

                Console.Write("\nEnter task number to remove: ");

                if (int.TryParse(Console.ReadLine(), out int taskNumber)
                    && taskNumber >= 1
                    && taskNumber <= taskList.Count)
                {
                    taskList.RemoveAt(taskNumber - 1);
                    Console.WriteLine("Task removed successfully!");
                }
                else
                {
                    Console.WriteLine("Invalid task number.");
                }
            }
            else if (option == "3")
            {
                if (taskList.Count == 0)
                {
                    Console.WriteLine("\nYour task list is empty.");
                }
                else
                {
                    Console.WriteLine("\nYour tasks:");

                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {taskList[i]}");
                    }
                }
            }
            else if (option == "4")
            {
                Console.WriteLine("\nGoodbye!");
            }
            else
            {
                Console.WriteLine("\nInvalid option. Please try again.");
            }
        }
    }
}
