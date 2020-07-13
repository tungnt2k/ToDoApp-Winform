using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "ntext")]
        public string Content { get; set; }
        [Required]
        public int CardId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("CardId")]
        public Card Card { get; set; }
        public Comment()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
        }
    }
}
