namespace Visitor
{
    //ConcreteElement
    public class Customer : IElement
    {
        public decimal AmountOrdered { get; private set; }
        public decimal Discount { get; set; }
        public string Name { get; private set; }

        public Customer(string name, decimal amountOrdered)
        {
            Name = name;
            AmountOrdered = amountOrdered;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            Console.WriteLine($"Visited {nameof(Customer)} {Name}, discount given {Discount}");
        }
    }

    //ConcreteElement
    public class Employee : IElement
    {
        public int YearsEmployeed { get; private set; }
        public decimal Discount { get; set; }
        public string Name { get; private set; }

        public Employee(int yearsEmployeed, string name)
        {
            YearsEmployeed = yearsEmployeed;
            Name = name;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            Console.WriteLine($"Visited {nameof(Employee)} {Name}, discount given {Discount}");
        }
    }

    //Visitor
    public interface IVisitor
    {
        void Visit(IElement element);
    }

    //Element
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }

    //ConcreteVisitor
    public class DiscountVisitor : IVisitor
    {
        public decimal TotalDiscountGiven { get; set; }

        public void Visit(IElement element)
        {
            if (element is Customer)
            {
                VisitCustomer((Customer)element);
            }
            else if (element is Employee)
            {
                VisitEmployee((Employee)element);
            }
        }

        private void VisitCustomer(Customer customer)
        {
            var discount = customer.AmountOrdered / 10;
            customer.Discount = discount;
            TotalDiscountGiven += discount;
        }

        private void VisitEmployee(Employee employee)
        {
            var discount = employee.YearsEmployeed < 10 ? 100 : 200;
            employee.Discount = discount;
            TotalDiscountGiven += discount;
        }
    }

    //ObjectStructure
    public class Container
    {
        public List<Employee> Employees { get; set; } = new();
        public List<Customer> Customers { get; set; } = new();

        public void Accept(IVisitor visitor)
        {
            foreach (var item in Employees)
            {
                item.Accept(visitor);
            }
            foreach (var item in Customers)
            {
                item.Accept(visitor);
            }
        }
    }
}
