using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse_ClassLibrary
{
    public class Wire : Goods
    {
        public Wire(string name, double price) : base(name, price)
        {            
        }

        public override int ExpirationDate { get; set; } = 3;
    }
}
