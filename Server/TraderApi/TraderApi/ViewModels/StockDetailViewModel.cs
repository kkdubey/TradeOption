using System;
using System.Collections.Generic;
using System.Text;

namespace TraderApi.ViewModels
{
    public class StockDetailViewModel
    {
        public int StockID { get; set; }
        public string StockName { get; set; }
        public int StockQuantity { get; set; }
    }
}
