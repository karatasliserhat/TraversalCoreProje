using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Data;
using TraversalCoreProje.BusinessLayer.Interfaces;
using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.DataAccessLayer.Concreate;
using TraversolCoreProje.DataAccessLayer.Interfaces;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Services
{
    public class VisitorReadService : GenericReadService<ResultVisitorDto, Visitor>, IVisitorReadService
    {
        private readonly AppDbContext _appDbContext;
        public VisitorReadService(IGenericReadRepository<Visitor> genericReadRepository, IMapper mapper, AppDbContext appDbContext) : base(genericReadRepository, mapper)
        {
            _appDbContext = appDbContext;
        }

        public List<VisitorChartDto> GetVisitorChart()
        {
            List<VisitorChartDto> visitorChartDtos = new List<VisitorChartDto>();

            using (var command = _appDbContext.Database.GetDbConnection().CreateCommand())
            {

                command.CommandText = "SELECT * FROM(SELECT cast([VisitorDate] as date) as tarih,City,Count FROM Visitors) ps PIVOT (SUM(Count) FOR City IN ([1],[2],[3],[4],[5],[6])) AS pvt order by tarih desc";

                command.CommandType = CommandType.Text;
                _appDbContext.Database.OpenConnection();

                using (var reader = command.ExecuteReader())
                {

                    while (reader.Read())
                    {
                        VisitorChartDto visitorChartDto = new VisitorChartDto();


                        visitorChartDto.VisitDate = reader.GetDateTime(0).ToShortDateString();

                        Enumerable.Range(1, 6).ToList().ForEach(x =>
                        {
                            visitorChartDto.Counts.Add(reader.GetInt32(x));
                        });

                        visitorChartDtos.Add(visitorChartDto);

                    }
                }
                _appDbContext.Database.CloseConnection();
            }
            return visitorChartDtos;
        }
    }
}
