﻿namespace Strategy
{
    //Strategy
    public interface IExportService
    {
        void Export(Order order);
    }

    //ConcreteStratege
    public class JsonExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting {order.Name} to Json");
        }
    }

    //ConcreteStrategy
    public class XMlExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting {order.Name} to XML");
        }
    }

    //ConcreteStrategy
    public class CSVExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting {order.Name} to CSV");
        }
    }

    //Context
    public class Order
    {
        public string Customer { get; set; }
        public int Amount { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }

        public IExportService? ExportService { get; set; }

        public Order(string customer, int amount, string name)
        {
            Customer = customer;
            Amount = amount;
            Name = name;
            ExportService = new CSVExportService();
        }

        public void Export()
        {
            ExportService?.Export(this);
        }
    }
}
