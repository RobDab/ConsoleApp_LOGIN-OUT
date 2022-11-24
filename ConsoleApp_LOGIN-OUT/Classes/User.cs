using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_LOGIN_OUT.Classes
{
    internal static class User
    {
        public static string Username;

        public static string Password;

        public static bool isLogged = false;

        public static DateTime Log;

        public static List<DateTime> AccessLog = new List<DateTime>();



        //METHODS ------
        public static void Login()
        {
            do
            {
                Console.WriteLine("Inserisci Username: _");
                Username = Console.ReadLine();
                if (Username == "")
                {
                    Console.WriteLine("Inserisci uno Username valida");
                }
            } while (Username == "");
            do
            {
                string psw1;
                string psw2;
                Password = "";

                Console.WriteLine("Inserisci Password _ ");
                psw1 = Console.ReadLine();
                Console.WriteLine("Conferma Password _ ");
                psw2 = Console.ReadLine();
                
                if(psw1 == psw2 && psw1!= "")
                {
                    Password = psw1;
                    isLogged = true;
                    Log = DateTime.Now;
                    AccessLog.Add(Log);
                }
                else
                {
                    Console.WriteLine("Inserisci password uguali NON vuote! clicca 'INVIO'");
                    Console.ReadLine();
                }
            } while (Password == "");
        }

        public static void Logout()
        {
            
            if (isLogged)
            {
                Console.WriteLine("***** See you soon! :D *****");
                Username = null;
                Password = null;
                isLogged = false;
                
            }
            else
            {
                Console.WriteLine("There is no loggged User. LogIn to start! Click on 'Enter'");
                
                
            }
            
            
        }

        public static void DisplayLog()
        {
            Console.WriteLine("\n<><><><><><><><><><><>");
            Console.WriteLine($"Current Log: {Log.ToLocalTime().ToString()}");
            Console.WriteLine($"User: {Username}");
            Console.WriteLine("\n<><><><><><><><><><><>");
        }

        public static void DisplayAccessLog()
        {
            Console.WriteLine("\n<><><><><><><><><><><>");
            foreach (DateTime log in AccessLog)
            {
                Console.WriteLine($"\n< {log.ToLocalTime().ToString()} >");
            }
            Console.WriteLine("\n<><><><><><><><><><><>");
        }
    }
}
