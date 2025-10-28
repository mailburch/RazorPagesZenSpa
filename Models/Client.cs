using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesZenSpaCh7.Models
{
    [Table("Client")]
    public class Client
    {
        [Key]
        public int ID { get; set; }

        [Required(ErrorMessage = "First name is required.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        [StringLength(30, ErrorMessage = "First name must be ≤ {1} characters.")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Last name is required.")]
        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        [StringLength(30, ErrorMessage = "Last name must be ≤ {1} characters.")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = string.Empty;

        [StringLength(60)]
        public string Address { get; set; } = string.Empty;

        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Only alphabetic letters and spaces are allowed.")]
        [StringLength(40)]
        public string City { get; set; } = string.Empty;

        [RegularExpression("^[a-zA-Z]*$", ErrorMessage = "Only alphabetic letters are allowed.")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "Use 2-letter code (e.g., MI).")]
        public string State { get; set; } = string.Empty;

        [Display(Name = "Postal Code")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Use 12345 or 12345-6789.")]
        [StringLength(10)]
        public string PostalCode { get; set; } = string.Empty;

        [StringLength(40)]
        public string Country { get; set; } = string.Empty;

        [Phone]
        [Display(Name = "Phone")]
        public string Phone { get; set; } = string.Empty;

        [Required(ErrorMessage = "Email is required")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string Username { get; set; } = string.Empty;

        [Required]
        [DataType(DataType.Password)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Password must be at least {2} characters.")]
        public string Password { get; set; } = string.Empty;

        [NotMapped]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Passwords must match.")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
