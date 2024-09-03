using Microsoft.AspNetCore.Mvc;
using UserCore.Implementation.OrderManagement;
using UserCore.Interface;
using UserModel.OrderManagement;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderManagementControllers : ControllerBase
    {
        private readonly IProductCustomerCreation _productCustomerCreation;
        private readonly IProductCreation _productCreation;
        private readonly IMappingCreation _mappingCreation;
        private readonly IMappingUpdation _mappingUpdation;
        public OrderManagementControllers
            (IProductCreation productCreation, 
            IProductCustomerCreation productCustomerCreation, 
            IMappingCreation mappingCreation,
            IMappingUpdation mappingUpdation)
        {
            _productCreation = productCreation;
            _productCustomerCreation = productCustomerCreation;
            _mappingCreation = mappingCreation;
            _mappingUpdation = mappingUpdation;
        }
        // POST api/<OrderManagementControllers>
        [HttpPost("AddCustomerToTheProducts")]
        public void PostProductCustomers([FromBody] ProductCustomerRequestModel requestModel)
        {
            _productCustomerCreation.CreateProductCustomer(requestModel);
        }

        [HttpPost("AddProductsOnly")]
        public void PostProducts([FromBody] ProductRequestModel requestModel)
        {
            _productCreation.CreateProducts(requestModel);
        }

        [HttpPost("AddMappingToCustomerAndProduct")]
        public void PostMapping([FromBody] MappingRequestModel requestModel)
        {
               _mappingCreation.CreateMapping(requestModel);
        }


        [HttpPut("UpdateMappingForCustomerAndProduct")]
        public void UpdateMapping([FromBody] MappingRequestModel requestModel)
        {
            _mappingUpdation.UpdateMapping(requestModel);
        }


        [HttpPut("UpdateMappingWithoutChangingTheOriginalValues")]
        public void UpdateMappingWithoutChangeTheReference([FromBody] MappingRequestModel requestModel)
        {
            _mappingUpdation.UpdateMappingWithoutReferenceChange(requestModel);
        }

    }
}
