using System;

namespace Task_004
{
    public class Store
    {
        private Article[] _articles;

        public Store(int countArticles)
        {
            _articles = new Article[countArticles];

            for (var i = 0; i < _articles.Length; i++)
            {
                _articles[i] = new Article();
            }
        }

        public string this[string index]
        {
            get
            {
                for (var i = 0; i < _articles.Length; i++)
                {
                    if (_articles[i].Name == index)
                    {
                        return $"{_articles[i].Name} из магазина {_articles[i].NameStore} стоит {_articles[i].Price}р";
                    }
                }

                return $"{index}, товара нет в магазине";
            }
        }
        
        public string this[int index]
        {
            get
            {
                if (index <= _articles.Length && index >= 0)
                {
                    return $"{_articles[index].Name} из магазина {_articles[index].NameStore} стоит {_articles[index].Price}р";
                }

                return "Введён не правельный индекс";
            }
        }

        public void Show()
        {
            for (var i = 0; i < _articles.Length; i++)
            {
                Console.WriteLine(_articles[i]);
            }
        }
        
        public void Fill(int index, string name, string nameStore, float price)
        {
            _articles[index].Add(name, nameStore, price);
        }
    }
}