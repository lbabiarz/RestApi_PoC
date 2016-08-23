using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi_PoC_DAL.Models
{
    public class StudentsGroup : AuditableEntity
    {
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; } 
    }
}
