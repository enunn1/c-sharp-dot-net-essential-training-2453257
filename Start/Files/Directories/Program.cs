// LinkedIn Learning Course .NET Programming with C# by Joe Marini
// Creating and Deleting Directories

const string dirname = "TestDir";

// TODO: Create a Directory if it doesn't already exist
// if (!Directory.Exists(dirname))
// {
//     Directory.CreateDirectory(dirname);
// }
// else 
// {
//     Directory.Delete(dirname);
// }

// TODO: Get the path for the current directory
string curPath = Directory.GetCurrentDirectory();
// Console.WriteLine($"Current directory is {curPath}");

// TODO: Just like with files, you can retrieve info about a directory
// DirectoryInfo di = new DirectoryInfo(curPath);
// Console.WriteLine($"Directory name: {di.Name}");
// Console.WriteLine($"Parent directory: {di.Parent}"); 
// Console.WriteLine($"Creation time: {di.CreationTime}");   

// TODO: Enumerate the contents of directories
Console.WriteLine("Just directories:");
List<string> dirs = new List<string>(Directory.EnumerateDirectories(curPath));
foreach (string dir in dirs)
{
    Console.WriteLine(dir);
}
Console.WriteLine("---------------");

Console.WriteLine("Just files:");
List<string> files = new List<string>(Directory.EnumerateFiles(curPath));
foreach (string file in files)
{
    Console.WriteLine(file);
}

Console.WriteLine("---------------");

Console.WriteLine("All directory contents:");
List<string> entries = new List<string>(Directory.EnumerateFileSystemEntries(curPath));
foreach (string file in entries)
{
    Console.WriteLine(file);
}