using TemplateMethod;

Console.Title = "Template Method";

ExchangeMailParser exchangeMailParser = new();
Console.WriteLine(exchangeMailParser.ParseMailBody("7efee005-3964-4914-acd0-bf14ff3cff13"));

Console.WriteLine("======================================================================");

ApacheMailParser apacheMailParser = new();
Console.WriteLine(apacheMailParser.ParseMailBody("56dc54bd-0146-4409-9014-8ec658e90834"));

Console.WriteLine("======================================================================");

EudoraMailparser eudoraMailParser = new();
Console.WriteLine(eudoraMailParser.ParseMailBody("a6bc9dbc-da9a-4c16-845b-8515fd0317de"));