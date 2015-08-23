using System;
using System.Collections.Generic;

namespace HW4.ArraysIndexes.Task2
{
    class Store
    {
        //Предположим что в магазине максимум 100 товаров (просто в условии сказано использовать массив:))
        //тут должен быть List<T>
        private Article[] _articles = new Article[maxCount];
        private string _storeName;               
        private int _count;
        private const int maxCount = 100;

        public string StoreName { get { return _storeName; } }

        public Store(string name)
        {
            if (name == null)
                throw new ArgumentNullException();
            else
                _storeName = name;
        }

        public void AddArticle(Article article)
        {
            if (article == null)
                throw new ArgumentNullException();

            if (_count < maxCount)
            { 
                _articles[_count] = article;
                _count++;
            }
            else
                throw new IndexOutOfRangeException("Store is full!");
        }

        public Article GetByIndex(int index)
        {
            return _articles[index];
        }

        public Article[] GetByName(string name)
        {
            var list = new List<Article>();
            foreach (var item in _articles)
            {
                if (item != null && item.ArticleName == name)
                    list.Add(item);
            }

            return list.ToArray();
        }
    }
}
