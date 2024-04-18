using Exchange.Data.Entity;

namespace Exchange.Repository.IRepositoryInterface
{
    public interface IReightRepository
    {

        void Add(Reight exchange);

        Reight Update(Reight exchange);

        void Delete(int id);

        List<Reight> GetAll();
        Reight GetById(int id);
    }
}
