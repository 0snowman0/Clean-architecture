using Application.Contracts.Persistence.Tables;
using Application.Responses;
using Domain;
using Moq;
using Moq.Language;
namespace UnitTest.Mocks
{
    public static class MockLeaveRepository
    {
        public static Mock<ITestTable> GetLeaveTypeRepository()
        {
            BaseCommandResponse respose = new BaseCommandResponse();

            var TestTables = new List<TestTable4>()
            {
               new TestTable4 { Id = 1, Name = "kasra"} ,
               new TestTable4 { Id = 2, Name = "Mahsa"} ,
               new TestTable4{ Id = 3, Name = "noBody"}
            };

            var mockRepo = new Mock<ITestTable>();
            mockRepo.Setup(r => r.GetAll()).ReturnsAsync(TestTables);

            

            mockRepo.Setup(r => r.Add(It.IsAny<Domain.TestTable4>()))
                .Returns((Domain.TestTable4 testTable) =>
                {
                    TestTables.Add(testTable);
                    respose.Data = testTable;
                    return Task.FromResult(respose.Data); // برگرداندن Task
                });


            return mockRepo;
        }
    }
}

