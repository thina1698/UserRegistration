using UserModel.OrderManagement;

namespace UserCore.Implementation.OrderManagement
{
    public interface IMappingUpdation
    {
        void UpdateMapping(MappingRequestModel requestModel);

        void UpdateMappingWithoutReferenceChange(MappingRequestModel requestModel);
    }
}