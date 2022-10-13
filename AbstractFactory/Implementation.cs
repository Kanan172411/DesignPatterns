namespace AbstractFactory
{
   //AbstractFactory
   public interface IShoppingCardPurchaseFactory
    {
        IDiscountService CreateDiscountService();

        IShippingCostsService CreateShippingCostsService();
    }

    //AbstractProduct
    public interface IDiscountService
    {
        int DiscountPercentage { get; }
    }

    //ConcreteProduct
    public class AzerbaijanDiscountService : IDiscountService
    {
        public int DiscountPercentage => 50;
    }

    //ConcreteProduct
    public class GermanyDiscountService : IDiscountService
    {
        public int DiscountPercentage => 20;
    }

    //AbstractProduct
    public interface IShippingCostsService
    {
        decimal ShippingCosts { get; }
    }

    //ConcreteProduct
    public class AzerbaijanShippingCosts : IShippingCostsService
    {
        public decimal ShippingCosts => 10;
    }

    //ConcreteProduct
    public class GermanyShippingCosts : IShippingCostsService
    {
        public decimal ShippingCosts => 20;
    }

    //ConcreteFactory
    public class AzerbaijanShoppingCardPurchaseFactory : IShoppingCardPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new AzerbaijanDiscountService();
        }

        public IShippingCostsService CreateShippingCostsService()
        {
            return new AzerbaijanShippingCosts();
        }
    }

    //ConcreteFactory
    public class GermanyShoppingCardPurchaseFactory : IShoppingCardPurchaseFactory
    {
        public IDiscountService CreateDiscountService()
        {
            return new GermanyDiscountService();
        }

        public IShippingCostsService CreateShippingCostsService()
        {
            return new GermanyShippingCosts();
        }
    }

    //Client class
    public class ShoppingCard
    {
        private readonly IDiscountService _discountService;
        private readonly IShippingCostsService _shippingCostsService;
        private int _orderCosts;

        public ShoppingCard(IShoppingCardPurchaseFactory factory)
        {
            _discountService = factory.CreateDiscountService();
            _shippingCostsService = factory.CreateShippingCostsService();
            _orderCosts = 200;
        }
        public void CalculateCosts()
        {
            Console.WriteLine($"Total Cost =  " +
                $"{_orderCosts - (_orderCosts * _discountService.DiscountPercentage / 100) + _shippingCostsService.ShippingCosts}");
        }
    }

}
