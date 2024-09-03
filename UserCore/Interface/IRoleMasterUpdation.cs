using UserModel.UserModel;

namespace UserCore.Interface
{
    public interface IRoleMasterUpdation
    {
        void UpdateRoleMaster(int roleMasterId, RoleMasterModel roleMasterModel);
    }
}