using Exchange.ApiModel;
using Exchange.Service;
using Exchange.Service.IServiceInterface;
using Microsoft.AspNetCore.Mvc;

namespace Exchange.Contoller
{
    public class ChangeConrtoller : Controller
    {
        private readonly IExchangeProvaidorService _exchange;
        private readonly IReightService _reight;

        public ChangeConrtoller(IExchangeProvaidorService exchange, IReightService reight)
        {
            _exchange = exchange;
            _reight = reight;
        }


        public IActionResult Index()
        {

             var list = _exchange.GetAll();
             return Ok(list);


        }
        public IActionResult IndexReight()
        {
            var list = _reight.GetAll();
            return Ok(list);
        }

        public IActionResult Add(ExchangeProvaidorApiModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                _exchange.Add(model);

                return Ok(model);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }


        public IActionResult Add(ReightApiModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                _reight.Add(model);

                return Ok(model);
            }
            catch (Exception ex)
            {
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }

        public IActionResult Delete(ExchangeProvaidorApiModel model)
        {
            _exchange.Delete(model);
            return Ok();
        }
        public IActionResult Delete(ReightApiModel model)
        {
            _reight.Delete(model);
            return Ok();
        }









    }
}
