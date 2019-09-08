using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouse_ClassLibrary
{
    public class Goods
    {
        public Goods(string name, double price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public virtual int ExpirationDate { get; set; }

        public DateTime ExpiredDate(DateTime expirationDate)
        {
            return expirationDate.AddDays(ExpirationDate);
        }
    }
}
