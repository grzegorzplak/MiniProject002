using System.ComponentModel;

namespace MiniProject002.Models
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Category name")]
        public string CategoryName { get; set; }
        public virtual ICollection<Product>? Categories { get; set; }
    }
}
