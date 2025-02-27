﻿using Exchange.Data.Entity;
using Exchange.Data;
using Exchange.Repository.IRepositoryInterface;

namespace Exchange.Repository
{
    public class ReightRepository:IReightRepository
    {
        private readonly DBContextExchange _context;


        public ReightRepository(DBContextExchange context)
        {
            _context = context;
        }
        public void Add(Reight reight)
        {
            _context.Reights.Add(reight);
            _context.SaveChanges();
            
        }

        public Reight Update(Reight reight)
        {

            var entity = _context.Reights.FirstOrDefault(p => p.Id == reight.Id);
            entity.Sell = reight.Sell;
            entity.Buy = reight.Buy;
            entity.Currecny = reight.Currecny;
            _context.Reights.Update(entity);
            _context.SaveChanges();
            return entity;
        }

        public void Delete(int id)
        {
            var querry = _context.ExchangeProvadiors.Find(id);
            if (querry != null)
            {
                _context.ExchangeProvadiors.Remove(querry);
            }

        }

      

        public List<Reight> GetAll()
        {
            return _context.Reights.ToList();
        }

        public Reight GetById(int id)
        {
            return _context.Reights.FirstOrDefault(r => r.Id == id);
        }
    }
}
