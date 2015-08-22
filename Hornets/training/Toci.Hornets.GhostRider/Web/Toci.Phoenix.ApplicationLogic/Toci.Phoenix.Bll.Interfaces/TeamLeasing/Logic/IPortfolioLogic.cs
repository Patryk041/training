using Toci.Phoenix.Bll.Interfaces.TeamLeasing.BusinessModel;

namespace Toci.Phoenix.Bll.Interfaces.TeamLeasing.Logic
{
    public interface IPortfolioLogic
    {
        IPortfolioBusinessModel GetEmployeePortfolio(int id);
    }
}