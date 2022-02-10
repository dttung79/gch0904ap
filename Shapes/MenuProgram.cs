using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class MenuProgram
    {
        protected const int QUIT = 0;
        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = GetChoice();
                DoTask(choice);
                if (choice == QUIT) running = false;
            }
        }
        protected virtual int GetChoice()
        {
            System.Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        protected abstract void PrintMenu();
        protected abstract void DoTask(int choice);
    }
}