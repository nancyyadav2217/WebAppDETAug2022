using APIDemo.Models;

namespace APIDemo.Services
{
    public class TicketServices
    {
        static List<Ticket> Tickets { get; }
        static int nextId = 3;
        static TicketServices()
        {
            Tickets = new List<Ticket>
                {
                    new Ticket { ID=1, BookedFor="Platinum Plus",Price=5000,Qty=202},
                    new Ticket { ID=2, BookedFor="Platinum ",Price=4000,Qty=300 },
                    new Ticket{ ID=3,  BookedFor="Gold",Price=3000,Qty=500},
                    new Ticket{ID = 4,  BookedFor="Silver",Price=2000,Qty=5000},
                    new Ticket{ID = 5,  BookedFor="General",Price=5000,Qty=1000}
                };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket Get(int id)
        {
            Ticket ticket = Tickets.FirstOrDefault(t => t.ID == id);
            return ticket;
        }
    }
}
