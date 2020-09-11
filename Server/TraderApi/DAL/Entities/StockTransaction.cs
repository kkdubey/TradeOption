using System;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class StockTransaction
    {
        [Key]
        public int StockTransactionID { get; set; }
        public int UserDetailID { get; set; }
        public int StockDetailID { get; set; }
        public string TrasnactionType { get; set; }
        public float UserStockPrice { get; set; }
        public int UserStockQuantity { get; set; }
        public DateTime ModifiedTime { get; set; }


        public virtual UserDetail UserDetail { get; set; }
        public virtual StockDetail StockDetail { get; set; }


    }





}
