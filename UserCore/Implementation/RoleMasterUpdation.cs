using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfrastructure.Table;
using UserInfrastructure;
using UserModel.UserModel;
using UserCore.Interface;

namespace UserCore.Implementation
{
    public class RoleMasterUpdation : IRoleMasterUpdation
    {
        private readonly UserDBcontext _userDBcontext;

        public RoleMasterUpdation(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public void UpdateRoleMaster(int roleMasterId, RoleMasterModel roleMasterModel)
        {
            var roleMaster = _userDBcontext.RoleMaster
                            .First(i => i.RoleMasterId == roleMasterId);
            //Update the Values
            roleMaster.RoleMasterId = roleMasterModel.RoleMasterId;
            roleMaster.RoleMasterName = roleMasterModel.RoleMasterName;
            _userDBcontext.SaveChanges();
        }
    }
}
