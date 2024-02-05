using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refrence_Book_Application
{
    public class User
    {
        static List<Class1> users = new List<Class1>();
        static void listadd(Class1 obj)
        {
            users.Add(obj);
        }

        public void UserInput()
        {
            Console.WriteLine("Enter a Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a Email");
            string email = Console.ReadLine();
            Console.WriteLine("Enter a City");
            string city = Console.ReadLine();
            Console.WriteLine("Enter a State");
            string state = Console.ReadLine();
            Console.WriteLine("Enter a Zip Code");
            int zip = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a Contact");
            long contact = Convert.ToInt64(Console.ReadLine());

            Class1 c1 = new Class1(name, email, city, state, zip, contact);

            listadd(c1);

        }
        public void UserDetails()
        {
            long contact2;
            Console.WriteLine("Enter Contact Details");
            contact2 = Convert.ToInt64(Console.ReadLine());

            for (int i = 0; i < users.Count; i++)
            {

                if (users[i].contact == contact2)
                {
                    Console.WriteLine($" User Details :");
                    Console.WriteLine($" User name : {users[i].name}");
                    Console.WriteLine($" User contact : {users[i].contact} ");
                    Console.WriteLine($" User email : {users[i].email}");
                    Console.WriteLine($" User city : {users[i].city}");
                    Console.WriteLine($" User state : {users[i].state}");
                    Console.WriteLine($" User zip : {users[i].zip}");
                }
            }
        }
        public void Modify()
        {
            long contact2;
            Console.WriteLine("Enter a contact Details");
            contact2 = Convert.ToInt64(Console.ReadLine());

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].contact == contact2)
                {
                    int choice;
                    do
                    {
                        // int choice;
                        Console.WriteLine("select you're choice");
                        Console.WriteLine("1.Edit Name");
                        Console.WriteLine("2.Edit Email");
                        Console.WriteLine("3.Edit City");
                        Console.WriteLine("4.Edit state");
                        Console.WriteLine("5.Edit Zip");
                        Console.WriteLine("6.Edit Contact");
                        Console.WriteLine("7. Exit");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("previous name=" + users[i].name);
                                users[i].name = Console.ReadLine();
                                Console.WriteLine("updated name=" + users[i].name);
                                break;

                            case 2:
                                Console.WriteLine("previous Email" + users[i].email);
                                users[i].email = Console.ReadLine();
                                Console.WriteLine("Updated Email=" + users[i].email);
                                break;

                            case 3:
                                Console.WriteLine("previous city=" + users[i].city);
                                users[i].city = Console.ReadLine();
                                Console.WriteLine("updated city=" + users[i].city);
                                break;

                            case 4:
                                Console.WriteLine("previous state=" + users[i].state);
                                users[i].state = Console.ReadLine();
                                Console.WriteLine("updated state=" + users[i].state);
                                break;

                            case 5:
                                Console.WriteLine("previous zip=" + users[i].zip);
                                users[i].zip = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Updated zip=" + users[i].zip);
                                break;

                            case 6:
                                Console.WriteLine("Previous Contact=" + users[i].contact);
                                users[i].contact = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Updated Contact=" + users[i].contact);
                                break;

                            default:
                                Console.WriteLine("Invalid choice");
                                break;


                        }


                    }
                    while (choice != 7);
                }
            }



        }
        public void Delete()
        {
            long contact2;
            Console.WriteLine("Enter a Contact");
            contact2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < users.Count; i++)
            {
                if (users[i].contact == contact2)
                {
                    users.RemoveAt(i);
                }
            }
        }
    }
}
