using Exchange.ApiModel;
using Exchange.Data.Entity;
using Exchange.Repository.IRepositoryInterface;
using Exchange.Service.IServiceInterface;

namespace Exchange.Service
{
    public class ServiceReightService : IReightService
    {
        private readonly IReightRepository _reight;
        public ServiceReightService(IReightRepository reight)
        {
            _reight = reight;

        }
        public void Add(ReightApiModel model)
        {
            Reight change = new Reight
            {
                Buy = model.Buy,
                Sell = model.Sell,
                Currecny = model.Currecny

            };
            _reight.Add(change);

        }

        public void Add(Reight exchange)
        {
            throw new NotImplementedException();
        }

        public void Delete(ReightApiModel model)
        {

            _reight.Delete(model.Id);

        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<ReightApiModel> GetAll()
        {
            var data = _reight.GetAll();
            List<ReightApiModel> exchangeprovaidorapimodel = data.Select(change => new ReightApiModel
            {
               Id = change.Id,
               Buy = change.Buy,    
               Sell = change.Sell,
               Currecny = change.Currecny,


            }).ToList();
            return exchangeprovaidorapimodel;
        }

        public ReightApiModel GetById(int reightid)
        {
            var changeid = _reight.GetById(reightid);
            return new ReightApiModel
            {

                Id = changeid.Id,
                Sell = changeid.Sell,
                Buy = changeid.Buy,
                Currecny = changeid.Currecny

              
            };

        }

        public Reight Update(ReightApiModel model)
        {
            Reight reight = new Reight
            {
                Id = model.Id,
                Sell = model.Sell,
                Buy = model.Buy,
                Currecny = model.Currecny,


            };
            _reight.Update(reight);
            return reight;
        }

    

        
    }
}
