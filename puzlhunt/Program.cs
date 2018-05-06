using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;
using System.Diagnostics;
using System.Timers;

namespace puzlhunt
{
    class Program
    {
        static void simpleSleep(int msTime) { System.Threading.Thread.Sleep(msTime); } // Simpel Sleep, mest för effekt.

        static void Main(string[] args)
        {
            while (true) // While för att programmet inte ska stänga, utan börja om.
            {
                mainMenu();
            }
        }

        static void mainMenu()
        {
            // Main menu
            Console.Clear();
            string welcomeText = "Welcome to UNF Puzlhunt \nPlease enter your password.\nPassword:\n";
            TypeLine(welcomeText);

            string answer = Console.ReadLine();

            if (answer == "QWERTY") // Läs vad Password är
            {
                firstTask();
            }
            else
            {
                wrongPassword();
            }
        }
     
        static void firstTask() // Första uppdraget med programmet. 
        {
            correctPassword();
            string info = "One simple task, follow me.\n";
            string task = "hejhej";
            string newLine = "\n"; // Måste hitta en bättre lösning.
            TypeLine(info);
            simpleSleep(3000);
            Console.Clear();
            TypeLine(task);
            TypeLine(newLine); // Måste hitta en bättre lösning.

            // Timer
            Stopwatch aTime = new Stopwatch();
            aTime.Start();


            string answer = Console.ReadLine();
            aTime.Stop();

            int minutes = (int)aTime.Elapsed.TotalMinutes;
            double fsec = 60 * (aTime.Elapsed.TotalMinutes - minutes);
            int secSpent = (int)fsec;

            string timeUsed = aTime.ToString();

            if (task == answer && secSpent <= 30)
            {
                string correctString = "Correct! Good for you." + secSpent;
                Console.Clear();
                TypeLine(correctString);
                string answerTwo = Console.ReadLine();

            }
            else if(task == answer && secSpent >= 30)
            {
                string failString = "Sorry you need too type faster..." + secSpent;
                TypeLine(failString);
            }
            else if(task != answer && secSpent <= 30)
            {
                string failString = "Ooops! I see a type-o!" + secSpent;
                TypeLine(failString);
            }
            else if (task != answer && secSpent >= 30)
            {
                string failString = "Ooops! I see a type-o and you were too slow!" + secSpent;
                TypeLine(failString);
            }

        }

        static void correctPassword() // Om man skriver rätt lösenord.
        {
            simpleSleep(3000);
            Console.Clear();
            string passwordTrue = "Correct!";
            TypeLine(passwordTrue);
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
        }

        static void wrongPassword() // Om man skriver fel lösenord
        {
            Console.Clear();
            string wrongPassword = "Please try again...";
            TypeLine(wrongPassword);
            simpleSleep(3000);
        }

        static void writeASCII() // Skriver ut snygg ASCII text.
        {
            Console.WriteAscii("UNF PUZLHUNT", Color.Lime);
        }

        static void TypeLine(string line) // Skriver ut text sakta.
        {
            for (int i = 0; i < line.Length; i++)
            {
                Console.Write(line[i]);
                System.Threading.Thread.Sleep(50); // Sleep for 150 milliseconds
            }
        }
    }
}