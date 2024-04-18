namespace Exchange.Data.Entity
{
    public class Reight
    {
        public int Id { get; set; } 
        public decimal Currecny { get; set; }
        public decimal Buy { get; set; }
        public decimal Sell { get; set; }


        public virtual ICollection<Reight> Reights { get; set; }
    }
}
