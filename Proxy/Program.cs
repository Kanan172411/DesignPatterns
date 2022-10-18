using Proxy;
Console.Title = "Proxy";

//without proxy
Console.WriteLine("Constructing Document");
var myDocument = new Document("index.js");
Console.WriteLine("Constructed");
myDocument.DisplayDocument();

Console.WriteLine("========================================================");

//with proxy
Console.WriteLine("Constructing Document proxy");
var myDocumentProxy = new DocumentProxy("main.js");
Console.WriteLine("Document Proxy Constructed");
myDocumentProxy.DisplayDocument();

Console.WriteLine("========================================================");

//with chanied proxy
Console.WriteLine("Constructing Protected Document Proxy");
var myProtectedDocumentProxy = new ProtectedDocumentProxy("main.js", "Viewer");
Console.WriteLine("Protected Document Proxy Constructed");
myProtectedDocumentProxy.DisplayDocument();

Console.WriteLine("========================================================");

//with chained proxy no access
Console.WriteLine("Constructing Protected Document Proxy");
myProtectedDocumentProxy = new ProtectedDocumentProxy("main.js", "AnotherRole");
Console.WriteLine("Protected Document Proxy Constructed");
myProtectedDocumentProxy.DisplayDocument();
