using Strategy;

Console.Title = "Strategy";

Order order = new("Kanan", 5, "windows license");
order.Export();

order.ExportService = new XMlExportService();
order.Export();

order.ExportService = new JsonExportService();
order.Export();