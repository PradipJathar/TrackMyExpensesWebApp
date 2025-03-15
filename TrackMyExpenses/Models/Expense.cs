using System.ComponentModel.DataAnnotations;

namespace TrackMyExpenses.Models
{
    public class Expense
    {
        [Key]
        public int ExpenseId { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public double Amount { get; set; }

        [Required]
        public DateTime ExpenseDate { get; set; }

        [Required]
        public string Category { get; set; }

        public int CategoryId { get; set; }
    }
}
