using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for operations taking user inputs
            Console.WriteLine("hello from the consele phoneBook app");
            Console.WriteLine("select operationn");
            Console.WriteLine("1 add contact");
            Console.WriteLine("2 Display contact by number");
            Console.WriteLine("3 view all contacts");
            Console.WriteLine("4 search for contacts for a given name");
            Console.WriteLine("press x to exit");

            var userInput = Console.ReadLine();
            var PhoneBook = new PhoneBook();    // creating object of phonebook

            while (true) //
            {
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("contact name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("contact number:");
                        var number = Console.ReadLine();

                        var newContact = new Contact(name, number);
                        PhoneBook.AddContact(newContact);
                        break;

                    case "2":
                        Console.WriteLine("contact num to search");
                        var SearchNumber = Console.ReadLine();
                        PhoneBook.DisplayContact(SearchNumber);
                        break;

                    case "3": // to display all contact
                        PhoneBook.DisplayAllContact();
                        break;

                    case "4": // to search for a contact for a given name
                        Console.WriteLine("Name search phrase");
                        var searchPhrase= Console.ReadLine();   // to get value from user
                        PhoneBook.DisplayMatchingContacts(searchPhrase);
                        break;
                    case "x":
                        return;

                    default:
                        Console.WriteLine("select valid option");
                        break;
                }
                Console.WriteLine("select option");
                userInput = Console.ReadLine(); 

            }
            }
        }
    }
