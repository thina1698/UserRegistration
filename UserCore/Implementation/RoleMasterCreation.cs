using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfrastructure.Table;
using UserInfrastructure;
using UserModel.User;
using UserModel.UserModel;
using UserCore.Interface;

namespace UserCore.Implementation
{
    public class RoleMasterCreation : IRoleMasterCreation
    {
        private readonly UserDBcontext _userDBcontext;

        public RoleMasterCreation(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public void PostRoleMaster(RoleMasterModel roleMasterModel)
        {

            var roleMaster = new RoleMaster()
            {
                RoleMasterId = roleMasterModel.RoleMasterId,
                RoleMasterName = roleMasterModel.RoleMasterName,
            };
            _userDBcontext.RoleMaster.Add(roleMaster);
            _userDBcontext.SaveChanges();
        }
    }
}

