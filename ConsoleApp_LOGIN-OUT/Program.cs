using ConsoleApp_LOGIN_OUT.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_LOGIN_OUT
{
    internal class Program
    {

        static void Main(string[] args)
        {


            Console.WriteLine("-* BENVENUTO *-");
            DisplayMenu();


        }


        public static void DisplayMenu()
        {
            string Input;
            Console.WriteLine("\nScegli un'operazione tra le seguenti:");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Logout");
            Console.WriteLine("3. Ora e Data Accesso");
            Console.WriteLine("4. Access Log");
            Console.WriteLine("q. *Quit session*");

            do
            {

                Input = Console.ReadLine();
                if (
                    Input != "1"
                && Input != "2"
                && Input != "3"
                && Input != "4"
                && Input != "q"

                    )
                {
                    Console.WriteLine("Inserisci una delle opzioni elencate e riprova.");
                };
            }while (
                   Input != "1"
                && Input != "2"
                && Input != "3"
                && Input != "4"
                && Input != "q"
                );



            switch (Input)
            {
                case "1":
                    if (!User.isLogged)
                    {
                        User.Login();

                    }
                    else
                    {
                        Console.WriteLine("Already Logged-in!");
                    }
                    break;
                case "2":
                    User.Logout();

                    break;

                case "3":


                    if (User.isLogged)
                    {
                        User.DisplayLog();
                    }
                    else
                    {
                        Console.WriteLine("There is no loggged User. LogIn to start! Click 'Enter'");

                    }

                    break;

                case "4":
                    // creare metodo in user per display access log
                    User.DisplayAccessLog();

                    break;
                case "q":
                    Console.WriteLine("\n*** Come back soon!! >_<'\n" +
                        "'enter' to quit.");

                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
            }
            
            DisplayMenu();
        }

    }   
}
