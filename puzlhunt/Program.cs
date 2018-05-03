using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;

namespace puzlhunt
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) // While för att programmet inte ska stänga, utan börja om.
            {
                Console.Clear();
                string welcomeText = "Welcome to UNF Puzlhunt \nPlease enter your password.\nPassword:\n";
                TypeLine(welcomeText);

                string answer = Console.ReadLine();

                if(answer == "QWERTY") // Läs vad Password är
                {
                    firstTask();
                }
                else
                {
                    wrongPassword();
                }

            }
        }

        static void firstTask() // Första uppdraget med programmet. 
        {
            correctPassword();
            string info = "Hmmmmmm?";
            TypeLine(info);
            string answer = Console.ReadLine();

        }

        static void correctPassword() // Om man skriver rätt lösenord.
        {
            System.Threading.Thread.Sleep(3000); // Sleep för att det ska se ut som att det laddar.
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
            System.Threading.Thread.Sleep(3000);
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