using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_1
{
    class Store
    {
        private Article[] article;
        public Store()
        {
            article = new Article[] {new Article("Часы Apella", 15000M, "Bestwath.ru"), new Article("Часы Auguste Raymond", 25000M, "Bestwatch.ru"),
                new Article("Часы Ulyse Nardin", 250000M, "Bestwatch.ru") };
        }

        public int Length
        {
            get { return article.Length; }
        }

        public string this [int index]
        {
            get
            {
                if(index >= 0 && index < article.Length)
                return string.Format("Наименование товара: {0}. \nСтоимость: {1} гривен. \nЕсть в наличии в магазине: {2}",
                    article[index].Good_name, article[index].Good_price, article[index].Shop_name);

                return "Такого товара нет на складе";

            }

        }

        public string this [string index]
        {
            get
            {
                for (int i = 0; i < article.Length; i++)
                    if (article[i].Good_name == index)
                        return string.Format("Такой товар есть на складе: {0}. \nСтоимость: {1} гривен. \nЕсть в наличии в магазине: {2}",
                            article[i].Good_name, article[i].Good_price, article[i].Shop_name);

                return "Такого товара нет на складе:";
            }
        }
    }
}
