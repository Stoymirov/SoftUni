using System.Reflection;



string[] inputArticle = Console.ReadLine().Split(", ").ToArray();


Article article = new Article(inputArticle[0], inputArticle[1], inputArticle[2]);

int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] command = Console.ReadLine().Split(": ").ToArray();
    switch (command[0]) 
    {
        case "Edit":
            article.Edit(command[1]);
         break;

        case "ChangeAuthor":
            article.ChangeAuthor(command[1]);
            break;

        case "Rename":
            article.Rename(command[1]);
            break;
    }
}

Console.WriteLine(article);





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


    public void Edit(string newContent)
    {
        Content = newContent;
    }

    public void ChangeAuthor(string newAuthor)
    {
        Author = newAuthor;
    }

    public void Rename(string newTitle)
    {
        Title = newTitle;
    }

    public override string ToString()
    {
        return $"{Title} - {Content}: {Author}";
    }
}


