using Application.Contracts.Persistence.Tables;
using Application.Features.TestTable.Requests.Commands;
using Application.Responses;
using AutoMapper;
using MediatR;

namespace Application.Features.TestTable.Handlers.Commands
{
    public class Update_TestTable_H : IRequestHandler<Update_TestTable_R, BaseCommandResponse>
    {
        private readonly ITestTable _testTable;
        private readonly IMapper _mapper;

        public Update_TestTable_H(ITestTable testTable, IMapper mapper)
        {
            _testTable = testTable;
            _mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(Update_TestTable_R request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();

            var TargetUpdate = await _testTable.Get(request.TestTable_Update_Dto.Id);

            _mapper.Map(request.TestTable_Update_Dto , TargetUpdate);

            await _testTable.Update(TargetUpdate);


            response.Success();
            response.StatusCode = 204;
            response.Data = Unit.Value;
            return response;
        }
    }
}
