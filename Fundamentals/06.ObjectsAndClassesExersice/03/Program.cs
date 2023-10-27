using System.Reflection;



List<Article> articles = new List<Article>();


int i = int.Parse(Console.ReadLine());


for (int j = 0; j < i; j++)
{
string[] inputArticle = Console.ReadLine().Split(", ").ToArray();

Article article = new Article(inputArticle[0], inputArticle[1], inputArticle[2]);
    articles.Add(article);
}

foreach (Article article in articles)
{
    Console.WriteLine(article);
}





class Article
{

    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }


   

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}