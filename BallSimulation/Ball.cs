//ボールクラス
using System;
using System.Drawing;

class Ball
{
    //静的プロパティ
    public static int Count;  //オブジェクトの個数をカウント

    //乱数
    Random rnd = new Random();

    //プロパティ
    public double XPos { get; set; }  //x座標
    public double YPos { get; set; }  //y座標
    public Image Img { get; set; }  //画像データ

    private double moveX;  //加速度(x)
    private double moveY;  //加速度(y)
    //private Random rnd = new Random();

    //コンストラクタ
    public Ball()
    {
        XPos = 0;
        YPos = 0;
        Img = Image.FromFile(@"images\soccer_ball.png"); //\を2つ重ねてもいい

        moveX = 5;
        moveY = 5;

    }

    //引数付きコンストラクタ（座標指定）
    public Ball(double xp, double yp ,string path)
    {
        XPos = xp; //初期座標を引数から設定
        YPos = yp;
        Img = Image.FromFile(path);
        //Img = Image.FromFile(@"images\tennis_ball.png");

        moveX = rnd.Next(-10,10);
        moveY = rnd.Next(-10,10);

        Console.WriteLine("X = {0},Y = {1}", (int)moveX, (int)moveY);

        Ball.Count += 1;
    }

    //移動
    public void Move()
    {
        XPos += moveX;
        YPos += moveY;

        //if((YPos > 800 -100)||YPos < 0)
       // {
       //     moveY = -moveY;
       // }

       // if ((XPos > 800 - 100) || XPos < 0)
       // {
       //     moveX = -move;
       // }

        if (YPos >= 650)
        {
            moveY *= -1;
        }
        if(YPos <= 0)
        {
            moveY *= -1;
        }
        if(XPos <= 1000)
        {
            moveX *= -1;
        }
        if (XPos >= 0)
        {
            moveX *= -1;
        }
    }
}