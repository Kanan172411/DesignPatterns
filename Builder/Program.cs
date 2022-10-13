using BuilderPattern;

Console.Title = "Builder";

Garage garage = new Garage();

MercedesBuilder mercedesBuilder = new MercedesBuilder();
BMWBuilder bmwBuilder = new BMWBuilder();

garage.Construct(mercedesBuilder);
Console.WriteLine(mercedesBuilder.Car.ToString());
garage.Show();

garage.Construct(bmwBuilder);
Console.WriteLine(bmwBuilder.Car.ToString());
garage.Show();

Console.ReadKey();