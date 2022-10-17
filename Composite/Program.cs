using Directory = Composite.Directory;
using File = Composite.File;

Console.Title = "Composite";

var root = new Directory("root", 0);
var topLevelFile = new Directory("toplevel.txt", 100);
var topLevelDirectory1 = new Directory("topLevelDirectory1", 4);
var topLevelDirectory2 = new Directory("topLevelDirectory2", 4);

root.Add(topLevelFile);
root.Add(topLevelDirectory1);
root.Add(topLevelDirectory2);

var subLevelFile1 = new File("subLevel1.txt", 200);
var subLevelFile2 = new File("subLevel2.txt", 150);

topLevelDirectory1.Add(subLevelFile1);
topLevelDirectory2.Add(subLevelFile2);

Console.WriteLine($"Size of topLevelDirectory1: {topLevelDirectory1.GetSize()}");
Console.WriteLine($"Size of topLevelDirectory2: {topLevelDirectory2.GetSize()}");
Console.WriteLine($"Size of root: {root.GetSize()}");
