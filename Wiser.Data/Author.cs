using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiser.Data
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Name => $"{FirstName} {LastName}";

        //This virtue attribute is the sum of how much virtue this author has gained over all wisdom attributed to him.
        public int Virtue { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}
