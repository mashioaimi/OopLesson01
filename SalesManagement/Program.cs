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
            int[] totals = new int[4] { 0, 0, 0, 0 };
            string[] shops = { "新宿店", "浅草店", "丸の内店", "横浜店" };

            SalesCounter sales = new SalesCounter(ReadSales("Sales.csv"));

            //集計
            foreach (var item in sales._sales)
            {
                for (int i = 0; i < shops.Length; i++)
                {
                    if (item.ShopName.Equals(shops[i]))
                    {
                        totals[i] += item.Amount;
                        break;
                    }
                }
            }

            //出力
            for (int i = 0; i < shops.Length; i++)
            {
                Console.WriteLine($"{shops[i]}の売上合計：{ totals[i]}");
            }
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

