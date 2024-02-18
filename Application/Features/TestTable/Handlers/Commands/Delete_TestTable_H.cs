using Application.Contracts.Persistence.Tables;
using Application.Features.TestTable.Requests.Commands;
using Application.Responses;
using AutoMapper;
using MediatR;

namespace Application.Features.TestTable.Handlers.Commands
{
    public class Delete_TestTable_H : IRequestHandler<Delete_TestTable_R , BaseCommandResponse>
    {
        private readonly ITestTable _testTable;
        private readonly IMapper _mapper;

        public Delete_TestTable_H(ITestTable testTable, IMapper mapper)
        {
            _testTable = testTable;
            _mapper = mapper;
        }

        public async Task<BaseCommandResponse> Handle(Delete_TestTable_R request, CancellationToken cancellationToken)
        {
            var response = new BaseCommandResponse();

            try
            {
                await _testTable.Delete(request.Ids);
             
                response.Success();

                response.StatusCode = 204;
            }
            catch (Exception ex)
            {

            }

         return response;

        }
    }
}
