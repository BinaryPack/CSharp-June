using System;
using System.Collections.Generic;
using System.Text;

namespace WorkProject__28._06._26_
{
    internal class TaskExams4
    {
        static void Main(string[] args)
        {
            List<Product> inventory = new List<Product>
            {
                new Product("Ноутбук", 1500m),
                new Product("Мышка", 25m),
                new Product("Клавиатура", 40m),
                new Product("Монитор", 200m)
            };
            foreach (Product product in inventory)
            {
                Console.WriteLine(product.Item + " " + product.Price);
            }
            var expensiveItems = inventory.OrderByDescending(x => x.Price > 30m).ToList();
            var assortment = inventory.Where(x => x.Price < 100m).Select(x => x.Item).ToList();
            var totalSpend = inventory.Sum(x => x.Price);
            var checkMouses = inventory.Any(x => x.Item == "Мышка");
            foreach (var item in expensiveItems) Console.WriteLine(item);
            foreach (var item in assortment) Console.WriteLine(item);
            Console.WriteLine(totalSpend + " " + checkMouses);
        }
        public class Product
        {
            public string Item { get; private set; }
            public decimal Price { get; private set;  }

            public Product(string item, decimal price)
            {
                Item = item;
                if (price >= 0)
                {
                    Price = price;
                }
                else throw new Exception("Ошибка, цена не может быть отрицательной!");
            }
        }
    }
}
