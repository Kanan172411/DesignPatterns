using FactoryMethod;

Console.Title = "Factory Method";

List<DiscountFactory> factories = new List<DiscountFactory>
{
    new CodeDiscountFactory(Guid.NewGuid()),
    new CountryDiscountFactory("AZE")
};

foreach (var factory in factories)
{
    DiscountService discountService = factory.CreateDiscountService();
    Console.WriteLine($"Percentage: {discountService.DiscountPercentage} " + $" Came from: {discountService}");
}