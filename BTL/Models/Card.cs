using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.Models
{
    public class Card
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(255)]
        public string Name { get; set; }
        [Required]
        public int BoardId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool IsDone { get; set; }
        public bool Notification { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        [ForeignKey("BoardId")]
        public Board Board { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public ICollection<Task> Tasks { get; set; }
        public Card()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            IsDone = false;
            Notification = false;
        }
    }
}
