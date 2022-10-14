using Facade;

Console.Title = "Facade";

var facade = new DiscountFacade();

Console.WriteLine($"For id with 1: {facade.CalculateDiscountPercentage(1)}");
Console.WriteLine($"For id with 10: {facade.CalculateDiscountPercentage(10)}");
