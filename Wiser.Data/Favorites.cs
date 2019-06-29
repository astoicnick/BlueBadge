using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiser.Data
{
    public class Favorite
    {
        [Key]
        public int FavoriteId { get; set; }
        [Required]
        [ForeignKey("Owner")]
        public int OwnerId { get; set; }

        [Required]
        [ForeignKey("Wisdom")]
        public int WisdomId { get; set; }
    }
}
