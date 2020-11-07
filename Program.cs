using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static string command;
        static int argument = 0;
        static Queue queue = new Queue();
        static void Main()
        {
            Dictionary<string, Action> commands = new Dictionary<string, Action>()
            {
                {"push", () => Push()},
                {"pop", () => Pop()},
                {"front", () => Front()},
                {"exit", () => Exit()},
                {"clear", () => Clear()},
                {"size", () => Size()}
            };
            while (true)
            {
                command = Console.ReadLine();
                SplitCommandAndArgument();
                if (commands.ContainsKey(command))
                    commands[command]();
                else
                    PrintError();
            }
        }

        static void Push()
        {
            queue.Push(argument);
            PrintOk();
        }

        static void Pop()
        {
            if (!queue.IsEmpty())
            {
                Console.WriteLine(queue.Pop());
            }
            else 
                PrintError();

        }

        static void Front()
        {
            if (!queue.IsEmpty())
                Console.WriteLine(queue.Front());
            else
                PrintError();
        }

        static void Clear()
        {
            queue.Clear();
            PrintOk();
        }
        static void Size() => Console.WriteLine(queue.Size);

        static void SplitCommandAndArgument()
        {
            string[] data = command.Split(new char[] { ' ' });
            command = data[0];
            if (command.Contains("push"))
            {
                argument = 0;
                int.TryParse(data[1], out argument);
            }
        }
        static void PrintError() => Console.WriteLine("error :(");
        static void PrintOk() => Console.WriteLine("Ok :)");
        static void Exit()
        {
            Console.WriteLine("bye");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
