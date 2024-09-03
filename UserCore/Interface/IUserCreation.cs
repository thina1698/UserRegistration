using UserModel.User;

namespace UserCore.Interface
{
    public interface IUserCreation
    {
        bool PostUser(UserRegistrationModel userModel);
    }
}