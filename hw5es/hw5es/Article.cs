using System;
using System.Linq;
using System.Reflection;

namespace hw5es
{
    public class Article
    {
        private string _name;
        private string _storeName;
        private double _price;

        public Article(string name, string storeName, double price)
        {
            _name = name;
            _storeName = storeName;
            _price = price;
        }

        public string Name => _name;

        public string StoreName => _storeName;

        public double Price => _price;
    }

    public class Store
    {
        private Article[] _articles;

        public Store(params Article[] articles)
        {
            _articles = articles;
        }

        public void AddArticle(Article article)
        {
            Array.Copy(_articles, _articles, _articles.Length + 1);
        }

        public void GetByIndex(int index)
        {
            if (index < 0 || index > _articles.Length)
            {
                throw new Exception("Index is out of range.");
            }

            Console.WriteLine($"Item by index {index}: ");
            Console.WriteLine($"{_articles[index].Name} ~ {_articles[index].Price} ~ {_articles[index].StoreName}");
        }

        public void GetByName(string name)
        {
            var items = _articles.Where(x => x.Name == name).ToArray();
            if (items.Length > 0)
            {
                Console.WriteLine("Items:");
                foreach (var item in _articles.Where(x => x.Name == name))
                {
                    Console.WriteLine($"{item.Name} ~ {item.Price} ~ {item.StoreName}");
                }
            }
            else
            {
                Console.WriteLine("No items found");
            }
        }
    }
}