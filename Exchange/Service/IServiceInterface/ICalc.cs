using Exchange.Data.Entity;

namespace Exchange.Service.IServiceInterface
{
    public interface ICalc
    {
        decimal ConvertCurrency(decimal amount, decimal exchangeRate, List<Type> banktype);

    }
}
