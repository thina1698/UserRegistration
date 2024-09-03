using UserModel.User;

namespace UserCore.Interface
{
    public interface IUserUpdation
    {
        void PutUser(int userId, UserRegistrationModel userModel);
    }
}