using Command;

Console.Title = "Command";

CommandManager commandManager = new();
EmployeeManagerRepository repository = new ();

commandManager.Invoke(
    new AddEmployeeToManagerList(
        repository, 1, new Employee(111, "Brandon")));
repository.WriteDataStore();

commandManager.Undo();
repository.WriteDataStore();

commandManager.Invoke(
    new AddEmployeeToManagerList(
        repository, 1, new Employee(222, "Stark")));
repository.WriteDataStore();

commandManager.Invoke(
    new AddEmployeeToManagerList(
        repository, 2, new Employee(333, "Theon")));
repository.WriteDataStore();

commandManager.UndoAll();
repository.WriteDataStore();