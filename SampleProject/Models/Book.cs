using System.ComponentModel.DataAnnotations;

namespace SampleProject.Models
{
    public class Book : IValidatableObject
    {
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Should be bigger than 0")]
        public int id { get; set; }
        [Required]
        public string author { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string publisher { get; set; }
        [Range(1900, 2023, ErrorMessage = "Should be in between 1900 and 2023")]
        public int issueYear { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            throw new NotImplementedException();
        }
    }
}
