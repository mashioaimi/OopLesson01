using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesCounter sales = new SalesCounter("Sales.csv");

            Dictionary<string, int> amountPerStore = sales.GetPerStoreSales();

            //出力
            foreach (var item in amountPerStore)
            {
                Console.WriteLine("{0}の売上合計：{1}", item.Key, item.Value);
                //Console.WriteLine("$"{item.key}の売上合計：{item.value})
            }

        }
    }
}
 