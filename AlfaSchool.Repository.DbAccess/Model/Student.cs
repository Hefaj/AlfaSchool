using System.ComponentModel.DataAnnotations;
using AlfaSchool.Repository.Model;

namespace AlfaSchool.Repository.DbAccess.Model
{
    public class Student : BaseEntity
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(100)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(100)]
        public string Email { get; set; }
    }
}
