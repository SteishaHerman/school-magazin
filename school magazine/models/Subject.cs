using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolMagazine.Models
{
    public class Subject
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity),Required, Key]  
        public int Id { get; set; }
        [Column ("Name_Subject")]
        public string NameSubject { get; set; }
        public Teacher Teacher { get; set; }
    }
}
