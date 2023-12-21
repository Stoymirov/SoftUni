//string basePath = "../../../Photos/";
//int imageNumber = 1;
//while (File.Exists($"{basePath}image{imageNumber}.jpg"))
//{
//    using (FileStream stream = new FileStream($"{basePath}image{imageNumber}.jpg", FileMode.Open))
//    {
//        byte[] buffer = new byte[stream.Length];

//        stream.Read(buffer, 0, buffer.Length);
//        Console.WriteLine(string.Join(" ", buffer));

//        using (var encryptedStream = new FileStream($"{basePath}image{imageNumber}.encrypted.jpg", FileMode.OpenOrCreate))
//        {
//            for (int i = 0; i < buffer.Length; i++)
//            {
//                buffer[i] = (byte)(buffer[i] ^ 157);
//            }
//            encryptedStream.Write(buffer, 0, buffer.Length);
//        }
//    }

//    imageNumber++;
//}
string basePath = "../../../Photos/";
int imageNumber = 1;
while (File.Exists($"{basePath}image{imageNumber}.encrypted.jpg"))
{
    using (FileStream stream = new FileStream($"{basePath}image{imageNumber}.encrypted.jpg", FileMode.Open))
    {
        byte[] buffer = new byte[stream.Length];

        stream.Read(buffer, 0, buffer.Length);
        Console.WriteLine(string.Join(" ", buffer));

        using (var encryptedStream = new FileStream($"{basePath}image{imageNumber}.jpg", FileMode.OpenOrCreate))
        {
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = (byte)(buffer[i] ^ 157);
            }
            encryptedStream.Write(buffer, 0, buffer.Length);
        }

        Console.WriteLine(string.Join(" ", buffer));
    }

    imageNumber++;
}