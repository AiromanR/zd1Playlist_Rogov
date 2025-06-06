using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks; //ContexMenuStrip

namespace zd1Shop_Rogov
{
    internal class Shop
    {
        public static Dictionary<Product, int> products;
        public Shop()
        {
            products = new Dictionary<Product, int>();
        }
        //Добавление продукта в словарь
        public void AddProduct(Product product, int count)
        {
            products.Add(product, count);
        }
        //Показать все продукты
        public string WriteAllProducts()
        {
            string list = "Список продуктов:\n";
            foreach (var product in products)
                list += product.Key.GetInfo() + $", Количество: {product.Value}\n";
            return list;
        }
        //Создание и добавление продукта в словарь
        public void CreateProduct(string name, decimal price, int count)
        {
            products.Add(new Product(name, price), count);
        }
        //Продажа продукта
        public string Sell(Product product, int count)
        {
            if (products.ContainsKey(product))
            {
                if (products[product] - count <= 0)
                    return "Нет в наличии!";
                else
                {
                    products[product] -= count;
                    return null;
                }
            }
            else
                return "Товар не найден!";
        }
        //Поиск товара по имени
        public Product FindByName(string name)
        {
            foreach (var product in products.Keys)
            {
                if (product.Name == name)
                    return product;
            }
            return null;
        }
        //Продажа товара с поиском по имени (перегрузка)
        public string Sell(string ProductName, int count)
        {
            Product ToSell = FindByName(ProductName);
            if (ToSell != null)
            {
                this.Sell(ToSell, count);
                return null;
            }
            else
                return "Товар не найден!";
        }
    }
}
