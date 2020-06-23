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
            int total = 0; //全体の売り上げ金額集計用
            SalesCounter sales = new SalesCounter(ReadSales("Sales.csv"));
            foreach (var item in sales._sales)
            {
                total += item.Amount;
            }

            Console.WriteLine("全体の売り上げ：{0}円", total);
        }

        //売り上げデータを読み込み、Saleオブジェクトのリストを返す
        static List<Sale> ReadSales(string filePath)
        {
            //売り上げデータを入れるリストオブジェクトを生成
            var sales = new List<Sale>();
            //ファイルから読み込み
            string[] lines = File.ReadAllLines(filePath); //データを持ってくる
            //読み込んだ桁の数だけ繰り返す
            foreach (string line in lines)
            {
                string[] items = line.Split(',');

                //オブジェクト初期化子
                Sale sale = new Sale
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2])
                };
                sales.Add(sale);    //saleオブジェクトをリストに追加
            }
            return sales;
        }
    }
}
