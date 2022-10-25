namespace Observer
{
    public class TicketChange
    {
        public int Amount { get; private set; }
        public int ArtistId { get; private set; }

        public TicketChange(int amount, int artistId)
        {
            Amount = amount;
            ArtistId = artistId;
        }
    }

    //Subject
    public abstract class TicketChangeNotifier
    {
        private List<ITicketChangeListener> _observers = new();

        public void AddObserver(ITicketChangeListener observer)
        {
            _observers.Add(observer);   
        }

        public void RemoveObserver(ITicketChangeListener observer)
        {
            _observers.Remove(observer);
        }

        public void Notify(TicketChange ticketChange)
        {
            foreach (var item in _observers)
            {
                item.ReceiveTicketChangeNotification(ticketChange);
            }
        }
    }

    //Observer
    public interface ITicketChangeListener
    {
        void ReceiveTicketChangeNotification(TicketChange ticketChange); 
    }

    //ConcreteSubject
    public class OrderService : TicketChangeNotifier
    {
        public void CompleteTicketSales(int artistId, int amount)
        {
            Console.WriteLine($"{nameof(OrderService)} is changing its state.");
            Console.WriteLine($"{nameof(OrderService)} is notifying observers...");
            Notify(new TicketChange(artistId, amount));
        }
    }

    //ConcreteObserver
    public class TicketResellerService : ITicketChangeListener
    {
        public void ReceiveTicketChangeNotification(TicketChange ticketChange)
        {
            Console.WriteLine($"{nameof(TicketResellerService)} notified " + 
                $"of ticket change: artist {ticketChange.ArtistId}, amount " +
                $"{ticketChange.Amount}");
        }
    }

    //ConcreteObserver
    public class TicketStockService : ITicketChangeListener
    {
        public void ReceiveTicketChangeNotification(TicketChange ticketChange)
        {
            Console.WriteLine($"{nameof(TicketStockService)} notified " +
               $"of ticket change: artist {ticketChange.ArtistId}, amount " +
               $"{ticketChange.Amount}");
        }
    }
}
