using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab14_WpfApp
{
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public Category Category { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
    public enum Category
    {
        Food,
        Appliance
    }
   
}
