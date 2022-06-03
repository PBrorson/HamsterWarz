using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamsterWarz.Shared
{
    public class Hamster
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int Age { get; set; }
        public string FavFood { get; set; } = string.Empty;
        public string Loves { get; set; } = string.Empty;
        public string ImgName { get; set; } = string.Empty;
        public int Wins { get; set; } 
        public int Losses { get; set; } 
        public int Games { get; set; } 
    }
}
