using System.ComponentModel.DataAnnotations;

namespace CoreAndFood.Data.Models
{
    public class Category
    {
        public int CategoryID { get; set; }
        [Required(ErrorMessage ="Category name can't be empty!!")]
        [StringLength(20, ErrorMessage = "Name should be between 4-20 characters",MinimumLength =4)]
        public string CategoryName{ get; set; }
        public string CategoryDescription { get; set; }
        //public bool Status { get; set; }
        public List<Food> Foods { get; set; }
       
    }
}
