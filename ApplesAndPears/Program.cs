using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplesAndPears
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Fruit> fruits = new List<Fruit>();
            Random rnd = new Random();

            for(int i = 1; i <=10; i++)
            {
                Fruit fruit = new Fruit();
                double price = rnd.NextDouble();
                fruit.price = price;
                fruits.Add(fruit);
            }

            fruits.Sort();

            Console.WriteLine("Randomly generated values sorted from low to high:\n");

            foreach (Fruit fruit in fruits)
            {
                
                Console.WriteLine(fruit.price);
            }

            Console.WriteLine("\nIs it correct? :)");

            Fruit apple = new Fruit();
            Fruit pear = new Fruit();
            FruitRatingComparer compare = new FruitRatingComparer();

            Console.WriteLine("\nThese are the ratings that people give an apple: (1/10)");

            for (int i = 1; i <= 10; i++)
            {
                Rating rating = new Rating();
                int score = rnd.Next(1,11);
                Console.WriteLine(score);
                rating.rating = score;
                apple.ratings.Add(rating);
            }

            double averageAppleRating = compare.Average(apple);
            Console.WriteLine("This is the average: " + averageAppleRating);

            Console.WriteLine("\nThese are the ratings that people give a pear: (1/10)");

            for (int i = 1; i <= 10; i++)
            {
                Rating rating = new Rating();
                int score = rnd.Next(1,11);
                Console.WriteLine(score);
                rating.rating = score;
                pear.ratings.Add(rating);
            }

            double averagePearRating = compare.Average(pear);
            Console.WriteLine("This is the average: " + averagePearRating);

            int winner = compare.Compare(apple, pear);

            if (winner < 0)
                Console.WriteLine("\nPear has the best rating!");
            else if (winner > 0)
                Console.WriteLine("\nApple has the best rating!");
            else
                Console.WriteLine("\nApples and pears are equily rated! :0");

        }
    }
}
