using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace regedit_cleaner
{
    class Program
    {
        static void setPosition(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }

        static void Main(string[] args)
        {
            // disabling some useless things. (like resize and maximize window)
            IntPtr handle = interops.GetSystemMenu(interops.GetConsoleWindow(), false);
            if(handle != null)
            {
                interops.DeleteMenu(handle, interops.SC_MAXIMIZE, interops.MF_BYCOMMAND);
                interops.DeleteMenu(handle, interops.SC_SIZE, interops.MF_BYCOMMAND);
            }

            Console.Title = " github.com/byyyxd ";
            Console.WindowHeight = 15;
            Console.BufferHeight = 15;
            Console.WindowWidth = 60;
            Console.BufferWidth = 60;

            setPosition(7, 5);
            Console.Write("- Welcome to the alternative regedit cleaner.");
            setPosition(23, 6);
            Console.Write(" - " + Environment.UserName);

            setPosition(11, 10);
            Console.Write(" Press any button to start cleaning. ");

            Console.ReadKey();

            if(yeap.Clean_Regedit())
            {
                Console.Clear();
                setPosition(3, 3);
                Console.Write(" All regedits cleaned with sucess.");
            } else
            {
                Console.Clear();
                setPosition(3, 4);
                Console.Write(" An error occured while deleting regedits.");
            }

            Console.Write("\n\n     ps: if you already used it and \n     got any error\n     this error means that it" +
                            "   couldn't find the path\n     selected, so it's not an error.\n     it just" +
                            " couldn't find cuz it already got deleted. ;)");

            Console.ReadLine();
        }
    }
}
