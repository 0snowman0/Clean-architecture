using Application.Contracts.Persistence.Tables;
using Application.Dto.TestTable.command;
using Application.Features.TestTable.Handlers.Commands;
using Application.Features.TestTable.Requests.Commands;
using Application.Profile;
using Application.Responses;
using AutoMapper;
using Domain;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.Mocks;
using Xunit.Sdk;

namespace UnitTest.TestTable.command
{
    public class Create_TestTable_T
    {

        IMapper _mapper;
        Mock<ITestTable> _mockRepository;
        TestTable_Create_Dto _TestTable_Create_Dto ;
        public Create_TestTable_T()
        {
            _mockRepository = MockLeaveRepository.GetLeaveTypeRepository();

            var mapperConfig = new MapperConfiguration(m =>
            {
                m.AddProfile<AutoMap>();
            });

            _mapper = mapperConfig.CreateMapper();

            _TestTable_Create_Dto = new TestTable_Create_Dto()
            {
                Name = "Test DTO"
            };
        }

        [Fact]
        public async Task Create_TestTable_Test()
        {
            
            var handler = new Create_TestTable_H(_mockRepository.Object, _mapper);
            var result = await handler.Handle(new Create_TestTable_R()
            {
                testTable_Create_Dto = _TestTable_Create_Dto
            }, CancellationToken.None);

            result.ShouldBeOfType<BaseCommandResponse>();

            var testTables = await _mockRepository.Object.GetAll();

            testTables.Count().ShouldBe(4);
        }

        [Fact]
        public void  sum()
        {
            int p = 4;
            Assert.Equal(p , 4);
        }

    }
}
