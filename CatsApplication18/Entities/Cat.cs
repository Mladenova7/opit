using System.ComponentModel.DataAnnotations;

namespace CatsApplication18.Entities
{
    public class Cat
    {
        public int Id { get; set; }
        [MaxLength(50,ErrorMessage ="MaxLength-50")]
        [Required]
        public string Name { get; set; }
        [Range(1,30, ErrorMessage = "WRONG NUMBER FOR AGE")]
        public int Age { get; set; }
        [MaxLength(30)]
        public string Breed { get; set; }
    }
}
