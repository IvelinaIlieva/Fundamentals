using System;

namespace P01._Advertisement_Message
{
    internal class Program
    {
        static void Main()
        {
            int numberOfMessages = int.Parse(Console.ReadLine());

            string[] phrases =
            {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };
            string[] events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            string[] authors =
            {
                "Diana",
                "Petya",
                "Stella",
                "Elena",
                "Katya",
                "Iva",
                "Annie",
                "Eva"
            };
            string[] cities =
            {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            Random rnd = new Random();
            
            for (int i = 1; i <= numberOfMessages; i++)
            {
                int indexOfPhrases = rnd.Next(phrases.Length);
                int indexOfEvents = rnd.Next(events.Length);
                int indexOfAuthors = rnd.Next(authors.Length);
                int indexOfCities = rnd.Next(cities.Length);

                Console.WriteLine($"{phrases[indexOfPhrases]} {events[indexOfEvents]} {authors[indexOfAuthors]} – {cities[indexOfCities]}.");
            }
        }
    }
}
