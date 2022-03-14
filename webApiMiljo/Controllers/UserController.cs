using Microsoft.AspNetCore.Mvc;
using webApiMiljo.INTERFACES;
using webApiMiljo.MODELS;

namespace webApiMiljo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController
    {
        private readonly IService _service;


        public UserController(IService service)
        {
            _service = service;
        }
        //POST

        [HttpPost("Create Customer")]

        public bool PostCustomer(string firstname, string lastname, string email, int age)
        {
            return _service.PostCustomer(firstname, lastname, email, age);
        }

        //GET
        //UPDATE
        //DELETE
    }
}
