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
            int asakusatotal = 0;
            int marunouchitotal = 0;
            int yokohamatotal = 0;
            SalesCounter sales = new SalesCounter(ReadSales("Sales.csv"));
            foreach (var item in sales._sales)
            {
                if( item.ShopName.Equals("新宿店"))
                {
                    total += item.Amount;
                }
                else if(item.ShopName.Equals("浅草店"))
                {
                    asakusatotal += item.Amount;
                }
                else if(item.ShopName.Equals("丸の内店"))
                {
                    marunouchitotal += item.Amount;
                }
                else if(item.ShopName.Equals("横浜店"))
                {
                    yokohamatotal += item.Amount;
                }

            }

            Console.WriteLine("新宿店売り上げ：{0}円", total);
            Console.WriteLine("浅草店売り上げ：{0}円", asakusatotal);
            Console.WriteLine("丸の内店売り上げ：{0}円", marunouchitotal);
            Console.WriteLine("横浜店売り上げ：{0}円", yokohamatotal);

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
