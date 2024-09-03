using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModel.BookingSystem
{
    public class PaymentRequestModel
    {
        public int PaymentId { get; set; }
        public int BookingId { get; set; }
        public int PaymentModeId { get; set; }
        public bool IsPaid { get; set; }
    }
}
