using webApiMiljo.INTERFACES;
using webApiMiljo.MODELS;

namespace webApiMiljo.REPO
{
    public class Repository : IRepository
    {
        private readonly MyContext _repository;
        public Repository(MyContext repository)
        {
            _repository = repository;
        }
        //POST
        public bool PostCustomer(Customer customer)
        {
            _repository.Customers?.Add(customer);
            return (_repository.SaveChanges()) > 0;
        }
        //GET
        //UPDATE
        //DELETE
    }
}
