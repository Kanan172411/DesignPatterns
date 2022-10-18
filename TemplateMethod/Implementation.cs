namespace TemplateMethod
{ 
    //Abstract class
    public abstract class MailParser
    {
        public virtual void FindServer()
        {
            Console.WriteLine("Finding server ...");
        }

        public abstract void AuthenticateToServer();

        public string ParseHtmlMailBody(string identifier)
        {
            Console.WriteLine("Parsing Html mail body ...");
            return $"This is the body of mail with id {identifier}";
        }

        //Template Method
        public string ParseMailBody(string identifier)
        {
            Console.WriteLine("Parsing mail body (in template method) ...");
            FindServer();
            AuthenticateToServer();
            return ParseHtmlMailBody(identifier);
        }
    }

    public class ExchangeMailParser : MailParser
    {
        public override void AuthenticateToServer()
        {
            Console.WriteLine("Connecting to Exchange");
        }
    }

    public class ApacheMailParser : MailParser
    {
        public override void AuthenticateToServer()
        {
            Console.WriteLine("Connecting to Apache");
        }
    }

    public class EudoraMailparser : MailParser
    {
        public override void AuthenticateToServer()
        {
            Console.WriteLine("Connecting to Eudora");
        }

        public override void FindServer()
        {
            Console.WriteLine("Finding Eudora server through a custom algorithm...");
        }
    }
}
