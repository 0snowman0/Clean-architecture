using Application.Contracts.Persistence.Tables;
using Application.Dto.TestTable.Queries;
using Application.Features.TestTable.Requests.Queries;
using Application.Responses;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.TestTable.Handlers.Queries
{
    public class GetAll_TestTable_H : IRequestHandler<GetAll_TestTable_R, BaseCommandResponse>
    {
        private readonly ITestTable testTable;
        private readonly IMapper mapper;

        public GetAll_TestTable_H(ITestTable testTable, IMapper mapper)
        {
            this.testTable = testTable;
            this.mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(GetAll_TestTable_R request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();

            var TableTests = await testTable.GetAll();

            var TableTestsMap = mapper.Map<List<TestTable_Dto>>(TableTests);

            response.Success();
            response.StatusCode = 200;
            response.Data = TableTestsMap;
            return response;
        }
    }
}
