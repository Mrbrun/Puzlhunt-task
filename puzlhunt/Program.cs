using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        static void mainMenu() // Första menyn för att skriva in password
        {
            // Main menu
            Console.Clear();
            string welcomeText = "Välkommen till UNF Puzlhunt \nSkriv in lösenordet.\n";
            TypeLine(welcomeText);

            string answer = Console.ReadLine();

            if (answer == "TCt3RDS9jMBe") // Läs vad Password är
            {
                firstTask();
            }
            else if(answer == "BYSOAN")
            {
                secoundTask();
            }
            else
            {
                wrongPassword();
            }


        }

        static void firstTask() // Första uppdraget med programmet. 
        {
            string secret = "Royale with Cheese";
            string secret2 = "Royale with cheese";
            string secret3 = "Royale With Cheese";
            string secret4 = "royale with cheese";
            correctPassword();

            string storyTell = "[Vincent]\nYou know what they call a Quarter Pounder with Cheese in Paris?\n[Jules]\n" +
                "They don't call it a Quarter Pounder with Cheese?\n[Vincent]\nNo, they got the metric system there, they wouldn't know what the fuck a QuarterPounder is.\n" +
                "[Jules]\nWhat'd they call it?\n[Vincent]\n";
            TypeLine(storyTell);

            // Timer
            Stopwatch aTime = new Stopwatch();
            aTime.Start();


            string answer = Console.ReadLine();
            aTime.Stop();

            int minutes = (int)aTime.Elapsed.TotalMinutes;
            double fsec = 60 * (aTime.Elapsed.TotalMinutes - minutes);
            int secSpent = (int)fsec;

            // string timeUsed = aTime.ToString();

            if (secret == answer || secret2 == answer || secret3 == answer || secret4 == answer && secSpent <= 30)
            {
                string correctString = "Correct! Good for you." + secSpent;
                Console.Clear();
                TypeLine(correctString);
                string QR1 = "▄▄▄▄▄▄▄  ▄ ▄▄ ▄▄▄▄▄▄▄";
                string QR2 = "█ ▄▄▄ █ ██ ▀▄ █ ▄▄▄ █";
                string QR3 = "█ ███ █ ▄▀ ▀▄ █ ███ █";
                string QR4 = "█▄▄▄▄▄█ █ ▄▀█ █▄▄▄▄▄█";
                string QR5 = "▄▄ ▄  ▄▄▀██▀▀ ▄▄▄ ▄▄ ";
                string QR6 = "██▄▀▀▀▄ █   ▄█▄ ▀▄▄▀█";
                string QR7 = "  ▀▄▀▀▄▄ ▀▄▀▄█▀▄▄▀ ▀▄";
                string QR8 = "▄▄▄▄▄▄▄ █▀▀▀  ▄█▄ ▄▄▀";
                string QR9 = "█ ▄▄▄ █  █▄█▀█▄█▀  ▄ ";
                string QR10 = "█ ███ █ ▀█▀▀▄  ██▄ ▀█";
                string QR11 = "█▄▄▄▄▄█ █ ▀▄▄▀▀ █▄ ▄";
                Console.WriteLine("\n" + QR1 + "\n" + QR2 + "\n" + QR3 + "\n" + QR4 + "\n" + QR5 + "\n" + QR6 + "\n" + QR7 + "\n" + QR8 + "\n" + QR9 + "\n" + QR10 + "\n" + QR11);

                simpleSleep(10000);

            }
            else if (secret == answer && secSpent >= 30)
            {
                string failString = "Sorry you need too type faster..." + secSpent;
                TypeLine(failString);
            }
            else if (secret != answer && secSpent <= 30)
            {
                string failString = "Ooops! I see a type-o!" + secSpent;
                TypeLine(failString);
            }
            else if (secret != answer && secSpent >= 30)
            {
                string failString = "Ooops! I see a type-o and you were too slow!" + secSpent;
                TypeLine(failString);
            }

        }

        static void secoundTask() // Andra uppdraget med programmet
        {
            correctPassword();
            TypeLine("");
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
