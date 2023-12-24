
using System.Text;

namespace DirectoryTraversal;
public class DirectoryTraversal

{
    static void Main()
    {
        string path = Console.ReadLine();
        string reportFileName = @"\report.txt";

       string reportContent = TraverseDirectory(path);
       Console.WriteLine(reportContent);

        WriteReportToDesktop(reportContent, reportFileName);
    }


    private static string TraverseDirectory(string inputFolderPath)
    {
        SortedDictionary<string,Dictionary<string,double>> dictionary = new SortedDictionary<string,Dictionary<string,double>>();
        
        StringBuilder sb = new StringBuilder();

        DirectoryInfo directoryInfo = new DirectoryInfo(inputFolderPath);

        FileInfo[] files = directoryInfo.GetFiles();

        foreach (FileInfo file in files)
        {
            string extension = file.Extension;
            if (!dictionary.ContainsKey(extension))
            {
                dictionary.Add(extension,new Dictionary<string, double>());
            }
            dictionary[extension].Add(file.Name,file.Length);
        }

        foreach (var keyValuePair in dictionary.OrderByDescending(x=>x.Value.Count))
        {
            sb.AppendLine(keyValuePair.Key);
            foreach (var kvp2 in keyValuePair.Value.OrderBy(s=>s.Value))
            {
                sb.AppendLine($"--{kvp2.Key} - {kvp2.Value/1024:f3}kb");
            }
        }
        
        return sb.ToString();
    }
    private static void WriteReportToDesktop(string textContent, string reportFileName)
    {
        string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;
        
        File.WriteAllText(filePath, textContent);
    }


}