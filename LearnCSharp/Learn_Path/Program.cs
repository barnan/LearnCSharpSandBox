// See https://aka.ms/new-console-template for more information



string path = "file.srpx";

string path0 = Path.GetFileNameWithoutExtension(path) + ".";

string path2 = Path.ChangeExtension(path, ".jpg");
string path3 = Path.ChangeExtension(path, "png");

string path4 = Path.Combine("C:\\", Path.ChangeExtension(path0,"txt"));
string path5 = Path.Combine("C:\\", Path.ChangeExtension(path0, ".txt"));

Console.WriteLine(path);
Console.WriteLine(path0);
Console.WriteLine(path2);
Console.WriteLine(path3);
Console.WriteLine(path4);
Console.WriteLine(path5);


var result = Directory.GetFiles(@"c:\source\Configurations-SRP-2100\Configuration\", "*.txt");

Console.ReadKey();

