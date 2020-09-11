using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class StockDetail
    {
        [Key]
        public int StockID { get; set; }
        public string StockName { get; set; }
        public int StockQuantity { get; set; }
    }
}
