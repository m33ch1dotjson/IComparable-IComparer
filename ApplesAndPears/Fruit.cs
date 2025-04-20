using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplesAndPears
{
    class Fruit : IComparable<Fruit>
    {
        public double price;
        public List<Rating> ratings = new List<Rating>(); 
        public int CompareTo(Fruit fruit)
        {
            Fruit otherFruit = fruit;
            return this.price.CompareTo(otherFruit.price);
        }
    }
}
