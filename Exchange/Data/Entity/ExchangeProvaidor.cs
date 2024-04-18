namespace Exchange.Data.Entity
{
    public class ExchangeProvaidor
    {
        public int Id { get; set; } 

        public string Name { get; set; }    

        public Types Type { get; set; }

        public DateTime Update { get; set; }

        public int ExchangeProvaidorId { get; set; }
        public virtual ExchangeProvaidor ExchangeProvaidors { get; set; }
    }
}
