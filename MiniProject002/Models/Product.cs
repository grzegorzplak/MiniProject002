using System.ComponentModel;

namespace MiniProject002.Models
{
    public class Product
    {
        public int Id { get; set; }
        [DisplayName("Product name")]
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
    }
}
