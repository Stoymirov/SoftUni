using System.Text;

string text = "myNameIsMitaka";
var fileStream = new FileStream("log.txt",FileMode.OpenOrCreate);
using (fileStream)
{
    byte[] bytes = Encoding.UTF8.GetBytes(text);
    fileStream.Write(bytes,0,bytes.Length);
}