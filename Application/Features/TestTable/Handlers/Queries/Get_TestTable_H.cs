using Application.Contracts.Persistence.Tables;
using Application.Dto.TestTable.Queries;
using Application.Features.TestTable.Requests.Queries;
using Application.Responses;
using AutoMapper;
using MediatR;

namespace Application.Features.TestTable.Handlers.Queries
{
    public class Get_TestTable_H : IRequestHandler<Get_TestTable_R, BaseCommandResponse>
    {
        private readonly ITestTable testTable;
        private readonly IMapper mapper;

        public Get_TestTable_H(ITestTable testTable, IMapper mapper)
        {
            this.testTable = testTable;
            this.mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(Get_TestTable_R request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();

            var TestTable = await testTable.Get(request.Id);

            var testTableMap = mapper.Map<TestTable_Dto>(TestTable);

            response.Success();
            response.StatusCode = 200;
            response.Data = testTableMap;
            return response;
        }
    }
}
