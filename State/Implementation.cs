namespace State
{
    //State
    public abstract class BankAccountState
    {
        public BankAccount BankAccouunt { get; protected set; } = null!;
        public decimal Balance { get; set; }

        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
    }

    //ConcreteState
    public class RegularState : BankAccountState
    {
        public RegularState(decimal balance, BankAccount bankAccount)
        {
            BankAccouunt = bankAccount;
            Balance = balance;
        }
        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, depositing {amount}");
            Balance += amount;
            if(Balance >= 1000)
            {
                BankAccouunt.BankAccountState = new GoldState(Balance, BankAccouunt);
            }
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, withdrawing {amount} from {Balance}");
            Balance -= amount;
            if (Balance < 0)
            {
                BankAccouunt.BankAccountState = new OverdrawnState(Balance, BankAccouunt);
            }
        }
    }

    //ConcreteState
    public class OverdrawnState : BankAccountState
    {
        public OverdrawnState(decimal balance, BankAccount bankAccount)
        {
            BankAccouunt = bankAccount;
            Balance = balance;
        }
        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, depositing {amount}");
            Balance += amount;
            if (Balance >= 0)
            {
                BankAccouunt.BankAccountState = new RegularState(Balance, BankAccouunt);
            }
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, cannot withdraw, balance {Balance}");
        }
    }

    //ConcreteState
    public class GoldState : BankAccountState
    {
        public GoldState(decimal balance, BankAccount bankAccount)
        {
            Balance = balance;
            BankAccouunt = bankAccount; 
        }
        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, depositing " + $"{amount} + 10% bonus: {amount/10}");
            Balance += amount + (amount / 10);
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, withdrawing {amount} from {Balance}");
            Balance -= amount;
            if (Balance < 1000 && Balance >= 0)
            {
                BankAccouunt.BankAccountState = new RegularState(Balance, BankAccouunt);
            }
            else if(Balance < 0)
            {
                BankAccouunt.BankAccountState = new OverdrawnState(Balance, BankAccouunt);
            }
        }
    }

    //Context
    public class BankAccount
    {
        public BankAccountState BankAccountState { get; set; }
        public decimal Balance { get { return BankAccountState.Balance; } }

        public BankAccount()
        {
            BankAccountState = new RegularState(200, this);
        }

        public void Deposit(decimal amount)
        {
            BankAccountState.Deposit(amount);
        }

        public void Withdraw(decimal amount)
        {
            BankAccountState.Withdraw(amount);
        }
    }
}
