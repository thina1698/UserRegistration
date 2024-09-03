using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfrastructure.Table;
using UserModel.BookingSystem;

namespace UserInfrastructure
{
    public class UserDBcontext : DbContext
    {
        public UserDBcontext(DbContextOptions<UserDBcontext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<RoleMaster> RoleMaster {  get; set; }
        public DbSet<Customer> Customer {  get; set; }
        public DbSet<Vehicle> Vehicle {  get; set; }
        public DbSet<Booking> Booking {  get; set; }
        public DbSet<Payment> Payment {  get; set; }
        public DbSet<PaymentMode> PaymentMode {  get; set; }
        public DbSet<ProductCustomers> ProductCustomers { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<ProductMapping>   ProductMapping { get; set; }
    }
}
