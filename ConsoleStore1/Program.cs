using System;
using ConsoleStore1;

class MainProgram
{
    public static void Main()
    {
        ConsoleStore1.ManageProduct.InsertNewProduct newProduct = new ConsoleStore1.ManageProduct.InsertNewProduct();
        Console.WriteLine(@"
▒██   ██▒█     █▓█████ ██▓    ▄████▄  ▒█████  ███▄ ▄███▓█████▒██   ██▒
▒▒ █ █ ▒▓█░ █ ░█▓█   ▀▓██▒   ▒██▀ ▀█ ▒██▒  ██▓██▒▀█▀ ██▓█   ▀▒▒ █ █ ▒░
░░  █   ▒█░ █ ░█▒███  ▒██░   ▒▓█    ▄▒██░  ██▓██    ▓██▒███  ░░  █   ░
 ░ █ █ ▒░█░ █ ░█▒▓█  ▄▒██░   ▒▓▓▄ ▄██▒██   ██▒██    ▒██▒▓█  ▄ ░ █ █ ▒ 
▒██▒ ▒██░░██▒██▓░▒████░██████▒ ▓███▀ ░ ████▓▒▒██▒   ░██░▒████▒██▒ ▒██▒
▒▒ ░ ░▓ ░ ▓░▒ ▒ ░░ ▒░ ░ ▒░▓  ░ ░▒ ▒  ░ ▒░▒░▒░░ ▒░   ░  ░░ ▒░ ▒▒ ░ ░▓ ░
░░   ░▒ ░ ▒ ░ ░  ░ ░  ░ ░ ▒  ░ ░  ▒    ░ ▒ ▒░░  ░      ░░ ░  ░░   ░▒ ░
 ░    ░   ░   ░    ░    ░ ░  ░       ░ ░ ░ ▒ ░      ░     ░   ░    ░  
 ░    ░     ░      ░  ░   ░  ░ ░         ░ ░        ░     ░  ░░    ░  
                             ░                                        
");
        int limit = 3;
        for (int i = 0; i < limit; i++)
        {
            Console.Write("Enter Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Product Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Product Price: ");
            if (int.TryParse(Console.ReadLine(), out int price))
            {
                newProduct.InsertData(name, description, price);
            }
            else
            {
                Console.WriteLine("Invalid price. Please enter a valid number.");
                i--;
            }
        }
    }
}
//GROUP LEADER: CONCEPCION, DEAN UZAIH C.
//MEMBERS: SABELARIO, SHAN GABRIEL/OBANDO, ZYRILL/ BOCARILE, ENOC/ ORCAJADA, ANJOE/ BALUCA, JHON RAY/ BAYSON, MAR ELVIS/ VALERIO, PSALM EMMANUEL