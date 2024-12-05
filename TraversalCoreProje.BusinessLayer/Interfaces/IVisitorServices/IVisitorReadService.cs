using TraversalCoreProje.CoreLayer.Concrete;
using TraversolCoreProje.Dto.Dtos;

namespace TraversalCoreProje.BusinessLayer.Interfaces
{
    public interface IVisitorReadService:IGenericReadService<ResultVisitorDto,Visitor>
    {
        List<VisitorChartDto> GetVisitorChart();
    }
}
