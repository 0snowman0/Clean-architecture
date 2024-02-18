﻿using Application.Dto.TestTable.command;
using Application.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TestTable.Requests.Commands
{
    public class Create_TestTable_R : IRequest<BaseCommandResponse>
    {
        public TestTable_Create_Dto testTable_Create_Dto { get; set; } = null!;
    }
}
