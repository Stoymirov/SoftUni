using System.Text;

string path = "../../../text.txt";
using (FileStream stream = new FileStream(path, FileMode.Open))
{
    
    byte[] buffer = new byte[20];
    while (stream.Position < stream.Length)
    {
        stream.Read(buffer, 0, 20);
        string s = Encoding.UTF8.GetString(buffer);
        Console.WriteLine(s);
      
    }
}

using (StreamReader reader = new StreamReader(path))
{
    char[] chars = reader.ReadToEnd().ToCharArray();
    int n = chars.Length/20;
    Console.WriteLine(Math.Ceiling((chars.Length/ (decimal)20)));

}