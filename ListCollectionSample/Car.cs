using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollectionSample
{
    [Serializable]　//ないとシリアル化できない
    class Car
    {
        //車名
        [System.ComponentModel.DisplayName("車名")]
        public string Name { get; set; }
        //メーカー
        [System.ComponentModel.DisplayName("メーカー")]
        public string Maker { get; set; }
        //カテゴリー
        [System.ComponentModel.DisplayName("カテゴリ")]
        public string Category { get; set; }
        //画像
        [System.ComponentModel.DisplayName("画像")]
        public Image carPic { get; set; }
    }
}
