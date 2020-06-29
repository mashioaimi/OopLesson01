using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListCollectionSample
{
    public partial class Form1 : Form
    {
        //車データを入れるバインディングリスト
        BindingList<Car> _cars = new BindingList<Car>();

        public Form1()
        {
            InitializeComponent();
            dgvCarData.DataSource = _cars;

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Car car = new Car()
            {
                Name = tbName.Text,
                Maker = tbMaker.Text,
                Category = tbCategory.Text,
                carPic = pbImage.Image
            };


            _cars.Insert(0, car); //リストの先頭(インデックス0)へ追加
            dgvCarData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            inputItemAllClear();

        }

        private void inputItemAllClear()
        {
            tbName.Clear();
            tbMaker.Clear();
            tbCategory.Clear();
            pbImage.Image = null;
        }

        private void btOpenImage_Click(object sender, EventArgs e)
        {
            if (ofdOpenImage.ShowDialog() == DialogResult.OK)
            {
                //選択した画像をピクチャーボックスに表示
                pbImage.Image = Image.FromFile(ofdOpenImage.FileName);
                //ピクチャーボックスのサイズに画像を調整
                pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btClearImage_Click(object sender, EventArgs e)
        {
            pbImage.Image = null; //クリックされたらbtImageを何も入っていない状態にする
        }

        private void dgvCarData_Click(object sender, EventArgs e)
        {
            //選択したレコードを取り出す
            //データグリッドビューで選択した行のインデックスを元に
            //BindingListのデータを取得する
            Car selectedCar = _cars[dgvCarData.CurrentRow.Index];
            tbName.Text = selectedCar.Name;
            tbMaker.Text = selectedCar.Maker;
            tbCategory.Text = selectedCar.Category;
        }

        private void btModify_Click(object sender, EventArgs e)
        {
            //Car selectedCar = _cars[dgvCarData.CurrentRow.Index];
            //selectedCar.Name = tbName.Text;
            //selectedCar.Maker = tbMaker.Text;
            //selectedCar.Category = tbCategory.Text;
            //dgvCarData.Refresh();  データグリッドビューの描画

            //変更対象のレコード(オブジェクト)
            Car modify = new Car() //中の処理を変更
            {
                Name = tbName.Text,
                Maker = tbMaker.Text,
                Category = tbCategory.Text,
                carPic = pbImage.Image
            };

            _cars[dgvCarData.CurrentRow.Index] = modify; //格納された行の文字を変更

            inputItemAllClear();

        }
    }
}
