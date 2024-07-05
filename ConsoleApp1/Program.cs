namespace ConsoleApp1
{
    public class PhoneBook
    {
        private Dictionary<string, string> _phoneBook;

        public PhoneBook()
        {
            _phoneBook = new Dictionary<string, string>();
        }

        public void AddEntry(string name, string phoneNumber)
        {
            if (!_phoneBook.ContainsKey(name))
            {
                _phoneBook.Add(name, phoneNumber);
                Console.WriteLine($"Entry for {name} added successfully.");
            }
            else
            {
                Console.WriteLine($"Entry for {name} already exists.");
            }
        }

        public void UpdateEntry(string name, string newPhoneNumber)
        {
            if (_phoneBook.ContainsKey(name))
            {
                _phoneBook[name] = newPhoneNumber;
                Console.WriteLine($"Entry for {name} updated successfully.");
            }
            else
            {
                Console.WriteLine($"Entry for {name} not found.");
            }
        }

        public string SearchEntry(string name)
        {
            if (_phoneBook.ContainsKey(name))
            {
                return $"Phone number for {name}: {_phoneBook[name]}";
            }
            else
            {
                return $"Entry for {name} not found.";
            }
        }

        public void DeleteEntry(string name)
        {
            if (_phoneBook.ContainsKey(name))
            {
                _phoneBook.Remove(name);
                Console.WriteLine($"Entry for {name} deleted successfully.");
            }
            else
            {
                Console.WriteLine($"Entry for {name} not found.");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PhoneBook phoneBook = new PhoneBook();
            while (true)
            {
                Console.WriteLine("Phone Book Menu:");
                Console.WriteLine("1. Add Entry");
                Console.WriteLine("2. Update Entry");
                Console.WriteLine("3. Search Entry");
                Console.WriteLine("4. Delete Entry");
                Console.WriteLine("5. Exit");
                Console.Write("Choose an option: ");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Write("Enter name: ");
                        string nameToAdd = Console.ReadLine();
                        Console.Write("Enter phone number: ");
                        string phoneNumberToAdd = Console.ReadLine();
                        phoneBook.AddEntry(nameToAdd, phoneNumberToAdd);
                        break;
                    case "2":
                        Console.Write("Enter name: ");
                        string nameToUpdate = Console.ReadLine();
                        Console.Write("Enter new phone number: ");
                        string newPhoneNumber = Console.ReadLine();
                        phoneBook.UpdateEntry(nameToUpdate, newPhoneNumber);
                        break;
                    case "3":
                        Console.Write("Enter name: ");
                        string nameToSearch = Console.ReadLine();
                        Console.WriteLine(phoneBook.SearchEntry(nameToSearch));
                        break;
                    case "4":
                        Console.Write("Enter name: ");
                        string nameToDelete = Console.ReadLine();
                        phoneBook.DeleteEntry(nameToDelete);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}