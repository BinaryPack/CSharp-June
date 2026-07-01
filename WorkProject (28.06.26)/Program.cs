//using System;

//namespace Programs
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var producer = new Product("Стивен", 2000m);
//            Console.WriteLine(producer.Name);
//        }
//    }
//    public class Product
//    {
//        public string Name { get; private set; }
//        public decimal Price { get; private set; }

//        public Product(string name, decimal price)
//        {
//            Name = name;
//            if (price >= 0) Price = price;
//            else throw new Exception("Цена не может быть отрицательной");
//        }

//    }
//}