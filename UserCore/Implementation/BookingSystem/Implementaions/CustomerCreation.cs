using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfrastructure.Table;
using UserInfrastructure;
using UserModel.UserModel;
using UserModel.BookingSystem;
using UserCore.Implementation.BookingSystem.Interfaces;

namespace UserCore.Implementation.BookingSystem.Implementaions
{
    public class CustomerCreation : ICustomerCreation
    {
        private readonly UserDBcontext _userDBcontext;

        public CustomerCreation(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public void CreateCustomer(CustomerRequestModel customerRequest)
        {

            var customer = new Customer()
            {
                CustomerId = customerRequest.CustomerId,
                FirstName = customerRequest.FirstName,
                LastName = customerRequest.LastName,
                EmailId = customerRequest.EmailId,
                ContactNumber = customerRequest.ContactNumber,
                Address = customerRequest.Address,
                DateOfBirth = customerRequest.DateOfBirth,
                LicenseNumber = customerRequest.LicenseNumber,
                LicenseExpiryDate = customerRequest.LicenseExpiryDate,
            };
            _userDBcontext.Customer.Add(customer);
            _userDBcontext.SaveChanges();
        }
    }
}
