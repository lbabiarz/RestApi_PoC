using System;
using System.Security.AccessControl;
using System.Security.Permissions;

namespace RestApi_PoC_DAL.Models
{
    public abstract class AuditableEntity
    {

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifyDateTime { get; set; }
        public bool Removed { get; set; }
        public bool Visible { get; set; }   
    }
}