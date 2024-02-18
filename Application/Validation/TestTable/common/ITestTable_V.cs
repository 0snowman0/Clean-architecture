using Application.Dto.TestTable.common;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Validation.TestTable.common
{
    public class ITestTable_V : AbstractValidator<ITestTable_Dto>
    {
        public ITestTable_V()
        {
            RuleFor(x => x.Name)
    .NotEmpty()
    .WithMessage("The Name field is required.")
    .MaximumLength(10)
    .WithMessage("The Name field must be 10 characters or less.");
        }
    }
}
