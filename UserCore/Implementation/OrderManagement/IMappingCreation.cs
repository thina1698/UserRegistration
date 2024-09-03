using UserModel.OrderManagement;

namespace UserCore.Implementation.OrderManagement
{
    public interface IMappingCreation
    {
        void CreateMapping(MappingRequestModel requestModel);
    }
}