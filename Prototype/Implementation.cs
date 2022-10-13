using Newtonsoft.Json;
namespace Prototype
{
    //Prototype
    public abstract class Person
    {
        public abstract string Name { get; set; }

        public abstract Person Clone(bool deepClone);
    }

    //ConcretePrototype
    public class Manager : Person
    {
        public override string Name { get ; set ; }

        public Manager(string name)
        {
            Name = name;
        }

        public override Person Clone(bool deepClone = false)
        {
            var objectAsJson = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject<Manager>(objectAsJson);
            return (Person)MemberwiseClone();   
        }
    }

    //ConcretePrototype
    public class Employee : Person
    {
        public Manager Manager { get; set; }

        public override string Name { get; set ; }

        public Employee(Manager manager, string name)
        {
            Manager = manager;
            Name = name;
        }

        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var objectAsJson = JsonConvert.SerializeObject(this);
                return JsonConvert.DeserializeObject<Employee>(objectAsJson);
            }
            return(Employee)MemberwiseClone();
        }
    }
}
