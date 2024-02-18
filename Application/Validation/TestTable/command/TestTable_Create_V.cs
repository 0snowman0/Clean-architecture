using Application.Dto.TestTable.command;
using Application.Validation.TestTable.common;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validation.TestTable.command
{
    public class TestTable_Create_V : AbstractValidator<TestTable_Create_Dto>
    {
        public TestTable_Create_V()
        {
            Include(new ITestTable_V());
        }
    }
}
