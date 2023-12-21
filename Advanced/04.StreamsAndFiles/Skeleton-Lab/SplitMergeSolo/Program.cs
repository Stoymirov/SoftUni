int parts = 2;

using (FileStream stream = new FileStream("../../../New Text Document.txt", FileMode.Open))
{
    long length = stream.Length / parts;

    for (int i = 0; i < parts; i++)
    {
        using (FileStream newStream = new FileStream($"../../../textFile{i + 1}.txt", FileMode.OpenOrCreate))
        {
            byte[] buffer;
            if (i == parts - 1) // For the last part, read the remaining bytes
            {
                buffer = new byte[stream.Length - (i * length)];
            }
            else
            {
                buffer = new byte[length];
            }

            int bytesRead = stream.Read(buffer, 0, buffer.Length);
            newStream.Write(buffer, 0, bytesRead);
        }
    }
}