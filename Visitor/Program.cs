using Visitor;

Console.Title = "Visitor";

var container = new Container();

container.Customers.Add(new Customer("Tyrion", 500));
container.Customers.Add(new Customer("Joffrey", 1000));
container.Customers.Add(new Customer("Meryn", 800));
container.Employees.Add(new Employee(12, "Trant"));
container.Employees.Add(new Employee(8, "Clegane"));

DiscountVisitor visitor = new();

container.Accept(visitor);

Console.WriteLine($"Total discount: {visitor.TotalDiscountGiven}");


