using webApiMiljo.INTERFACES;
using webApiMiljo.MODELS;

namespace webApiMiljo.SERVICES
{
    public class Service : IService
    {
        private readonly IRepository _repository;
        public Service(IRepository repository)
        {
            _repository = repository;
        }
        //POST
        public bool PostCustomer(string firstname, string lastname, string email, int age)
        {
            var newModel = new Customer(firstname, lastname, age, email);
            return _repository.PostCustomer(newModel);
        }
        //GET
        //UPDATE
        //DELETE
    }
}

