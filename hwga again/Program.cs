using System.Security.Cryptography;

namespace hwga_again;

internal class Program
{
    static List<string> list = new List<string>();
    static bool run= true;
    static void Main(string[] args)
    {
        while (run)
        {
            WriteMenu();
            
        }
    }
    static void WriteMenu()
    {
        Console.WriteLine("\n--- MENÜ ---");
        Console.WriteLine("list   - Kilistazza a lista elemeit");
        Console.WriteLine("add    - Hozzaad egy uj elemet a listahoz");
        Console.WriteLine("clear  - Kitörli a lista összes elemet");
        Console.WriteLine("remove - Kitöröl egy megadott elemet");
        Console.WriteLine("exit   - Kilep az alkalmazasbol");
        Console.Write("Valassz menupontot: ");
        SwitchList();
    }
    static void SwitchList()
    {
        string parancs = Console.ReadLine()?.Trim().ToLower();
        switch (parancs)
        {
            case "list":
                listt();
                break;
            case "add":
                add();
                break;
            case "clear":
                clear();
                break;
            case "remove":
                remove();
                break;

            case "exit":
                exit();
                break;
            default:
                Console.WriteLine("Hibas menupont, probald ujra!");
                break;

        }
    }
    static void listt() 
    {
        Console.WriteLine(String.Join('\n', list));
        if (list.Count == 0)
        {
            Console.WriteLine("A lista ures");
        }
    }
    static void add() 
    {
        Console.WriteLine("Adj meg egy szoveget: ");
        string line = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(line))
        {
            list.Add(line);
            Console.WriteLine($"{line} hozzaadva a listahoz.");

        }
        else
        {
            Console.WriteLine("Nem adtal meg ervenyes szoveget");
        }
    }
    static void clear() 
    {
        list.Clear();
        Console.WriteLine("A lista kiuritve.");
    }
    static void remove() 
    {
        Console.Write("Melyik elemet szeretned torolni?: ");
        string deleted = Console.ReadLine();
        if (list.Remove(deleted))
        {
            Console.WriteLine($"\"{deleted}\" torolve lett a listabol");
        }
        else
        {
            Console.WriteLine("Ilyen elem nincs a listaban");
        }
    }
    static void exit() 
    {
        run = false;
        Console.WriteLine("Kilepes");
    }
}
