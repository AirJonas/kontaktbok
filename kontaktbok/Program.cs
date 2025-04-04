namespace kontaktbok
{
    public class Program
    {
        static List<Kontakt> kontakts = new List<Kontakt>();
        static void Main(string[] args) 
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                Console.WriteLine("=== Kontaks Bok App ===");
                Console.WriteLine("1. Legge til kontakt");
                Console.WriteLine("2. Søke kontakt");
                Console.WriteLine("3. Vise alle kontakter");
                Console.WriteLine("0. Exit");
                Console.Write("Velg en alternativ: ");
                string choice = Console.ReadLine();

                switch(choice)
                {
                    case "1":
                        AddContact();
                        break;
                    case "2":
                        SearchContact();
                        break;
                    case "3":
                        ShowContacts();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Alternativ finnes ikke. Prøv på nytt.");
                        Console.ReadLine();
                        break;
                }
            }
        }
        //bruker static for neste funksjoner fordi dem brukes bare i Program classe
        
        static void AddContact()
        {
            Console.Clear();
            Console.WriteLine("--- Legge til kontakt ---");
            Console.Write("Kontakt navn: ");
            string name = Console.ReadLine().ToLower();
            Console.Write("Kontakt telefon nummer: ");
            string phoneNumber = Console.ReadLine().ToLower();

            kontakts.Add(new Kontakt(name, phoneNumber));
            Console.WriteLine("Kotakt lagd! Press Enter til å forsette...");
            Console.ReadLine();
        }

        static void SearchContact()
        {
            Console.Clear();
            Console.WriteLine("--- Søke kontakt ---");
            Console.Write("Enter navn til å lete etter: ");
            string search = Console.ReadLine().ToLower();

            var results = kontakts.Where(contact =>  contact.Name.Contains(search)).ToList();
            if (results.Count == 0)
            {
                Console.WriteLine("ingen kontakter var funnet.");
            }
            else
            {
                Console.WriteLine("Søking resultater:");
                foreach (var contact in results)
                {
                    Console.WriteLine($"\nNavn: {contact.Name}, Telefon Num: {contact.PhoneNumber}");
                }
            }

            Console.WriteLine("Press Enter til å forsette...");
            Console.ReadLine();
        }

        static void ShowContacts()
        {
            Console.Clear();
            Console.WriteLine("--- Alle Kontakter ---");
            if (kontakts.Count == 0)
            {
                Console.WriteLine("Ingen kontakter til å vise.");
            }
            else
            {
                foreach (var contact in kontakts)
                {
                    Console.WriteLine($"\nNavn: {contact.Name}, Telefon Num: {contact.PhoneNumber}");
                }
            }
            Console.WriteLine("Press Enter til å forsette...");
            Console.ReadLine();
        }
    }
}
