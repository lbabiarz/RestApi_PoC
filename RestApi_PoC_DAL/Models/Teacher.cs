using System.Collections.Generic;

namespace RestApi_PoC_DAL.Models
{
    public class Teacher : AuditableEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<StudentsGroup> StudentsGroups { get; set; } 

    }
}
