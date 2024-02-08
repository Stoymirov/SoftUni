using System.Xml;

IterateFolder(@"C:\\ProgrammingProjects\\SoftUniProjects\\SoftUni\\Advanced");
long IterateFolder(string folderPath, int n = 0)
{
    string[] files = Directory.GetFiles(folderPath);

    foreach (string file in files)
    {
        FileInfo info = new FileInfo(file);
        Console.WriteLine($"{new string(' ',n*3)}{file}");
    }
    string[] directories = Directory.GetDirectories(folderPath);
    foreach (string directory in directories)
    {
        Console.WriteLine(directory);
        IterateFolder(directory,n+1);
    }
        

    return 0;
}