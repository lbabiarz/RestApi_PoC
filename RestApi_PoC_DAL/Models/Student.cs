using System;

namespace RestApi_PoC_DAL.Models
{
    public class Student :AuditableEntity
    {
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }
        public StudentsGroup StudentsGroup { get; set; }
    }
}
