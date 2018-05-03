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
            while (true) // While för att programmet inte ska stänga
            {
                Console.Clear();
                string welcomeText = "Welcome to UNF Puzlhunt \nPlease enter your password.\nPassword:\n";
                TypeLine(welcomeText);

                string answer = Console.ReadLine();

                if(answer == "QWERTY") // Läs vad Password är
                {
                    System.Threading.Thread.Sleep(3000); // Sleep för att det ska se ut som att det laddar.
                    Console.Clear();
                    string password = "Password: \n";
                    TypeLine(password);

                    string pwGuess = Console.ReadLine();
                }
                else
                {
                    wrongPassword();
                }

            }
        }

        static void wrongPassword()
        {
            Console.Clear();
            string wrongPassword = "Please try again...";
            TypeLine(wrongPassword);
            System.Threading.Thread.Sleep(3000);
        }

        static void writeASCII()
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
