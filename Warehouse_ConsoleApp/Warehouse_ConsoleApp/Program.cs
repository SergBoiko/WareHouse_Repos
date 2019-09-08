using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WareHouse_ClassLibrary;

namespace Warehouse_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var wareHouse = new Warehouse(5);
            var sand = new Sand("Pesok", 300);
            var wire = new Wire("Metal", 100);

            wareHouse.Products.Add(sand);
            wareHouse.Products.Add(wire);

            foreach(Goods good in wareHouse.Products)
            {
                Console.WriteLine(good.ExpiredDate(DateTime.Now));
            }
            Console.ReadKey();
        }
    }
}
