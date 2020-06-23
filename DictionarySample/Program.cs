using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionarySample
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> color = new Dictionary<string, string>
            {
                //Key,Value
                {"黒","Black" },
                {"白","White"},
                {"黄","Yellow"}
            };

            //配列のように値を追加
            color["赤"] = "Red";
            //Addメソッドで値の追加
            color.Add("青", "Blue");

            foreach (var key in color.Keys)
            {
                Console.WriteLine($"{key}は{color[key]}です。");
            }

            //キーの存在チェック
            if(color.ContainsKey("緑"))
            {
                Console.WriteLine("緑は存在しています。");
            } else
            {
                Console.WriteLine("緑は存在しません。");
            }

            //値の存在チェック
            if(color.ContainsValue("Red"))
            {
                Console.WriteLine("Redは値に存在しています。");
            }
            else
            {
                Console.WriteLine("Redは値に存在しません。");
            }
        }
    }
}
