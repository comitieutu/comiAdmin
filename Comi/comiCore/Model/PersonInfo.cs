using System;

namespace ComiCore.Model
{
    public class PersonInfo : BaseEntity
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public Gender Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public int DistrictId { get; set; }
        public virtual District District { get; set; }
        public virtual ApplicationUser ApplicationUser { get; set; }
    }
    public enum Gender
    {
        Male = 1,
        Female = 2,
        Other = 3
    }
}
