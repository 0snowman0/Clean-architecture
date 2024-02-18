using Application.Dto.TestTable.Queries;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TestTable.Requests.Queries
{
    public class GetAll_TestTable_R  :IRequest<BaseCommandResponse>
    {
    }
}
