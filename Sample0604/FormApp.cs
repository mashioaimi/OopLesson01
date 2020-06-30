using System;
using System.Drawing;
using System.Windows.Forms;

class FormApp
{
    static Form form;
    static Label labelRedSignal;
    static Label labelYellowSignal;
    static Label labelBlueSignal;

    //状態　0：赤、1：青、2：黄
    static int Status = 0; //初期状態は赤

    public static void Main()
    {
        form = new Form(); //フォームの生成

        form.Text = "フォームアプリケーション";
        form.Width = 400;   //幅
        form.Height = 300;  //高さ

        //赤ラベル
        labelRedSignal = new Label(); //ラベルの生成
        labelRedSignal.Top = 20;
        labelRedSignal.Left = 240;
        labelRedSignal.BorderStyle = BorderStyle.FixedSingle;

        labelRedSignal.Width = 100;
        labelRedSignal.Height = 100;
        labelRedSignal.BackColor  = Color.Red;
        labelRedSignal.Parent = form; //ラベルの親を設定

        //黄ラベル
        labelYellowSignal = new Label(); //ラベルの生成
        labelYellowSignal.Width = 100;
        labelYellowSignal.Height = 100;
        labelYellowSignal.Top = 20;
        labelYellowSignal.Left = 130;
        labelYellowSignal.BorderStyle = BorderStyle.FixedSingle;

        labelYellowSignal.BackColor = Color.Transparent;
        labelYellowSignal.Parent = form; //ラベルの親を設定

        labelBlueSignal = new Label(); //ラベルの生成
        labelBlueSignal.Width = 100;
        labelBlueSignal.Height = 100;
        labelBlueSignal.Top = 20;
        labelBlueSignal.Left = 20;
        labelBlueSignal.BorderStyle = BorderStyle.FixedSingle;

        labelBlueSignal.BackColor = Color.Transparent;
        labelBlueSignal.Parent = form; //ラベルの親を設定

        //ボタン
        Button buttonPush = new Button();
        buttonPush.Text = "チェンジ";
        buttonPush.Top = 150;   //y座標
        buttonPush.Left = 250;  //x座標

        buttonPush.Width = 100;
        buttonPush.Height = 50;

        buttonPush.Parent = form;
        buttonPush.Click += ButtonPush_Click;

        Application.Run(form); //フォームを指定して起動

    }

    private static void ButtonPush_Click(Object sender,EventArgs e)
    {
        labelRedSignal.BackColor = Color.Transparent;
        labelYellowSignal.BackColor = Color.Transparent;
        labelBlueSignal.BackColor = Color.Transparent;


        if (Status == 0)
        {
            //赤が点灯中
            labelBlueSignal.BackColor = Color.Blue;
            Status = 1; //青へ移動
        }
        else if(Status == 1)
        {
            //青が点灯中
            labelYellowSignal.BackColor = Color.Yellow;
            Status = 2; //黄へ移動
        }
        else
        {
            //黄が点灯中
            labelRedSignal.BackColor = Color.Red;
            Status = 0; //赤へ移動
        }
    }
}