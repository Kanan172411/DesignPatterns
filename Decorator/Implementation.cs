﻿namespace Decorator
{
    //Component
    public interface IMailService
    {
        bool SendMail(string message);
    }

    //ConcreteComponent1
    public class CloudMailService : IMailService
    {
        public bool SendMail(string message)
        {
            Console.WriteLine($"Message \"{message}\" " + $"sent via {nameof(CloudMailService)}.");
            return true;
        }
    }

    //ConcreteComponent2
    public class OnPremiseMailService : IMailService
    {
        public bool SendMail(string message)
        {
            Console.WriteLine($"Message \"{message}\" " + $"sent via {nameof(OnPremiseMailService)}.");
            return true;
        }
    }

    //Decorator
    public abstract class MailServiceDecoratorBase : IMailService
    {
        private readonly IMailService _mailService;
        public MailServiceDecoratorBase(IMailService mailService)
        {
            _mailService = mailService;
        }
        public virtual bool SendMail(string message)
        {
            return _mailService.SendMail(message);
        }
    }

    //ConcreteDecorator1
    public class StatisticDecorator : MailServiceDecoratorBase
    {
        public StatisticDecorator(IMailService mailService) : base(mailService)
        {
        }
        public override bool SendMail(string message)
        {
            Console.WriteLine($"Collecting statistics in {nameof(StatisticDecorator)}.");
            return base.SendMail(message);
        }
    }

    //ConcreteDecorator2
    public class MessageDatabaseDecorator : MailServiceDecoratorBase
    {
        public List<string> SentMessages { get; private set; } = new List<string>();
        public MessageDatabaseDecorator(IMailService mailService) : base(mailService)
        {
        }

        public override bool SendMail(string message)
        {
            if (base.SendMail(message))
            {
                SentMessages.Add(message);  
                return true;
            }
            return false;
        }
    }
}
