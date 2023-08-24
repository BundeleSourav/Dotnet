using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRS.Models
{
    [Table("rooms")]
    public class Room : BaseEntity
    {
        [EnumDataType(typeof(Roomtype))]
        [Column(name: "room_type", TypeName = "nvarchar(20)")]
        public Roomtype Type { get; set; }

        [Column(name: "description", TypeName = "nvarchar(20)")]
        public string Desc { get; set; }

        public double Price { get; set; }

        [EnumDataType(typeof(Status))]
        [Column(TypeName = "nvarchar(20)")]
        public Status Status { get; set; }

        public virtual ICollection<Booking> NewBooking { get; set; } = new List<Booking>();

        [ForeignKey("RoomAdmin")]
        public int? RoomAdminId { get; set; }
        public virtual Admin RoomAdmin { get; set; }

        public virtual ICollection<AddKart> AddRoomToKart { get; set; } = new List<AddKart>();

        public void AddBook(Booking newBook)
        {
            NewBooking.Add(newBook);
            newBook.NewRoom = this;
        }

        public Room() : base()
        {
            Status = Status.VACANT;
        }

        public Room(Roomtype type, string desc, double price, Status status) : base()
        {
            Type = type;
            Desc = desc;
            Price = price;
            Status = Status.VACANT;
        }

        public Room(Roomtype type, string desc, double price, Status status, Admin roomAdmin) : base()
        {
            Type = type;
            Desc = desc;
            Price = price;
            Status = Status.VACANT;
            RoomAdmin = roomAdmin;
        }

        public override string ToString()
        {
            return $"Room [Type={Type}, Desc={Desc}, Price={Price}, Status={Status}]";
        }
    }
}
