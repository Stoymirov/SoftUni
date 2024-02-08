using P01.Stream_Progress;
using File = P01.Stream_Progress.File;
File file = new File("stefan",3,1024);
Music musicalensymSI = new("az","pesni za u vas",3,2);
StreamProgressInfo info = new(musicalensymSI);
Console.WriteLine(info.CalculateCurrentPercent());