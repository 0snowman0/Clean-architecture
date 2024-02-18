using Application.Dto.TestTable.command;
using Application.Features.TestTable.Requests.Commands;
using Application.Features.TestTable.Requests.Queries;
using Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers.Test
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var TestTables = await _mediator.Send(new GetAll_TestTable_R());
            return Ok(TestTables);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            var TestTable = await _mediator.Send(new Get_TestTable_R {Id = id });
            return Ok(TestTable);
        }

        [HttpPost]
        public async Task<ActionResult<BaseCommandResponse>> Create(TestTable_Create_Dto testTable_Create_Dto)
        {
            var command =  new Create_TestTable_R {testTable_Create_Dto = testTable_Create_Dto };
            var response = await _mediator.Send(command);

            return Ok(response);
        }

        [HttpDelete]
        public async Task<ActionResult> Delete(List<int> Ids)
        {
            var Response = await _mediator.Send(new Delete_TestTable_R{Ids = Ids });
            return Ok(Response);
        }

        [HttpPut]
        public async Task<ActionResult> Update(TestTable_Update_Dto testTable_Update_Dto)
        {
            var command = new Update_TestTable_R { TestTable_Update_Dto = testTable_Update_Dto};
            await _mediator.Send(command);
            return NoContent();
        }
    }
}
