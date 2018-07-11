using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Survey1.Models
{
    public class Choice
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(70)")]
        public string Text { get; set; }

        [ForeignKey("Question")]
        public int QId { get; set; }
        public Question Question { get; set; }
    }
}
