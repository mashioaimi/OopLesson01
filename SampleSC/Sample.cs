
using System;
using System.Management.Instrumentation;
using System.Windows.Forms;

//Formクラスを継承したSampleクラス
class Sample : Form
{

    //int data;
    public static void Main()
    {
        Application.Run(new Sample());
    }

    //デフォルトコンストラクタ
    public Sample()
    {
        int num;
        Random rand = new Random();
        //チェック用配列
        var checkNum = new int[20] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
                                       0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        for(int i = 0; i < 20; i++)
        {
            do
            {
                num = rand.Next(20) + 1; //0～20の乱数
            } while (checkNum[num - 1] != 0);

            checkNum[num - 1] = 1; //出た数の要素にチェック
            Console.Write(num + " ");

        }

    }
}