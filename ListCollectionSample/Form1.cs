using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
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
                Maker = cbMaker.Text,
                Category = tbCategory.Text,
                carPic = pbImage.Image
            };
            //メーカーをコンボボックスの入力候補に登録
            setComboBoxMaker(cbMaker.Text);

            if (tbName.Text == "") //(==)→中身の確認
            {
                MessageBox.Show("正しい値を入力してください。",
                    "エラー",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            } else
            {
                _cars.Insert(0, car); //リストの先頭(インデックス0)へ追加
                dgvCarData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

                inputItemAllClear();

                initButton();
                dgvCarData.ClearSelection(); //クリックしたときに選択されないようにする
                dgvCarData.ClearSelection(); //選択行をクリア

            }
        }

        private void inputItemAllClear()
        {
            tbName.Text = "";
            cbMaker.Text = "";
            tbCategory.Clear();
            pbImage.Image = null;
        }

        //メーカーコンボボックスの入力候補登録
        private void setComboBoxMaker(string maker)
        {
            if (!cbMaker.Items.Contains(maker)) //!←否定
            {
                //コンボボックスの候補に追加
                cbMaker.Items.Add(maker);
            }
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
            cbMaker.Text = selectedCar.Maker;
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
                Maker = cbMaker.Text,
                Category = tbCategory.Text,
                carPic = pbImage.Image
            };

            _cars[dgvCarData.CurrentRow.Index] = modify; //格納された行の文字を変更

            inputItemAllClear();

        }

        private void btDelet_Click(object sender, EventArgs e)
        {
            _cars.RemoveAt(dgvCarData.CurrentRow.Index);
            initButton();
        }
        private void Form1_Load(object sender, EventArgs e) //Formの中で変更と削除を作る
        {
            initButton();

        }
        void initButton()
        {
            if (_cars.Count == 0)
            {
                btModify.Enabled = false; //初期状態では変更ボタンはマスク
                btDelet.Enabled = false;
            } else
            {
                btModify.Enabled = true;
                btDelet.Enabled = true;
            }
        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 新規入力ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputItemAllClear();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            //セーブファイルダイアログを表示
            if (sfdSaveData.ShowDialog() == DialogResult.OK)
            {

                //ファイルストリームを生成
                BinaryFormatter formatter = new BinaryFormatter();

                using (FileStream fs = new FileStream(sfdSaveData.FileName, FileMode.Create))
                {
                    try
                    {
                        //シリアル化して保存
                        formatter.Serialize(fs, _cars);
                    } catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to serialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            //オープンファイルダイアログを表示
            if (ofdOpenData.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fs = new FileStream(ofdOpenData.FileName, FileMode.Open))
                {
                    try
                    {
                        BinaryFormatter formatter = new BinaryFormatter();
                        //逆シリアル化して読み込む
                        _cars = (BindingList<Car>)formatter.Deserialize(fs);
                        //データグリッドビューに再設定
                        dgvCarData.DataSource = _cars;
                        //選択されている箇所を各コントロールへ表示
                        dgvCarData_Click(sender, e);

                    } 
                    catch (SerializationException se)
                    {
                        Console.WriteLine("Failed to deserialize. Reason: " + se.Message);
                        throw;
                    }
                }
            }
        }
    }
}
