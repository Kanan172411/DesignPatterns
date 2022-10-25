using ChainOfResponsibility;
using System.ComponentModel.DataAnnotations;

Console.Title = "Chain of Responsibility";

var validDocument = new Document("How to avoid C# Development", DateTimeOffset.UtcNow, true, true);
var invalidDocument = new Document("How to avoid C# Development", DateTimeOffset.UtcNow.AddDays(-60), true, true);

var documentHandlerChain = new DocumentTitleHandler();
documentHandlerChain
    .SetSuccessor(new DocumentTitleHandler())
    .SetSuccessor(new DocumentApprovedByLitigationHandler())
    .SetSuccessor(new DocumentApprovedByManagerHandler())
    .SetSuccessor(new DocumentLastModifiedHandler());

try
{
    documentHandlerChain.Handle(validDocument);
    Console.WriteLine("Valid document is valid");
    documentHandlerChain.Handle(invalidDocument);
    Console.WriteLine("Invalid document is valid");
}
catch (ValidationException ex)
{
    Console.WriteLine(ex.Message);
}
