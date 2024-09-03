using UserModel.User;

namespace UserCore.Interface
{
    public interface IUserInformation
    {
        UserRegistrationModel GetSingleUser(int userId);
    }
}