using Refrence_Book_Application;
using System;

namespace Refrence_Book_Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            do
            {
                Console.WriteLine("Welcome Refrence Book Application");
                Console.WriteLine("1. Add New Contact");
                Console.WriteLine("2. Show details of Contact");
                Console.WriteLine("3. Edit a contact");
                Console.WriteLine("4. Delete a Contact");
                Console.WriteLine("5. View all contacts for a state or city");
                Console.WriteLine("6. Get count of contacts");
                Console.WriteLine("7. Exit");
                Console.WriteLine("Enter your choice");

                ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        User user = new User();
                        user.UserInput();
                        break;

                    case 2:
                        User u2 = new User();
                        u2.UserDetails();
                        break;

                    case 3:
                        User u3 = new User();
                        u3.Modify();
                        break;

                    case 4:
                        User u4 = new User();
                        u4.Delete();
                        break;

                }
            }
            while (ch != 7);

        }
    }
}