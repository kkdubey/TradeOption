using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class UserDetail
    {
        [Key]
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string UserMobile { get; set; }
    }
}
