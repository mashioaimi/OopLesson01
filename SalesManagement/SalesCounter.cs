﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesManagement
{
    //売り上げ集計クラス
    class SalesCounter
    {
        private List<Sale> _sales;
        //コンストラクタ
        public SalesCounter(List<Sale> sales)
        {
            _sales = sales;
        }

    }
}