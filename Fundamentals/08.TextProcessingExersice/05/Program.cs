using System.Text;

string titleOfAnArticle = Console.ReadLine();
string contentOfThatArticle = Console.ReadLine();
StringBuilder sb = new StringBuilder();
sb.AppendLine("<h1>");
sb.AppendLine("\t" +titleOfAnArticle);
sb.AppendLine("</h1>");
sb.AppendLine("<article>");
sb.AppendLine("\t" + contentOfThatArticle);
sb.AppendLine("<article>");
string command = String.Empty;
while ((command = Console.ReadLine()) != "end of comment") 
{
    sb.AppendLine("<div>");
    sb.AppendLine("\t" + command);
    sb.AppendLine("</div>");

}
Console.WriteLine(sb);