using Application.Dto.TestTable.command;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TestTable.Requests.Commands
{
    public class Update_TestTable_R : IRequest<BaseCommandResponse>
    {
        public TestTable_Update_Dto TestTable_Update_Dto { get; set; } = null!;
    }
}
