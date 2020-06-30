using System.Windows.Forms;
using System.Drawing;

class FormApp
{
    static Form form;

    public static void Main()
    {

        #region タイマー処理
        Timer timer = new Timer();  //タイマー

        timer.Tick += Timer_Tick;
        timer.Interval = 50;
        timer.Start();
        #endregion

        form = new Form(); //フォームの生成

        form.Text = "";
        form.Width = 800;   //幅
        form.Height = 600;  //高さ

        //ラベル
        Label labelAppName = new Label();   //ラベルの生成
        labelAppName.Text = "サンプルアプリ";
        labelAppName.Parent = form; //ラベルの親を設定

        //ボタン
        Button buttonPush = new Button();
        buttonPush.Text = "押す";
        buttonPush.Top = 100;   //y座標
        buttonPush.Left = 100;  //x座標
        //buttonPush.Location = new Point(100,100);
        buttonPush.Width = 100;
        buttonPush.Height = 100;
        buttonPush.BackColor = Color.Gray;  //ボタンの色

        buttonPush.Click += ButtonPush_Click;
        buttonPush.Parent = form;

        Application.Run(form);  //フォームを指定して起動
    }

    private static void Timer_Tick(object sender, System.EventArgs e)
    {
        #region フォームの背景
        if (form.BackColor == Color.Red)
        {
            form.BackColor = Color.Blue;
        }
        else
        {
            form.BackColor = Color.Red;
        }
        #endregion
    }

    private static void ButtonPush_Click(object sender, System.EventArgs e)
    {
        Button bt = (Button)sender;

        #region ボタンの色
        if (bt.BackColor == Color.Gray)
        {
            bt.BackColor = Color.Violet;
        }
        else
        {
            bt.BackColor = Color.Gray;
        }
        #endregion

        #region フォームの背景
        if (form.BackColor == Color.Red)
        {
            form.BackColor = Color.Blue;
        }
        else
        {
            form.BackColor = Color.Red;
        }
        #endregion
    }
}