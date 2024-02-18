using Application.Dto.TestTable.command;
using Application.Dto.TestTable.Queries;
using Domain;

namespace Application.Profile
{
    public class AutoMap : AutoMapper.Profile
    {
        public AutoMap()
        {
            //TestTable
            CreateMap<TestTable4, TestTable_Dto>().ReverseMap();

            CreateMap<TestTable4, TestTable_Create_Dto>().ReverseMap();
            
            CreateMap<TestTable4, TestTable_Update_Dto>().ReverseMap();
        }
    }
}
