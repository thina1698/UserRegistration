using Microsoft.AspNetCore.Mvc;
using UserCommonApi;
using UserCore.Interface;
using UserModel.User;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserRegistration.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserCreation _userCreation;
        private readonly IUserUpdation _userUpdation;
        private readonly IUserDeletion _userDeletion;
        private readonly IUserInformation _userInformation;

        public UserController
        (
            IUserCreation userCreation,
            IUserUpdation userUpdation,
            IUserDeletion userDeletion,
            IUserInformation userInformation
        )
        {
            _userCreation = userCreation;
            _userUpdation = userUpdation;
            _userDeletion = userDeletion;   
            _userInformation = userInformation;
        }


        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public CommonApiResponse Get(int userId)
        {
            var getData= _userInformation.GetSingleUser(userId);
            return new CommonApiResponse()
            {
                Data = getData,
                Message="Data Fetched Succesfully"
            };
        }

        // POST api/<UserController>
        [HttpPost]
        public void Post([FromBody] UserRegistrationModel userRegistrationModel)
        {
            _userCreation.PostUser(userRegistrationModel);
        }

        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public void Put(int userId, [FromBody] UserRegistrationModel userRegistrationModel)
        {
            _userUpdation.PutUser(userId, userRegistrationModel);
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public void Delete(int userId)
        {
            _userDeletion.DeleteUser(userId);
        }
    }
}
