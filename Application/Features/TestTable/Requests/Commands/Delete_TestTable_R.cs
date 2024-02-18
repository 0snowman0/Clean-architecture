using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TestTable.Requests.Commands
{
    public class Delete_TestTable_R : IRequest<BaseCommandResponse>
    {
        public  List<int> Ids { get; set; }
    }
}
