using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserInfrastructure.Table;
using UserInfrastructure;
using UserModel.OrderManagement;

namespace UserCore.Implementation.OrderManagement
{
    public class MappingUpdation : IMappingUpdation
    {
        private readonly UserDBcontext _userDBcontext;

        public MappingUpdation(UserDBcontext userDBcontext)
        {
            _userDBcontext = userDBcontext;
        }

        public void UpdateMapping(MappingRequestModel requestModel)
        {
            // Retrieve the existing mappings for the given customer
            var previousValues = _userDBcontext.ProductMapping
                                    .Where(pm => pm.ProductCustomersId == requestModel.ProductCustomersId)
                                    .ToList();

            // Remove the existing mappings from the database
            _userDBcontext.ProductMapping.RemoveRange(previousValues);

            // Create new mappings based on the provided ProductsId
            var newMappings = requestModel.ProductsId.Select(productId => new ProductMapping
            {
                ProductCustomersId = requestModel.ProductCustomersId,
                ProductsId = productId,
            });
            _userDBcontext.ProductMapping.AddRange(newMappings);
            _userDBcontext.SaveChanges();
        }

        public void UpdateMappingWithoutReferenceChange(MappingRequestModel requestModel)
        {
            // Retrieve the existing mappings for the given customer
            var existingMappings = _userDBcontext.ProductMapping
                .Where(pm => pm.ProductCustomersId == requestModel.ProductCustomersId)
                .ToList();

            // Iterate through the existing mappings and update the ProductsId
            for (int i = 0; i < existingMappings.Count && i < requestModel.ProductsId.Count; i++)
            {
                existingMappings[i].ProductsId = requestModel.ProductsId[i];
            }

            // If there are more new ProductsId than existing mappings, add the new ones
            if (requestModel.ProductsId.Count > existingMappings.Count)
            {
                var newMappings = requestModel.ProductsId
                    .Skip(existingMappings.Count)
                    .Select(productId => new ProductMapping
                    {
                        ProductCustomersId = requestModel.ProductCustomersId,
                        ProductsId = productId,
                    });

                _userDBcontext.ProductMapping.AddRange(newMappings);
            }
            // If there are more existing mappings than new ProductsId, remove the extra ones
            else if (existingMappings.Count > requestModel.ProductsId.Count)
            {
                _userDBcontext.ProductMapping.RemoveRange(
                    existingMappings.Skip(requestModel.ProductsId.Count));
            }
            _userDBcontext.SaveChanges();
        }
    }
}
