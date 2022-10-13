using System.Text;

namespace BuilderPattern
{
    //Product
    public class Car
    {
        private readonly List<string> _parts = new();
        private readonly string _carType;

        public Car(string carType)
        {
            _carType = carType;
        }

        public void AddPart(string part)
        {
            _parts.Add(part);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var part in _parts)
            {
                sb.Append($"Car of type {_carType} has part {part}");
            }
            return sb.ToString();
        }
    }

    //Builder
    public abstract class CarBuilder
    {
       public Car Car { get; private set; }

        public CarBuilder(string carType)
        {
            Car = new Car(carType);
        }

        public abstract void BuildEngine();
        public abstract void BuildFrame();
    }

    //ConcreteBuilder
    public class MercedesBuilder : CarBuilder
    {
        public MercedesBuilder() : base("Mercedes")
        {

        }

        public override void BuildEngine()
        {
            Car.AddPart("'W16'");
        }

        public override void BuildFrame()
        {
            Car.AddPart("'2 door without stripes'");
        }
    }

    //ConcreteBuilder
    public class BMWBuilder : CarBuilder
    {
        public BMWBuilder() : base("BMW")
        {

        }

        public override void BuildEngine()
        {
            Car.AddPart("'L6'");
        }

        public override void BuildFrame()
        {
            Car.AddPart("'4 door with stripes'");
        }
    }

    //Director
    public class Garage
    {
        private CarBuilder _builder;

        public Garage()
        {

        }

        public void Construct(CarBuilder builder)
        {
            _builder = builder;

            _builder.BuildEngine();
            _builder.BuildFrame();
        }

        public void Show()
        {
            Console.WriteLine(_builder?.Car.ToString());
        }
    }
}
