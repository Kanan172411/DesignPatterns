using Singleton;

Console.Title = "Singleton";

Logger instance1 = Logger.Instance;
Logger instance2 = Logger.Instance;

if (instance1 == instance2 && instance1 == Logger.Instance)
{
    Console.WriteLine("Instances are same");
}

instance1.Log($"Message from: { nameof(instance1)}");
instance2.Log($"Message from: { nameof(instance2)}");

Logger.Instance.Log($"Message from: {nameof(Logger.Instance)}");