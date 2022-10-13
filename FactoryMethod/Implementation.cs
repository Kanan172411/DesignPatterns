namespace FactoryMethod
{
    //Product
    public abstract class DiscountService
    {
        public abstract int DiscountPercentage { get; }
        public override string ToString() => GetType().Name;

    }

    //ConcreteProduct
    public class CountryDiscountService : DiscountService
    {
        private readonly string _countryIdentifier;

        public CountryDiscountService(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }

        public override int DiscountPercentage
        {
            get
            {
                switch (_countryIdentifier)
                {
                    case "AZE":
                        return 50;
                    default:
                        return 10;
                }
            }
        }
    }

    //ConcreteProduct
    public class CodeDiscountService : DiscountService
    {
        private readonly Guid _code;

        public CodeDiscountService(Guid code)
        {
            _code = code;
        }

        public override int DiscountPercentage
        {
            get => 15;
        }
    }

    //Creator
    public abstract class DiscountFactory
    {
        public abstract DiscountService CreateDiscountService();
    }

    //ConcreteCreator
    public class CountryDiscountFactory : DiscountFactory
    {
        private readonly string _countryIdentifier;

        public CountryDiscountFactory(string countryIdentifier)
        {
            _countryIdentifier = countryIdentifier;
        }

        public override DiscountService CreateDiscountService()
        {
            return new CountryDiscountService(_countryIdentifier);
        }
    }

    //ConcreteCreator
    public class CodeDiscountFactory : DiscountFactory
    {
        private readonly Guid _code;

        public CodeDiscountFactory(Guid code)
        {
            _code = code;
        }
        public override DiscountService CreateDiscountService()
        {
            return new CodeDiscountService(_code);
        }
    }
}
