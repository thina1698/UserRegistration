using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModel.BookingSystem
{
    public class Payment
    {
        public int PaymentId {  get; set; }
        public int BookingId { get; set; }
        public int PaymentModeId {  get; set; }
        public bool IsPaid {  get; set; }
        public Booking Booking { get; set; }
        public PaymentMode PaymentMode { get; set; }
    }
}
