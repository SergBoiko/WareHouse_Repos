using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse_ClassLibrary
{
    public class Warehouse
    {
        public List<Goods> Products;

        public Warehouse(int capacity)
        {
            Products = new List<Goods>();
            this.Capacity = capacity;            
        }

        public int Capacity { get; set; }
    }
}
