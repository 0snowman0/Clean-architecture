using Application.Dto.TestTable.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dto.TestTable.command
{
    public class TestTable_Create_Dto : ITestTable_Dto
    {
        public string Name { get; set; } = string.Empty;
    }
}
