using Microsoft.EntityFrameworkCore;
using UserCore.Implementation;
using UserCore.Implementation.BookingSystem.Implementaions;
using UserCore.Implementation.BookingSystem.Interfaces;
using UserCore.Implementation.OrderManagement;
using UserCore.Interface;
using UserInfrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var connection = builder.Configuration.GetConnectionString("UserDb");
builder.Services.AddDbContext<UserDBcontext>(option => option.UseSqlServer(connection));

//This is For RoleMaster Table
builder.Services.AddScoped<IRoleMasterCreation, RoleMasterCreation>();
builder.Services.AddScoped<IRoleMasterUpdation, RoleMasterUpdation>();
builder.Services.AddScoped<IRoleMasterDeletion, RoleMasterDeletion>();

//This is For User Table
builder.Services.AddScoped<IUserCreation, UserCreation>();
builder.Services.AddScoped<IUserUpdation, UserUpdation>();
builder.Services.AddScoped<IUserDeletion, UserDeletion>();
builder.Services.AddScoped<IUserInformation, UserInformation>();

//This is for Login Validation
builder.Services.AddScoped<ILoginValidation, LoginValidation>();

//This is Booking System
builder.Services.AddScoped<ICustomerCreation, CustomerCreation>();
builder.Services.AddScoped<IVehicleCreation, VehicleCreation>();
builder.Services.AddScoped<IBookingCreation, BookingCreation>();
builder.Services.AddScoped<IPaymentCreation, PaymentCreation>();
builder.Services.AddScoped<IPaymentModeCreation, PaymentModeCreation>();

//Prashanth Tasks
builder.Services.AddScoped<ITotalAmountEarnedByRentedVehicle,TotalAmountEarnedByRentedVehicle>();
builder.Services.AddScoped<ITotalAssignedVehicles, TotalAssignedVehicles>();
builder.Services.AddScoped<ICustomerLicenseExpiredInOneYear, CustomerLicenseExpiredInOneYear>();
builder.Services.AddScoped<IPaymentWithSpecificType, PaymentWithSpecificType>();
builder.Services.AddScoped<ICustomerBookingswithSpecificLocation, CustomerBookingswithSpecficLocation>();
builder.Services.AddScoped<ICustomerInfo, CustomerInfo>();

//Order Managements
builder.Services.AddScoped<IProductCustomerCreation, ProductCustomerCreation>();
builder.Services.AddScoped<IProductCreation, ProductCreation>();
builder.Services.AddScoped<IMappingCreation, MappingCreation>();
builder.Services.AddScoped<IMappingUpdation,MappingUpdation>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
