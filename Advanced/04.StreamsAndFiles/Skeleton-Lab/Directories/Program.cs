
//for(int i = 0;i<10; i++)
//{
//    Directory.CreateDirectory($"../../../{i + 1}.CustomFolder");
//}
//Directory.CreateDirectory("../../../AllInFolder");
//for (int i = 0; i < 10; i++)
//{
//    Directory.Move($"../../../{i + 1}.CustomFolder", $"../../../AllInFolder/{i+1}.CustomMovedFolder");
//}
string[] fileNames = Directory.GetFiles("../../../");
foreach (string fileName in fileNames)
{
    Console.WriteLine(fileName);
    FileInfo fileInfo = new FileInfo(fileName);
}


string[] subDir = Directory.GetDirectories("../../../");

foreach (var VARIABLE in subDir)
{
    Console.WriteLine(VARIABLE);
}