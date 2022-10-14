using Bridge;

Console.Title = "Bridge";

var noCoupon = new NoCoupon();
var oneManatCoupon = new OneManatCoupon();
var twoManatCoupon = new TwoManatCoupon();


var meatBasedMenu = new MeatbasedMenu(noCoupon);
Console.WriteLine($"Meat based menu, no coupon: {meatBasedMenu.CalculatePrice()} manat.");

var meatBasedMenu1 = new MeatbasedMenu(oneManatCoupon);
Console.WriteLine($"Meat based menu, one manat coupon: {meatBasedMenu1.CalculatePrice()} manat.");

var meatBasedMenu2 = new MeatbasedMenu(twoManatCoupon);
Console.WriteLine($"Meat based menu, two manat coupon: {meatBasedMenu2.CalculatePrice()} manat.");


var vegeterianMenu = new VegettarianMenu(noCoupon);
Console.WriteLine($"Vegeterian menu, no coupon: {vegeterianMenu.CalculatePrice()} manat.");

var vegeterianMenu1 = new VegettarianMenu(oneManatCoupon);
Console.WriteLine($"Vegeterian menu, one manat coupon: {vegeterianMenu1.CalculatePrice()} manat.");

var vegeterianMenu2 = new VegettarianMenu(twoManatCoupon);
Console.WriteLine($"Vegeterian menu, two manat coupon: {vegeterianMenu2.CalculatePrice()} manat.");