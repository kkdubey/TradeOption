using System;
using System.Collections.Generic;
using System.Text;

namespace TraderApi.ViewModels
{
    public class StockTransactionViewModel
    {
        public int StockTransactionID { get; set; }
        public int UserDetailID { get; set; }
        public int StockDetailID { get; set; }
        public string TrasnactionType { get; set; }
        public float UserStockPrice { get; set; }
        public int UserStockQuantity { get; set; }
        public DateTime ModifiedTime { get; set; }


        public virtual UserDetailViewModel UserDetail { get; set; }
        public virtual StockDetailViewModel StockDetail { get; set; }


    }





}
