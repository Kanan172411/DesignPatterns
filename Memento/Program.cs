using Memento;

Console.Title = "Memento";

CommandManager commandManager = new();
IEmployeeManagerRepository repository = new EmployeeManagerRepository();

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

commandManager.Invoke(
    new AddEmployeeToManagerList(
        repository, 3, new Employee(444, "Walder")));
repository.WriteDataStore();

commandManager.UndoAll();
repository.WriteDataStore();
