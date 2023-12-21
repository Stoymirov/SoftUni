using System.IO;
using System.Text;

using (FileStream fileStream = new FileStream("../../../myfile.txt", FileMode.OpenOrCreate))
{
    byte[] buffer = new byte[3];

    while (fileStream.Read(buffer, 0, 3) > 0)
    {
        string bufferAsString = Encoding.UTF8.GetString(buffer);
        Console.WriteLine("Reading next 3 bytes: ");
        Console.WriteLine($"{String.Join(" ", buffer)}");
        Console.WriteLine($"{bufferAsString}");
        Console.WriteLine($"Stream position: {fileStream.Position}");
    }

    fileStream.Position = 0;

}
using (var stream = new FileStream("../../../myfile.txt", FileMode.Append))
{
    string input = Console.ReadLine();
    //byte[] writerBuffer = input.ToCharArray().Select(c => (byte)c).ToArray();
    byte[] writerBuffer = Encoding.UTF8.GetBytes(input);

    stream.Write(writerBuffer, 0, writerBuffer.Length);
      
}