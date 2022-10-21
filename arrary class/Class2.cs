using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrary_class
{
    public class Product
    {
        private int id;
        private string name;    
        public Product(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public override string ToString()
        {
            return $"{id} {name}";
        }
    }
    public class program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Product> map = new Dictionary<int,Product>();
            map.Add(1, new Product(1, "pen"));
            map.Add(2, new Product(2, "book"));
            map.Add(3, new Product(3, "pencil"));

            foreach(KeyValuePair<int, Product> item in map)
            {
                Console.WriteLine(item.Value);
            }
        }


    }
}
