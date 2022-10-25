using Interpreter;

Console.Title = "Interpreter";

var expressions = new List<RomanExpression>
{
    new RomanHundredExpression(),
    new RomanTenExpression(),
    new RomanOneExpression()
};

var context = new RomanContext(5);
foreach(var item in expressions)
{
    item.Interpret(context);
}

Console.WriteLine($"Translating Arabic numerals to Roman numerals: 5 = {context.Output}");
Console.WriteLine("===================================================================");


context = new RomanContext(81);
foreach(var item in expressions)
{
    item.Interpret(context);
}

Console.WriteLine($"Translating Arabic numerals to Roman numerals: 81= {context.Output}");
Console.WriteLine("===================================================================");


context = new RomanContext(733);
foreach(var item in expressions)
{
    item.Interpret(context);
}

Console.WriteLine($"Translating Arabic numerals to Roman numerals: 733 = {context.Output}");