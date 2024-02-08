string pathToRead = "../../../alone.jpg";
string pathToWrite = "../../../newMoreWorking2.jpg";

using (FileStream stream = new FileStream(pathToRead, FileMode.Open))
{
    using (FileStream stream2 = new FileStream(pathToWrite, FileMode.Create))
    {
        byte[] buffer = new byte[103];
        while (stream.Position < buffer.Length)
        {
            stream.Read(buffer, 0, buffer.Length);

        }
        for (int i = 0; i < buffer.Length; i++)
        {
            buffer[i] = (byte)(buffer[i] ^ 123);

        }
        stream2.Write(buffer, 0, (int)stream.Length);
    }

}