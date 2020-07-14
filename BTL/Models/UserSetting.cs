using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL.Models
{
    public class UserSetting
    {
        [Key]
        public int Id { get; set; }
        public bool Noti { get; set; }
        public bool StartWithWin { get; set; }
    }
}
