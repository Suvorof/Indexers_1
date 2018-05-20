using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers_1
{
    class Program
    {
        static void Main()
        {
            Store store = new Store();
            Console.WriteLine("Количество товаров в магазине: {0} шт.", store.Length);
            Console.WriteLine("Введите номер товра N от 0 до {0} чтобы получить информацию о нём:", store.Length - 1);
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(store[N]);
            Console.ReadLine();

            Console.WriteLine("Введите наименование товара чтобы проверить его наличие на складе, наапример: 'Часы Apella'.");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine(store[name]);
            Console.ReadLine();


        }
    }
}
