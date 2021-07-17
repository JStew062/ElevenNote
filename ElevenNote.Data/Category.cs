using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevenNote.Data
{
    public class Category
    {
        [Key]
        public int CatId { get; set; }

        [Required]
        public string CatName { get; set; }

        [ForeignKey(nameof(Note))]
        public int NoteId { get; set; }
        public virtual Note Note { get; set; }

    }
}
