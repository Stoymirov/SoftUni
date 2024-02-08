using System.Text;

string path = "../../../text.txt";

using (FileStream stream = new FileStream(path,FileMode.Open))
{
    byte[] buffer = new byte[20];
    

    
    while (stream.Position < stream.Length)
    {

        stream.Read(buffer, 0, buffer.Length);
        string input = Encoding.UTF8.GetString(buffer);
        Console.WriteLine(input);
        Thread.Sleep(1000);
    }
}
