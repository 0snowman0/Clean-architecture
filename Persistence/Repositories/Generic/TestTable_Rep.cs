using Application.Contracts.Persistence.Tables;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories.Generic
{
    public class TestTable_Rep : GenericRepository<TestTable4> , ITestTable
    {
        private readonly Context_En _context;

        public TestTable_Rep(Context_En context)
            :base(context)
        {
            _context = context;
        }
    }
}
