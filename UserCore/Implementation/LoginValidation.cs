using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserCore.Interface;
using UserInfrastructure;
using UserModel.UserModel;

namespace UserCore.Implementation
{
    public class LoginValidation : ILoginValidation
    {
        private readonly UserDBcontext _userDBcontext;
        public LoginValidation(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public string LoginValidate(LoginModel loginModel)
        {
            var user = _userDBcontext.User
               .First(u => u.EmailId == loginModel.EmailId && u.Password == loginModel.Password);

            if (user == null)
            {
                return "Invalid credentials";
            }

            var role = _userDBcontext.RoleMaster
                        .First(r => r.RoleMasterId == user.RoleMasterId);

            if (role == null || (role.RoleMasterName != "Admin" && role.RoleMasterName != "Super Admin"))
            {
                return "Access denied";
            }

            return "Login Successful";
        }
    }
}
