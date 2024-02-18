using Application.Contracts.Persistence.Tables;
using Application.Features.TestTable.Requests.Commands;
using Application.Responses;
using AutoMapper;
using MediatR;


namespace Application.Features.TestTable.Handlers.Commands
{
    public class Create_TestTable_H : IRequestHandler<Create_TestTable_R, BaseCommandResponse>
    {
        private readonly ITestTable _testTable;
        private readonly IMapper _mapper;

        public Create_TestTable_H(ITestTable testTable, IMapper mapper)
        {
            _testTable = testTable;
            _mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(Create_TestTable_R request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();

            var NewTestTable = _mapper.Map<Domain.TestTable4>(request.testTable_Create_Dto);

            await _testTable.Add(NewTestTable);

            response.Success();
            response.StatusCode = 200;
            response.Data = NewTestTable.Id;
            return response;
        }
    }
}
