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
            else if(answer == "BYSOAN" || answer == "bysoan")
            {
                secoundTask();
            }
            else if(answer == "asdf" || answer == "ASDF" || answer == "QWERTY" || answer == "qwerty")
            {
                thirdTask();
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

                string QR1 = "▄▄▄▄▄▄▄ ▄▄  ▄ ▄▄▄▄▄▄▄";
                string QR2 = "█ ▄▄▄ █ ▄▀▄ █ █ ▄▄▄ █";
                string QR3 = "█ ███ █ █▄▄▀  █ ███ █";
                string QR4 = "█▄▄▄▄▄█ ▄ ▄ ▄ █▄▄▄▄▄█";
                string QR5 = "▄▄▄▄  ▄ ▄▀█  ▄  ▄▄▄ ▄";
                string QR6 = "█▀▄ █▀▄▄ █▄ ██▄█▀▀▀▄█";
                string QR7 = " ▄ ▀▄▀▄█▀█▄▄▀█▄  ▀ ▀▀";
                string QR8 = "▄▄▄▄▄▄▄ ▀ ▀  ▄▀▄█▄   ";
                string QR9 = "█ ▄▄▄ █  ▄ █▀▄   ██ ▀";
                string QR10 = "█ ███ █ █ ▄▄ ▀▄  ▀ ▀ ";
                string QR11 = "█▄▄▄▄▄█ █  ██▄▀▀█ ▄ ▀";

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
            TypeLine("Sorry Las, inge BYSOAN skit här inte. ;)");
            simpleSleep(3000);

        }

        static void thirdTask()
        {
            Console.Clear();
            string one1 = "__________████████_____██████";
            string one2 = "_________█░░░░░░░░██_██░░░░░░█";
            string one3 = "________█░░░░░░░░░░░█░░░░░░░░░█";
            string one4 = "_______█░░░░░░░███░░░█░░░░░░░░░█";
            string one5 = "_______█░░░░░░░███░░░█░░░░░░░░░█";
            string one6 = "______█░░░██░░░░░░░░███░██░░░░██";
            string one7 = "_____█░░░░░░░░░░░░░░░░░█░░░░░░░░███";
            string one8 = "____█░░░░░░░░░░░░░██████░░░░░████░░█";
            string one9= "____█░░░░░░░░░█████░░░████░░██░░██░░█";
            string one10 = "___██░░░░░░░███░░░░░░░░░░█░░░░░░░░███";
            string one11 = "__█░░░░░░░░░░░░░░█████████░░█████████";
            string one12 = "_█░░░░░░░░░░█████_████___████_█████___█";
            string one13 = "_█░░░░░░░░░░█______█_███__█_____███_█___█";
            string one14 = "█░░░░░░░░░░░░█___████_████____██_██████";
            string one15 = "░░░░░░░░░░░░░█████████░░░████████░░░█";
            string one16 = "░░░░░░░░░░░░░░░░█░░░░░█░░░░░░░░░░░░█";
            string one17 = "░░░░░░░░░░░░░░░░░░░░██░░░░█░░░░░░██";
            string one18 = "░░░░░░░░░░░░░░░░░░░░██░░░░█░░░░░░██";
            string one19 = "░░░░░░░░░░░░░░░░██░░░░░░░░░░█░░░░░█";
            string one20 = "░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█";
            string one21 = "░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█";
            string one22 = "░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█";
            string one23 = "░░░░░░░░░░░█████████░░░░░░░░░░░░░░██";
            string one24 = "░░░░░░░░░░█▒▒▒▒▒▒▒▒███████████████▒▒█";
            string one25 = "░░░░░░░░░█▒▒███████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█";
            string one26 = "░░░░░░░░░█▒▒▒▒▒▒▒▒▒█████████████████";
            string one27 = "░░░░░░░░░░████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█";
            string one28 = "░░░░░░░░░░████████▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒█";
            string one29 = "░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░█";
            string one30 = "██░░░░░░░░░░░░░░░░░░░░░░░░░░░██";
            string one31 = "▓██░░░░░░░░░░░░░░░░░░░░░░░░██";
            string one32 = "▓▓▓███░░░░░░░░░░░░░░░░░░░░█";
            string one33 = "▓▓▓▓▓▓███░░░░░░░░░░░░░░░██";
            string one34 = "▓▓▓▓▓▓▓▓▓███████████████▓▓█";
            string one35 = "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██";
            string one36 = "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓██";
            string one37 = "▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓█";

            Console.WriteLine("\n" + one1 + "\n" + one2 + "\n" + one3 + "\n" + one4 + "\n" + one5 + "\n" + one6 + "\n" + one7 + "\n" + one8 + "\n" + one9 + "\n" + one10 + "\n" + one11 + "\n" + one12 + "\n" + one13 + "\n" + one14 + "\n" + one15 + "\n" + one16 + "\n" + one17 + "\n" + one18 + "\n" + one19 + "\n" + one20 + "\n" + one21 + "\n" + one22 + "\n" + one23 + "\n" + one24 + "\n" + one25 + "\n" + one26 + "\n" + one27 + "\n" + one28 + "\n" + one29 + "\n" + one30 + "\n" + one31 + "\n" + one32 + "\n" + one33 + "\n" + one34 + "\n" + one35 + "\n" + one36 + "\n" + one37);
            TypeLine("Wrong password, FeelsBadMan");
            simpleSleep(10000);
        }

        static void correctPassword() // Om man skriver rätt lösenord.
        {
            simpleSleep(3000);
            Console.Clear();
            string passwordTrue = "Rätt!";
            TypeLine(passwordTrue);
            System.Threading.Thread.Sleep(1500);
            Console.Clear();
        }

        static void wrongPassword() // Om man skriver fel lösenord
        {
            Console.Clear();
            string wrongPassword = "Försök igen...";
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
