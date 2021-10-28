using System;
using System.ComponentModel.DataAnnotations;

namespace AlfaSchool.Repository.Model
{
    public class BaseEntity
    {
        [Required]
        public Guid Id { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        [Required]
        public DateTime LatModifiedDate { get; set; }
    }
}
