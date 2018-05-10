using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
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
            string secret = "Cheese";
            correctPassword();
            string info = "\n";
            string vincent = "[Vincent]";
            string jules = "[Jules]";
            string task1 = "You know what they call a Quarter Pounder with Cheese in Paris?";
            string task2 = "They don't call it a Quarter Pounder with Cheese?";
            string task3 = "No, they got the metric system there, they wouldn't know what the fuck a Quarter Pounder is.";
            string task4 = "What'd they call it?";
            string task5 = "They call it Royale with Cheese.";
            string task6 = "Royale with Cheese..";
            string newLine = "\n"; // Måste hitta en bättre lösning.
            TypeLine(info);
            simpleSleep(3000);
            Console.Clear();
            TypeLine(vincent);
            TypeLine(newLine);
            TypeLine(task1);
            TypeLine(newLine); // Måste hitta en bättre lösning.

            simpleSleep(500);

            TypeLine(jules);
            TypeLine(newLine);
            TypeLine(task2);
            TypeLine(newLine);

            simpleSleep(500);

            TypeLine(vincent);
            TypeLine(newLine);
            TypeLine(task3);
            TypeLine(newLine);

            simpleSleep(500);

            TypeLine(jules);
            TypeLine(newLine);
            TypeLine(task4);
            TypeLine(newLine);

            simpleSleep(500);

            TypeLine(vincent);
            TypeLine(newLine);
            TypeLine(task5);
            TypeLine(newLine);

            simpleSleep(500);

            TypeLine(jules);
            TypeLine(newLine);
            TypeLine(task6);
            TypeLine(newLine);

            // Timer
            Stopwatch aTime = new Stopwatch();
            aTime.Start();


            string answer = Console.ReadLine();
            aTime.Stop();

            int minutes = (int)aTime.Elapsed.TotalMinutes;
            double fsec = 60 * (aTime.Elapsed.TotalMinutes - minutes);
            int secSpent = (int)fsec;

            string timeUsed = aTime.ToString();

            if (secret == answer && secSpent <= 30)
            {
                string correctString = "Correct! Good for you." + secSpent;
                Console.Clear();
                TypeLine(correctString);
                string QR1 = "█▀▀▀▀▀█ ▄ ▀▀▄ █▀▀▀▀▀█";
                string QR2 = "█ ███ █ █   █ █ ███ █";
                string QR3 = "█ ▀▀▀ █ █ █▀▀ █ ▀▀▀ █";
                string QR4 = "▀▀▀▀▀▀▀ ▀ ▀ ▀ ▀▀▀▀▀▀▀";
                string QR5 = "  ▀▄▄█▀█████▄▀▄▀▀█▀▀▄";
                string QR6 = "▀█▄█▀ ▀▀▄ ▀▄▀▄▀ ▄▄▀ █";
                string QR7 = "▀▀▀   ▀▀▄▄▀▀██ ▄   ▄▀";
                string QR8 = "█▀▀▀▀▀█ ██▀▀█▀▄█▀▀  ▀";
                string QR9 = "█ ███ █   ▀▄▄█▄▀▀   ▀";
                string QR10 = "█ ▀▀▀ █ ▀█▄ ▄▀█ ▄ ▀▀▀";
                string QR11 = "▀▀▀▀▀▀▀   ▀▀  ▀  ▀▀ ▀";
                Console.WriteLine("\n" + QR1 + "\n" + QR2 + "\n" + QR3 + "\n" + QR4 + "\n" + QR5 + "\n" + QR6 + "\n" + QR7 + "\n" + QR8 + "\n" + QR9 + "\n" + QR10 + "\n" + QR11);

                simpleSleep(10000);

            }
            else if(task1 == answer && secSpent >= 30)
            {
                string failString = "Sorry you need too type faster..." + secSpent;
                TypeLine(failString);
            }
            else if(task1 != answer && secSpent <= 30)
            {
                string failString = "Ooops! I see a type-o!" + secSpent;
                TypeLine(failString);
            }
            else if (task1 != answer && secSpent >= 30)
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