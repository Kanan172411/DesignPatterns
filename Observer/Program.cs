using Observer;

Console.Title = "Observer";

TicketStockService ticketStockService = new();
TicketResellerService resellerService = new();
OrderService orderService = new();

orderService.AddObserver(ticketStockService);
orderService.AddObserver(resellerService);

orderService.CompleteTicketSales(1, 2);

Console.WriteLine();
orderService.RemoveObserver(resellerService);
orderService.CompleteTicketSales(4, 5);
