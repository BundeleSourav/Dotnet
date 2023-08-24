using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HRS.Models
{
    [Table("bookings")]
    public class Booking : BaseEntity
    {
        [Column(length: 20)]
        public string Name { get; set; }

        [Column(length: 20)]
        public string Address { get; set; }

        public long Contactno { get; set; }

        public long Aadharno { get; set; }

        [DataType(DataType.Date)]
        public DateTime Fromdate { get; set; }

        [DataType(DataType.Date)]
        public DateTime Todate { get; set; }

        [ForeignKey("NewClient")]
        public int? NewClientId { get; set; }
        public virtual Client NewClient { get; set; }

        [ForeignKey("NewRoom")]
        public int? NewRoomId { get; set; }
        public virtual Room NewRoom { get; set; }

        [ForeignKey("BookingAdmin")]
        public int? BookingAdminId { get; set; }
        public virtual Admin BookingAdmin { get; set; }

        public Booking() : base()
        {
        }

        public Booking(string name, string address, long contactno, long aadharno, DateTime fromdate, DateTime todate) : base()
        {
            Name = name;
            Address = address;
            Contactno = contactno;
            Aadharno = aadharno;
            Fromdate = fromdate;
            Todate = todate;
        }

        public Booking(string name, string address, long contactno, long aadharno, DateTime fromdate, DateTime todate, Client newClient, Room newRoom)
            : base()
        {
            Name = name;
            Address = address;
            Contactno = contactno;
            Aadharno = aadharno;
            Fromdate = fromdate;
            Todate = todate;
            NewClient = newClient;
            NewRoom = newRoom;
        }

        public Booking(string name, string address, long contactno, long aadharno, DateTime fromdate, DateTime todate, Client newClient, Room newRoom, Admin bookingAdmin)
            : base()
        {
            Name = name;
            Address = address;
            Contactno = contactno;
            Aadharno = aadharno;
            Fromdate = fromdate;
            Todate = todate;
            NewClient = newClient;
            NewRoom = newRoom;
            BookingAdmin = bookingAdmin;
        }

        public override string ToString()
        {
            return $"Booking [Name={Name}, Address={Address}, Contactno={Contactno}, Aadharno={Aadharno}, Fromdate={Fromdate}, Todate={Todate}]";
        }
    }
}
