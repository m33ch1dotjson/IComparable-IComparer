using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplesAndPears
{
    class FruitRatingComparer : IComparer<Fruit>
    {
        public int Compare(Fruit fruit1, Fruit fruit2)
        {
            double avg1 = Average(fruit1);
            double avg2 = Average(fruit2);
            return avg1.CompareTo(avg2);
        }

        public double Average(Fruit fruit)
        {
            List<int> scores = new List<int>();
            
            foreach(Rating rating in fruit.ratings)
            {
                scores.Add(rating.rating);
            }

            return scores.Average();
        }
    }
}
