using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project1.Models
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The Username is Required")]
        [MaxLength(100, ErrorMessage = "The Username cannot exceed 100 characters")]
        public string Username { get; set; }

        [DataType(DataType.Date)]
        public DateTime CommentDate { get; set; }

        [Required]
        public string Content { get; set; }
        [ForeignKey("Post")]
        public int PostId { get; set; }
        public BlogPost Post { get; set; }
    }
}
