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
    public class RoleMasterDeletion : IRoleMasterDeletion
    {
        private readonly UserDBcontext _userDBcontext;

        public RoleMasterDeletion(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }
        public void DeleteRoleMaster(int roleMasterId)
        {

            var roleMaster = _userDBcontext.RoleMaster
                            .First(i => i.RoleMasterId == roleMasterId);
            _userDBcontext.RoleMaster.Remove(roleMaster);
            _userDBcontext.SaveChanges();
        }

    }
}
