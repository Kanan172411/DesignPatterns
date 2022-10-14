using Decorator;

Console.Title = "Decorator";

var cloudMailService = new CloudMailService();
cloudMailService.SendMail("Hello there!");

var onPremiseMailService = new OnPremiseMailService();
onPremiseMailService.SendMail("General Kenobi!");

var statisticDecorator = new StatisticDecorator(cloudMailService);
statisticDecorator.SendMail($"Hello there via {nameof(StatisticDecorator)} wrapper.");

var messageDatabaseDecorator = new MessageDatabaseDecorator(onPremiseMailService);
messageDatabaseDecorator.SendMail($"Hello there via {nameof(MessageDatabaseDecorator)} wrapper message 1");
messageDatabaseDecorator.SendMail($"Hello there via {nameof(MessageDatabaseDecorator)} wrapper message 2");

foreach (var item in messageDatabaseDecorator.SentMessages)
{
    Console.WriteLine($"Stored message: \"{item}\"");
}