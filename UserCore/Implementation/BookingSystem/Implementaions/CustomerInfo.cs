using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCore.Implementation.BookingSystem.Interfaces;
using UserInfrastructure;
using UserModel.BookingSystem;

namespace UserCore.Implementation.BookingSystem.Implementaions
{
    public class CustomerInfo : ICustomerInfo
    {
        private readonly UserDBcontext _userDBcontext;

        public CustomerInfo(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }

        public List<Customer> getAllCustomer()
        {
            var customerList = _userDBcontext.Customer
                            .Select(c => new Customer
                            {
                                CustomerId = c.CustomerId,
                                FirstName = c.FirstName,
                                LastName = c.LastName,
                                EmailId = c.EmailId,
                                ContactNumber = c.ContactNumber,
                                Address = c.Address,
                                LicenseNumber = c.LicenseNumber,
                                LicenseExpiryDate = c.LicenseExpiryDate,
                                DateOfBirth = c.DateOfBirth,
                            }).ToList();
            return customerList;
        }

    }
}
