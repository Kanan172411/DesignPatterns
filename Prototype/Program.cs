using Prototype;

Console.Title = "Prototype";

Manager manager = new Manager("Les");
Manager managerClone = (Manager)manager.Clone();
Console.WriteLine($"Manager has been cloned: {managerClone.Name}");

Employee employee = new Employee(managerClone, "Jackson");
Employee employeeClone = (Employee)employee.Clone(true);
Console.WriteLine($"Employee has been cloned: {employeeClone.Name} " + $" with manager {employeeClone.Manager.Name}");

managerClone.Name = "Kanan";
Console.WriteLine($"Employee has been cloned: {employeeClone.Name} " + $" with manager {employeeClone.Manager.Name}");
