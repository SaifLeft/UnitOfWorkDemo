using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.TypeRepository
{
    class AddressRepository : GenericRepository<TestAddress>, IAddressRepository
    {
        public AddressRepository(PeopleContext context) : base(context) { }
    }
}
