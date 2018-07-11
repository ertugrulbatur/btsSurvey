using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Survey1.Models
{
    public class Annoucement
    {
        public int Id { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string Text { get; set; }
        public ICollection<AppUser> User { get; set; }


    }
}
