﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserModel.BookingSystem
{
    public class SpecficPaymentResponseModel
    {
            public int CustomerId { get; set; }
            public string Name { get; set; } 
            public string Email { get; set; } 
            public string PaymentModeType { get; set; }
        }
}
