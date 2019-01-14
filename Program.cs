using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ver2c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Putova Yulia\nIS-62\nVersion 2 (C#)");
            {
                Console.WriteLine("\n-------------------------------------\n Creating Client (default way)\n");
                // Client client1 = new Client();
                Client.name = "Yulia";
                Client.phone = "0664344157";
                Console.WriteLine("Client created (default)\n");
                Console.WriteLine( Client.phone);
                Console.WriteLine(Client.name);
                Console.WriteLine("\n-------------------------------------\n Creating Client (initialization way)\n");
                Client client2 = new Client("", "");
              /*   Console.WriteLine("\n-------------------------------------\n Creating Client (copy way)\n");
                Client client3 = new Client(client2);*/
            }
            {
                Console.WriteLine("\n-------------------------------------\n Creating Company (default way)\n");
                Company comp1 = new Company();
                Console.WriteLine("\n-------------------------------------\n Creating Company (initialization way)\n");
                Company comp2 = new Company("", 0,0,0,0);
                Console.WriteLine("\n-------------------------------------\n Creating Company (copy way)\n");
                Company comp3 = new Company(comp2);
            }
            Console.ReadKey();
        }
    }
}
