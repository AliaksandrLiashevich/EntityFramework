using Entity_Framework.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCLI
{
    class Program
    {
        static void Main(string[] args)
        {
            DbPrinter printer = new DbPrinter(new Service(new Entity_Framework.Context.AppDbContext()));

            printer.PrintFullCustomersData();

            Console.ReadKey();
        }
    }
}
