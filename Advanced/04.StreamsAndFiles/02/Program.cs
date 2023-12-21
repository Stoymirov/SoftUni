using (StreamReader reader = new StreamReader("../../../input.txt"))
{
  string line=  reader.ReadLine();
  int row = 0;
  while (line!=null)
  {
      Console.WriteLine($"{++row}.{line}");
      line = reader.ReadLine();
  }
}