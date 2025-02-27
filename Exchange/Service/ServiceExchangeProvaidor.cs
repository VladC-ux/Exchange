﻿
using Exchange.ApiModel;
using Exchange.Data.Entity;
using Exchange.Repository;
using Exchange.Repository.IRepositoryInterface;
using Exchange.Service.IServiceInterface;

namespace Exchange.Service
{
    public class ServiceExchangeProvaidor:IExchangeProvaidorService
    {
        private readonly IExchangeProvaidorRepository _exchange;


        public ServiceExchangeProvaidor(IExchangeProvaidorRepository exchange)
        {
            _exchange = exchange;

        }

        public void Add(ExchangeProvaidorApiModel model)
        {
            ExchangeProvaidor change = new ExchangeProvaidor
            {
                Name = model.Name,
                Type = model.Type,
                Update = model.Update,
            };
            _exchange.Add(change);
        }


        public void Delete(ExchangeProvaidorApiModel model)
        {

            _exchange.Delete(model.Id);
           
        }

       
        public List<ExchangeProvaidorApiModel> GetAll()
        {
            var data = _exchange.GetAll();
            List<ExchangeProvaidorApiModel> changeapimodels = data.Select(change => new ExchangeProvaidorApiModel
            {
                Id = change.Id,
                Name = change.Name,
                Type = change.Type,
               

            }).ToList();
            return changeapimodels;
        }
        public ExchangeProvaidorApiModel GetById(int exchangeid)
        {
            var exchange = _exchange.GetById(exchangeid);
            return new ExchangeProvaidorApiModel
            {

                Id = exchange.Id,
                Name = exchange.Name,
                Type = exchange.Type,
                Update = exchange.Update
            };

        }
        public ExchangeProvaidor Update(ExchangeProvaidorApiModel exchange)
        {
            ExchangeProvaidor change = new ExchangeProvaidor
            {
                Id = exchange.Id,
                Name = exchange.Name,
                Type = exchange.Type,
                Update = exchange.Update,


            };
            _exchange.Update(change);
            return change;
        }

    
    }
}
