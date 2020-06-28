using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.Models
{
    public enum Gender
    {
        Male=0,
        Female=1
    }
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Username { get; set; }
        [Column(TypeName = "text")]
        public string Password { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public string FullName { get; set; }
        [Column(TypeName = "nvarchar")]
        [StringLength(100)]
        public  string Address { get; set; }
        public  DateTime BirthDay { get; set; }
        public Gender Gender { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Phone { get; set; }
        [Column(TypeName = "varchar")]
        [StringLength(50)]
        public string Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

        public ICollection<Task> Tasks { get; set; }
        public  ICollection<Category> Categories { get; set; }
    }
}
