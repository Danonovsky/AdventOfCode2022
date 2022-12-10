var lines = File.ReadAllLines("input.txt");
var rootDirectory = new Directory("/",null);
var currentDirectory = rootDirectory;

foreach (var line in lines)
{
    var words = line.Split(" ");
    if (words[0].Equals("$"))
    {
        //command
        if (words[1].Equals("cd"))
        {
            //go to directory words[2]
        }

        if (words[1].Equals("ls"))
        {
            //go to saving mode
        }
    }
    else
    {
        if (words[0].Equals("dir"))
        {
            currentDirectory.Directories.Add(new Directory(words[1],currentDirectory));
        }
        else
        {
            currentDirectory.Files.Add(new MyFile(int.Parse(words[0]),words[1]));
        }
    }
}

internal class Directory
{
    public string Name { get; set; }
    public List<Directory> Directories { get; set; } = new();
    public List<MyFile> Files { get; set; } = new();
    public Directory? Parent { get; set; }

    public Directory(string name, Directory? parent)
    {
        Name = name;
        Parent = parent;
    }
}

internal class MyFile
{
    public string Name { get; set; }
    public int Size { get; set; }

    public MyFile(int size,string name)
    {
        Name = name;
        Size = size;
    }
}