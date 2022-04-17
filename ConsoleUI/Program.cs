using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.Model;
namespace ConsoleUI
{
    class Program
    {   private static List<GuestModel> guests = new List<GuestModel>();
        static void Main(string[] args)
        {

            GetGuestInfo();
            PrintGuestsInfo();

            Console.ReadLine();
        }

        private static void GetGuestInfo()
        {
                string answer;
            do
            {
                GuestModel guest = new GuestModel();

                guest.FirstName = MessageToConsoleString("What is your first name: ");

                guest.LastName = MessageToConsoleString("What is your last name: ");

                guest.MessageToHost = MessageToConsoleString("What is your message to host: ");

                guest.Age = MessageToConsoleInt("What is your age: ");

                guest.RedPocket = MessageToConsoleDouble("How much is your Red Pocket: ");

                guests.Add(guest);

                answer = MessageToConsoleString("Are there any more guests?(yes or no): ");

                Console.Clear();

            } while (answer.ToLower() == "yes");
        }

        private static void PrintGuestsInfo()
        {
            foreach (GuestModel guest in guests)
            {
                Console.WriteLine($"Guest {guest.FirstName} {guest.LastName} said: {guest.MessageToHost} to the host. ");
                Console.WriteLine($"Guest is {guest.Age} years old. The Guest gave {guest.RedPocket} red pocket to the host!");
            }
        }
        private static int MessageToConsoleInt(string message)
        {
            
            int output;
            Console.Write(message);
            string input = Console.ReadLine();

            while (!int.TryParse(input, out output))
            {
                Console.WriteLine("Input must be an integer..");
                Console.Write("Please try again now with an integer: ");
                input = Console.ReadLine();
            }
            return output;
        }
        private static double MessageToConsoleDouble(string message)
        {
            double output;
            Console.Write(message);
            string input = Console.ReadLine();
            while (!double.TryParse(input, out output))
            {
                Console.WriteLine("Input must be a number: ");
                Console.Write("Please try again now with a number: ");
                input= Console.ReadLine();
            }
            return output;
        }
        private static string MessageToConsoleString(string message)
        {
            string output;
            Console.Write(message);
            output = Console.ReadLine();
            return output;
        }

    }
}
