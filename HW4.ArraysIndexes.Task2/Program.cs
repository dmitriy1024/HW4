using System;

namespace HW4.ArraysIndexes.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            var store = new Store("Everything for 5");
            store.AddArticle(new Article("iphone 7", store.StoreName, 4.50));
            store.AddArticle(new Article("headphones", store.StoreName, 5.50));
            store.AddArticle(new Article("iphone 7s", store.StoreName, 6.50));

            Article[] arr = store.GetByName("iphone 7s");
            foreach (var item in arr)
            {
                Console.WriteLine(item.ToString());
            }

            Console.ReadKey();
        }
    }
}
