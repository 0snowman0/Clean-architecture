using Application.Contracts.Persistence.Tables;
using Application.Dto.TestTable.Queries;
using Application.Features.TestTable.Handlers.Queries;
using Application.Features.TestTable.Requests.Queries;
using Application.Profile;
using Application.Responses;
using AutoMapper;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Mocks;

namespace UnitTest.TestTable.queries
{
    public class TestTable_T
    {
        IMapper _mapper;
        Mock<ITestTable> _mockRepository;
        public TestTable_T()
        {
            _mockRepository = MockLeaveRepository.GetLeaveTypeRepository();

            var mapperConfig = new MapperConfiguration(m =>
            {
                m.AddProfile<AutoMap>();
            });

            _mapper = mapperConfig.CreateMapper();
        }

        [Fact]
        public async Task GetLeaveTypeListTest()
        {
            var handler = new GetAll_TestTable_H(_mockRepository.Object, _mapper);

            var result = await handler.Handle(new GetAll_TestTable_R(), CancellationToken.None);

            result.ShouldBeOfType<BaseCommandResponse>();
            
            Assert.NotNull(result);
            
        }
    }
}
