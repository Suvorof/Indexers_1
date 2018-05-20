using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_1
{
    class Article
    {
        private string good_name;
        private decimal good_price;
        private string shop_name;

        public string Good_name { get; set; }
        public decimal Good_price { get; set; }
        public string Shop_name { get; set; }

        public Article(string good_name, decimal good_price, string shop_name)
        {
            this.Good_name = good_name;
            this.Good_price = good_price;
            this.Shop_name = shop_name;
        }
    }
}
