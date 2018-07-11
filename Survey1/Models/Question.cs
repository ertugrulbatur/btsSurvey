using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Survey1.Models
{
    public class Question
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Text { get; set; }       
        public ICollection<Choice> Choice { get; set; }

        [ForeignKey("Survey")]
        public int SID { get; set; }

        [ForeignKey("AppUser")]
        public int UID { get; set; }
        public AppUser User { get; set; }

    }
}
