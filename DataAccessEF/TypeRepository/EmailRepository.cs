using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessEF.TypeRepository
{
    class EmailRepository : GenericRepository<TestEmail>, IEmailRepository
    {
        public EmailRepository(PeopleContext context) : base(context) { }
    }
}
