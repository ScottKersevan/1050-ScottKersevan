
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleReadPasswords
{

    class PasswordExample
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your Login ID");
            var loginid = Console.ReadLine();
            Console.WriteLine("Please enter your Password");
            var password = ReadPassword();

            Console.Write("Your Password is:" + password);
            Console.ReadLine();
        }


        public static string ReadPassword()
        {
            string password = "";
            ConsoleKeyInfo info = Console.ReadKey(true);
            while (info.Key != ConsoleKey.Enter)
            {
                if (info.Key != ConsoleKey.Backspace)
                {
                    Console.Write("*");
                    password += info.KeyChar;
                }
                else if (info.Key == ConsoleKey.Backspace)
                {
                    if (!string.IsNullOrEmpty(password))
                    {

                        password = password.Substring(0, password.Length - 1);

                        int pos = Console.CursorLeft;

                        Console.SetCursorPosition(pos - 1, Console.CursorTop);

                        Console.Write(" ");

                        Console.SetCursorPosition(pos - 1, Console.CursorTop);

                    }
                }
                info = Console.ReadKey(true);
            }

#pragma warning disable CS0162 // Unreachable code detected
            var x = 6;
#pragma warning restore CS0162 // Unreachable code detected
            var y = 3;
            var z = 72;
            int result = (x + y) * (z + 10);
            Console.Write("var x = 6 \n var y = 3 \n var z = 72 \n");
            Console.WriteLine("(x + y) * (z + 10)=\n"); 
            
            Console.Write(result); Console.WriteLine("\n");
                       { Console.WriteLine("Hello \t World!"); }
            { Console.WriteLine("Hello \n World"); }
            { Console.WriteLine("Hello World!"); }
            { Console.WriteLine("Hello\\World!"); }
            return password;
#pragma warning disable CS0162 // Unreachable code detected
            
#pragma warning restore CS0162 // Unreachable code detected
        }
        
    }
}
