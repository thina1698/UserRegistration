using Microsoft.AspNetCore.Mvc;
using UserCore.Interface;
using UserModel.UserModel;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleMasterController : ControllerBase
    {

        private readonly IRoleMasterCreation _roleMasterCreation;
        private readonly IRoleMasterUpdation _roleMasterUpdation;
        private readonly IRoleMasterDeletion _roleMasterDeletion;

        public RoleMasterController
        (
            IRoleMasterCreation roleMasterCreation,
            IRoleMasterUpdation roleMasterUpdation,
            IRoleMasterDeletion roleMasterDeletion
        )
        {
            _roleMasterCreation = roleMasterCreation;
            _roleMasterUpdation = roleMasterUpdation;
            _roleMasterDeletion = roleMasterDeletion;
        }

        // GET: api/<RoleMasterController>
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{
        //    return new string[] { "value1", "value2" };
        //}

        // GET api/<RoleMasterController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // POST api/<RoleMasterController>
        [HttpPost]
        public void Post([FromBody] RoleMasterModel roleMasterModel)
        {
            _roleMasterCreation.PostRoleMaster(roleMasterModel);
        }

        // PUT api/<RoleMasterController>/5
        [HttpPut("{id}")]
        public void Put(int roleMasterId, [FromBody] RoleMasterModel roleMasterModel)
        {
            _roleMasterUpdation.UpdateRoleMaster(roleMasterId, roleMasterModel);
        }

        // DELETE api/<RoleMasterController>/5
        [HttpDelete("{id}")]
        public void Delete(int roleMasterId)
        {
            _roleMasterDeletion.DeleteRoleMaster(roleMasterId);
        }
    }
}
