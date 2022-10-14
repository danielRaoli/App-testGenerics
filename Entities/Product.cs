using System;

namespace Curso8.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; private set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name}, Price ${Price}";
        }

        public int CompareTo(object? obj)
        {
            if(!(obj is Product))
            {
                throw new Exception("object is not Employee");
            }
            Product other = obj as Product;
            return this.Price.CompareTo(other.Price);
        }
    }
}
