using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiser.Data
{
    public enum TypeOfWisdom { Proverb, Quote, etc }
    public class Wisdom
    {
        //Id for table
        [Key]
        public int WisdomId { get; set; }

        [Required]
        //Type of wisdom means in what context the wisdom should be taken. Reading a proverb should be different than reading a fact.
        public TypeOfWisdom WisdomType { get; set; }

        [Required]
        //The actual "meat and potatoes" of the wisdom. This is the proverb, the fact, etc.
        public string Content { get; set; }

        [Required]
        //The "citation" standard for the site. Where in the book or other place they found it (ex: "Meditiations 4:15)
        public string Source { get; set; }

        //The author is the person that thought of the wisdom, not the user
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }

        [Required]
        [ForeignKey("Owner")]
        public int OwnerId { get; set; }
        //Figure this out -> Do I make new data class for user or find out how to modify initial user class?
        //public virtual User Owner { get; set; }

        //This is how many upvotes each post gets. 1 Upvote = 1 virtue.
        [Required]
        public int WisdomVirtue { get; set; }

        //This is when the post was created. Set before added in services.
        [Required]
        public DateTime CreatedAt { get; set; }



    }
}
