using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    //売り上げ集計クラス
    class SalesCounter
    {
        public List<Sale> _sales;
        //コンストラクタ
        public SalesCounter(List<Sale> sales)
        {
            _sales = sales;
        }

    } 
}
