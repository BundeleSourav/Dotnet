using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRS.Models
{
    [Table("admins")]
    public class Admin : BaseEntity
    {
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string Address { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        [EmailAddress]
        public string Email { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Password { get; set; }

        public long ContactNo { get; set; }

        [EnumDataType(typeof(Role))]
        [Column(TypeName = "nvarchar(20)")]
        public Role Role { get; set; }

        public virtual ICollection<Client> ClientDetail { get; set; } = new List<Client>();
        public virtual ICollection<Room> RoomDetail { get; set; } = new List<Room>();
        public virtual ICollection<Booking> BookingDetail { get; set; } = new List<Booking>();

        public void AddBook(Booking newBook)
        {
            BookingDetail.Add(newBook);
            newBook.BookingAdmin = this;
        }

        public Admin() : base()
        {
            Role = Role.ADMIN;
        }

        public Admin(string name, string address, string email, string password, long contactNo) : base()
        {
            Name = name;
            Address = address;
            Email = email;
            Password = password;
            ContactNo = contactNo;
            Role = Role.ADMIN;
        }

        public override string ToString()
        {
            return $"Admin [Name={Name}, Email={Email}, ContactNo={ContactNo}]";
        }
    }
}
