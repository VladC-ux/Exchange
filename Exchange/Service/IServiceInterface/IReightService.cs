using Exchange.ApiModel;
using Exchange.Data.Entity;
using Exchange.Repository;

namespace Exchange.Service.IServiceInterface
{
    public interface IReightService
    {
        void Add(ReightApiModel exchange);

        Reight Update(ReightApiModel exchange);

        void Delete(ReightApiModel id);

        List<ReightApiModel> GetAll();

        ReightApiModel GetById(int id);


    }
}
