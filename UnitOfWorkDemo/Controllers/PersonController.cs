using Domain;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace UnitOfWorkDemo.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class PersonController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;
        public PersonController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IEnumerable<TestPerson> GetAllPersons()
        {
            return unitOfWork.Person.GetAll();
        }
        [HttpGet]
        public IEnumerable<TestPerson> GetAdultPersons()
        {
            return unitOfWork.Person.GetAdultPersons();
        }
    }
}
