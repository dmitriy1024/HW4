using System;

namespace HW4.ArraysIndexes.Task2
{
    class Article
    {
        private string _articleName;
        private string _shopName;
        private double _costInUAH;

        public string ArticleName { get { return _articleName; } }
        public string ShopName { get { return _shopName; } }
        public double CostInUAH { get { return _costInUAH; } }

        public Article(string articleName, string shopName, double costInUAH)
        {
            _articleName = articleName;
            _shopName = shopName;

            if (costInUAH <= 0)
                throw new ArgumentException("Cost must be > 0");
            else
                _costInUAH = costInUAH;
        }

        public override string ToString()
        {
            return String.Format("Article: {0}   Store: {1}   Cost: {2} UAH", _articleName, _shopName, _costInUAH);
        }
    }
}
