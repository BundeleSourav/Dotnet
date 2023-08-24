using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRS.Models
{
    [Table("clients")]
    public class Client : BaseEntity
    {
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [EmailAddress]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Password { get; set; }

        public long ContactNo { get; set; }

        [EnumDataType(typeof(Role))]
        [Column(TypeName = "nvarchar(20)")]
        public Role Role { get; set; }

        public virtual ICollection<Booking> Checkin { get; set; } = new List<Booking>();
        
        [ForeignKey("ClientAdmin")]
        public int? ClientAdminId { get; set; }
        public virtual Admin ClientAdmin { get; set; }

        public virtual ICollection<AddKart> AddToKart { get; set; } = new List<AddKart>();

        public void AddBook(Booking newBook)
        {
            Checkin.Add(newBook);
            newBook.NewClient = this;
        }

        public Client() : base()
        {
            Role = Role.USER;
        }

        public Client(string name, string email, string password, long contactNo) : base()
        {
            Name = name;
            Email = email;
            Password = password;
            ContactNo = contactNo;
            Role = Role.USER;
        }

        public Client(string name, string email, string password, long contactNo, Admin clientAdmin) : base()
        {
            Name = name;
            Email = email;
            Password = password;
            ContactNo = contactNo;
            Role = Role.USER;
            ClientAdmin = clientAdmin;
        }

        public override string ToString()
        {
            return $"Client [Name={Name}, Email={Email}, ContactNo={ContactNo}, Role={Role}]";
        }
    }
}
