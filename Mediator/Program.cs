using Mediator;

Console.Title = "Mediator";

TeamChatRoom teamChatRoom = new();

var bran = new Lawyer("Bran");
var sansa = new Lawyer("Sansa");
var snow = new AcountManager("Snow");
var rob = new AcountManager("Rob");
var rickon = new AcountManager("Rickon");

teamChatRoom.Register(bran);
teamChatRoom.Register(sansa);
teamChatRoom.Register(snow);
teamChatRoom.Register(rob);
teamChatRoom.Register(rickon);

rob.Send("Some message to everyone");
snow.Send("Some answer to everyone");
snow.Send("Rob","Some message to rob");
rob.SendTo<Lawyer>("Some Message to lawyers");
