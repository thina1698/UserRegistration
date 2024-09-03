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
    public class CustomerLicenseExpiredInOneYear : ICustomerLicenseExpiredInOneYear
    {
        private readonly UserDBcontext _userDBcontext;

        public CustomerLicenseExpiredInOneYear(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }

        public List<CustomerRequestModel> LicenseExpiryInOneYear()
        {
            var today = DateTime.Now;
            var nextYear = today.AddYears(1);

            var getDetails = _userDBcontext.Customer
                .Where(i => i.LicenseExpiryDate >= today && i.LicenseExpiryDate <= nextYear)
                .Select(c => new CustomerRequestModel()
                {
                    CustomerId = c.CustomerId,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    EmailId = c.EmailId,
                    ContactNumber = c.ContactNumber,
                    Address = c.Address,
                    DateOfBirth = c.DateOfBirth,
                    LicenseNumber = c.LicenseNumber,
                    LicenseExpiryDate = c.LicenseExpiryDate
                }).ToList();
            return getDetails;
        }
    }
}
