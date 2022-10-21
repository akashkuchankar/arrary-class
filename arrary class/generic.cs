//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Web;

//namespace arrary_class
//{
//    public class Product
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public int Price { get; set; }
//    }
//    public class Employee
//    {
//        public string name;
//        public double salary;
//        public Employee(string name,double salary)
//        {
//            this.name = name;   
//            this.salary = salary;   
//        }

//    }

//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            List<int> ilist = new List<int>();

//            ilist.Add(10);
//            ilist.Add(20);
//            ilist.Add(30);
//            ilist.Add(40);
//            ilist.Add(50);

//          ilist.Insert(2, 15);
//          //  ilist.Remove(20);
//            ilist.RemoveAt(2);
//            ilist.Sort();
//            ilist.Reverse();
//            ilist.AddRange(ilist);


//            List<string> slist = new List<string>();

//            slist.Add("C#");
//            slist.Add("MVC");

           
//            List<Employee> emplist2 = new List<Employee>()
//            {
//                new Employee("test1", 32000),
//                new Employee("test2", 22000),
//                new Employee("test3", 22000)
//            };

//            foreach (Employee emp in emplist2)
//            {
//                Console.WriteLine(emp);
//            }

//            List<Product> prodlist = new List<Product>()
//            {
//                new Product{Id=1,Name="mouse",Price=999},
//                 new Product{Id=1,Name="mouse",Price=999},
//                  new Product{Id=1,Name="mouse",Price=999},
//                   new Product{Id=1,Name="mouse",Price=999},
//                   new Product{Id=1,Name="mouse",Price=999},
//            };

//            foreach (Product item in prodlist)
//            {
//                Console.WriteLine($"{item.Id} {item.Name} {item.Price}");
//            }

//            foreach (int item in ilist)
//            {
//                Console.WriteLine(item);
//            }

//        }
//    }
//}
