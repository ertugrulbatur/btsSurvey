using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Survey1.Models
{
    public class Survey
    {
        public int Id { get; set; }
        public ICollection<Question> Question { get; set; }
        public ICollection<AppUser> User { get; set; }


        

        
    }
}
