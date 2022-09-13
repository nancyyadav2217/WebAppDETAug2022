namespace APIDemo.Models
{
    public class Ticket
    {
        public int ID { get; set; }
        public string BookedBy { get; set; }
        public string BookedFor { get; set; }
        public int Qty { get; set; }
        public int Price { get; set; }

    }
}
