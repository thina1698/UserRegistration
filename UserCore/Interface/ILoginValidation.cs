using UserModel.UserModel;

namespace UserCore.Interface
{
    public interface ILoginValidation
    {
        string LoginValidate(LoginModel loginModel);
    }
}