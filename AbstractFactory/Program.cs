using AbstractFactory;

Console.Title = "Abstract Factory";

var azerbaijanShoppingCardPurchaseFactory = new AzerbaijanShoppingCardPurchaseFactory();
var shoppingCardForAzerbaijan = new ShoppingCard(azerbaijanShoppingCardPurchaseFactory);
shoppingCardForAzerbaijan.CalculateCosts();

var germanyShoppingCardPurchaseFactory = new GermanyShoppingCardPurchaseFactory();
var shoppingCardForGermany = new ShoppingCard(germanyShoppingCardPurchaseFactory);
shoppingCardForGermany.CalculateCosts();