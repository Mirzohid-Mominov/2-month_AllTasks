Console.WriteLine("Hello, World!");
var currentDirectory = Directory.GetCurrentDirectory();
var parentDirectory = Directory.GetParent(currentDirectory).Parent.Parent.ToString();
var myFileInProjectDirectory = Path.Combine(parentDirectory, "myTxtFile.txt");

Console.WriteLine($"Current Dir {currentDirectory}");
Console.WriteLine($"Parent Dir {parentDirectory}");

File.Create(myFileInProjectDirectory);