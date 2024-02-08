
string path = @"C:\ProgrammingProjects\SoftUniProjects\SoftUni\Advanced";
Console.WriteLine(Iterator(path)/1024/1024);
long Iterator(string path, int n = 0)
{
    string[] files = Directory.GetFiles(path);

    long size = 0;
    foreach (var file in files)
    {
        FileInfo info = new FileInfo(file);
        size += info.Length;
    }
    string[] directories = Directory.GetDirectories(path);
    foreach (var directory in directories)
    {
        size += Iterator(directory);

    }
    return size;
}