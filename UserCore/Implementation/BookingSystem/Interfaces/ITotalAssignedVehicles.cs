using UserModel.BookingSystem;

namespace UserCore.Implementation.BookingSystem.Interfaces
{
    public interface ITotalAssignedVehicles
    {
        List<AssignedVehicleResponseModel> GetAssignedVehicles();
    }
}