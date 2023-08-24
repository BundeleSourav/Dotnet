using System.ComponentModel.DataAnnotations;

namespace HRS.Models
{
    public abstract class BaseEntity
    {
        [Key]
        public long Id { get; set; }
    }
}
